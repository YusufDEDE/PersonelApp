namespace PersonelApp_Form
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnList = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDeptPer = new System.Windows.Forms.Button();
            this.btnPerList = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(248, 496);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(587, 33);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "button1";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(248, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(587, 175);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(248, 46);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(587, 156);
            this.dataGridView2.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(70, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(70, 72);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 79);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(55, 13);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "LastName";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 155);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(158, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Personel";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Departman Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 295);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // btnDeptPer
            // 
            this.btnDeptPer.Location = new System.Drawing.Point(12, 344);
            this.btnDeptPer.Name = "btnDeptPer";
            this.btnDeptPer.Size = new System.Drawing.Size(185, 23);
            this.btnDeptPer.TabIndex = 6;
            this.btnDeptPer.Text = "Add Personel Department";
            this.btnDeptPer.UseVisualStyleBackColor = true;
            this.btnDeptPer.Click += new System.EventHandler(this.btnDeptPer_Click);
            // 
            // btnPerList
            // 
            this.btnPerList.Location = new System.Drawing.Point(248, 220);
            this.btnPerList.Name = "btnPerList";
            this.btnPerList.Size = new System.Drawing.Size(587, 29);
            this.btnPerList.TabIndex = 7;
            this.btnPerList.Text = "Personel List";
            this.btnPerList.UseVisualStyleBackColor = true;
            this.btnPerList.Click += new System.EventHandler(this.btnPerList_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Call Me Baby!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(16, 473);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(184, 23);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "Call Me Delete!";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 582);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPerList);
            this.Controls.Add(this.btnDeptPer);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDeptPer;
        private System.Windows.Forms.Button btnPerList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDel;
    }
}

