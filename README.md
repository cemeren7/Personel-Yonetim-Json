Personel Yönetim Uygulaması

- Bu proje bir Windows Form uygulamasıdır.
- Tasarım alanında, DevExpress taraflı gelişmiş modern kontroller kullanılarak arayüz oluşturulmuştur.
- Verilerin düzenlenmesi ve kayıt edilmesi için JSON yapısı kullanılmıştır.
- Programda yaşanabilecek tüm hata kayıtları, tarafımda bulunan mail adresine loglanmaktadır.
- Oluşturulan veri modelleri sınıflara dayalıdır ve JSON tabanlıdır.

Program üzerinde yapılabilecek işlemler

- Personel ekleme, silme, düzenleme
- Düzenleme yapılan personel kaydına göre değişiklikleri log kaydı olarak tarih ve saate göre görüntüleme (local IP alınmaktadır)
- Verileri Excel, PDF, HTML, Word tabanlı olarak aktarma; panoya kopyalama (tüm veriler veya satır)
- Kısayolları kullanarak işlem yapma
- Uygulamada tema ayarlarını değiştirme
- Dışarıdan dosya açıp düzenleme
- Gmail taraflı mail gönderme (dosya eklenebilir)
- Verilerin üzerinde filtreleme yapma

Not
- Program üzerinde ileriki zamanlarda belirli güncellemeler ve iyileştirmeler yapılacaktır.
- Programın çalışması için mutlaka bilgisayarınızda devexpress paketinin 19.1 sürümü kurulu olmalıdır.

- Güncellemeler 11.09.2025
- Mail gönderiminde yaşanan durum asenkron olarak göndermeye dayalı olarak güncellendi.
- tooltip nesnelerinde tasarım iyileştirmesine gidildi.
- Mail gönderme işleminde hata ayıklaması için try/catch yapısı eklendi.
