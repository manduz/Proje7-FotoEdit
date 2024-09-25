namespace FotoEdit
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
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBackGround = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnClose);
            this.flowLayoutPanel1.Controls.Add(this.btnBackGround);
            this.flowLayoutPanel1.Controls.Add(this.btnClear);
            this.flowLayoutPanel1.Controls.Add(this.btnShow);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(98, 237);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(424, 28);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Location = new System.Drawing.Point(3, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBackGround
            // 
            this.btnBackGround.AutoSize = true;
            this.btnBackGround.Location = new System.Drawing.Point(77, 3);
            this.btnBackGround.Name = "btnBackGround";
            this.btnBackGround.Size = new System.Drawing.Size(112, 23);
            this.btnBackGround.TabIndex = 1;
            this.btnBackGround.Text = "Set the Background";
            this.btnBackGround.UseVisualStyleBackColor = true;
            this.btnBackGround.Click += new System.EventHandler(this.btnBackGround_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Location = new System.Drawing.Point(195, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(77, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear Picture";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnShow
            // 
            this.btnShow.AutoSize = true;
            this.btnShow.Location = new System.Drawing.Point(278, 3);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(80, 23);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Show Picture";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Resim Dosyaları|*.png;*.jpg;*.jpeg;*.bmp|Tüm Dosyalar|*.*";
            this.openFileDialog1.Title = "SelectPictureFile";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 240);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(52, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "strect";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 219);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(520, 264);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "pictureEdit";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBackGround;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

