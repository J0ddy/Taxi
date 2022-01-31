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
            pbCarImage.Image ??= pbCarImage.ErrorImage;
            pbCompanyImage.Image ??= pbCompanyImage.ErrorImage;
        }

        #region Methods

        private void AddDelButtonsEnabled(bool enabled)
        {
            btnNewTrip.Enabled = enabled;
            btnRemoveTrip.Enabled = enabled;
        }
        #endregion

        #region TabControl
        private void btnHome_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = dataTab;
            AddDelButtonsEnabled(true);
        }

        private void btnCarInfo_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = carTab;
            AddDelButtonsEnabled(false);
        }

        private void btnCompanyInfo_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = companyTab;
            AddDelButtonsEnabled(false);
        }
        #endregion

        private void pbCarImage_Click(object sender, EventArgs e)
        {
            //TODO: Changeable Car images or Get Car image via API
            throw new NotImplementedException();
        }

        private void pbCompanyImage_Click(object sender, EventArgs e)
        {
            //TODO: Changeable Company images only by Company admin
            throw new NotImplementedException();
        }
    }
}