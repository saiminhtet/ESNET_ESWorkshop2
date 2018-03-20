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
    public partial class FormEF_Practice2 : Form
    {
        DafestyNewEntities ctx = new DafestyNewEntities();
        List<Customers> q;
        Customers c;
        static string oldName, oldRating, newName, newRating;
        int currpos;

        public FormEF_Practice2()
        {
            InitializeComponent();
            
            q = _LoadData();
            _UpdateTBoxes(q.First());
            _ScrollTo(0);
            _MsgStatus("Welcome!");
        }

        //Goto Previous Record
        private void button1_Click_1(object sender, EventArgs e)
        {
            q = ctx.Customers.ToList();
            currpos = _FindPos(q) - 1;
            if (currpos >= 0)
            {
                _UpdateTBoxes(q[currpos]);
                _UpdStatus($"Current Customer: ");
                _ScrollTo(currpos);
            }
            else
                _MsgStatus("This is the first entry. Unable to retrieve previous record.");
        }

        //Goto Next Record
        private void button2_Click_1(object sender, EventArgs e)
        {
            q = ctx.Customers.ToList();
            currpos = _FindPos(q) + 1;
            if (currpos <= (q.Count - 1))
            {
                _UpdateTBoxes(q[currpos]);
                _UpdStatus($"Current Customer: ");
                _ScrollTo(currpos);
            }
            else
            {
                _MsgStatus("This is the last entry. Unable to retrieve next record.");
            }
        }

        //Goto First Record
        private void button3_Click_1(object sender, EventArgs e)
        {
            q = ctx.Customers.ToList();
            _UpdateTBoxes(q.First());
            _UpdStatus($"Current Customer: ");
            _ScrollTo(0);
        }

        //Goto Last Record
        private void button4_Click(object sender, EventArgs e)
        {
            q = ctx.Customers.ToList();
            _UpdateTBoxes(q.Last());
            _UpdStatus($"Current Customer: ");
            _ScrollTo(q.Count-1);
        }

        //Remove Record
        private void button5_Click(object sender, EventArgs e)
        {
            q = ctx.Customers.ToList();
            currpos = _FindPos(q) - 1;
            c = _FindCust(q);
            _UpdateTBoxes(c);
            
            DialogResult dialogResult = MessageBox.Show
                ("Do you really want to remove this record?\n" +
                $"Customer ID : {c.CustomerID}\n" +
                $"Customer Name : {c.CustomerName}\n" +
                $"Member Rating : {c.MemberRating}", 
                "Record Administrator", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                ctx.Customers.Remove(c);
                ctx.SaveChanges();
                _UpdStatus($"Removed Customer: ");
                q = _LoadData();
                _ScrollTo(currpos);
            }
        }

        //Add Record
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                q = ctx.Customers.ToList();
                currpos = _FindPos(q);
                if (currpos < 0)
                {
                    if (_ValidateInput())
                    {
                        c = new Customers();
                        _ReadInput(c);

                        ctx.Customers.Add(c);
                        ctx.SaveChanges();
                        _UpdStatus($"Added Customer: ");
                        q = _LoadData();
                        currpos = _FindPos(q);
                        _ScrollTo(currpos);
                    }
                    else
                        _MsgStatus("Please enter valid information. None of the fields should be blank.");
                }
                else
                    _MsgStatus("Record already exists");
            }
            catch (Exception ex) { _MsgStatus(ex.Message); }
        }

        //Update Record
        private void button2_Click(object sender, EventArgs e)
        {
            if (_ValidateInput())
            {
                c = _FindCust(q);
                oldName = c.CustomerName;
                oldRating = c.MemberRating;
                _ReadInput(c);
                newName = c.CustomerName;
                newRating = c.MemberRating;
                ctx.SaveChanges();
                _ChgStatus();
                q = _LoadData();
                currpos = _FindPos(q);
                _ScrollTo(currpos);
            }
            else
                _MsgStatus("Please enter valid information. None of the fields should be blank.");
        }

        //Query Record
        private void button1_Click(object sender, EventArgs e)
        {
            if (custIDTBox.Text != "")
            {
                c = _FindCust(q);
                oldName = c.CustomerName;
                oldRating = c.MemberRating;
                _UpdateTBoxes(c);
                _UpdStatus("Current Customer: ");
                q = _LoadData();
                currpos = _FindPos(q);
                _ScrollTo(currpos);
            }
            else
                _MsgStatus("Please enter a valid CustomerID. It cannot be blank.");
        }

        //Methods
        private List<Customers> _LoadData()
        {
            dataGridView1.DataSource = ctx.Customers.ToList();
            return ctx.Customers.ToList();
        }
        private Customers _ReadInput(Customers c)
        {
            c.CustomerID = custIDTBox.Text;
            c.CustomerName = custNameTBox.Text;
            c.MemberRating = memRatingTBox.Text;
            return c;
        }
        private void _UpdateTBoxes(Customers c)
        {
            custIDTBox.Text = c.CustomerID;
            custNameTBox.Text = c.CustomerName;
            memRatingTBox.Text = c.MemberRating;
        }
        private void _ScrollTo(int index)
        {
            dataGridView1.ClearSelection();
            dataGridView1.Rows[index].Selected = true;
            dataGridView1.FirstDisplayedScrollingRowIndex =
                dataGridView1.SelectedRows[0].Index;
        }
        private int _FindPos(List<Customers> q)
        {
            return q.FindIndex(x => x.CustomerID == custIDTBox.Text);
        }
        private Customers _FindCust(List<Customers> q)
        {
            return q.Find(x => x.CustomerID == custIDTBox.Text);
        }
        private bool _ValidateInput()
        {
            return (custIDTBox.Text != "" && 
                    custNameTBox.Text != "" && 
                    memRatingTBox.Text != "") ? true : false;
        }
        private void _MsgStatus(string m)
        {
            toolStripStatusLabel1.Text = m;
        }
        private void _UpdStatus(string m)
        {
            toolStripStatusLabel1.Text = m +
                $"{ custIDTBox.Text}, { custNameTBox.Text}, { memRatingTBox.Text}";
        }
        private void _ChgStatus()
        {
            toolStripStatusLabel1.Text = 
                $"Updated Customer: " +
                $"{oldName}, {oldRating} >>>" +
                $"{newName}, {newRating}";
        }
    }
}
