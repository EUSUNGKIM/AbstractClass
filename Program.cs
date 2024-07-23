using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace 김의성_플밍1기__상속
{
    // 추상클래스란 부모클래스의 역할을 하기위한 클래스 입니다.
    // 추상클래스로 필드도 가질수 있고 메서드도 가질수 있지만 다른점이면
    // 추상 메서드를 선언할수 있습니다. 여기서 추상 메서드를 선언 하게되면
    // 반드시 상속 받는 클래스에서 무조건적으로 구현을 해줘야 합니다 아니면
    // 오류가 나게됩니다. 이를 사용하게 되는 이유는 사용가능한 코드가 버그가
    // 나게되면 찾는게 아주 골치아파 집니다 하지만 추상클래스를 사용하면 반드시
    // 추상클래스를 선언한 자식 클래스에서는 반드시 구현해야하기때문에 어디서
    // 어긋난건지 금방 알 수있겠됩니다. 추상클래스는 인스턴스를 생성할 수 없습니다.
    // private static virtual 등도 선언을 할 수 없습니다.

    // 오버라이딩의 의미는 우선시되는 이란 뜻입니다. 오버라이딩에선 부모 클래스에서
    // 물려받은 메소드를 자식클래스에 재정의 하는것입니다.이를 사용하면 부모 클래스보다
    // 자식 클래스의 메소드가 더 우선시 되기때문입니다.

    // 오버로딩이란 하나의 메소드에서 여러 가지를 구현할수있습니다. 예를 들어 하나의
    // 메소드속에서 같은 이름의 매개변수나 갯수 타입등을 다르게 지정할 수 있게됩니다.
    // 이를 사용하는 이유는 코드를 일관성 있게 만들어 주기 위해입니다.
    public class Program
    {
        public abstract class Dummy
        {
            public string name;
            public int hp;

            public Dummy()
            {
                name = "더미인형";
                hp = 100;
            }
            public abstract void GunAttack(int attack);
        }
        public abstract class Firearms : Dummy
        {
            public string gunname;
            public string type;
            public int attack;

            public Firearms()
            {
                gunname = "M4";
                type = "돌격소총";
                attack = 55;
            }
            public override void GunAttack(int attack)
            {
                hp -= this.attack;
                Console.WriteLine($"{gunname}이 {this.attack}데미지로 맞췄습니다.");
                Console.WriteLine($"더미의 체력은{hp}남았습니다.");
                if (hp <= 0)
                {
                    Console.WriteLine($"{name}이 쓰러졌습니다.");
                }
            }
        }
        public class Ak47 : Firearms
        {
            public Ak47()
            {
                gunname = "AK47";
                type = "반자동 소총";
                attack = 65;
            }
        }
        public class M4 : Firearms
        {
            public M4()
            {
                
            }
        }
        public class Knife : Firearms
        {
            public Knife()
            {
                gunname = "나이프";
                type = "근접 무기";
                attack = 100;
            }

            public override void GunAttack(int attack)
            {
                hp -= this.attack;
                Console.WriteLine($"{gunname}이 {this.attack}데미지로 찔렀습니다.");
                Console.WriteLine($"더미의 체력은{hp}남았습니다.");
                if (hp <= 0)
                {
                    Console.WriteLine($"{name}이 쓰러졌습니다.");
                }
            }
        }

        static void Main(string[] args)
        {
            Ak47 ak47 = new Ak47();
            ak47.GunAttack(0);
            
            M4 m4 = new M4();
            m4.GunAttack(0);

            Knife knife = new Knife();
            knife.GunAttack(0);
        }
    }
}