# Abstract Class ve Interface Karşılaştırması

## Abstract Class (Soyut Sınıf)
Soyut sınıflar, doğrudan nesne oluşturulamayan ve diğer sınıflar için bir temel (base) sınıf olarak kullanılan sınıflardır. İçerisinde hem gövdeli (implement edilmiş) hem de gövdesiz (abstract) metotlar barındırabilirler.

### Özellikler:
- Diğer sınıflar tarafından kalıtım yoluyla türetilebilirler.
- İçerisinde erişim belirleyicileri (access modifiers) kullanılabilir.
- Constructor (yapıcı) ve destructor (yıkıcı) metotlara sahip olabilirler.
- Statik üyeler içerebilirler.

## Interface (Arayüz)
Arayüzler, içerisinde sadece metot, özellik, olay ve indeksleyici bildirimleri barındıran, ancak bunların gövdelerini içermeyen yapılardır. Bir sınıf, bir veya birden fazla arayüzü uygulayarak (implement) bu bildirimlerin gövdelerini sağlar.

### Özellikler:
- Sadece metot, özellik, olay ve indeksleyici bildirimleri içerir; bunların gövdeleri bulunmaz.
- Erişim belirleyicileri kullanılmaz; tüm üyeler varsayılan olarak public'tir.
- Constructor veya destructor metotları içermezler.
- Statik üyeler barındırmazlar.

## Abstract Class ve Interface arasındaki farklar
Abstract class (soyut sınıf) ve interface (arayüz) kavramları, nesne yönelimli programlamada soyutlama ve çok biçimliliği sağlamak için kullanılır. Her ikisi de sınıflar arasında ortak davranışları ve özellikleri tanımlamak için kullanılsa da aralarında farklar vardır.

### Kalıtım (Inheritance):
- **Soyut Sınıf:** Bir sınıf, yalnızca bir soyut sınıfı miras alabilir.
- **Arayüz:** Bir sınıf, birden fazla arayüzü uygulayabilir.

### Üye Tanımları:
- **Soyut Sınıf:** Hem uygulanmış (gövdeli) hem de uygulanmamış (gövdesiz) metotlar içerebilir.
- **Arayüz:** Yalnızca metot, özellik, olay ve indeksleyici bildirimleri içerir; bunların gövdeleri bulunmaz.

### Erişim Belirleyicileri:
- **Soyut Sınıf:** Üyeleri için farklı erişim belirleyicileri (public, protected, private) kullanılabilir.
- **Arayüz:** Üyeleri varsayılan olarak public'tir ve başka bir erişim belirleyicisi kullanılamaz.

### Constructor ve Statik Üyeler:
- **Soyut Sınıf:** Constructor (yapıcı) ve statik üyeler içerebilir.
- **Arayüz:** Constructor içermez ve statik üyeler barındırmaz.

### Alanlar (Fields):
- **Soyut Sınıf:** Alanlar (fields) içerebilir.
- **Arayüz:** Alanlar içermez.

### Uygulama (Implementation):
- **Soyut Sınıf:** Metotların varsayılan uygulamalarını sağlayabilir.
- **Arayüz:** Metotların varsayılan uygulamalarını sağlayamaz; tüm metotlar uygulayan sınıf tarafından tanımlanmalıdır.

### Kullanım Amacı:
- **Soyut Sınıf:** Ortak davranışları ve özellikleri paylaşan sınıflar için temel (base) sınıf olarak kullanılır.
- **Arayüz:** Farklı sınıflara belirli bir yetenek veya işlevsellik kazandırmak için kullanılır.

## Abstract Class Örneği
```csharp
// Soyut sınıf tanımı
public abstract class Hayvan
{
    public string Isim { get; set; }
    public int Yas { get; set; }

    // Soyut metot
    public abstract void SesCikar();

    // Normal metot
    public void BilgiGoster()
    {
        Console.WriteLine($"İsim: {Isim}, Yaş: {Yas}");
    }
}

// Türeyen sınıf: Kedi
public class Kedi : Hayvan
{
    public override void SesCikar()
    {
        Console.WriteLine("Miyav");
    }
}

// Türeyen sınıf: Kopek
public class Kopek : Hayvan
{
    public override void SesCikar()
    {
        Console.WriteLine("Hav");
    }
}
```

## Interface Örneği
```csharp
// Arayüz tanımı
public interface IVeritabaniIslemleri
{
    void Baglan();
    void VeriEkle(string veri);
    void VeriSil(int id);
}

// Arayüzü uygulayan sınıf: SqlVeritabani
public class SqlVeritabani : IVeritabaniIslemleri
{
    public void Baglan()
    {
        Console.WriteLine("SQL Veritabanına bağlanıldı.");
    }

    public void VeriEkle(string veri)
    {
        Console.WriteLine($"SQL Veritabanına '{veri}' eklendi.");
    }

    public void VeriSil(int id)
    {
        Console.WriteLine($"SQL Veritabanından ID'si {id} olan veri silindi.");
    }
}

// Arayüzü uygulayan sınıf: OracleVeritabani
public class OracleVeritabani : IVeritabaniIslemleri
{
    public void Baglan()
    {
        Console.WriteLine("Oracle Veritabanına bağlanıldı.");
    }

    public void VeriEkle(string veri)
    {
        Console.WriteLine($"Oracle Veritabanına '{veri}' eklendi.");
    }

    public void VeriSil(int id)
    {
        Console.WriteLine($"Oracle Veritabanından ID'si {id} olan veri silindi.");
    }
}
```
