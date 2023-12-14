using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_22
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var person = new Person
            {
                Name = textBoxName.Text,
                DateOfBirth = dateTimePickerDateOfBirth.Value,
                PhoneNumber = maskedTextBoxPhoneNumber.Text
            };

            Person.AddPersonToFile("data.txt", person);
            // Очистите поля или отобразите сообщение об успешном добавлении
            MessageBox.Show("Запись успешно добавлена.");
            this.Close();

        }

        private void maskedTextBoxPhoneNumber_Enter(object sender, EventArgs e)
        {
            MaskedTextBox mtb = (MaskedTextBox)sender;
            mtb.Select(0, 0); // Перемещение курсора в начало
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Запретить ввод запятых, табуляции и других знаков
            if (e.KeyChar == ',' || e.KeyChar == '\t')
            {
                e.Handled = true;
            }
        }
    }
}
