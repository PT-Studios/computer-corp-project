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
    public partial class AddCPUForm : Form
    {
        private SalesForm parent;

        public AddCPUForm(SalesForm s)
        {
            parent = s;
            InitializeComponent();
            cpuQualBox.Items.Add("High-Range");
            cpuQualBox.Items.Add("Mid-Range");
            cpuQualBox.Items.Add("Low-Range");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string cpuName = cpuNameBox.Text;
            string cpuSpec = cpuSpecBox.Text;
            string cpuQual = cpuQualBox.Text;
            CPU newCPU = new CPU(cpuName, cpuSpec, cpuQual);
            parent.data.addCPU(newCPU);

            parent.loadCPUs();
            this.Dispose();
        }
    }
}
