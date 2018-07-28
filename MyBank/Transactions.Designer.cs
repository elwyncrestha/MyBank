namespace MyBank
{
    partial class Transactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transactions));
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.panMoney = new System.Windows.Forms.Panel();
            this.txtPinNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnWithdrawReceipt = new System.Windows.Forms.Button();
            this.gbPins = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnC = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnA = new System.Windows.Forms.Button();
            this.gbActions.SuspendLayout();
            this.panMoney.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbPins.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbActions
            // 
            this.gbActions.BackColor = System.Drawing.Color.Silver;
            this.gbActions.Controls.Add(this.panMoney);
            this.gbActions.Controls.Add(this.panel1);
            this.gbActions.Font = new System.Drawing.Font("Georgia", 16F);
            this.gbActions.Location = new System.Drawing.Point(21, 38);
            this.gbActions.Name = "gbActions";
            this.gbActions.Size = new System.Drawing.Size(440, 395);
            this.gbActions.TabIndex = 0;
            this.gbActions.TabStop = false;
            this.gbActions.Text = "Actions";
            // 
            // panMoney
            // 
            this.panMoney.BackColor = System.Drawing.Color.DimGray;
            this.panMoney.Controls.Add(this.txtPinNum);
            this.panMoney.Controls.Add(this.label2);
            this.panMoney.Controls.Add(this.lblHeading);
            this.panMoney.Controls.Add(this.label3);
            this.panMoney.Controls.Add(this.txtAccountNo);
            this.panMoney.Location = new System.Drawing.Point(154, 31);
            this.panMoney.Name = "panMoney";
            this.panMoney.Size = new System.Drawing.Size(280, 358);
            this.panMoney.TabIndex = 2;
            // 
            // txtPinNum
            // 
            this.txtPinNum.BackColor = System.Drawing.Color.White;
            this.txtPinNum.ForeColor = System.Drawing.Color.DimGray;
            this.txtPinNum.Location = new System.Drawing.Point(22, 184);
            this.txtPinNum.Name = "txtPinNum";
            this.txtPinNum.PasswordChar = '*';
            this.txtPinNum.Size = new System.Drawing.Size(197, 32);
            this.txtPinNum.TabIndex = 2;
            this.txtPinNum.TextChanged += new System.EventHandler(this.txtPinNum_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F);
            this.label2.Location = new System.Drawing.Point(22, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Your Pin Number to Login";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(49, 16);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(170, 18);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Money Marketplace";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Account Number";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.BackColor = System.Drawing.Color.White;
            this.txtAccountNo.ForeColor = System.Drawing.Color.DimGray;
            this.txtAccountNo.Location = new System.Drawing.Point(22, 87);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(197, 32);
            this.txtAccountNo.TabIndex = 0;
            this.txtAccountNo.TextChanged += new System.EventHandler(this.txtAccountNo_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnBalance);
            this.panel1.Controls.Add(this.btnWithdraw);
            this.panel1.Controls.Add(this.btnWithdrawReceipt);
            this.panel1.Location = new System.Drawing.Point(6, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 358);
            this.panel1.TabIndex = 5;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackgroundImage = global::MyBank.Properties.Resources.dashIcon1;
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDashboard.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(3, 218);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(136, 137);
            this.btnDashboard.TabIndex = 5;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnBalance
            // 
            this.btnBalance.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalance.Location = new System.Drawing.Point(3, 5);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(136, 65);
            this.btnBalance.TabIndex = 0;
            this.btnBalance.Text = "Balance";
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.Location = new System.Drawing.Point(3, 76);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(136, 65);
            this.btnWithdraw.TabIndex = 1;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnWithdrawReceipt
            // 
            this.btnWithdrawReceipt.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdrawReceipt.Location = new System.Drawing.Point(3, 147);
            this.btnWithdrawReceipt.Name = "btnWithdrawReceipt";
            this.btnWithdrawReceipt.Size = new System.Drawing.Size(136, 65);
            this.btnWithdrawReceipt.TabIndex = 2;
            this.btnWithdrawReceipt.Text = "Withdraw with Receipt";
            this.btnWithdrawReceipt.UseVisualStyleBackColor = true;
            this.btnWithdrawReceipt.Click += new System.EventHandler(this.btnWithdrawReceipt_Click);
            // 
            // gbPins
            // 
            this.gbPins.BackColor = System.Drawing.Color.Silver;
            this.gbPins.Controls.Add(this.panel3);
            this.gbPins.Controls.Add(this.label4);
            this.gbPins.Font = new System.Drawing.Font("Georgia", 16F);
            this.gbPins.Location = new System.Drawing.Point(468, 38);
            this.gbPins.Name = "gbPins";
            this.gbPins.Size = new System.Drawing.Size(233, 395);
            this.gbPins.TabIndex = 1;
            this.gbPins.TabStop = false;
            this.gbPins.Text = "Pins";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.btnA);
            this.panel3.Controls.Add(this.btnC);
            this.panel3.Controls.Add(this.btnSeven);
            this.panel3.Controls.Add(this.btnZero);
            this.panel3.Controls.Add(this.btnEight);
            this.panel3.Controls.Add(this.btnNine);
            this.panel3.Controls.Add(this.btnThree);
            this.panel3.Controls.Add(this.btnFour);
            this.panel3.Controls.Add(this.btnTwo);
            this.panel3.Controls.Add(this.btnFive);
            this.panel3.Controls.Add(this.btnOne);
            this.panel3.Controls.Add(this.btnSix);
            this.panel3.Location = new System.Drawing.Point(16, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 268);
            this.panel3.TabIndex = 15;
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.LightGray;
            this.btnC.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(137, 203);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(60, 60);
            this.btnC.TabIndex = 14;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.Color.LightGray;
            this.btnSeven.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.Location = new System.Drawing.Point(5, 5);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(60, 60);
            this.btnSeven.TabIndex = 3;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.btnPins_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.LightGray;
            this.btnZero.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(71, 203);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(60, 60);
            this.btnZero.TabIndex = 13;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnPins_Click);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.Color.LightGray;
            this.btnEight.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.Location = new System.Drawing.Point(71, 5);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(60, 60);
            this.btnEight.TabIndex = 4;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.btnPins_Click);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.Color.LightGray;
            this.btnNine.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.Location = new System.Drawing.Point(137, 5);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(60, 60);
            this.btnNine.TabIndex = 5;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.btnPins_Click);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.Color.LightGray;
            this.btnThree.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.Location = new System.Drawing.Point(137, 137);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(60, 60);
            this.btnThree.TabIndex = 11;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.btnPins_Click);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.Color.LightGray;
            this.btnFour.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.Location = new System.Drawing.Point(5, 71);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(60, 60);
            this.btnFour.TabIndex = 6;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.btnPins_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.LightGray;
            this.btnTwo.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.Location = new System.Drawing.Point(71, 137);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(60, 60);
            this.btnTwo.TabIndex = 10;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.btnPins_Click);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.Color.LightGray;
            this.btnFive.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.Location = new System.Drawing.Point(71, 71);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(60, 60);
            this.btnFive.TabIndex = 7;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.btnPins_Click);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.Color.LightGray;
            this.btnOne.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.Location = new System.Drawing.Point(5, 137);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(60, 60);
            this.btnOne.TabIndex = 9;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.btnPins_Click);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.Color.LightGray;
            this.btnSix.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.Location = new System.Drawing.Point(137, 71);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(60, 60);
            this.btnSix.TabIndex = 8;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.btnPins_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "ATM Card Pin";
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.LightGray;
            this.btnA.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(5, 203);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(60, 60);
            this.btnA.TabIndex = 15;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyBank.Properties.Resources.transactionsBg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(720, 448);
            this.Controls.Add(this.gbPins);
            this.Controls.Add(this.gbActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Transactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.Transactions_Load);
            this.gbActions.ResumeLayout(false);
            this.panMoney.ResumeLayout(false);
            this.panMoney.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gbPins.ResumeLayout(false);
            this.gbPins.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbActions;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.GroupBox gbPins;
        private System.Windows.Forms.Panel panMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnWithdrawReceipt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.TextBox txtPinNum;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnA;
    }
}