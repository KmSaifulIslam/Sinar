using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokoSinar
{
    class ClassListDetailPembelian
    {
        public int ID_DetailPembelian { get; set; }
        public string Nama_Barang { get; set; }
        public decimal Harga_Beli { get; set; }
        public int Jumlah_Beli { get; set; }
        public string Satuan { get; set; }
        public double Diskon { get; set; }
        public decimal Sub_Total { get; set; }
        public string ID_Barang { get; set; }
        public string No_Faktur { get; set; }
    }
}
