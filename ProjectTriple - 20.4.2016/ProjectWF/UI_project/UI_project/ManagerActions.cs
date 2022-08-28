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
using System.Net.Mail;

namespace UI_project
{
    public partial class ManagerActions : Form
    {
        private ManagerProp MP;
        private int index;

        /// <summary>
        /// יצירת מערך פעולות  של המנהל לפי הפעולה שבחר
        /// </summary>
        /// <param name="a"></param>
        /// <param name="index"></param>
        public ManagerActions(ManagerProp a, int index)
        {
            InitializeComponent();
            this.MP = a;
            this.index = index;
            this.ClientView.Visible = false;
            this.AcceptClients.Visible = false;
            this.NotActiveClientstbl.DataSource =null;
            this.Clientstbl.DataSource = null;
            if (this.index == 1)
            {
                this.AcceptClients.Visible = true;
                DataSet NotActive = PhonesProjectBL.ClientBL.ReturnAll();
                this.NotActiveClientstbl.DataSource = NotActive.Tables[0].Copy();
            }
            if (this.index == 2)
            {
                this.ClientView.Visible = true;
                DataSet Clients = PhonesProjectBL.ClientBL.ReturnAll();
                this.Clientstbl.DataSource = Clients.Tables[0].Copy();
            }
            if (this.index == 3)
            {
                this.CompPanel.Visible = true;
                DataSet comps = PhonesProjectBL.ComplainBL.GetAllComps();
                this.Comptbl.DataSource = comps.Tables[0].Copy();
            }
        }
     

        private void ManagerActions_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// כפתור חזרה ומחיקת הלקוחות שלא אושרו ע"י המנהל
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButtom_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in this.NotActiveClientstbl.Rows)
            {
                if (Convert.ToBoolean(row.Cells[3].Value) == false)
                {
                    this.SendEmail(Convert.ToString(row.Cells[7].Value));

                    int a = Convert.ToInt32(row.Cells[0].Value);
                    PhonesProjectBL.ClientBL.DeleteClient(a);


                    ////////////// הסרה ושליחה ללקוח מייל שהוסר מן התוכנה

                    
                }

            }

            this.MP.Activate();
            this.MP.Show();
            this.Close();
        }
        /// <summary>
        /// פעולת שליחת המייל על ביטול בקשת הלקוח להיכנס למערכת
        /// </summary>
        /// <param name="email"></param>
        private void SendEmail(string email)
        {
            MailAddress from = new MailAddress("phonecompany78@gmail.com");
            MailAddress to = new MailAddress(email);

            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential(from.Address, "Administrato");

            MailMessage message = new MailMessage(from, to);
            message.Subject = "Joining Request Failed";
            message.Body ="Dear client, you request for joining our phone company has been declined. Try again later.";

            try
            {
                client.Send(message);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());

            }
        }
        /// <summary>
        /// כפתור חזרה לעמוד הקודם
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButtom2_Click(object sender, EventArgs e)
        {
            this.MP.Activate();
            this.MP.Show();
            this.Close();
        }
        /// <summary>
        /// מופע להחלפת הפעילות הלקוח בהתאם להחלטת המנהל
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotActiveClientstbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClientBL CurrentClient = new ClientBL(Convert.ToInt32(this.NotActiveClientstbl.Rows[e.RowIndex].Cells[0].Value));
            if (Convert.ToBoolean(this.NotActiveClientstbl.Rows[e.RowIndex].Cells[3].Value)==true)
            {
                CurrentClient.Active1 = false;
            }
            if (Convert.ToBoolean(this.NotActiveClientstbl.Rows[e.RowIndex].Cells[3].Value) == false)
            {
                CurrentClient.Active1 = true;

            }
        }

        private void AcceptButtom_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// התייחסות לשורה והעתקת הטקסטים
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Comptbl_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.CompDate.Value = (DateTime)Comptbl.SelectedRows[0].Cells[2].Value;
            this.Subject.Text = (string)Comptbl.SelectedRows[0].Cells[3].Value;
            this.Body.Text = (string)Comptbl.SelectedRows[0].Cells[4].Value;
            this.ConfComp.Enabled = true;
        }
        /// <summary>
        /// כפתור אישור למחיקת התלונה שהוגשה 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfComp_Click(object sender, EventArgs e)
        {
            PhonesProjectBL.ComplainBL.DeleteComp((int)this.Comptbl.SelectedRows[0].Cells[0].Value);
            this.CompDate.Value = DateTime.Now;
            this.Subject.Text ="";
            this.Body.Text = "";
            this.Comptbl.Rows.Remove(this.Comptbl.SelectedRows[0]);
        }
        /// <summary>
        /// כפתור חזרה לדף הקודם
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Back3_Click(object sender, EventArgs e)
        {
            this.MP.Activate();
            this.MP.Show();
            this.Close();
        }

        private void AcceptClients_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
