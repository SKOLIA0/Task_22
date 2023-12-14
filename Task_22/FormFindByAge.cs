using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_22
{
    public partial class FormFindByAge : Form
    {
        internal List<Person> SearchResult { get; private set; }

        public FormFindByAge()
        {
            InitializeComponent();
        }

        private void buttonFindAge_Click(object sender, EventArgs e)
        {
            int ageFrom = (int)numericUpDownFindAgeFrom.Value;
            int ageTo = (int)numericUpDownAgeTo.Value;
            var people = Person.ReadFromTextFile("data.txt");

            SearchResult = people.Where(p =>
            {
                int age = DateTime.Now.Year - p.DateOfBirth.Year;
                if (p.DateOfBirth > DateTime.Now.AddYears(-age)) age--;
                return age >= ageFrom && age <= ageTo;
            })
             .ToList();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
