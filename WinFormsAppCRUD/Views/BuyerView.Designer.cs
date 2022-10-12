namespace WinFormsAppCRUD.Views
{
    partial class BuyerView
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBuyerList = new System.Windows.Forms.TabPage();
            this.txtBuyerCount = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageBuyerDetail = new System.Windows.Forms.TabPage();
            this.txtBuyerAdress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBuyerPhoneNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBuyerPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuyerLogin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuyerId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageBuyerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabPageBuyerDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "BUYERS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 63);
            this.panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1049, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 30);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageBuyerList);
            this.tabControl1.Controls.Add(this.tabPageBuyerDetail);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1101, 463);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageBuyerList
            // 
            this.tabPageBuyerList.Controls.Add(this.txtBuyerCount);
            this.tabPageBuyerList.Controls.Add(this.btnDelete);
            this.tabPageBuyerList.Controls.Add(this.btnEdit);
            this.tabPageBuyerList.Controls.Add(this.btnAddNew);
            this.tabPageBuyerList.Controls.Add(this.dataGridView);
            this.tabPageBuyerList.Controls.Add(this.btnSearch);
            this.tabPageBuyerList.Controls.Add(this.txtSearch);
            this.tabPageBuyerList.Controls.Add(this.label2);
            this.tabPageBuyerList.Location = new System.Drawing.Point(4, 30);
            this.tabPageBuyerList.Name = "tabPageBuyerList";
            this.tabPageBuyerList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuyerList.Size = new System.Drawing.Size(1093, 429);
            this.tabPageBuyerList.TabIndex = 0;
            this.tabPageBuyerList.Text = "Buyer list";
            this.tabPageBuyerList.UseVisualStyleBackColor = true;
            // 
            // txtBuyerCount
            // 
            this.txtBuyerCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuyerCount.Location = new System.Drawing.Point(935, 246);
            this.txtBuyerCount.Multiline = true;
            this.txtBuyerCount.Name = "txtBuyerCount";
            this.txtBuyerCount.ReadOnly = true;
            this.txtBuyerCount.Size = new System.Drawing.Size(111, 72);
            this.txtBuyerCount.TabIndex = 13;
            this.txtBuyerCount.Text = "Всего покупателей: 0";
            this.txtBuyerCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(947, 192);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 30);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(947, 144);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(99, 30);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.Location = new System.Drawing.Point(947, 92);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(99, 30);
            this.btnAddNew.TabIndex = 10;
            this.btnAddNew.Text = "Add new";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(29, 80);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(825, 277);
            this.dataGridView.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(947, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 30);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(29, 36);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(825, 29);
            this.txtSearch.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search buyer:";
            // 
            // tabPageBuyerDetail
            // 
            this.tabPageBuyerDetail.Controls.Add(this.txtBuyerAdress);
            this.tabPageBuyerDetail.Controls.Add(this.label7);
            this.tabPageBuyerDetail.Controls.Add(this.btnCancel);
            this.tabPageBuyerDetail.Controls.Add(this.btnSave);
            this.tabPageBuyerDetail.Controls.Add(this.txtBuyerPhoneNumber);
            this.tabPageBuyerDetail.Controls.Add(this.label6);
            this.tabPageBuyerDetail.Controls.Add(this.txtBuyerPassword);
            this.tabPageBuyerDetail.Controls.Add(this.label5);
            this.tabPageBuyerDetail.Controls.Add(this.txtBuyerLogin);
            this.tabPageBuyerDetail.Controls.Add(this.label4);
            this.tabPageBuyerDetail.Controls.Add(this.txtBuyerId);
            this.tabPageBuyerDetail.Controls.Add(this.label3);
            this.tabPageBuyerDetail.Location = new System.Drawing.Point(4, 24);
            this.tabPageBuyerDetail.Name = "tabPageBuyerDetail";
            this.tabPageBuyerDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuyerDetail.Size = new System.Drawing.Size(1093, 435);
            this.tabPageBuyerDetail.TabIndex = 1;
            this.tabPageBuyerDetail.Text = "Buyer detail";
            this.tabPageBuyerDetail.UseVisualStyleBackColor = true;
            // 
            // txtBuyerAdress
            // 
            this.txtBuyerAdress.Location = new System.Drawing.Point(39, 269);
            this.txtBuyerAdress.Name = "txtBuyerAdress";
            this.txtBuyerAdress.Size = new System.Drawing.Size(380, 29);
            this.txtBuyerAdress.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "Buyer adress:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(236, 324);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(183, 44);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(30, 324);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(183, 44);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtBuyerPhoneNumber
            // 
            this.txtBuyerPhoneNumber.Location = new System.Drawing.Point(39, 201);
            this.txtBuyerPhoneNumber.Name = "txtBuyerPhoneNumber";
            this.txtBuyerPhoneNumber.Size = new System.Drawing.Size(380, 29);
            this.txtBuyerPhoneNumber.TabIndex = 15;
            this.txtBuyerPhoneNumber.Text = "+7(000)000-00-00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(39, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Buyer phone number:";
            // 
            // txtBuyerPassword
            // 
            this.txtBuyerPassword.Location = new System.Drawing.Point(258, 137);
            this.txtBuyerPassword.Name = "txtBuyerPassword";
            this.txtBuyerPassword.Size = new System.Drawing.Size(183, 29);
            this.txtBuyerPassword.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(258, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Buyer password:";
            // 
            // txtBuyerLogin
            // 
            this.txtBuyerLogin.Location = new System.Drawing.Point(39, 137);
            this.txtBuyerLogin.Name = "txtBuyerLogin";
            this.txtBuyerLogin.Size = new System.Drawing.Size(154, 29);
            this.txtBuyerLogin.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(39, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Buyer login:";
            // 
            // txtBuyerId
            // 
            this.txtBuyerId.Location = new System.Drawing.Point(39, 53);
            this.txtBuyerId.Name = "txtBuyerId";
            this.txtBuyerId.ReadOnly = true;
            this.txtBuyerId.Size = new System.Drawing.Size(154, 29);
            this.txtBuyerId.TabIndex = 9;
            this.txtBuyerId.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(39, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Buyer ID:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // BuyerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 526);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BuyerView";
            this.Text = "BuyerView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageBuyerList.ResumeLayout(false);
            this.tabPageBuyerList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabPageBuyerDetail.ResumeLayout(false);
            this.tabPageBuyerDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPageBuyerList;
        private TabPage tabPageBuyerDetail;
        private Button btnClose;
        private Label label2;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dataGridView;
        private Button btnAddNew;
        private Button btnEdit;
        private Button btnDelete;
        private Label label3;
        private TextBox txtBuyerId;
        private Label label4;
        private TextBox txtBuyerLogin;
        private Label label5;
        private TextBox txtBuyerPassword;
        private Label label6;
        private TextBox txtBuyerPhoneNumber;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtBuyerAdress;
        private Label label7;
        private TextBox txtBuyerCount;
        private ContextMenuStrip contextMenuStrip1;
    }
}