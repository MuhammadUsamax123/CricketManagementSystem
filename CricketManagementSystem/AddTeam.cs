using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CricketManagementSystem
{
    public partial class AddTeam : MaterialSkin.Controls.MaterialForm
    {
        public AddTeam()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinmanager = MaterialSkin.MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green500, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void AddTeam_Load(object sender, EventArgs e)
        {

        }
    }
}
