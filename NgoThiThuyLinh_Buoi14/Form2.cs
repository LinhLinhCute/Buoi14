﻿using System;
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
    public partial class Form2 : Form
    {

        SqlConnection consql = Connect.Connectdb1();
        DataSet ds_GV;
        DataColumn[] key = new DataColumn[1];
        public Form2()
        {
            
            InitializeComponent();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           //if(e.RowIndex>=0 && e.RowIndex < dgv_GV.Rows.Count)

        }
        private void lOAD_ComboBox_CS()
        {
            
            try
            {
                if (consql.State == ConnectionState.Closed)
                {
                    consql.Open();
                }
                string read;
                read = "select tencoso from COSO";
                SqlCommand cmd = new SqlCommand(read, consql);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cbB_CoSo.Items.Add(rdr["tencoso"].ToString());
                }
                if (consql.State == ConnectionState.Open)
                {
                    consql.Close();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Load_ComboBox_DonVi()
        {
            
            try
            {
                if (consql.State == ConnectionState.Closed)
                {
                    consql.Open();
                }
                
                string read;
                read = "select tendonvi from DONVI";
                SqlCommand cmd = new SqlCommand(read, consql);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cbB_DonVi.Items.Add(rdr["tendonvi"].ToString());
                }
                if (consql.State == ConnectionState.Open)
                {
                    consql.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Load_Data(){
            
            try
            {
                string read;
                read = "select tengv from GV";
                DataSet ds = new DataSet();
                // tạo dataAdapter
                SqlDataAdapter da = new SqlDataAdapter(read, consql);
                // đổ dữ liệu vào dataset
                da.Fill(ds, "GV");
                //Gán dữ liệu vào datagridview
                dgv_GV.DataSource = ds.Tables["GV"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Load_Data();
            lOAD_ComboBox_CS();
            Load_ComboBox_DonVi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_GV_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu mn = new ContextMenu();
                mn.MenuItems.Add(new MenuItem("Hiển thị thông tin chi tiết"));
                mn.MenuItems.Add(new MenuItem("Xóa giáo viên này"));
                int currentMouseOverRow = dgv_GV.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    mn.MenuItems.Add(new MenuItem("Lua Chon"));
                }
                mn.Show(dgv_GV, new Point(e.X, e.Y));
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
