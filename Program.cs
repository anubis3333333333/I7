// string[] days = {"пн" , "вт", "ср", "чт", "пн", "сб", "вс"};
// for (int i = days.Length - 1; i >= 0; i--) {
//     Console.WriteLine($"{i + 1} : {days[i]}");
// }


// double[] temps = { 15.5, 12.3, 8.0, -2.5, -5.1, 0.4, 4.2 };
// foreach (double temp in temps){
//     Console.Write(temp + " ");
// }



// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int sum = 0;
// int countMoreThan100 = 0;
// foreach (int price in prices){
//     sum += price;
//     if (price > 100){
//         countMoreThan100++;
//     }
// }
// double average = (double)sum / prices.Length;
// Console.WriteLine($"Общая сумма цен: {sum}");
// Console.WriteLine($"Средняя цена: {average}");
// Console.WriteLine($"Количество товаров дороже 100: {countMoreThan100}");



// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int minPrice = prices[0]; 
// int maxPrice = prices[0];
// int maxIndex = 0;
// for (int i = 1; i < prices.Length; i++){
//     if (prices[i] < minPrice){
//         minPrice = prices[i];
//     }
//     if (prices[i] > maxPrice){
//         maxPrice = prices[i];
//         maxIndex = i;
//     }
// }
// Console.WriteLine($"Минимальная цена: {minPrice}");
// Console.WriteLine($"Индекс самого дорогого товара: {maxIndex} (цена: {maxPrice})");


// int[] balance = { 100, -50, 20, -5, 0, 75 };
// for (int i =0; i<balance.Length; i++){
//     if (balance[i] < 0 ){
//         balance[i] = 0;
//     } 
// }
// foreach (int n in balance){
//     Console.Write(n+" ");
// }


// int[] numbers = new int[5];
// Console.WriteLine("Введите 5 целых чисел:");
// for (int i = 0; i < numbers.Length; i++){
//     Console.Write($"Число {i + 1}: ");
//     numbers[i] = int.Parse(Console.ReadLine());
// }

// Console.Write("Массив в обратном порядке: ");
// for (int i = numbers.Length - 1; i >= 0; i--){
//     Console.Write(numbers[i] + " ");
// }
// Console.WriteLine();

// int evenCount = 0;
// foreach (int num in numbers){
//     if (num % 2 == 0){
//         evenCount++;
//     }
// }
// Console.WriteLine($"Количество чётных чисел: {evenCount}");



// string[] names = { "Анна", "Игорь", "Мария", "Олег", "Ольга" };
// Console.Write("Введите имя для поиска: ");
// string searchName = Console.ReadLine();
// int foundIndex = -1; 
// for (int i = 0; i < names.Length; i++){
//     if (names[i] == searchName){
//         foundIndex = i; 
//         break;         
//     }
// }
// if (foundIndex != -1){
//     Console.WriteLine($"Имя найдено! Позиция в массиве (индекс): {foundIndex}");
// }
// else{
//     Console.WriteLine("Не найдено");
// }

// int[] grades = { 4, 2, 3, 2, 2, 2, 2, 2 }; 
// Console.Write("Все оценки: ");
// foreach (int grade in grades){
//     Console.Write(grade + " ");
// }
// Console.WriteLine();
// int sum = 0;
// int maxGrade = grades[0];
// int minGrade = grades[0];
// int twosCount = 0;
// int fivesCount = 0;
// foreach (int grade in grades){
//     sum += grade; 
//     if (grade > maxGrade) maxGrade = grade; 
//     if (grade < minGrade) minGrade = grade; 

//     if (grade == 2) twosCount++;  
//     if (grade == 5) fivesCount++;
// }


// double average = (double)sum / grades.Length;
// Console.WriteLine($"Средняя оценка: {average:F2}");


// Console.WriteLine($"Наибольшая оценка: {maxGrade}");
// Console.WriteLine($"Наименьшая оценка: {minGrade}");


// Console.WriteLine($"Количество «двоек»: {twosCount}");
// Console.WriteLine($"Количество «пятёрок»: {fivesCount}");


// if (average >= 4.5){
//     Console.WriteLine("Статус: Отличник");
// }
// else if (average >= 3.5){
//     Console.WriteLine("Статус: Хорошист");
// }
// else{
//     Console.WriteLine("Статус: отчислен");
// }

