namespace iflelse;
class Program
{
    static void Main(string[] args)
    {
        int time = DateTime.Now.Hour;
          
        if(time>=6 && time<11)
         Console.WriteLine("Günaydin");
        else if(time<=18)
         Console.WriteLine("iyi Günler");
        else
         Console.WriteLine("iyi Geceler");

        string sonuc = time<=18 ? "İyi Günler" : "İyi Geceler";
         Console.WriteLine(sonuc);
    }
}
