## 🖩 Simple Console Calculator in C##

## 📌 About the Project  
This is a **console-based calculator** built in **C#**, designed as part of my System Developer studies.  
It supports **basic arithmetic operations** such as **addition, subtraction, multiplication, and division**,  
while also handling user input efficiently.  

## 🚀 Features  
✔️ Supports `+`, `-`, `*`, `/` operations  
✔️ User-friendly console interface  
✔️ Input validation for correct operator selection  
✔️ Error handling for invalid inputs  
✔️ Clean and structured C# code  

## 🔧 Technologies Used  
- **Language:** C#  
- **Framework:** .NET  
- **IDE:** Visual Studio  

## 📜 How It Works  
1️⃣ The user selects an operation (`+`, `-`, `*`, `/`)  
2️⃣ Inputs two numbers  
3️⃣ The program performs the calculation  
4️⃣ The result is displayed in the console  

## 📝 Code Example  
```csharp
Write("Select an option + - * /");
char op = char.Parse(ReadLine());

if(op == '+' || op == '-' || op == '*' || op == '/') 
{
    Write("First Number: ");
    double num1 = double.Parse(ReadLine());

    Write("Second Number: ");
    double num2 = double.Parse(ReadLine());

    double result = op == '+' ? num1 + num2 : 
                    op == '-' ? num1 - num2 :
                    op == '*' ? num1 * num2 : num1 / num2;

    WriteLine($"The result is: {result}");
}
else
{
    WriteLine("You selected a wrong option.");
}
🔗 More Information
👨‍💻 Developer: Evangelos Gallos
🌍 Portfolio: www.evgallos.com
📧 Contact: evangelos.gallos@gmail.com
📌 Repository: https://gihub.com/Evgallos/Calculator

⭐ If you found this project useful, consider giving it a star! 🚀
