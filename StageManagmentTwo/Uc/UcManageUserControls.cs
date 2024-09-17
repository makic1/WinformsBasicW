using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StageManagmentTwo.Uc
{
    public partial class UcManageUserControls : UserControl
    {
        public UcManageUserControls()
        {
            InitializeComponent();

            tabPageArtist.Controls.Add(new UcArtist());
            tabPageProgram.Controls.Add(new UcProgramStage());
            tabPagePerformance.Controls.Add(new UcPerformance());
        }

        /// <summary>
        /// aktualisiert tabpages
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedTab == tabPageArtist)
            {
                tabPageArtist.Controls.Clear();
                tabPageArtist.Controls.Add(new UcArtist());
            }
            if (tabControlMain.SelectedTab == tabPageProgram)
            {
                tabPageProgram.Controls.Clear();
                tabPageProgram.Controls.Add(new UcProgramStage());
            }
            if (tabControlMain.SelectedTab == tabPagePerformance)
            {
                tabPagePerformance.Controls.Clear();
                tabPagePerformance.Controls.Add(new UcPerformance());
            }
        }
    }
}
