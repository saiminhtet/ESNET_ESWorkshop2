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
        IssueTran c;
        int currpos;

        public FormIssueTranWorkshop()
        {
            InitializeComponent();
        }
    }
}
