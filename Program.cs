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

