using System;

namespace task23._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool f=true;
            do
            {

            }while (!f);
        }
    }
}

//PriceMustBeGratherThanZeroException - exception yaradirsiniz.

//Product class
//-No->her obyekt yarananda +1 vahid artacaq
//- Name
//- Price -> encapsulation edirsiniz, eger price 0dan ashagi gonderilibse,
//PriceMustBeGratherThanZeroException geriye qaytarirsiniz

//- Type (Baker, Drink, Meat, Diary)

//Store class
//-Products
//- AddProduct()
//- RemoveProductByNo() - no dəyəri qəbul edir və həmin dəyərli product obyektini products siyahısından çıxarır
//- GetProduct() -> nullable int No deyeri qebul edir eger hemin no'ya uygun product varsa geriye qaytarir
//- FilterProductsByType() - type dəyəri qəbul edir və həmin dəyərli productlardan ibarət array qaytarır
//- FilterProductByName() - string dəyər qəbul edir və name dəyərində həmin string dəyər olan bütün productlardan ibarət siyahı qaytarır

//Name, Price, Type deyeri olmadan, Product yarana bilmez.

//Program.cs -də menu hissə qurmağınız lazımdır. Layihə run olanda Product əlavə etmək, Type-a görə filterlemək seçimləri olmalıdır menuda
