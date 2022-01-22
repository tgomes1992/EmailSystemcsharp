using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class EditarParticipantes : Form
    {
        public EditarParticipantes()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void EditarParticipantes_Load(object sender, EventArgs e)
        {
            using (var db = new Dbcusto())
            {
                var item  = db.Participante.ToList();

                foreach(var participante in item)
                {
                    comboBox1.Items.Add(participante.Conta.ToString());
                }
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            using (var db = new Dbcusto())
            {
                var item = db.Participante
                    .Where(x => x.Conta.ToString() == comboBox1.Text)
                    .First();

                nome.Text = item.Nome;
                contacetip.Text = item.Conta.ToString();
                containterna.Text = item.Containterna;
                cnpj.Text = item.Cnpj;

            }
        }

        private void Cadastro_Click(object sender, EventArgs e)
        {
            using (var db = new Dbcusto())
            {
                var item = db.Participante
                    .Where(x => x.Conta.ToString() == comboBox1.Text)
                    .First();

                item.Nome = nome.Text;
                item.Conta = long.Parse(contacetip.Text);
                item.Containterna = containterna.Text;
                item.Cnpj = cnpj.Text;

                db.SaveChanges();


                nome.Text = "";
                contacetip.Text = "";
                containterna.Text = "";
                cnpj.Text = "";
                this.Refresh();

            }


        }    }  
}
