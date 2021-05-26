
namespace MissedAssignment1
{
    partial class ShowData
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnData = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.AdminBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtCityState = new System.Windows.Forms.TextBox();
            this.dropAdmin = new System.Windows.Forms.ComboBox();
            this.GradeBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.AdminBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(631, 121);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnData
            // 
            this.btnData.BackColor = System.Drawing.Color.Black;
            this.btnData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnData.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnData.FlatAppearance.BorderSize = 5;
            this.btnData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btnData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.btnData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnData.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnData.Location = new System.Drawing.Point(3, 2);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(121, 39);
            this.btnData.TabIndex = 1;
            this.btnData.Text = "Show Data";
            this.btnData.UseVisualStyleBackColor = false;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Black;
            this.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAdd.FlatAppearance.BorderSize = 5;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.Fuchsia;
            this.BtnAdd.Location = new System.Drawing.Point(145, 2);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(121, 39);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Add Student";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnDelete.Location = new System.Drawing.Point(283, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 39);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Student";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AdminBox
            // 
            this.AdminBox.Controls.Add(this.GradeBox);
            this.AdminBox.Controls.Add(this.dropAdmin);
            this.AdminBox.Controls.Add(this.txtCityState);
            this.AdminBox.Controls.Add(this.txtLastName);
            this.AdminBox.Controls.Add(this.txtFirstName);
            this.AdminBox.Controls.Add(this.txtID);
            this.AdminBox.Controls.Add(this.label6);
            this.AdminBox.Controls.Add(this.label5);
            this.AdminBox.Controls.Add(this.label4);
            this.AdminBox.Controls.Add(this.label3);
            this.AdminBox.Controls.Add(this.label2);
            this.AdminBox.Controls.Add(this.label1);
            this.AdminBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AdminBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminBox.Location = new System.Drawing.Point(3, 241);
            this.AdminBox.Name = "AdminBox";
            this.AdminBox.Size = new System.Drawing.Size(410, 206);
            this.AdminBox.TabIndex = 4;
            this.AdminBox.TabStop = false;
            this.AdminBox.Text = "Student Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(199, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "City/State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(199, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Admin Month";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(199, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Final Grade";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(84, 23);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 23);
            this.txtID.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(84, 52);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 23);
            this.txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(84, 82);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 23);
            this.txtLastName.TabIndex = 8;
            // 
            // txtCityState
            // 
            this.txtCityState.Location = new System.Drawing.Point(277, 23);
            this.txtCityState.Name = "txtCityState";
            this.txtCityState.Size = new System.Drawing.Size(100, 23);
            this.txtCityState.TabIndex = 9;
            // 
            // dropAdmin
            // 
            this.dropAdmin.FormattingEnabled = true;
            this.dropAdmin.Location = new System.Drawing.Point(277, 52);
            this.dropAdmin.Name = "dropAdmin";
            this.dropAdmin.Size = new System.Drawing.Size(121, 24);
            this.dropAdmin.TabIndex = 10;
            this.dropAdmin.SelectedIndexChanged += new System.EventHandler(this.dropAdmin_SelectedIndexChanged);
            // 
            // GradeBox
            // 
            this.GradeBox.FormattingEnabled = true;
            this.GradeBox.Location = new System.Drawing.Point(277, 86);
            this.GradeBox.Name = "GradeBox";
            this.GradeBox.Size = new System.Drawing.Size(121, 24);
            this.GradeBox.TabIndex = 11;
            // 
            // ShowData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AdminBox);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowData";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.AdminBox.ResumeLayout(false);
            this.AdminBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox AdminBox;
        private System.Windows.Forms.ComboBox GradeBox;
        private System.Windows.Forms.ComboBox dropAdmin;
        private System.Windows.Forms.TextBox txtCityState;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

