namespace AutoSalon
{
    partial class FormCars
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelModel = new System.Windows.Forms.Label();
            this.labelColour = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelGosNumber = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxGosNumber = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.comboBoxColour = new System.Windows.Forms.ComboBox();
            this.listViewCars = new System.Windows.Forms.ListView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Colour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GosNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(19, 132);
            this.labelModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(59, 19);
            this.labelModel.TabIndex = 0;
            this.labelModel.Text = "Модель";
            // 
            // labelColour
            // 
            this.labelColour.AutoSize = true;
            this.labelColour.Location = new System.Drawing.Point(19, 191);
            this.labelColour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelColour.Name = "labelColour";
            this.labelColour.Size = new System.Drawing.Size(47, 19);
            this.labelColour.TabIndex = 1;
            this.labelColour.Text = "Цвет";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(19, 250);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(44, 19);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Цена";
            // 
            // labelGosNumber
            // 
            this.labelGosNumber.AutoSize = true;
            this.labelGosNumber.Location = new System.Drawing.Point(19, 312);
            this.labelGosNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGosNumber.Name = "labelGosNumber";
            this.labelGosNumber.Size = new System.Drawing.Size(80, 19);
            this.labelGosNumber.TabIndex = 3;
            this.labelGosNumber.Text = "Гос. номер";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(19, 377);
            this.labelYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(92, 19);
            this.labelYear.TabIndex = 4;
            this.labelYear.Text = "Год выпуска";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(118, 127);
            this.textBoxModel.Multiline = true;
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(229, 24);
            this.textBoxModel.TabIndex = 5;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(118, 245);
            this.textBoxPrice.Multiline = true;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(229, 24);
            this.textBoxPrice.TabIndex = 6;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // textBoxGosNumber
            // 
            this.textBoxGosNumber.Location = new System.Drawing.Point(118, 307);
            this.textBoxGosNumber.Multiline = true;
            this.textBoxGosNumber.Name = "textBoxGosNumber";
            this.textBoxGosNumber.Size = new System.Drawing.Size(229, 24);
            this.textBoxGosNumber.TabIndex = 7;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(118, 372);
            this.textBoxYear.Multiline = true;
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(229, 24);
            this.textBoxYear.TabIndex = 8;
            this.textBoxYear.TextChanged += new System.EventHandler(this.textBoxYear_TextChanged);
            this.textBoxYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxYear_KeyPress);
            // 
            // comboBoxColour
            // 
            this.comboBoxColour.FormattingEnabled = true;
            this.comboBoxColour.Items.AddRange(new object[] {
            "Красный",
            "Черный",
            "Белый",
            "Синий",
            "Фиолетовый",
            "Зеленый"});
            this.comboBoxColour.Location = new System.Drawing.Point(118, 183);
            this.comboBoxColour.Name = "comboBoxColour";
            this.comboBoxColour.Size = new System.Drawing.Size(229, 27);
            this.comboBoxColour.TabIndex = 9;
            // 
            // listViewCars
            // 
            this.listViewCars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Model,
            this.Colour,
            this.Price,
            this.GosNum,
            this.Year});
            this.listViewCars.FullRowSelect = true;
            this.listViewCars.GridLines = true;
            this.listViewCars.HideSelection = false;
            this.listViewCars.Location = new System.Drawing.Point(374, 12);
            this.listViewCars.MultiSelect = false;
            this.listViewCars.Name = "listViewCars";
            this.listViewCars.Size = new System.Drawing.Size(643, 386);
            this.listViewCars.TabIndex = 10;
            this.listViewCars.UseCompatibleStateImageBehavior = false;
            this.listViewCars.View = System.Windows.Forms.View.Details;
            this.listViewCars.SelectedIndexChanged += new System.EventHandler(this.listViewCars_SelectedIndexChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(846, 404);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(171, 48);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Удалить запись";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonRed.FlatAppearance.BorderSize = 0;
            this.buttonRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRed.Location = new System.Drawing.Point(658, 404);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(182, 48);
            this.buttonRed.TabIndex = 13;
            this.buttonRed.Text = "Редактировать запись";
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(470, 404);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(182, 48);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Создать запись";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Model
            // 
            this.Model.Text = "Модель";
            this.Model.Width = 78;
            // 
            // Colour
            // 
            this.Colour.Text = "Цвет";
            this.Colour.Width = 99;
            // 
            // Price
            // 
            this.Price.Text = "Цена";
            this.Price.Width = 122;
            // 
            // GosNum
            // 
            this.GosNum.Text = "Гос. номер";
            this.GosNum.Width = 161;
            // 
            // Year
            // 
            this.Year.Text = "Год выпуска";
            this.Year.Width = 146;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoSalon.Properties.Resources.Лого;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // FormCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(1029, 464);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonRed);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewCars);
            this.Controls.Add(this.comboBoxColour);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxGosNumber);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelGosNumber);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelColour);
            this.Controls.Add(this.labelModel);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автомобили";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelColour;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelGosNumber;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxGosNumber;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.ComboBox comboBoxColour;
        private System.Windows.Forms.ListView listViewCars;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Colour;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader GosNum;
        private System.Windows.Forms.ColumnHeader Year;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}