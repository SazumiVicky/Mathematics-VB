# Advanced Mathematics Library VB.NET

Sebuah library matematika komprehensif yang diimplementasikan dalam VB.NET, mencakup berbagai operasi matematika tingkat lanjut termasuk aljabar linear, kalkulus, dan statistik.

## 🌟 Fitur

- **Operasi Matriks**
  - Transpose
  - Determinan (2x2)
  - Manipulasi matriks dasar

- **Kalkulus**
  - Turunan numerik
  - Integrasi numerik (metode rectangular)
  - Fungsi matematika dasar

- **Statistik**
  - Mean
  - Variance
  - Standard Deviation

- **Utilitas**
  - Generator matriks acak
  - Fungsi matematika dasar (factorial, power)

## 📁 Struktur Proyek

Mathematics-VB/
├── src/
│   ├── Core/
│   │   └── MathBase.vb
│   ├── Algebra/
│   │   └── Matrix.vb
│   ├── Calculus/
│   │   └── Derivative.vb
│   └── Statistics/
│       └── BasicStats.vb
├── Tests/
│   └── TestRunner.vb
└── Utils/
    └── MathHelper.vb

## 🚀 Cara Penggunaan

### Inisialisasi Proyek

1. Clone repository ini
2. Buka solusi di Visual Studio
3. Build proyek

### Contoh Penggunaan

' Matrix Operations
Dim matrix As New Matrix(2, 2)
Dim transposed = matrix.Transpose()

' Calculus
Dim deriv As New Derivative()
Dim result = deriv.NumericalDerivative(Function(x) x * x, 2.0)

' Statistics
Dim stats As New BasicStats()
Dim data = New Double() {1, 2, 3, 4, 5}
Dim mean = stats.Mean(data)
Dim stdDev = stats.StandardDeviation(data)

## 📚 Dokumentasi

### Matrix Class

' Membuat matriks baru
Dim matrix As New Matrix(rows, cols)

' Menghitung determinan (2x2)
Dim det = matrix.Determinant()

' Melakukan transpose
Dim transposed = matrix.Transpose()

### Derivative Class

' Menghitung turunan numerik
Dim deriv As New Derivative()
Dim result = deriv.NumericalDerivative(Function(x) x * x, 2.0)

' Menghitung integral
Dim integral = deriv.SimpleIntegration(Function(x) x * x, 0, 1)

### BasicStats Class

' Operasi statistik dasar
Dim stats As New BasicStats()
Dim mean = stats.Mean(data)
Dim variance = stats.Variance(data)
Dim stdDev = stats.StandardDeviation(data)

## 🛠️ Teknologi yang Digunakan

- Visual Basic .NET
- .NET Framework
- Visual Studio IDE

## 📋 Persyaratan Sistem

- .NET Framework 4.5 atau lebih tinggi
- Visual Studio 2017 atau lebih tinggi

## 🤝 Kontribusi

Kontribusi selalu diterima! Silakan ikuti langkah-langkah berikut:

1. Fork proyek ini
2. Buat branch fitur baru (`git checkout -b feature/example`)
3. Commit perubahan (`git commit -m 'Add some example'`)
4. Push ke branch (`git push origin feature/example`)
5. Buat Pull Request

## 📝 Lisensi

Didistribusikan di bawah Lisensi MIT. Lihat `LICENSE` untuk informasi lebih lanjut.

## 📧 Kontak

Sazumi Viki - root@sazumi.moe

Link Proyek: [https://github.com/sazumivicky/Mathematics-VB](https://github.com/sazumivicky/Mathematics-VB)