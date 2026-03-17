namespace CMS
{
    partial class Faculty
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtmoblie = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmsDataSet = new CMS.cmsDataSet();
            this.facultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facultyTableAdapter = new CMS.cmsDataSetTableAdapters.facultyTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moblieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.txtmoblie);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(70, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 209);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(83, 104);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(129, 20);
            this.txtemail.TabIndex = 13;
            // 
            // txtmoblie
            // 
            this.txtmoblie.Location = new System.Drawing.Point(83, 74);
            this.txtmoblie.Name = "txtmoblie";
            this.txtmoblie.Size = new System.Drawing.Size(129, 20);
            this.txtmoblie.TabIndex = 12;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(85, 46);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(127, 20);
            this.txtname.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "mobile";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "facultyname";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.facultynameDataGridViewTextBoxColumn,
            this.moblieDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.facultyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(313, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 209);
            this.dataGridView1.TabIndex = 8;
            // 
            // cmsDataSet
            // 
            this.cmsDataSet.DataSetName = "cmsDataSet";
            this.cmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facultyBindingSource
            // 
            this.facultyBindingSource.DataMember = "faculty";
            this.facultyBindingSource.DataSource = this.cmsDataSet;
            // 
            // facultyTableAdapter
            // 
            this.facultyTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // facultynameDataGridViewTextBoxColumn
            // 
            this.facultynameDataGridViewTextBoxColumn.DataPropertyName = "facultyname";
            this.facultynameDataGridViewTextBoxColumn.HeaderText = "facultyname";
            this.facultynameDataGridViewTextBoxColumn.Name = "facultynameDataGridViewTextBoxColumn";
            // 
            // moblieDataGridViewTextBoxColumn
            // 
            this.moblieDataGridViewTextBoxColumn.DataPropertyName = "moblie";
            this.moblieDataGridViewTextBoxColumn.HeaderText = "moblie";
            this.moblieDataGridViewTextBoxColumn.Name = "moblieDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // Faculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Faculty";
            this.Text = "Faculty";
            this.Load += new System.EventHandler(this.Faculty_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtmoblie;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private cmsDataSet cmsDataSet;
        private System.Windows.Forms.BindingSource facultyBindingSource;
        private cmsDataSetTableAdapters.facultyTableAdapter facultyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moblieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}