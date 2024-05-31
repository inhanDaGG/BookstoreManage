using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;

namespace BookstoreManage
{
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
            populate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        // 初始化SQL連接
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tp990\DuKangBookShopDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from BookTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Filter()
        {
            if (CatCbSearchCb.SelectedItem == null)
            {
                MessageBox.Show("請選擇一個分類進行篩選！");
                return;
            }

            string category = CatCbSearchCb.SelectedItem.ToString();

            string query = "SELECT * FROM BookTbl WHERE BCat = @BCat";
            using (SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tp990\DuKangBookShopDb.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                try
                {
                    Con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        cmd.Parameters.AddWithValue("@BCat", category);
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                            var ds = new DataSet();
                            sda.Fill(ds);
                            BookDGV.DataSource = ds.Tables[0];
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("錯誤: " + ex.Message);
                }
                finally
                {
                    Con.Close();
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (BTitleTb.Text == "" || BAutTb.Text == "" || QtyTb.Text == "" || PriceTb.Text == "" || BCatCb.SelectedIndex == -1)
            {
                MessageBox.Show("數據輸入錯誤!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "INSERT INTO BookTbl (BTitle, BAuthor, BCat, BQty, BPrice) VALUES (@BTitle, @BAuthor, @BCat, @BQty, @BPrice)";
                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        cmd.Parameters.AddWithValue("@BTitle", BTitleTb.Text);
                        cmd.Parameters.AddWithValue("@BAuthor", BAutTb.Text);
                        cmd.Parameters.AddWithValue("@BCat", BCatCb.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@BQty", int.Parse(QtyTb.Text));
                        cmd.Parameters.AddWithValue("@BPrice", decimal.Parse(PriceTb.Text));

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("書籍訊息保存成功!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Con.Close();
                    populate();
                    Reset();
                }
            }
        }

        private void CloseWeb_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CatCbSearchCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int key = 0;
        private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BTitleTb.Text = BookDGV.SelectedRows[0].Cells[1].Value.ToString();
            BAutTb.Text = BookDGV.SelectedRows[0].Cells[2].Value.ToString();
            BCatCb.SelectedItem = BookDGV.SelectedRows[0].Cells[3].Value.ToString();
            QtyTb.Text = BookDGV.SelectedRows[0].Cells[4].Value.ToString();
            PriceTb.Text = BookDGV.SelectedRows[0].Cells[5].Value.ToString();
            if (BTitleTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(BookDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void CatCbSearchCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Filter();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            populate();
            CatCbSearchCb.SelectedIndex = -1;
        }
        private void Reset()
        {
            BTitleTb.Text = "";
            BAutTb.Text = "";
            BCatCb.SelectedIndex = -1;
            QtyTb.Text = "";
            PriceTb.Text = "";

        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("數據缺失!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from BookTbl Where BId = " + key + "";
                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        cmd.Parameters.AddWithValue("@BTitle", BTitleTb.Text);
                        cmd.Parameters.AddWithValue("@BAuthor", BAutTb.Text);
                        cmd.Parameters.AddWithValue("@BCat", BCatCb.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@BQty", int.Parse(QtyTb.Text));
                        cmd.Parameters.AddWithValue("@BPrice", decimal.Parse(PriceTb.Text));

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("刪除成功!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Con.Close();
                    populate();
                    Reset();
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

            if (BTitleTb.Text == "" || BAutTb.Text == "" || QtyTb.Text == "" || PriceTb.Text == "" || BCatCb.SelectedIndex == -1)
            {
                MessageBox.Show("數據缺失!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update BookTbl set BTitle = '" + BTitleTb.Text + "',BAuthor = '" + BAutTb.Text + "',BCat = '" + BCatCb.SelectedItem.ToString() + "', BQty = " + QtyTb.Text + ", BPrice = " + PriceTb.Text + "where BId = " + key + " ";
                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        cmd.Parameters.AddWithValue("@BTitle", BTitleTb.Text);
                        cmd.Parameters.AddWithValue("@BAuthor", BAutTb.Text);
                        cmd.Parameters.AddWithValue("@BCat", BCatCb.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@BQty", int.Parse(QtyTb.Text));
                        cmd.Parameters.AddWithValue("@BPrice", decimal.Parse(PriceTb.Text));

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("編輯成功!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Con.Close();
                    populate();
                    Reset();
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            uers obj = new uers();
            obj.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            DashBoard obj = new DashBoard();
            obj.Show();
            this.Hide();
        }
    }
}