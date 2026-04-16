using System;
using System.Windows.Forms;

namespace Class_Activity
{
    public partial class Form1 : Form
    {
        // 1. CLASS-LEVEL SCOPE
        private const string CompanyID = "ECO-2026";
        private double BaseTaxRate = 0.15;

        public Form1()
        {
            InitializeComponent();
        }

        // 2. PRIVATE METHOD FOR LOGIC
        private double CalculateEmissions(double distance, double weight, double efficiency)
        {
            // Formula: (Distance * 0.05) + (Weight * 0.01) / Efficiency
            return (distance * 0.05) + (weight * 0.01) / efficiency;
        }

        // 3. BUTTON CLICK EVENT
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Capture inputs from the TextBoxes you renamed
            double dist = double.Parse(txtDistance.Text);
            double wgt = double.Parse(txtWeight.Text);
            double eff = double.Parse(txtEfficiency.Text);

            // Get result from our method
            double totalEmission = CalculateEmissions(dist, wgt, eff);

            // Display results in the Label you renamed
            lblResult.Text = $"Company ID: {CompanyID}\n" +
                             $"Base Tax: {BaseTaxRate}\n" +
                             $"Impact Score: {totalEmission:F2}";
        }
    }
}