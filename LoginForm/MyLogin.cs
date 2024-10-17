using LobbyForm;
using RegistrationForm;

using System.Net.Sockets;
using System.Text;

namespace LoginForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LoginTextBox.Text) || string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                MessageBox.Show("Поля Login и Password не могут быть пустыми!!!");
                return;
            }
            string UserLogin = LoginTextBox.Text;
            string UserPassword = PasswordTextBox.Text;
            try
            {
                if (AuthenticateUser(UserLogin, UserPassword))
                {
                    Lobby myLobby = new Lobby(UserLogin);
                    myLobby.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неверный Login или Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            Registr regForm = new Registr();
            regForm.Show();
        }

        private bool AuthenticateUser(string Login, string Password)
        {
            try
            {
                TcpClient client = new TcpClient("127.0.0.1", 8888);
                NetworkStream stream = client.GetStream();

                string data = $"CHECK:{Login}:{Password}";
                byte[] buffer = Encoding.UTF8.GetBytes(data);
                stream.Write(buffer, 0, buffer.Length);

                byte[] responseBuffer = new byte[512];
                int byteCount = stream.Read(responseBuffer, 0, responseBuffer.Length);
                string response = Encoding.UTF8.GetString(responseBuffer, 0, byteCount);

                client.Close();

                return response == "OK";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения к серверу: " + ex.Message);
                return false;
            }
        }
    }
}
