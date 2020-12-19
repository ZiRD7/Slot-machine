namespace Slot
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.pcbSlot_C = new System.Windows.Forms.PictureBox();
            this.pcbSlot_B = new System.Windows.Forms.PictureBox();
            this.pcbSlot_A = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTxtNPartite = new System.Windows.Forms.Label();
            this.lblTctNVittorie = new System.Windows.Forms.Label();
            this.lbl_nVittorie = new System.Windows.Forms.Label();
            this.lbl_nPartite = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSlot_C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSlot_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSlot_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Yellow;
            this.btnStart.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(89, 308);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(57, 33);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(156, 308);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(50, 33);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pcbSlot_C
            // 
            this.pcbSlot_C.Image = global::Slot.Properties.Resources.imgNumero7;
            this.pcbSlot_C.Location = new System.Drawing.Point(263, 242);
            this.pcbSlot_C.Margin = new System.Windows.Forms.Padding(2);
            this.pcbSlot_C.Name = "pcbSlot_C";
            this.pcbSlot_C.Size = new System.Drawing.Size(48, 56);
            this.pcbSlot_C.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSlot_C.TabIndex = 5;
            this.pcbSlot_C.TabStop = false;
            // 
            // pcbSlot_B
            // 
            this.pcbSlot_B.Image = global::Slot.Properties.Resources.imgNumero7;
            this.pcbSlot_B.Location = new System.Drawing.Point(193, 242);
            this.pcbSlot_B.Margin = new System.Windows.Forms.Padding(2);
            this.pcbSlot_B.Name = "pcbSlot_B";
            this.pcbSlot_B.Size = new System.Drawing.Size(48, 56);
            this.pcbSlot_B.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSlot_B.TabIndex = 4;
            this.pcbSlot_B.TabStop = false;
            // 
            // pcbSlot_A
            // 
            this.pcbSlot_A.Image = global::Slot.Properties.Resources.imgNumero7;
            this.pcbSlot_A.Location = new System.Drawing.Point(124, 242);
            this.pcbSlot_A.Margin = new System.Windows.Forms.Padding(2);
            this.pcbSlot_A.Name = "pcbSlot_A";
            this.pcbSlot_A.Size = new System.Drawing.Size(48, 56);
            this.pcbSlot_A.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSlot_A.TabIndex = 3;
            this.pcbSlot_A.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Slot.Properties.Resources.imgScritta;
            this.pictureBox1.Location = new System.Drawing.Point(103, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblTxtNPartite
            // 
            this.lblTxtNPartite.AutoSize = true;
            this.lblTxtNPartite.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtNPartite.ForeColor = System.Drawing.Color.Orange;
            this.lblTxtNPartite.Location = new System.Drawing.Point(86, 393);
            this.lblTxtNPartite.Name = "lblTxtNPartite";
            this.lblTxtNPartite.Size = new System.Drawing.Size(108, 18);
            this.lblTxtNPartite.TabIndex = 8;
            this.lblTxtNPartite.Text = "N. PARTITE";
            // 
            // lblTctNVittorie
            // 
            this.lblTctNVittorie.AutoSize = true;
            this.lblTctNVittorie.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTctNVittorie.ForeColor = System.Drawing.Color.Orange;
            this.lblTctNVittorie.Location = new System.Drawing.Point(228, 393);
            this.lblTctNVittorie.Name = "lblTctNVittorie";
            this.lblTctNVittorie.Size = new System.Drawing.Size(116, 18);
            this.lblTctNVittorie.TabIndex = 10;
            this.lblTctNVittorie.Text = "N. VITTORIE";
            // 
            // lbl_nVittorie
            // 
            this.lbl_nVittorie.AutoSize = true;
            this.lbl_nVittorie.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nVittorie.Location = new System.Drawing.Point(227, 423);
            this.lbl_nVittorie.Name = "lbl_nVittorie";
            this.lbl_nVittorie.Size = new System.Drawing.Size(49, 19);
            this.lbl_nVittorie.TabIndex = 12;
            this.lbl_nVittorie.Text = "label2";
            // 
            // lbl_nPartite
            // 
            this.lbl_nPartite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nPartite.AutoSize = true;
            this.lbl_nPartite.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nPartite.Location = new System.Drawing.Point(85, 423);
            this.lbl_nPartite.Name = "lbl_nPartite";
            this.lbl_nPartite.Size = new System.Drawing.Size(49, 19);
            this.lbl_nPartite.TabIndex = 13;
            this.lbl_nPartite.Text = "label2";
            this.lbl_nPartite.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTempo
            // 
            this.lblTempo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(123, 483);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(49, 19);
            this.lblTempo.TabIndex = 14;
            this.lblTempo.Text = "label2";
            this.lblTempo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Slot.Properties.Resources.imgSlot;
            this.ClientSize = new System.Drawing.Size(431, 574);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.lbl_nPartite);
            this.Controls.Add(this.lbl_nVittorie);
            this.Controls.Add(this.lblTctNVittorie);
            this.Controls.Add(this.lblTxtNPartite);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pcbSlot_C);
            this.Controls.Add(this.pcbSlot_B);
            this.Controls.Add(this.pcbSlot_A);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSlot_C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSlot_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSlot_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.PictureBox pcbSlot_A;
        private System.Windows.Forms.PictureBox pcbSlot_B;
        private System.Windows.Forms.PictureBox pcbSlot_C;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTxtNPartite;
        private System.Windows.Forms.Label lblTctNVittorie;
        private System.Windows.Forms.Label lbl_nVittorie;
        private System.Windows.Forms.Label lbl_nPartite;
        private System.Windows.Forms.Label lblTempo;
    }
}

