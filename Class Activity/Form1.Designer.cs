namespace Class_Activity
{
    partial class Form1
    {
    
        private System.ComponentModel.IContainer components = null;

       
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

      
        private void InitializeComponent()
        {
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.txtEfficiency = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblDist = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblWgt = new System.Windows.Forms.Label();
            this.lblEff = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
          
            this.txtDistance.Location = new System.Drawing.Point(224, 67);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(212, 20);
            this.txtDistance.TabIndex = 0;
           
            this.txtEfficiency.Location = new System.Drawing.Point(224, 158);
            this.txtEfficiency.Name = "txtEfficiency";
            this.txtEfficiency.Size = new System.Drawing.Size(212, 20);
            this.txtEfficiency.TabIndex = 2;
           
            this.txtWeight.Location = new System.Drawing.Point(224, 113);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(212, 20);
            this.txtWeight.TabIndex = 3;
          
            this.lblDist.AutoSize = true;
            this.lblDist.Location = new System.Drawing.Point(113, 67);
            this.lblDist.Name = "lblDist";
            this.lblDist.Size = new System.Drawing.Size(75, 13);
            this.lblDist.TabIndex = 4;
            this.lblDist.Text = "Distance (km):";
          
            this.btnCalculate.Location = new System.Drawing.Point(116, 230);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate Impact";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
           
            this.lblWgt.AutoSize = true;
            this.lblWgt.Location = new System.Drawing.Point(113, 113);
            this.lblWgt.Name = "lblWgt";
            this.lblWgt.Size = new System.Drawing.Size(96, 13);
            this.lblWgt.TabIndex = 6;
            this.lblWgt.Text = "Cargo Weight (kg):";
            
            this.lblEff.AutoSize = true;
            this.lblEff.Location = new System.Drawing.Point(87, 165);
            this.lblEff.Name = "lblEff";
            this.lblEff.Size = new System.Drawing.Size(131, 13);
            this.lblEff.TabIndex = 7;
            this.lblEff.Text = "Fuel Efficiency (L/100km):";
        
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(221, 235);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(111, 13);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "Results will show here";
         
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblEff);
            this.Controls.Add(this.lblWgt);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblDist);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtEfficiency);
            this.Controls.Add(this.txtDistance);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.TextBox txtEfficiency;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblDist;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblWgt;
        private System.Windows.Forms.Label lblEff;
        private System.Windows.Forms.Label lblResult;
    }
}

