using System.Net.Sockets;
using System.Text;

namespace LobbyForm
{
    public partial class Lobby : Form
    {
        private static string myLogin;
        private StreamReader? reader;
        private StreamWriter? writer;
        private const string host = "127.0.0.1";
        private const int port = 8888;

        public Lobby(string login)
        {
            InitializeComponent();
            myLogin = login;
            StartChatAsync();
        }

        private async void SendButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(SendMessageTextBox.Text))
            {
                await SendMessageAsync(writer, SendMessageTextBox.Text);
                SendMessageTextBox.Clear();
            }
        }

        private async void StartChatAsync()
        {
            using (TcpClient client = new TcpClient())
            {
               MessageBox.Show($"Welcome, {myLogin}");

                try
                {
                    await client.ConnectAsync(host, port);
                    reader = new StreamReader(client.GetStream());
                    writer = new StreamWriter(client.GetStream()) { AutoFlush = true };

                    await writer.WriteLineAsync($"LOGIN:{myLogin}");

                    Task.Run(() => ReceiveMessageAsync());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private async Task ReceiveMessageAsync()
        {
            while (true)
            {
                try
                {
                    string? message = await reader.ReadLineAsync();
                    if (string.IsNullOrEmpty(message)) continue;

                    UpdateMessages(message);
                }
                catch
                {
                    break;
                }
            }
        }

        private void UpdateMessages(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(UpdateMessages), message);
            }
            else
            {
                UsersMessageTextBox.AppendText(message + Environment.NewLine);
            }
        }

        private async Task SendMessageAsync(StreamWriter writer, string message)
        {
            // Изменено: Отправка сообщения с логином
            await writer.WriteLineAsync($"{myLogin}: {message}");
        }
    }
}
