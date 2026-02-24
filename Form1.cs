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
            DateTime arrivalTime = Convert.ToDateTime(this.arriveTimePicker.Value);

            int trainArriveH = arrivalTime.Hour;

            int trainArriveM = arrivalTime.Minute;

            DateTime departureTime = Convert.ToDateTime(this.departureTimePicker.Value);

            int trainDepartH = departureTime.Hour;

            int trainDepartM = departureTime.Minute;

            DateTime passengerTime = Convert.ToDateTime(this.passengerTimePicker.Value);

            int passArriveH = passengerTime.Hour;

            int passArriveM = passengerTime.Minute;

            MessageBox.Show($"Поезд {Logic.GetAnswer(trainArriveH, trainArriveM, trainDepartH, trainDepartM, passArriveH, passArriveM)} стоять на платформе");
        }
    }

    public class Logic
    {
        public static string GetAnswer(int trainArriveH, int trainArriveM, int trainDepartH, int trainDepartM, int passH, int passM)
        {
            bool willTrainPlatform = WillTrainBeOnPlatform(trainArriveH, trainArriveM, trainDepartH, trainDepartM, passH, passM);

            return (willTrainPlatform ? ("") : ("не ")) + "будет";
        }

        private static bool WillTrainBeOnPlatform(int trainArriveH, int trainArriveM, int trainDepartH, int trainDepartM, int passH, int passM)
        {
            const int minutesPerHour = 60;

            bool willTrainPlatform = false;

            int arriveTotalM = trainArriveH * minutesPerHour + trainArriveM;

            int departTotalM = trainDepartH * minutesPerHour + trainDepartM;

            int passTotalM = passH * minutesPerHour + passM;

            if (arriveTotalM <= departTotalM)
            {
                if (passTotalM >= arriveTotalM && passTotalM < departTotalM)
                {
                    willTrainPlatform = true;
                }
            }
            else
            {
                if (passTotalM >= arriveTotalM)
                {
                    willTrainPlatform = true;
                }
                else if (passTotalM < departTotalM)
                {
                    willTrainPlatform = true;
                }
            }

            return willTrainPlatform;
        }
    }
}
