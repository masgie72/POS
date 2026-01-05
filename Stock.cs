using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Stock : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SYAMSIATUN\OneDrive - Universitas Terbuka\Documents\wajik.mdf;Integrated Security=True;Connect Timeout=30");

        public Stock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
        {

        }

        private void StockOpen()
        {
            conn.Open();
            SqlCommand CountItem = new SqlCommand("select Count(ItemCode) from Stock", conn);
            string ItemCount = CountItem.ExecuteScalar().ToString();

            SqlCommand SumStockValue = new SqlCommand("select Sum(Prch_Value) from Stock", conn);
            string StockValue = SumStockValue.ExecuteScalar().ToString();
            conn.Close();

            lbItemCount.Text = ItemCount;
            lbValue.Text = "Rp."+StockValue.Trim();
            if (!string.IsNullOrEmpty(StockValue))
            {
                lbValue.Text = Convert.ToDouble(StockValue).ToString("C0", CultureInfo.CreateSpecificCulture("id-ID"));
            }
            else
            {
                lbValue.Text = "0";
            }

        }

        private void btSummary_Click(object sender, EventArgs e)
        {
            Puchasing_Summary puchasing_Summary = new Puchasing_Summary();
            puchasing_Summary.Show();
        }

        private void removeItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvStokView.DataSource == null)
            {
                MessageBox.Show("No item to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string RowIndex = dgvStokView.CurrentCell.RowIndex.ToString();

                int Row_Index = Convert.ToInt32(RowIndex);
                if (Row_Index >= 0)
                {
                    DialogResult confirmation = MessageBox.Show("Are you sure want to remove this item?", "Item Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmation == DialogResult.Yes)
                    {
                        DataGridViewRow row = this.dgvStokView.Rows[Row_Index];

                        string Delete_Item_Code = row.Cells["ItemCode"].Value.ToString();

                        conn.Open();
                        SqlCommand RemoveItem = new SqlCommand("DELETE FROM Stock WHERE ItemCode='" + Delete_Item_Code + "'", conn);
                        RemoveItem.ExecuteNonQuery();

                        SqlCommand AllItems = new SqlCommand("select * from [Stock]", conn);
                        AllItems.ExecuteNonQuery();
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(AllItems);
                        DataTable StockTable = new DataTable();
                        sqlDataAdapter.Fill(StockTable);
                        dgvStokView.DataSource = StockTable;
                        this.dgvStokView.Sort(this.dgvStokView.Columns["ItemCode"], ListSortDirection.Ascending);
                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please select an item to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }


        }

        private void fillScreenViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_View stock_View = new Stock_View();
            stock_View.Show();
        }

        private void lowStockValueReminderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Low_Stock_Value_Reminder low_Stock_Value_Reminder = new Low_Stock_Value_Reminder();
            low_Stock_Value_Reminder.Show();
        }

        private void txQuantity_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txQuantity.Text))
            {
                txQuantity.Text = "";
                txPrice.Text = "";
            }
            else
            {
                float PurchasingPrice;
                if (float.TryParse(txQuantity.Text, out PurchasingPrice))
                {

                }
                else
                {
                    txQuantity.Text = "";
                    txPrice.Text = "";
                }
            }
        }


        private void txPrice_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txPrice.Text))
            {
                txPrice.Text = "";
            }
            else
            {
                float PurchasingPrice;
                if (float.TryParse(txPrice.Text, out PurchasingPrice))
                {
                    double Purchasing_Value = Convert.ToDouble(txQuantity.Text) * Convert.ToDouble(txPrice.Text);
                    txValue.Text = Convert.ToString(Purchasing_Value);
                }
                else
                {
                    txPrice.Text = "";
                    txValue.Text = "";
                }
            }
        }

        private void txSellPrice_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txSellPrice.Text))
            {
                txSellPrice.Text = "";
            }
            else
            {
                float PurchasingPrice;
                if (float.TryParse(txSellPrice.Text, out PurchasingPrice))
                {
                    double Purchasing_Value = Convert.ToDouble(txQuantity.Text) * Convert.ToDouble(txPrice.Text);

                    txValue.Text = Convert.ToString(Purchasing_Value);
                }
                else
                {
                    txSellPrice.Text = "";
                    txValue.Text = "";
                }
            }
        }

        private void txValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txItemCode.Text))
            {
                MessageBox.Show("Item Code can't be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txItemCode.Focus();
                this.ActiveControl = txItemCode;
            }
            else
            {
                if (string.IsNullOrEmpty(txDecs.Text))
                {
                    MessageBox.Show("Description can't be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txDecs.Focus();
                    this.ActiveControl = txDecs;
                }
                else
                {
                    if (string.IsNullOrEmpty(txQuantity.Text))
                    {
                        MessageBox.Show("Quantity can't be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txQuantity.Focus();
                        this.ActiveControl = txQuantity;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txPrice.Text))
                        {
                            MessageBox.Show("Price can't be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txPrice.Focus();
                            this.ActiveControl = txPrice;
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(txValue.Text))
                            {
                                MessageBox.Show("Value can't be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txValue.Focus();
                                this.ActiveControl = txValue;
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(txSellPrice.Text))
                                {
                                    MessageBox.Show("Value can't be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    txSellPrice.Focus();
                                    this.ActiveControl = txSellPrice;
                                }

                                else
                                {
                                    if (string.IsNullOrEmpty(cbSupp.Text))
                                    {
                                        MessageBox.Show("Value can't be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        cbSupp.Focus();
                                        this.ActiveControl = cbSupp;
                                    }
                                    else
                                    {
                                        conn.Open();
                                        SqlCommand StockUpdate = new SqlCommand("INSERT INTO Stock([ItemCode], [Description], [Prch_Qty], [Prch_Price], [Prch_Value], [MRP], [Supplier]) VALUES ('" + txItemCode.Text + "','" + txDecs.Text + "','" + Convert.ToDouble(txQuantity.Text) + "','" + Convert.ToDouble(txPrice.Text) + "','" + Convert.ToDouble(txValue.Text) + "','" + Convert.ToDouble(txSellPrice.Text) + "','" + cbSupp.Text + "')", conn);
                                        StockUpdate.ExecuteNonQuery();

                                        SqlCommand ViewAllItems = new SqlCommand("select * from [Stock]", conn);
                                        ViewAllItems.ExecuteNonQuery();
                                        SqlDataAdapter itemAdapter = new SqlDataAdapter(ViewAllItems);
                                        DataTable StockTable = new DataTable();
                                        itemAdapter.Fill(StockTable);
                                        dgvStokView.DataSource = StockTable;

                                        conn.Close();

                                        StockOpen();

                                        txItemCode.Text = "";
                                        txDecs.Text = "";
                                        txQuantity.Text = "";
                                        txPrice.Text = "";
                                        txSellPrice.Text = "";
                                        txValue.Text = "";
                                        txSellPrice.Text = "";
                                        cbSupp.Text = "";
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }



        private void btViewAll_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand ViewAllItems = new SqlCommand("select * from [Stock]", conn);
            ViewAllItems.ExecuteNonQuery();
            SqlDataAdapter ItemAdapter = new SqlDataAdapter(ViewAllItems);

            DataTable StockTable = new DataTable();
            ItemAdapter.Fill(StockTable);
            dgvStokView.DataSource = StockTable;
            conn.Close();

            StockOpen();
        }

    

        private void viewLowStockItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txItemCode.Text = "";
            txDecs.Text = "";
            txQuantity.Text = "";
            txPrice.Text = "";
            txSellPrice.Text = "";
            txValue.Text = "";
            txSellPrice.Text = "";
            cbSupp.Text = "";
        }
    }
}


