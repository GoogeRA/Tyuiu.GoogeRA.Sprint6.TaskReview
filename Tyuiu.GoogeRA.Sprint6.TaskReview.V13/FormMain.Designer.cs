
namespace Tyuiu.GoogeRA.Sprint6.TaskReview.V13
{
    partial class FormMain
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
            this.panelOpen_GRA = new System.Windows.Forms.Panel();
            this.buttonGen_GRA = new System.Windows.Forms.Button();
            this.buttonStart_GRA = new System.Windows.Forms.Button();
            this.panelMatrix_GRA = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_GRA = new System.Windows.Forms.GroupBox();
            this.dataGridViewRes_GRA = new System.Windows.Forms.DataGridView();
            this.panelText_GRA = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxL_GRA = new System.Windows.Forms.TextBox();
            this.groupBoxK_GRA = new System.Windows.Forms.GroupBox();
            this.textBoxK_GRA = new System.Windows.Forms.TextBox();
            this.groupBoxStrok_GRA = new System.Windows.Forms.GroupBox();
            this.textBoxStroki_GRA = new System.Windows.Forms.TextBox();
            this.groupBoxStolp_GRA = new System.Windows.Forms.GroupBox();
            this.textBoxStolp_GRA = new System.Windows.Forms.TextBox();
            this.groupBoxResult_GRA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_GRA = new System.Windows.Forms.TextBox();
            this.textBoxC_GRA = new System.Windows.Forms.TextBox();
            this.groupBoxC_GRA = new System.Windows.Forms.GroupBox();
            this.groupBoxN1_GRA = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxN1_GRA = new System.Windows.Forms.TextBox();
            this.textBoxN2_GRA = new System.Windows.Forms.TextBox();
            this.panelOpen_GRA.SuspendLayout();
            this.panelMatrix_GRA.SuspendLayout();
            this.groupBoxOutPut_GRA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_GRA)).BeginInit();
            this.panelText_GRA.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxK_GRA.SuspendLayout();
            this.groupBoxStrok_GRA.SuspendLayout();
            this.groupBoxStolp_GRA.SuspendLayout();
            this.groupBoxResult_GRA.SuspendLayout();
            this.groupBoxC_GRA.SuspendLayout();
            this.groupBoxN1_GRA.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOpen_GRA
            // 
            this.panelOpen_GRA.Controls.Add(this.buttonGen_GRA);
            this.panelOpen_GRA.Controls.Add(this.buttonStart_GRA);
            this.panelOpen_GRA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOpen_GRA.Location = new System.Drawing.Point(0, 0);
            this.panelOpen_GRA.Name = "panelOpen_GRA";
            this.panelOpen_GRA.Size = new System.Drawing.Size(800, 100);
            this.panelOpen_GRA.TabIndex = 0;
            // 
            // buttonGen_GRA
            // 
            this.buttonGen_GRA.Location = new System.Drawing.Point(186, 13);
            this.buttonGen_GRA.Name = "buttonGen_GRA";
            this.buttonGen_GRA.Size = new System.Drawing.Size(108, 81);
            this.buttonGen_GRA.TabIndex = 1;
            this.buttonGen_GRA.Text = "Матрица";
            this.buttonGen_GRA.UseVisualStyleBackColor = true;
            this.buttonGen_GRA.Click += new System.EventHandler(this.buttonGen_GRA_Click);
            // 
            // buttonStart_GRA
            // 
            this.buttonStart_GRA.Location = new System.Drawing.Point(36, 12);
            this.buttonStart_GRA.Name = "buttonStart_GRA";
            this.buttonStart_GRA.Size = new System.Drawing.Size(124, 81);
            this.buttonStart_GRA.TabIndex = 0;
            this.buttonStart_GRA.Text = "выполнить";
            this.buttonStart_GRA.UseVisualStyleBackColor = true;
            this.buttonStart_GRA.Click += new System.EventHandler(this.buttonStart_GRA_Click);
            // 
            // panelMatrix_GRA
            // 
            this.panelMatrix_GRA.Controls.Add(this.groupBoxOutPut_GRA);
            this.panelMatrix_GRA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMatrix_GRA.Location = new System.Drawing.Point(0, 100);
            this.panelMatrix_GRA.Name = "panelMatrix_GRA";
            this.panelMatrix_GRA.Size = new System.Drawing.Size(800, 236);
            this.panelMatrix_GRA.TabIndex = 1;
            // 
            // groupBoxOutPut_GRA
            // 
            this.groupBoxOutPut_GRA.Controls.Add(this.dataGridViewRes_GRA);
            this.groupBoxOutPut_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_GRA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_GRA.Name = "groupBoxOutPut_GRA";
            this.groupBoxOutPut_GRA.Size = new System.Drawing.Size(800, 236);
            this.groupBoxOutPut_GRA.TabIndex = 1;
            this.groupBoxOutPut_GRA.TabStop = false;
            this.groupBoxOutPut_GRA.Text = "Результат";
            // 
            // dataGridViewRes_GRA
            // 
            this.dataGridViewRes_GRA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRes_GRA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewRes_GRA.Name = "dataGridViewRes_GRA";
            this.dataGridViewRes_GRA.RowHeadersVisible = false;
            this.dataGridViewRes_GRA.Size = new System.Drawing.Size(794, 217);
            this.dataGridViewRes_GRA.TabIndex = 0;
            this.dataGridViewRes_GRA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRes_GRA_CellContentClick);
            // 
            // panelText_GRA
            // 
            this.panelText_GRA.Controls.Add(this.groupBox2);
            this.panelText_GRA.Controls.Add(this.groupBoxN1_GRA);
            this.panelText_GRA.Controls.Add(this.groupBoxC_GRA);
            this.panelText_GRA.Controls.Add(this.groupBoxResult_GRA);
            this.panelText_GRA.Controls.Add(this.groupBox1);
            this.panelText_GRA.Controls.Add(this.groupBoxK_GRA);
            this.panelText_GRA.Controls.Add(this.groupBoxStrok_GRA);
            this.panelText_GRA.Controls.Add(this.groupBoxStolp_GRA);
            this.panelText_GRA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelText_GRA.Location = new System.Drawing.Point(0, 336);
            this.panelText_GRA.Name = "panelText_GRA";
            this.panelText_GRA.Size = new System.Drawing.Size(800, 113);
            this.panelText_GRA.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxL_GRA);
            this.groupBox1.Location = new System.Drawing.Point(312, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 40);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Диапозн maxVal:";
            // 
            // textBoxL_GRA
            // 
            this.textBoxL_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxL_GRA.Location = new System.Drawing.Point(3, 16);
            this.textBoxL_GRA.Name = "textBoxL_GRA";
            this.textBoxL_GRA.Size = new System.Drawing.Size(105, 20);
            this.textBoxL_GRA.TabIndex = 4;
            this.textBoxL_GRA.TextChanged += new System.EventHandler(this.textBoxL_GRA_TextChanged);
            // 
            // groupBoxK_GRA
            // 
            this.groupBoxK_GRA.Controls.Add(this.textBoxK_GRA);
            this.groupBoxK_GRA.Location = new System.Drawing.Point(309, 10);
            this.groupBoxK_GRA.Name = "groupBoxK_GRA";
            this.groupBoxK_GRA.Size = new System.Drawing.Size(114, 45);
            this.groupBoxK_GRA.TabIndex = 5;
            this.groupBoxK_GRA.TabStop = false;
            this.groupBoxK_GRA.Text = "Диапозон minVal:";
            // 
            // textBoxK_GRA
            // 
            this.textBoxK_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxK_GRA.Location = new System.Drawing.Point(3, 16);
            this.textBoxK_GRA.Name = "textBoxK_GRA";
            this.textBoxK_GRA.Size = new System.Drawing.Size(108, 20);
            this.textBoxK_GRA.TabIndex = 3;
            this.textBoxK_GRA.TextChanged += new System.EventHandler(this.textBoxK_GRA_TextChanged);
            // 
            // groupBoxStrok_GRA
            // 
            this.groupBoxStrok_GRA.Controls.Add(this.textBoxStolp_GRA);
            this.groupBoxStrok_GRA.Location = new System.Drawing.Point(13, 54);
            this.groupBoxStrok_GRA.Name = "groupBoxStrok_GRA";
            this.groupBoxStrok_GRA.Size = new System.Drawing.Size(136, 48);
            this.groupBoxStrok_GRA.TabIndex = 2;
            this.groupBoxStrok_GRA.TabStop = false;
            this.groupBoxStrok_GRA.Text = "Строки:";
            // 
            // textBoxStroki_GRA
            // 
            this.textBoxStroki_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxStroki_GRA.Location = new System.Drawing.Point(3, 16);
            this.textBoxStroki_GRA.Name = "textBoxStroki_GRA";
            this.textBoxStroki_GRA.Size = new System.Drawing.Size(130, 20);
            this.textBoxStroki_GRA.TabIndex = 0;
            this.textBoxStroki_GRA.TextChanged += new System.EventHandler(this.textBoxStroki_GRA_TextChanged);
            // 
            // groupBoxStolp_GRA
            // 
            this.groupBoxStolp_GRA.Controls.Add(this.textBoxStroki_GRA);
            this.groupBoxStolp_GRA.Location = new System.Drawing.Point(13, 7);
            this.groupBoxStolp_GRA.Name = "groupBoxStolp_GRA";
            this.groupBoxStolp_GRA.Size = new System.Drawing.Size(136, 48);
            this.groupBoxStolp_GRA.TabIndex = 1;
            this.groupBoxStolp_GRA.TabStop = false;
            this.groupBoxStolp_GRA.Text = "Столбцы:";
            // 
            // textBoxStolp_GRA
            // 
            this.textBoxStolp_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxStolp_GRA.Location = new System.Drawing.Point(3, 16);
            this.textBoxStolp_GRA.Name = "textBoxStolp_GRA";
            this.textBoxStolp_GRA.Size = new System.Drawing.Size(130, 20);
            this.textBoxStolp_GRA.TabIndex = 0;
            this.textBoxStolp_GRA.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // groupBoxResult_GRA
            // 
            this.groupBoxResult_GRA.Controls.Add(this.textBoxResult_GRA);
            this.groupBoxResult_GRA.Location = new System.Drawing.Point(589, 10);
            this.groupBoxResult_GRA.Name = "groupBoxResult_GRA";
            this.groupBoxResult_GRA.Size = new System.Drawing.Size(156, 46);
            this.groupBoxResult_GRA.TabIndex = 7;
            this.groupBoxResult_GRA.TabStop = false;
            this.groupBoxResult_GRA.Text = "Результат";
            // 
            // textBoxResult_GRA
            // 
            this.textBoxResult_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_GRA.Location = new System.Drawing.Point(3, 16);
            this.textBoxResult_GRA.Name = "textBoxResult_GRA";
            this.textBoxResult_GRA.Size = new System.Drawing.Size(150, 20);
            this.textBoxResult_GRA.TabIndex = 0;
            this.textBoxResult_GRA.TextChanged += new System.EventHandler(this.textBoxResult_GRA_TextChanged);
            // 
            // textBoxC_GRA
            // 
            this.textBoxC_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxC_GRA.Location = new System.Drawing.Point(3, 16);
            this.textBoxC_GRA.Name = "textBoxC_GRA";
            this.textBoxC_GRA.Size = new System.Drawing.Size(108, 20);
            this.textBoxC_GRA.TabIndex = 8;
            // 
            // groupBoxC_GRA
            // 
            this.groupBoxC_GRA.Controls.Add(this.textBoxC_GRA);
            this.groupBoxC_GRA.Location = new System.Drawing.Point(438, 6);
            this.groupBoxC_GRA.Name = "groupBoxC_GRA";
            this.groupBoxC_GRA.Size = new System.Drawing.Size(114, 45);
            this.groupBoxC_GRA.TabIndex = 9;
            this.groupBoxC_GRA.TabStop = false;
            this.groupBoxC_GRA.Text = "С-Столбец";
            // 
            // groupBoxN1_GRA
            // 
            this.groupBoxN1_GRA.Controls.Add(this.textBoxN1_GRA);
            this.groupBoxN1_GRA.Location = new System.Drawing.Point(153, 10);
            this.groupBoxN1_GRA.Name = "groupBoxN1_GRA";
            this.groupBoxN1_GRA.Size = new System.Drawing.Size(141, 41);
            this.groupBoxN1_GRA.TabIndex = 10;
            this.groupBoxN1_GRA.TabStop = false;
            this.groupBoxN1_GRA.Text = "Минимальное";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxN2_GRA);
            this.groupBox2.Location = new System.Drawing.Point(155, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 39);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Максимальое";
            // 
            // textBoxN1_GRA
            // 
            this.textBoxN1_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxN1_GRA.Location = new System.Drawing.Point(3, 16);
            this.textBoxN1_GRA.Name = "textBoxN1_GRA";
            this.textBoxN1_GRA.Size = new System.Drawing.Size(135, 20);
            this.textBoxN1_GRA.TabIndex = 0;
            // 
            // textBoxN2_GRA
            // 
            this.textBoxN2_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxN2_GRA.Location = new System.Drawing.Point(3, 16);
            this.textBoxN2_GRA.Name = "textBoxN2_GRA";
            this.textBoxN2_GRA.Size = new System.Drawing.Size(132, 20);
            this.textBoxN2_GRA.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelText_GRA);
            this.Controls.Add(this.panelMatrix_GRA);
            this.Controls.Add(this.panelOpen_GRA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6| ТаскРевью | Вариант 13 | Гооге Р. А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelOpen_GRA.ResumeLayout(false);
            this.panelMatrix_GRA.ResumeLayout(false);
            this.groupBoxOutPut_GRA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_GRA)).EndInit();
            this.panelText_GRA.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxK_GRA.ResumeLayout(false);
            this.groupBoxK_GRA.PerformLayout();
            this.groupBoxStrok_GRA.ResumeLayout(false);
            this.groupBoxStrok_GRA.PerformLayout();
            this.groupBoxStolp_GRA.ResumeLayout(false);
            this.groupBoxStolp_GRA.PerformLayout();
            this.groupBoxResult_GRA.ResumeLayout(false);
            this.groupBoxResult_GRA.PerformLayout();
            this.groupBoxC_GRA.ResumeLayout(false);
            this.groupBoxC_GRA.PerformLayout();
            this.groupBoxN1_GRA.ResumeLayout(false);
            this.groupBoxN1_GRA.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOpen_GRA;
        private System.Windows.Forms.Button buttonStart_GRA;
        private System.Windows.Forms.Panel panelMatrix_GRA;
        private System.Windows.Forms.Panel panelText_GRA;
        private System.Windows.Forms.DataGridView dataGridViewRes_GRA;
        private System.Windows.Forms.Button buttonGen_GRA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_GRA;
        private System.Windows.Forms.GroupBox groupBoxStrok_GRA;
        private System.Windows.Forms.TextBox textBoxStroki_GRA;
        private System.Windows.Forms.GroupBox groupBoxStolp_GRA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxL_GRA;
        private System.Windows.Forms.GroupBox groupBoxK_GRA;
        private System.Windows.Forms.TextBox textBoxK_GRA;
        private System.Windows.Forms.TextBox textBoxStolp_GRA;
        private System.Windows.Forms.GroupBox groupBoxResult_GRA;
        private System.Windows.Forms.TextBox textBoxResult_GRA;
        private System.Windows.Forms.TextBox textBoxC_GRA;
        private System.Windows.Forms.GroupBox groupBoxC_GRA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxN2_GRA;
        private System.Windows.Forms.GroupBox groupBoxN1_GRA;
        private System.Windows.Forms.TextBox textBoxN1_GRA;
    }
}

