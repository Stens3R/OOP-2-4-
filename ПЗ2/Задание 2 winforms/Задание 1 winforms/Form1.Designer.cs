namespace Задание_1_winforms
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.start_colection_button = new System.Windows.Forms.Button();
            this.stop_colection_button = new System.Windows.Forms.Button();
            this.metricValueBox = new System.Windows.Forms.TextBox();
            this.imperialValueBox = new System.Windows.Forms.TextBox();
            this.most_recent_valueTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.raw_data = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.destroy_class_button = new System.Windows.Forms.Button();
            this.Единицы = new System.Windows.Forms.GroupBox();
            this.radioButton_metric_value = new System.Windows.Forms.RadioButton();
            this.radioButton_imperial_value = new System.Windows.Forms.RadioButton();
            this.create_class_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton_mass_device = new System.Windows.Forms.RadioButton();
            this.radioButton_lenght_device = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.HeartBeatTimestamp_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Единицы.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(537, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(118, 256);
            this.dataGridView1.TabIndex = 0;
            // 
            // start_colection_button
            // 
            this.start_colection_button.Location = new System.Drawing.Point(18, 262);
            this.start_colection_button.Name = "start_colection_button";
            this.start_colection_button.Size = new System.Drawing.Size(119, 25);
            this.start_colection_button.TabIndex = 1;
            this.start_colection_button.Text = "start_colection_button";
            this.start_colection_button.UseVisualStyleBackColor = true;
            this.start_colection_button.Click += new System.EventHandler(this.start_colection_button_Click);
            // 
            // stop_colection_button
            // 
            this.stop_colection_button.Location = new System.Drawing.Point(143, 262);
            this.stop_colection_button.Name = "stop_colection_button";
            this.stop_colection_button.Size = new System.Drawing.Size(119, 25);
            this.stop_colection_button.TabIndex = 2;
            this.stop_colection_button.Text = "stop_colection_button";
            this.stop_colection_button.UseVisualStyleBackColor = true;
            this.stop_colection_button.Click += new System.EventHandler(this.stop_colection_button_Click);
            // 
            // metricValueBox
            // 
            this.metricValueBox.Location = new System.Drawing.Point(378, 12);
            this.metricValueBox.Name = "metricValueBox";
            this.metricValueBox.Size = new System.Drawing.Size(100, 20);
            this.metricValueBox.TabIndex = 3;
            // 
            // imperialValueBox
            // 
            this.imperialValueBox.Location = new System.Drawing.Point(378, 65);
            this.imperialValueBox.Name = "imperialValueBox";
            this.imperialValueBox.Size = new System.Drawing.Size(100, 20);
            this.imperialValueBox.TabIndex = 4;
            // 
            // most_recent_valueTextBox
            // 
            this.most_recent_valueTextBox.Location = new System.Drawing.Point(378, 133);
            this.most_recent_valueTextBox.Name = "most_recent_valueTextBox";
            this.most_recent_valueTextBox.Size = new System.Drawing.Size(100, 20);
            this.most_recent_valueTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "metric";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "imperial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "most recent value";
            // 
            // raw_data
            // 
            this.raw_data.AutoSize = true;
            this.raw_data.Location = new System.Drawing.Point(534, 12);
            this.raw_data.Name = "raw_data";
            this.raw_data.Size = new System.Drawing.Size(48, 13);
            this.raw_data.TabIndex = 9;
            this.raw_data.Text = "raw data";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.destroy_class_button);
            this.groupBox1.Controls.Add(this.Единицы);
            this.groupBox1.Controls.Add(this.create_class_button);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 214);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создать класс";
            // 
            // destroy_class_button
            // 
            this.destroy_class_button.Location = new System.Drawing.Point(117, 185);
            this.destroy_class_button.Name = "destroy_class_button";
            this.destroy_class_button.Size = new System.Drawing.Size(75, 23);
            this.destroy_class_button.TabIndex = 13;
            this.destroy_class_button.Text = "Удалить";
            this.destroy_class_button.UseVisualStyleBackColor = true;
            this.destroy_class_button.Click += new System.EventHandler(this.destroy_class_button_Click);
            // 
            // Единицы
            // 
            this.Единицы.Controls.Add(this.radioButton_metric_value);
            this.Единицы.Controls.Add(this.radioButton_imperial_value);
            this.Единицы.Location = new System.Drawing.Point(6, 94);
            this.Единицы.Name = "Единицы";
            this.Единицы.Size = new System.Drawing.Size(95, 64);
            this.Единицы.TabIndex = 3;
            this.Единицы.TabStop = false;
            this.Единицы.Text = "Единицы";
            // 
            // radioButton_metric_value
            // 
            this.radioButton_metric_value.AutoSize = true;
            this.radioButton_metric_value.Location = new System.Drawing.Point(6, 21);
            this.radioButton_metric_value.Name = "radioButton_metric_value";
            this.radioButton_metric_value.Size = new System.Drawing.Size(53, 17);
            this.radioButton_metric_value.TabIndex = 2;
            this.radioButton_metric_value.TabStop = true;
            this.radioButton_metric_value.Text = "metric";
            this.radioButton_metric_value.UseVisualStyleBackColor = true;
            // 
            // radioButton_imperial_value
            // 
            this.radioButton_imperial_value.AutoSize = true;
            this.radioButton_imperial_value.Location = new System.Drawing.Point(6, 44);
            this.radioButton_imperial_value.Name = "radioButton_imperial_value";
            this.radioButton_imperial_value.Size = new System.Drawing.Size(60, 17);
            this.radioButton_imperial_value.TabIndex = 3;
            this.radioButton_imperial_value.TabStop = true;
            this.radioButton_imperial_value.Text = "imperial";
            this.radioButton_imperial_value.UseVisualStyleBackColor = true;
            // 
            // create_class_button
            // 
            this.create_class_button.Location = new System.Drawing.Point(6, 185);
            this.create_class_button.Name = "create_class_button";
            this.create_class_button.Size = new System.Drawing.Size(75, 23);
            this.create_class_button.TabIndex = 12;
            this.create_class_button.Text = "Создать";
            this.create_class_button.UseVisualStyleBackColor = true;
            this.create_class_button.Click += new System.EventHandler(this.create_class_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.radioButton_mass_device);
            this.groupBox2.Controls.Add(this.radioButton_lenght_device);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(95, 69);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Класс";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(172, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(116, 44);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // radioButton_mass_device
            // 
            this.radioButton_mass_device.AutoSize = true;
            this.radioButton_mass_device.Location = new System.Drawing.Point(6, 19);
            this.radioButton_mass_device.Name = "radioButton_mass_device";
            this.radioButton_mass_device.Size = new System.Drawing.Size(84, 17);
            this.radioButton_mass_device.TabIndex = 0;
            this.radioButton_mass_device.TabStop = true;
            this.radioButton_mass_device.Text = "mass device";
            this.radioButton_mass_device.UseVisualStyleBackColor = true;
            // 
            // radioButton_lenght_device
            // 
            this.radioButton_lenght_device.AutoSize = true;
            this.radioButton_lenght_device.Location = new System.Drawing.Point(6, 42);
            this.radioButton_lenght_device.Name = "radioButton_lenght_device";
            this.radioButton_lenght_device.Size = new System.Drawing.Size(89, 17);
            this.radioButton_lenght_device.TabIndex = 1;
            this.radioButton_lenght_device.TabStop = true;
            this.radioButton_lenght_device.Text = "lenght device";
            this.radioButton_lenght_device.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            // 
            // HeartBeatTimestamp_label
            // 
            this.HeartBeatTimestamp_label.AutoSize = true;
            this.HeartBeatTimestamp_label.Location = new System.Drawing.Point(309, 207);
            this.HeartBeatTimestamp_label.Name = "HeartBeatTimestamp_label";
            this.HeartBeatTimestamp_label.Size = new System.Drawing.Size(115, 13);
            this.HeartBeatTimestamp_label.TabIndex = 13;
            this.HeartBeatTimestamp_label.Text = "HeartBeat Timestamp: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 303);
            this.Controls.Add(this.HeartBeatTimestamp_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.raw_data);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.most_recent_valueTextBox);
            this.Controls.Add(this.imperialValueBox);
            this.Controls.Add(this.metricValueBox);
            this.Controls.Add(this.stop_colection_button);
            this.Controls.Add(this.start_colection_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.Единицы.ResumeLayout(false);
            this.Единицы.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button start_colection_button;
        private System.Windows.Forms.Button stop_colection_button;
        private System.Windows.Forms.TextBox metricValueBox;
        private System.Windows.Forms.TextBox imperialValueBox;
        private System.Windows.Forms.TextBox most_recent_valueTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label raw_data;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_mass_device;
        private System.Windows.Forms.RadioButton radioButton_lenght_device;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button destroy_class_button;
        private System.Windows.Forms.GroupBox Единицы;
        private System.Windows.Forms.RadioButton radioButton_metric_value;
        private System.Windows.Forms.RadioButton radioButton_imperial_value;
        private System.Windows.Forms.Button create_class_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label HeartBeatTimestamp_label;
    }
}

