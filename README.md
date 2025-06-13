# FinancialCrm - Kişisel Finans ve Banka Takip Uygulaması

## Proje Hakkında
FinancialCrm, kullanıcıların banka hesaplarını, faturalarını, giderlerini ve banka hareketlerini kolayca yönetebileceği bir masaüstü uygulamasıdır. Proje, C# ve Windows Forms ile geliştirilmiş olup, veritabanı işlemleri için Entity Framework kullanmaktadır.

## Özellikler

## Kullanıcı Girişi (Login):
Kullanıcılar, uygulamaya kullanıcı adı ve şifre ile giriş yapar. Giriş işlemi sırasında Entity Framework ile Users tablosu üzerinden kimlik doğrulama yapılır. Girilen bilgiler veritabanında sorgulanır ve doğrulama başarılıysa ana ekrana yönlendirilir.

![image](https://github.com/user-attachments/assets/06fe79e5-1293-4908-8486-a90db351e701)

## Banka Yönetimi:
Kullanıcılar, farklı bankalardaki (ör. Ziraat Bankası, Vakıf Bank, İş Bankası) bakiyelerini görebilir. Her bankanın güncel bakiyesi ve son işlemleri ana ekranda özetlenir.

![image](https://github.com/user-attachments/assets/685af65f-3f6e-4c3d-83d3-098c6eb91201)

## Fatura Takibi:
Elektrik, doğalgaz, su, internet ve telefon gibi faturalar listelenebilir, yeni fatura eklenebilir, mevcut faturalar güncellenebilir veya silinebilir. Faturalar, dönemsel olarak takip edilir.

![image](https://github.com/user-attachments/assets/4c646f43-7a6b-41ff-aa13-ab72069f9270)

## Gider Yönetimi:
Market alışverişi, ulaşım gibi harcamalar kaydedilebilir ve geçmiş giderler listelenebilir.

![image](https://github.com/user-attachments/assets/be565841-b6fb-4618-ad30-b5699401fcc6)

## Banka Hareketleri:
Son banka işlemleri (maaş ödemesi, burs, havale vb.) detaylı şekilde görüntülenebilir.

![image](https://github.com/user-attachments/assets/6f3fc1c5-76e0-4e10-bd96-aae85ed15e26)

## Dashboard:
Toplam bakiye, ödenen/ödenecek faturalar ve son gelen havale gibi özet bilgiler grafiklerle sunulur.

![image](https://github.com/user-attachments/assets/f132a532-2349-4c0c-a24b-5537244fa314)

## Çıkış:
Kullanıcılar güvenli şekilde çıkış yapabilir.
