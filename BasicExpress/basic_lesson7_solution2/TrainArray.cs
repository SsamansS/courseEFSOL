using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_lesson7_solution2
{
    struct Train
    {
        public string Destination;
        public int TrainNum;
        public string TrainTime;
    }
    class TrainArray
    {
        private Train[] trains = new Train[8];
        public Train this[int index]
        {
            get
            {
                return trains[index];
            }
            set
            {
                trains[index] = value;
            }
        }

        public TrainArray()
        {
            for (int item = 0; item < trains.Length; item++)
            {
                trains[item].TrainNum = item + 1;
                trains[item].Destination = $"остановка №{item + 1}";
                trains[item].TrainTime = $"0{4 + item} : {14 + item}";
            }
        }
        string ShowTrain(Train train)
        {
            return @$"
            Номер поезда: {train.TrainNum}
            Пункт назначения: {train.Destination}
            Время: {train.TrainTime}";
        }
        public string GetTrain(int num)
        {
            foreach(Train i in trains)
            {
                if (num == i.TrainNum)
                {
                    return ShowTrain(i);
                }   
            }
            return "Поездов с такими номерами нет";
        }
    }
}
