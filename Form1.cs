using System.Globalization;
using System.Text;

namespace Classwork_Core
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int a = 0;
        public int[,] Mas = new int[5,5];
        public int[] mass = new int[5];
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            Con();
        }

        void Con()
        {
            foreach (char c in textBox1.Text)
            {
                if (char.IsLetter(c))
                {
                    if (char.IsUpper(c)) textBox2.Text += char.ToLower(c);

                    else if (char.IsLower(c)) textBox2.Text += char.ToUpper(c);
                }
                else textBox2.Text += c;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 5;
            dataGridView1.ColumnCount = 5;

            Random ran = new Random();
            for (int i = 0; i < Mas.GetLength(0) ; i++)
            {
                for (int j = 0; j < Mas.GetLength(1); j++)
                {
                    Mas[i, j] = ran.Next(2);
                    dataGridView1.Rows[i].Cells[j].Value = Mas[i, j].ToString();
                }
            }
            a = 0;
            Mas_sum();
            textBox3.Text = Convert.ToString(a);
        }

        void Mas_sum()
        {
            for (int i = 0; i < Mas.GetLength(0); i++)
            {
                for (int j = 0; j < Mas.GetLength(1); j++)
                {
                    mass[j] = Mas[i, j];
                }
                a += mass.Sum();
                mass[i] = Mas[i, i];
            }

            for (int i = 0; i < Mas.GetLength(0); i++)
            {
                mass[i] = Mas[i, i];
            }
            a -= mass.Sum();
        }

    }
}