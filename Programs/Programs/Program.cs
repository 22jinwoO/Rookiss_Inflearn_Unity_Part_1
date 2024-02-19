using System;

namespace Programs
{

    // 객체 (OOP Object Oriented Programming)
    // 객체는 속성과 기능으로 이루어짐

    //class Player // 상위 계층 : 부모 클래스 or 기반 클래스
    //{
    //    static public int counter = 1; // 오로지 1개만 존재!

    //    public int id;
    //    public int hp;
    //    public int attack; // public 을 붙여준 이유 : 나중에 외부에서 Kngiht 객체에 접근해도 사용할 수 있도록

    //    public Player(int hp)
    //    {
    //        this.hp = hp;
    //        Console.WriteLine("Player 생성자 호출");
    //    }

    //    public void Move()
    //    {
    //        Console.WriteLine("Player Move");
    //    }

    //    public void Attack()
    //    {
    //        Console.WriteLine("Player Attack");
    //    }
    //}

    //// OOP(은닉성/상속성/다형성)
    //class Mage
    //{

    //}

    //class Archer
    //{

    //}

    ////Knight

    //// 속성 : hp, attack
    //// 기능 : Move, Attack, Die

    //// Ref 참조
    //class Knight : Player // 상속을 받는 아이의 경우 : 자식 클래스 or 파생 클래스
    //{
    //    // 필드

    //    // static이 붙지 않으면 유일성 보장 x, 인스턴스 된 객체마다 실행하거나 값 개별 할당 가능
    //    // static이 붙으면 클래스에 종속되기 때문에 유일성 보장
    //    static public void Test()
    //    {

    //    }

    //    static public Knight CreateKnight()
    //    {
    //        Knight knight = new Knight();
    //        knight.hp = 100;
    //        knight.attack = 1;
    //        return knight;

    //    }

    //    int c;
    //    public Knight()  : base(100)
    //    {
    //        //id = counter;
    //        //counter++;
    //        //hp = 100;
    //        //attack = 10;
    //        this.c = 10;
    //        base.hp = 100;
    //        Console.WriteLine("Knight 생성자 호출");
    //    }

    //    public Knight(int hp) : base(100) // this() => Kngiht() 호출
    //    {
    //        this.hp = hp;
    //        attack = 10;

    //        Console.WriteLine("Player hp 생성자 호출!");

    //    }

    //    public Knight(int hp, int attack) : this() // this() => Kngiht() 호출
    //    {
    //        this.hp = hp;
    //        this.attack = attack;

    //        Console.WriteLine("int 생성자 호출!");

    //    }

    //    public Knight Clone()
    //    {
    //        Knight knight = new Knight();
    //        knight.hp = hp;
    //        knight.hp = attack;
    //        return knight;

    //    }

    //    //public void Move()
    //    //{
    //    //    Console.WriteLine("Knight Move");
    //    //}

    //    //public void Attack()
    //    //{
    //    //    Console.WriteLine("Knight Attack");
    //    //}

    //} 


    // OOP (은닉성 / 상속성 / 다형성)

    // 자동차
    // 핸들 페달 차문
    // 전기장치 엔진 기름 <-> 외부 노출




    //class Knight
    //{
    //    // public은 모두한테 다 공개하겠다는 의미.
    //    // 만약에 이 데이터가 엄청 중요한 정보여서 함부로 고치면 안되는 정보라면 모두가 접근할 수 있게 열어주는 것은 굉장히 위험함.
    //    // 프로그램이 커지면 커질수록 많은 사람끼리 코드를 공유하면서 사용할 수 있는 가능성이 높음
    //    // 접근 한정자 
    //    // public : 누구나 사용 가능 => 보안 레벨 낮음
    //    // protected : 상속을 받은애가 있다면 그 친구만 접근 가능
    //    // private : 나만 사용하겠다 => 외부에선 사용 못함 , 접근한정자를 아무것도 입력하지 않았을 경우 private으로 설정됨

    //    protected int hp;

    //    //public void SetHP(int hp)
    //    //{
    //    //    this.hp = hp;
    //    //}


    //}

    //class SuperKnight : Knight
    //{ 
    //   void Test()
    //    {
    //        hp = 10;
    //    }
    //}

    // OOP (은닉성/상속성/다형성)
    // 클래스 형식 변환
    class Player
    {
        protected int hp;
        protected int attack;
    }

    class Knight : Player
    {

    }

    class Mage : Player
    {
        public int mp;

    }

    class Program
    {
        // 게임에 들어가는 것을 구현할 때 이런식으로 오버로딩을 통해 Kight, Mage 각각의 클래스마다의 기능을 구현할 수 있음 => 코드의 재사용성이 떨어짐
        //기사 
        //static void EnterGame(Knight knight)
        //{

        //}

        ////법사
        //static void EnterGame(Mage mage)
        //{

        //}

        static Player FindPlayerByID(int id)
        {
            // id에 해당하는 플레이어를 탐색

            // 못찾았으면
            return null;
        }
        // 앞선 문제에서 매개변수로 Knight와 Mage가 상속받은 Player를 사용한다면 Knight와 Mage 둘 다 사용 가능한 함수가 됨
        // 하지만 이렇게 하면 매개변수로 Mage를 넣었을 때 Mage의 mp 값에 접근을 못함. (mp는 player가 아니라 Mage만 갖고 있는 값이기 때문)
        static void EnterGame(Player player)
        {
            // 매개변수 값의 형태가 Mage인지 확인하는 구문 => 1. is 로 확인 가능 return 값은 bool 자료형
            bool isMage = (player is Mage);
            if (isMage)
            {
                // 함수 내용이 아래와 같을 때 EnterGame(knight)가 함수를 호출해도 문법적으로는 오류가 발생하지 않음 => 실행 시 오류
                Mage mage = (Mage)player;
                mage.mp = 10;
            }

            // as 는 캐스팅 까지 가능 , player가 knight 일 땐 mage2 = null 이 됨, 대부분 as를 사용함
            Mage mage2 = (player as Mage);

            if (mage2!=null)
            {
                // 함수 내용이 아래와 같을 때 EnterGame(knight)가 함수를 호출해도 문법적으로는 오류가 발생하지 않음 => 실행 시 오류
                mage2.mp = 10;
            }

        }

        static void Main(string[] args)
        {
            //Knight knight = Knight.CreateKnight();
            //knight.Move();
            //knight.Attack();

            //Knight knight = new Knight();
            //knight.SetHP(100);
            //knight.hp = 1; // hp를 private으로 선언한 경우 보호수준 때문에 접근 불가능
            //knight.SecretFunction();

            Knight knight = new Knight();
            Mage mage = new Mage();

            // Mage 타입 -> Player 타입
            // Player 타입 -> Mage 타입 ? 원래는 안되지만 괄호를 넣어 강제로 변환 가능
            Player magePlayer = mage;
            Mage mage2 = (Mage)magePlayer;

            EnterGame(knight);
            EnterGame(mage);
        }

    }
}
