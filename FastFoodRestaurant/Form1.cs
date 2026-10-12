using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodRestaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void FriesTb_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Datelb.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelb.Text = DateTime.Now.ToLongTimeString();
        }

        private void FriesCB_CheckedChanged(object sender, EventArgs e)
        {
            if (FriesCB.Checked == true)
            {
                FriesTb.Enabled = true;
            }
            if (FriesCB.Checked == false)
            {
                FriesTb.Enabled = false;
                FriesTb.Text = "0";
            }

        }

        private void BurgerCB_CheckedChanged(object sender, EventArgs e)
        {
            if (BurgerCB.Checked == true)
            {
                BurgerTb.Enabled = true;
            }
            if (BurgerCB.Checked == false)
            {
                BurgerTb.Enabled = false;
                BurgerTb.Text = "0";
            }
        }

        private void SaladCB_CheckedChanged(object sender, EventArgs e)
        {
            if (SaladCB.Checked == true)
            {
                SaladTb.Enabled = true;
            }
            if (SaladCB.Checked == false)
            {
                SaladTb.Enabled = false;
                SaladTb.Text = "0";
            }
        }

        private void SandwichCB_CheckedChanged(object sender, EventArgs e)
        {
            if (SandwichCB.Checked == true)
            {
                SandwichTb.Enabled = true;
            }
            if (SandwichCB.Checked == false)
            {
                SandwichTb.Enabled = false;
                SandwichTb.Text = "0";
            }
        }

        private void ChickenCB_CheckedChanged(object sender, EventArgs e)
        {
            if (ChickenCB.Checked == true)
            {
                ChickenTb.Enabled = true;
            }
            if (ChickenCB.Checked == false)
            {
                ChickenTb.Enabled = false;
                ChickenTb.Text = "0";
            }
        }

        private void CheeseCB_CheckedChanged(object sender, EventArgs e)
        {
            if (CheeseCB.Checked == true)
            {
                CheeseTb.Enabled = true;
            }
            if (CheeseCB.Checked == false)
            {
                CheeseTb.Enabled = false;
                CheeseTb.Text = "0";
            }
        }

        private void TeaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (TeaCB.Checked == true)
            {
                TeaTb.Enabled = true;
            }
            if (TeaCB.Checked == false)
            {
                TeaTb.Enabled = false;
                TeaTb.Text = "0";
            }
        }

        private void ColaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (ColaCB.Checked == true)
            {
                ColaTb.Enabled = true;
            }
            if (ColaCB.Checked == false)
            {
                ColaTb.Enabled = false;
                ColaTb.Text = "0";
            }
        }

        private void WaterCB_CheckedChanged(object sender, EventArgs e)
        {
            if (WaterCB.Checked == true)
            {
                WaterTb.Enabled = true;
            }
            if (WaterCB.Checked == false)
            {
                WaterTb.Enabled = false;
                WaterTb.Text = "0";
            }
        }

        private void ChocolateCB_CheckedChanged(object sender, EventArgs e)
        {
            if (ChocolateCB.Checked == true)
            {
                ChocolateTb.Enabled = true;
            }
            if (ChocolateCB.Checked == false)
            {
                ChocolateTb.Enabled = false;
                ChocolateTb.Text = "0";
            }
        }

        private void PancakesCB_CheckedChanged(object sender, EventArgs e)
        {
            if (PancakesCB.Checked == true)
            {
                PancakesTb.Enabled = true;
            }
            if (PancakesCB.Checked == false)
            {
                PancakesTb.Enabled = false;
                PancakesTb.Text = "0";
            }
        }

        private void OrangeCB_CheckedChanged(object sender, EventArgs e)
        {

            if (OrangeCB.Checked == true)
            {
                OrangeTb.Enabled = true;
            }
            if (OrangeCB.Checked == false)
            {
                OrangeTb.Enabled = false;
                OrangeTb.Text = "0";
            }
        }

        private void Closelb_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
        //Declare unit price to different meal and drinks
        double friesup = 50, burgerup = 80, saladup = 100, sandwichup = 75, cheeseup = 80, chickenup = 100 ;

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(Reccipetb.Text + " Subtotal: "+Subtotallbl.Text+"  Tax: "+taxlbl.Text+"  Grand Total: "+Grdtotallbl.Text,new Font("Century Gothic",12,FontStyle.Regular),Brushes.Blue,new Point(130));
            
            /* e.Graphics.DrawString: Cela indique que nous utilisons l'objet Graphics pour dessiner du texte.

            (Reccipetb.Text + " Subtotal: "+Subtotallbl.Text+" Tax: "+taxlbl.Text+" Grand Total: "+Grdtotallbl.Text): Ceci est la chaîne de texte que nous voulons dessiner. Il utilise les valeurs des différents contrôles de texte (Reccipetb, Subtotallbl, taxlbl, Grdtotallbl) et les concatène avec des chaînes de texte supplémentaires pour obtenir le texte final à dessiner.

            new Font("Century Gothic", 12, FontStyle.Regular): Cela spécifie la police utilisée pour dessiner le texte. Il crée un nouvel objet Font en utilisant la police "Century Gothic", une taille de 12 points et un style régulier.

            Brushes.Blue: Cela spécifie la couleur utilisée pour dessiner le texte. Dans ce cas, la couleur est définie sur bleu en utilisant l'objet prédéfini Brushes.Blue.

            new Point(130): Cela spécifie les coordonnées de départ où le texte sera dessiné. Dans ce cas, le texte sera dessiné à la position x = 130, y = 0.*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FriesCB.Checked = false;
            BurgerCB.Checked = false;
            ChickenCB.Checked = false;
            SaladCB.Checked = false;
            SandwichCB.Checked = false;
            CheeseCB.Checked = false;
            WaterCB.Checked = false;
            TeaCB.Checked = false;
            ColaCB.Checked = false;
            ChocolateCB.Checked = false;
            PancakesCB.Checked = false;
            OrangeCB.Checked = false;
        }

        double waterup = 15, teaup = 15, colaup = 20, chocolateup = 25, pancakesup = 30, orangeup = 25;
        //Declare variable to hold total price for each drinks and meals
        double friestp, burgertp, saladtp, sandwichtp, cheesetp, watertp, teatp, colatp, chocolatetp, chickentp, pancakestp, orangetp;
        double Subtotal = 0, tax, grdtotal;
        private void button2_Click(object sender, EventArgs e)
        {
            friestp = friesup * Convert.ToDouble(FriesTb.Text);
            burgertp = burgerup * Convert.ToDouble(BurgerTb.Text);
            chickentp = chickenup * Convert.ToDouble(ChickenTb.Text);
            saladtp = saladup * Convert.ToDouble(SaladTb.Text);
            sandwichtp = sandwichup * Convert.ToDouble(SandwichTb.Text);
            cheesetp = cheeseup * Convert.ToDouble(CheeseTb.Text);
            watertp = waterup * Convert.ToDouble(WaterTb.Text);
            teatp = teaup * Convert.ToDouble(TeaTb.Text);
            colatp = colaup * Convert.ToDouble(ColaTb.Text);
            chocolatetp = chocolateup * Convert.ToDouble(ChocolateTb.Text);
            pancakestp = pancakesup * Convert.ToDouble(PancakesTb.Text);
            orangetp = orangeup * Convert.ToDouble(OrangeTb.Text);
            //Add products on the receipt
            Reccipetb.Clear();
            Subtotal = 0;
            Reccipetb.AppendText(Environment.NewLine);
            Reccipetb.AppendText("\t\t\tCODESPACE RESTAURENT\t\t"+Datelb.Text + Environment.NewLine);
            Reccipetb.AppendText("\t\t\t***************************"+Environment.NewLine);
            if (FriesCB.Checked == true)
            {
                Reccipetb.AppendText("\tFries:\t" + friestp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + friestp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (BurgerCB.Checked == true)
            {
                Reccipetb.AppendText("\tBurger:\t" + burgertp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + burgertp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (ChickenCB.Checked == true)
            {
                Reccipetb.AppendText("\tChicken:\t" + chickentp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + chickentp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (SaladCB.Checked == true)
            {
                Reccipetb.AppendText("\tSalad:\t" + saladtp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + saladtp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (SandwichCB.Checked == true)
            {
                Reccipetb.AppendText("\tSandwich:\t" + sandwichtp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + sandwichtp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (CheeseCB.Checked == true)
            {
                Reccipetb.AppendText("\tCheese:\t" + cheesetp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + cheesetp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (WaterCB.Checked == true)
            {
                Reccipetb.AppendText("\tWater:\t" + watertp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + watertp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (TeaCB.Checked == true)
            {
                Reccipetb.AppendText("\tTea:\t" + teatp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + teatp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (ColaCB.Checked == true)
            {
                Reccipetb.AppendText("\tCola:\t" + colatp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + colatp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (ChocolateCB.Checked == true)
            {
                Reccipetb.AppendText("\tChocolate:\t" + chocolatetp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + chocolatetp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (PancakesCB.Checked == true)
            {
                Reccipetb.AppendText("\tPancakes:\t" + pancakestp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + pancakestp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (OrangeCB.Checked == true)
            {
                Reccipetb.AppendText("\tOrange:\t" + orangetp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + orangetp;
                Subtotallbl.Text = "" + Subtotal;
            }
            tax = Subtotal * 0.16;//16% tax calculation to be changed based on your palce's tax regulations
            grdtotal = Subtotal + tax;
            taxlbl.Text = "RS" + tax;
            Grdtotallbl.Text = "Rs" + grdtotal;
        }
    }
}
