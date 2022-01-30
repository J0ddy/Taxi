using MaterialSkin;
using MaterialSkin.Controls;

namespace Taxi
{
    public partial class MainWindow : MaterialForm
    {
        public MainWindow()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Yellow600, Primary.BlueGrey900, Primary.Yellow500,
                Accent.LightBlue200, TextShade.WHITE);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        #region TabControl
        private void btnCarInfo_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = carTab;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = dataTab;
        }

        private void btnCompanyInfo_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = companyTab;
        }
        #endregion
        
    }
}