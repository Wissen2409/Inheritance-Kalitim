// Kalıtım : OOP'nin 3 kuralından bir tanesidir.!! 

// Kalıtım üst gruplardan alt gruplara miras yolu ile geçen bir yapıdır!!

// Özetle : Bir üst soya ait bir özelliğin, daha alt soylara geçmesidir kalıtım!!


// Yazılımsal olarak nedir ? : Bir sınıfın tüm özelliklerini, başka bir sınıfa aktarmak için katılım yapısı kullanılabilir!!!


KaraTasiti kara = new KaraTasiti();
kara.Kapasite=4;
kara.Enerji="Benzin";
kara.Hiz=100;
// karataşıtında olmayan ancak taşıt sıınıfınfan miras yolu ile gelen prop'ları set ettik ve bu değerle ile bir nesne ürettik!!

Console.WriteLine(kara.Kapasite);
