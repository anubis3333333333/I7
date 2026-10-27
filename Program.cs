string[] days = {"пн" , "вт", "ср", "чт", "пн", "сб", "вс"};
for (int i = days.Length - 1; i >= 0; i--) {
    Console.WriteLine($"{i + 1} : {days[i]}");
}
