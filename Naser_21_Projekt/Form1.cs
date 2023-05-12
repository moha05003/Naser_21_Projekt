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
                "\n Lycka till! ");
        }
        //Max värde
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
            result = MessageBox.Show("      Du fick : " + j + "        Datorn fick : " + k, "Poäng", MessageBoxButtons.OK, MessageBoxIcon.None);
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
                        MessageBox.Show("      Du fick : " + j + "        Datorn fick: " + k, "Poäng", MessageBoxButtons.OK, MessageBoxIcon.None);
                        if (j > o)
                        {
                            MessageBox.Show("Du gick över gränsen för max antal poäng, du förlorade", "Du förlorade", MessageBoxButtons.OK, MessageBoxIcon.None);
                            break;
                        }

                        u = 0;
                    }
                    //Datorn drar kort
                    if (result2 != DialogResult.Yes)
                    {
                        //Kollar om någon har vunnit
                        if (k > o)
                        {
                            MessageBox.Show("Datorn gick över gränsen för maxantal poäng, du vann", "Du vann", MessageBoxButtons.OK, MessageBoxIcon.None);
                            w = 0;
                            break;

                        }
                        else if (k > j)
                        {
                            MessageBox.Show("Datorn fick mer poäng än dig, du förlorade", "Du förlorade", MessageBoxButtons.OK, MessageBoxIcon.None);

                            w = 0;
                            break;

                        }

                        MessageBox.Show("Nu är det datorns tur att dra kort", "Datorns tur", MessageBoxButtons.OK, MessageBoxIcon.None);
                        while (true)
                        {
                            int v = random.Next(minsta, max);
                            k = v + k;
                            MessageBox.Show("      Du fick: " + j + "        Datorn fick: " + k, "Poäng", MessageBoxButtons.OK, MessageBoxIcon.None);


                            //Kollar om någon har vunnit
                            if (k > o)
                            {
                                MessageBox.Show("Datorn gick över gränsen för maxantal poäng, du vann", "Du vann", MessageBoxButtons.OK, MessageBoxIcon.None);
                                w = 0;
                                break;

                            }
                            else if (k > j)
                            {
                                MessageBox.Show("Datorn fick mer poäng än dig, du förlorade", "Du förlorade", MessageBoxButtons.OK, MessageBoxIcon.None);

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

            MessageBox.Show("Senaste vinnare är ", "Senaste vinnare", MessageBoxButtons.OK, MessageBoxIcon.None);

        }
    } 
}