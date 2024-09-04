namespace graafinentehtava10
{
    partial class BMIForm
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
            PainoLB = new Label();
            PituusLB = new Label();
            PainoTB = new TextBox();
            PituusTB = new TextBox();
            LaskeBT = new Button();
            VastausLB = new Label();
            KuvausLB = new Label();
            SuspendLayout();
            // 
            // PainoLB
            // 
            PainoLB.AutoSize = true;
            PainoLB.Location = new Point(34, 44);
            PainoLB.Margin = new Padding(4, 0, 4, 0);
            PainoLB.Name = "PainoLB";
            PainoLB.Size = new Size(102, 22);
            PainoLB.TabIndex = 0;
            PainoLB.Text = "Anna paino:";
            // 
            // PituusLB
            // 
            PituusLB.AutoSize = true;
            PituusLB.Location = new Point(34, 91);
            PituusLB.Margin = new Padding(4, 0, 4, 0);
            PituusLB.Name = "PituusLB";
            PituusLB.Size = new Size(107, 22);
            PituusLB.TabIndex = 1;
            PituusLB.Text = "Anna pituus:";
            // 
            // PainoTB
            // 
            PainoTB.Location = new Point(236, 44);
            PainoTB.Margin = new Padding(4);
            PainoTB.Name = "PainoTB";
            PainoTB.Size = new Size(141, 29);
            PainoTB.TabIndex = 2;
            // 
            // PituusTB
            // 
            PituusTB.Location = new Point(236, 87);
            PituusTB.Margin = new Padding(4);
            PituusTB.Name = "PituusTB";
            PituusTB.Size = new Size(141, 29);
            PituusTB.TabIndex = 3;
            // 
            // LaskeBT
            // 
            LaskeBT.Location = new Point(34, 160);
            LaskeBT.Margin = new Padding(4);
            LaskeBT.Name = "LaskeBT";
            LaskeBT.Size = new Size(307, 72);
            LaskeBT.TabIndex = 4;
            LaskeBT.Text = "Laske painoindeksi";
            LaskeBT.UseVisualStyleBackColor = true;
            LaskeBT.Click += LaskeBT_Click;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Location = new Point(34, 276);
            VastausLB.Margin = new Padding(4, 0, 4, 0);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(68, 22);
            VastausLB.TabIndex = 5;
            VastausLB.Text = "Vastaus";
            VastausLB.Click += VastausLB_Click;
            // 
            // KuvausLB
            // 
            KuvausLB.AutoSize = true;
            KuvausLB.Location = new Point(34, 307);
            KuvausLB.Name = "KuvausLB";
            KuvausLB.Size = new Size(66, 22);
            KuvausLB.TabIndex = 6;
            KuvausLB.Text = "Kuvaus";
            KuvausLB.Visible = false;
            // 
            // BMIForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 348);
            Controls.Add(KuvausLB);
            Controls.Add(VastausLB);
            Controls.Add(LaskeBT);
            Controls.Add(PituusTB);
            Controls.Add(PainoTB);
            Controls.Add(PituusLB);
            Controls.Add(PainoLB);
            Font = new Font("Noto Serif", 11.9999981F);
            Margin = new Padding(4);
            Name = "BMIForm";
            Text = "Painoindeksilaskuri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PainoLB;
        private Label PituusLB;
        private TextBox PainoTB;
        private TextBox PituusTB;
        private Button LaskeBT;
        private Label VastausLB;
        private Label KuvausLB;
    }
}
