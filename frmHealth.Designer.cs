namespace Assignment_Project
{
    partial class frmHealth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHealth));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPayment = new System.Windows.Forms.ComboBox();
            this.cbxMonth = new System.Windows.Forms.ComboBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.dgvPanel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Rubik", 12F);
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(842, 283);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(160, 44);
            this.btnRefresh.TabIndex = 61;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.btnUpdate.Font = new System.Drawing.Font("Rubik", 12F);
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(620, 572);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(153, 44);
            this.btnUpdate.TabIndex = 60;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.btnDelete.Font = new System.Drawing.Font("Rubik", 12F);
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(451, 572);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(143, 44);
            this.btnDelete.TabIndex = 59;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.btnAdd.Font = new System.Drawing.Font("Rubik", 12F);
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(275, 572);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 44);
            this.btnAdd.TabIndex = 58;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rubik", 12F);
            this.label4.Location = new System.Drawing.Point(159, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 57;
            this.label4.Text = "Cost";
            // 
            // txtCost
            // 
            this.txtCost.AcceptsTab = true;
            this.txtCost.Font = new System.Drawing.Font("Rubik", 12F);
            this.txtCost.Location = new System.Drawing.Point(275, 375);
            this.txtCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCost.MaxLength = 6;
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(143, 31);
            this.txtCost.TabIndex = 56;
            this.txtCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCost_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rubik", 12F);
            this.label3.Location = new System.Drawing.Point(642, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 55;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rubik", 12F);
            this.label2.Location = new System.Drawing.Point(139, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 54;
            this.label2.Text = "Payment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 12F);
            this.label1.Location = new System.Drawing.Point(152, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 53;
            this.label1.Text = "Month";
            // 
            // cbxPayment
            // 
            this.cbxPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayment.Font = new System.Drawing.Font("Rubik", 12F);
            this.cbxPayment.FormattingEnabled = true;
            this.cbxPayment.Items.AddRange(new object[] {
            "Credit Card",
            "Debit Card",
            "Cash"});
            this.cbxPayment.Location = new System.Drawing.Point(246, 503);
            this.cbxPayment.Margin = new System.Windows.Forms.Padding(4);
            this.cbxPayment.Name = "cbxPayment";
            this.cbxPayment.Size = new System.Drawing.Size(213, 33);
            this.cbxPayment.TabIndex = 52;
            // 
            // cbxMonth
            // 
            this.cbxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMonth.Font = new System.Drawing.Font("Rubik", 12F);
            this.cbxMonth.FormattingEnabled = true;
            this.cbxMonth.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.cbxMonth.Location = new System.Drawing.Point(246, 437);
            this.cbxMonth.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMonth.Name = "cbxMonth";
            this.cbxMonth.Size = new System.Drawing.Size(213, 33);
            this.cbxMonth.TabIndex = 51;
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Rubik", 12F);
            this.txtDesc.Location = new System.Drawing.Point(542, 422);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(321, 114);
            this.txtDesc.TabIndex = 50;
            // 
            // dgvPanel
            // 
            this.dgvPanel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPanel.BackgroundColor = System.Drawing.Color.White;
            this.dgvPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rubik", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPanel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPanel.Location = new System.Drawing.Point(0, 0);
            this.dgvPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPanel.Name = "dgvPanel";
            this.dgvPanel.RowHeadersWidth = 51;
            this.dgvPanel.RowTemplate.Height = 24;
            this.dgvPanel.Size = new System.Drawing.Size(1015, 263);
            this.dgvPanel.TabIndex = 49;
            this.dgvPanel.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPanel_CellDoubleClick);
            // 
            // frmHealth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1015, 673);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPayment);
            this.Controls.Add(this.cbxMonth);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.dgvPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHealth";
            this.Text = "frmHealth";
            this.Load += new System.EventHandler(this.frmHealth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPayment;
        private System.Windows.Forms.ComboBox cbxMonth;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.DataGridView dgvPanel;
    }
}