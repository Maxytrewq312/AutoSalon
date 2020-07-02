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
    public partial class FormAvailability : Form
    {
        public FormAvailability()
        {
            InitializeComponent();
            ShowFirms();
            ShowCar();
            ShowNal();
        }
        public void ShowFirms()
        {
            comboBoxFirm.Items.Clear();
            foreach (Firms firm in Program.ADb.Firms)
            {
                string[] item = {firm.Id.ToString() + ".", firm.Name, firm.Address };
                comboBoxFirm.Items.Add(string.Join(" ", item));
            }
        }
        public void ShowCar()
        {
            comboBoxCar.Items.Clear();
            foreach (Cars car in Program.ADb.Cars)
            {
                string[] item = { car.Id.ToString() + ".", car.Model, car.Colour};
                comboBoxCar.Items.Add(string.Join(" ", item));
            }
        }
        public void ShowNal()
        {
            listViewAv.Items.Clear();
            foreach (Availability av in Program.ADb.Availability)
            {
                ListViewItem item = new ListViewItem(new string[]
                { 
                    av.IdFirm.ToString(),
                    av.Firms.Name + " " + av.Firms.Address,
                    av.IdCar.ToString(), 
                    av.Cars.Model + " " + av.Cars.Colour
                });
                item.Tag = av;
                listViewAv.Items.Add(item);
            }
            listViewAv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void listViewAv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAv.SelectedItems.Count == 1)
            {
                Availability av = listViewAv.SelectedItems[0].Tag as Availability;
                comboBoxFirm.SelectedIndex = comboBoxFirm.FindString(av.IdFirm.ToString());
                comboBoxCar.SelectedIndex = comboBoxCar.FindString(av.IdCar.ToString());
            }
            else
            {
                comboBoxFirm.SelectedItem = null;
                comboBoxCar.SelectedItem = null;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxFirm.SelectedItem != null && comboBoxCar.SelectedItem != null)
            {
                Availability av = new Availability();
                av.IdFirm = Convert.ToInt32(comboBoxFirm.SelectedItem.ToString().Split('.')[0]);
                av.IdCar = Convert.ToInt32(comboBoxCar.SelectedItem.ToString().Split('.')[0]);
                Program.ADb.Availability.Add(av);
                Program.ADb.SaveChanges();
                ShowNal();
            }
            else
            {
                MessageBox.Show("Данные не выбраны", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            if (listViewAv.SelectedItems.Count == 1)
            {
                Availability av = listViewAv.SelectedItems[0].Tag as Availability;
                av.IdFirm = Convert.ToInt32(comboBoxFirm.SelectedItem.ToString().Split('.')[0]);
                av.IdCar = Convert.ToInt32(comboBoxCar.SelectedItem.ToString().Split('.')[0]);
                Program.ADb.SaveChanges();
                ShowNal();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAv.SelectedItems.Count == 1)
                {
                    Availability av = listViewAv.SelectedItems[0].Tag as Availability;
                    Program.ADb.Availability.Remove(av);
                    Program.ADb.SaveChanges();
                }
                comboBoxFirm.SelectedItem = null;
                comboBoxCar.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
