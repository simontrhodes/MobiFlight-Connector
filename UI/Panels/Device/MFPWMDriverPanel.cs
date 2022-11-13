using System;
using System.Globalization;
using System.Windows.Forms;
using MobiFlight.Config;

namespace MobiFlight.UI.Panels.Settings.Device
{
    public partial class MFPWMDriverPanel : UserControl
    {
        private readonly PWMDriver _config;
        private readonly bool _initialized;

        private MFPWMDriverPanel()
        {
            InitializeComponent();
        }

        public MFPWMDriverPanel(PWMDriver config) : this()
        {
            _config = config;
            NameTextBox.Text = config.Name;
            AddressComboBox.SelectedItem = "0x" + config.I2CAddress.ToString("X2");

            _initialized = true;
        }

        public event EventHandler Changed;

        private void value_Changed(object sender, EventArgs e)
        {
            if (!_initialized) return;
            SetValues();
            if (Changed != null)
                Changed(_config, EventArgs.Empty);
        }

        private void SetValues()
        {
            _config.Name = NameTextBox.Text;
            _config.I2CAddress = byte.Parse(AddressComboBox.Text.Replace("0x", ""), NumberStyles.HexNumber);
        }

        private void AddressComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            value_Changed(sender, e);
        }
    }
}