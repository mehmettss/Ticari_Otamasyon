using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otamasyon
{
    public partial class frmraporlar : Form
    {
        public frmraporlar()
        {
            InitializeComponent();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {

        }

        private void frmraporlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DboTicariOtamasyonDataSet3.TBL_PERSONELLER' table. You can move, or remove it, as needed.
            this.TBL_PERSONELLERTableAdapter.Fill(this.DboTicariOtamasyonDataSet3.TBL_PERSONELLER);
            // TODO: This line of code loads data into the 'DboTicariOtamasyonDataSet2.TBL_GIDERLER' table. You can move, or remove it, as needed.
            this.TBL_GIDERLERTableAdapter.Fill(this.DboTicariOtamasyonDataSet2.TBL_GIDERLER);
            // TODO: This line of code loads data into the 'DboTicariOtamasyonDataSet1.TBL_MUSTERILER' table. You can move, or remove it, as needed.
            this.TBL_MUSTERILERTableAdapter.Fill(this.DboTicariOtamasyonDataSet1.TBL_MUSTERILER);
            // TODO: This line of code loads data into the 'DboTicariOtamasyonDataSet.TBL_FIRMALAR' table. You can move, or remove it, as needed.
            this.TBL_FIRMALARTableAdapter.Fill(this.DboTicariOtamasyonDataSet.TBL_FIRMALAR);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer5.RefreshReport();
        }
    }
}
