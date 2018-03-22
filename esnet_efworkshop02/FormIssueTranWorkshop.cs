using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esnet_efworkshop02
{
    public partial class FormIssueTranWorkshop : Form
    {
        DafestyNewEntities ctx = new DafestyNewEntities();
        List<IssueTran> q;
        IssueTran tran;
        int currentrow;

        public FormIssueTranWorkshop()
        {
            InitializeComponent();
            q = _LoadData();
            UpdateTextboxValues(q.First());
            _ScrollToDataGridViewIndex(0);
            Customer_AutoComplete();


        }


        private void btn_first_Click(object sender, EventArgs e)
        {
            q = ctx.IssueTran.ToList();
            UpdateTextboxValues(q.First());
            _ScrollToDataGridViewIndex(0);
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            q = ctx.IssueTran.ToList();
            UpdateTextboxValues(q.Last());
            _ScrollToDataGridViewIndex(q.Count-1);

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            q = ctx.IssueTran.ToList();
            currentrow = _SelectTranscationRowsIndex(q) + 1;
            if (currentrow <= (q.Count - 1))
            {
                UpdateTextboxValues(q[currentrow]);
                _ScrollToDataGridViewIndex(currentrow);
            }
            else
            {
                _MsgStatus("This is the last entry. Unable to retrieve next record.");
            }
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            q = ctx.IssueTran.ToList();
            currentrow = _SelectTranscationRowsIndex(q) - 1;
            if (currentrow >= 0)
            {
                UpdateTextboxValues(q[currentrow]);
                _ScrollToDataGridViewIndex(currentrow);
            }
            else
            {
                _MsgStatus("This is the last entry. Unable to retrieve next record.");
            }
        }
        private List<IssueTran> _LoadData()
        {
            var data = from a in ctx.IssueTran
                       join b in ctx.Customers on a.CustomerID equals b.CustomerID
                       join c in ctx.Movies on a.VideoCode equals c.VideoCode
                       select new
                       {
                           Transaction_ID = a.TransactionID,
                           Customer_ID = a.CustomerID,
                           CustomerName = b.CustomerName,
                           Video_Code = a.VideoCode,
                           MovieTitle = c.MovieTitle,
                           Rental_Status = a.RentalStatus,
                           Issue_Date = a.DateIssue,
                           Due_Date = a.DateDue,
                           Return_Date = a.DateActualReturn,
                           Avaliable = c.TotalStock - c.NumberRented,
                           Rented = c.NumberRented,
                           Total_Stock = c.TotalStock,
                           Remark = a.Remarks
                       };

            dgv_trans.DataSource = data.ToList();
            return ctx.IssueTran.ToList(); 
        }

        private void _ScrollToDataGridViewIndex(int index)
        {
            dgv_trans.ClearSelection();
            dgv_trans.Rows[index].Selected = true;
            dgv_trans.FirstDisplayedScrollingRowIndex = dgv_trans.SelectedRows[0].Index;
        }

        private int _SelectTranscationRowsIndex(List<IssueTran> index)
        {
           return index.FindIndex(x => x.TransactionID == Convert.ToInt16(txt_tran_id.Text));
        }

        private IssueTran _FindTransaction(List<IssueTran> q)
        {
            
            return q.Find(x => x.TransactionID == Convert.ToInt16(txt_tran_id.Text));
        }

        private void UpdateTextboxValues(IssueTran it)
        {
            var m = ctx.Movies.Where(x => x.VideoCode == it.VideoCode).First();
            
            //Trans Info
            txt_tran_id.Text = it.TransactionID.ToString();
            txt_cust_id.Text = it.CustomerID;
            txt_video_code.Text = it.VideoCode.ToString();

            if (!string.IsNullOrEmpty(it.DateDue.ToString()))
            {
                dtp_due.Value = Convert.ToDateTime(it.DateDue);
            }           
            if(!string.IsNullOrEmpty(it.DateIssue.ToString()))
            {
                dtp_issue.Value = Convert.ToDateTime(it.DateIssue);
            }
            if(!string.IsNullOrEmpty(it.DateActualReturn.ToString()))
            {
                dtp_return.Value = Convert.ToDateTime(it.DateActualReturn);
            }
            txt_remarks.Text = it.Remarks;
            if (it.RentalStatus == "in")
            {
                rbtn_In.Select();
            }
            else { rbtn_Out.Select(); }
            //Movie Info
            txt_avaliable.Text = (m.TotalStock - m.NumberRented).ToString();
            txt_total.Text = m.TotalStock.ToString();
            txt_rent.Text = m.NumberRented.ToString();
            txt_m_title.Text = m.MovieTitle;
            txt_m_type.Text = m.MovieType;
            txt_rating.Text = m.Rating;
            txt_r_price.Text = m.RentalPrice.ToString();


            
            

        }

        private void dgv_trans_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //tran = dgv_trans.CurrentRow.Cells["Transaction_ID"].Value;
            //UpdateTextboxValues(tran);
            //q = _LoadData();
            //currentindex = _SelectTranscationRowsIndex(q);
            //_ScrollToDataGridViewIndex(currentindex);

         

        }

        
        private void _MsgStatus(string m)
        {
            slbl_Main.Text = m;
        }

        private void txt_cust_name_TabIndexChanged(object sender, EventArgs e)
        {
           
        }

        //private void txt_cust_name_TextChanged(object sender, EventArgs e)
        //{
        //    var source = new AutoCompleteStringCollection();

        //    var name = from a in ctx.Customers
        //               where a.CustomerName.StartsWith(txt_cust_name.Text)
        //               select a.CustomerName;
        //    source.AddRange(name.ToArray());


        //    txt_cust_name.AutoCompleteMode = AutoCompleteMode.Suggest;
        //    txt_cust_name.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //    txt_cust_name.AutoCompleteCustomSource = source;


        //}

        private void Customer_AutoComplete()
        {
            var source = new AutoCompleteStringCollection();

            var name = from a in ctx.Customers
                       where a.CustomerName.StartsWith(txt_cust_name.Text)
                       select a.CustomerName;
            source.AddRange(name.ToArray());


            txt_cust_name.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_cust_name.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_cust_name.AutoCompleteCustomSource = source;
        }

        //private void txt_cust_name_TextChanged(object sender, EventArgs e)
        //{
        //    var cust_id = ctx.Customers.Where(x => x.CustomerName == txt_cust_name.Text).Select(x => new { x.CustomerID }).ToString();
        //    txt_cust_id.Text = cust_id;
                        
        //}

        //private void txt_cust_name_TabIndexChanged_1(object sender, EventArgs e)
        //{
        //    var cust_id = ctx.Customers.Where(x => x.CustomerName == txt_cust_name.Text).Select(x => new { x.CustomerID }).ToString();
        //    txt_cust_id.Text = cust_id;
        //}
    }
}
