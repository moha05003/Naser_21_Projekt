namespace Naser_21_Projekt
{
    public partial class Form1 : Form


    {

        int vinnare;


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
                "\n Lycka till! ");
        }
        //Max v�rde
        int o = 21;

        //Random 
        int minsta = 1;
        int max = 11;
        Random random = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int a = random.Next(minsta, max);
            int b = random.Next(minsta, max);
            int c = random.Next(minsta, max);
            int d = random.Next(minsta, max);
            int j = a + b;
            int k = d + j;
            DialogResult result;
            result = MessageBox.Show("      Du fick : " + j + "        Datorn fick : " + k, "Po�ng", MessageBoxButtons.OK, MessageBoxIcon.None);
            if (result == DialogResult.OK)
            {
                //avbrytningsvariabel
                int w = 1;

                while (w == 1)
                {
                    //Dra flera kort

                    DialogResult result2;
                    result2 = MessageBox.Show("Vill du dra ett kort till?", "Fler kort?", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                    if (result2 == DialogResult.Yes)
                    {
                        int u = random.Next(minsta, max);
                        j = j + u;
                        MessageBox.Show("      Du fick : " + j + "        Datorn fick: " + k, "Po�ng", MessageBoxButtons.OK, MessageBoxIcon.None);
                        if (j > o)
                        {
                            MessageBox.Show("Du gick �ver gr�nsen f�r max antal po�ng, du f�rlorade", "Du f�rlorade", MessageBoxButtons.OK, MessageBoxIcon.None);
                            break;
                        }

                        u = 0;
                    }
                    //Datorn drar kort
                    if (result2 != DialogResult.Yes)
                    {
                        //Kollar om n�gon har vunnit
                        if (k > o)
                        {
                            MessageBox.Show("Datorn gick �ver gr�nsen f�r maxantal po�ng, du vann", "Du vann", MessageBoxButtons.OK, MessageBoxIcon.None);
                            w = 0;
                            break;

                        }
                        else if (k > j)
                        {
                            MessageBox.Show("Datorn fick mer po�ng �n dig, du f�rlorade", "Du f�rlorade", MessageBoxButtons.OK, MessageBoxIcon.None);

                            w = 0;
                            break;

                        }

                        MessageBox.Show("Nu �r det datorns tur att dra kort", "Datorns tur", MessageBoxButtons.OK, MessageBoxIcon.None);
                        while (true)
                        {
                            int v = random.Next(minsta, max);
                            k = v + k;
                            MessageBox.Show("      Du fick: " + j + "        Datorn fick: " + k, "Po�ng", MessageBoxButtons.OK, MessageBoxIcon.None);


                            //Kollar om n�gon har vunnit
                            if (k > o)
                            {
                                MessageBox.Show("Datorn gick �ver gr�nsen f�r maxantal po�ng, du vann", "Du vann", MessageBoxButtons.OK, MessageBoxIcon.None);
                                w = 0;
                                break;

                            }
                            else if (k > j)
                            {
                                MessageBox.Show("Datorn fick mer po�ng �n dig, du f�rlorade", "Du f�rlorade", MessageBoxButtons.OK, MessageBoxIcon.None);

                                w = 0;
                                break; 

                            }


                        }


                    }
                }
            }
        }
  
        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Senaste vinnare �r ", "Senaste vinnare", MessageBoxButtons.OK, MessageBoxIcon.None);

        }
    } 
}