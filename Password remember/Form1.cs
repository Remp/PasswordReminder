using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Password_remember
{
    public partial class Form1 : Form
    {
        public Dictionary<string, Dictionary<string, string>> data;

        public Form1()
        {
            InitializeComponent();
        }

        private void SerializeData(string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = File.Open(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                formatter.Serialize(fs, data);
            }
        }

        private void DeserializeData(string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read))
            {
                data = (Dictionary<string, Dictionary<string, string>>)formatter.Deserialize(fs);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }
    }
}
