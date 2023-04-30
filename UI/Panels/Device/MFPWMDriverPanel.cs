using System;
using System.Globalization;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;

namespace MobiFlight.UI.Panels.Settings.Device
{
    public partial class MFPWMDriverPanel : UserControl
    {
        private MobiFlight.Config.PWMDriver config;
        bool initialized = false;

        public MFPWMDriverPanel()
        {
            InitializeComponent();
        }

        public MFPWMDriverPanel(MobiFlight.Config.PWMDriver config, List<MobiFlightPin> Pins) : this()
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
                Changed(config, new EventArgs());
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