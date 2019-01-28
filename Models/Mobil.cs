using System.ComponentModel.DataAnnotations;

namespace netcore_webapi.Models
{
    public class Mobil{
        public Mobil(string namaModel, string brand, int tahunProduksi)
        {
            NamaModel = namaModel;
            Brand = brand;
            TahunProduksi = tahunProduksi;
        }

        [Required]
        public string NamaModel { get; set; }
        [Required]
        public string Brand { get; set; }

        [Required]
        public int TahunProduksi { get; set; }

    }
}