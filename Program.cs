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

Segue cobran�a referente ao Custo CETIP no valor de R$365,61  do Cliente CONCESSIONARIA ROTA DO ATLANTICO S.A. emitido neste m�s.

CONCESSIONARIA ROTA DO ATLANTICO S.A.- CNPJ 13799190000109
Institui��o: 111
Ag.: 1
Conta Interna:  704420-9

Diante do exposto acima, lembramos que o custo mensal cobrado pela B3, referente a manuten��o do ativo depositado na clearing, dever� ser enviado pela Emissora a Oliveira Trust at� o 8� dia �til e o saldo existente em sua conta ser� exclusivamente utilizado para esse fim.
Comunicamos tamb�m que ser� realizada a recusa do d�bito no caso de insufici�ncia de saldo na conta de titularidade da Emissora mantida junto � Oliveira Trust, uma vez que a Emissora � a �nica respons�vel pela quita��o do d�bito com a B3. Nestes casos, a Emissora dever� realizar a quita��o do d�bito diretamente junto � B3 atrav�s de dep�sito e/ou outras formas a serem informadas por eles.
Por fim, informamos que a Oliveira Trust n�o emite nenhuma fatura ou documento fiscal para estes tipos de custos, pois esta atribui��o � de responsabilidade �nica e exclusivamente da B3
Obs: a transfer�ncia dever� ser realizada sob a mesma titularidade (mesma Raz�o Social e CNPJ)Qualquer d�vida, ficamos � disposi��o.

Att,
EQUIPE DE ESCRITURA��O E LIQUIDA��O
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

