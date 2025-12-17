# Student Management Console App

Ushbu loyiha C# tilida yozilgan **console ilova** bo‘lib, talabalarni boshqarish uchun mo‘ljallangan.  
Ilova orqali foydalanuvchi tizimga kiradi, talabalarni qo‘shadi, ro‘yxatini ko‘radi va mavjud o‘rinlar sonini tekshiradi.

---

## Asosiy imkoniyatlar

- Foydalanuvchini ism orqali kutib olish
- Parol orqali tizimga kirish (admin)
- Cheklangan urinishlar bilan autentifikatsiya
- Talaba qo‘shish
- Talabalar ro‘yxatini ko‘rish
- Qo‘sha oladigan talabalar sonini aniqlash
- Oddiy va tushunarli console menyu

---

## Console menyu

Dasturga muvaffaqiyatli kirilgandan so‘ng quyidagi menyu chiqadi:
Talaba kiritish

O'quvchilar ro'yxati

Qo'sha oladigan o'quvchilar soni


---
Management
│
├── Managment.Domain
│ └── Models
│ └── Student.cs
│
├── Management.Aplication
│ └── Servises
│ └── StudentService.cs
│
└── Management.Client
└── Program.cs

## Ishlatilgan texnologiyalar

- C#
- .NET Console Application
- OOP (Class, Method)
- Array orqali vaqtinchalik xotira
- Layered Architecture

---

## Qanday ishga tushiriladi

1. Repository ni klon qiling:
```bash
git clone https://github.com/USERNAME/Management.git
