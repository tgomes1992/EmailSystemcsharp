namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.


            string t = @"Prezados,

Segue cobrança referente ao Custo CETIP no valor de R$365,61  do Cliente CONCESSIONARIA ROTA DO ATLANTICO S.A. emitido neste mês.

CONCESSIONARIA ROTA DO ATLANTICO S.A.- CNPJ 13799190000109
Instituição: 111
Ag.: 1
Conta Interna:  704420-9

Diante do exposto acima, lembramos que o custo mensal cobrado pela B3, referente a manutenção do ativo depositado na clearing, deverá ser enviado pela Emissora a Oliveira Trust até o 8º dia útil e o saldo existente em sua conta será exclusivamente utilizado para esse fim.
Comunicamos também que será realizada a recusa do débito no caso de insuficiência de saldo na conta de titularidade da Emissora mantida junto à Oliveira Trust, uma vez que a Emissora é a única responsável pela quitação do débito com a B3. Nestes casos, a Emissora deverá realizar a quitação do débito diretamente junto à B3 através de depósito e/ou outras formas a serem informadas por eles.
Por fim, informamos que a Oliveira Trust não emite nenhuma fatura ou documento fiscal para estes tipos de custos, pois esta atribuição é de responsabilidade única e exclusivamente da B3
Obs: a transferência deverá ser realizada sob a mesma titularidade (mesma Razão Social e CNPJ)Qualquer dúvida, ficamos à disposição.

Att,
EQUIPE DE ESCRITURAÇÃO E LIQUIDAÇÃO
Tel (21) 3514-0000
Fax (21) 3514-0099
www.oliveiratrust.com.br
sqescrituracao@oliveiratrust.com.br
...
                        ";


            var mail = new WinFormsApp1.classes.EmailCetip(t);


            mail.sendemail();

            //ApplicationConfiguration.Initialize();
            //Application.Run(new Menu());
        }
    }
}

