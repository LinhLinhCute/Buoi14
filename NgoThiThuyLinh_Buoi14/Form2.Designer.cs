namespace NgoThiThuyLinh_Buoi14
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbB_CoSo = new System.Windows.Forms.ComboBox();
            this.cbB_DonVi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_GV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hienThongTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GV)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbB_CoSo
            // 
            this.cbB_CoSo.FormattingEnabled = true;
            this.cbB_CoSo.Location = new System.Drawing.Point(130, 38);
            this.cbB_CoSo.Name = "cbB_CoSo";
            this.cbB_CoSo.Size = new System.Drawing.Size(221, 21);
            this.cbB_CoSo.TabIndex = 0;
            // 
            // cbB_DonVi
            // 
            this.cbB_DonVi.FormattingEnabled = true;
            this.cbB_DonVi.Location = new System.Drawing.Point(130, 82);
            this.cbB_DonVi.Name = "cbB_DonVi";
            this.cbB_DonVi.Size = new System.Drawing.Size(221, 21);
            this.cbB_DonVi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cơ sở:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đơn vị đào tạo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Danh sách giáo viên :";
            // 
            // dgv_GV
            // 
            this.dgv_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GV.Location = new System.Drawing.Point(12, 134);
            this.dgv_GV.Name = "dgv_GV";
            this.dgv_GV.Size = new System.Drawing.Size(409, 150);
            this.dgv_GV.TabIndex = 5;
            this.dgv_GV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgv_GV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgv_GV.CellContextMenuStripChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgv_GV.ContextMenuStripChanged += new System.EventHandler(this.toolStripMenuItem1_Click);
            this.dgv_GV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_GV_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hienThongTinToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // hienThongTinToolStripMenuItem
            // 
            this.hienThongTinToolStripMenuItem.Name = "hienThongTinToolStripMenuItem";
            this.hienThongTinToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hienThongTinToolStripMenuItem.Text = "Hien thong tin";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 330);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_GV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbB_DonVi);
            this.Controls.Add(this.cbB_CoSo);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GV)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbB_CoSo;
        private System.Windows.Forms.ComboBox cbB_DonVi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_GV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hienThongTinToolStripMenuItem;
    }
}