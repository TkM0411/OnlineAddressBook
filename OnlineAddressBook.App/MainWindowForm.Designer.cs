
namespace OnlineAddressBook.App
{
    partial class MainWindowForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowForm));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tblpnlMainContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tblpnlButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.tblpnlEditableControls = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            this.pnlMain.SuspendLayout();
            this.tblpnlMainContainer.SuspendLayout();
            this.tblpnlButtons.SuspendLayout();
            this.tblpnlEditableControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tblpnlMainContainer);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(626, 262);
            this.pnlMain.TabIndex = 0;
            // 
            // tblpnlMainContainer
            // 
            this.tblpnlMainContainer.ColumnCount = 1;
            this.tblpnlMainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlMainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblpnlMainContainer.Controls.Add(this.tblpnlButtons, 0, 1);
            this.tblpnlMainContainer.Controls.Add(this.tblpnlEditableControls, 0, 0);
            this.tblpnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnlMainContainer.Location = new System.Drawing.Point(0, 0);
            this.tblpnlMainContainer.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.tblpnlMainContainer.Name = "tblpnlMainContainer";
            this.tblpnlMainContainer.RowCount = 2;
            this.tblpnlMainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlMainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblpnlMainContainer.Size = new System.Drawing.Size(626, 262);
            this.tblpnlMainContainer.TabIndex = 0;
            // 
            // tblpnlButtons
            // 
            this.tblpnlButtons.ColumnCount = 7;
            this.tblpnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblpnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblpnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblpnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblpnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblpnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpnlButtons.Controls.Add(this.btnPrevious, 1, 0);
            this.tblpnlButtons.Controls.Add(this.btnSave, 3, 0);
            this.tblpnlButtons.Controls.Add(this.btnNext, 5, 0);
            this.tblpnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnlButtons.Location = new System.Drawing.Point(3, 215);
            this.tblpnlButtons.Name = "tblpnlButtons";
            this.tblpnlButtons.RowCount = 1;
            this.tblpnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlButtons.Size = new System.Drawing.Size(620, 44);
            this.tblpnlButtons.TabIndex = 0;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrevious.Location = new System.Drawing.Point(67, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(94, 38);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "&Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(263, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 38);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNext.Location = new System.Drawing.Point(459, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 38);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "&Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tblpnlEditableControls
            // 
            this.tblpnlEditableControls.ColumnCount = 3;
            this.tblpnlEditableControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.40096F));
            this.tblpnlEditableControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.59904F));
            this.tblpnlEditableControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.tblpnlEditableControls.Controls.Add(this.lblName, 0, 0);
            this.tblpnlEditableControls.Controls.Add(this.lblPhoneNumber, 0, 1);
            this.tblpnlEditableControls.Controls.Add(this.lblAddress, 0, 2);
            this.tblpnlEditableControls.Controls.Add(this.txtName, 1, 0);
            this.tblpnlEditableControls.Controls.Add(this.txtPhoneNumber, 1, 1);
            this.tblpnlEditableControls.Controls.Add(this.rtbAddress, 1, 2);
            this.tblpnlEditableControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnlEditableControls.Location = new System.Drawing.Point(3, 3);
            this.tblpnlEditableControls.Name = "tblpnlEditableControls";
            this.tblpnlEditableControls.RowCount = 3;
            this.tblpnlEditableControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpnlEditableControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpnlEditableControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblpnlEditableControls.Size = new System.Drawing.Size(620, 206);
            this.tblpnlEditableControls.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Location = new System.Drawing.Point(3, 3);
            this.lblName.Margin = new System.Windows.Forms.Padding(3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(112, 35);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhoneNumber.Location = new System.Drawing.Point(3, 44);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(3);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(112, 35);
            this.lblPhoneNumber.TabIndex = 1;
            this.lblPhoneNumber.Text = "Phone Number";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddress.Location = new System.Drawing.Point(3, 85);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(3);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(112, 118);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Location = new System.Drawing.Point(121, 7);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(293, 25);
            this.txtName.TabIndex = 3;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPhoneNumber.Location = new System.Drawing.Point(121, 48);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.txtPhoneNumber.MaxLength = 15;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(293, 25);
            this.txtPhoneNumber.TabIndex = 4;
            // 
            // rtbAddress
            // 
            this.rtbAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbAddress.Location = new System.Drawing.Point(121, 85);
            this.rtbAddress.MaxLength = 200;
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(293, 118);
            this.rtbAddress.TabIndex = 5;
            this.rtbAddress.Text = "";
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 262);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindowForm";
            this.Text = "Online Address Book";
            this.Load += new System.EventHandler(this.MainWindowForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.tblpnlMainContainer.ResumeLayout(false);
            this.tblpnlButtons.ResumeLayout(false);
            this.tblpnlEditableControls.ResumeLayout(false);
            this.tblpnlEditableControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TableLayoutPanel tblpnlMainContainer;
        private System.Windows.Forms.TableLayoutPanel tblpnlButtons;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TableLayoutPanel tblpnlEditableControls;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.RichTextBox rtbAddress;
    }
}

