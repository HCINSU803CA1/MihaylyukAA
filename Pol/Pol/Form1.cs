using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (License.Checked == true)
            {
                Form2 form = new Form2(); // Создание экземпляра класса
                form.Show();
                this.Hide(); // Обращение к текущему экземпляыру класса
            }
            else
            {
                MessageBox.Show("Отдай почку!!!", "Error");
                text.Text = "Отдай чертову почку!!!";
            }

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
  
}
