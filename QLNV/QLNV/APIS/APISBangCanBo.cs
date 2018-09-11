using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNV.Model;

namespace QLNV.APIS
{
    class APISBangCanBo
    {
        QLNVNhanVienEntities db = new QLNVNhanVienEntities();
        public IQueryable<BangCanBo> GetBangCanBo()
        {
            return db.BangCanBoes;
        }
        //GetBangCanBo
        public BangCanBo GetBangCanBoID(int Id)
        {
            return db.BangCanBoes.SingleOrDefault(x => x.CanBoID == Id);
        }
        public BangCanBo GetBangCanBoHoTen(string hoten)
        {
            return db.BangCanBoes.SingleOrDefault(x => x.HoTen == hoten);
        }
        public BangCanBo GetBangCanBoDonVi(string donVi)
        {
            return db.BangCanBoes.SingleOrDefault(x => x.DonVi == donVi);
        }
        public BangCanBo GetBangCanBoChucVu(string chucVu)
        {
            return db.BangCanBoes.SingleOrDefault(x => x.ChucVu == chucVu);
        }
        public BangCanBo GetBangCanBoNgaySinh(DateTime ngaySinh)
        {
            return db.BangCanBoes.SingleOrDefault(x => x.NgaySinh == ngaySinh);
        }
        //GetBangYeuCau
        public BangYeuCau GetBangYeuCauID(int Id)
        {
            return db.BangYeuCaus.SingleOrDefault(x => x.YeuCauID == Id);
        }
        public BangYeuCau GetBangYeuCauSoLuongCaTruc(int SlCaTruc)
        {
            return db.BangYeuCaus.SingleOrDefault(x => x.SoLuongCaTruc == SlCaTruc);
        }
        public BangYeuCau GetBangYeuCauNgayTruc(DateTime ngayTruc)
        {
            return db.BangYeuCaus.SingleOrDefault(x => x.NgayTruc == ngayTruc);
        }
        public BangYeuCau GetBangYeuCauIdAdmin(int IdAdmin)
        {
            return db.BangYeuCaus.SingleOrDefault(x => x.IDAdmin == IdAdmin);
        }
        //PostCanBo
        public void PostCanBo(BangCanBo canBo)
        {
            if(canBo == null)
            {
                //return92
            }
            else
            {
                db.BangCanBoes.Add(canBo);
                db.SaveChanges();
            }
            //return
        }
        //PostYeuCau
        public void PostYeuCau(BangYeuCau yeuCau)
        {
            if (yeuCau == null)
            {

            }
            else
            {
                db.BangYeuCaus.Add(yeuCau);
                db.SaveChanges();
            }
        }
        //UpdateCanBo
        public void UpdateCanBo(BangCanBo canBo)
        {
            BangCanBo CanBo=db.BangCanBoes.SingleOrDefault(x => x.CanBoID == canBo.CanBoID);
            if (canBo == null)
            {

            }
            else
            {
                CanBo.HoTen = canBo.HoTen;
                CanBo.NgaySinh = canBo.NgaySinh;
                CanBo.DonVi = canBo.DonVi;
                canBo.ChucVu = canBo.ChucVu;
            }
        }
        //UpdateYeuCau
        public void UpdateYeuCau(BangYeuCau yeuCau)
        {
            BangYeuCau YeuCau = db.BangYeuCaus.SingleOrDefault(x => x.YeuCauID == yeuCau.YeuCauID);
            if (yeuCau == null)
            {
                
            }
            else
            {
                YeuCau.NgayTruc = yeuCau.NgayTruc;
                YeuCau.SoLuongCaTruc = yeuCau.SoLuongCaTruc;
                YeuCau.IDAdmin = yeuCau.IDAdmin;
            }
        }
        //DeleteCanBo
        public void DeleteCanBo(BangCanBo canBo)
        {
            BangCanBo CanBo = db.BangCanBoes.SingleOrDefault(x => x.CanBoID == canBo.CanBoID);
            if (canBo == null)
            {

            }
            else
            {
                db.BangCanBoes.Remove(canBo);
            }
        }
        //DeleteYeuCau
        public void DeleteYeuCau(BangYeuCau yeuCau)
        {
            BangYeuCau YeuCau = db.BangYeuCaus.SingleOrDefault(x => x.YeuCauID == yeuCau.YeuCauID);
            if (yeuCau == null)
            {

            }
            else
            {
                db.BangYeuCaus.Remove(yeuCau);
            }
        }
    }
}
