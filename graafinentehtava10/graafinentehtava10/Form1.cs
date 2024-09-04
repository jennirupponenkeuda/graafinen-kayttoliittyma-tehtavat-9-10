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
            paino = Convert.ToDouble(PainoTB.Text); //haetaan tieto textboxista nimelt� PainoTB
            pituus = Convert.ToDouble(PituusTB.Text); // haetaan tieto textboxista nimelt� PituusTB
            double bmi = Math.Round(paino / (pituus * pituus), 2); //Uusi double bmi, joka py�ristet��n kahteen desimaaliin, siksi ,2 lopussa.
            if (bmi < 18.5)
            {
                VastausLB.Text = "Painoindeksisi on " + bmi; // Muista laittaa tekstin j�lkeen lainausmerkkien sis�ll� v�lily�nti tekstin sujuvoittamiseksi!
                VastausLB.ForeColor = Color.Aqua; //T�ss� m��ritell��n tekstin v�ri VastausLB:lle
                KuvausLB.Text = "Alipaino";
                KuvausLB.ForeColor = Color.Aqua; //T�ss� m��ritell��n tekstin v�ri KuvausLB:lle
                KuvausLB.Visible = true; // Ota KuvausLB esiin, sill� se on aluksi piilossa (muutoin tekstisi ei n�y)
            }
            else if (bmi < 25) // else if, eli jos my�s t�m� toteutuu, n�ytet��n t�m� teksi, ei edellist�!
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
            else // T�m� toteutuu, kun mik��n yll�olevist� ei toteudu
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
