using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MobiFlight.UI.Panels
{
    public partial class DisplayPWMDriverPanel : UserControl
    {
        private const int PWMPinCount = 16;

        public DisplayPWMDriverPanel()
        {
            InitializeComponent();
            displayPWMPinPanel.OnMoveTriggered += DisplayPWMPinPanel_OnMoveTriggered;
        }

        public event EventHandler<MoveTriggeredEventArgs> OnMoveTriggered;


         private void DisplayPWMPinPanel_OnMoveTriggered(object sender, MoveTriggeredEventArgs e)
         {
             OnMoveTriggered(this, e);
         }

        public void SyncFromConfig(OutputConfigItem config)
        {
            if (config.PWMDriver == null) return;
            
            // pre-select display stuff
            if (config.PWMDriver.Address != null)
                if (!ComboBoxHelper.SetSelectedItem(PWMDriversAddressesComboBox, config.PWMDriver.Address))
                    Log.Instance.log("_syncConfigToForm : Exception on selecting item in PWMDriversAddressesComboBox "+config.PWMDriver.Address,
                        LogSeverity.Error);

            UpdatePinList();

            if (config.PWMDriver.Pin == null) return;
            
            var cfg = config.Clone() as OutputConfigItem;
            cfg.PWMDriver.Pin = config.PWMDriver.Pin;
            displayPWMPinPanel.SyncFromConfig(cfg);
        }

        private void UpdatePinList()
        {
            displayPWMPinPanel.SetPins(SetPinList());
        }


        public void SetAddresses(List<ListItem> I2CAddresses)
        {
            PWMDriversAddressesComboBox.DataSource = new List<ListItem>(I2CAddresses);
            PWMDriversAddressesComboBox.DisplayMember = "Label";
            PWMDriversAddressesComboBox.ValueMember = "Value";

            if (I2CAddresses.Count <= 0) return;

            PWMDriversAddressesComboBox.SelectedIndex = 0;
            PWMDriversAddressesComboBox.Enabled = true;
        }


        private static List<ListItem> SetPinList()
        {
            var pinList = new List<ListItem>();
            for (var pin = 0; pin < PWMPinCount; pin++)
            {
                var itemNum = pin.ToString();
                pinList.Add(new ListItem
                {
                    Label = itemNum,
                    Value = itemNum
                });
            }

            return pinList;
        }

        internal OutputConfigItem SyncToConfig(OutputConfigItem config)
        {
            var address = PWMDriversAddressesComboBox.SelectedValue.ToString().Split(',').ElementAt(0);

            config = displayPWMPinPanel.SyncToConfig(config);
            config.PWMDriver.Address = address;
            return config;
        }

        private void PWMAddressesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedValue == null) return;
            UpdatePinList();
        }

        public void SetSelectedAddress(List<ListItem> value)
        {
            PWMDriversAddressesComboBox.SelectedValue = value;
        }

        private void displayPWMPinPanel_Load(object sender, EventArgs e)
        {
        }
    }
}