using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NgoThiThuyLinh_Buoi14
{
    public partial class Form1 : Form
    {
        public SqlConnection connect;
        
        public Form1()
        {
             
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public Form1(string strcn)
        {
            connect = new SqlConnection(strcn);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            connect = new SqlConnection("Data Source =" + txt_Sever.Text + "; Initial Catalog= " + txt_Database.Text + "; Integrated Security = true");
           

            if (txt_User.Text !=" " && txt_Pass.Text!=" " )
            {
                connect = new SqlConnection("Data Source =" + txt_Sever.Text + "; Initial Catalog= " + txt_Database.Text + "; uid = " + txt_User.Text + "; pwd=" + txt_Pass.Text + "; Integrated Security = true");
            }
            try
            {
                SqlConnection con = Connect.Connectdb(txt_Sever.Text, txt_Database.Text, txt_User.Text, txt_Pass.Text);
                if (con != null)
                    MessageBox.Show("Ket Noi Thanh Cong!");
                Form F = new Form2();
                F.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Ket Noi That Bai!");
            }
           
            
            
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
