namespace Tasks
{
    internal class Task7_Program
    {
        public void Task_7()
        {
            Task7_Vehicle car = new Task7_Car();
            Task7_Vehicle motorcycle = new Task7_Motorcycle();

            car.Brand = "BMW";
            car.Year = 2012;

            motorcycle.Brand = "NINJA";
            motorcycle.Year = 2020;

            car.Run();
            motorcycle.Run();
        }
    }
}
