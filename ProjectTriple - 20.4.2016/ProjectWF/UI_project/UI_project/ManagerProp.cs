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
    public partial class ManagerProp : Form
    {
        private LogIn userlogin;
        /// <summary>
        /// פעולה בונה של העמוד
        /// </summary>
        /// <param name="login"></param>
        public ManagerProp(LogIn login)
        {
            InitializeComponent();
            this.userlogin = login;
        }

        //private void button3_Click(object sender, EventArgs e)
        //{

        //}

        //private void button2_Click(object sender, EventArgs e)
        //{

        //}

        //private void button1_Click(object sender, EventArgs e)
        //{


        //}

        private void UserProp_Load(object sender, EventArgs e)
        {
           
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
    
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }
        /// <summary>
        /// כפתור חזרה לעמוד הקודם
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.userlogin.WhenReturn(userlogin);
            this.userlogin.Activate();
            this.userlogin.Show();
            this.Close();
        }
        /// <summary>
        /// מופע המשייך את המנהל לפקודה שהוא רוצה לבצע בעץ הפעולות
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (this.ActionTree.SelectedNode.Text == "Accept and declain Clients")
            {
                ManagerActions a = new ManagerActions(this,1);
                a.Activate();
                a.Show();
            }
            if (this.ActionTree.SelectedNode.Text == "View the client list")
            {
                ManagerActions a = new ManagerActions(this,2);
                a.Activate();
                a.Show();
            }
            if (this.ActionTree.SelectedNode.Text == "Client Complains")
            {
                ManagerActions a = new ManagerActions(this,3);
                a.Activate();
                a.Show();
            }
            if (this.ActionTree.SelectedNode.Text == "Exit the system")
            {
                this.userlogin.Activate();
                this.userlogin.Show();
                this.Close();
            }
            if (this.ActionTree.SelectedNode.Text == "Add new phone to the store")
            {
                ManagerActions2 b =new ManagerActions2(this);
                b.Activate();
                b.Show();
            }
            if (this.ActionTree.SelectedNode.Text == "Add new pack to the store")
            {
                ManagerActions_Pack b = new ManagerActions_Pack(this);
                b.Activate();
                b.Show();
            }
            if (this.ActionTree.SelectedNode.Text == "Order management")
            {
                ManagerActions_Orders b = new ManagerActions_Orders(this);
                b.Activate();
                b.Show();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
        }
    }
}
