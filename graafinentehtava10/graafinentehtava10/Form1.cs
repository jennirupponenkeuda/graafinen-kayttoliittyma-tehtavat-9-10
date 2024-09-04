namespace graafinentehtava10
{
    public partial class BMIForm : Form
    {
        public BMIForm()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            double paino = 0, pituus = 0;
            paino = Convert.ToDouble(PainoTB.Text); //haetaan tieto textboxista nimeltä PainoTB
            pituus = Convert.ToDouble(PituusTB.Text); // haetaan tieto textboxista nimeltä PituusTB
            double bmi = Math.Round(paino / (pituus * pituus), 2); //Uusi double bmi, joka pyöristetään kahteen desimaaliin, siksi ,2 lopussa.
            if (bmi < 18.5)
            {
                VastausLB.Text = "Painoindeksisi on " + bmi; // Muista laittaa tekstin jälkeen lainausmerkkien sisällä välilyönti tekstin sujuvoittamiseksi!
                VastausLB.ForeColor = Color.Aqua; //Tässä määritellään tekstin väri VastausLB:lle
                KuvausLB.Text = "Alipaino";
                KuvausLB.ForeColor = Color.Aqua; //Tässä määritellään tekstin väri KuvausLB:lle
                KuvausLB.Visible = true; // Ota KuvausLB esiin, sillä se on aluksi piilossa (muutoin tekstisi ei näy)
            }
            else if (bmi < 25) // else if, eli jos myös tämä toteutuu, näytetään tämä teksi, ei edellistä!
            {
                VastausLB.Text = "Painoindeksisi on " + bmi;
                VastausLB.ForeColor = Color.Green;
                KuvausLB.Text = "Normaalipaino";
                KuvausLB.ForeColor = Color.Green;
                KuvausLB.Visible = true;
            }
            else if (bmi < 40)
            {
                VastausLB.Text = "Painoindeksisi on " + bmi;
                VastausLB.ForeColor = Color.Gold;
                KuvausLB.Text = "Ylipaino";
                KuvausLB.ForeColor = Color.Gold;
                KuvausLB.Visible = true;

            }
            else // Tämä toteutuu, kun mikään ylläolevistä ei toteudu
            {
                VastausLB.Text = "Painoindeksisi on " + bmi;
                VastausLB.ForeColor = Color.Red;
                KuvausLB.Text = "Huomattava ylipaino";
                KuvausLB.ForeColor = Color.Red;
                KuvausLB.Visible = true;
            }
        }

        private void VastausLB_Click(object sender, EventArgs e)
        {

        }
    }
}
