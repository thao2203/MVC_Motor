using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVC_Motor.Models
{
    public class ClassEX
    {
        public static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;
        public static DataTable log(string cmdtxt)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            SqlDataAdapter cmd = new SqlDataAdapter(cmdtxt, conn);


            DataTable dt = new DataTable();

            cmd.Fill(dt);
            return dt;
        }

        internal object getbylsp(string mlsp)
        {
            DataTable dt = new DataTable();
            string cmdtext = string.Format(@"select * from sanpham where maLoai='" + mlsp + "'");
            dt = log(cmdtext);
            List<SanPham> li = new List<SanPham>();
            foreach (DataRow dr in dt.Rows)
            {
                SanPham ad = new SanPham();
                ad.maSanPham = int.Parse(dr[0].ToString());
                ad.maLoai = int.Parse(dr[2].ToString());
                ad.donGia = int.Parse(dr[4].ToString());
                ad.hinhAnh = dr[3].ToString();
                ad.mauSac = dr[5].ToString();
                ad.moTa = dr[6].ToString();
                ad.tenSanPham = dr[1].ToString();
                li.Add(ad);
            }
            return li;
        }
        internal object getlsp()
        {

            DataTable dt = new DataTable();
            string cmdtext = string.Format(@"select * from loaisanpham");
            dt = log(cmdtext);
            List<LoaiSanPham> li = new List<LoaiSanPham>();
            foreach (DataRow dr in dt.Rows)
            {
                LoaiSanPham ad = new LoaiSanPham();
                ad.maLoai = int.Parse(dr[0].ToString());
                ad.TenLoai = dr[1].ToString();
                li.Add(ad);
            }
            return li;
        }
        internal object getsp()
        {
            DataTable dt = new DataTable();
            string cmdtext = string.Format(@"select top(20) * from sanpham");
            dt = log(cmdtext);
            List<SanPham> li = new List<SanPham>();
            foreach (DataRow dr in dt.Rows)
            {
                SanPham ad = new SanPham();
                ad.maSanPham = int.Parse(dr[0].ToString());
                ad.maLoai = int.Parse(dr[2].ToString());
                ad.donGia = int.Parse(dr[4].ToString());
                ad.hinhAnh = dr[3].ToString();
                ad.mauSac = dr[5].ToString();
                ad.moTa = dr[6].ToString();
                ad.tenSanPham = dr[1].ToString();
                li.Add(ad);
            }
            return li;
        }
    }
}