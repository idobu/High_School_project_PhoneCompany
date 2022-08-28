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
    public partial class ManagerActions2 : Form
    {
        private ManagerProp Prop;
        /// <summary>
        /// יצירת העמוד
        /// </summary>
        /// <param name="Prop"></param>
        public ManagerActions2(ManagerProp Prop)
        {
            InitializeComponent();
            this.Prop = Prop;
            this.ReturnTableAgain();
        }
        /// <summary>
        /// פעולה להחזרת הטבלה של הטלפונים
        /// </summary>
        protected void ReturnTableAgain()
        {
            DataSet AllPhones = PhonesProjectBL.StockBL.ReturnAllPhones();
            this.StorePhones.DataSource = AllPhones.Tables[0].Copy();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// פעולה המאשרת את הערכים ששונו בטלפון שבטבלה
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in this.StorePhones.Rows)
            {
                StockBL phone = new StockBL(Convert.ToInt32(dr.Cells[0].Value));
                phone.PhonesInStock2 =Convert.ToInt32(dr.Cells[1].Value);
                phone.Price2 = Convert.ToInt32(dr.Cells[4].Value);
                phone.SerialNum2 = Convert.ToInt32(dr.Cells[6].Value);
                phone.Pname1 = Convert.ToString(dr.Cells[7].Value);
                phone.CreationYear2 = Convert.ToInt32(dr.Cells[5].Value);
            }
            this.ReturnTableAgain();
        }
        /// <summary>
        /// בדיקת תקינת מספרית לאורך כל הטקסט שנשלח
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private bool CodeCheck_number(string s)
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
        /// בדיקת תקינת מספרית לאורך כל הטקסט שנשלח
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private bool CodeCheck_letters(string s)
        {
            foreach (char a in s)
            {
                if (!char.IsLetter(a))
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// כפתור המפעיל את פעולה המחיקה של הטקסטים בעמוד
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.Reset();
        }
        /// <summary>
        /// פעולה למיקת הערכים בטקסטים בדף
        /// </summary>
        protected void Reset()
        {
            this.Pname.Text = "";
            this.PriceBox.Text = "";
            this.SerialBox.Text = "";
            this.CompBox.ClearSelected();
            this.ColorBox.ClearSelected();
            this.YearBox.Text = "";
            this.StockAmountBox.Text = "";
        }
        /// <summary>
        /// פעולת הוספת הטלפון לרשימת הטלפונים
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if ((this.PriceBox.Text != "") && (this.StockAmountBox.Text != "") && (this.SerialBox.Text != "") && (this.YearBox.Text != "") && (this.StockAmountBox.Text != "") && (this.StockAmountBox.Text != "0") && (this.ColorBox.SelectedIndex >= 0) && (this.CompBox.SelectedIndex >= 0))
            {
                if ((this.CodeCheck_number(this.PriceBox.Text)) && (this.CodeCheck_number(this.YearBox.Text)) && (this.CodeCheck_number(SerialBox.Text) && (this.CodeCheck_number(this.StockAmountBox.Text))))
                {
                    StockBL AddedPhone = new StockBL(this.ColorBox.Text, this.Pname.Text, this.CompBox.Text);
                    if (AddedPhone.Pcolor2==null)
                    {
                        StockBL phone = new StockBL(-1, Convert.ToInt32(this.StockAmountBox.Text), this.ColorBox.SelectedItem.ToString(), this.CompBox.SelectedItem.ToString(), Convert.ToInt32(this.PriceBox.Text), Convert.ToInt32(this.YearBox.Text), Convert.ToInt32(this.SerialBox.Text), this.Pname.Text);
                        this.Reset();
                    }
                    else
                    {
                        MessageBox.Show("This phone type already exists!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Values in the phone adding were incorrect !");
            }
            this.ReturnTableAgain();
        }
        /// <summary>
        ///  פעולה לחזרה לעמוד הקודם
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bbutton_Click(object sender, EventArgs e)
        {
            this.Prop.Activate();
            this.Prop.Show();
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
