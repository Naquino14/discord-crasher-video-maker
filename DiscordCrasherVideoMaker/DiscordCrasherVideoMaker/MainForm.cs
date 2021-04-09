using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordCrasherVideoMaker
{
    public partial class MainForm : Form
    {
        private FormBacker formBacker = new FormBacker();
        public MainForm()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;

            InitializeComponent();

            formBacker.Initialize(
                vid1PathLabel,
                vid2PathLabel,
                vidOutputPathLabel,
                buttonCreate
                );
        }

        private void buttonVid1_Click(object sender, EventArgs e) => formBacker.Vid1OnClick();
        private void buttonVid2_Click(object sender, EventArgs e) => formBacker.Vid2OnClick();
        private void buttonOutput_Click(object sender, EventArgs e) => formBacker.OutputOnClick();
        private void buttonIUnderstand_Click(object sender, EventArgs e) => formBacker.IUnderstandOnClick();
        private void buttonCreate_Click(object sender, EventArgs e) => formBacker.CreateVideoOnClick();
        private void buttonHelp_Click(object sender, EventArgs e) => formBacker.HelpOnClick();
    }
}
