namespace KeygenApp
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
            this.lblImagePath = new System.Windows.Forms.Label();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.lblKey = new System.Windows.Forms.Label();
            this.btnGenerateKey = new System.Windows.Forms.Button();
            this.cboOffset = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboRadius = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtKey = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(132, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblImagePath
            // 
            this.lblImagePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblImagePath.Location = new System.Drawing.Point(31, 47);
            this.lblImagePath.Name = "lblImagePath";
            this.lblImagePath.Size = new System.Drawing.Size(396, 24);
            this.lblImagePath.TabIndex = 1;
            this.lblImagePath.Text = "Image path";
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.AutoSize = true;
            this.btnSelectImage.Location = new System.Drawing.Point(12, 12);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(79, 23);
            this.btnSelectImage.TabIndex = 2;
            this.btnSelectImage.Text = "Select Image";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // lblKey
            // 
            this.lblKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblKey.Location = new System.Drawing.Point(132, 421);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(222, 24);
            this.lblKey.TabIndex = 3;
            this.lblKey.Text = "key";
            // 
            // btnGenerateKey
            // 
            this.btnGenerateKey.AutoSize = true;
            this.btnGenerateKey.Location = new System.Drawing.Point(179, 368);
            this.btnGenerateKey.Name = "btnGenerateKey";
            this.btnGenerateKey.Size = new System.Drawing.Size(82, 23);
            this.btnGenerateKey.TabIndex = 4;
            this.btnGenerateKey.Text = "Generate Key";
            this.btnGenerateKey.UseVisualStyleBackColor = true;
            this.btnGenerateKey.Click += new System.EventHandler(this.btnGenerateKey_Click);
            // 
            // cboOffset
            // 
            this.cboOffset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOffset.FormattingEnabled = true;
            this.cboOffset.Location = new System.Drawing.Point(242, 276);
            this.cboOffset.Name = "cboOffset";
            this.cboOffset.Size = new System.Drawing.Size(112, 21);
            this.cboOffset.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Choose Offset";
            // 
            // cboRadius
            // 
            this.cboRadius.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRadius.FormattingEnabled = true;
            this.cboRadius.Location = new System.Drawing.Point(242, 312);
            this.cboRadius.Name = "cboRadius";
            this.cboRadius.Size = new System.Drawing.Size(112, 21);
            this.cboRadius.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Radius";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(306, 368);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.Color.Green;
            this.resultLabel.Location = new System.Drawing.Point(435, 425);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(35, 20);
            this.resultLabel.TabIndex = 11;
            this.resultLabel.Text = "Idle";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(360, 421);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(67, 23);
            this.progressBar1.TabIndex = 12;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(12, 325);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(51, 20);
            this.txtKey.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 484);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboRadius);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboOffset);
            this.Controls.Add(this.btnGenerateKey);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.lblImagePath);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "GLCM Key generation application";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblImagePath;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Button btnGenerateKey;
        private System.Windows.Forms.ComboBox cboOffset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboRadius;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtKey;
    }
}

