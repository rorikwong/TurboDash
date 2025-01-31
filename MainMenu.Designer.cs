namespace turbo_dash
{
    partial class MainMenu
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
            partname = new Label();
            partnumber = new Label();
            partstatus = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            partcost = new Label();
            textBox4 = new TextBox();
            addpart = new Button();
            updatepart = new Button();
            deletebutton = new Button();
            clearbutton = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // partname
            // 
            partname.AutoSize = true;
            partname.BackColor = SystemColors.AppWorkspace;
            partname.Location = new Point(31, 94);
            partname.Name = "partname";
            partname.Size = new Size(130, 32);
            partname.TabIndex = 0;
            partname.Text = "Part Name:";
            partname.Click += label1_Click;
            // 
            // partnumber
            // 
            partnumber.AutoSize = true;
            partnumber.BackColor = SystemColors.AppWorkspace;
            partnumber.Location = new Point(31, 170);
            partnumber.Name = "partnumber";
            partnumber.Size = new Size(154, 32);
            partnumber.TabIndex = 1;
            partnumber.Text = "Part Number:";
            partnumber.Click += label1_Click_1;
            // 
            // partstatus
            // 
            partstatus.AutoSize = true;
            partstatus.BackColor = SystemColors.AppWorkspace;
            partstatus.Location = new Point(31, 339);
            partstatus.Name = "partstatus";
            partstatus.Size = new Size(125, 32);
            partstatus.TabIndex = 2;
            partstatus.Text = "Part Status";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(242, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(630, 39);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(242, 170);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(630, 39);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(242, 258);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(630, 39);
            textBox3.TabIndex = 5;
            // 
            // partcost
            // 
            partcost.AutoSize = true;
            partcost.BackColor = SystemColors.AppWorkspace;
            partcost.Location = new Point(31, 265);
            partcost.Name = "partcost";
            partcost.Size = new Size(113, 32);
            partcost.TabIndex = 6;
            partcost.Text = "Part Cost:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(242, 339);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(630, 39);
            textBox4.TabIndex = 7;
            // 
            // addpart
            // 
            addpart.Location = new Point(31, 496);
            addpart.Name = "addpart";
            addpart.Size = new Size(140, 76);
            addpart.TabIndex = 8;
            addpart.Text = "Add Part";
            addpart.UseVisualStyleBackColor = true;
            // 
            // updatepart
            // 
            updatepart.Location = new Point(219, 496);
            updatepart.Name = "updatepart";
            updatepart.Size = new Size(140, 76);
            updatepart.TabIndex = 9;
            updatepart.Text = "Update Table";
            updatepart.UseVisualStyleBackColor = true;
            // 
            // deletebutton
            // 
            deletebutton.Location = new Point(411, 496);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(140, 76);
            deletebutton.TabIndex = 10;
            deletebutton.Text = "Delete";
            deletebutton.UseVisualStyleBackColor = true;
            // 
            // clearbutton
            // 
            clearbutton.Location = new Point(606, 496);
            clearbutton.Name = "clearbutton";
            clearbutton.Size = new Size(140, 76);
            clearbutton.TabIndex = 11;
            clearbutton.Text = "Clear";
            clearbutton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.DimGray;
            dataGridView1.Location = new Point(31, 612);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(873, 311);
            dataGridView1.TabIndex = 12;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(943, 960);
            Controls.Add(dataGridView1);
            Controls.Add(clearbutton);
            Controls.Add(deletebutton);
            Controls.Add(updatepart);
            Controls.Add(addpart);
            Controls.Add(textBox4);
            Controls.Add(partcost);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(partstatus);
            Controls.Add(partnumber);
            Controls.Add(partname);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 6, 6, 6);
            Name = "MainMenu";
            Text = "TurboDash";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label partname;
        private Label partnumber;
        private Label partstatus;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label partcost;
        private TextBox textBox4;
        private Button addpart;
        private Button updatepart;
        private Button deletebutton;
        private Button clearbutton;
        private DataGridView dataGridView1;
    }
}
