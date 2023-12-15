﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ticari_Otamasyon
{
    public partial class frmanamodul : Form
    {
        public frmanamodul()
        {
            InitializeComponent();
        }
        frmurunler fr;
        private void btnurunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr== null || fr.IsDisposed)
            {
                fr = new frmurunler();
                fr.MdiParent = this;
                fr.Show();
                
            }
    
        }
        public string kullanici;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (fr15 == null || fr15.IsDisposed)
            {
                fr15 = new frmanasayfa();
                fr15.MdiParent = this;
                fr15.Show();
            } 
        }
        frmmusteriler fr2;
        private void btnmusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr2==null || fr2.IsDisposed)
            {
                fr2 = new frmmusteriler();
                fr2.MdiParent = this;
                fr2.Show();
            }
            

        }
        frmfirmalar fr3;
        private void btnfirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(fr3==null || fr3.IsDisposed)
            {
                fr3 = new frmfirmalar();
                fr3.MdiParent = this;
                fr3.Show();
            }
        }

        frmpersonel fr4;

        private void btnpersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(fr4==null || fr4.IsDisposed) 
            {
                fr4 = new frmpersonel();
                fr4.MdiParent = this;
                fr4.Show();
            }
        }
        frmrehber fr5;
        private void btnrehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr5 == null || fr5.IsDisposed)
            {
                fr5 = new frmrehber();
                fr5.MdiParent = this;
                fr5.Show();
            }
        }

        frmgiderler fr6;

        private void btngiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr6 == null || fr6.IsDisposed)
            {
                fr6 = new frmgiderler();
                fr6.MdiParent = this;
                fr6.Show();
            }
          
        }

        frmbankalar fr7;
        private void btnbankalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr7 == null || fr7.IsDisposed) 
            {
                fr7 = new frmbankalar();
                fr7.MdiParent = this;
                fr7.Show();
            }       
        }
        frmfaturalar fr8;
        private void btnfaturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(fr8 == null || fr8.IsDisposed)
            {
                fr8 = new frmfaturalar();
                fr8.MdiParent = this;
                fr8.Show();
            }
        }

        frmnotlar fr9;

        private void btnnotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if( fr9 == null || fr9.IsDisposed) 
            { 
                fr9 = new frmnotlar();
                fr9.MdiParent = this;
                fr9.Show();
            }
        }
        frmhareketler fr10;
        private void btnhareketler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(fr10 == null || fr10.IsDisposed) 
            {
                fr10 = new frmhareketler();
                fr10.MdiParent = this;
                fr10.Show();
            }
        }
        frmraporlar fr11;
        private void btnraporlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr11 == null || fr11.IsDisposed)
            {
                fr11 = new frmraporlar();
                fr11.MdiParent = this;
                fr11.Show();
            }
         
        }
        frmstoklar fr12;
        private void btnstoklar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(fr12 == null || fr12.IsDisposed)
            {
                fr12 = new frmstoklar();
                fr12.MdiParent = this;
                fr12.Show();
            }
         
        }
        frmayarlar fr13;
        private void btnayarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr13 == null || fr13.IsDisposed)
            {
                fr13 = new frmayarlar();
                fr13.ad = kullanici;
                fr13.Show();
            }
        }
        frmkasa fr14;
        private void btnkasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr14 == null || fr14.IsDisposed)
            {

                fr14 = new frmkasa();
                fr14.ad = kullanici; 
                fr14.MdiParent = this;
                fr14.Show();
            }
        }
        frmanasayfa fr15;
        private void btnanasayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr15 == null || fr15.IsDisposed) 
            {
                fr15 = new frmanasayfa();
                fr15.MdiParent = this;
                fr15.Show();  
            }
        }
    }
}
