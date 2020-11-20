using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    class Animals
    {
        //fields
        private string _type;
        private double _health = 100;
        private double _attackDamage = 20;
        private int _speed = 2;
        private int _attackRange = 1;
        private bool _isOnRange = false;
        private Point3D _position = new Point3D(0, 0, 0);
        public enum animalType { aerial, ground };

        //properties

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public double Health
        {
            get { return _health; }
            set { _health = value; }
        }

        public double AttackDamage
        {
            get { return _attackDamage; }
            set { _attackDamage = value; }
        }

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public int AttackRange
        {
            get { return _attackRange; }
            set { _attackRange = value; }
        }

        public bool OnRange
        {
            get { return _isOnRange; }
            set { _isOnRange = value; }
        }
        public Point3D Position
        {
            get { return _position; }
            set { _position = value; }
        }
            

        //constructor Methods
        public Animals() { }
        public Animals(animalType type, double health, double attackDamage, Point3D position) 
        {
            _position = position;
            _type = type.ToString();
            _health = health;
            _attackDamage = attackDamage;
        }



        public void Move( Point3D position) 
        {
            if (_type == "aerial") 
            {
                AerialMove(position);
            }
            else 
            { 
                GroundMove(position); 
            }
        }

        public void AerialMove(Point3D position)
        {
            _position.X = position.X;
            _position.Y = position.Y;
            _position.Z = position.Z;
        }
        public void GroundMove(Point3D position)
        {
            _position.X = position.X;
            _position.Z = position.Z;
        }

        public void IsOnRange(Point3D animal, Point3D hunter, int attackRange)
        {
            
            if (animal.X - hunter.X <= attackRange || animal.Z - hunter.Z <= attackRange) 
            {
                _isOnRange = true; 
            }
        }

        public void Attack(Hunter hunter)
        {
            IsOnRange(_position, hunter.Position,_attackRange);
            if (_isOnRange)
            {
                if (hunter.Health <= 0)
                {
                    hunter.Health = 0;
                    Die();
                    Console.WriteLine($"{hunter.GetFullName()} is Dead stop attacking him!\n");
                }
                else
                {
                    Console.WriteLine($"{hunter.GetFullName()}'s health was {hunter.Health}\n");
                    hunter.Health -= _attackDamage;
                    if (hunter.Health<0)
                    {
                        hunter.Health = 0;
                        Console.WriteLine($"got {_attackDamage} damage and now hi is Dead\n");
                    }
                    else
                    Console.WriteLine($"got {_attackDamage} damage and now his health = {hunter.Health}\n");
                }
            }
            else
            {
                Console.WriteLine($"{hunter.GetFullName()} is out of range\n");
                
            }
        }

        public void Die()
        {
            //this.Destroy()
        }

    }

   

}
