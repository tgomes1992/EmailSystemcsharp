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
    public partial class Cadastrar_emails : Form
    {
        public Cadastrar_emails()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db= new Dbcusto())
            {
                try
                {
                    db.Emails.Add(new Emails
                    {
                        ContaCetip = long.Parse(comboBox1.Text),
                        Email = textBox1.Text
                    });
                    db.SaveChanges();
                    MessageBox.Show("Cadastro_realizado com Sucesso");
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    
                }
                finally
                {
                    textBox1.Text = "";
                    comboBox1.Text = "";
                    NomeEmissor.Text = "";
                }
              
            }
        }

  

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }



        private void add(object sender, EventArgs e)
        {

        }

        private void Cadastrar_emails_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            using (var db = new Dbcusto())
            {
                var p = db.Participante.ToList();

                foreach (var item in p)
                {
                    comboBox1.Items.Add(item.Conta.ToString());
                }
            }
        }

        private void comboBox1_Leave_1(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

            if(comboBox1.Text != "")
            {
                using (var db = new Dbcusto())
                {
                    var pi = db.Participante
                        .Where(x => x.Conta.ToString().ToLower() == comboBox1.Text.ToLower())
                        .First();

                    NomeEmissor.Text = pi.Nome.ToString();

                }



            }



        }

        private void NomeEmissor_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
    

