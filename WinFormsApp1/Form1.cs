//using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    
    public partial class Form1 : Form
    {
        Form_save Form_Save { get; set; }
        int[] array = new int[5];
        public Form1()
        {
            InitializeComponent();
        }
        void BubbleSort()
        {
            int buf;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        buf = array[i];
                        array[i] = array[j];
                        array[j] = buf;
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            array[0] = Convert.ToInt32(textBox1.Text);
            array[1] = Convert.ToInt32(textBox2.Text);
            array[2] = Convert.ToInt32(textBox3.Text);
            array[3] = Convert.ToInt32(textBox4.Text);
            array[4] = Convert.ToInt32(textBox5.Text);
            BubbleSort();
            textBox6.Clear();
            for (int i = 0; i < array.Length; i++)
            {
                textBox6.Text += array[i].ToString() + "\r\n";
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if(Form_Save == null)
            {
                Form_Save = new Form_save(textBox6.Text);
                Form_Save.ShowDialog();
            }
        }
    }
}