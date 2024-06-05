namespace WindowsFormsUserInfo
{
    partial class formUserInfo
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
            this.SuspendLayout();
            // 
            // formUserInfo
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "formUserInfo";
            this.Load += new System.EventHandler(this.formUserInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinEditors.UltraTextEditor utxtName;
        private Infragistics.Win.Misc.UltraLabel ulblName;
        private Infragistics.Win.Misc.UltraLabel ulblUsername;
        private Infragistics.Win.Misc.UltraLabel ulblAddress;
        private Infragistics.Win.Misc.UltraLabel ulblPhone;
        private Infragistics.Win.Misc.UltraLabel ulblGender;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor utxtUsername;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor utxtAddress;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor utxtPhone;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private Infragistics.Win.AppStyling.Runtime.AppStylistRuntime appStylistRuntime1;
        private Infragistics.Win.UltraWinListView.UltraListView ulistviewUserInfo;
        private Infragistics.Win.Misc.UltraButton ubtnInsert;
        private Infragistics.Win.Misc.UltraButton ubtnUpdate;
        private Infragistics.Win.Misc.UltraButton ubtnDelete;
        private Infragistics.Win.Misc.UltraButton ubtnClose;
        private Infragistics.Win.Misc.UltraButton ubtnReset;
    }
}

