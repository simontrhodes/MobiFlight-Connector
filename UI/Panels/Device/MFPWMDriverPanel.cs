using System;
using System.Globalization;
using System.Windows.Forms;

namespace MobiFlight.UI.Panels.Settings.Device
{
    public partial class MFPWMDriverPanel : UserControl
    {
        private MobiFlight.Config.PWMDriver config;
        bool initialized = false;

        private MFPWMDriverPanel()
        {
            InitializeComponent();
        }

        public MFPWMDriverPanel(MobiFlight.Config.PWMDriver config) : this()
        {
            this.config = config;
            NameTextBox.Text = config.Name;
            AddressComboBox.SelectedItem = "0x" + config.I2CAddress.ToString("X2");

            initialized = true;
        }

        public event EventHandler Changed;

        private void value_Changed(object sender, EventArgs e)
        {
            if (!initialized) return;
            SetValues();
            if (Changed != null)
                Changed(config, EventArgs.Empty);
        }

        private void SetValues()
        {
            config.Name = NameTextBox.Text;
            config.I2CAddress = byte.Parse(AddressComboBox.Text.Replace("0x", ""), NumberStyles.HexNumber);
        }

        private void AddressComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            value_Changed(sender, e);
        }
    }
}