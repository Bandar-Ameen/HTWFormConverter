using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControlSystem
{
    public partial class MainForm : Form
    {
        public delegate void UpdatePowerReading(double reading);
        public UpdatePowerReading PowerDelegate;
        
        public delegate void UpdatePowerButton(bool state);
        public UpdatePowerButton PowerButtonDelegate;

        //-----------------------------------------------------------------------------------------------------------------------//
        public MainForm()
        {
            InitializeComponent();

            // Setup bindings.
            
            panelPreColor.DataBindings.Add("BackColor", winToWeb.Program.Model, "PreampColor", false, DataSourceUpdateMode.OnPropertyChanged);
            checkBoxEnable.DataBindings.Add("Checked", winToWeb.Program.Model, "ControlThreadEnable", false, DataSourceUpdateMode.OnPropertyChanged);
            numericUpDown1.DataBindings.Add("Value", winToWeb.Program.Model, "ScrollValue", false, DataSourceUpdateMode.OnPropertyChanged);
            textBoxScrollValue.DataBindings.Add("Text", winToWeb.Program.Model, "ScrollValue", false, DataSourceUpdateMode.OnPropertyChanged);
            trackBar1.DataBindings.Add("Value", winToWeb.Program.Model, "ScrollValue", false, DataSourceUpdateMode.OnPropertyChanged);

            
            // Example of ComboBox binding.
            
            comboBox1.DataSource = winToWeb.Program.Model.preampList;
            comboBox1.DisplayMember = "DisplayName";
            comboBox1.ValueMember = "Value";
            comboBox1.DataBindings.Add("SelectedValue", winToWeb.Program.Model, "PreampSetting", false, DataSourceUpdateMode.OnPropertyChanged);
        
            PowerDelegate = new UpdatePowerReading(UpdatePowerMethod);

            PowerButtonDelegate = new UpdatePowerButton(UpdatePowerButtonMethod);


        }

        //-----------------------------------------------------------------------------------------------------------------------//
        public void UpdatePowerMethod(double reading)
        {
            textBoxPower.Text = reading.ToString();
        }

        //-----------------------------------------------------------------------------------------------------------------------//
        public void UpdatePowerButtonMethod(bool paramPowerOn)
        {
            this.checkBoxToggle.Checked = paramPowerOn;
            this.checkBoxToggle.BackColor = winToWeb.Program.Model.PowerColor;
        }

        //-----------------------------------------------------------------------------------------------------------------------//
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            winToWeb.Program.Model.ScrollValue = trackBar1.Value;
        }

        //-----------------------------------------------------------------------------------------------------------------------//
        private void MainForm_Load(object sender, EventArgs e)
        {
            winToWeb.Program.Model.AddObserver(this);
            checkBoxEnable.Checked = true;
        }

        //-----------------------------------------------------------------------------------------------------------------------//
        private void buttonNewForm_Click(object sender, EventArgs e)
        {
            MainForm newForm = new MainForm();
            newForm.Show();
        }

        //-----------------------------------------------------------------------------------------------------------------------//
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            winToWeb.Program.Model.RemoveObserver(this);
        }


    }
}