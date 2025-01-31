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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            partname = new Label();
            partnumber = new Label();
            partstatus = new Label();
            partnametext = new TextBox();
            partnumbertext = new TextBox();
            partcosttext = new TextBox();
            partcost = new Label();
            addpart = new Button();
            updatepart = new Button();
            deletebutton = new Button();
            clearbutton = new Button();
            partsviewer = new DataGridView();
            partstatusid = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)partsviewer).BeginInit();
            SuspendLayout();
            // 
            // partname
            // 
            partname.AutoSize = true;
            partname.BackColor = SystemColors.AppWorkspace;
            partname.Location = new Point(58, 89);
            partname.Margin = new Padding(6, 0, 6, 0);
            partname.Name = "partname";
            partname.Size = new Size(130, 32);
            partname.TabIndex = 0;
            partname.Text = "Part Name:";
            // 
            // partnumber
            // 
            partnumber.AutoSize = true;
            partnumber.BackColor = SystemColors.AppWorkspace;
            partnumber.Location = new Point(58, 242);
            partnumber.Margin = new Padding(6, 0, 6, 0);
            partnumber.Name = "partnumber";
            partnumber.Size = new Size(154, 32);
            partnumber.TabIndex = 1;
            partnumber.Text = "Part Number:";
            // 
            // partstatus
            // 
            partstatus.AutoSize = true;
            partstatus.BackColor = SystemColors.AppWorkspace;
            partstatus.Location = new Point(58, 550);
            partstatus.Margin = new Padding(6, 0, 6, 0);
            partstatus.Name = "partstatus";
            partstatus.Size = new Size(125, 32);
            partstatus.TabIndex = 2;
            partstatus.Text = "Part Status";
            // 
            // partnametext
            // 
            partnametext.Location = new Point(289, 89);
            partnametext.Margin = new Padding(6);
            partnametext.Name = "partnametext";
            partnametext.Size = new Size(1167, 39);
            partnametext.TabIndex = 3;
            partnametext.TextChanged += partnametext_TextChanged;
            // 
            // partnumbertext
            // 
            partnumbertext.Location = new Point(289, 242);
            partnumbertext.Margin = new Padding(6);
            partnumbertext.Name = "partnumbertext";
            partnumbertext.Size = new Size(1167, 39);
            partnumbertext.TabIndex = 4;
            partnumbertext.TextChanged += partnumbertext_TextChanged;
            // 
            // partcosttext
            // 
            partcosttext.Location = new Point(289, 370);
            partcosttext.Margin = new Padding(6);
            partcosttext.Name = "partcosttext";
            partcosttext.Size = new Size(1167, 39);
            partcosttext.TabIndex = 5;
            partcosttext.TextChanged += partcosttext_TextChanged;
            // 
            // partcost
            // 
            partcost.AutoSize = true;
            partcost.BackColor = SystemColors.AppWorkspace;
            partcost.Location = new Point(58, 370);
            partcost.Margin = new Padding(6, 0, 6, 0);
            partcost.Name = "partcost";
            partcost.Size = new Size(113, 32);
            partcost.TabIndex = 6;
            partcost.Text = "Part Cost:";
            // 
            // addpart
            // 
            addpart.Location = new Point(31, 669);
            addpart.Margin = new Padding(6);
            addpart.Name = "addpart";
            addpart.Size = new Size(260, 162);
            addpart.TabIndex = 8;
            addpart.Text = "Add Part";
            addpart.UseVisualStyleBackColor = true;
            addpart.Click += addpart_Click;
            // 
            // updatepart
            // 
            updatepart.Location = new Point(346, 669);
            updatepart.Margin = new Padding(6);
            updatepart.Name = "updatepart";
            updatepart.Size = new Size(260, 162);
            updatepart.TabIndex = 9;
            updatepart.Text = "Update Table";
            updatepart.UseVisualStyleBackColor = true;
            updatepart.Click += updatepart_Click;
            // 
            // deletebutton
            // 
            deletebutton.Location = new Point(660, 669);
            deletebutton.Margin = new Padding(6);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(260, 162);
            deletebutton.TabIndex = 10;
            deletebutton.Text = "Delete";
            deletebutton.UseVisualStyleBackColor = true;
            deletebutton.Click += deletebutton_Click;
            // 
            // clearbutton
            // 
            clearbutton.Location = new Point(985, 669);
            clearbutton.Margin = new Padding(6);
            clearbutton.Name = "clearbutton";
            clearbutton.Size = new Size(260, 162);
            clearbutton.TabIndex = 11;
            clearbutton.Text = "Clear";
            clearbutton.UseVisualStyleBackColor = true;
            clearbutton.Click += clearbutton_Click;
            // 
            // partsviewer
            // 
            partsviewer.AllowUserToOrderColumns = true;
            partsviewer.BackgroundColor = SystemColors.ControlDarkDark;
            partsviewer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            partsviewer.GridColor = Color.DimGray;
            partsviewer.Location = new Point(31, 875);
            partsviewer.Margin = new Padding(6);
            partsviewer.Name = "partsviewer";
            partsviewer.Size = new Size(1621, 456);
            partsviewer.TabIndex = 12;
            partsviewer.CellContentClick += partsviewer_CellContentClick;
            // 
            // partstatusid
            // 
            partstatusid.FormattingEnabled = true;
            partstatusid.Location = new Point(289, 542);
            partstatusid.Name = "partstatusid";
            partstatusid.Size = new Size(1175, 40);
            partstatusid.TabIndex = 13;
            partstatusid.SelectedIndexChanged += partstatusid_SelectedIndexChanged;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1797, 1421);
            Controls.Add(partstatusid);
            Controls.Add(partsviewer);
            Controls.Add(clearbutton);
            Controls.Add(deletebutton);
            Controls.Add(updatepart);
            Controls.Add(addpart);
            Controls.Add(partcost);
            Controls.Add(partcosttext);
            Controls.Add(partnumbertext);
            Controls.Add(partnametext);
            Controls.Add(partstatus);
            Controls.Add(partnumber);
            Controls.Add(partname);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "MainMenu";
            Text = "TurboDash";
            ((System.ComponentModel.ISupportInitialize)partsviewer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private void partnametext_TextChanged(object sender, EventArgs e)
        {
            // Handle text changed event
        }

        private void partnumbertext_TextChanged(object sender, EventArgs e)
        {
            // Handle text changed event
        }

        private void partcosttext_TextChanged(object sender, EventArgs e)
        {
            // Handle text changed event
        }

        private void updatepart_Click(object sender, EventArgs e)
        {
            // Handle update part button click event
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            // Handle delete button click event
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            // Handle clear button click event
        }

        private void partsviewer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle parts viewer cell content click event
        }

        private void partstatusid_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle part status id selected index changed event
        }

        #endregion

        private Label partname;
        private Label partnumber;
        private Label partstatus;
        private System.Windows.Forms.TextBox partnametext;
        private TextBox partnumbertext;
        private TextBox partcosttext;
        private Label partcost;
        private Button addpart;
        private Button updatepart;
        private Button deletebutton;
        private Button clearbutton;
        private DataGridView partsviewer;
        private ComboBox partstatusid;
    }
}
