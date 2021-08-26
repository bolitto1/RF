using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Detector_facial.formularios
{
    public partial class frmpruebas : Form
    {
        public frmpruebas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            appvb.dsTableAdapters.fotos_empTableAdapter tafe = new appvb.dsTableAdapters.fotos_empTableAdapter();
            //tafe.Insert ()
        }
    }
}
