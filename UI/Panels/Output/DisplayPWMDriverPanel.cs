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

        private int PWMPortCount = 16;
        private DisplayPinPanel displayPWMPinPanel;

        public DisplayPWMDriverPanel()
        {
            InitializeComponent();
            displayPWMPinPanel = new DisplayPinPanel();
            displayPWMPinPanel.WideStyle = false;
            displayPWMPinPanel.MultiSelectSupport = false;
            displayPWMPinPanel.SetPins(SetPWMPinList());



        }

        
        public void SetAdresses(List<ListItem> I2Caddresses)
        {
            PWMDriversAddressesComboBox.DataSource = new List<ListItem>(I2Caddresses);
            PWMDriversAddressesComboBox.DisplayMember = "Label";
            PWMDriversAddressesComboBox.ValueMember = "Value";

            if (I2Caddresses.Count > 0)
            {
                PWMDriversAddressesComboBox.SelectedIndex = 0;
                PWMDriversAddressesComboBox.Enabled = true;
            }
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
            //SetPWMPinList();

            if (config.PWMDriver.PWMPin != null)
            {
                OutputConfigItem cfg = config.Clone() as OutputConfigItem;
                cfg.Pin.DisplayPin = config.PWMDriver.PWMPin;
                //displayPinPanel.syncFromConfig(cfg);
            }
        }

        

        private List<ListItem> SetPWMPinList()
        {

            List<ListItem> pwmpinList = new List<ListItem>();
            for (int port = 0; port < PWMPortCount; port++)
            {
                    string itemNum = port.ToString();
                pwmpinList.Add(new ListItem()
                {
                    Label = itemNum,
                    Value = itemNum
                });

            }
            return pwmpinList;
            
        }

        internal OutputConfigItem syncToConfig(OutputConfigItem config)
        {
            String address = PWMDriversAddressesComboBox.SelectedValue.ToString().Split(',').ElementAt(0);
            OutputConfigItem cfg = config.Clone() as OutputConfigItem;
            cfg = displayPinPanel.syncToConfig(cfg);
            String pin = cfg.Pin.DisplayPin;

            config.PWMDriver.PWMPin = pin;
            config.PWMDriver.Address = address + " (" + pin + ")";
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
