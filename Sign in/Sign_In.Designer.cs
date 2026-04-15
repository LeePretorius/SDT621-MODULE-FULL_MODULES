namespace Sign_in
{
    partial class Sign_In
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(92, 47);
            label1.Name = "label1";
            label1.Size = new Size(62, 45);
            label1.TabIndex = 0;
            label1.Text = "Name :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Location = new Point(92, 109);
            label2.Name = "label2";
            label2.Size = new Size(62, 50);
            label2.TabIndex = 1;
            label2.Text = "Surname :";
            // 
            // label3
            // 
            label3.Location = new Point(92, 181);
            label3.Name = "label3";
            label3.Size = new Size(62, 50);
            label3.TabIndex = 2;
            label3.Text = "Id : ";
            // 
            // button1
            // 
            button1.Location = new Point(348, 304);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Continue";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(142, 304);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Location = new Point(92, 278);
            label4.Name = "label4";
            label4.Size = new Size(205, 23);
            label4.TabIndex = 5;
            label4.Text = "If already have account please login :";
            label4.UseMnemonic = false;
            // 
            // Sign_In
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 381);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Sign_In";
            Text = "Sign In";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Label label4;
    }
}
