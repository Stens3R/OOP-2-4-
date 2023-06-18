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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.raw_data = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(670, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(118, 256);
            this.dataGridView1.TabIndex = 0;
            // 
            // start_colection_button
            // 
            this.start_colection_button.Location = new System.Drawing.Point(129, 232);
            this.start_colection_button.Name = "start_colection_button";
            this.start_colection_button.Size = new System.Drawing.Size(119, 25);
            this.start_colection_button.TabIndex = 1;
            this.start_colection_button.Text = "start_colection_button";
            this.start_colection_button.UseVisualStyleBackColor = true;
            this.start_colection_button.Click += new System.EventHandler(this.start_colection_button_Click);
            // 
            // stop_colection_button
            // 
            this.stop_colection_button.Location = new System.Drawing.Point(129, 272);
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(378, 133);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
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
            this.label3.Location = new System.Drawing.Point(309, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // raw_data
            // 
            this.raw_data.AutoSize = true;
            this.raw_data.Location = new System.Drawing.Point(534, 40);
            this.raw_data.Name = "raw_data";
            this.raw_data.Size = new System.Drawing.Size(48, 13);
            this.raw_data.TabIndex = 9;
            this.raw_data.Text = "raw data";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(537, 68);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(118, 256);
            this.dataGridView2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.raw_data);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.imperialValueBox);
            this.Controls.Add(this.metricValueBox);
            this.Controls.Add(this.stop_colection_button);
            this.Controls.Add(this.start_colection_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button start_colection_button;
        private System.Windows.Forms.Button stop_colection_button;
        private System.Windows.Forms.TextBox metricValueBox;
        private System.Windows.Forms.TextBox imperialValueBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label raw_data;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

