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

namespace Project.V11
{
    public partial class FormEditEmploye_MEA : Form
    {
        string openFilePath;
        public FormEditEmploye_MEA()
        {
            InitializeComponent();
        }

        private void buttonOk_MEA_Click(object sender, EventArgs e)
        {
            
            try
            {
                string[] dataString = new string[4] { textBoxSurnameInput_MEA.Text, textBoxNameInput_MEA.Text, dateTimePickerDateEnter_MEA.Text, textBoxInsideNumberInput_MEA.Text };
                if (textBoxSurnameInput_MEA.Text == null)
                {
                    MessageBox.Show("Введены не все данные. Проверьте корректность заполнения полей.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dataString[0] = textBoxSurnameInput_MEA.Text;
                }

                if (textBoxNameInput_MEA.Text == null)
                {
                    MessageBox.Show("Введены не все данные. Проверьте корректность заполнения полей.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dataString[1] = textBoxNameInput_MEA.Text;
                }

                dataString[2] = dateTimePickerDateEnter_MEA.Text;

                if (textBoxInsideNumberInput_MEA.Text == null)
                {
                    MessageBox.Show("Введены не все данные. Проверьте корректность заполнения полей.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dataString[3] = textBoxInsideNumberInput_MEA.Text;
                }

                if (textBoxInsideNumberInput_MEA.Text != null && textBoxNameInput_MEA.Text != null && textBoxSurnameInput_MEA.Text != null)
                {
                    System.IO.File.WriteAllText($@"{Directory.GetCurrentDirectory()}\" + dataString[3] + ".txt", dataString[0] + " " + dataString[1] + " " + dataString[2] + " " + dataString[3]);
                    MessageBox.Show("Редактирование прошло успешно. Для выхода нажмите Cancel или сверните окно для редактирования.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при редактировании данных. Повторите попытку позже или поплачьтесь разработчикам.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_MEA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditEmploye_MEA_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Выберите сотрудника и измените данные которые требуется изменить. Если данные в каком-то поле не требуют изменения, введите информацию без изменения.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            openFileDialogTask_MEA.ShowDialog();
            openFilePath = openFileDialogTask_MEA.FileName;
            string[] dataString = File.ReadAllText(openFilePath).Split(' ');
            textBoxSurnameInput_MEA.Text = dataString[0];
            textBoxNameInput_MEA.Text = dataString[1];
            dateTimePickerDateEnter_MEA.Text = dataString[2];
            textBoxInsideNumberInput_MEA.Text = dataString[3];
        }
    }
}
