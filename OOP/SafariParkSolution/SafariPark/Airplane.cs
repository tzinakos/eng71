using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public class Airplane : Vehicle
    {
        //Fields
        private string _airline;
        private int _altitude;
        private bool _isGrounded = true;
        private bool _isOnFlyMode = false;

        //properties
        public int Altitude
        {
            get { return _altitude; }
            set { if (value > 0 ) _altitude = value; }
        }
        public string Airline
        {
            get { return _airline; }
            set { _airline = value; }
        }

        //Constractor Methods
        public Airplane(int capacity) : base(capacity)
        {
            
        }

        public Airplane(int capacity, int speed, string airline) : base(capacity, speed)
        {
            _airline = airline;
        }

        // Airplane Behavior Methods
        public void Ascend(int distance)
        {
            _altitude += distance;
            if (_altitude > 0)
            {
                _isGrounded = false;
                _isOnFlyMode = true;
            }
        }

        public void Descend(int distance)
        {
            _altitude -= distance;
            if (_altitude <= 0)
            {
                _isGrounded = true;
                _isOnFlyMode = false;
            }

        }

        public override string Move()
        {
            return $"{base.Move()} at an altitude of {_altitude} meters";
        }

        public override string Move(int times)
        {
            return $"{base.Move(times)} at an altitude of {_altitude} meters";
        }

        public override string ToString()
        {
            return $"Thank you for flying {_airline}: {base.ToString()} capacity: {Capacity} passengers: {NumPassengers} speed: {Speed} position: {GetPosition()} altitude: {_altitude}";
        }

    }
}
