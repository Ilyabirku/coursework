using System.Runtime.InteropServices;

namespace Курсовая
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (
                textBox1.Text == "" ||
                textBox2.Text == "" ||
                textBox3.Text == "" ||
                textBox4.Text == "" ||
                textBox5.Text == "" ||
                textBox6.Text == "" ||
                textBox7.Text == "" ||
                textBox8.Text == "" ||
                textBox9.Text == "" ||
                textBox10.Text == "" ||
                textBox11.Text == ""
                )
            {
                MessageBox.Show(
                    "Все обязательные поля должны быть заполненны.\n" +
                    "Если у вас нет данных для некоторых из низ укажите 0",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                );
            }
            else
            {
                double additionally = 0.0;
                foreach (var item in listBox1.Items)
                {
                    additionally += Convert.ToDouble(item.ToString());
                }
                double work = Convert.ToDouble(textBox9.Text);
                double work_weight = Convert.ToDouble(textBox8.Text);
                double order = Convert.ToDouble(textBox10.Text);
                double count = Convert.ToDouble(textBox11.Text);
                double rate = Convert.ToDouble(textBox4.Text);
                double material = Convert.ToDouble(textBox7.Text);
                dataGridView1.Rows[0].Cells[1].Value = textBox9.Text; // Работа
                dataGridView1.Rows[0].Cells[2].Value = textBox8.Text; // Трудоемкость
                dataGridView1.Rows[0].Cells[3].Value = textBox10.Text; // Заказ
                dataGridView1.Rows[0].Cells[4].Value = additionally; // Дополнительные
                dataGridView1.Rows[0].Cells[5].Value = textBox11.Text; // Колличество
                dataGridView1.Rows[0].Cells[6].Value = textBox4.Text; // Коэффициент
                dataGridView1.Rows[0].Cells[7].Value = textBox7.Text; // Материалы
                dataGridView1.Rows[0].Cells[0].Value = ((work + work_weight + order + rate) * count + material + additionally).ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = textBox12.Text;
            if (value.Length > 0)
            {
                if (listBox1.Items[0].ToString() == "Пока тут пусто, начните добовлять элементы")
                {
                    listBox1.Items.Clear();
                }
                listBox1.Items.Add(value);
                textBox12.Clear();
            }
            else
            {
                MessageBox.Show(
                "Поле дополнительные расходы должны быть заполнены",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly
            );
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.ReadOnly = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.ReadOnly = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Cells[1].Value = "";
            dataGridView1.Rows[0].Cells[2].Value = "";
            dataGridView1.Rows[0].Cells[3].Value = "";
            dataGridView1.Rows[0].Cells[4].Value = "";
            dataGridView1.Rows[0].Cells[5].Value = "";
            dataGridView1.Rows[0].Cells[6].Value = "";
            dataGridView1.Rows[0].Cells[7].Value = "";
            dataGridView1.Rows[0].Cells[0].Value = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Cells[1].Value = "";
            dataGridView1.Rows[0].Cells[2].Value = "";
            dataGridView1.Rows[0].Cells[3].Value = "";
            dataGridView1.Rows[0].Cells[4].Value = "";
            dataGridView1.Rows[0].Cells[5].Value = "";
            dataGridView1.Rows[0].Cells[6].Value = "";
            dataGridView1.Rows[0].Cells[7].Value = "";
            dataGridView1.Rows[0].Cells[0].Value = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            listBox1.Items.Clear();
            listBox1.Items.Add("Пока тут пусто, начните добовлять элементы");
        }
    }
}
