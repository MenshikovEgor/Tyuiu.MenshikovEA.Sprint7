
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_MEA));
            this.panelInfo_MEA = new System.Windows.Forms.Panel();
            this.chartInfo_MEA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonEditEmploye_MEA = new System.Windows.Forms.Button();
            this.buttonChooseFile_MEA = new System.Windows.Forms.Button();
            this.dataGridViewOutput_MEA = new System.Windows.Forms.DataGridView();
            this.contextMenuStripGridDo_MEA = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextMenuRemoveEmploye_MEA = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuEditEmploye_MEA = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxAddEmploye_MEA = new System.Windows.Forms.GroupBox();
            this.buttonAddEmploye_MEA = new System.Windows.Forms.Button();
            this.textBoxInsideNumberInput_MEA = new System.Windows.Forms.TextBox();
            this.textBoxInsideNumber_MEA = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateEnter_MEA = new System.Windows.Forms.DateTimePicker();
            this.textBoxDateEnter_MEA = new System.Windows.Forms.TextBox();
            this.textBoxSurnameInput_MEA = new System.Windows.Forms.TextBox();
            this.textBoxSurname_MEA = new System.Windows.Forms.TextBox();
            this.textBoxNameInput_MEA = new System.Windows.Forms.TextBox();
            this.textBoxName_MEA = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_MEA = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_MEA = new System.Windows.Forms.ToolTip(this.components);
            this.buttonChartEdit_MEA = new System.Windows.Forms.Button();
            this.panelInfo_MEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartInfo_MEA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_MEA)).BeginInit();
            this.contextMenuStripGridDo_MEA.SuspendLayout();
            this.groupBoxAddEmploye_MEA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInfo_MEA
            // 
            this.panelInfo_MEA.Controls.Add(this.buttonChartEdit_MEA);
            this.panelInfo_MEA.Controls.Add(this.chartInfo_MEA);
            this.panelInfo_MEA.Controls.Add(this.buttonEditEmploye_MEA);
            this.panelInfo_MEA.Controls.Add(this.buttonChooseFile_MEA);
            this.panelInfo_MEA.Controls.Add(this.dataGridViewOutput_MEA);
            this.panelInfo_MEA.Location = new System.Drawing.Point(0, 0);
            this.panelInfo_MEA.Name = "panelInfo_MEA";
            this.panelInfo_MEA.Size = new System.Drawing.Size(1024, 470);
            this.panelInfo_MEA.TabIndex = 1;
            // 
            // chartInfo_MEA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartInfo_MEA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartInfo_MEA.Legends.Add(legend1);
            this.chartInfo_MEA.Location = new System.Drawing.Point(678, 103);
            this.chartInfo_MEA.Name = "chartInfo_MEA";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Сотрудники";
            this.chartInfo_MEA.Series.Add(series1);
            this.chartInfo_MEA.Size = new System.Drawing.Size(343, 364);
            this.chartInfo_MEA.TabIndex = 5;
            this.toolTip_MEA.SetToolTip(this.chartInfo_MEA, "График востребованности рабочих в разные сезоны");
            // 
            // buttonEditEmploye_MEA
            // 
            this.buttonEditEmploye_MEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditEmploye_MEA.Image")));
            this.buttonEditEmploye_MEA.Location = new System.Drawing.Point(791, 13);
            this.buttonEditEmploye_MEA.Name = "buttonEditEmploye_MEA";
            this.buttonEditEmploye_MEA.Size = new System.Drawing.Size(108, 83);
            this.buttonEditEmploye_MEA.TabIndex = 4;
            this.toolTip_MEA.SetToolTip(this.buttonEditEmploye_MEA, "Редактировать данные сотрудника");
            this.buttonEditEmploye_MEA.UseVisualStyleBackColor = true;
            this.buttonEditEmploye_MEA.Click += new System.EventHandler(this.buttonEditEmploye_MEA_Click);
            // 
            // buttonChooseFile_MEA
            // 
            this.buttonChooseFile_MEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonChooseFile_MEA.Image")));
            this.buttonChooseFile_MEA.Location = new System.Drawing.Point(677, 13);
            this.buttonChooseFile_MEA.Name = "buttonChooseFile_MEA";
            this.buttonChooseFile_MEA.Size = new System.Drawing.Size(108, 83);
            this.buttonChooseFile_MEA.TabIndex = 3;
            this.toolTip_MEA.SetToolTip(this.buttonChooseFile_MEA, "Выберите файл сотрудника с его внутренним номером");
            this.buttonChooseFile_MEA.UseVisualStyleBackColor = true;
            this.buttonChooseFile_MEA.Click += new System.EventHandler(this.buttonChooseFile_MEA_Click);
            // 
            // dataGridViewOutput_MEA
            // 
            this.dataGridViewOutput_MEA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput_MEA.Location = new System.Drawing.Point(12, 74);
            this.dataGridViewOutput_MEA.Name = "dataGridViewOutput_MEA";
            this.dataGridViewOutput_MEA.RowHeadersWidth = 51;
            this.dataGridViewOutput_MEA.RowTemplate.Height = 24;
            this.dataGridViewOutput_MEA.Size = new System.Drawing.Size(659, 393);
            this.dataGridViewOutput_MEA.TabIndex = 0;
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
            // groupBoxAddEmploye_MEA
            // 
            this.groupBoxAddEmploye_MEA.Controls.Add(this.buttonAddEmploye_MEA);
            this.groupBoxAddEmploye_MEA.Controls.Add(this.textBoxInsideNumberInput_MEA);
            this.groupBoxAddEmploye_MEA.Controls.Add(this.textBoxInsideNumber_MEA);
            this.groupBoxAddEmploye_MEA.Controls.Add(this.dateTimePickerDateEnter_MEA);
            this.groupBoxAddEmploye_MEA.Controls.Add(this.textBoxDateEnter_MEA);
            this.groupBoxAddEmploye_MEA.Controls.Add(this.textBoxSurnameInput_MEA);
            this.groupBoxAddEmploye_MEA.Controls.Add(this.textBoxSurname_MEA);
            this.groupBoxAddEmploye_MEA.Controls.Add(this.textBoxNameInput_MEA);
            this.groupBoxAddEmploye_MEA.Controls.Add(this.textBoxName_MEA);
            this.groupBoxAddEmploye_MEA.Location = new System.Drawing.Point(13, 477);
            this.groupBoxAddEmploye_MEA.Name = "groupBoxAddEmploye_MEA";
            this.groupBoxAddEmploye_MEA.Size = new System.Drawing.Size(1000, 143);
            this.groupBoxAddEmploye_MEA.TabIndex = 3;
            this.groupBoxAddEmploye_MEA.TabStop = false;
            this.groupBoxAddEmploye_MEA.Text = "Добавить нового сотрудника:";
            // 
            // buttonAddEmploye_MEA
            // 
            this.buttonAddEmploye_MEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddEmploye_MEA.Location = new System.Drawing.Point(790, 94);
            this.buttonAddEmploye_MEA.Name = "buttonAddEmploye_MEA";
            this.buttonAddEmploye_MEA.Size = new System.Drawing.Size(204, 43);
            this.buttonAddEmploye_MEA.TabIndex = 8;
            this.buttonAddEmploye_MEA.Text = "Добавить сотрудника";
            this.buttonAddEmploye_MEA.UseVisualStyleBackColor = true;
            this.buttonAddEmploye_MEA.Click += new System.EventHandler(this.buttonAddEmploye_MEA_Click);
            // 
            // textBoxInsideNumberInput_MEA
            // 
            this.textBoxInsideNumberInput_MEA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInsideNumberInput_MEA.Location = new System.Drawing.Point(132, 94);
            this.textBoxInsideNumberInput_MEA.Name = "textBoxInsideNumberInput_MEA";
            this.textBoxInsideNumberInput_MEA.Size = new System.Drawing.Size(155, 22);
            this.textBoxInsideNumberInput_MEA.TabIndex = 7;
            // 
            // textBoxInsideNumber_MEA
            // 
            this.textBoxInsideNumber_MEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInsideNumber_MEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInsideNumber_MEA.Location = new System.Drawing.Point(6, 94);
            this.textBoxInsideNumber_MEA.Name = "textBoxInsideNumber_MEA";
            this.textBoxInsideNumber_MEA.ReadOnly = true;
            this.textBoxInsideNumber_MEA.Size = new System.Drawing.Size(120, 19);
            this.textBoxInsideNumber_MEA.TabIndex = 6;
            this.textBoxInsideNumber_MEA.Text = "Внутр. номер:";
            // 
            // dateTimePickerDateEnter_MEA
            // 
            this.dateTimePickerDateEnter_MEA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateEnter_MEA.Location = new System.Drawing.Point(748, 44);
            this.dateTimePickerDateEnter_MEA.Name = "dateTimePickerDateEnter_MEA";
            this.dateTimePickerDateEnter_MEA.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDateEnter_MEA.TabIndex = 5;
            // 
            // textBoxDateEnter_MEA
            // 
            this.textBoxDateEnter_MEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDateEnter_MEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDateEnter_MEA.Location = new System.Drawing.Point(539, 45);
            this.textBoxDateEnter_MEA.Name = "textBoxDateEnter_MEA";
            this.textBoxDateEnter_MEA.ReadOnly = true;
            this.textBoxDateEnter_MEA.Size = new System.Drawing.Size(202, 19);
            this.textBoxDateEnter_MEA.TabIndex = 4;
            this.textBoxDateEnter_MEA.Text = "Дата трудоустройства:";
            // 
            // textBoxSurnameInput_MEA
            // 
            this.textBoxSurnameInput_MEA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSurnameInput_MEA.Location = new System.Drawing.Point(321, 45);
            this.textBoxSurnameInput_MEA.Name = "textBoxSurnameInput_MEA";
            this.textBoxSurnameInput_MEA.Size = new System.Drawing.Size(202, 22);
            this.textBoxSurnameInput_MEA.TabIndex = 3;
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
            // textBoxNameInput_MEA
            // 
            this.textBoxNameInput_MEA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNameInput_MEA.Location = new System.Drawing.Point(56, 45);
            this.textBoxNameInput_MEA.Name = "textBoxNameInput_MEA";
            this.textBoxNameInput_MEA.Size = new System.Drawing.Size(155, 22);
            this.textBoxNameInput_MEA.TabIndex = 1;
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
            // openFileDialogTask_MEA
            // 
            this.openFileDialogTask_MEA.FileName = "openFileDialogTask_MEA";
            // 
            // buttonChartEdit_MEA
            // 
            this.buttonChartEdit_MEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonChartEdit_MEA.Image")));
            this.buttonChartEdit_MEA.Location = new System.Drawing.Point(905, 14);
            this.buttonChartEdit_MEA.Name = "buttonChartEdit_MEA";
            this.buttonChartEdit_MEA.Size = new System.Drawing.Size(108, 83);
            this.buttonChartEdit_MEA.TabIndex = 6;
            this.toolTip_MEA.SetToolTip(this.buttonChartEdit_MEA, "Редактировать данные графика");
            this.buttonChartEdit_MEA.UseVisualStyleBackColor = true;
            this.buttonChartEdit_MEA.Click += new System.EventHandler(this.buttonChartEdit_MEA_Click);
            // 
            // FormMain_MEA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 632);
            this.Controls.Add(this.groupBoxAddEmploye_MEA);
            this.Controls.Add(this.panelInfo_MEA);
            this.Name = "FormMain_MEA";
            this.Text = "Спринт 7 | Проект | Вариант 11 | Меньшиков Е.А.";
            this.Load += new System.EventHandler(this.FormMain_MEA_Load);
            this.panelInfo_MEA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartInfo_MEA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_MEA)).EndInit();
            this.contextMenuStripGridDo_MEA.ResumeLayout(false);
            this.groupBoxAddEmploye_MEA.ResumeLayout(false);
            this.groupBoxAddEmploye_MEA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInfo_MEA;
        private System.Windows.Forms.Button buttonEditEmploye_MEA;
        private System.Windows.Forms.Button buttonChooseFile_MEA;
        private System.Windows.Forms.DataGridView dataGridViewOutput_MEA;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripGridDo_MEA;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuRemoveEmploye_MEA;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuEditEmploye_MEA;
        private System.Windows.Forms.GroupBox groupBoxAddEmploye_MEA;
        private System.Windows.Forms.TextBox textBoxSurnameInput_MEA;
        private System.Windows.Forms.TextBox textBoxSurname_MEA;
        private System.Windows.Forms.TextBox textBoxNameInput_MEA;
        private System.Windows.Forms.TextBox textBoxName_MEA;
        private System.Windows.Forms.TextBox textBoxInsideNumberInput_MEA;
        private System.Windows.Forms.TextBox textBoxInsideNumber_MEA;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateEnter_MEA;
        private System.Windows.Forms.TextBox textBoxDateEnter_MEA;
        private System.Windows.Forms.Button buttonAddEmploye_MEA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInfo_MEA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_MEA;
        private System.Windows.Forms.ToolTip toolTip_MEA;
        private System.Windows.Forms.Button buttonChartEdit_MEA;
    }
}

