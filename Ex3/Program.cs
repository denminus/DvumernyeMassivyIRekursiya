/*Здесь для вас открылась новая сущность — ситуация, при которой метод вызывает сам себя. В
математике (программирование — это частный случай математики) есть целая область, которая
занимается подобными случаями — рекуррентные соотношения. В программировании это просто
называется рекурсией.
Что такое рекурсия? Это функция, которая вызывает сама себя. Есть шутка: чтобы понять рекурсию,
нужно понять рекурсию. В ней подчёркивается суть явления. Пример с закраской картинки непростой,
поэтому давайте рассмотрим более тривиальный. Начнём с классической задачи математики —
вычисления факториала. В программировании решим её с помощью рекурсии. 

/*
int Factorial(int n)
{
 // 1! = 1
 // 0! = 1
 if(n == 1) return 1;
 else return n * Factorial(n-1);
}
for (int i = 1; i < 40; i++)
{
 Console.WriteLine($"{i}! = {Factorial(i)}");
}


double Factorial(int n)
{
 // 1! = 1
 // 0! = 1
 if(n == 1) return 1;
 else return n * Factorial(n-1);
}
for (int i = 1; i < 40; i++)
{
 Console.WriteLine($"{i}! = {Factorial(i)}");
}



int Fibonacci(int n)
{
 if(n == 1 || n == 2) return 1;
 else return Fibonacci(n-1) + Fibonacci(n-2);
}
for (int i = 1; i < 10; i++)
{
 Console.WriteLine(Fibonacci(i));
}


double Fibonacci(int n)
{
 if(n == 1 || n == 2) return 1;
 else return Fibonacci(n-1) + Fibonacci(n-2);
}
for (int i = 1; i < 50; i++)
{
 Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}
*/
