using Microsoft.VisualBasic.ApplicationServices;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Xml;
using Newtonsoft.Json;

namespace LocalChatServer
{
    public partial class MyServer : Form
    {
        public static bool isServerRun = false;
        private static List<User> users;
        private static string filePath = "users.json";
        private ServerObject server = new ServerObject();
        public MyServer()
        {
            InitializeComponent();
            LoadUsersFromFile();
        }

        private async void StartServerButton_Click(object sender, EventArgs e)
        {
            if (!isServerRun)
            {
                isServerRun = true;
                ServerStatusLable.Text = "online";
                StartServerButton.Text = "Stop Server";
                await server.ListenAsync();
            }
            else
            {
                isServerRun = false;
                ServerStatusLable.Text = "offline";
                StartServerButton.Text = "Start Server";
                server.Disconnect();
            }
        }
        class User
        {
            public string Login { get; set; }
            public string Password { get; set; }
            public string Email { get; set; }
        }
        static void LoadUsersFromFile()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                users = JsonConvert.DeserializeObject<List<User>>(json);
            }
            else
            {
                users = new List<User>();
            }
        }
        static void SaveUsersToFile()
        {
            string json = JsonConvert.SerializeObject(users, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
        static bool CheckUserLogAndPass(string login, string pass)
        {
            foreach (var user in users)
            {
                if (user.Login == login && user.Password == pass)
                {
                    return true;
                }
            }
            return false;
        }
        static void AddUser(string login, string email, string pasword)
        {
            users.Add(new User { Login = login, Email = email, Password = pasword });
            SaveUsersToFile();
        }

        class ServerObject
        {
            TcpListener tcpListener = new TcpListener(IPAddress.Any, 8888);
            List<ClientObject> clients = new List<ClientObject>();
            protected internal void RemoveConnection(string id)
            {
                ClientObject? client = clients.FirstOrDefault(c => c.Id == id);
                if (client != null) clients.Remove(client);
                client?.Close();
            }
            protected internal async Task ListenAsync()
            {
                try
                {
                    tcpListener.Start();
                    Console.WriteLine("Server is up and running. Waiting for connections...");

                    while (true)
                    {
                        TcpClient tcpClient = await tcpListener.AcceptTcpClientAsync();
                        NetworkStream stream = tcpClient.GetStream();
                        byte[] buffer = new byte[512];
                        int byteCount = stream.Read(buffer, 0, buffer.Length);
                        string data = Encoding.UTF8.GetString(buffer, 0, byteCount);

                        string[] splitData = data.Split(':');
                        string comandData = splitData[0];
                        if (comandData == "CHECK")
                        {
                            byte[] response = Encoding.UTF8.GetBytes(CheckUserLogAndPass(splitData[1], splitData[2]) ? "OK" : "FAIL");
                            stream.Write(response, 0, response.Length);
                        }
                        else if (comandData == "LOGIN")
                        {

                            ClientObject clientObject = new ClientObject(tcpClient, this, splitData[1]);
                            clients.Add(clientObject);
                            Task.Run(clientObject.ProcessAsync);
                        }
                        else if (comandData == "REGISTER")
                        {
                            string answer;
                            if (!CheckUserLogAndPass(splitData[1], splitData[3]))
                            {
                                AddUser(splitData[1], splitData[2], splitData[3]);
                                answer = "Users successfully registered!";
                            }
                            else
                                answer = "Login or password allready used!";

                            byte[] response = Encoding.UTF8.GetBytes(answer);
                            stream.Write(response, 0, response.Length);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Disconnect();
                }
            }
            protected internal async Task BroadcastMessageAsync(string message, string id)
            {
                foreach (var client in clients)
                {
                    if (client.Id != id)
                    {
                        await client.Writer.WriteLineAsync(message);
                        await client.Writer.FlushAsync();
                    }
                }
            }
            protected internal void Disconnect()
            {
                foreach (var client in clients)
                {
                    client.Close();
                }
                tcpListener.Stop();
            }
        }
         class ClientObject
         {
             protected internal string Id { get; } = Guid.NewGuid().ToString();
             protected internal StreamWriter Writer { get; }
             protected internal StreamReader Reader { get; }
             protected internal string userLogin { get; }

             TcpClient client;
             ServerObject server; 

             public ClientObject(TcpClient tcpClient, ServerObject serverObject, string login)
             {
                 client = tcpClient;
                 server = serverObject;
                 userLogin = login;
                 var stream = client.GetStream();
                 Reader = new StreamReader(stream);
                 Writer = new StreamWriter(stream);
             }

             public async Task ProcessAsync()
             {
                 try
                 {
                     string? message = $"{userLogin} logged into the chat room";
                     
                     await server.BroadcastMessageAsync(message, Id);
                     while (true)
                     {
                         try
                         {
                             message = await Reader.ReadLineAsync();
                             if (message == null) continue;
                             await server.BroadcastMessageAsync(message, Id); 
                         }
                         catch
                         {
                             message = $"{userLogin} exited the chat room";
                             await server.BroadcastMessageAsync(message, Id);
                             break;
                         }
                     }
                 }
                 catch (Exception e)
                 {
                     Console.WriteLine(e.Message);
                 }
                 finally
                 {
                     server.RemoveConnection(Id);
                 }
             }
             protected internal void Close()
             {
                 Writer.Close();
                 Reader.Close();
                 client.Close();
             }
         }
    }
}
