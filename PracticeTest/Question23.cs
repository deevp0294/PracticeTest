using System;

namespace PracticeTest
{
    public class RoomBooking
    {
        public int RoomNumber;
        public DateTime StartTime;
        public string Organizer;
        int duration;
        string org;

        public RoomBooking(int room, DateTime datetime, int dur, string org1)
        {
            RoomNumber = room;
            StartTime = datetime;
            duration = dur;
            org = org1;

            // Add duration minutes to StartTime
            StartTime = StartTime.AddMinutes(duration);
        }

        public RoomBooking()
        {
        }

        public RoomBooking(string org)
        {
            Organizer = org;
        }
    }

    internal class Question23
    {
        public void Funct()
        {
            RoomBooking roombooking =
                new RoomBooking(12, DateTime.Now, 30, "Deep");

            Console.WriteLine(roombooking.StartTime);
        }
    }
}