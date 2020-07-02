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
    public partial class FormFirms : Form
    {
        public FormFirms()
        {
            InitializeComponent();
            ShowFirm();
        }
        public void ShowFirm()
        {
            listViewFirms.Items.Clear();
            foreach (Firms firm in Program.ADb.Firms)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    firm.Id.ToString(), firm.Name, firm.Address,
                    firm.City, firm.Phone
                });
                item.Tag = firm;
                listViewFirms.Items.Add(item);
            }
            listViewFirms.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Firms firm = new Firms();
                firm.Name = textBoxName.Text;
                firm.Address = textBoxAddress.Text;
                firm.City = textBoxCity.Text;
                firm.Phone = textBoxPhone.Text;
                if (firm.Name == "" || firm.Address == "" || firm.City == "")
                {
                    throw new Exception("Не заполнены поля имени, фамилии или отчества");
                }
                Program.ADb.Firms.Add(firm);
                Program.ADb.SaveChanges();
                ShowFirm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Ошибка!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listViewFirms.SelectedItems.Count == 1)
            {
                Firms firm = listViewFirms.SelectedItems[0].Tag as Firms;
                firm.Name = textBoxName.Text;
                firm.Address = textBoxAddress.Text;
                firm.City = textBoxCity.Text;
                firm.Phone = textBoxPhone.Text;
                Program.ADb.SaveChanges();
                ShowFirm();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewFirms.SelectedItems.Count == 1)
                {
                    Firms firm = listViewFirms.SelectedItems[0].Tag as Firms;
                    Program.ADb.Firms.Remove(firm);
                    Program.ADb.SaveChanges();
                    ShowFirm();
                }
                textBoxName.Text = "";
                textBoxAddress.Text = "";
                textBoxCity.Text = "";
                textBoxPhone.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewFirms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFirms.SelectedItems.Count == 1)
            {
                Firms firm = listViewFirms.SelectedItems[0].Tag as Firms;
                textBoxName.Text = firm.Name;
                textBoxAddress.Text = firm.Address;
                textBoxCity.Text = firm.City;
                textBoxPhone.Text = firm.Phone;
            }
            else
            {
                textBoxName.Text = "";
                textBoxAddress.Text = "";
                textBoxCity.Text = "";
                textBoxPhone.Text = "";
            }
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && 
                (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61)
            {
                e.Handled = true;
            }
        }
    }
}
