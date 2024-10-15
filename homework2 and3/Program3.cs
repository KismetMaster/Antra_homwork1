// See https://aka.ms/new-console-template for more information

//int[] generateNember() {
//    int [] number = new int[10];
//    for (int i = 1; i < 10; i++) {
//        number[i] = i;
//    }
//    return number;
//}

//void Reverse(int[] numbers) {
//    int n = numbers.Length-1;
//    for (int i = 0; i < numbers.Length/2; i++) {
//        int temp=numbers[i];
//        numbers[i] = numbers[n - i];
//        numbers[n - i] = temp;
//    }
//}

//void PrintNumbers(int[]nums) {
//    for (int i = 0; i < nums.Length; i++) {
//    Console.WriteLine(nums[i]);
//    }
//}

//int[] numbers = generateNember();
//Reverse(numbers);
//PrintNumbers(numbers);




// int Fibonacci(int n) {
//    if (n < 2)
//    {
//        return n;
//    }
//    int p = 0, q = 0, r = 1;
//    for (int i = 2; i <= n; ++i)
//    {
//        p = q;
//        q = r;
//        r = p + q;
//    }
//    return r;
//}

//Console.WriteLine(Fibonacci(3));



//using System;
//using System.Collections.Generic;

//// 接口定义
//public interface IPersonService
//{
//    decimal CalculateSalary();
//    int CalculateAge();
//    string[] GetAddresses();
//}

//public interface IStudentService : IPersonService
//{
//    double CalculateGPA();
//    void EnrollInCourse(Course course);
//}

//public interface IInstructorService : IPersonService
//{
//    bool IsHeadOfDepartment();
//    decimal CalculateBonus();
//}

//// Person类：抽象基类
//public abstract class Person : IPersonService
//{
//    public string Name { get; set; }
//    public DateTime BirthDate { get; set; }
//    private List<string> addresses = new List<string>();

//    // 添加地址
//    public void AddAddress(string address)
//    {
//        addresses.Add(address);
//    }

//    // 获取地址
//    public string[] GetAddresses()
//    {
//        return addresses.ToArray();
//    }

//    // 计算年龄
//    public int CalculateAge()
//    {
//        return DateTime.Now.Year - BirthDate.Year;
//    }

//    // 抽象方法：子类需要实现
//    public abstract decimal CalculateSalary();
//}

//// Student类，继承自Person
//public class Student : Person, IStudentService
//{
//    private List<Course> courses = new List<Course>();
//    private Dictionary<Course, char> grades = new Dictionary<Course, char>();

//    // 注册课程
//    public void EnrollInCourse(Course course)
//    {
//        courses.Add(course);
//    }

//    // 计算GPA
//    public double CalculateGPA()
//    {
//        double totalPoints = 0;
//        int totalCourses = grades.Count;

//        foreach (var grade in grades.Values)
//        {
//            totalPoints += GradeToPoints(grade);
//        }

//        return totalCourses == 0 ? 0 : totalPoints / totalCourses;
//    }

//    private double GradeToPoints(char grade)
//    {
//        switch (grade)
//        {
//            case 'A': return 4;
//            case 'B': return 3;
//            case 'C': return 2;
//            case 'D': return 1;
//            case 'F': return 0;
//            default: return 0;
//        }
//    }

//    // 学生不需要薪资计算，但需要实现接口
//    public override decimal CalculateSalary()
//    {
//        return 0; // 学生没有薪资
//    }
//}

//// Instructor类，继承自Person
//public class Instructor : Person, IInstructorService
//{
//    public DateTime JoinDate { get; set; }
//    public bool IsDepartmentHead { get; set; }
//    public decimal BaseSalary { get; set; }

//    // 计算工资，包含奖金
//    public override decimal CalculateSalary()
//    {
//        return BaseSalary + CalculateBonus();
//    }

//    // 计算奖金
//    public decimal CalculateBonus()
//    {
//        int yearsOfExperience = DateTime.Now.Year - JoinDate.Year;
//        return BaseSalary * (decimal)(0.05 * yearsOfExperience); // 每年5%的奖金
//    }

//    // 判断是否是系主任
//    public bool IsHeadOfDepartment()
//    {
//        return IsDepartmentHead;
//    }
//}

//// Course类
//public class Course
//{
//    public string CourseName { get; set; }
//    private List<Student> enrolledStudents = new List<Student>();

//    public List<Student> GetEnrolledStudents()
//    {
//        return enrolledStudents;
//    }

//    public void EnrollStudent(Student student)
//    {
//        enrolledStudents.Add(student);
//    }
//}

//// 测试程序
//class Program
//{
//    static void Main(string[] args)
//    {
//        // 创建Instructor
//        Instructor instructor = new Instructor
//        {
//            Name = "John Smith",
//            BirthDate = new DateTime(1980, 5, 20),
//            JoinDate = new DateTime(2010, 3, 15),
//            BaseSalary = 50000,
//            IsDepartmentHead = true
//        };

//        Console.WriteLine($"{instructor.Name} 年龄: {instructor.CalculateAge()}");
//        Console.WriteLine($"工资: {instructor.CalculateSalary()}");

//        // 创建Student
//        Student student = new Student
//        {
//            Name = "Alice Johnson",
//            BirthDate = new DateTime(2000, 8, 25)
//        };

//        student.EnrollInCourse(new Course { CourseName = "Math" });
//        student.EnrollInCourse(new Course { CourseName = "Physics" });

//        Console.WriteLine($"{student.Name} 年龄: {student.CalculateAge()}");
//        Console.WriteLine($"GPA: {student.CalculateGPA()}");
//    }
//}


using System;

class Color
{
    // 实例变量
    private int red;
    private int green;
    private int blue;
    private int alpha;

    // 构造函数（RGBA）
    public Color(int red, int green, int blue, int alpha)
    {
        this.red = red;
        this.green = green;
        this.blue = blue;
        this.alpha = alpha;
    }

    // 构造函数（RGB，默认alpha = 255）
    public Color(int red, int green, int blue)
        : this(red, green, blue, 255) // 调用另一个构造函数
    {
    }

    // 获取和设置颜色值
    public int GetRed() { return red; }
    public void SetRed(int red) { this.red = red; }

    public int GetGreen() { return green; }
    public void SetGreen(int green) { this.green = green; }

    public int GetBlue() { return blue; }
    public void SetBlue(int blue) { this.blue = blue; }

    public int GetAlpha() { return alpha; }
    public void SetAlpha(int alpha) { this.alpha = alpha; }

    // 计算灰度值
    public double GetGrayscale()
    {
        return (red + green + blue) / 3.0;
    }
}

class Ball
{
    // 实例变量
    private int size;
    private Color color;
    private int throwCount;

    // 构造函数
    public Ball(int size, Color color)
    {
        this.size = size;
        this.color = color;
        this.throwCount = 0; // 初始化抛出次数为0
    }

    // Pop方法，爆破球
    public void Pop()
    {
        size = 0;
    }

    // Throw方法，抛出球
    public void Throw()
    {
        if (size > 0) // 球没有被爆破时才能抛出
        {
            throwCount++;
        }
    }

    // 获取抛出次数
    public int GetThrowCount()
    {
        return throwCount;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // 创建几个球，指定颜色和大小
        Color redColor = new Color(255, 0, 0);
        Color greenColor = new Color(0, 255, 0);
        Ball ball1 = new Ball(10, redColor);
        Ball ball2 = new Ball(12, greenColor);

        // 抛掷球
        ball1.Throw();
        ball1.Throw();
        ball2.Throw();

        Console.WriteLine($"Ball 1 was thrown {ball1.GetThrowCount()} times.");
        Console.WriteLine($"Ball 2 was thrown {ball2.GetThrowCount()} times.");

        // 爆破第一个球
        ball1.Pop();

        // 尝试再次抛掷被爆破的球
        ball1.Throw();
        ball2.Throw();

        Console.WriteLine($"Ball 1 was thrown {ball1.GetThrowCount()} times after pop.");
        Console.WriteLine($"Ball 2 was thrown {ball2.GetThrowCount()} times after pop.");
    }
}


