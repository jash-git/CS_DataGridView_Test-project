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
                //dataGridView1.ReadOnly = true;//��Ū ���i���
                dataGridView1.RowHeadersVisible = false;//DataGridView �̫e�����ܿ���C�Ҧb��m���b�Y���
                dataGridView1.Rows[0].Selected = false;//����DataGridView���q�{���(�襤)Cell �Ϩ䤣����
                dataGridView1.AllowUserToAddRows = false;//�O�_���\�ϥΪ̷s�W���
                dataGridView1.AllowUserToDeleteRows = false;//�O�_���\�ϥΪ̧R�����
                dataGridView1.AllowUserToOrderColumns = false;//�O�_���\�ϥΪ̽վ�����m
                dataGridView1.AllowUserToResizeRows = false;//�O�_���\�ϥΪ̧��ܦ氪
                dataGridView1.AllowUserToResizeColumns = false;//�O�_���\�ϥΪ̧�����e
                dataGridView1.MultiSelect = false;//�����\�h��;�u����

                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;//��@���T��s��
                    dataGridView1.Columns[i].DefaultCellStyle.NullValue = null;//���\��@�Ϥ���šA�����X��
                }

                //�]�m�Ҧ���I����
                dataGridView1.RowsDefaultCellStyle.BackColor = Color.FromArgb(227, 227, 227);

                //�]�m�_�Ʀ�I����]�U�бq�s�}�l�^
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(204, 223, 229);

                //����C����w
                dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(207, 208, 192);

                //�]�w��r�C��
                dataGridView1.RowsDefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);
                dataGridView1.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0);


                //�N�氪�վ��A�X�ù��W��e��ܪ��椤�Ҧ��椸��]�]�A���Y�椸��^�����e�C
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

                //���\�����ݩʳ]�w�A�z�L����Ÿ�����
                dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                dataGridView1.AllowUserToAddRows = false;//�R���ťզC
                dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;//��C���

                do
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        DataGridViewRow r1 = this.dataGridView1.Rows[i];//���oDataGridView��C���
                        this.dataGridView1.Rows.Remove(r1);//DataGridView�R����C
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
          
            dataGridView1.Rows[(dataGridView1.Rows.Count-1)].Selected = true;//�]�w��ܴ�г��b�̫�@�� / ���w���@�C�Q���
        }

        private void button2_Click(object sender, EventArgs e)//Insert(select)
        {
            int index = dataGridView1.SelectedRows[0].Index;//���o�Q������Ĥ@�C�X�Ц�m
            dataGridView1.Rows.Insert(index, imageList1.Images[m_intCount % 5], "DATA:" + m_intCount);
            m_intCount++;
        }

        private void button3_Click(object sender, EventArgs e)//Insert(index 1) - �s�W�ܦ��ĤG�� [�]��C#�q0�}�l]
        {
            dataGridView1.Rows.Insert(1, imageList1.Images[m_intCount % 5], "DATA:" + m_intCount);
            m_intCount++;
        }

        private void button4_Click(object sender, EventArgs e)//Del Last
        {
            dataGridView1.Rows[(dataGridView1.Rows.Count - 1)].Selected = true;//�]�w��ܴ�г��b�̫�@�� / ���w���@�C�Q���
            int index = dataGridView1.SelectedRows[0].Index;//���o�Q������Ĥ@�C�X�Ц�m
            dataGridView1.Rows.RemoveAt(index);
        }

        private void button5_Click(object sender, EventArgs e)//Del (select)
        {
            int index = dataGridView1.SelectedRows[0].Index;//���o�Q������Ĥ@�C�X�Ц�m
            dataGridView1.Rows.RemoveAt(index);
        }

        private void button6_Click(object sender, EventArgs e)//Del(index 1)
        {
            dataGridView1.Rows.RemoveAt(1);
        }
    }
}