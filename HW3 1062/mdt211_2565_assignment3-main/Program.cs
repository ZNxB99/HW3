class Program
{
    static void Main(string[] args){
    Queue<char> Mach = new Queue<char>();
    Console.WriteLine("*******************");
    Console.WriteLine("Please input your fruit");
    Console.WriteLine("Only L | M | S");
    while(true){
        Console.WriteLine("*******************");
        char fruit = char.Parse(Console.ReadLine());
        if(fruit != 'S'&&fruit != 'M'&&fruit != 'L'){
            break;
        }
        else{
            if(fruit == 'S'){
                Mach.Push('3');
            }
            else if(fruit == 'M'){
                Mach.Push('2');
            }
            else if(fruit == 'L'){
                Mach.Push('1');
            }
        }
     }
     for(int i = 0;i<Mach.GetLength(); i++){
        if(Mach.Get(i) == '1'){
                Mach.Push('2');
                Mach.Push('2');
        }
        else if (Mach.Get(i) == '2'){
                Mach.Push('3');
                Mach.Push('3');
                Mach.Push('3');
        }
     }
     for (int i = 0 ;i<Mach.GetLength(); i++)
     Console.Write(Mach.Get(i));
    }
}