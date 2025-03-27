using EncapsulationAndRecord.Models;

namespace EncapsulationAndRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Apple","Iphone",1200.3m, 12.1m,1);

            product.GetInfo();
            product.Sale();
        }
    }
}
//Product classi yaradirsiz:
// Id
// BrandName,
// Model,
// Price,
// Cost, - xercleri   
// Income, - umumi gelir
// Count - mehsulun sayi
// fieldleri olur. Constructor ishe dushdukde Income ve Id-den bashqa butun deyerleri qebul edir.(Income 0-dan bashliyib mehsul satildiqca artacaq. Count menfi ola bilmez. Menfi gonderilerse 0 verilsin).
//Id-ni ctor ishe dushdukde(yəni constructorun icerisinde) BrandName ilk 2 simvolunu Modelin ilk 2 simvolunu birleshdirerek teyin edirsiz. Meselen( Brand adi : Apple, Model:Iphone13 dirse Id:ApIp olmalidir )
 
//GetInfo() methodu olur.

//Sale() methodu olur.Eger kifayet qeder mehsul varsa Satishi heyata kecirir satilan qiymetden xercler cixilaraq gelire elave edir ve mehsul sayini azaldir.

//QEYD:Butun fieldler encapsule edilmelidir. Encapsule shertlerini ozunuz mentiqle qurun