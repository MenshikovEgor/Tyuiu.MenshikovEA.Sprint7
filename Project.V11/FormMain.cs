using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using System.Windows.Forms;
using Project.V11.Lib;

namespace Project.V11
{

    public partial class FormMain_MEA : Form
    {
        DataService ds = new DataService();
        string openFilePath;
        string chartPath = $@"{Directory.GetCurrentDirectory()}\Сезонность сотрудников.txt";

        public FormMain_MEA()
        {
            InitializeComponent();
        }

        public void buttonChooseFile_MEA_Click(object sender, EventArgs e)
        {

            try
            {
                openFileDialogTask_MEA.ShowDialog();
                openFilePath = openFileDialogTask_MEA.FileName;
                string[] dataString = File.ReadAllText(openFilePath).Split(' ');

                DataTable dt = new DataTable();
                int count = 1;
                dt.Columns.Add("Данные сотрудника");


                for (int i = 0; i < 4; i++)
                {

                    dt.Rows.Add(dataString[i]);
                }


                dataGridViewOutput_MEA.DataSource = dt;
                buttonEditEmploye_MEA.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Возникла ошибка при чтении данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddEmploye_MEA_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.File.WriteAllText($@"{Directory.GetCurrentDirectory()}\" + textBoxInsideNumberInput_MEA.Text + " " + textBoxSurnameInput_MEA.Text + ".txt", textBoxSurnameInput_MEA.Text + " " + textBoxNameInput_MEA.Text + " " + dateTimePickerDateEnter_MEA.Text + " " + textBoxInsideNumberInput_MEA.Text);
                using (StreamWriter stream = new StreamWriter($@"{Directory.GetCurrentDirectory()}\Номера сотрудников.txt", true))
                {
                    stream.WriteLine(textBoxInsideNumberInput_MEA.Text + " " + textBoxSurnameInput_MEA.Text + "\n");
                }
                MessageBox.Show("Данные сотрудника сохранены успешно!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxNameInput_MEA.Clear();
                textBoxSurnameInput_MEA.Clear();
                textBoxInsideNumberInput_MEA.Clear();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка при сохранении данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEditEmploye_MEA_Click(object sender, EventArgs e)
        {
            FormEditEmploye_MEA Edit = new FormEditEmploye_MEA();
            Edit.ShowDialog();
        }

        private void FormMain_MEA_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(chartPath))
                {
                    chartInfo_MEA.ChartAreas[0].AxisX.Title = "Зима/Весна/Лето/Осень";
                    chartInfo_MEA.ChartAreas[0].AxisY.Title = "Кол-во сотрудников";

                    double[] serviceArray = ds.LoadFromDataFile(chartPath);
                    for (int i = 0; i < 12; i++)
                    {
                        chartInfo_MEA.Series[0].Points.AddXY(i + 1, serviceArray[i]);
                    }
                }
                else
                {
                    chartInfo_MEA.ChartAreas[0].AxisX.Title = "Зима/Весна/Лето/Осень";
                    chartInfo_MEA.ChartAreas[0].AxisY.Title = "Кол-во сотрудников";

                    System.IO.File.WriteAllText(chartPath, "1 \n1 \n1 \n1 \n1 \n1 \n1 \n1 \n1 \n1 \n1 \n1");
                    double[] serviceArray = ds.LoadFromDataFile(chartPath);
                    for (int i = 0; i < 12; i++)
                    {
                        chartInfo_MEA.Series[0].Points.AddXY(i + 1, serviceArray[i]);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при загрузке графика. Возможно исходный файл поврежден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonChartEdit_MEA_Click(object sender, EventArgs e)
        {
            FormChartEdit_MEA ched = new FormChartEdit_MEA();
            ched.ShowDialog();
        }
    }

    
}
