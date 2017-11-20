using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Giaodien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Giaodien()
        {
            InitializeComponent();
        }

        private void btnnhappizza_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            nhappizza frm = new nhappizza();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btntaotaikhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            taotaikhoan frm = new taotaikhoan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnnhanvien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Sửa frm = new Sửa();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnkhachhang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            khachhang frm = new khachhang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnsanpham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sanpham frm = new sanpham();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btndoanhthu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Doanhthu frm = new Doanhthu();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnhoadon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            hoadon frm = new hoadon();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dsphieunhap frm = new dsphieunhap();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
