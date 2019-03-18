using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrongPasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Generate_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_length.SelectedIndex == -1)
                    throw new Exception("You have to choose a length!");
                int len = int.Parse(comboBox_length.SelectedItem.ToString());
                PasswordGenerator pg = new PasswordGenerator(len, checkBox_numbers.Checked,
                  checkBox_symbols.Checked, checkBox_lowerchars.Checked, checkBox_upperchars.Checked);

                pg.Generate();
                label_autosize.Text = pg.password;
                textBox_password.Size = label_autosize.Size;
                textBox_password.Text = pg.password;
                pg.SaveToFileEncrypted();
            }
            catch (Exception exc) 
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
