
namespace MyStoreWinApp
{
    partial class frmMemberManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btDeleteMember = new System.Windows.Forms.Button();
            this.btUpdateMember = new System.Windows.Forms.Button();
            this.btNewMember = new System.Windows.Forms.Button();
            this.tbMemberCountry = new System.Windows.Forms.TextBox();
            this.tbMemberCity = new System.Windows.Forms.TextBox();
            this.tbMemberEmail = new System.Windows.Forms.TextBox();
            this.tbMemberName = new System.Windows.Forms.TextBox();
            this.tbMemberPassword = new System.Windows.Forms.TextBox();
            this.tbMemberId = new System.Windows.Forms.TextBox();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbMemberEmail = new System.Windows.Forms.Label();
            this.lbMemberName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btSearch = new System.Windows.Forms.Button();
            this.tbSearchName = new System.Windows.Forms.TextBox();
            this.tbSearchId = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.lbSearchName = new System.Windows.Forms.Label();
            this.lbSearchId = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btFilter = new System.Windows.Forms.Button();
            this.cbFilterCountry = new System.Windows.Forms.ComboBox();
            this.cbFilterCity = new System.Windows.Forms.ComboBox();
            this.lbFIlterCountry = new System.Windows.Forms.Label();
            this.lbFilterCity = new System.Windows.Forms.Label();
            this.lbFilter = new System.Windows.Forms.Label();
            this.grMemberList = new System.Windows.Forms.DataGridView();
            this.chbSort = new System.Windows.Forms.CheckBox();
            this.btClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grMemberList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btDeleteMember);
            this.panel1.Controls.Add(this.btUpdateMember);
            this.panel1.Controls.Add(this.btNewMember);
            this.panel1.Controls.Add(this.tbMemberCountry);
            this.panel1.Controls.Add(this.tbMemberCity);
            this.panel1.Controls.Add(this.tbMemberEmail);
            this.panel1.Controls.Add(this.tbMemberName);
            this.panel1.Controls.Add(this.tbMemberPassword);
            this.panel1.Controls.Add(this.tbMemberId);
            this.panel1.Controls.Add(this.lbCountry);
            this.panel1.Controls.Add(this.lbCity);
            this.panel1.Controls.Add(this.lbMemberEmail);
            this.panel1.Controls.Add(this.lbMemberName);
            this.panel1.Controls.Add(this.lbPassword);
            this.panel1.Controls.Add(this.lbMemberID);
            this.panel1.Location = new System.Drawing.Point(1, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1229, 119);
            this.panel1.TabIndex = 0;
            // 
            // btDeleteMember
            // 
            this.btDeleteMember.Location = new System.Drawing.Point(1135, 27);
            this.btDeleteMember.Name = "btDeleteMember";
            this.btDeleteMember.Size = new System.Drawing.Size(75, 52);
            this.btDeleteMember.TabIndex = 14;
            this.btDeleteMember.Text = "Delete";
            this.btDeleteMember.UseVisualStyleBackColor = true;
            this.btDeleteMember.Click += new System.EventHandler(this.btDeleteMember_Click);
            // 
            // btUpdateMember
            // 
            this.btUpdateMember.Location = new System.Drawing.Point(1034, 27);
            this.btUpdateMember.Name = "btUpdateMember";
            this.btUpdateMember.Size = new System.Drawing.Size(75, 52);
            this.btUpdateMember.TabIndex = 13;
            this.btUpdateMember.Text = "Update";
            this.btUpdateMember.UseVisualStyleBackColor = true;
            this.btUpdateMember.Click += new System.EventHandler(this.btUpdateMember_Click);
            // 
            // btNewMember
            // 
            this.btNewMember.Location = new System.Drawing.Point(936, 27);
            this.btNewMember.Name = "btNewMember";
            this.btNewMember.Size = new System.Drawing.Size(75, 52);
            this.btNewMember.TabIndex = 12;
            this.btNewMember.Text = "New";
            this.btNewMember.UseVisualStyleBackColor = true;
            this.btNewMember.Click += new System.EventHandler(this.btNewMember_Click);
            // 
            // tbMemberCountry
            // 
            this.tbMemberCountry.Location = new System.Drawing.Point(751, 82);
            this.tbMemberCountry.Name = "tbMemberCountry";
            this.tbMemberCountry.Size = new System.Drawing.Size(151, 23);
            this.tbMemberCountry.TabIndex = 11;
            // 
            // tbMemberCity
            // 
            this.tbMemberCity.Location = new System.Drawing.Point(330, 82);
            this.tbMemberCity.Name = "tbMemberCity";
            this.tbMemberCity.Size = new System.Drawing.Size(152, 23);
            this.tbMemberCity.TabIndex = 10;
            // 
            // tbMemberEmail
            // 
            this.tbMemberEmail.Location = new System.Drawing.Point(11, 82);
            this.tbMemberEmail.Name = "tbMemberEmail";
            this.tbMemberEmail.Size = new System.Drawing.Size(152, 23);
            this.tbMemberEmail.TabIndex = 9;
            // 
            // tbMemberName
            // 
            this.tbMemberName.Location = new System.Drawing.Point(751, 27);
            this.tbMemberName.Name = "tbMemberName";
            this.tbMemberName.Size = new System.Drawing.Size(151, 23);
            this.tbMemberName.TabIndex = 8;
            // 
            // tbMemberPassword
            // 
            this.tbMemberPassword.Location = new System.Drawing.Point(330, 27);
            this.tbMemberPassword.Name = "tbMemberPassword";
            this.tbMemberPassword.Size = new System.Drawing.Size(152, 23);
            this.tbMemberPassword.TabIndex = 7;
            // 
            // tbMemberId
            // 
            this.tbMemberId.Location = new System.Drawing.Point(12, 27);
            this.tbMemberId.Name = "tbMemberId";
            this.tbMemberId.Size = new System.Drawing.Size(152, 23);
            this.tbMemberId.TabIndex = 6;
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(751, 64);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(50, 15);
            this.lbCountry.TabIndex = 5;
            this.lbCountry.Text = "Country";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(330, 64);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(28, 15);
            this.lbCity.TabIndex = 4;
            this.lbCity.Text = "City";
            // 
            // lbMemberEmail
            // 
            this.lbMemberEmail.AutoSize = true;
            this.lbMemberEmail.Location = new System.Drawing.Point(12, 64);
            this.lbMemberEmail.Name = "lbMemberEmail";
            this.lbMemberEmail.Size = new System.Drawing.Size(36, 15);
            this.lbMemberEmail.TabIndex = 3;
            this.lbMemberEmail.Text = "Email";
            // 
            // lbMemberName
            // 
            this.lbMemberName.AutoSize = true;
            this.lbMemberName.Location = new System.Drawing.Point(751, 9);
            this.lbMemberName.Name = "lbMemberName";
            this.lbMemberName.Size = new System.Drawing.Size(87, 15);
            this.lbMemberName.TabIndex = 2;
            this.lbMemberName.Text = "Member Name";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(330, 9);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(57, 15);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Password";
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(12, 9);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(66, 15);
            this.lbMemberID.TabIndex = 0;
            this.lbMemberID.Text = "Member ID";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btSearch);
            this.panel2.Controls.Add(this.tbSearchName);
            this.panel2.Controls.Add(this.tbSearchId);
            this.panel2.Controls.Add(this.lbSearch);
            this.panel2.Controls.Add(this.lbSearchName);
            this.panel2.Controls.Add(this.lbSearchId);
            this.panel2.Location = new System.Drawing.Point(4, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 72);
            this.panel2.TabIndex = 1;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(356, 12);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(176, 53);
            this.btSearch.TabIndex = 5;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // tbSearchName
            // 
            this.tbSearchName.Location = new System.Drawing.Point(83, 46);
            this.tbSearchName.Name = "tbSearchName";
            this.tbSearchName.Size = new System.Drawing.Size(216, 23);
            this.tbSearchName.TabIndex = 4;
            // 
            // tbSearchId
            // 
            this.tbSearchId.Location = new System.Drawing.Point(83, 12);
            this.tbSearchId.Name = "tbSearchId";
            this.tbSearchId.Size = new System.Drawing.Size(216, 23);
            this.tbSearchId.TabIndex = 3;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(3, -3);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(42, 15);
            this.lbSearch.TabIndex = 0;
            this.lbSearch.Text = "Search";
            // 
            // lbSearchName
            // 
            this.lbSearchName.AutoSize = true;
            this.lbSearchName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSearchName.Location = new System.Drawing.Point(28, 46);
            this.lbSearchName.Name = "lbSearchName";
            this.lbSearchName.Size = new System.Drawing.Size(49, 19);
            this.lbSearchName.TabIndex = 2;
            this.lbSearchName.Text = "Name";
            // 
            // lbSearchId
            // 
            this.lbSearchId.AutoSize = true;
            this.lbSearchId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSearchId.Location = new System.Drawing.Point(28, 12);
            this.lbSearchId.Name = "lbSearchId";
            this.lbSearchId.Size = new System.Drawing.Size(22, 19);
            this.lbSearchId.TabIndex = 1;
            this.lbSearchId.Text = "Id";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btFilter);
            this.panel3.Controls.Add(this.cbFilterCountry);
            this.panel3.Controls.Add(this.cbFilterCity);
            this.panel3.Controls.Add(this.lbFIlterCountry);
            this.panel3.Controls.Add(this.lbFilterCity);
            this.panel3.Controls.Add(this.lbFilter);
            this.panel3.Location = new System.Drawing.Point(547, 169);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(691, 72);
            this.panel3.TabIndex = 2;
            // 
            // btFilter
            // 
            this.btFilter.Location = new System.Drawing.Point(488, 12);
            this.btFilter.Name = "btFilter";
            this.btFilter.Size = new System.Drawing.Size(176, 53);
            this.btFilter.TabIndex = 6;
            this.btFilter.Text = "Filter";
            this.btFilter.UseVisualStyleBackColor = true;
            this.btFilter.Click += new System.EventHandler(this.btFilter_Click);
            // 
            // cbFilterCountry
            // 
            this.cbFilterCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterCountry.FormattingEnabled = true;
            this.cbFilterCountry.Location = new System.Drawing.Point(125, 45);
            this.cbFilterCountry.Name = "cbFilterCountry";
            this.cbFilterCountry.Size = new System.Drawing.Size(239, 23);
            this.cbFilterCountry.TabIndex = 8;
            // 
            // cbFilterCity
            // 
            this.cbFilterCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterCity.FormattingEnabled = true;
            this.cbFilterCity.Location = new System.Drawing.Point(125, 16);
            this.cbFilterCity.Name = "cbFilterCity";
            this.cbFilterCity.Size = new System.Drawing.Size(239, 23);
            this.cbFilterCity.TabIndex = 7;
            // 
            // lbFIlterCountry
            // 
            this.lbFIlterCountry.AutoSize = true;
            this.lbFIlterCountry.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFIlterCountry.Location = new System.Drawing.Point(31, 47);
            this.lbFIlterCountry.Name = "lbFIlterCountry";
            this.lbFIlterCountry.Size = new System.Drawing.Size(63, 19);
            this.lbFIlterCountry.TabIndex = 6;
            this.lbFIlterCountry.Text = "Country";
            // 
            // lbFilterCity
            // 
            this.lbFilterCity.AutoSize = true;
            this.lbFilterCity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFilterCity.Location = new System.Drawing.Point(31, 16);
            this.lbFilterCity.Name = "lbFilterCity";
            this.lbFilterCity.Size = new System.Drawing.Size(35, 19);
            this.lbFilterCity.TabIndex = 6;
            this.lbFilterCity.Text = "City";
            // 
            // lbFilter
            // 
            this.lbFilter.AutoSize = true;
            this.lbFilter.Location = new System.Drawing.Point(5, -3);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(33, 15);
            this.lbFilter.TabIndex = 1;
            this.lbFilter.Text = "Filter";
            // 
            // grMemberList
            // 
            this.grMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grMemberList.Location = new System.Drawing.Point(4, 272);
            this.grMemberList.Name = "grMemberList";
            this.grMemberList.RowTemplate.Height = 25;
            this.grMemberList.Size = new System.Drawing.Size(1213, 187);
            this.grMemberList.TabIndex = 3;
            // 
            // chbSort
            // 
            this.chbSort.AutoSize = true;
            this.chbSort.Location = new System.Drawing.Point(12, 247);
            this.chbSort.Name = "chbSort";
            this.chbSort.Size = new System.Drawing.Size(163, 19);
            this.chbSort.TabIndex = 4;
            this.chbSort.Text = "Sort By Descending Name";
            this.chbSort.UseVisualStyleBackColor = true;
            this.chbSort.CheckedChanged += new System.EventHandler(this.chbSort_CheckedChanged);
            this.chbSort.CheckStateChanged += new System.EventHandler(this.chbSort_CheckStateChanged);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(449, 465);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(203, 40);
            this.btClose.TabIndex = 9;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(461, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "Member Management";
            // 
            // frmMemberManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 517);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.chbSort);
            this.Controls.Add(this.grMemberList);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmMemberManager";
            this.Text = "frmMemberManager";
            this.Load += new System.EventHandler(this.frmMemberManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grMemberList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbMemberCountry;
        private System.Windows.Forms.TextBox tbMemberCity;
        private System.Windows.Forms.TextBox tbMemberEmail;
        private System.Windows.Forms.TextBox tbMemberName;
        private System.Windows.Forms.TextBox tbMemberPassword;
        private System.Windows.Forms.TextBox tbMemberId;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbMemberEmail;
        private System.Windows.Forms.Label lbMemberName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.Button btDeleteMember;
        private System.Windows.Forms.Button btUpdateMember;
        private System.Windows.Forms.Button btNewMember;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbSearchName;
        private System.Windows.Forms.Label lbSearchId;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox tbSearchName;
        private System.Windows.Forms.TextBox tbSearchId;
        private System.Windows.Forms.ComboBox cbFilterCountry;
        private System.Windows.Forms.ComboBox cbFilterCity;
        private System.Windows.Forms.Label lbFIlterCountry;
        private System.Windows.Forms.Label lbFilterCity;
        private System.Windows.Forms.Button btFilter;
        private System.Windows.Forms.DataGridView grMemberList;
        private System.Windows.Forms.CheckBox chbSort;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label label1;
    }
}