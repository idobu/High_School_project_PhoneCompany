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
    public partial class ManagerActions_Pack : Form
    {
        private ManagerProp Prop;
        public ManagerActions_Pack(ManagerProp Prop)
        {
            InitializeComponent();
            this.Prop = Prop;
            this.ReturnPackTable();
        }
        /// <summary>
        /// פעולה הסוגרת את החלון ומעבירה לחלון הקודם
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bbutton_Click(object sender, EventArgs e)
        {
            Prop.Activate();
            Prop.Show();
            this.Close();
        }
        /// <summary>
        /// פעולה המעדכנת ומביאה את בטבלה עעדכנית מהמאגר
        /// </summary>
        protected void ReturnPackTable()
        {
            DataSet AllPcaks = PhonesProjectBL.PackageStockBL.ReturnEverything();
            this.PackStore.DataSource = AllPcaks.Tables[0].Copy();
        }
        /// <summary>
        /// ניקוי והסרת הערכים ביצירת החבילה החדשה
        /// </summary>
        protected void ResetThisPage()
        {
            this.PackName.Text = "";
            this.RestrictionBox.Text = "";
            this.AmountOfPacks.Text = "";
            this.BoxPrice.Text="";
        }
        /// <summary>
        /// כפתור המנקה את הערכים בטקסטים
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Rbutton_Click(object sender, EventArgs e)
        {
            this.ResetThisPage();
        }
        /// <summary>
        /// כפתור המאשר ובודקת תקינות של החבילה החדשה שהמנהל מנסה להוסיף
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfButton_Click(object sender, EventArgs e)
        {
            if ((this.RestrictionBox.Text != "") && (this.AmountOfPacks.Text != "") && (this.BoxPrice.Text != "") && (this.PackName.Text != ""))
            {
                if ((CodeCheck_IsInt(this.AmountOfPacks.Text)) && (CodeCheck_IsInt(this.BoxPrice.Text)))
                {
                    PackageStockBL AddedPack = new PackageStockBL(this.PackName.Text,Convert.ToInt32(this.BoxPrice.Text));
                    if (AddedPack.PackageInfo1 == null)
                    {
                        PackageStockBL Pack = new PackageStockBL(-1, this.RestrictionBox.Text, Convert.ToInt32(this.BoxPrice.Text), this.PackName.Text, Convert.ToInt32(this.AmountOfPacks.Text));
                        this.ResetThisPage();
                    }
                    else
                    {
                        MessageBox.Show("This Pack is already exists!");
                    }
                }
                else
                {
                    MessageBox.Show("Input was incorrect at the adding of the pack !");
                }
            }
            else
            {
                MessageBox.Show("Input was incorrect at the adding of the pack !");
            }
            this.ReturnPackTable();
            
        }
        /// <summary>
        /// פעולה לבדיקת המילה שנשלחה האם היא כולה מספרים
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private bool CodeCheck_IsInt(string s)
        {
            foreach (char a in s)
            {
                if (!char.IsNumber(a))
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// פעולה המאשרת את העידכונים מן הטבלה הנתונה אל הנתונים השמורים במאגר
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void AccButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in this.PackStore.Rows)
            {
                PackageStockBL thispack = new PackageStockBL(Convert.ToInt32(dr.Cells[0].Value));
                thispack.Pnum1 = Convert.ToString(dr.Cells[1].Value);
                thispack.PackageInfo1 = Convert.ToString(dr.Cells[3].Value);
                thispack.PackageInStock1 = Convert.ToInt32(dr.Cells[4].Value);
                thispack.Price1 = Convert.ToInt32(dr.Cells[2].Value);
            }
            this.ReturnPackTable();
            
        }
    }
}
