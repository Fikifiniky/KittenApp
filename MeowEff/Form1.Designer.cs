namespace MeowEff
{
    partial class Meow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meow));
            this.btnInstaMeow = new System.Windows.Forms.Button();
            this.btnMeowStop = new System.Windows.Forms.Button();
            this.btnMeowStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbInterval = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPotvrdit = new System.Windows.Forms.Button();
            this.lbAktualniInt = new System.Windows.Forms.Label();
            this.lbDalsi = new System.Windows.Forms.Label();
            this.btnNapoveda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInstaMeow
            // 
            this.btnInstaMeow.Location = new System.Drawing.Point(11, 104);
            this.btnInstaMeow.Name = "btnInstaMeow";
            this.btnInstaMeow.Size = new System.Drawing.Size(92, 30);
            this.btnInstaMeow.TabIndex = 0;
            this.btnInstaMeow.Text = "InstaMEOW!";
            this.btnInstaMeow.UseVisualStyleBackColor = true;
            this.btnInstaMeow.Click += new System.EventHandler(this.btnInstaMeow_Click);
            // 
            // btnMeowStop
            // 
            this.btnMeowStop.Location = new System.Drawing.Point(11, 161);
            this.btnMeowStop.Name = "btnMeowStop";
            this.btnMeowStop.Size = new System.Drawing.Size(92, 30);
            this.btnMeowStop.TabIndex = 1;
            this.btnMeowStop.Text = "MeowStop :(";
            this.btnMeowStop.UseVisualStyleBackColor = true;
            this.btnMeowStop.Click += new System.EventHandler(this.btnMeowStop_Click);
            // 
            // btnMeowStart
            // 
            this.btnMeowStart.Location = new System.Drawing.Point(11, 45);
            this.btnMeowStart.Name = "btnMeowStart";
            this.btnMeowStart.Size = new System.Drawing.Size(92, 30);
            this.btnMeowStart.TabIndex = 2;
            this.btnMeowStart.Text = "MeowStart!";
            this.btnMeowStart.UseVisualStyleBackColor = true;
            this.btnMeowStart.Click += new System.EventHandler(this.btnMeowStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbInterval
            // 
            this.tbInterval.Location = new System.Drawing.Point(130, 207);
            this.tbInterval.Name = "tbInterval";
            this.tbInterval.Size = new System.Drawing.Size(92, 20);
            this.tbInterval.TabIndex = 3;
            this.tbInterval.TextChanged += new System.EventHandler(this.tbInterval_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Interval (sekundy)";
            // 
            // btnPotvrdit
            // 
            this.btnPotvrdit.Location = new System.Drawing.Point(188, 233);
            this.btnPotvrdit.Name = "btnPotvrdit";
            this.btnPotvrdit.Size = new System.Drawing.Size(75, 23);
            this.btnPotvrdit.TabIndex = 5;
            this.btnPotvrdit.Text = "Potvrdit";
            this.btnPotvrdit.UseVisualStyleBackColor = true;
            this.btnPotvrdit.Click += new System.EventHandler(this.btnPotvrdit_Click);
            // 
            // lbAktualniInt
            // 
            this.lbAktualniInt.AutoSize = true;
            this.lbAktualniInt.Location = new System.Drawing.Point(145, 4);
            this.lbAktualniInt.Name = "lbAktualniInt";
            this.lbAktualniInt.Size = new System.Drawing.Size(0, 13);
            this.lbAktualniInt.TabIndex = 6;
            // 
            // lbDalsi
            // 
            this.lbDalsi.AutoSize = true;
            this.lbDalsi.Location = new System.Drawing.Point(3, 4);
            this.lbDalsi.Name = "lbDalsi";
            this.lbDalsi.Size = new System.Drawing.Size(0, 13);
            this.lbDalsi.TabIndex = 7;
            // 
            // btnNapoveda
            // 
            this.btnNapoveda.Location = new System.Drawing.Point(15, 13);
            this.btnNapoveda.Name = "btnNapoveda";
            this.btnNapoveda.Size = new System.Drawing.Size(26, 26);
            this.btnNapoveda.TabIndex = 8;
            this.btnNapoveda.UseVisualStyleBackColor = true;
            this.btnNapoveda.Click += new System.EventHandler(this.btnNapoveda_Click);
            // 
            // Meow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(269, 262);
            this.Controls.Add(this.btnNapoveda);
            this.Controls.Add(this.lbDalsi);
            this.Controls.Add(this.lbAktualniInt);
            this.Controls.Add(this.btnPotvrdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbInterval);
            this.Controls.Add(this.btnMeowStart);
            this.Controls.Add(this.btnMeowStop);
            this.Controls.Add(this.btnInstaMeow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Meow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInstaMeow;
        private System.Windows.Forms.Button btnMeowStop;
        private System.Windows.Forms.Button btnMeowStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPotvrdit;
        private System.Windows.Forms.Label lbAktualniInt;
        private System.Windows.Forms.Label lbDalsi;
        private System.Windows.Forms.Button btnNapoveda;
    }
}

