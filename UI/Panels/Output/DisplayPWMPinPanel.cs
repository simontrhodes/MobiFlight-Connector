using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MobiFlight.UI.Panels
{
    public partial class DisplayPWMPinPanel : UserControl
    {
        private MobiFlightModule Module;

        public DisplayPWMPinPanel()
        {
            InitializeComponent();
            singlePinSelectFlowLayoutPanel.Visible = true;
            PinSelectContainer.Height = singlePinSelectFlowLayoutPanel.Height;
            panel1.Visible = true;
        }

       
       
        internal void SetPins(List<ListItem> pins)
        {
            displayPWMPinComboBox.DataSource = new List<ListItem>(pins);
            displayPWMPinComboBox.DisplayMember = "Label";
            displayPWMPinComboBox.ValueMember = "Value";

            if (pins.Count > 0)
                displayPWMPinComboBox.SelectedIndex = 0;

            displayPWMPinComboBox.Enabled = pins.Count > 0;
            displayPWMPinComboBox.Width = displayPWMPinComboBox.MinimumSize.Width;

        }

            internal void syncFromConfig(OutputConfigItem config)
        {

            String serial = config.DisplaySerial;
            if (serial != null && serial.Contains('/'))
            {
                serial = serial.Split('/')[1].Trim();
            }
            if (config.PWMDriver.Pin != null && config.PWMDriver.Pin != "")
            {
                string pin = config.PWMDriver.Pin;

                if (!ComboBoxHelper.SetSelectedItem(displayPWMPinComboBox, pin)) { /* TODO: provide error message */ }
                SimLower.Text = config.PWMDriver.SimLower;
                SimUpper.Text = config.PWMDriver.SimUpper;
                PWMLower.Text = config.PWMDriver.PWMLower;
                PWMUpper.Text = config.PWMDriver.PWMUpper;
            }
        }
       

        virtual internal OutputConfigItem syncToConfig(OutputConfigItem config)
        {
            config.PWMDriver.Pin = displayPWMPinComboBox.Text;
            config.PWMDriver.SimLower = SimLower.Text;
            config.PWMDriver.SimUpper = SimUpper.Text;
            config.PWMDriver.PWMLower = PWMLower.Text;
            config.PWMDriver.PWMUpper = PWMUpper.Text;

            return config;
        }

       
       

        private void displayPWMPinComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Module != null)
            {
                String Pin = (sender as ComboBox).SelectedItem.ToString();
                
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
