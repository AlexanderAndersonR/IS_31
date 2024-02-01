using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WinFormsApp1
{
    public partial class Form_save : Form
    {
        public Form_save(string data)
        {
            InitializeComponent();
            textBox1.Text = data;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            var dialog = new System.Windows.Forms.FolderBrowserDialog();
            System.Windows.Forms.DialogResult result = dialog.ShowDialog();
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            ////openFileDialog.Filter = "Audio files(*.wav)|*.wav|All files(*.*)|*.*";
            //DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
                textBox2.Text = dialog.SelectedPath;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            // полная перезапись файла 
            using (StreamWriter writer = new StreamWriter(textBox2.Text+"\\"+textBox3.Text+".txt", false))
            {
                 writer.WriteLineAsync(textBox1.Text);
            }
        }
    }
}
