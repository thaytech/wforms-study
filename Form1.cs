namespace LOGIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textUsuario.Text.Equals("thay") && textSenha.Text.Equals("123"))
                {
                    var menu = new MenuRestrito();
                    menu.Show();

                    this.Visible = false;

                }
                else
                {
                    MessageBox.Show("Desculpe",
                        "Usuário ou senha incorretos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    textUsuario.Focus();
                    textSenha.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Desculpe",
                    ex.Message,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void textUsuario_Enter(object sender, EventArgs e)
        {
            textUsuario.BackColor = Color.White;
        }

        private void textUsuario_Leave(object sender, EventArgs e)
        {
            textUsuario.BackColor = Color.LightYellow;
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            textSenha.BackColor = Color.LightYellow;
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            textSenha.BackColor = Color.White;

        }

        private void textUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            int tecla = Convert.ToInt32(e.KeyChar);
            if (!char.IsLetterOrDigit(e.KeyChar) && tecla != 08)
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas letra ou números");

                textUsuario.SelectionStart = 0;
                textUsuario.SelectionLength = textUsuario.Text.Length;

                textUsuario.Focus();

            }
        }
    }
}
