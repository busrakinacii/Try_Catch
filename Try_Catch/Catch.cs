using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Try_Catch
{
    public partial class Catch : Form
    {
        public Catch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int s1 = Convert.ToInt32(textBox1.Text);
                int s2 = Convert.ToInt32(textBox2.Text);
                int sonuc = s1 * s2;
                label1.Text = sonuc.ToString();
            }
            catch (Exception hata)
            {
                MessageBox.Show("HATA VAR!!!!! " + hata.ToString());
            }
            finally
            {
                MessageBox.Show("Finally Bloğu Çalıştı.");
            }
        }
    }
}
