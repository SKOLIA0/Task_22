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
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }


        private void LoadData()
        {
            try
            {
                var people = Person.ReadFromTextFile("data.txt");
                listBoxList.Items.Clear();

                foreach (var person in people)
                {
                    listBoxList.Items.Add($"{person.Name} - {person.DateOfBirth.ToShortDateString()} - {person.PhoneNumber}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        private void buttonFormAdd_Click(object sender, EventArgs e)
        {
            var formAdd = new FormAdd();
            formAdd.ShowDialog(); // Отображение FormAdd как модального окна
            {
                LoadData();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonFormFindAge_Click(object sender, EventArgs e)
        {
            var formFindByAge = new FormFindByAge();
            if (formFindByAge.ShowDialog() == DialogResult.OK)
            {
                var searchResults = formFindByAge.SearchResult; // Убедитесь, что это свойство существует
                listBoxList.Items.Clear();

                foreach (var person in searchResults)
                {
                    listBoxList.Items.Add($"{person.Name} - {person.DateOfBirth.ToShortDateString()} - {person.PhoneNumber}");
                }
            }
        }

        private void buttonFormFindName_Click(object sender, EventArgs e)
        {
            var formFindByName = new FormFindByName();
            if (formFindByName.ShowDialog() == DialogResult.OK)
            {
                var searchResults = formFindByName.SearchResult;
                listBoxList.Items.Clear();

                foreach (var person in searchResults)
                {
                    listBoxList.Items.Add($"{person.Name} - {person.DateOfBirth.ToShortDateString()} - {person.PhoneNumber}");
                }
            }
        }
    }
}
