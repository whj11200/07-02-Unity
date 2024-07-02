using System.Diagnostics;

namespace Mainaap
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            // 인스턴스 객체생성
            //cat cat = new cat();
            //cat.color = "하얀색";
            //cat.Name = "네로";
            //cat.Meow();
            //Console.WriteLine($"{cat.Name}:{cat.color}");

            //cat nero = new cat(); //  매개변수가 없는 보이드 생성자 호출
            //nero.Meow();
            //cat cat3 = new cat("망고","핑크");
            //cat3.Meow();
            //// 생성과 동시에 호출
            //Console.WriteLine($"{cat3.Name},{cat3.color}");
            //cat nero = new cat("네로", "블랙");
            //nero.Meow();
            //Console.WriteLine($"{nero.Name},{nero.color}");

            //Console.WriteLine("출력");
            //Environment.Exit(0);
            // 메서드에 0을 할당하면 현재 프로그램이 종료가 되어 아래에 콘솔이 출력이 안된다.
            //Console.WriteLine("출력이 되나요?");
            //Process.Start("Notepad.exe");
            //Process.Start("Explorer.exe", "https://www.google.com/webhp");
            int iRandom = 0;
            int iSelection = 0;
            string[] choice = { "가위 , 바위, 보" };

            iRandom = (new Random().Next(1,4));

            Console.WriteLine("1(가위), 2(바위),3(보) 입력 :_\b");
            iSelection = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n 사용자 : {0}", choice[iSelection - 1]);
            Console.WriteLine("컴퓨터 : {0}\n", choice[iRandom -1]);
            if(iSelection == iRandom)
            {
                Console.WriteLine("비김");
            }
            else
            { 
                switch(iSelection)
                {
                    case 1: Console.WriteLine((iRandom == 3) ? "승" : "패");break;
                    case 2: Console.WriteLine((iRandom == 1) ? "승" : "패"); break;
                    case 3: Console.WriteLine((iRandom == 2) ? "승" : "패"); break;
                }
               
            }
        }
    }
    //public class cat
    //{
      
    //    public string Name; // 멤버 필드
    //    public string color;// 멤버 필드
    //    //public static int Count = 0;
    //    // 매개변수가 없는 생성자 즉 보이드 생성자라고 한다.
    //    public  cat()
    //    {

    //        //Name = string.Empty;
    //        //color = string.Empty;//Enpty: 비워있다
    //        Name = " ";
    //        color = " ";
           

    //    }
    //    //public cat(string _name, string _color)
    //    //{
    //    //    Name = _name;
    //    //    color = _color;
    //    //}

    //    // 맴버변수 와 매개변수와 이름이 같은 경우 this를 사용해서 할당하면 가능하다.
    //    public cat(string Name, string color)
    //    {
    //        this.Name = Name;
    //        this.color = color;
    //    }
    //    // 소멸자 반드시 같은 클래스의 생성지에서 생성 한 것은 반드시 같은 클래스의 소멸자에 소멸이
    //    // 원칙이다.
    //    ~cat()
    //    {
    //        Console.WriteLine($"{Name}:잘가라우");
    //    }// 안해도 자기가 알아서 사라진다.
    //    //생성자 특징 클래스 명 이랑 같다, 반환형이 없다. 
    //    // 객체가 생성될때 초기화 된다.
    //    // 생성자가 하나도 없더라도 void 생성자는 호출할 수 있다.
    //    // 매개변수있는 생성자를 만들면 기본 생성자만 따로 만들어진다.
    //    // 
    //    public void Meow()
    //    {
    //        Console.WriteLine("{0}: 야옹", Name);
    //    }
    //    //public static void Meow2()
    //    //{
    //    //    Console.WriteLine($"{name}");
    //    //}
    //    // 오류가 난 이유는 Count는 전역변수라서 static이 붙어도 할당이 가능하지만
    //    // 멤버변수인 Name은 할당이 불가능하다.
    //    // abstract 추상클래스
    //    // sealed 봉인 클래스
    //    // 보통은 string 로 문자열을 저장하지만 큰 규모의 문자열저장은 StringBuiler 클래스를 사용한다.


    //}
}
