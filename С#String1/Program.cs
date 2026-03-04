namespace С_String1
{
    public class Logic
    {
        public static string CompareTrainInStation(int ArrivalHour, int ArrivalMinute, int DepartureHour, int DepartureMinute, int PassengerHour, int PassengerMinute)
        {
            int TimeArrive = ArrivalHour * 60 + ArrivalMinute;
            int TimeDeparture = DepartureHour * 60 + DepartureMinute;
            int TimePassenger = PassengerHour * 60 + PassengerMinute;

            if (TimeArrive >= TimeDeparture) return "Время прибытия позже времени отбытия или равно ему!";
            if (TimePassenger < TimeDeparture && TimePassenger > TimeArrive)
            {
                return "Поезд находится на станции";
            }
            else
            {
                return "Поезд не находится на станции";
            }

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите час прибытия поезда:");
            var ArrivalHour = int.Parse(Console.ReadLine());

            Console.Write("Введите минуту(ы) прибытия поезда:");
            var ArrivalMinute = int.Parse(Console.ReadLine());

            Console.Write("Введите час отбытия поезда:");
            var DepartureHour = int.Parse(Console.ReadLine());

            Console.Write("Введите минуту(ы) отбытия поезда:");
            var DepartureMinute = int.Parse(Console.ReadLine());

            Console.Write("Введите час прихода на станцию пассажира:");
            var PassengerHour = int.Parse(Console.ReadLine());

            Console.Write("Введите минуту(ы) прихода на станцию пассажира:");
            var PassengerMinute = int.Parse(Console.ReadLine());

            var resultMSG = Logic.CompareTrainInStation(ArrivalHour, ArrivalMinute, DepartureHour, DepartureMinute, PassengerHour, PassengerMinute);


            Console.WriteLine(resultMSG);

        }
    }
}
