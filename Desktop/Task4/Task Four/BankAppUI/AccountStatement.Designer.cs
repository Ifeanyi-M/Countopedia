
namespace BankAppUI
{
    partial class AccountStatement
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
            this.lblChoose = new System.Windows.Forms.Label();
            this.cmbChooseAccount = new System.Windows.Forms.ComboBox();
            this.dgAccountStatement = new System.Windows.Forms.DataGridView();
            this.AccNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccountStatement)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChoose.Location = new System.Drawing.Point(372, 90);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(205, 32);
            this.lblChoose.TabIndex = 0;
            this.lblChoose.Text = "Choose Account";
            // 
            // cmbChooseAccount
            // 
            this.cmbChooseAccount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbChooseAccount.FormattingEnabled = true;
            this.cmbChooseAccount.Location = new System.Drawing.Point(607, 96);
            this.cmbChooseAccount.Name = "cmbChooseAccount";
            this.cmbChooseAccount.Size = new System.Drawing.Size(253, 33);
            this.cmbChooseAccount.TabIndex = 1;
            this.cmbChooseAccount.SelectedIndexChanged += new System.EventHandler(this.cmbChooseAccount_SelectedIndexChanged);
            // 
            // dgAccountStatement
            // 
            this.dgAccountStatement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccountStatement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccNum,
            this.Description,
            this.Amount,
            this.RemainBalance,
            this.Date});
            this.dgAccountStatement.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgAccountStatement.Location = new System.Drawing.Point(12, 162);
            this.dgAccountStatement.Name = "dgAccountStatement";
            this.dgAccountStatement.RowHeadersWidth = 51;
            this.dgAccountStatement.RowTemplate.Height = 29;
            this.dgAccountStatement.Size = new System.Drawing.Size(1007, 557);
            this.dgAccountStatement.TabIndex = 2;
            // 
            // AccNum
            // 
            this.AccNum.HeaderText = "Account Number";
            this.AccNum.MinimumWidth = 6;
            this.AccNum.Name = "AccNum";
            this.AccNum.Width = 180;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 400;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.Width = 125;
            // 
            // RemainBalance
            // 
            this.RemainBalance.HeaderText = "Balance";
            this.RemainBalance.MinimumWidth = 6;
            this.RemainBalance.Name = "RemainBalance";
            this.RemainBalance.Width = 125;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // AccountStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1031, 731);
            this.Controls.Add(this.dgAccountStatement);
            this.Controls.Add(this.cmbChooseAccount);
            this.Controls.Add(this.lblChoose);
            this.Name = "AccountStatement";
            this.Text = "AccountStatement";
            this.Load += new System.EventHandler(this.AccountStatement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAccountStatement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.ComboBox cmbChooseAccount;
        private System.Windows.Forms.DataGridView dgAccountStatement;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}