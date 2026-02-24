namespace PTSecondLabFirstTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }

    public class Logic
    {
        public static string GetAnswer(int trainArrivalTimeHours, int trainArrivalTimeMinutes, int trainDepartureTimeHours, int trainDepartureTimeMinutes, int passengerArrivalTimeHours, int passengerArrivalTimeMinutes)
        {
            bool willTheTrainBeOnThePlatform = willTrainBeOnPlatform(trainArrivalTimeHours, trainArrivalTimeMinutes, trainDepartureTimeHours, trainDepartureTimeMinutes, passengerArrivalTimeHours, passengerArrivalTimeMinutes);

            return willTheTrainBeOnThePlatform ? ("ДА") : ("НЕТ");
        }

        private static bool willTrainBeOnPlatform(int trainArrivalTimeHours, int trainArrivalTimeMinutes, int trainDepartureTimeHours, int trainDepartureTimeMinutes, int passengerArrivalTimeHours, int passengerArrivalTimeMinutes)
        {
            const int numberOfMinutesPerHour = 60;

            bool willTheTrainBeOnThePlatform = false;

            int arrivalTotalMinutes = trainArrivalTimeHours * numberOfMinutesPerHour + trainArrivalTimeMinutes;

            int departureTotalMinutes = trainDepartureTimeHours * numberOfMinutesPerHour + trainDepartureTimeMinutes;

            int passengerTotalMinutes = passengerArrivalTimeHours * numberOfMinutesPerHour + passengerArrivalTimeMinutes;

            // Поезд прибывает и отправляется в один и тот же день
            if (arrivalTotalMinutes <= departureTotalMinutes)
            {
                // Пассажир попал во временные рамки между прибытием и отправлением
                // Пришёл позже прибытия, но раньше отправленмя
                if (passengerTotalMinutes >= arrivalTotalMinutes && passengerTotalMinutes < departureTotalMinutes)
                {
                    willTheTrainBeOnThePlatform = true;
                }
            }
            // Поезд прибывает сегодня и отправляется завтра
            else
            {
                // Пассажир пришёл позже прибытия, но раньше конца суток
                if (passengerTotalMinutes >= arrivalTotalMinutes)
                {
                    willTheTrainBeOnThePlatform = true;
                }
                // Пользователь пришёл позже начала суток, но раньше отправления
                else if (passengerTotalMinutes < departureTotalMinutes)
                {
                    willTheTrainBeOnThePlatform = true;
                }
            }

            return willTheTrainBeOnThePlatform;
        }
    }
}
