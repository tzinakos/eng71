using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
   public class Vehicle : IMoveable
    {
        //Fields
        private int _capacity,_numPassengers,_speed;

        //props
        public int NumPassengers
        {
            get { return _numPassengers; }
            set { if(value>0 && value <_capacity)_numPassengers = value; }
        }


        public int Speed
        {
            get { return _speed; }
            set {  _speed = value; }
        }
        

        public int Capacity
        { 
            get { return _capacity; }
            set { _capacity = value; }
        }

        public int Position { get; private set; }


        //Constructor Methods
        public Vehicle()
        {

        }

        public Vehicle(int capacity, int speed = 10)
        {
            _capacity = capacity;
            _speed = speed;
        }

        

        //Behavior Methods
        public virtual string Move()
        {
            Position += _speed;
            return "Moving along";
        }

        public virtual string Move(int times)
        {
            if (_speed == 0) { _speed = 10; }
            Position += times * _speed;
            return $"Moving along {times} times";
        }

        public int GetPosition()
        {
            return Position;
        }
    }
}
