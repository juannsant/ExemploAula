namespace ExemploAula
{
    public partial class frmtellog : Form
    {
        public frmtellog()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnlogar_Click(object sender, EventArgs e)
        {
            if (txtusu.Text == "Admin" && txtsenha.Text == "123456")
            {
                MessageBox.Show("Usuário logado com sucesso");
                txtusu.Clear();
                txtsenha.Clear();
            }
            else
            {
                MessageBox.Show("Usuário/senha invalido");
                txtusu.Clear();
                txtsenha.Clear();
            }

            Hide();
            frmtelini ini = new frmtelini();
            ini.Show();
        }
    }
}
