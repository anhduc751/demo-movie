using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TungMovie
{
	public partial class FormMenuCustomer : Form
	{
		public FormMenuCustomer()
		{
			InitializeComponent();
		}


        private void btnUserInfo_Click(object sender, EventArgs e)
        {
			new EditInfo().Show();
        }

        private void btnPurchasedTicket_Click(object sender, EventArgs e)
        {
            new ListSuccessedTicket().Show();
        }

        private void btnFilming_Click(object sender, EventArgs e)
        {
            new ListMV().Show();
        }

        private void btnCharacterList_Click(object sender, EventArgs e)
        {
            new ListCharater().Show();
        }
    }
}
