using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Project.V11.Lib;

namespace Project.V11
{
    public partial class FormChartEdit_MEA : Form
    {
        DataService ds = new DataService();
        string chartPath = $@"{Directory.GetCurrentDirectory()}\Сезонность сотрудников.txt";

        public FormChartEdit_MEA()
        {
            InitializeComponent();
        }

        private void FormChartEdit_MEA_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Введите в каждое поле требуемое количество сотрудников. Поля не должны оставаться пустыми. В случае ненадобности сотрудников, введите 0.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            double[] serviceArray = ds.LoadFromDataFile(chartPath);
            textBoxDecemberInput_MEA.Text = Convert.ToString(serviceArray[0]);
            textBoxJanuaryInput_MEA.Text = Convert.ToString(serviceArray[1]);
            textBoxFebruaryInput_MEA.Text = Convert.ToString(serviceArray[2]);
            textBoxMarchInput_MEA.Text = Convert.ToString(serviceArray[3]);
            textBoxAprilInput_MEA.Text = Convert.ToString(serviceArray[4]);
            textBoxMayInput_MEA.Text = Convert.ToString(serviceArray[5]);
            textBoxJuneInput_MEA.Text = Convert.ToString(serviceArray[6]);
            textBoxJulyInput_MEA.Text = Convert.ToString(serviceArray[7]);
            textBoxAugustInput_MEA.Text = Convert.ToString(serviceArray[8]);
            textBoxSeptemberInput_MEA.Text = Convert.ToString(serviceArray[9]);
            textBoxOctoberInput_MEA.Text = Convert.ToString(serviceArray[10]);
            textBoxNovemberInput_MEA.Text = Convert.ToString(serviceArray[11]);

            
            
        }

        private void buttonOk_MEA_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxDecemberInput_MEA.Text == null || textBoxJanuaryInput_MEA.Text == null || textBoxFebruaryInput_MEA.Text == null || textBoxMarchInput_MEA.Text == null || textBoxAprilInput_MEA.Text == null || textBoxMayInput_MEA.Text == null || textBoxJuneInput_MEA.Text == null || textBoxJulyInput_MEA.Text == null || textBoxAugustInput_MEA.Text == null || textBoxSeptemberInput_MEA.Text == null || textBoxOctoberInput_MEA.Text == null || textBoxNovemberInput_MEA.Text == null)
                {
                    MessageBox.Show("Возникла ошибка. Возможно, не все поля оказались заполнены. Пожалуйста, повторите попытку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToDouble(textBoxDecemberInput_MEA.Text) < 0 || Convert.ToDouble(textBoxJanuaryInput_MEA.Text) < 0 || Convert.ToDouble(textBoxFebruaryInput_MEA.Text) < 0 || Convert.ToDouble(textBoxMarchInput_MEA.Text) < 0 || Convert.ToDouble(textBoxAprilInput_MEA.Text) < 0 || Convert.ToDouble(textBoxMayInput_MEA.Text) < 0 || Convert.ToDouble(textBoxJuneInput_MEA.Text) < 0 || Convert.ToDouble(textBoxJulyInput_MEA.Text) < 0 || Convert.ToDouble(textBoxAugustInput_MEA.Text) < 0 || Convert.ToDouble(textBoxSeptemberInput_MEA.Text) < 0 || Convert.ToDouble(textBoxOctoberInput_MEA.Text) < 0 || Convert.ToDouble(textBoxNovemberInput_MEA.Text) < 0)
                {
                    MessageBox.Show("Возникла ошибка. Возможно, не все поля оказались заполнены. Пожалуйста, повторите попытку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string[] res = new string[12] { textBoxDecemberInput_MEA.Text, textBoxJanuaryInput_MEA.Text, textBoxFebruaryInput_MEA.Text, textBoxMarchInput_MEA.Text, textBoxAprilInput_MEA.Text, textBoxMayInput_MEA.Text, textBoxJuneInput_MEA.Text, textBoxJulyInput_MEA.Text, textBoxAugustInput_MEA.Text, textBoxSeptemberInput_MEA.Text, textBoxOctoberInput_MEA.Text, textBoxNovemberInput_MEA.Text };
                    System.IO.File.WriteAllText(chartPath, textBoxDecemberInput_MEA.Text + "\n" + textBoxJanuaryInput_MEA.Text + "\n" + textBoxFebruaryInput_MEA.Text + "\n" + textBoxMarchInput_MEA.Text + "\n" + textBoxAprilInput_MEA.Text + "\n" + textBoxMayInput_MEA.Text + "\n" + textBoxJuneInput_MEA.Text + "\n" + textBoxJulyInput_MEA.Text + "\n" + textBoxAugustInput_MEA.Text + "\n" + textBoxSeptemberInput_MEA.Text + "\n" + textBoxOctoberInput_MEA.Text + "\n" + textBoxNovemberInput_MEA.Text);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Возможно, некоторые данные некорректны. Пожалуйста, повторите попытку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
