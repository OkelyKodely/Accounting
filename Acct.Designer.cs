namespace Acct
{
    partial class Acct
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
            this.acctlistpanel = new GradientPanel();
            this.expensesAndIncomebtn = new System.Windows.Forms.Button();
            this.newarbtn = new System.Windows.Forms.Button();
            this.newapbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.acctreceivablelbl = new System.Windows.Forms.Label();
            this.balass = new System.Windows.Forms.Label();
            this.balanceassetlbl = new System.Windows.Forms.Label();
            this.acctpayablelbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.acctlistlbl = new System.Windows.Forms.Label();
            this.file = new System.Windows.Forms.MainMenu(this.components);
            this.acctlistpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // acctlistpanel
            // 
            this.acctlistpanel.Controls.Add(this.expensesAndIncomebtn);
            this.acctlistpanel.Controls.Add(this.newarbtn);
            this.acctlistpanel.Controls.Add(this.newapbtn);
            this.acctlistpanel.Controls.Add(this.dataGridView1);
            this.acctlistpanel.Controls.Add(this.dataGridView2);
            this.acctlistpanel.Controls.Add(this.acctreceivablelbl);
            this.acctlistpanel.Controls.Add(this.balass);
            this.acctlistpanel.Controls.Add(this.balanceassetlbl);
            this.acctlistpanel.Controls.Add(this.acctpayablelbl);
            this.acctlistpanel.Controls.Add(this.panel1);
            this.acctlistpanel.Controls.Add(this.acctlistlbl);
            this.acctlistpanel.Location = new System.Drawing.Point(12, 12);
            this.acctlistpanel.Name = "acctlistpanel";
            this.acctlistpanel.Size = new System.Drawing.Size(703, 533);
            this.acctlistpanel.TabIndex = 0;
            // 
            // expensesAndIncomebtn
            // 
            this.expensesAndIncomebtn.Location = new System.Drawing.Point(534, 60);
            this.expensesAndIncomebtn.Name = "expensesAndIncomebtn";
            this.expensesAndIncomebtn.Size = new System.Drawing.Size(127, 23);
            this.expensesAndIncomebtn.TabIndex = 6;
            this.expensesAndIncomebtn.Text = "Expenses And Income";
            this.expensesAndIncomebtn.UseVisualStyleBackColor = true;
            this.expensesAndIncomebtn.Click += new System.EventHandler(this.expensesAndIncomebtn_Click);
            // 
            // newarbtn
            // 
            this.newarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newarbtn.Location = new System.Drawing.Point(155, 305);
            this.newarbtn.Name = "newarbtn";
            this.newarbtn.Size = new System.Drawing.Size(75, 21);
            this.newarbtn.TabIndex = 5;
            this.newarbtn.Text = "New AR";
            this.newarbtn.UseVisualStyleBackColor = true;
            this.newarbtn.Click += new System.EventHandler(this.newarbtn_Click);
            // 
            // newapbtn
            // 
            this.newapbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newapbtn.Location = new System.Drawing.Point(148, 63);
            this.newapbtn.Name = "newapbtn";
            this.newapbtn.Size = new System.Drawing.Size(75, 21);
            this.newapbtn.TabIndex = 4;
            this.newapbtn.Text = "New AP";
            this.newapbtn.UseVisualStyleBackColor = true;
            this.newapbtn.Click += new System.EventHandler(this.newapbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(19, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(662, 201);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView2.Location = new System.Drawing.Point(19, 329);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.Size = new System.Drawing.Size(662, 187);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // acctreceivablelbl
            // 
            this.acctreceivablelbl.AutoSize = true;
            this.acctreceivablelbl.Location = new System.Drawing.Point(16, 313);
            this.acctreceivablelbl.Name = "acctreceivablelbl";
            this.acctreceivablelbl.Size = new System.Drawing.Size(133, 13);
            this.acctreceivablelbl.TabIndex = 2;
            this.acctreceivablelbl.Text = "Accounts Receivable (AR)";
            // 
            // balass
            // 
            this.balass.AutoSize = true;
            this.balass.Location = new System.Drawing.Point(364, 66);
            this.balass.MinimumSize = new System.Drawing.Size(200, 13);
            this.balass.Name = "balass";
            this.balass.Size = new System.Drawing.Size(200, 13);
            this.balass.TabIndex = 2;
            // 
            // balanceassetlbl
            // 
            this.balanceassetlbl.AutoSize = true;
            this.balanceassetlbl.Location = new System.Drawing.Point(280, 66);
            this.balanceassetlbl.Name = "balanceassetlbl";
            this.balanceassetlbl.Size = new System.Drawing.Size(78, 13);
            this.balanceassetlbl.TabIndex = 2;
            this.balanceassetlbl.Text = "Balance Asset:";
            // 
            // acctpayablelbl
            // 
            this.acctpayablelbl.AutoSize = true;
            this.acctpayablelbl.Location = new System.Drawing.Point(16, 66);
            this.acctpayablelbl.Name = "acctpayablelbl";
            this.acctpayablelbl.Size = new System.Drawing.Size(116, 13);
            this.acctpayablelbl.TabIndex = 2;
            this.acctpayablelbl.Text = "Accounts Payable (AP)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(19, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 10);
            this.panel1.TabIndex = 1;
            // 
            // acctlistlbl
            // 
            this.acctlistlbl.AutoSize = true;
            this.acctlistlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acctlistlbl.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.acctlistlbl.Location = new System.Drawing.Point(12, 10);
            this.acctlistlbl.Name = "acctlistlbl";
            this.acctlistlbl.Size = new System.Drawing.Size(285, 37);
            this.acctlistlbl.TabIndex = 0;
            this.acctlistlbl.Text = "Accounting Pro v.1";
            // 
            // Acct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(727, 557);
            this.Controls.Add(this.acctlistpanel);
            this.Menu = this.file;
            this.Name = "Acct";
            this.Opacity = 0.98D;
            this.Text = "Accounting Pro v.1";
            this.acctlistpanel.ResumeLayout(false);
            this.acctlistpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel acctlistpanel;
        private System.Windows.Forms.Label acctreceivablelbl;
        private System.Windows.Forms.Label acctpayablelbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label acctlistlbl;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button newarbtn;
        private System.Windows.Forms.Button newapbtn;
        private System.Windows.Forms.Label balass;
        private System.Windows.Forms.Label balanceassetlbl;
        private System.Windows.Forms.Button expensesAndIncomebtn;
        private System.Windows.Forms.MainMenu file;
    }
}

