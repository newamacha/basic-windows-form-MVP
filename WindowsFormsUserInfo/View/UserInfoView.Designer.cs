namespace WindowsFormsUserInfo.View
{
    partial class UserInfoView
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
            this.utxtName = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.utxtUsername = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.utxtAddress = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.utxtPhone = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ulblName = new Infragistics.Win.Misc.UltraLabel();
            this.ulblUsername = new Infragistics.Win.Misc.UltraLabel();
            this.ulblAddress = new Infragistics.Win.Misc.UltraLabel();
            this.ulblPhone = new Infragistics.Win.Misc.UltraLabel();
            this.ulblGender = new Infragistics.Win.Misc.UltraLabel();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.ubtnInsert = new Infragistics.Win.Misc.UltraButton();
            this.ubtnUpdate = new Infragistics.Win.Misc.UltraButton();
            this.ubtnDelete = new Infragistics.Win.Misc.UltraButton();
            this.ubtnExit = new Infragistics.Win.Misc.UltraButton();
            this.ubtnReset = new Infragistics.Win.Misc.UltraButton();
            this.listUsers = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.utxtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utxtUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utxtAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utxtPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // utxtName
            // 
            this.utxtName.Location = new System.Drawing.Point(202, 50);
            this.utxtName.Name = "utxtName";
            this.utxtName.Size = new System.Drawing.Size(283, 24);
            this.utxtName.TabIndex = 1;
            // 
            // utxtUsername
            // 
            this.utxtUsername.Location = new System.Drawing.Point(202, 100);
            this.utxtUsername.Name = "utxtUsername";
            this.utxtUsername.Size = new System.Drawing.Size(283, 24);
            this.utxtUsername.TabIndex = 2;
            // 
            // utxtAddress
            // 
            this.utxtAddress.Location = new System.Drawing.Point(202, 149);
            this.utxtAddress.Name = "utxtAddress";
            this.utxtAddress.Size = new System.Drawing.Size(283, 24);
            this.utxtAddress.TabIndex = 3;
            // 
            // utxtPhone
            // 
            this.utxtPhone.Location = new System.Drawing.Point(202, 194);
            this.utxtPhone.Name = "utxtPhone";
            this.utxtPhone.Size = new System.Drawing.Size(283, 24);
            this.utxtPhone.TabIndex = 4;
            // 
            // ulblName
            // 
            this.ulblName.Location = new System.Drawing.Point(76, 54);
            this.ulblName.Name = "ulblName";
            this.ulblName.Size = new System.Drawing.Size(100, 23);
            this.ulblName.TabIndex = 6;
            this.ulblName.Text = "Name";
            // 
            // ulblUsername
            // 
            this.ulblUsername.Location = new System.Drawing.Point(76, 104);
            this.ulblUsername.Name = "ulblUsername";
            this.ulblUsername.Size = new System.Drawing.Size(100, 23);
            this.ulblUsername.TabIndex = 7;
            this.ulblUsername.Text = "Username";
            // 
            // ulblAddress
            // 
            this.ulblAddress.Location = new System.Drawing.Point(76, 153);
            this.ulblAddress.Name = "ulblAddress";
            this.ulblAddress.Size = new System.Drawing.Size(100, 23);
            this.ulblAddress.TabIndex = 8;
            this.ulblAddress.Text = "Address";
            // 
            // ulblPhone
            // 
            this.ulblPhone.Location = new System.Drawing.Point(76, 198);
            this.ulblPhone.Name = "ulblPhone";
            this.ulblPhone.Size = new System.Drawing.Size(100, 23);
            this.ulblPhone.TabIndex = 9;
            this.ulblPhone.Text = "Phone";
            // 
            // ulblGender
            // 
            this.ulblGender.Location = new System.Drawing.Point(76, 242);
            this.ulblGender.Name = "ulblGender";
            this.ulblGender.Size = new System.Drawing.Size(100, 23);
            this.ulblGender.TabIndex = 10;
            this.ulblGender.Text = "Gender";
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(202, 240);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(58, 20);
            this.rbtnMale.TabIndex = 11;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(286, 240);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(74, 20);
            this.rbtnFemale.TabIndex = 12;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // ubtnInsert
            // 
            this.ubtnInsert.Location = new System.Drawing.Point(76, 494);
            this.ubtnInsert.Name = "ubtnInsert";
            this.ubtnInsert.Size = new System.Drawing.Size(75, 23);
            this.ubtnInsert.TabIndex = 14;
            this.ubtnInsert.Text = "Insert";
            this.ubtnInsert.Click += new System.EventHandler(this.ubtnInsert_Click);
            // 
            // ubtnUpdate
            // 
            this.ubtnUpdate.Location = new System.Drawing.Point(202, 494);
            this.ubtnUpdate.Name = "ubtnUpdate";
            this.ubtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.ubtnUpdate.TabIndex = 15;
            this.ubtnUpdate.Text = "Update";
            this.ubtnUpdate.Click += new System.EventHandler(this.ubtnUpdate_Click);
            // 
            // ubtnDelete
            // 
            this.ubtnDelete.Location = new System.Drawing.Point(338, 494);
            this.ubtnDelete.Name = "ubtnDelete";
            this.ubtnDelete.Size = new System.Drawing.Size(75, 23);
            this.ubtnDelete.TabIndex = 16;
            this.ubtnDelete.Text = "Delete";
            this.ubtnDelete.Click += new System.EventHandler(this.ubtnDelete_Click);
            // 
            // ubtnExit
            // 
            this.ubtnExit.Location = new System.Drawing.Point(641, 494);
            this.ubtnExit.Name = "ubtnExit";
            this.ubtnExit.Size = new System.Drawing.Size(75, 23);
            this.ubtnExit.TabIndex = 17;
            this.ubtnExit.Text = "Exit";
            this.ubtnExit.Click += new System.EventHandler(this.ubtnExit_Click);
            // 
            // ubtnReset
            // 
            this.ubtnReset.Location = new System.Drawing.Point(522, 49);
            this.ubtnReset.Name = "ubtnReset";
            this.ubtnReset.Size = new System.Drawing.Size(75, 23);
            this.ubtnReset.TabIndex = 18;
            this.ubtnReset.Text = "Reset";
            this.ubtnReset.Click += new System.EventHandler(this.ubtnReset_Click);
            // 
            // listUsers
            // 
            this.listUsers.FormattingEnabled = true;
            this.listUsers.ItemHeight = 16;
            this.listUsers.Location = new System.Drawing.Point(76, 288);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(640, 180);
            this.listUsers.TabIndex = 20;
            this.listUsers.SelectedIndexChanged += new System.EventHandler(this.listUsers_SelectedIndexChanged_1);
            // 
            // UserInfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.listUsers);
            this.Controls.Add(this.ubtnReset);
            this.Controls.Add(this.ubtnExit);
            this.Controls.Add(this.ubtnDelete);
            this.Controls.Add(this.ubtnUpdate);
            this.Controls.Add(this.ubtnInsert);
            this.Controls.Add(this.rbtnFemale);
            this.Controls.Add(this.rbtnMale);
            this.Controls.Add(this.ulblGender);
            this.Controls.Add(this.ulblPhone);
            this.Controls.Add(this.ulblAddress);
            this.Controls.Add(this.ulblUsername);
            this.Controls.Add(this.ulblName);
            this.Controls.Add(this.utxtPhone);
            this.Controls.Add(this.utxtAddress);
            this.Controls.Add(this.utxtUsername);
            this.Controls.Add(this.utxtName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 600);
            this.MinimumSize = new System.Drawing.Size(818, 600);
            this.Name = "UserInfoView";
            this.Text = "UserInfoView";
            ((System.ComponentModel.ISupportInitialize)(this.utxtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utxtUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utxtAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utxtPhone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinEditors.UltraTextEditor utxtName;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor utxtUsername;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor utxtAddress;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor utxtPhone;
        private Infragistics.Win.Misc.UltraLabel ulblName;
        private Infragistics.Win.Misc.UltraLabel ulblUsername;
        private Infragistics.Win.Misc.UltraLabel ulblAddress;
        private Infragistics.Win.Misc.UltraLabel ulblPhone;
        private Infragistics.Win.Misc.UltraLabel ulblGender;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private Infragistics.Win.Misc.UltraButton ubtnInsert;
        private Infragistics.Win.Misc.UltraButton ubtnUpdate;
        private Infragistics.Win.Misc.UltraButton ubtnDelete;
        private Infragistics.Win.Misc.UltraButton ubtnExit;
        private Infragistics.Win.Misc.UltraButton ubtnReset;
        private System.Windows.Forms.ListBox listUsers;
    }
}