

using System.Net.Sockets;
using System.Text;

namespace RegistrationForm
{
    public partial class Registr : Form
    {
        public Registr()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LoginTextBox.Text) ||
                string.IsNullOrWhiteSpace(EmailTextBox.Text) ||
                string.IsNullOrWhiteSpace(PasswordTextBox.Text) ||
                string.IsNullOrWhiteSpace(ConfirmPasswordTextBox.Text))
            {
                MessageBox.Show("��� ���� ������ ���� ���������!");
                return;
            }

            if (PasswordTextBox.Text != ConfirmPasswordTextBox.Text)
            {
                MessageBox.Show("������ �� ���������!");
                return;
            }

            // �������� ������ �� ������ ��� �����������
            if (RegisterUser(LoginTextBox.Text, EmailTextBox.Text, PasswordTextBox.Text))
            {
                MessageBox.Show("����������� ������ �������!");
                this.Close(); // ��������� ����� �����������
            }
            else
            {
                MessageBox.Show("������ �����������. ���������� �����.");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool RegisterUser(string login, string email, string password)
        {
            try
            {
                TcpClient client = new TcpClient("127.0.0.1", 8888);
                NetworkStream stream = client.GetStream();

                string data = $"REGISTER:{login}:{email}:{password}";
                byte[] buffer = Encoding.UTF8.GetBytes(data);
                stream.Write(buffer, 0, buffer.Length);

                byte[] responseBuffer = new byte[512];
                int byteCount = stream.Read(responseBuffer, 0, responseBuffer.Length);
                string response = Encoding.UTF8.GetString(responseBuffer, 0, byteCount);

                client.Close();
                if (response == "OK") 
                {
                    MessageBox.Show("�������� �����������");
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("������ ����������� � �������: " + ex.Message);
                return false;
            }
        }
    }
}
