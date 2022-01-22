namespace WinFormsApp1
{
    public partial class CadastroParticipantes : Form
    {
        public CadastroParticipantes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_Click(object sender, EventArgs e)
        {
            using (var db = new Dbcusto())
            {
                try
                {
                    //Participante participante = new Participante();
                    //participante.Nome = nome.Text;
                    //participante.Cnpj = cnpj.Text;
                    //participante.Containterna = containterna.Text;
                    //participante.Conta = long.Parse(contacetip.Text);

                    db.Add(new Participante
                    {
                        Nome = nome.Text, 
                        Cnpj = cnpj.Text,
                        Containterna=containterna.Text, 
                        Conta   = long.Parse(contacetip.Text)
                    });
                    db.SaveChanges();
                    MessageBox.Show("Participante Cadastrado");
                    nome.Text = "";
                    cnpj.Text = "";
                    containterna.Text = "";
                    contacetip.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.ToString());
                }



            }
        
        }

    }

       
}