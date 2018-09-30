﻿using System.Drawing;
using System.Drawing.Drawing2D;

namespace Acct
{
    partial class APForm
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
            this.acctpayablelbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.acctpayablepanel = new GradientPanel();
            this.closebtn = new System.Windows.Forms.Button();
            this.writeCheckbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.invoiceNotb = new System.Windows.Forms.TextBox();
            this.amounttb = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.timetb = new System.Windows.Forms.TextBox();
            this.datetb = new System.Windows.Forms.TextBox();
            this.lastnametb = new System.Windows.Forms.TextBox();
            this.companytb = new System.Windows.Forms.TextBox();
            this.firstNametb = new System.Windows.Forms.TextBox();
            this.datelbl = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.invoiceno = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.company = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.acctpayablepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // acctpayablelbl
            // 
            this.acctpayablelbl.AutoSize = true;
            this.acctpayablelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acctpayablelbl.Location = new System.Drawing.Point(3, 17);
            this.acctpayablelbl.Name = "acctpayablelbl";
            this.acctpayablelbl.Size = new System.Drawing.Size(347, 37);
            this.acctpayablelbl.TabIndex = 0;
            this.acctpayablelbl.Text = "Accounts Payable (AP)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(3, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 10);
            this.panel1.TabIndex = 1;
            // 
            // acctpayablepanel
            // 
            this.acctpayablepanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.acctpayablepanel.Controls.Add(this.closebtn);
            this.acctpayablepanel.Controls.Add(this.writeCheckbtn);
            this.acctpayablepanel.Controls.Add(this.deletebtn);
            this.acctpayablepanel.Controls.Add(this.savebtn);
            this.acctpayablepanel.Controls.Add(this.invoiceNotb);
            this.acctpayablepanel.Controls.Add(this.amounttb);
            this.acctpayablepanel.Controls.Add(this.description);
            this.acctpayablepanel.Controls.Add(this.timetb);
            this.acctpayablepanel.Controls.Add(this.datetb);
            this.acctpayablepanel.Controls.Add(this.lastnametb);
            this.acctpayablepanel.Controls.Add(this.companytb);
            this.acctpayablepanel.Controls.Add(this.firstNametb);
            this.acctpayablepanel.Controls.Add(this.datelbl);
            this.acctpayablepanel.Controls.Add(this.time);
            this.acctpayablepanel.Controls.Add(this.invoiceno);
            this.acctpayablepanel.Controls.Add(this.desc);
            this.acctpayablepanel.Controls.Add(this.amount);
            this.acctpayablepanel.Controls.Add(this.lastName);
            this.acctpayablepanel.Controls.Add(this.company);
            this.acctpayablepanel.Controls.Add(this.firstName);
            this.acctpayablepanel.Controls.Add(this.acctpayablelbl);
            this.acctpayablepanel.Controls.Add(this.panel1);
            this.acctpayablepanel.Location = new System.Drawing.Point(12, 12);
            this.acctpayablepanel.Name = "acctpayablepanel";
            this.acctpayablepanel.Size = new System.Drawing.Size(699, 312);
            this.acctpayablepanel.TabIndex = 2;
            //
            // closebtn
            // 
            this.closebtn.Location = new System.Drawing.Point(605, 264);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(75, 23);
            this.closebtn.TabIndex = 5;
            this.closebtn.TabStop = false;
            this.closebtn.Text = "Close";
            this.closebtn.UseVisualStyleBackColor = true;
            // 
            // writeCheckbtn
            // 
            this.writeCheckbtn.Location = new System.Drawing.Point(528, 76);
            this.writeCheckbtn.Name = "writeCheckbtn";
            this.writeCheckbtn.Size = new System.Drawing.Size(75, 23);
            this.writeCheckbtn.TabIndex = 5;
            this.writeCheckbtn.TabStop = false;
            this.writeCheckbtn.Text = "Write Check";
            this.writeCheckbtn.UseVisualStyleBackColor = true;
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(447, 264);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 23);
            this.deletebtn.TabIndex = 5;
            this.deletebtn.TabStop = false;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(528, 264);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 23);
            this.savebtn.TabIndex = 5;
            this.savebtn.TabStop = false;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // invoiceNotb
            // 
            this.invoiceNotb.Location = new System.Drawing.Point(204, 145);
            this.invoiceNotb.Name = "invoiceNotb";
            this.invoiceNotb.Size = new System.Drawing.Size(100, 20);
            this.invoiceNotb.TabIndex = 5;
            // 
            // amounttb
            // 
            this.amounttb.Location = new System.Drawing.Point(191, 121);
            this.amounttb.Name = "amounttb";
            this.amounttb.Size = new System.Drawing.Size(113, 20);
            this.amounttb.TabIndex = 4;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(73, 178);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(231, 118);
            this.description.TabIndex = 6;
            // 
            // timetb
            // 
            this.timetb.Location = new System.Drawing.Point(40, 145);
            this.timetb.Name = "timetb";
            this.timetb.Size = new System.Drawing.Size(100, 20);
            this.timetb.TabIndex = 4;
            this.timetb.TabStop = false;
            // 
            // datetb
            // 
            this.datetb.Location = new System.Drawing.Point(40, 121);
            this.datetb.Name = "datetb";
            this.datetb.Size = new System.Drawing.Size(100, 20);
            this.datetb.TabIndex = 4;
            this.datetb.TabStop = false;
            // 
            // lastnametb
            // 
            this.lastnametb.Location = new System.Drawing.Point(252, 78);
            this.lastnametb.Name = "lastnametb";
            this.lastnametb.Size = new System.Drawing.Size(100, 20);
            this.lastnametb.TabIndex = 2;
            // 
            // companytb
            // 
            this.companytb.Location = new System.Drawing.Point(61, 98);
            this.companytb.Name = "companytb";
            this.companytb.Size = new System.Drawing.Size(100, 20);
            this.companytb.TabIndex = 3;
            // 
            // firstNametb
            // 
            this.firstNametb.Location = new System.Drawing.Point(61, 78);
            this.firstNametb.Name = "firstNametb";
            this.firstNametb.Size = new System.Drawing.Size(100, 20);
            this.firstNametb.TabIndex = 1;
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Location = new System.Drawing.Point(7, 124);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(30, 13);
            this.datelbl.TabIndex = 3;
            this.datelbl.Text = "Date";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(7, 148);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(30, 13);
            this.time.TabIndex = 2;
            this.time.Text = "Time";
            // 
            // invoiceno
            // 
            this.invoiceno.AutoSize = true;
            this.invoiceno.Location = new System.Drawing.Point(146, 148);
            this.invoiceno.Name = "invoiceno";
            this.invoiceno.Size = new System.Drawing.Size(62, 13);
            this.invoiceno.TabIndex = 2;
            this.invoiceno.Text = "Invoice No.";
            // 
            // desc
            // 
            this.desc.AutoSize = true;
            this.desc.Location = new System.Drawing.Point(7, 181);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(60, 13);
            this.desc.TabIndex = 2;
            this.desc.Text = "Description";
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Location = new System.Drawing.Point(146, 124);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(43, 13);
            this.amount.TabIndex = 2;
            this.amount.Text = "Amount";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(188, 81);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(58, 13);
            this.lastName.TabIndex = 2;
            this.lastName.Text = "Last Name";
            // 
            // company
            // 
            this.company.AutoSize = true;
            this.company.Location = new System.Drawing.Point(7, 101);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(51, 13);
            this.company.TabIndex = 2;
            this.company.Text = "Company";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(7, 81);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(57, 13);
            this.firstName.TabIndex = 2;
            this.firstName.Text = "First Name";
            // 
            // APForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 336);
            this.Controls.Add(this.acctpayablepanel);
            this.Name = "APForm";
            this.Text = "NewAPForm";
            this.acctpayablepanel.ResumeLayout(false);
            this.acctpayablepanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label acctpayablelbl;
        private System.Windows.Forms.Panel panel1;
        private GradientPanel acctpayablepanel;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.TextBox invoiceNotb;
        private System.Windows.Forms.TextBox amounttb;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox timetb;
        private System.Windows.Forms.TextBox datetb;
        private System.Windows.Forms.TextBox lastnametb;
        private System.Windows.Forms.TextBox firstNametb;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label invoiceno;
        private System.Windows.Forms.Label desc;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.TextBox companytb;
        private System.Windows.Forms.Label company;
        private System.Windows.Forms.Button writeCheckbtn;
        private System.Windows.Forms.Button deletebtn;
    }
}