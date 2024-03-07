//7- kullanıcıdan öğrenci sayısını isteyen her öğrenci için öğrenci adı,öğrenci soyadı,
//1.sınav notu,2.sınav notu,3.sınav notu isteyen ve daha sonra not
//ortalamasını hesaplayıp ekrana yazdıran algoritma yapınız.

Console.WriteLine("öğrenci sayısını giriniz: ");
int numberOfStudents = Convert.ToInt32(Console.ReadLine());
string studentName, studentSurname;
int firstExam = 0, secondExam = 0, thirdExam = 0, gradeAverage;


    for (int i = 0; i < numberOfStudents; i++)
    {
        Console.WriteLine("öğrenci adını giriniz: ");
        studentName = Console.ReadLine();
        Console.WriteLine("öğrenci soyadını giriniz: ");
        studentSurname = Console.ReadLine();
        //exams
        Console.WriteLine("1. sınav notunu giriniz");
        firstExam = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("2. sınav notunu giriniz");
        secondExam = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("3. sınav notunu giriniz");
        thirdExam = Convert.ToInt32(Console.ReadLine());

        gradeAverage = (firstExam + secondExam + thirdExam) / 3;
        Console.WriteLine(studentName + studentSurname + " not ortalaması :" + gradeAverage);
    } 