namespace ManagerApp
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Account invalid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (username == "Admin" && password == "123@123")
            {
                MessageBox.Show("Login Success", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormHome home = new FormHome();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Account invalid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Are you sure ?";
            string title = "Message";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(message, title, buttons, icon);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}