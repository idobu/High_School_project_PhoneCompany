using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhonesProjectBL;

namespace UI_project
{
    public partial class LogIn : Form
    {
        private Form1 MainMenu;
        private ManagerProp UserProp;
        /// <summary>
        /// בניית מסך הטעינה ומסך של הכניסה
        /// </summary>
        /// <param name="a"></param>
        public LogIn(Form1 a)
        {
            MainMenu=a;
            InitializeComponent();
        }
        public int WhenReturn(LogIn a)
        {
            //this.label4.Visible = false;
            return 1;
        }
        /// <summary>
        /// כניסת משתמש ובדיקת תקינות לפרטים
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text != "")
            {
                if(textBox1.Text=="ADMINACCESS")                                 // שם משתמש וסיסמה קבועים
                {
                    if (textBox2.Text!="")
                    {
                    if(textBox2.Text=="748362950")
                    {
                        MessageBox.Show("Access Granted");
                        this.UserProp = new ManagerProp(this);
                        UserProp.Activate();
                        UserProp.Show();
                        this.MainMenu.Hide();

                    }
                    else
                    {
                        MessageBox.Show(" סיסמה שגויה");
                    }
                }
                }
                else
                {
                    MessageBox.Show("שם משתמש לא נכון");
                }
                
            }
            else
            {
                MessageBox.Show("שם משתמש או סיסמה לא נכונים");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// פתיחת המסך הקודם וסגירת הנוכחי
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.MainMenu.Activate();
            this.MainMenu.Show();
            this.Close();
        }
        /// <summary>
        /// אירוע המתרחש בטעינת הדף
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogIn_Load(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
