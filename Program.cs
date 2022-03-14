using System;

namespace U
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            QuestA47();

        }
        static int AddTwoNumbers(int x, int y)
        {
            // метод для сложения двух чисел
            int result = x + y;
            Console.WriteLine("{0} + {1} = {2}", x, y, result);
            return result;
        }

        static void TypeMassage(string massage)
        {
            massage = massage + "!!!";
            Console.WriteLine(massage);
        }
        // метод определяем максимальное значение в массиве
        static int GetMaxValue(int[] intArray)
        {
            Array.Sort(intArray);
            return intArray[intArray.Length - 1];
        }
        static void Quest22()
        {
            //S 2.2 Дана сторона квадрата. Найдите его периметр.
            Console.WriteLine("Введите сторону квадрата:");
            string y = Console.ReadLine();
            double x = Convert.ToDouble(y);
            if (x > 0)
            {
                Console.WriteLine("Периметр квадрата равен {0}", x * 4);
            }
            else
            {
                Console.WriteLine("Введенное значение вне диапазона, программа закрывается");
                Console.ReadKey();
            }
        }
        static void Quest24()
        {
            //S 2.4 Считая, что Земля - идеальная сфера с радиусом R = 6350 км,
            //определите расстояние до линии горизонта от точки B с заданной высотой h=AB над Землей.
            const double r = 6350;
            Console.WriteLine("Введите высоту на которой находится точка B");
            double doubleB = Convert.ToDouble(Console.ReadLine());
            double bG = Math.Sqrt((Math.Pow((r + doubleB), 2) - Math.Pow(r, 2)));
            Console.WriteLine("Расстояние от точки B до горизонта равно {0} км", bG);
        }
        static void Quest25()
        {
            //S 2.5 Дана длинна ребра кубу. Найти объем куда и площадь его боковой поверхности.
            Console.WriteLine("Введите длинну ребра куба");
            double edgeOfCube = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Объем куба равен {0}, ", Math.Pow(edgeOfCube, 3));
            Console.WriteLine("Площадь поверхности куба равна {0}", Math.Pow(edgeOfCube, 2) * 6);
        }
        static void Quest26()
        {
            //S 2.6 Дан радиус окружности. Найти длинну окружности и площадь круга.
            Console.WriteLine("Введите радиус окружности");
            double radius = Convert.ToDouble(Console.ReadLine());
            const double Pi = 3.14159;
            Console.WriteLine("Длинна окружности равна {0}", 2 * Pi * radius);
            Console.WriteLine("Площадь круга равноа {0}", Pi * Math.Pow(radius, 2));
        }
        static void Quest27()
        {
            //S 2.7 Даны два числа. Найти а) их среднее арифмитическое б) их среднее геометрическое.
            Console.WriteLine("Введите два числа");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Среднее арифмитическое равно {0}", (firstNumber + secondNumber) / 2);
            Console.WriteLine("Среднее геометрическое равно {0}", Math.Sqrt(firstNumber + secondNumber));
        }
        static void Quest28()
        {
            //S 2.8 Известны объем и масса тела. Определить плотность материала этого тела.
            Console.WriteLine("Введите объем (м^3) и массу (кг) тела");
            double valume = Convert.ToDouble(Console.ReadLine());
            double mass = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Плотность вещества равна {0}", mass / valume);
        }
        static void Quest29()
        {
            // S 2.9 Известны колличество жителей и площадь государства, найдите плотность населения
            Console.WriteLine("Введите площадь страны (м^2) и колличество населения страны");
            double areaCoutry = Convert.ToDouble(Console.ReadLine());
            double allPeople = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Плотность населения равна {0}", allPeople / areaCoutry);
        }
        static void Quest210()
        {
            // S 2.10 Составить программу для решения линейного уравнения ax+b=0(a !=0).
            Console.WriteLine("Программа для решения уравнения ax+b=0 где a != 0 \n Введите значение для a != 0");
            double aNumber = Convert.ToDouble(Console.ReadLine());
            while (aNumber == 0)
            {
                Console.WriteLine("a = 0, попробуйте еще раз");
                aNumber = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Введите значение любой значение для b");
            double bNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x равно {0} ", -bNumber / aNumber);
        }
        static void Quest211()
        {
            //S 2.11 Даны катеты прямоугольного треугольника. Найти его гипотенузу.
            Console.WriteLine("Введите значения катетов:");
            double sideFirst = Convert.ToDouble(Console.ReadLine());
            double sideSecond = Convert.ToDouble(Console.ReadLine());
            double sideThird = Math.Sqrt(Math.Pow(sideFirst, 2) + Math.Pow(sideSecond, 2));
            Console.WriteLine("Гипотенуза данного треугольника равна: {0}", sideThird);
        }
        static void Quest212()
        {
            // S2.12. Найти площадь кольца по заданным внешнему и внутреннему радиусам.
            const double Pi = 3.14159;
            Console.WriteLine("Введите сначала внешний затем внутренний радиус кольца:");
            double innerRadius = Convert.ToDouble(Console.ReadLine());
            double externalRadius = Convert.ToDouble(Console.ReadLine());
            double ringArea = Pi * Math.Pow(externalRadius, 2) - Pi * Math.Pow(innerRadius, 2);
            Console.WriteLine("Площадь кольца равна {0}", ringArea);
        }
        static void Quest213()
        {
            //S 2.13.  Даны катеты прямоугольного треугольника. Найти его периметр.
            Console.WriteLine("Введите значения катетов:");
            double firstSide = Convert.ToDouble(Console.ReadLine());
            double secondSide = Convert.ToDouble(Console.ReadLine());
            double thirdSide = Math.Sqrt(Math.Pow(firstSide, 2) + Math.Pow(secondSide, 2));
            double perimeter = firstSide + secondSide + thirdSide;
            Console.WriteLine("Периметр треугольнка равен: {0}", perimeter);
        }
        static void Quest213A()
        {
            //S 2.13А. Даны два числа. Найти среднее арифметическое и среднее геометрическое их  модулей.
            Console.WriteLine("Введите два числа");
            double firstNumber = Math.Abs(Convert.ToDouble(Console.ReadLine()));
            double secondNumber = Math.Abs(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Среднее арифмитическое модулей равно {0}", (firstNumber + secondNumber) / 2);
            Console.WriteLine("Среднее геометрическое модулей равно {0}", Math.Sqrt(firstNumber + secondNumber));
        }
        static void Quest214()
        {
            //S 2.14. Даны основания и высота равнобедренной трапеции. Найти ее периметр.
            Console.WriteLine("Введите последовательно основания и высоту трапеции");
            double upSide = Convert.ToDouble(Console.ReadLine());
            double downSide = Convert.ToDouble(Console.ReadLine());
            double heightTrapezoid = Convert.ToDouble(Console.ReadLine());
            double perimetr = Math.Sqrt(Math.Pow(Math.Abs(upSide - downSide) / 2, 2) + Math.Pow(heightTrapezoid, 2)) * 2 + upSide + downSide;
            Console.WriteLine("Периметр трапеции с введенными параметрами равен {0}", perimetr);
        }
        static void Quest214A()
        {
            //S 2.14А. Даны стороны прямоугольника. Найти его периметр и длину диагонали.
            Console.WriteLine("Введите по очереди стороны прямоугольника");
            double firstSide = Convert.ToDouble(Console.ReadLine());
            double secondSide = Convert.ToDouble(Console.ReadLine());
            double diagonal = Math.Sqrt(Math.Pow(firstSide, 2) + Math.Pow(secondSide, 2));
            Console.WriteLine("Периметр равен {0} , \n Диагональ равна {1}", (firstSide + secondSide) * 2, diagonal);
        }
        static void Quest215()
        {
            //S 2.15. Даны два числа. Найти их сумму, разность, произведение, а также частное от деления первого числа на второе.
            Console.WriteLine("Введите последовательно два числа");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Сумма чисел равна {0}", firstNumber + secondNumber);
            Console.WriteLine("Разность чисел равна {0}", firstNumber - secondNumber);
            Console.WriteLine("произведение чисел равна {0}", firstNumber * secondNumber);
            Console.WriteLine("Частное от деление чисел равна {0}", firstNumber % secondNumber);
        }
        static void Quest216()
        {
            //S 2.16. Даны длины сторон прямоугольного параллелепипеда. Найти его объем и площадь боковой поверхности.
            Console.WriteLine("Введите последовательно длинну, ширину и высоту паралелепипеда");
            double lengthP = Convert.ToDouble(Console.ReadLine());
            double widthP = Convert.ToDouble(Console.ReadLine());
            double hightP = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Объем равен{0}", lengthP * widthP * hightP);
            Console.WriteLine("площадь боковой поверности равна " + lengthP * hightP * 2 + widthP * hightP * 2);
        }
        static void Quest217()
        {
            //S 2.17. Известны координаты на плоскости двух точек. Составить программу вычисления расстояния между ними.
            Console.WriteLine("Введите последовательно координаты точек по осям x и y");
            double xFirstPoint = Convert.ToDouble(Console.ReadLine());
            double yFirstPoint = Convert.ToDouble(Console.ReadLine());
            double xSecondPoint = Convert.ToDouble(Console.ReadLine());
            double ySecondPoint = Convert.ToDouble(Console.ReadLine());
            double xSide = Math.Sqrt(Math.Pow(xFirstPoint, 2) + Math.Pow(xSecondPoint, 2));
            double ySide = Math.Sqrt(Math.Pow(yFirstPoint, 2) + Math.Pow(ySecondPoint, 2));
            Console.WriteLine("Расстояние между точками равно {0}", Math.Sqrt(Math.Pow(xSide, 2) + Math.Pow(ySide, 2)));
        }
        static void Quest218()
        {
            //S 2.18. Даны основания и высота равнобедренной трапеции. Найти периметр трапеции.
            Console.WriteLine("Введите последовательно большее, меньшее основания и высоту");
            double bigSide = Convert.ToDouble(Console.ReadLine());
            double smallSide = Convert.ToDouble(Console.ReadLine());
            double height = Convert.ToDouble(Console.ReadLine());
            double frontSide = Math.Sqrt(Math.Pow(height, 2) + Math.Pow(((bigSide - smallSide) / 2), 2));
            Console.WriteLine("Периметр трапеции равен {0}", frontSide * 2 + bigSide + smallSide);
        }
        static void Quest219()
        {
            //S 2.19. Даны основания равнобедренной трапеции и угол при большем основании. Найти площадь трапеции.
            Console.WriteLine("Введите последовательно большее, меньшее основания и угол при большем основании");
            double bigSide = Convert.ToDouble(Console.ReadLine());
            double smallSide = Convert.ToDouble(Console.ReadLine());
            double corner = Convert.ToDouble(Console.ReadLine());
            double height = ((bigSide - smallSide) / 2) / Math.Cos(corner);
            Console.WriteLine("Площадь равна {0}", (bigSide + smallSide) * height / 2);
        }
        static void Quest220()
        {
            //S 2.20. Треугольник задан координатами своих вершин. Найти периметр и площадь треугольника.
            Console.WriteLine("Введите последовательно координаты точек по осям x и y");
            double xAPoint = Convert.ToDouble(Console.ReadLine());
            double yAPoint = Convert.ToDouble(Console.ReadLine());
            double xBPoint = Convert.ToDouble(Console.ReadLine());
            double yBPoint = Convert.ToDouble(Console.ReadLine());
            double xCPoint = Convert.ToDouble(Console.ReadLine());
            double yCPoint = Convert.ToDouble(Console.ReadLine());
            // Расчет сторон
            double sideAB = FrontSideSize(xAPoint, xBPoint, yAPoint, yBPoint);
            double sideBC = FrontSideSize(xBPoint, xCPoint, yBPoint, yCPoint);
            double sideAC = FrontSideSize(xAPoint, xCPoint, yAPoint, yCPoint);
            //Расчет площади треугольника по формуле Герона
            double halhPerimeter = (sideAB + sideAC + sideBC) / 2;
            double areaTriangle = Math.Sqrt(halhPerimeter * (halhPerimeter - sideAB) * (halhPerimeter - sideAC) * (halhPerimeter - sideBC));
            Console.WriteLine("Периметр равен {0}, и площадь равна {1}", sideBC + sideAC + sideAB, areaTriangle);
        }
        static void Quest221()
        {
            //S 2.21. Выпуклый четырехугольник задан координатами своих вершин. Найти площадь этого четырехугольника как сумму площадей треугольников.
            Console.WriteLine("Введите последовательно координаты точек по осям x и y");
            double xAPoint = Convert.ToDouble(Console.ReadLine());
            double yAPoint = Convert.ToDouble(Console.ReadLine());
            double xBPoint = Convert.ToDouble(Console.ReadLine());
            double yBPoint = Convert.ToDouble(Console.ReadLine());
            double xCPoint = Convert.ToDouble(Console.ReadLine());
            double yCPoint = Convert.ToDouble(Console.ReadLine());
            double xDPoint = Convert.ToDouble(Console.ReadLine());
            double yDPoint = Convert.ToDouble(Console.ReadLine());
            // Расчет сторон
            double sideAB = FrontSideSize(xAPoint, xBPoint, yAPoint, yBPoint);
            double sideBC = FrontSideSize(xCPoint, xBPoint, yCPoint, yBPoint);
            double sideAC = FrontSideSize(xAPoint, xCPoint, yAPoint, yCPoint);
            double sideDC = FrontSideSize(xDPoint, xCPoint, yDPoint, yCPoint);
            double sideAD = FrontSideSize(xAPoint, xDPoint, yAPoint, yDPoint);
            //Расчет площади треугольников по формуле Герона
            double halhPerimeter = (sideAB + sideAC + sideBC) / 2;
            double areaFirstTriangle = Math.Sqrt(halhPerimeter * (halhPerimeter - sideAB) * (halhPerimeter - sideAC) * (halhPerimeter - sideBC));
            halhPerimeter = (sideAD + sideAC + sideDC) / 2;
            double areaSecondTriangle = Math.Sqrt(halhPerimeter * (halhPerimeter - sideAB) * (halhPerimeter - sideAC) * (halhPerimeter - sideBC));
            Console.WriteLine("Пплощадь равна {0}", areaFirstTriangle + areaSecondTriangle);
        }
        static double FrontSideSize(double xFirstPoint, double yFirstPoint, double xSecondPoint, double ySecondPoint)
        {
            //Метод для расчета стороны дял задачи 2.20 и 2.21
            double xSide = Math.Sqrt(Math.Pow(xFirstPoint, 2) + Math.Pow(xSecondPoint, 2));
            double ySide = Math.Sqrt(Math.Pow(yFirstPoint, 2) + Math.Pow(ySecondPoint, 2));
            double side = Math.Sqrt(Math.Pow(xSide, 2) + Math.Pow(ySide, 2));
            return side;
        }
        static void Quest222()
        {
            //S 2.22. Известна стоимость 1 кг конфет, печенья и яблок. Найти стоимость всей покупки, если купили x кг конфет, у кг печенья и z кг яблок.
            Console.WriteLine("Введите стоимость конфет, печеья и яблок за кг, и вес каждого пункта покупки");
            double priceCandies = Convert.ToDouble(Console.ReadLine());
            double priceCookies = Convert.ToDouble(Console.ReadLine());
            double priceApples = Convert.ToDouble(Console.ReadLine());
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Стоимость всей покупки равна {0}", priceCandies * x + priceCookies * y + priceApples * z);
        }
        static void Quest223()
        {
            //S 2.23. Известна стоимость монитора, системного блока, клавиатуры и мыши. Сколько будут стоить 3 компьютера из этих элементов? N компьютеров?
            Console.WriteLine("Введите стоимость стоимость монитора, системного блока, клавиатуры и мыши. И необходимого количества компьютеров");
            double priceScreen = Convert.ToDouble(Console.ReadLine());
            double priceSystemUnit = Convert.ToDouble(Console.ReadLine());
            double priceKeyboard = Convert.ToDouble(Console.ReadLine());
            double priceMouse = Convert.ToDouble(Console.ReadLine());
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Стоимость трех компьютеров равна {0}", (priceKeyboard + priceMouse + priceScreen + priceSystemUnit) * 3);
            Console.WriteLine("Стоимость N компьютеров равна {0}", (priceKeyboard + priceMouse + priceScreen + priceSystemUnit) * n);
        }
        static void Quest224()
        {
            //S 2.24. Возраст Тани — X лет, а возраст Мити — Y лет. Найти их средний возраст, а также определить, 
            //на сколько отличается возраст каждого ребенка от среднего значения. 
            Console.WriteLine("Введите возраст Тани и Мити");
            double ageTanya = Convert.ToDouble(Console.ReadLine());
            double ageMetya = Convert.ToDouble(Console.ReadLine());
            double avarageAge = (ageMetya + ageTanya) / 2;
            Console.WriteLine("Средний возраст равен {0}", avarageAge);
            Console.WriteLine("Разница возраста Тани и среднего возраста {0}", Math.Abs(ageTanya - avarageAge));
            Console.WriteLine("Разница возраста Мити и среднего возраста {0}", Math.Abs(ageMetya - avarageAge));
        }
        static void Quest225()
        {
            //S 2.25. Два автомобиля едут навстречу друг другу с постоянными скоростями V1 и  V2 км/час.
            // Определить, через какое время автомобили встретятся, если расстояние между ними было S км.
            Console.WriteLine("Введите скорость (км/ч) каждого автомобиля и изначальное расстояние (км) между ними");
            double firstCarSpeed = Convert.ToDouble(Console.ReadLine());
            double secondCarSpeed = Convert.ToDouble(Console.ReadLine());
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Время (ч) через которое они встретятся равно {0}", distance / (firstCarSpeed + secondCarSpeed));
        }
        static void Quest226()
        {
            //S 2.26. Два автомобиля едут друг за другом с постоянными скоростями V1 и  V2 км/час (V1>V2). 
            //Определить, какое расстояние будет между ними через 30 минут после того, как первый автомобиль опередил второй на S км.
            Console.WriteLine("Введите скорость (км/ч) каждого автомобиля V1 > V2 \n и расстояние (км) между ними");
            double firstCarSpeed = Convert.ToDouble(Console.ReadLine());
            double secondCarSpeed = Convert.ToDouble(Console.ReadLine());
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Расстояние между ними через пол часа после обгона {0}", 0.5 * (firstCarSpeed - secondCarSpeed));
        }
        static void Quest227()
        {
            //S2.27. Известно значение температуры по шкале Цельсия. Найти соответствующее  значение температуры по шкале: 
            //а) Фаренгейта; б) Кельвина. Для пересчета по шкале Фаренгейта необходимо исходное значение температуры умножить 
            //на 1,8 и к результату прибавить 32, а по шкале Кельвина абсолютное значение нуля соответствует 273,15 градуса по шкале Цельсия.
            Console.WriteLine("Температуру по шкале Цельсия");
            double teperatureCelsius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Температура по шкале Фаренгейта равна {0}", (teperatureCelsius * 1.8) + 32);
            Console.WriteLine("Температура по шкале Кельвина равна {0}", teperatureCelsius + 273.15);
        }
        static void Quest228()
        {
            //S2.28. У американского писателя-фантаста Рэя Бредбери есть роман «450 градусов  по Фаренгейту». 
            //Какой температуре по шкале Цельсия соответствует указанное в названии значение?
            Console.WriteLine("Температуру 450 градусов п офаренгейту соответствует {0} градусов цельсия", (450 - 32) / 1.8);
        }
        static void Quest31()
        {
            //S3.1 Составить программу обмена значениями двух переменных величин.
            double c;
            Console.WriteLine("Введите значение для переменных");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            c = a;
            a = b;
            b = c;
            Console.WriteLine("Числа после обмена значений a = {0} b = {1}", a, b);
        }
        static void Quest32()
        {
            //S3.2. Cоставить программу обмена значениями трех переменных величин а, b, c по
            //следующим двум схемам:
            //а) b присвоить значение c, а присвоить значение b, с присвоить значение а;
            //б) b присвоить значение а, с присвоить значение b, а присвоить значение с.
            double d;
            Console.WriteLine("Введите значение для переменных");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            d = c;
            c = a;
            a = b;
            b = d;
            Console.WriteLine(" а) Числа после обмена значений a = {0} b = {1} c = {2}", a, b, c);
            d = a;
            a = c;
            c = b;
            b = d;
            Console.WriteLine(" б) Числа после обмена значений a = {0} b = {1} c = {2}", a, b, c);
        }
        static void Quest33()
        {
            //S3.3. Дано вещественное число а. Пользуясь только операцией умножения, получить:
            //а) a4 за две операции;
            //б) a6  за три операции;
            //в) a7 за четыре операции;
            //г) a8  за три операции;
            //д) a9 за четыре операции;
            //е) a10  за четыре операции.
            Console.WriteLine("Введите вещественное число a");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = a * a;
            double c = b * b;
            Console.WriteLine("a) {0}", b * b);
            Console.WriteLine("б) {0}", b * b * b);
            Console.WriteLine("в) {0}", b * b * b * a);
            Console.WriteLine("г) {0}", c * c);
            Console.WriteLine("д) {0}", c * c * a);
            Console.WriteLine("е) {0}", c * c * b);
        }
        static void Quest34()
        {
            //S3.4. Дано вещественное число a. Пользуясь только операцией умножения, получить:
            //а) a3 и a10 за четыре операции;
            //б) a4 и a20 за пять операций;
            //в) a5 и a13 за пять операций;
            //г) a5 и a19 за пять операций;
            //д) a2, a5 и a17 за шесть операций;
            //е) a4, a12 и a28 за шесть операций.
            Console.WriteLine("Введите вещественное число a");
            double a = Convert.ToDouble(Console.ReadLine());
            double a2 = a * a;
            double a3 = a * a * a;
            double a4 = a2 * a2;
            double a8 = a4 * a4;
            Console.WriteLine("a) a^3 = {0}, a^10 = {1}", a * a * a * 1 * 1, a4 * a4 * a2);
            Console.WriteLine("б) a^4 = {0}, a^20 = {1}", a * a * a * a * 1 * 1, a8 * a8 * a4);
            Console.WriteLine("в) a^5 = {0}, a^13 = {1}", a * a * a * a * a * 1, a8 * a4 * 1);
            Console.WriteLine("г) a^5 = {0}, a^19 = {1}", a * a * a * a * a * 1, a8 * a8 * a3);
            Console.WriteLine("д) a^2 = {0}, a^5 = {1}, a^17 = {2}", a * a * 1 * 1 * 1 * 1 * 1, a * a * a * a * a * 1 * 1, a8 * a8 * 1 * 1);
            Console.WriteLine("е) a^4 = {0}, a^12 = {1}, a^28 = {2}", a * a * a * a * 1 * 1 * 1, a4 * a8 * 1 * 1, a8 * a8 * a8 * a4);
        }
        static void Quest35()
        {
            //S3.5. Чему будет равно 10^10 по Вашему алгоритму?
            Console.WriteLine("10^10 равно = ", Math.Pow(10, 10));
        }
        static void QuestA11()
        {
            //A1.1. Дано расстояние в сантиметрах. Найти число полных метров в нем.
            Console.WriteLine("Введите расстояние в сантиметрах");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Число полных метров {0}", distance / 100);
        }
        static void QuestA12()
        {
            //A1.2. Дана масса в килограммах. Найти число полных центнеров в ней.
            Console.WriteLine("Введите массу в килограммах");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Число полных центнеров {0}", weight / 100);
        }
        static void QuestA13()
        {
            //A1.3. Дана масса в килограммах. Найти число полных тонн в ней.
            Console.WriteLine("Введите масса в килограммах");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Число полных тонн {0}", weight / 1000);
        }
        static void QuestA14()
        {
            //A1.4. Дано расстояние в метрах. Найти число полных километров в нем.
            Console.WriteLine("Введите расстояние в метрах");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Число полных километров {0}", distance / 1000);
        }
        static void QuestA15()
        {
            //A1.5. С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?            
            Console.WriteLine("Полных недель по прошествию 234 дней прошло : {0}", 234 / 7);
        }
        static void QuestA16()
        {
            //A1.6. С начала суток прошло n секунд. Определить:
            //а) сколько полных часов прошло с начала суток;
            //б) сколько полных минут прошло с начала очередного часа;
            //в) сколько полных секунд прошло с начала очередной минуты.
            Console.WriteLine("Введите последовательно колличество секунд и вариант вопроса :");
            double second = Convert.ToDouble(Console.ReadLine());
            const double minSecondsInDay = 0;        // Нижняя граница допустимых значений
            double maxSecondinDay = double.MaxValue; // Верхняя граница допустимых значений
            if (minSecondsInDay <= second && second <= maxSecondinDay)
            {
                char question = Convert.ToChar(Console.ReadLine());
                question = char.ToLower(question);
                if (question == 'а')
                {
                    Console.WriteLine("Ответ на вариант (а): {0}", Math.Truncate(second / 3600));
                }
                else
                {
                    if (question == 'б')
                    {
                        Console.WriteLine("Ответ на вариант (б) : {0}", Math.Truncate((second / 60) % 60));
                    }
                    else
                    {
                        if (question == 'в')
                        {
                            Console.WriteLine("Ответ на вариант (в) : {0}", Math.Truncate(second % 60));
                        }
                        else
                        {
                            Console.WriteLine("Введен вариант вне диапазона");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Введен вариант вне диапазона");
            }
        }
        static void QuestA17()
        {
            //A1.7. Дан прямоугольник с размерами 543 х 130 мм. Сколько квадратов со стороной 130 мм можно отрезать от него?
            double theBigSide = 543;
            Console.WriteLine("Получится квадратов со стороной 130мм : {0} шт.", Math.Truncate(theBigSide / 130));
        }
        static void QuestA18()
        {
            //A1.8. Дано целое число k (1 <= k <= 365). Присвоить целочисленной величине n значение 1, 2, …, 6 или 0 в зависимости от того, на какой день недели 
            // (понедельник, вторник, …, субботу или воскресенье) приходится k-й день года, в котором 1 января:
            //а) понедельник;
            //б) вторник;
            //в) d-й день недели (если 1 января — понедельник, то d=1, если вторник — d=2, …, если воскресенье — d=7).
            Console.WriteLine("Введите последовательно целое число k и вариант вопроса :");
            int numberOfDay = Convert.ToUInt16(Console.ReadLine());
            int n;
            int minDayInYear = 1;
            int maxDayInYear = 365;
            if (minDayInYear <= numberOfDay && numberOfDay <= maxDayInYear) // Верхняя и нижняя граница по колличеству дней в году
            {
                char question = Convert.ToChar(Console.ReadLine());
                question = char.ToLower(question);
                switch (question)
                {
                    case 'а':
                        Console.WriteLine("Ответ на вариант (а): n = {0}", n = numberOfDay % 7);
                        break;
                    case 'б':
                        Console.WriteLine("Ответ на вариант (б) : n = {0}", n = (numberOfDay + 1) % 7);
                        break;
                    case 'в':
                        if ((n = numberOfDay % 7) == 0)
                        {
                            Console.WriteLine("Ответ на вариант (в) : n =  {0}", 7);
                        }
                        else
                        {
                            Console.WriteLine("Ответ на вариант (в): n = {0}", n = numberOfDay % 7);
                        }
                        break;
                    default:
                        Console.WriteLine("Введен вариант вне диапазона");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Введен вариант вне диапазона");
            }
        }
        static void QuestA19()
        {
            //A1.9. С начала 2020 года по некоторый день прошло n месяцев и 2 дня. Присвоить целочисленной величине x значение 1, 2, …, 11 или 12 в зависимости от того, каким месяцем 
            // (январем, февралем и т.п.) является месяц этого дня. Например, при n=3 значение х равно 4.
            Console.WriteLine("Введите целочисленное значение n в пределах от 1 до 12");
            byte numberOfMonth = Convert.ToByte(Console.ReadLine());
            if (numberOfMonth == 12)
            {
                Console.WriteLine("Значения x для вашего варианта : {0}", 1); //Выводит значения равное Январю если пользователь ввел Декабрь
            }
            else
            {
                Console.WriteLine("Значения x для вашего варианта : {0}", numberOfMonth + 1);
            }
        }
        static void QuestA21()
        {
            //A2.1. Дано двузначное число. Найти: а) число десятков в нем; б) число единиц в нем; в) сумму его цифр; г) произведение его цифр.
            Console.WriteLine("Введите двухзначное целое число и вариант вопроса");
            sbyte twoDigitNumber = Convert.ToSByte(Console.ReadLine());
            char question = Convert.ToChar(Console.ReadLine());
            question = char.ToLower(question);
            switch (question)
            {
                case 'а':
                    Console.WriteLine("Ответ на вариант (а) : {0}", twoDigitNumber / 10);
                    break;
                case 'б':
                    Console.WriteLine("Ответ на вариант (б) : {0}", twoDigitNumber % 10);
                    break;
                case 'в':
                    Console.WriteLine("Ответ на вариант (в) : {0}", (twoDigitNumber / 10) + (twoDigitNumber % 10));
                    break;
                case 'г':
                    Console.WriteLine("Ответ на вариант (г) : {0}", (twoDigitNumber / 10) * (twoDigitNumber % 10));
                    break;
                default:
                    Console.WriteLine("Введен вариант вне диапазона");
                    break;
            }
        }
        static void QuestA22()
        {
            //A2.2. Дано двузначное число. Получить число, образованное при перестановке цифр заданного числа.
            Console.WriteLine("Введите двухзначное целое число и вариант вопроса");
            byte twoDigitNumber = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Число после перестановки: {0}{1}", twoDigitNumber % 10, twoDigitNumber / 10);
        }
        static void QuestA23()
        {
            //A2.3. Дано трехзначное число. Найти: а) число единиц в нем; б) число десятков в нем; в) сумму его цифр; г) произведение его цифр.
            Console.WriteLine("Введите трехзначное целое число и вариант вопроса");
            int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
            char question = Convert.ToChar(Console.ReadLine());
            question = char.ToLower(question);
            if (100 <= threeDigitNumber && threeDigitNumber <= 999)
            {
                switch (question)
                {
                    case 'а':
                        Console.WriteLine("Ответ на вариант (а) : {0}", threeDigitNumber % 10);
                        break;
                    case 'б':
                        Console.WriteLine("Ответ на вариант (б) : {0}", (threeDigitNumber % 100) / 10);
                        break;
                    case 'в':
                        Console.WriteLine("Ответ на вариант (в) : {0}", (threeDigitNumber / 100) + (threeDigitNumber % 10) + ((threeDigitNumber % 100) / 10));
                        break;
                    case 'г':
                        Console.WriteLine("Ответ на вариант (г) : {0}", (threeDigitNumber / 100) * (threeDigitNumber % 10) * ((threeDigitNumber % 100) / 10));
                        break;
                    default:
                        Console.WriteLine("Введен вариант вне диапазона");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Введен вариант вне диапазона, для завершения программы нажмите на любую клавишу.");
                Console.ReadKey();
            }
        }
        static void QuestA24()
        {
            //A2.4. Дано трехзначное число. Найти число, полученное при прочтении его цифр справа налево.
            Console.WriteLine("Введите трехзначное число");
            int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
            if (100 <= threeDigitNumber && threeDigitNumber <= 999)
            {
                int firstNumber = threeDigitNumber / 100;
                int secondNumber = ((threeDigitNumber % 100) / 10) * 10;
                int threeNuber = (threeDigitNumber % 10) * 100;
                int expandedNumber = firstNumber + secondNumber + threeNuber;
                Console.WriteLine("Измененное число {0}", expandedNumber);
            }
            else
            {
                Console.WriteLine("Введен вариант вне диапазона, для завершения программы нажмите на любую клавишу.");
                Console.ReadKey();
            }
        }
        static void QuestA25()
        {
            //A2.5. Дано трехзначное число. В нем зачеркнули первую слева цифру и приписали ее в конце. Найти полученное число.
            Console.WriteLine("Введите трехзначное число");
            int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
            if (100 <= threeDigitNumber && threeDigitNumber <= 999)
            {
                int firstNumber = threeDigitNumber / 100;
                int secondNumber = ((threeDigitNumber % 100) / 10) * 100;
                int threeNuber = (threeDigitNumber % 10) * 10;
                int modifiedNumber = firstNumber + secondNumber + threeNuber;
                Console.WriteLine("измененное число {0}", modifiedNumber);
            }
            else
            {
                Console.WriteLine("Введен вариант вне диапазона, для завершения программы нажмите на любую клавишу.");
                Console.ReadKey();
            }

        }
        static void QuestA26()
        {
            //A2.6. Дано трехзначное число. В нем зачеркнули последнюю справа цифру и приписали ее в начале. Найти полученное число.
            Console.WriteLine("Введите трехзначное число");
            int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
            if (100 <= threeDigitNumber && threeDigitNumber <= 999)
            {
                int firstNumber = threeDigitNumber / 100 * 10;
                int secondNumber = (threeDigitNumber % 100) / 10;
                int threeNuber = (threeDigitNumber % 10) * 100;
                int modifiedNumber = firstNumber + secondNumber + threeNuber;
                Console.WriteLine("измененное число {0}", modifiedNumber);
            }
            else
            {
                Console.WriteLine("Введен вариант вне диапазона, для завершения программы нажмите на любую клавишу.");
                Console.ReadKey();
            }

        }
        static void QuestA27()
        {
            //A2.7. Дано трехзначное число. Найти число, полученное при перестановке первой и второй цифр заданного числа.
            Console.WriteLine("Введите трехзначное число");
            int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
            if (100 <= threeDigitNumber && threeDigitNumber <= 999)
            {
                int firstNumber = threeDigitNumber / 100 * 10;
                int secondNumber = ((threeDigitNumber % 100) / 10) * 100;
                int threeNuber = threeDigitNumber % 10;
                int modifiedNumber = firstNumber + secondNumber + threeNuber;
                Console.WriteLine("Измененное число {0}", modifiedNumber);
            }
            else
            {
                Console.WriteLine("Введен вариант вне диапазона, для завершения программы нажмите на любую клавишу.");
                Console.ReadKey();
            }
        }
        static void QuestA28()
        {
            //A2.8. Дано трехзначное число. Найти число, полученное при перестановке второй и третьей цифр заданного числа.
            Console.WriteLine("Введите трехзначное число");
            int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
            if (100 <= threeDigitNumber && threeDigitNumber <= 999)
            {
                int firstNumber = threeDigitNumber / 100 * 100;
                int secondNumber = (threeDigitNumber % 100) / 10;
                int threeNuber = (threeDigitNumber % 10) * 10;
                int modifiedNumber = firstNumber + secondNumber + threeNuber;
                Console.WriteLine("Измененное число {0}", modifiedNumber);
            }
            else
            {
                Console.WriteLine("Введен вариант вне диапазона, для завершения программы нажмите на любую клавишу.");
                Console.ReadKey();
            }
        }
        static int CalculationA29(int firstNumber, int secondNumber, int threeNuber)
        {
            int firstModifiedNumber = firstNumber + secondNumber + threeNuber;
            return firstModifiedNumber;
        }
        static void QuestA29()
        {
            //A2.9. Дано трехзначное число, в котором все цифры различны. Получить шесть чисел, образованных при перестановке цифр заданного числа.
            Console.WriteLine("Введите трехзначное число в котором все цифры различны");
            int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
            if (100 <= threeDigitNumber && threeDigitNumber <= 999)
            {
                int firstNumber = threeDigitNumber / 100 * 100;
                int secondNumber = (threeDigitNumber % 100) / 10;
                int threeNuber = (threeDigitNumber % 10) * 10;
                Console.WriteLine("Первое измененное число {0}", CalculationA29(firstNumber, secondNumber, threeNuber));
                firstNumber = (threeDigitNumber / 100) * 10;
                secondNumber = ((threeDigitNumber % 100) / 10) * 100;
                threeNuber = threeDigitNumber % 10;
                Console.WriteLine("Второе измененное число {0}", CalculationA29(firstNumber, secondNumber, threeNuber));
                firstNumber = threeDigitNumber / 100;
                secondNumber = ((threeDigitNumber % 100) / 10) * 10;
                threeNuber = (threeDigitNumber % 10) * 100;
                Console.WriteLine("Третье измененное число {0}", CalculationA29(firstNumber, secondNumber, threeNuber));
                firstNumber = threeDigitNumber / 100;
                secondNumber = ((threeDigitNumber % 100) / 10) * 100;
                threeNuber = (threeDigitNumber % 10) * 10;
                Console.WriteLine("Четвертое измененное число {0}", CalculationA29(firstNumber, secondNumber, threeNuber));
                firstNumber = (threeDigitNumber / 100) * 10;
                secondNumber = (threeDigitNumber % 100) / 10;
                threeNuber = (threeDigitNumber % 10) * 100;
                Console.WriteLine("Пятое измененное число {0}", CalculationA29(firstNumber, secondNumber, threeNuber));
                firstNumber = (threeDigitNumber / 100) * 100;
                secondNumber = ((threeDigitNumber % 100) / 10) * 10;
                threeNuber = threeDigitNumber % 10;
                Console.WriteLine("Шестое измененное число {0}", CalculationA29(firstNumber, secondNumber, threeNuber));
            }
            else
            {
                Console.WriteLine("Введен вариант вне диапазона, для завершения программы нажмите на любую клавишу.");
                Console.ReadKey();
            }
        }
        static void QuestA210()
        {
            //A2.10. Дано четырехзначное число. Найти: а) сумму его цифр; б) произведение его цифр.
            Console.WriteLine("Введите четырех целое число и вариант вопроса");
            int fourDigitNumber = Convert.ToInt32(Console.ReadLine());
            char question = Convert.ToChar(Console.ReadLine());
            question = char.ToLower(question);
            if (1000 <= fourDigitNumber && fourDigitNumber <= 9999)
            {
                int firstDigit = fourDigitNumber / 1000;
                int secondDigit = (fourDigitNumber / 100) % 10;
                int threeDigit = (fourDigitNumber / 10) % 10;
                int fourDigit = fourDigitNumber % 10;
                switch (question)
                {
                    case 'а':
                        Console.WriteLine("Ответ на вариант (а) : {0}", firstDigit + secondDigit + threeDigit + fourDigit);
                        break;
                    case 'б':
                        Console.WriteLine("Ответ на вариант (б) : {0}", firstDigit * secondDigit * threeDigit * fourDigit);
                        break;
                    default:
                        Console.WriteLine("Введен вариант вне диапазона");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Введен вариант вне диапазона, для завершения программы нажмите на любую клавишу.");
                Console.ReadKey();
            }
        }
        static void QuestA211()
        {
            //A2.11. Дано четырехзначное число. Найти: а) число, полученное при прочтении его цифр справа налево;
            //б) число, образуемое при перестановке первой и второй, третьей и четвертой цифр заданного числа. Например, из числа 5434 получить 4543, из числа 7048 — 784;
            //в) число, образуемое при перестановке второй и третьей цифр заданного числа. Например, из числа 5084 получить 5804;
            //г) число, образуемое при перестановке двух первых и двух последних цифр заданного числа. Например, из числа 4566 получить 6645, из числа 7304 — 473.
            //Последнюю задачу решить двумя способами:  1) с выделением отдельных цифр заданного числа; 2) без выделения отдельных цифр заданного числа.
            Console.WriteLine("Введите четырех целое число и вариант вопроса");
            int fourDigitNumber = Convert.ToInt32(Console.ReadLine());
            char question = Convert.ToChar(Console.ReadLine());
            question = char.ToLower(question);
            if (1000 <= fourDigitNumber && fourDigitNumber <= 9999)
            {
                int firstDigit = fourDigitNumber / 1000;
                int secondDigit = (fourDigitNumber / 100) % 10;
                int threeDigit = (fourDigitNumber / 10) % 10;
                int fourDigit = fourDigitNumber % 10;
                switch (question)
                {
                    case 'а':
                        Console.WriteLine("Ответ на вариант (а) : {0}{1}{2}{3}", fourDigit, threeDigit, secondDigit, firstDigit);
                        break;
                    case 'б':
                        Console.WriteLine("Ответ на вариант (б) : {0}{1}{2}{3}", secondDigit, firstDigit, fourDigit, threeDigit);
                        break;
                    case 'в':
                        Console.WriteLine("Ответ на вариант (в) : {0}{1}{2}{3}", firstDigit, threeDigit, secondDigit, fourDigit);
                        break;
                    case 'г':
                        if (threeDigit == 0)
                        {
                            Console.WriteLine("Ответ на вариант (г) 1) : {0}{1}{2}", fourDigit, firstDigit, secondDigit);
                        }
                        else
                        {
                            Console.WriteLine("Ответ на вариант (г) 1) : {0}{1}{2}{3}", threeDigit, fourDigit, firstDigit, secondDigit);
                        }
                        Console.WriteLine("Ответ на вариант (г) 2) : {0}{1}", fourDigitNumber % 100, fourDigitNumber / 100);
                        break;
                    default:
                        Console.WriteLine("Введен вариант вне диапазона");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Введен вариант вне диапазона, для завершения программы нажмите на любую клавишу.");
                Console.ReadKey();
            }
        }
        static void QuestA212()
        {
            //A2.12. Дано натуральное число n (n > 9). Найти: а) число единиц в нем; б) число десятков в нем.
            Console.WriteLine("Введите натуральное числао n > 9 и вариант вопроса");
            int naturalNumber = Convert.ToInt32(Console.ReadLine());
            char question = Convert.ToChar(Console.ReadLine());
            question = char.ToLower(question);
            if (naturalNumber > 9)
            {
                switch (question)
                {
                    case 'а':
                        Console.WriteLine("Ответ на вариант (а) : {0}", naturalNumber % 10);
                        break;
                    case 'б':
                        Console.WriteLine("Ответ на вариант (б) : {0}", (naturalNumber % 100) / 10);
                        break;
                    default:
                        Console.WriteLine("Введен вариант вне диапазона");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Введен вариант вне диапазона, для завершения программы нажмите на любую клавишу.");
                Console.ReadKey();
            }
        }
        static void QuestA213()
        {
            //A2.13. Дано натуральное число n (n > 99). Найти: а) число десятков в нем; б) число сотен в нем.
            Console.WriteLine("Введите натуральное числао n > 99 и вариант вопроса");
            int naturalNumber = Convert.ToInt32(Console.ReadLine());
            char question = Convert.ToChar(Console.ReadLine());
            question = char.ToLower(question);
            if (naturalNumber > 99)
            {
                switch (question)
                {
                    case 'а':
                        Console.WriteLine("Ответ на вариант (а) : {0}", (naturalNumber % 100) / 10);
                        break;
                    case 'б':
                        Console.WriteLine("Ответ на вариант (б) : {0}", (naturalNumber % 1000) / 100);
                        break;
                    default:
                        Console.WriteLine("Введен вариант вне диапазона");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Введен вариант вне диапазона, для завершения программы нажмите на любую клавишу.");
                Console.ReadKey();
            }

        }
        static void QuestA214()
        {
            //A2.14. Дано натуральное число n (n > 999). Найти: а) число сотен в нем; б) число тысяч в нем.
            Console.WriteLine("Введите натуральное числао n > 999 и вариант вопроса");
            int naturalNumber = Convert.ToInt32(Console.ReadLine());
            char question = Convert.ToChar(Console.ReadLine());
            question = char.ToLower(question);
            if (naturalNumber > 999)
            {
                switch (question)
                {
                    case 'а':
                        Console.WriteLine("Ответ на вариант (а) : {0}", (naturalNumber % 1000) / 100);
                        break;
                    case 'б':
                        Console.WriteLine("Ответ на вариант (б) : {0}", (naturalNumber % 10000) / 1000);
                        break;
                    default:
                        Console.WriteLine("Введен вариант вне диапазона");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Введен вариант вне диапазона, для завершения программы нажмите на любую клавишу.");
                Console.ReadKey();
            }

        }
        static void QuestA31()
        {
            //A3.1. Из трехзначного числа x вычли его последнюю цифру. Когда результат разделили на 10, а к частному слева приписали последнюю цифру числа x, 
            //то получилось число 237. Найти число x.
            int xLastNumber = 237 / 100;
            int x = (237 % 100) * 10 + xLastNumber;
            Console.WriteLine("Число x равно: {0}", x);
        }
        static void QuestA32()
        {
            //A3.2. Из трехзначного числа x вычли его последнюю цифру. Когда результат разделили на 10, а к частному слева приписали последнюю цифру числа x, 
            //то получилось число n. Найти число x. Значение n вводится с клавиатуры, 100 <= n <= 999 и при этом число десятков в n не равно нулю.
            Console.WriteLine("Введите число n, 100 <= n <= 999 и при этом число десятков в n не равно нулю.");
            int nNumber = Convert.ToInt32(Console.ReadLine());
            if (100 <= nNumber && nNumber <= 999)
            {
                int xLastNumber = nNumber / 100;
                int x = (nNumber % 100) * 10 + xLastNumber;
                Console.WriteLine("Число x равно: {0}", x);
            }
            else
            {
                Console.WriteLine("Введенное значение находится вне диапазона, нажмите любую клавишу для завершения задачи");
                Console.ReadKey();
            }
        }
        static void QuestA33()
        {
            //A3.3. В трехзначном числе x зачеркнули первую цифру. Когда оставшееся число умножили на 10, а произведение сложили с первой цифрой числа x, 
            //то получилось число 564. Найти число x.
            int xLastNumber = 564 % 10;
            int x = 564 / 10 + xLastNumber * 100;
            Console.WriteLine("Число x равно: {0}", x);
        }
        static void QuestA34()
        {
            //A3.4. В трехзначном числе x зачеркнули первую цифру. Когда полученное число умножили на 10, а произведение сложили с первой цифрой числа x, 
            //то получилось число n. По заданному n найти число x (значение n вводится с клавиатуры, 100 <= n <= 999).
            Console.WriteLine("Введите число n, 100 <= n <= 999");
            int nNumber = Convert.ToInt32(Console.ReadLine());
            if (100 <= nNumber && nNumber <= 999)
            {
                int xLastNumber = nNumber % 10;
                int x = nNumber / 10 + xLastNumber * 100;
                Console.WriteLine("Число x равно: {0}", x);
            }
            else
            {
                Console.WriteLine("Введенное значение находится вне диапазона, нажмите любую клавишу для завершения задачи");
                Console.ReadKey();
            }
        }
        static void QuestA35()
        {
            //A3.5. В трехзначном числе x зачеркнули его вторую цифру. Когда к образованному при этом двузначному числу слева приписали вторую цифру числа x, 
            //то получилось число 546. Найти число x.
            int xSecondNumber = 546 / 100;
            int xFirstNumber = (546 % 100) / 10;
            int xThirdNumber = 546 % 10;
            Console.WriteLine("Значение X равно : {0}{1}{2}", xFirstNumber, xSecondNumber, xThirdNumber);
        }
        static void QuestA36()
        {
            //A3.6. В трехзначном числе x зачеркнули его вторую цифру. Когда к образованному при этом двузначному числу слева приписали вторую цифру числа x, 
            //то получилось число n. По заданному n найти число x (значение n вводится с клавиатуры, 10 <= n <= 999 и при этом число десятков в n не равно нулю).
            Console.WriteLine("Введите число n, 10 <= n <= 999");
            int nNumber = Convert.ToInt32(Console.ReadLine());
            if (10 <= nNumber && nNumber <= 999)
            {
                int xSecondNumber = nNumber / 100;
                int xFirstNumber = (nNumber % 100) / 10;
                int xThirdNumber = nNumber % 10;
                Console.WriteLine("Значение X равно : {0}{1}{2}", xFirstNumber, xSecondNumber, xThirdNumber);
            }
            else
            {
                Console.WriteLine("Введенное значение находится вне диапазона, нажмите любую клавишу для завершения задачи");
                Console.ReadKey();
            }
        }
        static void QuestA37()
        {
            //A3.7. В трехзначном числе x зачеркнули его вторую цифру. Когда к образованному при этом двузначному числу справа приписали вторую цифру числа x, 
            //то получилось число 456. Найти число x.
            int xFirstNumber = 456 / 100;
            int xThirdNumber = (456 % 100) / 10;
            int xSecondNumber = 456 % 10;
            Console.WriteLine("Значение X равно : {0}{1}{2}", xFirstNumber, xSecondNumber, xThirdNumber);
        }
        static void QuestA38()
        {
            //A3.8. В трехзначном числе x зачеркнули его вторую цифру. Когда к образованному при этом двузначному числу справа приписали вторую цифру числа x, 
            //то получилось число n. По заданному n найти число x (значение n вводится с клавиатуры, 100 <= n <= 999).
            Console.WriteLine("Введите число n, 100 <= n <= 999");
            int nNumber = Convert.ToInt32(Console.ReadLine());
            if (100 <= nNumber && nNumber <= 999)
            {
                int xFirstNumber = nNumber / 100;
                int xThirdNumber = (nNumber % 100) / 10;
                int xSecondNumber = nNumber % 10;
                Console.WriteLine("Значение X равно : {0}{1}{2}", xFirstNumber, xSecondNumber, xThirdNumber);
            }
            else
            {
                Console.WriteLine("Введенное значение находится вне диапазона, нажмите любую клавишу для завершения задачи");
                Console.ReadKey();
            }
        }
        static void QuestA39()
        {
            //A3.9. В трехзначном числе x зачеркнули его последнюю цифру. Когда в оставшемся двузначном числе переставили цифры, а затем приписали к ним слева 
            //последнюю цифру числа x, то получилось число 654. Найти число x.
            int xThirdNumber = 654 / 100;
            int xSecondNumber = (654 % 100) / 10;
            int xFirstNumber = 654 % 10;
            Console.WriteLine("Значение X равно : {0}{1}{2}", xFirstNumber, xSecondNumber, xThirdNumber);
        }
        static void QuestA310()
        {
            //A3.10. В трехзначном числе x зачеркнули его последнюю цифру. Когда в оставшемся двузначном числе переставили цифры, а затем приписали к ним слева 
            //последнюю цифру числа x, то получилось число n. По заданному n найти число x (значение n вводится с клавиатуры, 1 <= n <= 999 и при этом число 
            //единиц в n не равно нулю).
            Console.WriteLine("Введите число n, 100 <= n <= 999");
            int nNumber = Convert.ToInt32(Console.ReadLine());
            if (1 <= nNumber && nNumber <= 999)
            {
                int xThirdNumber = nNumber / 100;
                int xSecondNumber = (nNumber % 100) / 10;
                int xFirstNumber = nNumber % 10;
                Console.WriteLine("Значение X равно : {0}{1}{2}", xFirstNumber, xSecondNumber, xThirdNumber);
            }
            else
            {
                Console.WriteLine("Введенное значение находится вне диапазона, нажмите любую клавишу для завершения задачи");
                Console.ReadKey();
            }
        }
        // A4. Целочисленная арифметика. Задачи повышенной сложности
        static void QuestA41()
        {
            //A4.1. Даны цифры двух целых чисел: двузначного a2a1 и однозначного b, где a1 — число единиц, a2 — число десятков.
            // Получить цифры числа, равного сумме заданных чисел (известно, что это число двузначное). Слагаемое — двузначное 
            //число и число-результат не определять; условный оператор не использовать.
            Console.WriteLine("Введите цифры целых чисел: двузначного a2a1 и однозначного b, при a2a1 + b <= 99");
            int a2Digit = Convert.ToInt32(Console.ReadLine());
            int a1Digit = Convert.ToInt32(Console.ReadLine());
            int bDigit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Первая цифра {0}", (a2Digit * 10 + a1Digit + bDigit) / 10);
            Console.WriteLine("Вторая цифра {0}", (a2Digit * 10 + a1Digit + bDigit) % 10);
        }
        static void QuestA42()
        {
            //A4.2. Даны цифры двух двузначных чисел, записываемых в виде a2a1 и b2b1, где a1 и b1 — число единиц, 
            //a2 и b2 — число десятков. Получить цифры числа, равного сумме заданных чисел (известно, что это число двузначное).
            // Слагаемое — двузначное число и число-результат не определять; условный оператор не использовать.
            Console.WriteLine("Введите цифры целых двухзначных чисел: a2a1 и b2b1, при a2a1 + b2b1 <= 99");
            int a2Digit = Convert.ToInt32(Console.ReadLine());
            int a1Digit = Convert.ToInt32(Console.ReadLine());
            int b2Digit = Convert.ToInt32(Console.ReadLine());
            int b1Digit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Первая цифра {0}", (a2Digit * 10 + a1Digit + b2Digit * 10 + b1Digit) / 10);
            Console.WriteLine("Вторая цифра {0}", (a2Digit * 10 + a1Digit + b2Digit * 10 + b1Digit) % 10);
        }
        static void QuestA43()
        {
            //A4.3. Даны цифры двух десятичных целых чисел: трехзначного a3a2a1 и двузначного b2b1, где a1 и b1 — число единиц,
            // a2 и b2 — число десятков, a3 — число сотен. Получить цифры числа, равного сумме заданных чисел (известно,
            // что это число трехзначное). Числа-слагаемые и число-результат не определять; условный оператор не использовать.
            Console.WriteLine("Введите цифры целых чисел: a3a2a1 и b2b1, при a2a1 + b2b1 <= 999");
            int a3Digit = Convert.ToInt32(Console.ReadLine());
            int a2Digit = Convert.ToInt32(Console.ReadLine());
            int a1Digit = Convert.ToInt32(Console.ReadLine());
            int b2Digit = Convert.ToInt32(Console.ReadLine());
            int b1Digit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Первая цифра {0}", (a3Digit * 100 + a2Digit * 10 + a1Digit + b2Digit * 10 + b1Digit) / 100);
            Console.WriteLine("Вторая цифра {0}", ((a3Digit * 100 + a2Digit * 10 + a1Digit + b2Digit * 10 + b1Digit) % 100) / 10);
            Console.WriteLine("Третья цифра {0}", (a3Digit * 100 + a2Digit * 10 + a1Digit + b2Digit * 10 + b1Digit) % 10);
        }
        static void QuestA44()//------
        {
            //A4.4. Даны целое число k (10 ≤ k ≤ 99) и последовательность цифр 10111213…9899, в которой выписаны подряд все 
            //двузначные числа. Определить:
            //а) номер пары цифр, в которую входит k-я цифра;
            //б) двузначное число, образованное парой цифр, в которую входит k-я цифра;
            //в) k-ю цифру, если известно, что: k — четное число;  k — нечетное число.
            //Примечание. Величины строкового типа не использовать.
            Console.WriteLine("Введите целок число k и вариант вопроса");
            int k = Convert.ToInt32(Console.ReadLine());
            char question = Convert.ToChar(Console.ReadLine());
            if (10 <= k && k <= 99)
            {
                switch (question)
                {
                    case 'а':
                        Console.WriteLine("Номер пары цифр: {0}", k - 10 + 1);
                        break;
                    case 'б':

                        break;
                    case 'в':

                        break;

                    default:
                        Console.WriteLine("Введен вариант вне диапазона");
                        break;
                }

            }
            else
            {
                Console.WriteLine("Введено число вне диапазона. Нажмите любую клавишу для хавершения программы");
            }


        }
        static void QuestA45()//------
        {
            //A4.5. Даны целое число k (1 ≤ k ≤ 150) и последовательность цифр 101102103…149150, в которой выписаны подряд 
            //все трехзначные числа от 101  до 150.
            //Определить k-ю цифру, если известно, что:
            //k — число, кратное трем;
            //k — одно из чисел 1, 4, 7, …;
            //k — одно из чисел 2, 5, 8, …
            //Примечание. Величины строкового типа не использовать.

        }
        static void QuestA46()
        {
            //A4.6. Даны целые числа h, m, s (0 ≤ h ≤ 23, 0 ≤ m ≤ 59, 0 ≤ s ≤ 59), указывающие момент времени: «h часов, 
            //m минут, s секунд». Определить угол (в градусах) между положением часовой стрелки в начале суток и в указанный 
            //момент времени.
            Console.WriteLine("Введите последовательно h, m и s и вариант формата часов 12(a) или 24(b)");
            int h = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int s = Convert.ToInt32(Console.ReadLine());
            char format = Convert.ToChar(Console.ReadLine());
            double ungle;
            if (0 <= h && h <= 23 && 0 <= m && m <= 59 && 0 <= s && s <= 59 && format == 'a' || format == 'b')
            // Проверка выходящих данных на вхождение в допустимый диапазон
            {
                switch (format)
                {
                    case 'a':
                        if (h - 12 < 0)
                        {
                            ungle = 360 * (Convert.ToDouble(h) * 3600 + Convert.ToDouble(m) * 60 + Convert.ToDouble(s)) / 43200;
                            Console.WriteLine("Угол равен {0}", ungle);
                        }
                        else
                        {
                            ungle = 360 * ((Convert.ToDouble(h) - 12) * 3600 + Convert.ToDouble(m) * 60 + Convert.ToDouble(s)) / 43200;
                            Console.WriteLine("Угол равен {0}", ungle);
                        }
                        break;
                    case 'b':
                        ungle = 360 * (Convert.ToDouble(h) * 3600 + Convert.ToDouble(m) * 60 + Convert.ToDouble(s)) / 86400;
                        Console.WriteLine("Угол равен {0}", ungle);
                        break;
                    default:
                        Console.WriteLine("Some Text");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Введено значение вне диапазона, нажмите клавишу для завершения программы.");
                Console.ReadKey();
            }
        }
        static void QuestA47()
        {
            //A4.7. С начала суток часовая стрелка повернулась на y градусов (0 ≤ y ≤ 360, y — вещественное число). 
            //Определить число полных часов и число полных минут, прошедших с начала с уток.
            Console.WriteLine("Введите y");
            double clockUngle = Convert.ToDouble(Console.ReadLine());
            const int secondsInDay12HourFormat = 43200;
            double minutLeft = clockUngle / 360 * secondsInDay12HourFormat / 60;
            double hourLeft = minutLeft / 60;
            Console.WriteLine("С начало суток прошло {0} часа(ов) или {1} минут(ы)", Convert.ToInt32(hourLeft), minutLeft);

        }
        static void QuestA48()
        {
            //A4.8. Часовая стрелка образует угол y с лучом, проходящим через центр и через точку, соответствующую 12 часам 
            //на циферблате, 0 ≤ y ≤ 2 . Определить значение угла для минутной стрелки, а также количество полных часов и 
            //полных минут.

        }
        static void QuestA49()
        {
            //A4.9. Даны целые числа h, m (0 ≤ h ≤ 12, 0 ≤ m ≤ 59), указывающие момент времени: «h часов, m минут». 
            //Определить наименьшее время (число полных минут), которое должно пройти до того момента, 
            //когда часовая и минутная стрелки на циферблате:
            //а) совпадут;
            //б) расположатся перпендикулярно друг другу.

        }
        static void QuestA410()
        {
            //A4.10. Даны два целых числа a и b. Если a делится на b или b делится на a, то вывести 1, 
            //иначе — любое другое число. Условные операторы и операторы цикла не использовать.

        }
    }
}