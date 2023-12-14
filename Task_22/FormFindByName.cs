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
    public partial class FormFindByName : Form
    {
        internal List<Person> SearchResult { get; private set; }

        public FormFindByName()
        {
            InitializeComponent();
        }

        private void labelFindName_Click(object sender, EventArgs e)
        {

        }

        private void buttonFindName_Click(object sender, EventArgs e)
        {
            var searchText = textBoxFindName.Text.ToLower();
            var people = Person.ReadFromTextFile("data.txt");

            SearchResult = people.Where(p => p.Name.ToLower().Contains(searchText)).ToList();

            this.DialogResult = DialogResult.OK; // Установить результат диалога
            this.Close(); // Закрыть форму после выполнения поиска
        }
    }
}
