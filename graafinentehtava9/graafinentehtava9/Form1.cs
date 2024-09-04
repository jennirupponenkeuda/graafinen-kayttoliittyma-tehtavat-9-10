namespace graafinentehtava9
{
    public partial class AsteMuunninForm : Form
    {
        public AsteMuunninForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MuunnaBT_Click(object sender, EventArgs e)
        {
            double vastaus;
            double asteet = Convert.ToDouble(AsteetTB.Text);
            if (CelsiusRB.Checked) // Jos valitaan Celsius -asteiksi muuntaminen
            {
                vastaus = asteet * 1.8 + 32; // Muunnetaan Celsius-asteiksi
                VastausLB.Text = asteet + " Fahrenheitia on " + vastaus + " Celsiusta -astetta";
                VastausLB.Visible = true;
            }
            else if (FahrenheitRB.Checked) // Jos valitaan Fahrenheit -asteiksi muuntaminen
                {
                    vastaus = (asteet - 32) / 1.8; //Muunnetaan Fahrenheit -asteiksi
                    VastausLB.Text = asteet + "Celsiusta on" + vastaus + "Fahrenheit -astetta";
                    VastausLB.Visible = true;
                }
            else
                {
                    VastausLB.Text = "Et valinnut muunnettavaa astetta tai antanut lukua";
                    VastausLB.Visible = true;
                }
            }
        }
    }

