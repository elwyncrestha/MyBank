namespace MyBank
{
    partial class ChangePinNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePinNumber));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerACNo = new System.Windows.Forms.TextBox();
            this.txtOldPinNo = new System.Windows.Forms.TextBox();
            this.txtNewPinNo = new System.Windows.Forms.TextBox();
            this.txtConfirmNewPin = new System.Windows.Forms.TextBox();
            this.btnPinChange = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 16F);
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer A/C No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 16F);
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Old Pin Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 16F);
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Pin Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 16F);
            this.label4.Location = new System.Drawing.Point(14, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirm New Pin";
            // 
            // txtCustomerACNo
            // 
            this.txtCustomerACNo.Font = new System.Drawing.Font("Georgia", 16F);
            this.txtCustomerACNo.Location = new System.Drawing.Point(285, 51);
            this.txtCustomerACNo.Name = "txtCustomerACNo";
            this.txtCustomerACNo.Size = new System.Drawing.Size(133, 32);
            this.txtCustomerACNo.TabIndex = 4;
            // 
            // txtOldPinNo
            // 
            this.txtOldPinNo.Font = new System.Drawing.Font("Georgia", 16F);
            this.txtOldPinNo.Location = new System.Drawing.Point(285, 90);
            this.txtOldPinNo.Name = "txtOldPinNo";
            this.txtOldPinNo.PasswordChar = '*';
            this.txtOldPinNo.Size = new System.Drawing.Size(133, 32);
            this.txtOldPinNo.TabIndex = 5;
            // 
            // txtNewPinNo
            // 
            this.txtNewPinNo.Font = new System.Drawing.Font("Georgia", 16F);
            this.txtNewPinNo.Location = new System.Drawing.Point(285, 133);
            this.txtNewPinNo.Name = "txtNewPinNo";
            this.txtNewPinNo.PasswordChar = '*';
            this.txtNewPinNo.Size = new System.Drawing.Size(133, 32);
            this.txtNewPinNo.TabIndex = 6;
            // 
            // txtConfirmNewPin
            // 
            this.txtConfirmNewPin.Font = new System.Drawing.Font("Georgia", 16F);
            this.txtConfirmNewPin.Location = new System.Drawing.Point(285, 176);
            this.txtConfirmNewPin.Name = "txtConfirmNewPin";
            this.txtConfirmNewPin.PasswordChar = '*';
            this.txtConfirmNewPin.Size = new System.Drawing.Size(133, 32);
            this.txtConfirmNewPin.TabIndex = 7;
            // 
            // btnPinChange
            // 
            this.btnPinChange.BackgroundImage = global::MyBank.Properties.Resources.changePin;
            this.btnPinChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPinChange.Font = new System.Drawing.Font("Georgia", 16F);
            this.btnPinChange.Location = new System.Drawing.Point(285, 235);
            this.btnPinChange.Name = "btnPinChange";
            this.btnPinChange.Size = new System.Drawing.Size(133, 77);
            this.btnPinChange.TabIndex = 8;
            this.btnPinChange.Text = "Change";
            this.btnPinChange.UseVisualStyleBackColor = true;
            this.btnPinChange.Click += new System.EventHandler(this.btnPinChange_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BackgroundImage = global::MyBank.Properties.Resources.dashIcon1;
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDashboard.Font = new System.Drawing.Font("Georgia", 16F);
            this.btnDashboard.Location = new System.Drawing.Point(500, 48);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(136, 162);
            this.btnDashboard.TabIndex = 11;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // ChangePinNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyBank.Properties.Resources.changepinBg;
            this.ClientSize = new System.Drawing.Size(669, 393);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPinChange);
            this.Controls.Add(this.txtConfirmNewPin);
            this.Controls.Add(this.txtNewPinNo);
            this.Controls.Add(this.txtOldPinNo);
            this.Controls.Add(this.txtCustomerACNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChangePinNumber";
            this.Text = "ChangePinNumber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerACNo;
        private System.Windows.Forms.TextBox txtOldPinNo;
        private System.Windows.Forms.TextBox txtNewPinNo;
        private System.Windows.Forms.TextBox txtConfirmNewPin;
        private System.Windows.Forms.Button btnPinChange;
        private System.Windows.Forms.Button btnDashboard;
    }
}