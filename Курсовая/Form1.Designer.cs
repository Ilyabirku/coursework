using System.Configuration;
using System.Runtime.InteropServices;

namespace Курсовая
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            panel1 = new Panel();
            textBox4 = new TextBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label4 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            label11 = new Label();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            pictureBox2 = new PictureBox();
            groupBox3 = new GroupBox();
            pictureBox4 = new PictureBox();
            groupBox4 = new GroupBox();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            textBox11 = new TextBox();
            pictureBox5 = new PictureBox();
            listBox1 = new ListBox();
            textBox12 = new TextBox();
            button1 = new Button();
            groupBox5 = new GroupBox();
            button2 = new Button();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            Итого = new DataGridViewTextBoxColumn();
            Работа = new DataGridViewTextBoxColumn();
            Трудоемкость = new DataGridViewTextBoxColumn();
            Заказ = new DataGridViewTextBoxColumn();
            Дополнительные = new DataGridViewTextBoxColumn();
            Количество = new DataGridViewTextBoxColumn();
            Коэффициент = new DataGridViewTextBoxColumn();
            Материалы = new DataGridViewTextBoxColumn();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(54, 19);
            label1.TabIndex = 0;
            label1.Text = "Номер";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(376, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(474, 8);
            label2.Name = "label2";
            label2.Size = new Size(108, 19);
            label2.TabIndex = 2;
            label2.Text = "Разработчик";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(811, 8);
            label3.Name = "label3";
            label3.Size = new Size(81, 19);
            label3.TabIndex = 3;
            label3.Text = "Заказчик";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(474, 31);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(281, 27);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(811, 31);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(289, 27);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Location = new Point(766, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 119);
            panel1.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(187, 71);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(93, 27);
            textBox4.TabIndex = 2;
            textBox4.Text = "1";
            textBox4.KeyPress += textBox4_KeyPress;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(19, 71);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(156, 23);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Ручное задание";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(19, 19);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(255, 23);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Автоматическое вычесление";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(831, 95);
            label4.Name = "label4";
            label4.Size = new Size(234, 19);
            label4.TabIndex = 7;
            label4.Text = "Коэффициент эффективности";
            label4.Click += label4_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 107);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(376, 27);
            textBox5.TabIndex = 8;
            textBox5.KeyPress += textBox5_KeyPress;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 191);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(376, 27);
            textBox6.TabIndex = 9;
            textBox6.KeyPress += textBox6_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 84);
            label5.Name = "label5";
            label5.Size = new Size(189, 19);
            label5.TabIndex = 10;
            label5.Text = "Наименование изделия";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 169);
            label6.Name = "label6";
            label6.Size = new Size(144, 19);
            label6.TabIndex = 11;
            label6.Text = "Артикул изделия";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(7, 24);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(257, 27);
            textBox7.TabIndex = 16;
            textBox7.Text = "0";
            textBox7.TextChanged += textBox7_TextChanged;
            textBox7.KeyPress += textBox7_KeyPress;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(7, 24);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(250, 27);
            textBox8.TabIndex = 17;
            textBox8.Text = "0";
            textBox8.KeyPress += textBox8_KeyPress;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(7, 24);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(257, 27);
            textBox9.TabIndex = 18;
            textBox9.Text = "0";
            textBox9.KeyPress += textBox9_KeyPress;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(7, 24);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(199, 27);
            textBox10.TabIndex = 19;
            textBox10.Text = "0";
            textBox10.KeyPress += textBox10_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(213, 32);
            label11.Name = "label11";
            label11.Size = new Size(54, 19);
            label11.TabIndex = 20;
            label11.Text = "в-час";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Location = new Point(26, 243);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(334, 69);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Стоимость материала";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.материал;
            pictureBox1.Location = new Point(281, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(textBox9);
            groupBox2.Location = new Point(26, 326);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(334, 68);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Стоимость работы";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.работа;
            pictureBox2.Location = new Point(281, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pictureBox4);
            groupBox3.Controls.Add(textBox10);
            groupBox3.Controls.Add(label11);
            groupBox3.Location = new Point(26, 494);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(334, 66);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "Стоимость заказа";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.заказ;
            pictureBox4.Location = new Point(281, 11);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(47, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 21;
            pictureBox4.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(pictureBox3);
            groupBox4.Controls.Add(textBox8);
            groupBox4.Location = new Point(26, 409);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(334, 68);
            groupBox4.TabIndex = 24;
            groupBox4.TabStop = false;
            groupBox4.Text = "Трудоемкость";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.контейнер;
            pictureBox3.Location = new Point(281, 11);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(47, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(474, 169);
            label7.Name = "label7";
            label7.Size = new Size(171, 19);
            label7.TabIndex = 25;
            label7.Text = "Количество изделий";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(474, 191);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(254, 27);
            textBox11.TabIndex = 26;
            textBox11.Text = "1";
            textBox11.TextChanged += textBox11_TextChanged;
            textBox11.KeyPress += textBox11_KeyPress;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.мебель;
            pictureBox5.Location = new Point(474, 75);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(88, 74);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 27;
            pictureBox5.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 19;
            listBox1.Items.AddRange(new object[] { "Пока тут пусто, начните добовлять элементы" });
            listBox1.Location = new Point(36, 67);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(394, 99);
            listBox1.TabIndex = 28;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(36, 26);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(268, 27);
            textBox12.TabIndex = 30;
            textBox12.TextChanged += textBox12_TextChanged;
            textBox12.KeyPress += textBox12_KeyPress;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.WindowText;
            button1.Font = new Font("JetBrains Mono SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(310, 15);
            button1.Name = "button1";
            button1.Size = new Size(117, 47);
            button1.TabIndex = 31;
            button1.Text = "добавить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBox12);
            groupBox5.Controls.Add(button1);
            groupBox5.Controls.Add(listBox1);
            groupBox5.Location = new Point(433, 243);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(458, 174);
            groupBox5.TabIndex = 32;
            groupBox5.TabStop = false;
            groupBox5.Text = "Дополнительные расходы";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Font = new Font("JetBrains Mono SemiBold", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.ForeColor = Color.White;
            button2.Location = new Point(912, 332);
            button2.Name = "button2";
            button2.Size = new Size(232, 77);
            button2.TabIndex = 33;
            button2.Text = "Рассчитать стоимость";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(433, 441);
            label8.Name = "label8";
            label8.Size = new Size(171, 19);
            label8.TabIndex = 35;
            label8.Text = "Смета по стоимости";
            label8.Click += label8_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] {
                Итого,
                Работа,
                Трудоемкость,
                Заказ,
                Дополнительные,
                Количество,
                Коэффициент,
                Материалы
            });
            dataGridView1.Location = new Point(433, 463);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(711, 108);
            dataGridView1.TabIndex = 36;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Итого
            // 
            Итого.HeaderText = "Итого";
            Итого.MinimumWidth = 6;
            Итого.Name = "Итого";
            Итого.ReadOnly = true;
            Итого.Width = 125;
            // 
            // Работа
            // 
            Работа.HeaderText = "Работа";
            Работа.MinimumWidth = 6;
            Работа.Name = "Работа";
            Работа.ReadOnly = true;
            Работа.Width = 125;
            // 
            // Трудоемкость
            // 
            Трудоемкость.HeaderText = "Трудоемкость";
            Трудоемкость.MinimumWidth = 6;
            Трудоемкость.Name = "Трудоемкость";
            Трудоемкость.ReadOnly = true;
            Трудоемкость.Width = 125;
            // 
            // Заказ
            // 
            Заказ.HeaderText = "Заказ";
            Заказ.MinimumWidth = 6;
            Заказ.Name = "Заказ";
            Заказ.ReadOnly = true;
            Заказ.Width = 125;
            // 
            // Дополнительные
            // 
            Дополнительные.HeaderText = "Дополнительные";
            Дополнительные.MinimumWidth = 6;
            Дополнительные.Name = "Дополнительные";
            Дополнительные.ReadOnly = true;
            Дополнительные.Width = 125;
            // 
            // Количество
            // 
            Количество.HeaderText = "Количество";
            Количество.MinimumWidth = 6;
            Количество.Name = "Количество";
            Количество.ReadOnly = true;
            Количество.Width = 125;
            // 
            // Коэффициент
            // 
            Коэффициент.HeaderText = "Коэффициент";
            Коэффициент.MinimumWidth = 6;
            Коэффициент.Name = "Коэффициент";
            Коэффициент.ReadOnly = true;
            Коэффициент.Width = 125;
            // 
            // Материалы
            // 
            Материалы.HeaderText = "Материалы";
            Материалы.MinimumWidth = 6;
            Материалы.Name = "Материалы";
            Материалы.ReadOnly = true;
            Материалы.Width = 125;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.Font = new Font("JetBrains Mono SemiBold", 9F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(912, 269);
            button3.Name = "button3";
            button3.Size = new Size(116, 62);
            button3.TabIndex = 37;
            button3.Text = "очистить смету";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaptionText;
            button4.Font = new Font("JetBrains Mono SemiBold", 9F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(1028, 269);
            button4.Name = "button4";
            button4.Size = new Size(116, 62);
            button4.TabIndex = 38;
            button4.Text = "очистить все";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1158, 583);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(groupBox5);
            Controls.Add(pictureBox5);
            Controls.Add(textBox11);
            Controls.Add(label7);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("JetBrains Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Мебельщик";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Panel panel1;
        private Label label4;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label5;
        private Label label6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private Label label11;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label7;
        private TextBox textBox11;
        private PictureBox pictureBox5;
        private ListBox listBox1;
        private TextBox textBox12;
        private Button button1;
        private GroupBox groupBox5;
        private Button button2;
        private Label label8;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Итого;
        private DataGridViewTextBoxColumn Работа;
        private DataGridViewTextBoxColumn Трудоемкость;
        private DataGridViewTextBoxColumn Заказ;
        private DataGridViewTextBoxColumn Дополнительные;
        private DataGridViewTextBoxColumn Количество;
        private DataGridViewTextBoxColumn Коэффициент;
        private DataGridViewTextBoxColumn Материалы;
        private Button button3;
        private Button button4;
    }
}
