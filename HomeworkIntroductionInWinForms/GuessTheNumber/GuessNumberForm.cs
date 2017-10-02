using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class GuessNumberForm : Form
    {
        private int count = 0;

        public GuessNumberForm()
        {
            InitializeComponent();
        }

        private void ButtonStartGame_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Загадайте число от 1 до 2000");
            Guess();
        }

        private void Guess()
        {
            Random rand = new Random();
            for (;;)
            {
                count++;
                DialogResult res = MessageBox.Show("Это число " + rand.Next(1, 2000) + "?", "", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    MessageBox.Show("Поздравляем!\nУгадано за " + count + " попыток");
                    break;
                }
            }
        }
    }
}
