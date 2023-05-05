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
            MessageBox.Show("H�r �r reglerna f�r Black Jack-spelet:\n " 

                +
                "\n1) M�let med Black Jack �r att f� en hand med ett totalt v�rde av 21 eller s� n�ra 21 som m�jligt utan att g� �ver.\n"
                +
                "\n2) Korten har f�ljande v�rden: Ess r�knas som 1 eller 11, kl�dda kort(knekt, dam och kung) r�knas som 10 och �vriga kort r�knas som sitt numeriska v�rde.\n"
                +
                "\n3) Spelet b�rjar med att spelaren och dealern f�r tv� kort var.Spelaren kan v�lja att ta fler kort(hit) eller stanna med sin nuvarande hand(stand).\n"
                +
                "\n4) Om spelaren g�r �ver 21 s� f�rlorar denne automatiskt.Efter att spelaren har stannat s� �r det dealerns tur att spela.\n"
                +
                "\n5) Dealern m�ste ta kort tills denne har minst 17 po�ng.Om dealern g�r �ver 21 s� vinner spelaren.\n"
                +
                "\n6) Om spelaren har en hand med h�gre totalt v�rde �n dealern utan att g� �ver 21 s� vinner spelaren.\n"
                +
                "\n7) Om dealern har en h�gre hand �n spelaren eller om spelaren g�r �ver 21 s� vinner dealern.\n"
                +
                "\n Lycka till! ") ; 
        }
    }
}