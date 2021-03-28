using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SmartRoads
{
    public partial class MainWindow : Form
    {
        public static List<string> listDate = new List<string>();//Дата
        public static List<string> listTime = new List<string>();//Время
        public static List<string> listFriction = new List<string>();//Трение
        public static List<string> listState = new List<string>();//Состояние
        public static List<string> listTa = new List<string>();//Температруа воздуха
        public static List<string> listWater = new List<string>();//Толщина слоя воды
        public static int number = 1;

        public MainWindow()
        {

            InitializeComponent();

        }
        /// <summary>
        /// Заносит данные в листы
        /// </summary>
        /// <param name="numberOperation">количество проделанных операций</param>
        public void DataEntry()
        {
            number = Convert.ToInt32(textBoxSensorNumber.Text);
            using (var reader = new StreamReader(@textBoxFile.Text))//data path
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    //заполнение данными
                    if (values[0].Split('.')[0] == "2021")//запись показаний датчика без дополнительной информации
                    {
                        listDate.Add(values[0]);
                        listTime.Add(values[1]);
                        listFriction.Add(values[5]);
                        listState.Add(values[6]);
                        listTa.Add(values[7]);
                        listWater.Add(values[13]);
                    }
                }
            }
        }
        /// <summary>
        /// Считает рекомендуемую скорость и изменяет отображение
        /// </summary>
        /// <param name="numberArea">номер строки в данных</param>
        public void RecommendedSpeed(int numberArea)
        {
            //критерии снижения скорости
            double state = Convert.ToDouble(listState[numberArea]);// состояние дороги
            double friction = (0.81 - Convert.ToDouble(listFriction[numberArea].Replace('.', ','))) * 0.05;//трение
            double icePossible = 0.01;//возможность гололёда
            double water = Convert.ToDouble(listWater[numberArea].Replace('.', ',')) * 0.05;//толщина слоя воды

            //изменяем стсотяние дороги
            switch (Convert.ToInt32(state))
            {
                case 1:
                    state = 0.05;
                    break;
                case 2:
                    state = 0.1;
                    break;
                case 3:
                    state = 0.15;
                    break;
                case 4:
                    state = 0.3;
                    break;
                case 5:
                    state = 0.25;
                    break;
                case 6:
                    state = 0.2;
                    break;
            }
            //учитываем возможное появления гололёда на участке
            if (Convert.ToDouble(listTa[numberArea].Replace('.', ',')) < 0 & Convert.ToInt32(state) != 6)
            {
                icePossible = 0.15;
            }
            //преобразуем скорость до меньшего крастного пяти
            int speed = Convert.ToInt32(Convert.ToInt32(textBoxSpeedLimit.Text) / (1 + state + friction + icePossible + water));
            if (speed % 5 != 0)
            {
                speed -= Convert.ToInt32(speed % 5);
            }
            //возвращаем рекомендумую скорость
            labelSpeed.Text = Convert.ToString(speed);
            Thread.Sleep(2000);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            listDate.Clear();
            listFriction.Clear();
            listState.Clear();
            listTa.Clear();
            listTime.Clear();
            listWater.Clear();
            DataEntry();
            RecommendedSpeed(number);
        }
    }
}
