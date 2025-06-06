namespace Library_Management_System___GUI
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
            label1 = new Label();
            statusStrip1 = new StatusStrip();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            btnDVDSearch = new Button();
            btnDVDDel = new Button();
            btnDVDUpdate = new Button();
            btnDVDAdd = new Button();
            dataGridView2 = new DataGridView();
            tabPage3 = new TabPage();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            dataGridView3 = new DataGridView();
            tabPage4 = new TabPage();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            dataGridView4 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(182, 9);
            label1.Name = "label1";
            label1.Size = new Size(549, 53);
            label1.TabIndex = 0;
            label1.Text = "Library Management System";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(0, 426);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(981, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(55, 81);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(859, 332);
            tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnDVDSearch);
            tabPage2.Controls.Add(btnDVDDel);
            tabPage2.Controls.Add(btnDVDUpdate);
            tabPage2.Controls.Add(btnDVDAdd);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(851, 299);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "DVD";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // btnDVDSearch
            // 
            btnDVDSearch.Location = new Point(30, 222);
            btnDVDSearch.Name = "btnDVDSearch";
            btnDVDSearch.Size = new Size(94, 29);
            btnDVDSearch.TabIndex = 5;
            btnDVDSearch.Text = "Search";
            btnDVDSearch.UseVisualStyleBackColor = true;
            btnDVDSearch.Click += btnDVDSearch_Click;
            // 
            // btnDVDDel
            // 
            btnDVDDel.Location = new Point(30, 157);
            btnDVDDel.Name = "btnDVDDel";
            btnDVDDel.Size = new Size(94, 29);
            btnDVDDel.TabIndex = 4;
            btnDVDDel.Text = "Delete";
            btnDVDDel.UseVisualStyleBackColor = true;
            btnDVDDel.Click += btnDVDDel_Click;
            // 
            // btnDVDUpdate
            // 
            btnDVDUpdate.Location = new Point(30, 98);
            btnDVDUpdate.Name = "btnDVDUpdate";
            btnDVDUpdate.Size = new Size(94, 29);
            btnDVDUpdate.TabIndex = 3;
            btnDVDUpdate.Text = "Update";
            btnDVDUpdate.UseVisualStyleBackColor = true;
            btnDVDUpdate.Click += btnDVDUpdate_Click;
            // 
            // btnDVDAdd
            // 
            btnDVDAdd.Location = new Point(30, 37);
            btnDVDAdd.Name = "btnDVDAdd";
            btnDVDAdd.Size = new Size(94, 29);
            btnDVDAdd.TabIndex = 2;
            btnDVDAdd.Text = "Add";
            btnDVDAdd.UseVisualStyleBackColor = true;
            btnDVDAdd.Click += button1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(168, 37);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(655, 214);
            dataGridView2.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button5);
            tabPage3.Controls.Add(button6);
            tabPage3.Controls.Add(button7);
            tabPage3.Controls.Add(button8);
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(851, 299);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Magazine";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(32, 218);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 9;
            button5.Text = "Search";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(32, 161);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 8;
            button6.Text = "Delete";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(32, 96);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 7;
            button7.Text = "Update";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(32, 33);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 6;
            button8.Text = "Add";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(173, 33);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(660, 214);
            dataGridView3.TabIndex = 1;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button9);
            tabPage4.Controls.Add(button10);
            tabPage4.Controls.Add(button11);
            tabPage4.Controls.Add(button12);
            tabPage4.Controls.Add(dataGridView4);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(851, 299);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Book";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(31, 222);
            button9.Name = "button9";
            button9.Size = new Size(94, 29);
            button9.TabIndex = 9;
            button9.Text = "Search";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(31, 162);
            button10.Name = "button10";
            button10.Size = new Size(94, 29);
            button10.TabIndex = 8;
            button10.Text = "Delete";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(31, 95);
            button11.Name = "button11";
            button11.Size = new Size(94, 29);
            button11.TabIndex = 7;
            button11.Text = "Update";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Location = new Point(31, 37);
            button12.Name = "button12";
            button12.Size = new Size(94, 29);
            button12.TabIndex = 6;
            button12.Text = "Add";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(179, 37);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.Size = new Size(649, 214);
            dataGridView4.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 448);
            Controls.Add(tabControl1);
            Controls.Add(statusStrip1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Library Management";
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private StatusStrip statusStrip1;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private DataGridView dataGridView2;
        private Button btnDVDAdd;
        private DataGridView dataGridView3;
        private DataGridView dataGridView4;
        private Button btnDVDUpdate;
        private Button btnDVDDel;
        private Button btnDVDSearch;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private void tabPage3_Click(object sender, EventArgs e) { }
    }
}
