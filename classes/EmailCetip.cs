using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mime;
using System.Net;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using System.Globalization;


namespace WinFormsApp1.classes
{
    public class EmailCetip
    {
        private MimeMessage _message;
           private string _body;


        private string _criar_assunto()
        {
            string s = @$"COBRANÇA CUSTO MENSAL CETIP - {DateTime.Now.ToString("dd/MM/yyyy")}";
            return s;
        }



        private TextPart _criar_corpo()
        {
            TextPart b = new TextPart("plain")
            {
                Text = _body


            //Text = @"Prezados,

            //        Segue cobrança referente ao Custo CETIP no valor de R$ ${valor}  do Cliente BSBIOS IND. E COM. DE BIOD. SUL BR S/A emitido neste mês.

            //        ${nome}- CNPJ ${cnpj}
            //        Instituição: 111
            //        Ag.: 1
            //        Conta Interna:  ${conta_interna}

            //        Diante do exposto acima, lembramos que o custo mensal cobrado pela B3, referente a manutenção do ativo depositado na clearing, deverá ser enviado pela Emissora a Oliveira Trust até o 8º dia útil e o saldo existente em sua conta será exclusivamente utilizado para esse fim.
            //        Comunicamos também que será realizada a recusa do débito no caso de insuficiência de saldo na conta de titularidade da Emissora mantida junto à Oliveira Trust, uma vez que a Emissora é a única responsável pela quitação do débito com a B3. 
            //        Nestes casos, a Emissora deverá realizar a quitação do débito diretamente junto à B3 através de depósito e/ou outras formas a serem informadas por eles.
            //        Por fim, informamos que a Oliveira Trust não emite nenhuma fatura ou documento fiscal para estes tipos de custos, pois esta atribuição é de responsabilidade única e exclusivamente da B3
            //        Obs: a transferência deverá ser realizada sob a mesma titularidade (mesma Razão Social e CNPJ)Qualquer dúvida, ficamos à disposição.

            //        Att,
            //        EQUIPE DE ESCRITURAÇÃO E LIQUIDAÇÃO
            //        Tel (21) 3514-0000
            //        Fax (21) 3514-0099
            //        www.oliveiratrust.com.br
            //        sqescrituracao@oliveiratrust.com.br
            //"

        };

            return b;
        }


        public EmailCetip(string body) {

            _body = body;

            
            _message = new MimeMessage();
            _message.From.Add(new MailboxAddress("Thiago Gomes", "thiago.conceicao@oliveiratrust.com.br"));
            _message.To.Add(new MailboxAddress("Thiago Gomes", "thiago.conceicao@oliveiratrust.com.br"));
            _message.Subject = _criar_assunto();
            _message.Body = _criar_corpo();

        }

        public void sendemail()
        {


            try
            {
                var client = new SmtpClient();
                {
                    client.Connect("smtp.gmail.com", 465);
                    client.Authenticate("login", "senha");

                    client.Send(_message);
                    client.Disconnect(true);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
 
        }



    }
}
