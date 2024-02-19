using System;

namespace Programs
{

    // 객체 (OOP Object Oriented Programming)
    // 객체는 속성과 기능으로 이루어짐

    class Player // 상위 계층 : 부모 클래스 or 기반 클래스
    {
        static public int counter = 1; // 오로지 1개만 존재!

        public int id;
        public int hp;
        public int attack; // public 을 붙여준 이유 : 나중에 외부에서 Kngiht 객체에 접근해도 사용할 수 있도록

        public Player(int hp)
        {
            this.hp = hp;
            Console.WriteLine("Player 생성자 호출");
        }

        public void Move()
        {
            Console.WriteLine("Player Move");
        }

        public void Attack()
        {
            Console.WriteLine("Player Attack");
        }
    }

    // OOP(은닉성/상속성/다형성)
    class Mage
    {

    }

    class Archer
    {

    }

    //Knight

    // 속성 : hp, attack
    // 기능 : Move, Attack, Die

    // Ref 참조
    class Knight : Player // 상속을 받는 아이의 경우 : 자식 클래스 or 파생 클래스
    {
        // 필드

        // static이 붙지 않으면 유일성 보장 x, 인스턴스 된 객체마다 실행하거나 값 개별 할당 가능
        // static이 붙으면 클래스에 종속되기 때문에 유일성 보장
        static public void Test()
        {

        }

        static public Knight CreateKnight()
        {
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 1;
            return knight;

        }

        int c;
        public Knight()  : base(100)
        {
            //id = counter;
            //counter++;
            //hp = 100;
            //attack = 10;
            this.c = 10;
            base.hp = 100;
            Console.WriteLine("Knight 생성자 호출");
        }

        public Knight(int hp) : base(100) // this() => Kngiht() 호출
        {
            this.hp = hp;
            attack = 10;

            Console.WriteLine("Player hp 생성자 호출!");

        }

        public Knight(int hp, int attack) : this() // this() => Kngiht() 호출
        {
            this.hp = hp;
            this.attack = attack;

            Console.WriteLine("int 생성자 호출!");

        }

        public Knight Clone()
        {
            Knight knight = new Knight();
            knight.hp = hp;
            knight.hp = attack;
            return knight;

        }

        //public void Move()
        //{
        //    Console.WriteLine("Knight Move");
        //}

        //public void Attack()
        //{
        //    Console.WriteLine("Knight Attack");
        //}

    } 

    class Program
    {

        static void Main(string[] args)
        {
            Knight knight = Knight.CreateKnight();
            knight.Move();
            knight.Attack();


        }

    }
}
