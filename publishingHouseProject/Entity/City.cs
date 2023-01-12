using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace publishingHouseProject.Entity
{
    public class City
    {
       
        [Key]
        public int Id { get; set; }
        public string CityName { get; set; }
        public string RegionName { get; set; }
        public int RegionId{ get; set; }
        public virtual ICollection<SubOffice> SubOffices { get; set; }
        public virtual Region Region{ get; set; }

        //public string Adana { get; set; }
        //public string Adıyaman { get; set; }
        //public string Afyonkarahisar { get; set; }
        //public string Ağrı { get; set; }
        //public string Aksaray { get; set; }
        //public string Amasya { get; set; }
        //public string Ankara { get; set; }
        //public string Antalya { get; set; }
        //public string Ardahan { get; set; }
        //public string Artvin { get; set; }
        //public string Aydın { get; set; }
        //public string Balıkesir { get; set; }
        //public string Bartın { get; set; }
        //public string Batman { get; set; }
        //public string Bayburt { get; set; }
        //public string Bilecik { get; set; }
        //public string Bingöl { get; set; }
        //public string Bitlis { get; set; }
        //public string Bolu { get; set; }
        //public string Burdur { get; set; }
        //public string Bursa { get; set; }
        //public string Çanakkale { get; set; }
        //public string Çankırı { get; set; }
        //public string Çorum { get; set; }
        //public string Denizli { get; set; }
        //public string Diyarbakır { get; set; }
        //public string Düzce { get; set; }
        //public string Edirne { get; set; }
        //public string Elazığ { get; set; }
        //public string Erzincan { get; set; }
        //public string Erzurum { get; set; }
        //public string Eskişehir { get; set; }
        //public string Gaziantep { get; set; }
        //public string Giresun { get; set; }
        //public string Gümüşhane { get; set; }
        //public string Hakkari { get; set; }
        //public string Hatay { get; set; }
        //public string Isparta { get; set; }
        //public string İstanbul { get; set; }
        //public string İzmir { get; set; }
        //public string Kahramanmaraş { get; set; }
        //public string Karabük { get; set; }
        //public string Karaman { get; set; }
        //public string Kars { get; set; }
        //public string Kastamonu { get; set; }
        //public string Kayseri { get; set; }
        //public string Kırıkkale { get; set; }
        //public string Kırklareli { get; set; }
        //public string Kırşehir { get; set; }
        //public string Kilis { get; set; }
        //public string Kocaeli { get; set; }
        //public string Konya { get; set; }
        //public string Kütahya { get; set; }
        //public string Malatya { get; set; }
        //public string Manisa { get; set; }
        //public string Mardin { get; set; }
        //public string Mersin { get; set; }
        //public string Muğla { get; set; }
        //public string Muş { get; set; }
        //public string Nevşehir { get; set; }
        //public string Niğde { get; set; }
        //public string Ordu { get; set; }
        //public string Osmaniye { get; set; }
        //public string Rize { get; set; }
        //public string Sakarya { get; set; }
        //public string Samsun { get; set; }
        //public string Siirt { get; set; }
        //public string Sinop { get; set; }
        //public string Sivas { get; set; }
        //public string Şanlıurfa { get; set; }
        //public string Şırnak { get; set; }
        //public string Tekirdağ { get; set; }
        //public string Tokat { get; set; }
        //public string Trabzon { get; set; }
        //public string Tunceli { get; set; }
        //public string Uşak { get; set; }
        //public string Van { get; set; }
        //public string Yozgat { get; set; }
        //public string Yalova { get; set; }
        //public string Zonguldak { get; set; }
    }
}
