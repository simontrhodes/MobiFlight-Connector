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
    public partial class ServoDriverPanel : UserControl
    {
        public ServoDriverPanel()
        {
            InitializeComponent();
        }

        public void SetAdresses(List<ListItem> I2Caddresses)
        {
            servoDriversAddressesComboBox.DataSource = new List<ListItem>(I2Caddresses);
            servoDriversAddressesComboBox.DisplayMember = "Label";
            servoDriversAddressesComboBox.ValueMember = "Value";

            if (I2Caddresses.Count > 0)
                servoDriversAddressesComboBox.SelectedIndex = 0;

            servoDriversAddressesComboBox.Enabled = I2Caddresses.Count > 0;
        }

        public void syncFromConfig(OutputConfigItem config)
        {
            if (config.ServoDriver.Address != null)
            {
                if (!ComboBoxHelper.SetSelectedItem(servoDriversAddressesComboBox, config.ServoDriver.Address))
                {
                    // TODO: provide error message
                    Log.Instance.log("_syncConfigToForm : Exception on selecting item in Servo Address ComboBox", LogSeverity.Debug);
                }
            }
            
        }

        internal OutputConfigItem syncToConfig(OutputConfigItem config)
        {
            if (servoDriversAddressesComboBox.SelectedValue != null)
            {
                config.ServoDriver.Address = servoDriversAddressesComboBox.SelectedValue.ToString().Split(',').ElementAt(0);
                //config.Servo.Min = minValueTextBox.Text;
                //config.Servo.Max = maxValueTextBox.Text;
                //config.Servo.MaxRotationPercent = maxRotationPercentNumericUpDown.Text;
            }

            return config;
        }

        private void servoAddressesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedValue == null) return;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void SetSelectedAddress(string value)
        {
            servoDriversAddressesComboBox.SelectedValue = value;
        }

       

        

       
    }
}
