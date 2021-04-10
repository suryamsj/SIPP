using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPP.model
{
    class Pengeluaran
    {
        string namabarang;
        int jumlahbarang;
        int hargabarang;
        string tanggalpembelian;

        public Pengeluaran() { }

        public Pengeluaran(string namabarang, int jumlahbarang, int hargabarang, string tanggalpembelian)
        {
            this.Namabarang = namabarang;
            this.Jumlahbarang = jumlahbarang;
            this.Hargabarang = hargabarang;
            this.Tanggalpembelian = tanggalpembelian;
        }

        public string Namabarang { get => namabarang; set => namabarang = value; }
        public int Jumlahbarang { get => jumlahbarang; set => jumlahbarang = value; }
        public int Hargabarang { get => hargabarang; set => hargabarang = value; }
        public string Tanggalpembelian { get => tanggalpembelian; set => tanggalpembelian = value; }
    }
}
