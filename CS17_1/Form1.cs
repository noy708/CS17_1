using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS17_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int[] age = Enumerable.Range(0, 100).ToArray();
            ageComboBox.DataSource = age;
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = nameTextBox.Text + "さん（" + ageComboBox.SelectedItem + "才）のニックネームは「" + GetNickName() + "」です"; 
        }

        private string GetNickName()
        {
            Nickname n = new Nickname();
            n.Name = nameTextBox.Text;
            n.Age = (int)ageComboBox.SelectedItem;
            return n.GetNickName();

        }
    }
}
