
namespace Tyuiu.GoogeRA.Sprint6.TaskReviev
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxOne_GRA = new System.Windows.Forms.GroupBox();
            this.buttonHelp_GRA = new System.Windows.Forms.Button();
            this.buttonSave_GRA = new System.Windows.Forms.Button();
            this.buttonStart_GRA = new System.Windows.Forms.Button();
            this.buttonOpenFile_GRA = new System.Windows.Forms.Button();
            this.panelTopOne_GRA = new System.Windows.Forms.Panel();
            this.panelTopTwo_GRA = new System.Windows.Forms.Panel();
            this.groupBoxExe_GRA = new System.Windows.Forms.GroupBox();
            this.textBoxExe_GRA = new System.Windows.Forms.TextBox();
            this.panelLeft_GRA = new System.Windows.Forms.Panel();
            this.groupBoxLoadFromFile_GRA = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPut_GRA = new System.Windows.Forms.DataGridView();
            this.panelRait = new System.Windows.Forms.Panel();
            this.groupBoxRes_GRA = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPut_GRA = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_GRA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix_GRA = new System.Windows.Forms.OpenFileDialog();
            this.toolTipInfo_GRA = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxOne_GRA.SuspendLayout();
            this.panelTopOne_GRA.SuspendLayout();
            this.panelTopTwo_GRA.SuspendLayout();
            this.groupBoxExe_GRA.SuspendLayout();
            this.panelLeft_GRA.SuspendLayout();
            this.groupBoxLoadFromFile_GRA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_GRA)).BeginInit();
            this.panelRait.SuspendLayout();
            this.groupBoxRes_GRA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_GRA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOne_GRA
            // 
            this.groupBoxOne_GRA.Controls.Add(this.buttonHelp_GRA);
            this.groupBoxOne_GRA.Controls.Add(this.buttonSave_GRA);
            this.groupBoxOne_GRA.Controls.Add(this.buttonStart_GRA);
            this.groupBoxOne_GRA.Controls.Add(this.buttonOpenFile_GRA);
            this.groupBoxOne_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOne_GRA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOne_GRA.Name = "groupBoxOne_GRA";
            this.groupBoxOne_GRA.Size = new System.Drawing.Size(1002, 100);
            this.groupBoxOne_GRA.TabIndex = 0;
            this.groupBoxOne_GRA.TabStop = false;
            // 
            // buttonHelp_GRA
            // 
            this.buttonHelp_GRA.Location = new System.Drawing.Point(857, 20);
            this.buttonHelp_GRA.Name = "buttonHelp_GRA";
            this.buttonHelp_GRA.Size = new System.Drawing.Size(133, 74);
            this.buttonHelp_GRA.TabIndex = 3;
            this.buttonHelp_GRA.Text = "Help";
            this.toolTipInfo_GRA.SetToolTip(this.buttonHelp_GRA, "Справка");
            this.buttonHelp_GRA.UseVisualStyleBackColor = true;
            this.buttonHelp_GRA.Click += new System.EventHandler(this.buttonHelp_GRA_Click);
            // 
            // buttonSave_GRA
            // 
            this.buttonSave_GRA.Enabled = false;
            this.buttonSave_GRA.Location = new System.Drawing.Point(275, 13);
            this.buttonSave_GRA.Name = "buttonSave_GRA";
            this.buttonSave_GRA.Size = new System.Drawing.Size(99, 81);
            this.buttonSave_GRA.TabIndex = 2;
            this.buttonSave_GRA.Text = "buttonSave";
            this.toolTipInfo_GRA.SetToolTip(this.buttonSave_GRA, "Сохранить файл");
            this.buttonSave_GRA.UseVisualStyleBackColor = true;
            this.buttonSave_GRA.Click += new System.EventHandler(this.buttonSave_GRA_Click);
            // 
            // buttonStart_GRA
            // 
            this.buttonStart_GRA.Enabled = false;
            this.buttonStart_GRA.Location = new System.Drawing.Point(153, 13);
            this.buttonStart_GRA.Name = "buttonStart_GRA";
            this.buttonStart_GRA.Size = new System.Drawing.Size(105, 81);
            this.buttonStart_GRA.TabIndex = 1;
            this.buttonStart_GRA.Text = "buttonDone";
            this.toolTipInfo_GRA.SetToolTip(this.buttonStart_GRA, "Выполнить ");
            this.buttonStart_GRA.UseVisualStyleBackColor = true;
            this.buttonStart_GRA.Click += new System.EventHandler(this.buttonStart_GRA_Click);
            // 
            // buttonOpenFile_GRA
            // 
            this.buttonOpenFile_GRA.Location = new System.Drawing.Point(25, 13);
            this.buttonOpenFile_GRA.Name = "buttonOpenFile_GRA";
            this.buttonOpenFile_GRA.Size = new System.Drawing.Size(112, 81);
            this.buttonOpenFile_GRA.TabIndex = 0;
            this.buttonOpenFile_GRA.Text = "OpenFile";
            this.toolTipInfo_GRA.SetToolTip(this.buttonOpenFile_GRA, "Открыть файл");
            this.buttonOpenFile_GRA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_GRA.Click += new System.EventHandler(this.buttonOpenFile_GRA_Click);
            // 
            // panelTopOne_GRA
            // 
            this.panelTopOne_GRA.Controls.Add(this.groupBoxOne_GRA);
            this.panelTopOne_GRA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopOne_GRA.Location = new System.Drawing.Point(0, 0);
            this.panelTopOne_GRA.Name = "panelTopOne_GRA";
            this.panelTopOne_GRA.Size = new System.Drawing.Size(1002, 100);
            this.panelTopOne_GRA.TabIndex = 1;
            // 
            // panelTopTwo_GRA
            // 
            this.panelTopTwo_GRA.Controls.Add(this.groupBoxExe_GRA);
            this.panelTopTwo_GRA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopTwo_GRA.Location = new System.Drawing.Point(0, 100);
            this.panelTopTwo_GRA.Name = "panelTopTwo_GRA";
            this.panelTopTwo_GRA.Size = new System.Drawing.Size(1002, 100);
            this.panelTopTwo_GRA.TabIndex = 2;
            // 
            // groupBoxExe_GRA
            // 
            this.groupBoxExe_GRA.Controls.Add(this.textBoxExe_GRA);
            this.groupBoxExe_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxExe_GRA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxExe_GRA.Name = "groupBoxExe_GRA";
            this.groupBoxExe_GRA.Size = new System.Drawing.Size(1002, 100);
            this.groupBoxExe_GRA.TabIndex = 0;
            this.groupBoxExe_GRA.TabStop = false;
            this.groupBoxExe_GRA.Text = "Условие";
            // 
            // textBoxExe_GRA
            // 
            this.textBoxExe_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxExe_GRA.Location = new System.Drawing.Point(3, 16);
            this.textBoxExe_GRA.Multiline = true;
            this.textBoxExe_GRA.Name = "textBoxExe_GRA";
            this.textBoxExe_GRA.ReadOnly = true;
            this.textBoxExe_GRA.Size = new System.Drawing.Size(996, 81);
            this.textBoxExe_GRA.TabIndex = 0;
            // 
            // panelLeft_GRA
            // 
            this.panelLeft_GRA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLeft_GRA.Controls.Add(this.groupBoxLoadFromFile_GRA);
            this.panelLeft_GRA.Location = new System.Drawing.Point(13, 200);
            this.panelLeft_GRA.Name = "panelLeft_GRA";
            this.panelLeft_GRA.Size = new System.Drawing.Size(500, 473);
            this.panelLeft_GRA.TabIndex = 3;
            // 
            // groupBoxLoadFromFile_GRA
            // 
            this.groupBoxLoadFromFile_GRA.Controls.Add(this.dataGridViewInPut_GRA);
            this.groupBoxLoadFromFile_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxLoadFromFile_GRA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxLoadFromFile_GRA.Name = "groupBoxLoadFromFile_GRA";
            this.groupBoxLoadFromFile_GRA.Size = new System.Drawing.Size(500, 473);
            this.groupBoxLoadFromFile_GRA.TabIndex = 1;
            this.groupBoxLoadFromFile_GRA.TabStop = false;
            this.groupBoxLoadFromFile_GRA.Text = "Ввод:";
            // 
            // dataGridViewInPut_GRA
            // 
            this.dataGridViewInPut_GRA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInPut_GRA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewInPut_GRA.Name = "dataGridViewInPut_GRA";
            this.dataGridViewInPut_GRA.RowHeadersVisible = false;
            this.dataGridViewInPut_GRA.Size = new System.Drawing.Size(494, 454);
            this.dataGridViewInPut_GRA.TabIndex = 0;
            // 
            // panelRait
            // 
            this.panelRait.Controls.Add(this.groupBoxRes_GRA);
            this.panelRait.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRait.Location = new System.Drawing.Point(519, 200);
            this.panelRait.Name = "panelRait";
            this.panelRait.Size = new System.Drawing.Size(483, 476);
            this.panelRait.TabIndex = 4;
            // 
            // groupBoxRes_GRA
            // 
            this.groupBoxRes_GRA.Controls.Add(this.dataGridViewOutPut_GRA);
            this.groupBoxRes_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRes_GRA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxRes_GRA.Name = "groupBoxRes_GRA";
            this.groupBoxRes_GRA.Size = new System.Drawing.Size(483, 476);
            this.groupBoxRes_GRA.TabIndex = 1;
            this.groupBoxRes_GRA.TabStop = false;
            this.groupBoxRes_GRA.Text = "Вывод:";
            // 
            // dataGridViewOutPut_GRA
            // 
            this.dataGridViewOutPut_GRA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutPut_GRA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOutPut_GRA.Name = "dataGridViewOutPut_GRA";
            this.dataGridViewOutPut_GRA.RowHeadersVisible = false;
            this.dataGridViewOutPut_GRA.Size = new System.Drawing.Size(477, 457);
            this.dataGridViewOutPut_GRA.TabIndex = 0;
            // 
            // toolTipInfo_GRA
            // 
            this.toolTipInfo_GRA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipInfo_GRA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 676);
            this.Controls.Add(this.panelRait);
            this.Controls.Add(this.panelLeft_GRA);
            this.Controls.Add(this.panelTopTwo_GRA);
            this.Controls.Add(this.panelTopOne_GRA);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | ТаскРевью | Вариант | Гооге Р.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxOne_GRA.ResumeLayout(false);
            this.panelTopOne_GRA.ResumeLayout(false);
            this.panelTopTwo_GRA.ResumeLayout(false);
            this.groupBoxExe_GRA.ResumeLayout(false);
            this.groupBoxExe_GRA.PerformLayout();
            this.panelLeft_GRA.ResumeLayout(false);
            this.groupBoxLoadFromFile_GRA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_GRA)).EndInit();
            this.panelRait.ResumeLayout(false);
            this.groupBoxRes_GRA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_GRA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOne_GRA;
        private System.Windows.Forms.Panel panelTopOne_GRA;
        private System.Windows.Forms.Panel panelTopTwo_GRA;
        private System.Windows.Forms.Panel panelLeft_GRA;
        private System.Windows.Forms.DataGridView dataGridViewInPut_GRA;
        private System.Windows.Forms.Panel panelRait;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_GRA;
        private System.Windows.Forms.GroupBox groupBoxLoadFromFile_GRA;
        private System.Windows.Forms.GroupBox groupBoxRes_GRA;
        private System.Windows.Forms.Button buttonStart_GRA;
        private System.Windows.Forms.Button buttonOpenFile_GRA;
        private System.Windows.Forms.GroupBox groupBoxExe_GRA;
        private System.Windows.Forms.TextBox textBoxExe_GRA;
        private System.Windows.Forms.Button buttonHelp_GRA;
        private System.Windows.Forms.Button buttonSave_GRA;
        private System.Windows.Forms.ToolTip toolTipInfo_GRA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_GRA;
        private System.Windows.Forms.OpenFileDialog saveFileDialogMatrix_GRA;
    }
}

