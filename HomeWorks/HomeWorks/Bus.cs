using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    class Bus: Car  //f)Bus classi yaradirsiniz.Miras alir Car classindan.PassengerCountfieldi-i olur Bus classinin.
    {
        public int PassengerCount;

        public Bus():base()  //h)Bus Classinda cunstructorunda Car Classini constructorunu cagirmali, Car-dan instance alib obyekt yaratsin
        {

        }

        public override string Info() //g)Bus class-da Info override elesin,PassengerCount-da elave olsun info methodunun neticesine elave olsun.
        {
            return $"Info about Car: {Brand}  {Model}  {Color}  {MaxSpeed} Max Passenger Count: {PassengerCount}";
            
        }
    }

}
