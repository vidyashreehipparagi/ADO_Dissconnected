namespace ADO_Dissconnected
{
    partial class Form1
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
            this.btSave1 = new System.Windows.Forms.Button();
            this.cbSubjects = new System.Windows.Forms.ComboBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.lbSearch = new System.Windows.Forms.Button();
            this.txRollno = new System.Windows.Forms.TextBox();
            this.txName = new System.Windows.Forms.TextBox();
            this.txSid = new System.Windows.Forms.TextBox();
            this.lbSubject = new System.Windows.Forms.Label();
            this.lbRollno = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbSid = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btShowAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btSave1
            // 
            this.btSave1.Location = new System.Drawing.Point(72, 280);
            this.btSave1.Name = "btSave1";
            this.btSave1.Size = new System.Drawing.Size(125, 51);
            this.btSave1.TabIndex = 26;
            this.btSave1.Text = "Save";
            this.btSave1.UseVisualStyleBackColor = true;
            this.btSave1.Click += new System.EventHandler(this.btSave1_Click);
            // 
            // cbSubjects
            // 
            this.cbSubjects.FormattingEnabled = true;
            this.cbSubjects.Location = new System.Drawing.Point(216, 209);
            this.cbSubjects.Name = "cbSubjects";
            this.cbSubjects.Size = new System.Drawing.Size(167, 24);
            this.cbSubjects.TabIndex = 25;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(242, 361);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(111, 44);
            this.btDelete.TabIndex = 24;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(86, 361);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(111, 44);
            this.btUpdate.TabIndex = 23;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // lbSearch
            // 
            this.lbSearch.Location = new System.Drawing.Point(242, 280);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(111, 44);
            this.lbSearch.TabIndex = 22;
            this.lbSearch.Text = "Search";
            this.lbSearch.UseVisualStyleBackColor = true;
            this.lbSearch.Click += new System.EventHandler(this.lbSearch_Click);
            // 
            // txRollno
            // 
            this.txRollno.Location = new System.Drawing.Point(216, 135);
            this.txRollno.Multiline = true;
            this.txRollno.Name = "txRollno";
            this.txRollno.Size = new System.Drawing.Size(167, 43);
            this.txRollno.TabIndex = 21;
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(216, 81);
            this.txName.Multiline = true;
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(167, 43);
            this.txName.TabIndex = 20;
            // 
            // txSid
            // 
            this.txSid.Location = new System.Drawing.Point(216, 22);
            this.txSid.Multiline = true;
            this.txSid.Name = "txSid";
            this.txSid.Size = new System.Drawing.Size(167, 43);
            this.txSid.TabIndex = 19;
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Location = new System.Drawing.Point(63, 200);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(57, 16);
            this.lbSubject.TabIndex = 18;
            this.lbSubject.Text = "Courses";
            // 
            // lbRollno
            // 
            this.lbRollno.AutoSize = true;
            this.lbRollno.Location = new System.Drawing.Point(63, 138);
            this.lbRollno.Name = "lbRollno";
            this.lbRollno.Size = new System.Drawing.Size(46, 16);
            this.lbRollno.TabIndex = 17;
            this.lbRollno.Text = "Rollno";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(63, 84);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(44, 16);
            this.lbName.TabIndex = 16;
            this.lbName.Text = "Name";
            // 
            // lbSid
            // 
            this.lbSid.AutoSize = true;
            this.lbSid.Location = new System.Drawing.Point(63, 25);
            this.lbSid.Name = "lbSid";
            this.lbSid.Size = new System.Drawing.Size(27, 16);
            this.lbSid.TabIndex = 15;
            this.lbSid.Text = "Sid";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(439, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(242, 157);
            this.dataGridView1.TabIndex = 27;
            // 
            // btShowAll
            // 
            this.btShowAll.Location = new System.Drawing.Point(497, 233);
            this.btShowAll.Name = "btShowAll";
            this.btShowAll.Size = new System.Drawing.Size(125, 51);
            this.btShowAll.TabIndex = 28;
            this.btShowAll.Text = "Show All";
            this.btShowAll.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btShowAll);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btSave1);
            this.Controls.Add(this.cbSubjects);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.txRollno);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.txSid);
            this.Controls.Add(this.lbSubject);
            this.Controls.Add(this.lbRollno);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbSid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSave1;
        private System.Windows.Forms.ComboBox cbSubjects;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button lbSearch;
        private System.Windows.Forms.TextBox txRollno;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.TextBox txSid;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.Label lbRollno;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btShowAll;
    }
}

