namespace CS_DataGridView_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void dataGridView1Clean()
        {
            try
            {
                //--
                //dataGridView1.ReadOnly = true;//唯讀 不可更改
                dataGridView1.RowHeadersVisible = false;//DataGridView 最前面指示選取列所在位置的箭頭欄位
                dataGridView1.Rows[0].Selected = false;//取消DataGridView的默認選取(選中)Cell 使其不反藍
                dataGridView1.AllowUserToAddRows = false;//是否允許使用者新增資料
                dataGridView1.AllowUserToDeleteRows = false;//是否允許使用者刪除資料
                dataGridView1.AllowUserToOrderColumns = false;//是否允許使用者調整欄位位置
                dataGridView1.AllowUserToResizeRows = false;//是否允許使用者改變行高
                dataGridView1.AllowUserToResizeColumns = false;//是否允許使用者改變欄寬
                dataGridView1.MultiSelect = false;//不允許多選;只能單選

                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;//單一欄位禁止編輯
                    dataGridView1.Columns[i].DefaultCellStyle.NullValue = null;//允許單一圖片放空，不顯示X圖
                }

                //設置所有行背景色
                dataGridView1.RowsDefaultCellStyle.BackColor = Color.FromArgb(227, 227, 227);

                //設置奇數行背景色（下標從零開始）
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(204, 223, 229);

                //選擇顏色指定
                dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(207, 208, 192);

                //設定文字顏色
                dataGridView1.RowsDefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);
                dataGridView1.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0);


                //將行高調整到適合螢幕上當前顯示的行中所有單元格（包括標頭單元格）的內容。
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

                //允許換行屬性設定，透過換行符號換行
                dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                dataGridView1.AllowUserToAddRows = false;//刪除空白列
                dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;//整列選取

                do
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        DataGridViewRow r1 = this.dataGridView1.Rows[i];//取得DataGridView整列資料
                        this.dataGridView1.Rows.Remove(r1);//DataGridView刪除整列
                    }
                } while (dataGridView1.Rows.Count > 0);

            }
            catch
            {
            }
        }

        public int m_intCount;
        private void Form1_Load(object sender, EventArgs e)
        {
            m_intCount = 0;
            dataGridView1Clean();
        }

        private void button1_Click(object sender, EventArgs e)//Add
        {
            dataGridView1.Rows.Add(imageList1.Images[m_intCount%5], "DATA:"+ m_intCount);
            m_intCount++;
          
            dataGridView1.Rows[(dataGridView1.Rows.Count-1)].Selected = true;//設定選擇游標都在最後一筆 / 指定哪一列被選取
        }

        private void button2_Click(object sender, EventArgs e)//Insert(select)
        {
            int index = dataGridView1.SelectedRows[0].Index;//取得被選取的第一列旗標位置
            dataGridView1.Rows.Insert(index, imageList1.Images[m_intCount % 5], "DATA:" + m_intCount);
            m_intCount++;
        }

        private void button3_Click(object sender, EventArgs e)//Insert(index 1) - 新增變成第二筆 [因為C#從0開始]
        {
            dataGridView1.Rows.Insert(1, imageList1.Images[m_intCount % 5], "DATA:" + m_intCount);
            m_intCount++;
        }

        private void button4_Click(object sender, EventArgs e)//Del Last
        {
            dataGridView1.Rows[(dataGridView1.Rows.Count - 1)].Selected = true;//設定選擇游標都在最後一筆 / 指定哪一列被選取
            int index = dataGridView1.SelectedRows[0].Index;//取得被選取的第一列旗標位置
            dataGridView1.Rows.RemoveAt(index);
        }

        private void button5_Click(object sender, EventArgs e)//Del (select)
        {
            int index = dataGridView1.SelectedRows[0].Index;//取得被選取的第一列旗標位置
            dataGridView1.Rows.RemoveAt(index);
        }

        private void button6_Click(object sender, EventArgs e)//Del(index 1)
        {
            dataGridView1.Rows.RemoveAt(1);
        }
    }
}