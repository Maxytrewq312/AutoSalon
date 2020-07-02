namespace AutoSalon
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonFirms = new System.Windows.Forms.Button();
            this.buttonCars = new System.Windows.Forms.Button();
            this.buttonAvaila = new System.Windows.Forms.Button();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFirms
            // 
            this.buttonFirms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonFirms.FlatAppearance.BorderSize = 0;
            this.buttonFirms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFirms.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFirms.Location = new System.Drawing.Point(12, 224);
            this.buttonFirms.Name = "buttonFirms";
            this.buttonFirms.Size = new System.Drawing.Size(366, 48);
            this.buttonFirms.TabIndex = 1;
            this.buttonFirms.Text = "Фирмы";
            this.buttonFirms.UseVisualStyleBackColor = false;
            this.buttonFirms.Click += new System.EventHandler(this.buttonFirms_Click);
            // 
            // buttonCars
            // 
            this.buttonCars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonCars.FlatAppearance.BorderSize = 0;
            this.buttonCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCars.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCars.Location = new System.Drawing.Point(12, 307);
            this.buttonCars.Name = "buttonCars";
            this.buttonCars.Size = new System.Drawing.Size(366, 48);
            this.buttonCars.TabIndex = 2;
            this.buttonCars.Text = "Автомобили";
            this.buttonCars.UseVisualStyleBackColor = false;
            this.buttonCars.Click += new System.EventHandler(this.buttonCars_Click);
            // 
            // buttonAvaila
            // 
            this.buttonAvaila.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonAvaila.FlatAppearance.BorderSize = 0;
            this.buttonAvaila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAvaila.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAvaila.Location = new System.Drawing.Point(12, 394);
            this.buttonAvaila.Name = "buttonAvaila";
            this.buttonAvaila.Size = new System.Drawing.Size(366, 48);
            this.buttonAvaila.TabIndex = 3;
            this.buttonAvaila.Text = "Наличие";
            this.buttonAvaila.UseVisualStyleBackColor = false;
            this.buttonAvaila.Click += new System.EventHandler(this.buttonAvaila_Click);
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.BackColor = System.Drawing.Color.White;
            this.pictureBoxCar.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxCar.Image = global::AutoSalon.Properties.Resources.Лого;
            this.pictureBoxCar.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(366, 96);
            this.pictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCar.TabIndex = 0;
            this.pictureBoxCar.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(390, 471);
            this.Controls.Add(this.buttonAvaila);
            this.Controls.Add(this.buttonCars);
            this.Controls.Add(this.buttonFirms);
            this.Controls.Add(this.pictureBoxCar);
            this.Name = "Menu";
            this.Text = "Главное меню ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.Button buttonFirms;
        private System.Windows.Forms.Button buttonCars;
        private System.Windows.Forms.Button buttonAvaila;
    }
}

