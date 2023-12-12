
namespace Tyuiu.GoogeRA.Sprint6.TaskReviev
{
    partial class FormAbout
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
            this.pictureBoxAvatar_GRA = new System.Windows.Forms.PictureBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonOK_GRA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_GRA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_GRA
            // 
            this.pictureBoxAvatar_GRA.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxAvatar_GRA.Name = "pictureBoxAvatar_GRA";
            this.pictureBoxAvatar_GRA.Size = new System.Drawing.Size(156, 239);
            this.pictureBoxAvatar_GRA.TabIndex = 0;
            this.pictureBoxAvatar_GRA.TabStop = false;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(176, 13);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(133, 39);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "Разработчик: Гооге Р. А.\r\nГруппа: ПКТб-23-1\r\n\r\n";
            // 
            // buttonOK_GRA
            // 
            this.buttonOK_GRA.Location = new System.Drawing.Point(247, 203);
            this.buttonOK_GRA.Name = "buttonOK_GRA";
            this.buttonOK_GRA.Size = new System.Drawing.Size(185, 49);
            this.buttonOK_GRA.TabIndex = 2;
            this.buttonOK_GRA.Text = "OK";
            this.buttonOK_GRA.UseVisualStyleBackColor = true;
            this.buttonOK_GRA.Click += new System.EventHandler(this.buttonOK_GRA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 264);
            this.Controls.Add(this.buttonOK_GRA);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.pictureBoxAvatar_GRA);
            this.Name = "FormAbout";
            this.Text = "Справка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_GRA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_GRA;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonOK_GRA;
    }
}