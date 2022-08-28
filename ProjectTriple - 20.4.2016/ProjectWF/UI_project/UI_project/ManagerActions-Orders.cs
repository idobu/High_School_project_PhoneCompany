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
    public partial class ManagerActions_Orders : Form
    {
        private ManagerProp Prop;

        public ManagerActions_Orders(ManagerProp prop)
        {
            InitializeComponent();
            this.Prop = prop;
            this.ReturnTblAgain();
        }
        /// <summary>
        /// פעולה המעדכנת מחדש את הטבלה 
        /// </summary>
        protected void ReturnTblAgain()
        {
          DataSet Orders=  PhonesProjectBL.PhoneOrderBL.GetAllOrders();
          this.OrderView.DataSource = Orders.Tables[0].Copy();
        }
        /// <summary>
        /// פעולה הבודקת את החלטת המנהל למחוק את העסקה שהתבצעה ולבטל אותה או לא
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove this order and abort it from the system?", "Order Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                int id=Convert.ToInt32(this.OrderView.Rows[e.RowIndex].Cells[0].Value);
                ManagerBL a = new ManagerBL();
                a.RemoveOrderFromDB(id);
                this.ReturnTblAgain();
            }
            else
            {
            }
        }
        /// <summary>
        /// סגירת החלון ומעבר לחלון הקודם
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Prop.Activate();
            this.Prop.Show();
            this.Close();
        }

    }
}
