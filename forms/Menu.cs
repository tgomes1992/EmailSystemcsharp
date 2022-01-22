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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void importar_custos_cetip_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();                     
            using (Dbcusto db = new Dbcusto())

            {
                try
                {
                    using (var fs = File.OpenRead(ofd.FileName))
                    {
                        StreamReader sr = new StreamReader(fs);
                        string line;
                        var per = long.Parse(sr.ReadLine().Split(";")[0]);
                        var t = db.CustoCetip
                            .Where(c => c.Periodo == per);
                        db.CustoCetip.RemoveRange(t);
                        db.SaveChanges();

                        try
                        {
                            while ((line = sr.ReadLine()) != null)
                            {
                                db.CustoCetip.Add(new CustoCetip
                                {
                                    Periodo = long.Parse(line.Split(";")[0]),
                                    ContaCetip = long.Parse(line.Split(";")[1]),
                                    Nome = line.Split(";")[2],
                                    Valor = double.Parse(line.Split(";")[3])
                                });
                            }
                            db.SaveChanges();
                            MessageBox.Show("Importação Concluida");
                        }
                        catch (Exception ex)
                        {
                            
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                catch(Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void Cadastrar_participantes_Click(object sender, EventArgs e)
        {
            CadastroParticipantes m = new CadastroParticipantes();
            m.Show();

        }

        private void editar_participantes_Click(object sender, EventArgs e)
        {
            EditarParticipantes m = new EditarParticipantes();
            m.Show();  
        }

        private void Cadastrar_emails_Click(object sender, EventArgs e)
        {
            Cadastrar_emails m = new Cadastrar_emails();
            m.Show();

        }
    }
}
