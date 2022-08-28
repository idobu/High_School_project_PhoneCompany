using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_project
{
    public partial class Form1 : Form
    {
        private LogIn Old;
        public Form1()
        {         
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
      
        }
        /// <summary>
        /// חגירת מסך נוכחי ופתיחת המסך הקודם
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Old = new LogIn(this);
            Old.Activate();
            Old.Show();
           
        }
        /// <summary>
        /// פעולה הבודקת תקינות כולשהי להמשך פתיחת החלון הבא
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public int WhenReturn(Form1 a)
        {
            this.button2.Enabled = true;
            return 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
     
        }
        /// <summary>
        /// סגירת החלון
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
