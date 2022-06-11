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
        public bool WideStyle = false;

        public DisplayPWMDriverPanel()
        {
            InitializeComponent();
            displayPinPanel.SetPorts(new List<ListItem>());
            displayPinPanel.WideStyle = false;

        }

        public void syncFromConfig(OutputConfigItem config)
        {
            // pre-select display stuff
            if (config.PWMDriver != null && config.PWMDriver.Address != null)
            {
                if (!ComboBoxHelper.SetSelectedItem(PWMDriversAddressesComboBox, config.PWMDriver.Address.ToString()))
                {
                    Log.Instance.log("_syncConfigToForm : Exception on selecting item in PWMDriversAddressesComboBox", LogSeverity.Debug);
                }
            }

            UpdatePinList();

            if (config.PWMDriver.Pin != null)
            {
                OutputConfigItem cfg = config.Clone() as OutputConfigItem;
                cfg.Pin.DisplayPin = config.PWMDriver.Pin;
                displayPinPanel.syncFromConfig(cfg);
            }
        }

        public void UpdatePinList()
        {
            displayPinPanel.SetPins(SetPinList());
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

        
        

        private List<ListItem> SetPinList()
        {

            List<ListItem> PinList = new List<ListItem>();
            for (int port = 0; port < PWMPortCount; port++)
            {
                    string itemNum = port.ToString();
                PinList.Add(new ListItem()
                {
                    Label = itemNum,
                    Value = itemNum
                });

            }
            return PinList;
            
        }

        internal OutputConfigItem syncToConfig(OutputConfigItem config)
        {
            String address = PWMDriversAddressesComboBox.SelectedValue.ToString().Split(',').ElementAt(0);
            OutputConfigItem cfg = config.Clone() as OutputConfigItem;
            cfg = displayPinPanel.syncToConfig(cfg);
            String pin = cfg.Pin.DisplayPin;

            config.PWMDriver.Pin = pin;
            //config.PWMDriver.Address = address + " (" + pin + ")";
            config.PWMDriver.Address = address ;
            return config;
        }

        private void PWMAddressesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedValue == null) return;
            UpdatePinList();
        }


       

        public void SetSelectedAddress(string value)
        {
            PWMDriversAddressesComboBox.SelectedValue = value;
        }

        internal void SetNumModules(int num8bitRegisters)
        {
        //    this.RegisterCount = num8bitRegisters;
            UpdatePinList();
        }

       
    }
}
