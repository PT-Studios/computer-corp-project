using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerCorps
{
    public class DataManager
    {
        private System.Collections.ArrayList cpus;
        private System.Collections.ArrayList gpus;
        private System.Collections.ArrayList rams;
        private System.Collections.ArrayList hds;
        private System.Collections.ArrayList orders;

        public DataManager()
        {
            cpus = new System.Collections.ArrayList();
            gpus = new System.Collections.ArrayList();
            rams = new System.Collections.ArrayList();
            hds = new System.Collections.ArrayList();
            orders = new System.Collections.ArrayList();
        }

        public void addCPU(CPU c)
        {
            cpus.Add(c);
        }

        public void addGPU(GPU g)
        {
            gpus.Add(g);
        }

        public void addRAM(RAM r)
        {
            rams.Add(r);
        }

        public void addHD(HD h)
        {
            hds.Add(h);
        }

        public void addOrder(Order o)
        {
            orders.Add(o);
        }

        public CPU[] getCPUs()
        {
            return (CPU[])cpus.ToArray(typeof(CPU));
        }

        public GPU[] getGPUs()
        {
            return (GPU[])gpus.ToArray(typeof(GPU));
        }

        public RAM[] getRAMs()
        {
            return (RAM[])rams.ToArray(typeof(RAM));
        }

        public HD[] getHDs()
        {
            return (HD[])hds.ToArray(typeof(HD));
        }

        public Order[] getOrders()
        {
            return (Order[])orders.ToArray(typeof(Order));
        }

        public void removeCPU(CPU c)
        {
            cpus.Remove(c);
        }

        public void removeGPU(GPU g)
        {
            gpus.Remove(g);
        }

        public void removeRAM(RAM r)
        {
            rams.Remove(r);
        }

        public void removeHD(HD h)
        {
            hds.Remove(h);
        }
        
        public void removeOrder(Order o)
        {
            orders.Remove(o);
        }
        
        public CPU getCPU(int index)
        {
            CPU[] tmpCPUs = getCPUs();
            return tmpCPUs[index];
        }

        public GPU getGPU(int index)
        {
            GPU[] tmpGPUs = getGPUs();
            return tmpGPUs[index];
        }

        public RAM getRAM(int index)
        {
            RAM[] tmpRAMs = getRAMs();
            return tmpRAMs[index];
        }

        public HD getHD(int index)
        {
            HD[] tmpHDs = getHDs();
            return tmpHDs[index];
        }

        public Order getOrder(int index)
        {
            Order[] tmpOrds = getOrders();
            return tmpOrds[index];
        }

        public void getOrdersByCPU(CPU c)
        {
            cpus.Equals(c);
        }

        /*public Order[] getOrdersByCustomer(Customer c)
        {
            Order[] tmpOrds = getOrders();
            ArrayList ord = new ArrayList();
            for (int i = 0; i < tmpOrds.Length; i++)
            {
                if (c.Equals(tmpOrds[i].getCustomer()))
                {
                    ord.Add(tmpOrds[i]);
                }
            }
            return (Order[])ord.ToArray(typeof(Order));
        }
        */
        public void getOrdersByGPU(GPU g)
        {
            gpus.Equals(g);
        }

        public void getOrdersByProductAndCPU(CPU c, GPU g)
        {
            cpus.Equals(c);
            gpus.Equals(g);
        }

        /*public void getPartsByHigh(CPU c, GPU g, RAM r, HD h)
        {
            Order[] tmpOrds = getOrders();
            System.Collections.ArrayList ord = new System.Collections.ArrayList();
            for (int i = 0; i < tmpOrds.Length; i++)
            {
                if (c.Equals(tmpOrds[i].getCPU()))
                {
                    ord.Add(tmpOrds[i]);
                }
            }
            return (Order[])ord.ToArray(typeof(Order));
        }*/
    }
}
