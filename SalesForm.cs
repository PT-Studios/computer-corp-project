using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComputerCorps
{
    public partial class SalesForm : Form
    {

        public DataManager data;

        public SalesForm(DataManager d)
        {
            data = d;
            InitializeComponent();
            //customerReportBox.Items.Clear();
            //productReportBox.Items.Clear();
        }

        public void loadCPUs()
        {
            cpuPanel.Controls.Clear();
            CPU[] tmpCPU = data.getCPUs();
            for (int i = 0; i < tmpCPU.Length; i++)
            {
                CheckBox tmp = new CheckBox();
                tmp.Text = tmpCPU[i].getName() + " (" + tmpCPU[i].getSpecs() + ")" + " [" + tmpCPU[i].getQuality() + "]";
                tmp.AutoSize = true;
                tmp.Location = new Point(0, (20 * i));
                tmp.CheckedChanged += new EventHandler(tmp_CheckedChanged);
                cpuPanel.Controls.Add(tmp);
            }
        }

        public void loadGPUs()
        {
            gpuPanel.Controls.Clear();
            GPU[] tmpGPU = data.getGPUs();
            for (int i = 0; i < tmpGPU.Length; i++)
            {
                CheckBox tmp = new CheckBox();
                tmp.Text = tmpGPU[i].getName() + " (" + tmpGPU[i].getSpecs() + ")" + " [" + tmpGPU[i].getQuality() + "]";
                tmp.AutoSize = true;
                tmp.Location = new Point(0, (20 * i));
                tmp.CheckedChanged += new EventHandler(tmp_CheckedChanged);
                gpuPanel.Controls.Add(tmp);
            }
        }

        public void loadRAMs()
        {
            ramPanel.Controls.Clear();
            RAM[] tmpRAM = data.getRAMs();
            for (int i = 0; i < tmpRAM.Length; i++)
            {
                CheckBox tmp = new CheckBox();
                tmp.Text = tmpRAM[i].getName() + " (" + tmpRAM[i].getSpecs() + ")" + " [" + tmpRAM[i].getQuality() + "]";
                tmp.AutoSize = true;
                tmp.Location = new Point(0, (20 * i));
                tmp.CheckedChanged += new EventHandler(tmp_CheckedChanged);
                ramPanel.Controls.Add(tmp);
            }
        }

        public void loadHDs()
        {
            hdPanel.Controls.Clear();
            HD[] tmpHD = data.getHDs();
            for (int i = 0; i < tmpHD.Length; i++)
            {
                CheckBox tmp = new CheckBox();
                tmp.Text = tmpHD[i].getName() + " (" + tmpHD[i].getSpecs() + ")" + " [" + tmpHD[i].getQuality() + "]";
                tmp.AutoSize = true;
                tmp.Location = new Point(0, (20 * i));
                tmp.CheckedChanged += new EventHandler(tmp_CheckedChanged);
                hdPanel.Controls.Add(tmp);
            }
        }

        public void loadOrders()
        {
            orderPanel.Controls.Clear();
            Order[] tmpOrd = data.getOrders();
            for (int i = 0; i < tmpOrd.Length; i++)
            {
                CheckBox tmp = new CheckBox();
                tmp.Text = "CPU: " + (tmpOrd[i].getCPU().getName());
                tmp.AutoSize = true;
                tmp.Location = new Point(0, (20 * i));
                tmp.CheckedChanged += new EventHandler(tmp_OrdCheckedChanged);
                orderPanel.Controls.Add(tmp);
            }
        }

        public void tmp_OrdCheckedChanged(Object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked == true)
            {
                for (int i = 0; i < orderPanel.Controls.Count; i++)
                {
                    if (!sender.Equals(orderPanel.Controls[i]))
                    {
                        ((CheckBox)orderPanel.Controls[i]).Checked = false;
                    }
                }
            }
        }

        public void tmp_CheckedChanged(Object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked == true)
            {
                for (int i = 0; i < cpuPanel.Controls.Count; i++)
                {
                    if (!sender.Equals(cpuPanel.Controls[i]))
                    {
                        ((CheckBox)cpuPanel.Controls[i]).Checked = false;
                    }
                }
            }
        }

        private void addCPUButton_Click(object sender, EventArgs e)
        {
            AddCPUForm newForm = new AddCPUForm(this);
            newForm.Show();
        }

        private void deleteCPUButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cpuPanel.Controls.Count; i++)
            {
                if (((CheckBox)cpuPanel.Controls[i]).Checked == true)
                {
                    CPU toBeDeleted = data.getCPU(i);
                    data.removeCPU(toBeDeleted);
                }
            }
            loadCPUs();
        }

        private void addGPUButton_Click(object sender, EventArgs e)
        {
            AddGPUForm newForm = new AddGPUForm(this);
            newForm.Show();
        }

        private void removeGPUButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gpuPanel.Controls.Count; i++)
            {
                if (((CheckBox)gpuPanel.Controls[i]).Checked == true)
                {
                    GPU toBeDeleted = data.getGPU(i);
                    data.removeGPU(toBeDeleted);
                }
            }
            loadCPUs();
        }


        private void addRAMButton_Click(object sender, EventArgs e)
        {
            AddRAMForm newForm = new AddRAMForm(this);
            newForm.Show();
        }

        private void removeRAMButton_Click(object sender, EventArgs e)
        {
            {
                for (int i = 0; i < ramPanel.Controls.Count; i++)
                {
                    if (((CheckBox)ramPanel.Controls[i]).Checked == true)
                    {
                        RAM toBeDeleted = data.getRAM(i);
                        data.removeRAM(toBeDeleted);
                    }
                }
                loadRAMs();
            }
        }

        private void addHDButton_Click(object sender, EventArgs e)
        {
            AddHdForm newForm = new AddHdForm(this);
            newForm.Show();
        }

        private void removeHDButton_Click(object sender, EventArgs e)
        {
            {
                for (int i = 0; i < hdPanel.Controls.Count; i++)
                {
                    if (((CheckBox)hdPanel.Controls[i]).Checked == true)
                    {
                        HD toBeDeleted = data.getHD(i);
                        data.removeHD(toBeDeleted);
                    }
                }
                loadHDs();
            }
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            AddNewOrder newForm = new AddNewOrder(this);
            newForm.Show();
        }

        private void removeOrderButton_Click(object sender, EventArgs e)
        {
            {
                for (int i = 0; i < orderPanel.Controls.Count; i++)
                {
                    if (((CheckBox)orderPanel.Controls[i]).Checked == true)
                    {
                        Order toBeDeleted = data.getOrder(i);
                        data.removeOrder(toBeDeleted);
                    }
                }
                loadOrders();
            }
        }
    }
}

