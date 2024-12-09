namespace BarlangokGUI
{
    partial class Form1
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
            lbnev = new Label();
            label3 = new Label();
            label4 = new Label();
            txid = new TextBox();
            txhossz = new TextBox();
            txmely = new TextBox();
            btsrc = new Button();
            btsave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 26);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "azonosító:";
            // 
            // lbnev
            // 
            lbnev.AutoSize = true;
            lbnev.Location = new Point(68, 64);
            lbnev.Name = "lbnev";
            lbnev.Size = new Size(78, 15);
            lbnev.TabIndex = 1;
            lbnev.Text = "Barlang neve:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 101);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 2;
            label3.Text = "Hosszúság:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 134);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Mélység:";
            // 
            // txid
            // 
            txid.Location = new Point(135, 23);
            txid.Name = "txid";
            txid.Size = new Size(84, 23);
            txid.TabIndex = 4;
            // 
            // txhossz
            // 
            txhossz.Location = new Point(135, 93);
            txhossz.Name = "txhossz";
            txhossz.Size = new Size(84, 23);
            txhossz.TabIndex = 5;
            // 
            // txmely
            // 
            txmely.Location = new Point(135, 126);
            txmely.Name = "txmely";
            txmely.Size = new Size(84, 23);
            txmely.TabIndex = 6;
            // 
            // btsrc
            // 
            btsrc.Location = new Point(286, 23);
            btsrc.Name = "btsrc";
            btsrc.Size = new Size(104, 23);
            btsrc.TabIndex = 7;
            btsrc.Text = "Barlang keresése";
            btsrc.UseVisualStyleBackColor = true;
            btsrc.Click += btsrc_Click;
            // 
            // btsave
            // 
            btsave.Location = new Point(286, 113);
            btsave.Name = "btsave";
            btsave.Size = new Size(104, 23);
            btsave.TabIndex = 8;
            btsave.Text = "Adatok mentése";
            btsave.UseVisualStyleBackColor = true;
            btsave.Click += btsave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btsave);
            Controls.Add(btsrc);
            Controls.Add(txmely);
            Controls.Add(txhossz);
            Controls.Add(txid);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbnev);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Barlangok";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbnev;
        private Label label3;
        private Label label4;
        private TextBox txid;
        private TextBox txhossz;
        private TextBox txmely;
        private Button btsrc;
        private Button btsave;
    }
}
