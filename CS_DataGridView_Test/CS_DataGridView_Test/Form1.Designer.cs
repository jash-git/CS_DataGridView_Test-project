namespace CS_DataGridView_Test
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Img = new System.Windows.Forms.DataGridViewImageColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Img,
            this.Name});
            this.dataGridView1.Location = new System.Drawing.Point(67, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(604, 272);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Img
            // 
            this.Img.HeaderText = "Img";
            this.Img.MinimumWidth = 6;
            this.Img.Name = "Img";
            this.Img.Width = 125;
            // 
            // Name
            // 
            this.Name.HeaderText = "name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Name.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "Insert(select)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(485, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "Insert(index 1)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(67, 382);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 51);
            this.button4.TabIndex = 4;
            this.button4.Text = "Del Last";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(275, 382);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(186, 51);
            this.button5.TabIndex = 5;
            this.button5.Text = "Del (select)";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(485, 382);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(186, 51);
            this.button6.TabIndex = 6;
            this.button6.Text = "Del(index 1)";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "01.png");
            this.imageList1.Images.SetKeyName(1, "02.png");
            this.imageList1.Images.SetKeyName(2, "03.png");
            this.imageList1.Images.SetKeyName(3, "04.png");
            this.imageList1.Images.SetKeyName(4, "05.png");
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(67, 452);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(186, 51);
            this.button7.TabIndex = 7;
            this.button7.Text = "Change Img(select)";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 515);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);

            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewImageColumn Img;
        private DataGridViewTextBoxColumn Name;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private ImageList imageList1;
        private Button button7;
    }
}