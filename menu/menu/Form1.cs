namespace menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double total;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Burger - 6.30");
            total += 6.30;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("cake - 4.50");
            total += 4.50;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("yellowtea - 2.00");
            total += 2.00;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("hotdog - 3.00");
            total += 3.00;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("cofee - 5.00");
            total += 5.00;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("nuggets - 10.00");
            total += 10.00;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("pizza - 10.00");
            total += 10.00;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("cola - 1.50");
            total += 1.50;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("chicken - 6.00");
            total += 6.00;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string secilenMehsul = listBox1.SelectedItem.ToString();

                string qiymetHissesi = secilenMehsul.Split('-')[1].Trim();
                total -= Convert.ToDouble(qiymetHissesi.Replace('.', ','));

                listBox1.Items.RemoveAt(listBox1.SelectedIndex);

                MessageBox.Show($"{secilenMehsul} sebetden silindi!", "Bildiris", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = total.ToString("0.00") + " AZN";
            }
            else
            {
                MessageBox.Show("Zehmet olmasa silmek ucun siyahidan bir mehsul secin!", "Diqqet", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult cavab = MessageBox.Show("Xanalar sifirlansinmi?", "Tesdiq", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cavab == DialogResult.Yes)
            {
                listBox1.Items.Clear();
                total = 0;

                MessageBox.Show("Melumatlar sifirlandi.", "Ugurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Sebetiniz bosdur!", "Diqqet", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
            }
            else
            {
                textBox1.Text = total.ToString("0.00") + " AZN";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(maskedTextBox1.Text.Replace('.', ','), out double daxilEdilenPul))
            {
                if (daxilEdilenPul < total)
                {
                    MessageBox.Show("Daxil edilen mebleg hesabdan azdir!", "Diqqet", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    double qaliq = daxilEdilenPul - total;

                    label3.Text = "Qaytarilir: " + qaliq.ToString("0.00") + " AZN";

                    MessageBox.Show("Odenis qebul olundu. Nus olsun!", "Ugurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Zehmet olmasa duzgun pul miqdari daxil edin!", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
            label3.Text = "Qaytarılır:        0";
        }
    }
}