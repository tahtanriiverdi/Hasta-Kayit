using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TahaProjehastakyt.DL;

namespace TahaProjehastakyt.BL
{
    public static class BLogic
    {
        public static bool HastaEkle(Hastalar m)
        {
            try
            {
                int res = DataLayer.HastaEkle(m);
                return (res > 0);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool DoktorEkle(Doktorlar u)
        {
            try
            {
                int res = DataLayer.DoktorEkle(u);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static DataSet Doktorgetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.Doktorgetir(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return null;
            }
        }

        internal static bool DoktorGuncelle(Doktorlar u)
        {
            try
            {
                int res = DataLayer.DoktorGuncelle(u);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool DoktorSil(string id)
        {
            try
            {
                int res = DataLayer.Doktorsil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static DataSet Hastagetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.Hastagetir(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return null;
            }
        }

        internal static bool HastaGuncelle(Hastalar m)
        {
            try
            {
                int res = DataLayer.HastaGuncelle(m);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool HastaSil(string id)
        {
            try
            {
                int res = DataLayer.HastaSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static DataSet RandevuDetay()
        {
            try
            {
                DataSet ds = DataLayer.RandevuDetay();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return null;
            }
        }

        internal static bool RandevuEkle(Tedavitarih s)
        {
            try
            {
                int res = DataLayer.RandevuEkle(s);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool RandevuGuncelle(Tedavitarih s)
        {
            try
            {
                int res = DataLayer.RandevuGuncelle(s);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool RandevuSil(string id)
        {
            try
            {
                int res = DataLayer.RandevuSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }
    }
}
