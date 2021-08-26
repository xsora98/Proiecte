using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Licenta
{
    public partial class Marimi : Form
    {
        public static string marime;
        public static string stoc;
        public Marimi()
        {
            InitializeComponent();
        }

        private void Marimi_Load(object sender, EventArgs e)
        {
            marime = "";
            stoc = "";
        }

        private void M28_CheckedChanged(object sender, EventArgs e)
        {
            SM28.Enabled = !SM28.Enabled;
        }

        private void M29_CheckedChanged(object sender, EventArgs e)
        {
            SM29.Enabled = !SM29.Enabled;
        }

        private void M30_CheckedChanged(object sender, EventArgs e)
        {
            SM30.Enabled = !SM30.Enabled;
        }

        private void M31_CheckedChanged(object sender, EventArgs e)
        {
            SM31.Enabled = !SM31.Enabled;
        }

        private void M32_CheckedChanged(object sender, EventArgs e)
        {
            SM32.Enabled = !SM32.Enabled;
        }

        private void M33_CheckedChanged(object sender, EventArgs e)
        {
            SM33.Enabled = !SM33.Enabled;
        }

        private void M34_CheckedChanged(object sender, EventArgs e)
        {
            SM34.Enabled = !SM34.Enabled;
        }

        private void M35_CheckedChanged(object sender, EventArgs e)
        {
            SM35.Enabled = !SM35.Enabled;
        }

        private void M36_CheckedChanged(object sender, EventArgs e)
        {
            SM36.Enabled = !SM36.Enabled;
        }

        private void M37_CheckedChanged(object sender, EventArgs e)
        {
            SM37.Enabled = !SM37.Enabled;
        }

        private void M38_CheckedChanged(object sender, EventArgs e)
        {
            SM38.Enabled = !SM38.Enabled;
        }

        private void M39_CheckedChanged(object sender, EventArgs e)
        {
            SM39.Enabled = !SM39.Enabled;
        }

        private void M40_CheckedChanged(object sender, EventArgs e)
        {
            SM40.Enabled = !SM40.Enabled;
        }

        private void M41_CheckedChanged(object sender, EventArgs e)
        {
            SM41.Enabled = !SM41.Enabled;
        }

        private void M42_CheckedChanged(object sender, EventArgs e)
        {
            SM42.Enabled = !SM42.Enabled;
        }

        private void M43_CheckedChanged(object sender, EventArgs e)
        {
            SM43.Enabled = !SM43.Enabled;
        }

        private void M44_CheckedChanged(object sender, EventArgs e)
        {
            SM44.Enabled = !SM44.Enabled;
        }

        private void M45_CheckedChanged(object sender, EventArgs e)
        {
            SM45.Enabled = !SM45.Enabled;
        }

        private void M46_CheckedChanged(object sender, EventArgs e)
        {
            SM46.Enabled = !SM46.Enabled;
        }

        private void M47_CheckedChanged(object sender, EventArgs e)
        {
            SM47.Enabled = !SM47.Enabled;
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            marime = "";
            stoc = "";
            if (SM28.Enabled == true)
            {
                marime += "28,";
                stoc += SM28.Value.ToString()+",";
            }
            if (SM29.Enabled == true)
            {
                marime += "29,";
                stoc += SM29.Value.ToString() + ",";
            }
            if (SM30.Enabled == true)
            {
                marime += "30,";
                stoc += SM30.Value.ToString() + ",";
            }
            if (SM31.Enabled == true)
            {
                marime += "31,";
                stoc += SM31.Value.ToString() + ",";
            }
            if (SM32.Enabled == true)
            {
                marime += "32,";
                stoc += SM32.Value.ToString() + ",";
            }
            if (SM33.Enabled == true)
            {
                marime += "33,";
                stoc += SM33.Value.ToString() + ",";
            }
            if (SM34.Enabled == true)
            {
                marime += "34,";
                stoc += SM34.Value.ToString() + ",";
            }
            if (SM35.Enabled == true)
            {
                marime += "35,";
                stoc += SM35.Value.ToString() + ",";
            }
            if (SM36.Enabled == true)
            {
                marime += "36,";
                stoc += SM36.Value.ToString() + ",";
            }
            if (SM37.Enabled == true)
            {
                marime += "37,";
                stoc += SM37.Value.ToString() + ",";
            }
            if (SM38.Enabled == true)
            {
                marime += "38,";
                stoc += SM38.Value.ToString() + ",";
            }
            if (SM39.Enabled == true)
            {
                marime += "39,";
                stoc += SM39.Value.ToString() + ",";
            }
            if (SM40.Enabled == true)
            {
                marime += "40,";
                stoc += SM40.Value.ToString() + ",";
            }
            if (SM41.Enabled == true)
            {
                marime += "41,";
                stoc += SM41.Value.ToString() + ",";
            }
            if (SM42.Enabled == true)
            {
                marime += "42,";
                stoc += SM42.Value.ToString() + ",";
            }
            if (SM43.Enabled == true)
            {
                marime += "43,";
                stoc += SM43.Value.ToString() + ",";
            }
            if (SM44.Enabled == true)
            {
                marime += "44,";
                stoc += SM44.Value.ToString() + ",";
            }
            if (SM45.Enabled == true)
            {
                marime += "45,";
                stoc += SM45.Value.ToString() + ",";
            }
            if (SM46.Enabled == true)
            {
                marime += "46,";
                stoc += SM46.Value.ToString() + ",";
            }
            if (SM47.Enabled == true)
            {
                marime += "47,";
                stoc += SM47.Value.ToString() + ",";
            }
            if (marime == "")
            {
                MessageBox.Show("Selectați cel puțin o mărime!");
                return;
            }

            marime = marime.Remove(marime.Length - 1);
            stoc = stoc.Remove(stoc.Length - 1);
            MessageBox.Show("Marime:"+marime+"\nStoc:"+stoc);
            Close();
            this.Visible = false;
        }
    }
}
