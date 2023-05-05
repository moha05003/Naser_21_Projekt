namespace Naser_21_Projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult resultat = MessageBox.Show("Vill du avslut spelet?", "Avsluta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultat == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Här är reglerna för Black Jack-spelet:\n " 

                +
                "\n1) Målet med Black Jack är att få en hand med ett totalt värde av 21 eller så nära 21 som möjligt utan att gå över.\n"
                +
                "\n2) Korten har följande värden: Ess räknas som 1 eller 11, klädda kort(knekt, dam och kung) räknas som 10 och övriga kort räknas som sitt numeriska värde.\n"
                +
                "\n3) Spelet börjar med att spelaren och dealern får två kort var.Spelaren kan välja att ta fler kort(hit) eller stanna med sin nuvarande hand(stand).\n"
                +
                "\n4) Om spelaren går över 21 så förlorar denne automatiskt.Efter att spelaren har stannat så är det dealerns tur att spela.\n"
                +
                "\n5) Dealern måste ta kort tills denne har minst 17 poäng.Om dealern går över 21 så vinner spelaren.\n"
                +
                "\n6) Om spelaren har en hand med högre totalt värde än dealern utan att gå över 21 så vinner spelaren.\n"
                +
                "\n7) Om dealern har en högre hand än spelaren eller om spelaren går över 21 så vinner dealern.\n"
                +
                "\n Lycka till! ") ; 
        }
    }
}