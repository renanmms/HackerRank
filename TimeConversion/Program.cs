// See https://aka.ms/new-console-template for more information

string s = Console.ReadLine();

string result = timeConversion(s);

Console.WriteLine(result);

static string timeConversion(string s){
    DateTime time = new DateTime();

    // string newStr = s[0..8];
    //string newStr = s.Substring(0, 8);
    string newStr = s.Substring(0, s.Length - 2);

    //string clockFormat = s[8..10];
    string clockFormat = s.Substring(8);

    //07:05:45PM
    int hora = Convert.ToInt32(newStr.Split(":")[0]); // 7
    int minuto = Convert.ToInt32(newStr.Split(":")[1]); // 5
    int segundo = Convert.ToInt32(newStr.Split(":")[2]); // 45


    hora = ((clockFormat == "PM") ? hora += 12 : hora) % 12;
    //hora = (clockFormat == "PM") ? 0 : 12; // (12 + 0) = 12

    time = time.AddHours(hora); // 00:00:00
    time = time.AddMinutes(minuto); // 00:40:00
    time = time.AddSeconds(segundo); // 00:40:22

    return time.ToString("HH:mm:ss");
}
