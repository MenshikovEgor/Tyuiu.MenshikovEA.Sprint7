
namespace Project.V11
{
    partial class FormMain_MEA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_MEA));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxSearch_MEA = new System.Windows.Forms.TextBox();
            this.textBoxSearchInput_MEA = new System.Windows.Forms.TextBox();
            this.buttonChooseFile_MEA = new System.Windows.Forms.Button();
            this.buttonSave_MEA = new System.Windows.Forms.Button();
            this.contextMenuStripGridDo_MEA = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextMenuRemoveEmploye_MEA = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuEditEmploye_MEA = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxInfo_MEA = new System.Windows.Forms.TextBox();
            this.groupBoxAddEmploye_MEA = new System.Windows.Forms.GroupBox();
            this.textBoxName_MEA = new System.Windows.Forms.TextBox();
            this.textBoxNameInput_MEA = new System.Windows.Forms.TextBox();
            this.textBoxSurname_MEA = new System.Windows.Forms.TextBox();
            this.textBoxSurnameInput_MEA = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStripGridDo_MEA.SuspendLayout();
            this.groupBoxAddEmploye_MEA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxInfo_MEA);
            this.panel1.Controls.Add(this.buttonSave_MEA);
            this.panel1.Controls.Add(this.buttonChooseFile_MEA);
            this.panel1.Controls.Add(this.textBoxSearchInput_MEA);
            this.panel1.Controls.Add(this.textBoxSearch_MEA);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 470);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(659, 393);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxSearch_MEA
            // 
            this.textBoxSearch_MEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch_MEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch_MEA.Location = new System.Drawing.Point(12, 13);
            this.textBoxSearch_MEA.Name = "textBoxSearch_MEA";
            this.textBoxSearch_MEA.ReadOnly = true;
            this.textBoxSearch_MEA.Size = new System.Drawing.Size(61, 19);
            this.textBoxSearch_MEA.TabIndex = 1;
            this.textBoxSearch_MEA.Text = "Поиск:";
            // 
            // textBoxSearchInput_MEA
            // 
            this.textBoxSearchInput_MEA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearchInput_MEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearchInput_MEA.Location = new System.Drawing.Point(80, 13);
            this.textBoxSearchInput_MEA.Name = "textBoxSearchInput_MEA";
            this.textBoxSearchInput_MEA.Size = new System.Drawing.Size(591, 26);
            this.textBoxSearchInput_MEA.TabIndex = 2;
            // 
            // buttonChooseFile_MEA
            // 
            this.buttonChooseFile_MEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonChooseFile_MEA.Image")));
            this.buttonChooseFile_MEA.Location = new System.Drawing.Point(677, 13);
            this.buttonChooseFile_MEA.Name = "buttonChooseFile_MEA";
            this.buttonChooseFile_MEA.Size = new System.Drawing.Size(108, 83);
            this.buttonChooseFile_MEA.TabIndex = 3;
            this.buttonChooseFile_MEA.UseVisualStyleBackColor = true;
            // 
            // buttonSave_MEA
            // 
            this.buttonSave_MEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_MEA.Image")));
            this.buttonSave_MEA.Location = new System.Drawing.Point(791, 13);
            this.buttonSave_MEA.Name = "buttonSave_MEA";
            this.buttonSave_MEA.Size = new System.Drawing.Size(108, 83);
            this.buttonSave_MEA.TabIndex = 4;
            this.buttonSave_MEA.UseVisualStyleBackColor = true;
            // 
            // contextMenuStripGridDo_MEA
            // 
            this.contextMenuStripGridDo_MEA.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripGridDo_MEA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuRemoveEmploye_MEA,
            this.ContextMenuEditEmploye_MEA});
            this.contextMenuStripGridDo_MEA.Name = "contextMenuStripGridDo_MEA";
            this.contextMenuStripGridDo_MEA.Size = new System.Drawing.Size(355, 52);
            // 
            // ContextMenuRemoveEmploye_MEA
            // 
            this.ContextMenuRemoveEmploye_MEA.Name = "ContextMenuRemoveEmploye_MEA";
            this.ContextMenuRemoveEmploye_MEA.Size = new System.Drawing.Size(354, 24);
            this.ContextMenuRemoveEmploye_MEA.Text = "&Удалить выбранного сотрудника";
            // 
            // ContextMenuEditEmploye_MEA
            // 
            this.ContextMenuEditEmploye_MEA.Name = "ContextMenuEditEmploye_MEA";
            this.ContextMenuEditEmploye_MEA.Size = new System.Drawing.Size(354, 24);
            this.ContextMenuEditEmploye_MEA.Text = "&Редактировать выбранного сотрудника";
            // 
            // textBoxInfo_MEA
            // 
            this.textBoxInfo_MEA.Location = new System.Drawing.Point(678, 103);
            this.textBoxInfo_MEA.Multiline = true;
            this.textBoxInfo_MEA.Name = "textBoxInfo_MEA";
            this.textBoxInfo_MEA.ReadOnly = true;
            this.textBoxInfo_MEA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInfo_MEA.Size = new System.Drawing.Size(335, 364);
            this.textBoxInfo_MEA.TabIndex = 5;
            // 
            // groupBoxAddEmploye_MEA
            // 
            this.groupBoxAddEmploye_MEA.Controls.Add(this.textBoxSurnameInput_MEA);
            this.groupBoxAddEmploye_MEA.Controls.Add(this.textBoxSurname_MEA);
            this.groupBoxAddEmploye_MEA.Controls.Add(this.textBoxNameInput_MEA);
            this.groupBoxAddEmploye_MEA.Controls.Add(this.textBoxName_MEA);
            this.groupBoxAddEmploye_MEA.Location = new System.Drawing.Point(13, 477);
            this.groupBoxAddEmploye_MEA.Name = "groupBoxAddEmploye_MEA";
            this.groupBoxAddEmploye_MEA.Size = new System.Drawing.Size(1000, 100);
            this.groupBoxAddEmploye_MEA.TabIndex = 3;
            this.groupBoxAddEmploye_MEA.TabStop = false;
            this.groupBoxAddEmploye_MEA.Text = "Добавить нового сотрудника:";
            // 
            // textBoxName_MEA
            // 
            this.textBoxName_MEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName_MEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName_MEA.Location = new System.Drawing.Point(6, 45);
            this.textBoxName_MEA.Name = "textBoxName_MEA";
            this.textBoxName_MEA.ReadOnly = true;
            this.textBoxName_MEA.Size = new System.Drawing.Size(43, 19);
            this.textBoxName_MEA.TabIndex = 0;
            this.textBoxName_MEA.Text = "Имя:";
            // 
            // textBoxNameInput_MEA
            // 
            this.textBoxNameInput_MEA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNameInput_MEA.Location = new System.Drawing.Point(56, 45);
            this.textBoxNameInput_MEA.Name = "textBoxNameInput_MEA";
            this.textBoxNameInput_MEA.Size = new System.Drawing.Size(155, 22);
            this.textBoxNameInput_MEA.TabIndex = 1;
            // 
            // textBoxSurname_MEA
            // 
            this.textBoxSurname_MEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSurname_MEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSurname_MEA.Location = new System.Drawing.Point(229, 44);
            this.textBoxSurname_MEA.Name = "textBoxSurname_MEA";
            this.textBoxSurname_MEA.ReadOnly = true;
            this.textBoxSurname_MEA.Size = new System.Drawing.Size(86, 19);
            this.textBoxSurname_MEA.TabIndex = 2;
            this.textBoxSurname_MEA.Text = "Фамилия:";
            // 
            // textBoxSurnameInput_MEA
            // 
            this.textBoxSurnameInput_MEA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSurnameInput_MEA.Location = new System.Drawing.Point(321, 45);
            this.textBoxSurnameInput_MEA.Name = "textBoxSurnameInput_MEA";
            this.textBoxSurnameInput_MEA.Size = new System.Drawing.Size(202, 22);
            this.textBoxSurnameInput_MEA.TabIndex = 3;
            // 
            // FormMain_MEA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 632);
            this.Controls.Add(this.groupBoxAddEmploye_MEA);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain_MEA";
            this.Text = "Спринт 7 | Проект | Вариант 11 | Меньшиков Е.А.";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStripGridDo_MEA.ResumeLayout(false);
            this.groupBoxAddEmploye_MEA.ResumeLayout(false);
            this.groupBoxAddEmploye_MEA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxInfo_MEA;
        private System.Windows.Forms.Button buttonSave_MEA;
        private System.Windows.Forms.Button buttonChooseFile_MEA;
        private System.Windows.Forms.TextBox textBoxSearchInput_MEA;
        private System.Windows.Forms.TextBox textBoxSearch_MEA;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripGridDo_MEA;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuRemoveEmploye_MEA;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuEditEmploye_MEA;
        private System.Windows.Forms.GroupBox groupBoxAddEmploye_MEA;
        private System.Windows.Forms.TextBox textBoxSurnameInput_MEA;
        private System.Windows.Forms.TextBox textBoxSurname_MEA;
        private System.Windows.Forms.TextBox textBoxNameInput_MEA;
        private System.Windows.Forms.TextBox textBoxName_MEA;
    }
}

