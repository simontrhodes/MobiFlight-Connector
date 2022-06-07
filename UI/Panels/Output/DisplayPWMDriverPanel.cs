using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MobiFlight.Base;
using MobiFlight.UI.Panels.Config;

namespace MobiFlight.UI.Panels
{
    public partial class DisplayPWMDriverPanel : UserControl
    {

        private int PWMPortCount = 0;
        public DisplayPWMDriverPanel()
        {
            InitializeComponent();
            displayPinPanel.SetPorts(new List<ListItem>());
            displayPinPanel.WideStyle = true;
        }

        
        public void SetAdresses(List<ListItem> I2Caddresses)
        {
            PWMDriversAddressesComboBox.DataSource = new List<ListItem>(I2Caddresses);
            PWMDriversAddressesComboBox.DisplayMember = "Label";
            PWMDriversAddressesComboBox.ValueMember = "Value";

            if (I2Caddresses.Count > 0)
                PWMDriversAddressesComboBox.SelectedIndex = 0;

            PWMDriversAddressesComboBox.Enabled = I2Caddresses.Count > 0;
        }

        public void syncFromConfig(OutputConfigItem config)
        {
            if (config.PWMDriver.Address != null)
            {
                if (!ComboBoxHelper.SetSelectedItem(PWMDriversAddressesComboBox, config.PWMDriver.Address))
                {
                    
                    Log.Instance.log("_syncConfigToForm : Exception on selecting item in Servo Address ComboBox", LogSeverity.Debug);
                }
            }
            UpdatePWMPinPinList();

            if (config.PWMDriver.PWMPin != null)
            {
                OutputConfigItem cfg = config.Clone() as OutputConfigItem;
                cfg.Pin.DisplayPin = config.PWMDriver.PWMPin;
                displayPinPanel.syncFromConfig(cfg);
            }
        }

        

        private void UpdatePWMPinPinList()
        {

            List<ListItem> pwmpinList = new List<ListItem>();
            for (int row = 1; row <= PWMPortCount; row++)
            {

                for (int column = 1; column <= 8; column++)
                {
                    string itemNum = (8 * (row - 1) + column - 1).ToString();
                    pwmpinList.Add(new ListItem()
                    {
                        Label =
                        MobiFlightPWMDriver.LABEL_PREFIX + " " + itemNum,
                        Value = MobiFlightPWMDriver.LABEL_PREFIX + " " + itemNum
                    });
                }
            }


            displayPinPanel.SetPins(pwmpinList);
        }

        internal OutputConfigItem syncToConfig(OutputConfigItem config)
        {
            if (PWMDriversAddressesComboBox.SelectedValue != null)
            {
                config.PWMDriver.Address = PWMDriversAddressesComboBox.SelectedValue.ToString().Split(',').ElementAt(0);
                
            }

            return config;
        }

        private void PWMAddressesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedValue == null) return;
        }


        private void label_Click(object sender, EventArgs e)
        {

        }

        

        public void SetSelectedAddress(string value)
        {
            PWMDriversAddressesComboBox.SelectedValue = value;
        }

        internal void SetNumModules(int num8bitRegisters)
        {
        //    this.RegisterCount = num8bitRegisters;
            //UpdatePinList();
        }
    }
}
