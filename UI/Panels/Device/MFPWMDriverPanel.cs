using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MobiFlight.UI.Panels.Settings.Device
{
    public partial class MFPWMDriverPanel : UserControl
    {
       
        public event EventHandler Changed;

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

        private void value_Changed(object sender, EventArgs e)
        {
            if (!initialized) return;
            setValues();
            if (Changed != null)
                Changed(config, new EventArgs());
        }

        private void setValues()
        {
            config.Name = NameTextBox.Text;
            config.I2CAddress = byte.Parse(AddressComboBox.Text.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber);

        }
        private void displayError(Control control, String message)
        {
            errorProvider.SetIconAlignment(control, ErrorIconAlignment.TopRight);
            errorProvider.SetError(
                    control,
                    message);
            MessageBox.Show(message, i18n._tr("Hint"));
        }
        private void removeError(Control control)
        {
            errorProvider.SetError(
                    control,
                    "");
        }

        private void AddressComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            value_Changed(sender, e);
        }
    }
}
