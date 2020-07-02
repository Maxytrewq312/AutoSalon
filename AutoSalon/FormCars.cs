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
    public partial class FormCars : Form
    {
        public FormCars()
        {
            InitializeComponent();
            ShowCars();
        }
        public void ShowCars()
        {
            listViewCars.Items.Clear();
            foreach (Cars car in Program.ADb.Cars)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    car.Id.ToString(), car.Model, car.Colour,
                    car.Price, car.GosNumber.ToString(), car.Year.ToString()
                });
                item.Tag = car;
                listViewCars.Items.Add(item);
            }
            listViewCars.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void listViewCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCars.SelectedItems.Count == 1)
            {
                Cars car = listViewCars.SelectedItems[0].Tag as Cars;
                textBoxModel.Text = car.Model;
                comboBoxColour.Text = car.Colour;
                textBoxPrice.Text = car.Price;
                textBoxGosNumber.Text = car.GosNumber.ToString();
                textBoxYear.Text = car.Year.ToString();
            }
            else
            {
                textBoxModel.Text = "";
                comboBoxColour.Text = "";
                textBoxPrice.Text = "";
                textBoxGosNumber.Text = "";
                textBoxYear.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Cars car = new Cars();
                car.Model = textBoxModel.Text;
                car.Colour = comboBoxColour.Text;
                car.Price = textBoxPrice.Text;
                car.GosNumber = Convert.ToInt32(textBoxGosNumber.Text);
                car.Year = Convert.ToInt32(textBoxYear.Text);
                if (car.Model == "" || car.Colour == "" || car.Price == "")
                {
                    throw new Exception("Не заполнены поля модели, цвета или цены");
                }
                Program.ADb.Cars.Add(car);
                Program.ADb.SaveChanges();
                ShowCars();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Ошибка!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            if (listViewCars.SelectedItems.Count == 1)
            {
                Cars car = listViewCars.SelectedItems[0].Tag as Cars;
                car.Model = textBoxModel.Text;
                car.Colour = comboBoxColour.Text;
                car.Price = textBoxPrice.Text;
                car.GosNumber = Convert.ToInt32(textBoxGosNumber.Text);
                car.Year = Convert.ToInt32(textBoxYear.Text);
                Program.ADb.SaveChanges();
                ShowCars();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewCars.SelectedItems.Count == 1)
                {
                    Cars car = listViewCars.SelectedItems[0].Tag as Cars;
                    Program.ADb.Cars.Remove(car);
                    Program.ADb.SaveChanges();
                    ShowCars();
                }
                textBoxModel.Text = "";
                comboBoxColour.Text = "";
                textBoxPrice.Text = "";
                textBoxGosNumber.Text = "";
                textBoxYear.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && 
                (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61)
            {
                e.Handled = true;
            }
        }

        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxYear_KeyPress(object sender, KeyPressEventArgs e)
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
