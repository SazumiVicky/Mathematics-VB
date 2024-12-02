# 📊 Advanced Mathematics Library VB.NET

A comprehensive mathematics library in VB.NET providing advanced operations such as linear algebra, calculus, and statistics to support your development needs.

## 🌟 Key Features

### 🔢 **Matrix Operations**
- Matrix transpose
- Determinant calculation (2x2)
- Basic matrix manipulation

### 📐 **Calculus**
- Numerical derivatives
- Numerical integration (rectangular method)
- Basic mathematical functions

### 📊 **Statistics**
- Mean calculation
- Variance calculation
- Standard deviation calculation

### 🛠️ **Additional Utilities**
- Random matrix generator
- Basic math functions (factorial, power)

## 📂 Project Structure

```plaintext
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
```

## 🚀 How to Use

### 1. Clone and Initialize the Project
```bash
git clone https://github.com/sazumivicky/Mathematics-VB.git
```
2. Open the solution in **Visual Studio**.
3. Build and run the project.

### 💡 Example Usage

```vb
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
```

## 📖 Class Documentation

### 🧮 **Matrix Class**
- Create a new matrix:
  ```vb
  Dim matrix As New Matrix(rows, cols)
  ```
- Calculate determinant (2x2):
  ```vb
  Dim det = matrix.Determinant()
  ```
- Transpose a matrix:
  ```vb
  Dim transposed = matrix.Transpose()
  ```

### 📉 **Derivative Class**
- Calculate numerical derivative:
  ```vb
  Dim deriv As New Derivative()
  Dim result = deriv.NumericalDerivative(Function(x) x * x, 2.0)
  ```
- Perform simple integration:
  ```vb
  Dim integral = deriv.SimpleIntegration(Function(x) x * x, 0, 1)
  ```

### 📊 **BasicStats Class**
- Basic statistical operations:
  ```vb
  Dim stats As New BasicStats()
  Dim mean = stats.Mean(data)
  Dim variance = stats.Variance(data)
  Dim stdDev = stats.StandardDeviation(data)
  ```

## 🛠️ Technologies Used

- Visual Basic .NET
- .NET Framework
- Visual Studio IDE

## 💻 System Requirements

- **.NET Framework 4.5** or higher
- **Visual Studio 2017** or later

## 🤝 Contribution

We welcome contributions! Follow these steps to contribute:

1. **Fork** this repository.
2. Create a new feature branch (`git checkout -b feature/new-feature`).
3. Commit your changes (`git commit -m 'Add new feature'`).
4. Push to the branch (`git push origin feature/new-feature`).
5. Open a **Pull Request**.

## 📝 License

Distributed under the **MIT License**. See the `LICENSE` file for more details.

## 📧 Contact

**Sazumi Viki**  
✉️ Email: [root@sazumi.moe](mailto:root@sazumi.moe)

🔗 Project Link: [Mathematics-VB on GitHub](https://github.com/sazumivicky/Mathematics-VB)
