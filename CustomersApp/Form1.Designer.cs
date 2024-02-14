namespace CustomersApp
{
    partial class Form1
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
            ListViewGroup listViewGroup1 = new ListViewGroup("Names", HorizontalAlignment.Left);
            label1 = new Label();
            label2 = new Label();
            txtCustomer = new TextBox();
            txtAge = new TextBox();
            label3 = new Label();
            button1 = new Button();
            lstCustomers = new ListView();
            colNames = new ColumnHeader();
            label4 = new Label();
            button2 = new Button();
            label5 = new Label();
            txtBalance = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 107);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 37);
            label2.Name = "label2";
            label2.Size = new Size(338, 37);
            label2.TabIndex = 1;
            label2.Text = "Add customers to the Store";
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(19, 135);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(331, 23);
            txtCustomer.TabIndex = 2;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(19, 204);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(331, 23);
            txtAge.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(19, 176);
            label3.Name = "label3";
            label3.Size = new Size(37, 21);
            label3.TabIndex = 4;
            label3.Text = "Age";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(19, 321);
            button1.Name = "button1";
            button1.Size = new Size(331, 47);
            button1.TabIndex = 5;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lstCustomers
            // 
            lstCustomers.Columns.AddRange(new ColumnHeader[] { colNames });
            listViewGroup1.Header = "Names";
            listViewGroup1.Name = "listViewGroup1";
            lstCustomers.Groups.AddRange(new ListViewGroup[] { listViewGroup1 });
            lstCustomers.Location = new Point(480, 93);
            lstCustomers.Name = "lstCustomers";
            lstCustomers.Size = new Size(270, 203);
            lstCustomers.TabIndex = 6;
            lstCustomers.UseCompatibleStateImageBehavior = false;
            // 
            // colNames
            // 
            colNames.Text = "Nombres";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(471, 37);
            label4.Name = "label4";
            label4.Size = new Size(178, 37);
            label4.TabIndex = 7;
            label4.Text = "Customer List";
            // 
            // button2
            // 
            button2.Location = new Point(594, 302);
            button2.Name = "button2";
            button2.Size = new Size(156, 44);
            button2.TabIndex = 8;
            button2.Text = "Show";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(19, 249);
            label5.Name = "label5";
            label5.Size = new Size(63, 21);
            label5.TabIndex = 9;
            label5.Text = "Balance";
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(19, 273);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(331, 23);
            txtBalance.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBalance);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(lstCustomers);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(txtAge);
            Controls.Add(txtCustomer);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCustomer;
        private TextBox txtAge;
        private Label label3;
        private Button button1;
        private ListView lstCustomers;
        private Label label4;
        private ColumnHeader colNames;
        private Button button2;
        private Label label5;
        private TextBox txtBalance;
    }
}