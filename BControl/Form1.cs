/*
BControl - Screen Brightness Controller via WMI
by GeoSn0w (@FCE365)

Documentation: 
    - https://docs.microsoft.com/en-us/windows/desktop/wmicoreprov/wmimonitorbrightness
    - https://docs.microsoft.com/en-us/windows/desktop/wmicoreprov/wmimonitorbrightnessmethods
    - https://docs.microsoft.com/en-us/windows/desktop/wmicoreprov/wmisetbrightness-method-in-class-wmimonitorbrightnessmethods
    - https://docs.microsoft.com/en-us/windows/desktop/wmicoreprov/wmimonitorbasicdisplayparams
    - https://docs.microsoft.com/en-us/windows/desktop/cimwin32prov/win32-videocontroller
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BControl
{
    public partial class VisualForm : Form
    {
        byte[] ValidBrightnessLevels;
        Label Percentage = new Label();

        public VisualForm()
        {
            InitializeComponent();
        }

        private void VisualForm_Load(object sender, EventArgs e)
        {
            Controls.Add(Percentage);
            Percentage.Font = new Font("Segoe UI", 15.75f, FontStyle.Regular);
            Percentage.Location = new Point(55, 204);
            Percentage.Size = new Size(80, 50);
            Percentage.ForeColor = Color.White;

            ValidBrightnessLevels = QueryAvailableBrightnessLevels();
            if (ValidBrightnessLevels.Count() == 0) 
            {
                MessageBox.Show("This computer does not appear to support this feature. Make sure the driver is installed and the video card supports brightness controlling.", "BControl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BrightnessController.Enabled = false;
            }
            else
            {
                BrightnessController.Value = FetchCurrentBrightness();
                BrightnessController.TickFrequency = ValidBrightnessLevels.Count();
                BrightnessController.Maximum = ValidBrightnessLevels.Count() - 1;
                BrightnessController.Update();
                BrightnessController.Refresh();
                Percentage.Text = BrightnessController.Value + " %";
            }
        }

        static int FetchCurrentBrightness()
        {
            byte CurrentBrightness = 0;
            System.Management.ManagementScope ManScope = new System.Management.ManagementScope("ROOT\\WMI");
            System.Management.SelectQuery ManQuery= new System.Management.SelectQuery("WmiMonitorBrightness");
            System.Management.ManagementObjectSearcher ManObjS = new System.Management.ManagementObjectSearcher(ManScope, ManQuery);
            System.Management.ManagementObjectCollection ManObjC = ManObjS.Get();

            foreach (System.Management.ManagementObject ManObject in ManObjC)
            {
                CurrentBrightness = (byte) ManObject.GetPropertyValue("CurrentBrightness");
                break;
            }

            ManObjC.Dispose();
            ManObjS.Dispose();

            return (int) CurrentBrightness;
        }

        static byte[] QueryAvailableBrightnessLevels()
        {

            byte[] BrightnessLevels = new byte[0];
            System.Management.ManagementScope ManScope = new System.Management.ManagementScope("ROOT\\WMI");
            System.Management.SelectQuery ManQuery = new System.Management.SelectQuery("WmiMonitorBrightness");
            System.Management.ManagementObjectSearcher ManObjS = new System.Management.ManagementObjectSearcher(ManScope, ManQuery);

            try
            {
                System.Management.ManagementObjectCollection ManObjC = ManObjS.Get();
                foreach (System.Management.ManagementObject ManObject in ManObjC)
                {
                    BrightnessLevels = (byte[])ManObject.GetPropertyValue("Level");
                    break;
                }

                ManObjC.Dispose();
                ManObjS.Dispose();
            }
            catch (Exception VideoException)
            {
                MessageBox.Show("Unable to get available brightness levels. The video card may not support this feature or the driver is not installed. Error: ", VideoException.Message);

            }
            return BrightnessLevels;
        }
        static void injectBrightnessWithValue(byte brightness)
        {
            System.Management.ManagementScope ManScope = new System.Management.ManagementScope("ROOT\\WMI");
            System.Management.SelectQuery ManQuery = new System.Management.SelectQuery("WmiMonitorBrightnessMethods");
            System.Management.ManagementObjectSearcher ManObjS = new System.Management.ManagementObjectSearcher(ManScope, ManQuery);
            System.Management.ManagementObjectCollection ManObjC = ManObjS.Get();

            foreach (System.Management.ManagementObject ManObject in ManObjC)
            {
                ManObject.InvokeMethod("WmiSetBrightness", new Object[] { UInt32.MaxValue, brightness });
                break; 
            }

            ManObjC.Dispose();
            ManObjS.Dispose();
        }

        private void BrightnessController_Scroll(object sender, EventArgs e)
        {
            injectBrightnessWithValue(ValidBrightnessLevels[BrightnessController.Value]);
            Percentage.Text = BrightnessController.Value + "%";
        }

        private void GetVideoCardInfo_Click(object sender, EventArgs e)
        {
            ManagementObjectSearcher ManObjS = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
            foreach (ManagementObject ManObject in ManObjS.Get())
            {
                MessageBox.Show(ManObject["Name"] + "\n" + "Driver Version: " + 
                                ManObject["DriverVersion"] + "\n" + "Video Processor: " + 
                                ManObject["VideoProcessor"] + "\n\n" + "Installed Display Drivers: " +
                                ManObject["InstalledDisplayDrivers"], "BControl - Video Card Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CloseAppX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
