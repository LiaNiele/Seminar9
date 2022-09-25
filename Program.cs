//запрос данных от пользователя
int ReadData(string line){     
    Console.Write(line);
    int num = int.Parse(Console.ReadLine()??"1");
    return num;
}

// вывод результата
void PrintData(string prefix, string num){   
    Console.WriteLine(prefix + num);
}



// Задача 64:Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// рекурсия от m до n
string NumMN(int m, int n){
    if(m>=n) return (n).ToString();
    else return m + ", " + NumMN(m+1,n);
}

int m = ReadData("Введите число M: ");
int n = ReadData("Введите число N: ");
string result = (m<n)? (NumMN(m,n)):(NumMN(n,m));

PrintData("Числа от M до N: ", result);



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//рекурсивный метод нахождения суммы элементов
int SumMN(int m, int n){
    if(m>=n) return n;
    else return m + SumMN(m+1,n); 
}

int m = ReadData("Введите число M: ");
int n = ReadData("Введите число N: ");
int sum = 0;
if(m<n) sum = SumMN(m,n);
else sum = SumMN(n,m);

PrintData("Сумма натуральных элементов в промежутке M до N равна: ", (sum).ToString());


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// рекурсивный метод вычисления функции Акермана
int Akkerman(int m,int n){
    if(m == 0) return n+1;
    if(m > 0 && n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m-1, Akkerman(m, n-1));
}

int m = ReadData("Введите число M: ");
int n = ReadData("Введите число N: ");

// проверка чисел на отрицательность
if(m<0 || n<0){
    Console.WriteLine("Введено отрицательное число");
}

string res = (Akkerman(m,n)).ToString();

PrintData($"Функция Аккермана для {m} и {n} равна: ", res);