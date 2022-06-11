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
        }

        public void SetSelectedPin(string value)
        {
            displayPWMPinComboBox.SelectedValue = value;
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
            if (config.Pin.DisplayPin != null && config.Pin.DisplayPin != "")
            {
                string pin = config.Pin.DisplayPin;

                if (!ComboBoxHelper.SetSelectedItem(displayPWMPinComboBox, pin)) { /* TODO: provide error message */ }
            }
        }
       

        virtual internal OutputConfigItem syncToConfig(OutputConfigItem config)
        {
            config.Pin.DisplayPin = displayPWMPinComboBox.Text;
            return config;
        }

        internal void SetModule(MobiFlightModule module)
        {
            Module = module;
        }

       

        private void displayPWMPinComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Module != null)
            {
                String Pin = (sender as ComboBox).SelectedItem.ToString();
                
            }
        }
    }
}
