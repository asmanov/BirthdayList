using System.Windows.Forms;

namespace BirthdayList
{
    public partial class FullNameUserControl : UserControl
    {
        public FullNameUserControl()
        {
            InitializeComponent();
        }
        public FullNameUserControl(string fname, string lname) : this()
        {
            namelabel.Text = fname;
            lastNamelabel.Text = lname;
        }
    }
}
