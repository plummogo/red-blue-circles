namespace PirosKekKorongok
{
 partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nudMelysegKorlat = new System.Windows.Forms.NumericUpDown();
            this.lblMelysegKorlat = new System.Windows.Forms.Label();
            this.btnBacktrack = new System.Windows.Forms.Button();
            this.btnSzelessegi = new System.Windows.Forms.Button();
            this.btn_bal = new System.Windows.Forms.Button();
            this.btn_jobb = new System.Windows.Forms.Button();
            this.btnMelysegi = new System.Windows.Forms.Button();
            this.cbxKorfigyeles = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAAlg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMelysegKorlat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 501);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // nudMelysegKorlat
            // 
            this.nudMelysegKorlat.Location = new System.Drawing.Point(709, 54);
            this.nudMelysegKorlat.Name = "nudMelysegKorlat";
            this.nudMelysegKorlat.Size = new System.Drawing.Size(48, 20);
            this.nudMelysegKorlat.TabIndex = 1;
            // 
            // lblMelysegKorlat
            // 
            this.lblMelysegKorlat.AutoSize = true;
            this.lblMelysegKorlat.Location = new System.Drawing.Point(619, 57);
            this.lblMelysegKorlat.Name = "lblMelysegKorlat";
            this.lblMelysegKorlat.Size = new System.Drawing.Size(75, 13);
            this.lblMelysegKorlat.TabIndex = 2;
            this.lblMelysegKorlat.Text = "Mélységkorlát:";
            // 
            // btnBacktrack
            // 
            this.btnBacktrack.Location = new System.Drawing.Point(622, 83);
            this.btnBacktrack.Name = "btnBacktrack";
            this.btnBacktrack.Size = new System.Drawing.Size(135, 23);
            this.btnBacktrack.TabIndex = 3;
            this.btnBacktrack.Text = "Backtrack";
            this.btnBacktrack.UseVisualStyleBackColor = true;
            this.btnBacktrack.Click += new System.EventHandler(this.buttonBacktrack_Click);
            // 
            // btnSzelessegi
            // 
            this.btnSzelessegi.Location = new System.Drawing.Point(38, 45);
            this.btnSzelessegi.Name = "btnSzelessegi";
            this.btnSzelessegi.Size = new System.Drawing.Size(135, 23);
            this.btnSzelessegi.TabIndex = 4;
            this.btnSzelessegi.Text = "Szélességi kereső";
            this.btnSzelessegi.UseVisualStyleBackColor = true;
            this.btnSzelessegi.Click += new System.EventHandler(this.btnSzelessegi_Click);
            // 
            // btn_bal
            // 
            this.btn_bal.Location = new System.Drawing.Point(32, 522);
            this.btn_bal.Name = "btn_bal";
            this.btn_bal.Size = new System.Drawing.Size(75, 23);
            this.btn_bal.TabIndex = 5;
            this.btn_bal.Text = "Balra";
            this.btn_bal.UseVisualStyleBackColor = true;
            this.btn_bal.Click += new System.EventHandler(this.btn_bal_Click);
            // 
            // btn_jobb
            // 
            this.btn_jobb.Location = new System.Drawing.Point(144, 522);
            this.btn_jobb.Name = "btn_jobb";
            this.btn_jobb.Size = new System.Drawing.Size(75, 23);
            this.btn_jobb.TabIndex = 6;
            this.btn_jobb.Text = "Jobbra";
            this.btn_jobb.UseVisualStyleBackColor = true;
            this.btn_jobb.Click += new System.EventHandler(this.btn_jobb_Click);
            // 
            // btnMelysegi
            // 
            this.btnMelysegi.Location = new System.Drawing.Point(38, 94);
            this.btnMelysegi.Name = "btnMelysegi";
            this.btnMelysegi.Size = new System.Drawing.Size(135, 23);
            this.btnMelysegi.TabIndex = 7;
            this.btnMelysegi.Text = "Mélységi kereső";
            this.btnMelysegi.UseVisualStyleBackColor = true;
            this.btnMelysegi.Click += new System.EventHandler(this.btnMelysegi_Click);
            // 
            // cbxKorfigyeles
            // 
            this.cbxKorfigyeles.AutoSize = true;
            this.cbxKorfigyeles.Checked = true;
            this.cbxKorfigyeles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxKorfigyeles.Location = new System.Drawing.Point(6, 19);
            this.cbxKorfigyeles.Name = "cbxKorfigyeles";
            this.cbxKorfigyeles.Size = new System.Drawing.Size(96, 17);
            this.cbxKorfigyeles.TabIndex = 8;
            this.cbxKorfigyeles.Text = "Kell körfigyelés";
            this.cbxKorfigyeles.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAAlg);
            this.groupBox1.Controls.Add(this.cbxKorfigyeles);
            this.groupBox1.Controls.Add(this.btnSzelessegi);
            this.groupBox1.Controls.Add(this.btnMelysegi);
            this.groupBox1.Location = new System.Drawing.Point(580, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 186);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gráfkeresők";
            // 
            // btnAAlg
            // 
            this.btnAAlg.Location = new System.Drawing.Point(38, 145);
            this.btnAAlg.Name = "btnAAlg";
            this.btnAAlg.Size = new System.Drawing.Size(135, 23);
            this.btnAAlg.TabIndex = 9;
            this.btnAAlg.Text = "A-algoritmus";
            this.btnAAlg.UseVisualStyleBackColor = true;
            this.btnAAlg.Click += new System.EventHandler(this.btnAAlg_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(822, 557);
            this.Controls.Add(this.btn_jobb);
            this.Controls.Add(this.btn_bal);
            this.Controls.Add(this.btnBacktrack);
            this.Controls.Add(this.lblMelysegKorlat);
            this.Controls.Add(this.nudMelysegKorlat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMelysegKorlat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

  }

  #endregion

   
  private System.Windows.Forms.PictureBox pictureBox1;
  private System.Windows.Forms.Label lblMelysegKorlat;
  private System.Windows.Forms.NumericUpDown nudMelysegKorlat;
  private System.Windows.Forms.Button btnBacktrack;
  private System.Windows.Forms.Button btnSzelessegi;
  private System.Windows.Forms.Button btn_bal;
  private System.Windows.Forms.Button btn_jobb;
  private System.Windows.Forms.Button btnMelysegi;
  private System.Windows.Forms.CheckBox cbxKorfigyeles;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.Button btnAAlg;
 }
}

