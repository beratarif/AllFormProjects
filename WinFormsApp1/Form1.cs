using System.IO;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(textBox1.Text);
            int sayi2 = int.Parse(textBox2.Text);
            int toplam = sayi1 + sayi2;
            label1.Text = "Toplam: " + toplam.ToString();
            label1.ForeColor = System.Drawing.Color.Blue;
            Gecmis.Items.Add(sayi1 + " + " + sayi2 + " = " + toplam);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(textBox1.Text);
            int sayi2 = int.Parse(textBox2.Text);
            int fark = sayi1 - sayi2;
            label1.Text = "Fark: " + fark.ToString();
            label1.ForeColor = System.Drawing.Color.Red;
            Gecmis.Items.Add(sayi1 + " - " + sayi2 + " = " + fark);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(textBox1.Text);
            int sayi2 = int.Parse(textBox2.Text);
            int carpim = sayi1 * sayi2;
            label1.Text = "Çarpým: " + carpim.ToString();
            label1.ForeColor = System.Drawing.Color.Green;
            Gecmis.Items.Add(sayi1 + " * " + sayi2 + " = " + carpim);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(textBox1.Text);
            int sayi2 = int.Parse(textBox2.Text);
            if (sayi2 != 0)
            {
                double bolum = (double)sayi1 / sayi2;
                label1.Text = "Bölüm: " + bolum.ToString();
                label1.ForeColor = System.Drawing.Color.Purple;
                Gecmis.Items.Add(sayi1 + " / " + sayi2 + " = " + bolum);

            }
            else
            {
                label1.Text = "Bölme hatasý: Sýfýra bölünemez!";
                label1.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string filePath = "sonuclar.txt";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                foreach (var item in Gecmis.Items)
                {
                    writer.WriteLine(item.ToString());
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "Sonuç: ";
            label1.ForeColor = System.Drawing.Color.Black;
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Gecmis.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();
            label1.Text = "Sonuç: ";
            label1.ForeColor = System.Drawing.Color.Black;
            string filePath = "sonuclar.txt";
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }
}
