int[] temperatures = { -5, 0, 24, 25, 35, 36 };
string status = "НОРМА";

for (int i = 0; i < temperatures.Length; i++)
{
    if (temperatures[i] <= 0)
    { 
        status = "ХОЛОДНО";
    }
    else if (temperatures[i] >= 35)
    {
        status = "ПЕРЕГРЕВ";
    }
    else if (temperatures[i] > 0 && temperatures[1] < 35)
    {
        status = "НОРМА";
    }
    Console.WriteLine($"датчик {i + 1}: {temperatures[i]} °C - Статус: {status}");
}

// int[] temperatures = { -5, 0, 24, 25, 35, 36 };

// for (i = 0; i < temperatures.Length; i++)
// {
//     if (temperatures[i] < 0)
//     { 
//         Console.WriteLine("ХОЛОДНО");
//     }
//     else if (temperatures[i] > 35)
//     {
//         Console.WriteLine("ПЕРЕГРЕВ");
//     }
//     else if (temperatures[i] > 0 && temperatures[1] < 35)
//     {
//         Console.WriteLine('НОРМА')
//     }
// }

