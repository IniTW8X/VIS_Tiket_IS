namespace VIS_projekt
{
    partial class LhutaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.prihlasenTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.kontrolaBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.notifikovatBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(589, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Přihlášen jako:";
            // 
            // prihlasenTxt
            // 
            this.prihlasenTxt.Enabled = false;
            this.prihlasenTxt.Location = new System.Drawing.Point(672, 12);
            this.prihlasenTxt.Name = "prihlasenTxt";
            this.prihlasenTxt.Size = new System.Drawing.Size(100, 20);
            this.prihlasenTxt.TabIndex = 3;
            this.prihlasenTxt.Text = "Petr Macák";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.notifikovatBtn);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.kontrolaBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 434);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kontrola dodržení lhůt tiketů";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(649, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Zrušit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kontrolaBtn
            // 
            this.kontrolaBtn.Location = new System.Drawing.Point(15, 32);
            this.kontrolaBtn.Name = "kontrolaBtn";
            this.kontrolaBtn.Size = new System.Drawing.Size(117, 23);
            this.kontrolaBtn.TabIndex = 0;
            this.kontrolaBtn.Text = "Zkontrolovat nyní";
            this.kontrolaBtn.UseVisualStyleBackColor = true;
            this.kontrolaBtn.Click += new System.EventHandler(this.kontrolaBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 77);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(394, 342);
            this.listBox1.TabIndex = 1;
            // 
            // notifikovatBtn
            // 
            this.notifikovatBtn.Location = new System.Drawing.Point(454, 120);
            this.notifikovatBtn.Name = "notifikovatBtn";
            this.notifikovatBtn.Size = new System.Drawing.Size(75, 23);
            this.notifikovatBtn.TabIndex = 2;
            this.notifikovatBtn.Text = "Notifikovat";
            this.notifikovatBtn.UseVisualStyleBackColor = true;
            this.notifikovatBtn.Click += new System.EventHandler(this.notifikovatBtn_Click);
            // 
            // LhutaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prihlasenTxt);
            this.Name = "LhutaForm";
            this.Text = "Kontrola lhůt tiketů";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prihlasenTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button notifikovatBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button kontrolaBtn;
    }
}