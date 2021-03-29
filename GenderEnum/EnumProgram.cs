using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenderEnum
{
    public partial class EnumProgram : Form
    {
        public EnumProgram()
        {
            InitializeComponent();
        }
        public TossingResult Tossing(Gender gender)
        {
            int temp;
            Random rnd = new Random();
            temp = rnd.Next(0, 2);

            if (temp == (int)gender)
            {
                return TossingResult.Female;
            }
            else
            {
                return TossingResult.Male;
            }
        }
        private void btnTossing_Click(object sender, EventArgs e)
        {
            TossingResult result;

            if (cmbBxName.Text == "Ammu")
            {
                result = Tossing(Gender.Ammu);
                this.Text = result.ToString();
            }
            else if (cmbBxName.Text == "Achu")
            {
                result = Tossing(Gender.Achu);
                this.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("please select  option");
            }
        }
    }
}
