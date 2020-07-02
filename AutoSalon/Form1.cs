using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSalon
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonFirms_Click(object sender, EventArgs e)
        {
            Form ff = new FormFirms();
            ff.Show();
        }

        private void buttonCars_Click(object sender, EventArgs e)
        {
            Form fc = new FormCars();
            fc.Show();
        }

        private void buttonAvaila_Click(object sender, EventArgs e)
        {
            Form fa = new FormAvailability();
            fa.Show();
        }
    }
}
