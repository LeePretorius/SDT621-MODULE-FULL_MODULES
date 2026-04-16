using System;
using System.Windows.Forms;

namespace Class_Activity
{
    public partial class Form1 : Form
    {
      
        private const string CompanyID = "ECO-2026";
        private double BaseTaxRate = 0.15;

        public Form1()
        {
            InitializeComponent();
        }

      
        private double CalculateEmissions(double distance, double weight, double efficiency)
        {
         
            return (distance * 0.05) + (weight * 0.01) / efficiency;
        }

     
        private void btnCalculate_Click(object sender, EventArgs e)
        {
           
            double dist = double.Parse(txtDistance.Text);
            double wgt = double.Parse(txtWeight.Text);
            double eff = double.Parse(txtEfficiency.Text);

        
            double totalEmission = CalculateEmissions(dist, wgt, eff);

          
            lblResult.Text = $"Company ID: {CompanyID}\n" +
                             $"Base Tax: {BaseTaxRate}\n" +
                             $"Impact Score: {totalEmission:F2}";
        }
    }
}