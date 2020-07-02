namespace AutoSalon
{
    partial class FormAvailability
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
            this.labelFirm = new System.Windows.Forms.Label();
            this.labelCar = new System.Windows.Forms.Label();
            this.comboBoxFirm = new System.Windows.Forms.ComboBox();
            this.comboBoxCar = new System.Windows.Forms.ComboBox();
            this.listViewAv = new System.Windows.Forms.ListView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.IdFirm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameFirm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdCar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameCar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFirm
            // 
            this.labelFirm.AutoSize = true;
            this.labelFirm.Location = new System.Drawing.Point(13, 108);
            this.labelFirm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirm.Name = "labelFirm";
            this.labelFirm.Size = new System.Drawing.Size(55, 19);
            this.labelFirm.TabIndex = 0;
            this.labelFirm.Text = "Фирма";
            // 
            // labelCar
            // 
            this.labelCar.AutoSize = true;
            this.labelCar.Location = new System.Drawing.Point(13, 199);
            this.labelCar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCar.Name = "labelCar";
            this.labelCar.Size = new System.Drawing.Size(93, 19);
            this.labelCar.TabIndex = 1;
            this.labelCar.Text = "Автомобиль";
            // 
            // comboBoxFirm
            // 
            this.comboBoxFirm.FormattingEnabled = true;
            this.comboBoxFirm.Location = new System.Drawing.Point(12, 130);
            this.comboBoxFirm.Name = "comboBoxFirm";
            this.comboBoxFirm.Size = new System.Drawing.Size(227, 27);
            this.comboBoxFirm.TabIndex = 2;
            // 
            // comboBoxCar
            // 
            this.comboBoxCar.FormattingEnabled = true;
            this.comboBoxCar.Location = new System.Drawing.Point(12, 221);
            this.comboBoxCar.Name = "comboBoxCar";
            this.comboBoxCar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxCar.Size = new System.Drawing.Size(227, 27);
            this.comboBoxCar.TabIndex = 3;
            // 
            // listViewAv
            // 
            this.listViewAv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdFirm,
            this.NameFirm,
            this.IdCar,
            this.NameCar});
            this.listViewAv.FullRowSelect = true;
            this.listViewAv.GridLines = true;
            this.listViewAv.HideSelection = false;
            this.listViewAv.Location = new System.Drawing.Point(299, 12);
            this.listViewAv.MultiSelect = false;
            this.listViewAv.Name = "listViewAv";
            this.listViewAv.Size = new System.Drawing.Size(736, 268);
            this.listViewAv.TabIndex = 4;
            this.listViewAv.UseCompatibleStateImageBehavior = false;
            this.listViewAv.View = System.Windows.Forms.View.Details;
            this.listViewAv.SelectedIndexChanged += new System.EventHandler(this.listViewAv_SelectedIndexChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(786, 327);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(171, 48);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Удалить запись";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonRed.FlatAppearance.BorderSize = 0;
            this.buttonRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRed.Location = new System.Drawing.Point(598, 327);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(182, 48);
            this.buttonRed.TabIndex = 16;
            this.buttonRed.Text = "Редактировать запись";
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(410, 327);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(182, 48);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "Создать запись";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // IdFirm
            // 
            this.IdFirm.Text = "Id фирмы";
            this.IdFirm.Width = 100;
            // 
            // NameFirm
            // 
            this.NameFirm.Text = "Наименование и адрес фирмы";
            this.NameFirm.Width = 287;
            // 
            // IdCar
            // 
            this.IdCar.Text = "Id автомобиля";
            this.IdCar.Width = 118;
            // 
            // NameCar
            // 
            this.NameCar.Text = "Модель и цвет машины";
            this.NameCar.Width = 251;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoSalon.Properties.Resources.Лого;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // FormAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(1047, 387);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonRed);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewAv);
            this.Controls.Add(this.comboBoxCar);
            this.Controls.Add(this.comboBoxFirm);
            this.Controls.Add(this.labelCar);
            this.Controls.Add(this.labelFirm);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAvailability";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Наличие";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirm;
        private System.Windows.Forms.Label labelCar;
        private System.Windows.Forms.ComboBox comboBoxFirm;
        private System.Windows.Forms.ComboBox comboBoxCar;
        private System.Windows.Forms.ListView listViewAv;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ColumnHeader IdFirm;
        private System.Windows.Forms.ColumnHeader NameFirm;
        private System.Windows.Forms.ColumnHeader IdCar;
        private System.Windows.Forms.ColumnHeader NameCar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}