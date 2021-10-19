# EventCalendarApp
Kullanıcının belirleyeceği günlük, haftalık ve aylık olarak yapacağı işleri planyabildiği bir uygulamadır. 
Kullanıcıdan işin başlık bilgisi, başlangıç ve bitiş tarih bilgisi alınır. Bu  bilgiler veritabanına kaydedilir. 
Kullanıcı kaydettiği işleri listeleyebilir, silebilir ve değiştirebilir.
Kullanıcıdan işin başlangıç tarihi ve bitiş tarihi alınarak işlerin günlük, haftalık ve aylık olarak belirlenebilmektedir. 
Kullanılan Teknolojiiler: ASP.NET Core MVC, MSSQL, Entity Framework

Postman üzerinden uygulamadaki Rest servisler test edilmiştir. Servise yapılan istekler ve dönen cevaplar incelenmiştir.  
Yapılan Rest çağrılarının cevapları görsellerde gösterilmiştir.

Kullanıcının kaydettiği işleri listeyebilmesi için yapılan get isteği:
![image](https://user-images.githubusercontent.com/81049064/137917612-4fd9eaf6-7d1e-4ab0-9d57-5a5c60a390a8.png)

Kullanıcının yeni iş kaydı oluşturması için yapılan post isteği:
![image](https://user-images.githubusercontent.com/81049064/137917100-f7677ade-5fd4-49a7-ad1c-261eeb6c3a84.png)

Kullanıcının planladığı işi güncelleyebilmesi için yapılan post isteği:
![image](https://user-images.githubusercontent.com/81049064/137917886-40203231-aa76-459e-b0c8-90a101195c5b.png)

Kullanıcının planladığı işi silebilmesi için yapılan post isteği:
![image](https://user-images.githubusercontent.com/81049064/137918200-94f83807-09cf-4fb4-83d5-645e939fe7c9.png)
