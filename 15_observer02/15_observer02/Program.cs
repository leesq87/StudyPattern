using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace _15_observer02
{
    //상속받을 옵저버들이 필수적으로 가져야할 메서드
    public interface Observer
    {
        void Update(float temperature, float humidity, float pressure);
    }

    //상속받을 주제클래스가 필수적으로 가져야할 메서드
    public interface Subject : Observer
    {
        void RegisterObserver(Observer o);
        void RemoveObserver(Observer o);
        void NotifyObservers();
    }

    //상속받을 옵저버들이 필수적으로 가져야할 메서드
    public interface DisplayElement
    {
        void Display();
    }


    public class WeatherData : Subject
    {
        private ArrayList observers;
        private float temperature;
        private float humidity;
        private float pressure;


        //상속받은 subject인터페이스가 observer인터페이스를 상속을 받았기에..
        public void Update(float temperature, float humidity, float pressure)
        {
        }

        //주제 클래스가 생성될때 컬렉션을 하나 생성

        public WeatherData()
        {
            observers = new ArrayList();
        }

        //옵저버를 추가하는 메서드
        public void RegisterObserver(Observer o)
        {
            observers.Add(o);
            Console.WriteLine(observers[observers.Count - 1].ToString());
        }

        //옵저버를 제거하는 메서드
        public void RemoveObserver(Observer o)
        {
            int i = observers.IndexOf(o);
            if (i >= 0)
                observers.Remove(i);

        }

        //옵저버를 찾아가서 그 값을 주고 출력한다.
        public void NotifyObservers()
        {
            //루프를 돌려서 옵저버가 등록된 것 마다 값을 준다.
            for (int i = 0; i < observers.Count; i++)
            {
                Observer observer = (Observer)observers[i];
                observer.Update(temperature, humidity, pressure);
            }
        }

        //측정변경
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        //측정값 셋팅
        public void SetMeasurement(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }

    }

    //옵저버 클래스
    //옵저버에 등록할 observer인터페이스와 표현할 displayelement를 상속받는다.
    public class CurrentConditionsDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;

        //생성자 등록
        //subject객체인 weatherData클래스를 매개변수로 받고, 자신을 옵저버로 등록한다.
        public CurrentConditionsDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);

        }

        //subject객체에 옵저버로 등록하였다면 subject객체가 옵저버로 등록한
        //클래스를 직접 찾아서 정보를 주고 정보를 받은 옵저버는 이를 자신의 변환단계를 거쳐서 보여주게 된다.
        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("current conditions : " + temperature + " F degrees and " + humidity + " % humidity");
        }

    }

    public class NameDisplay : Observer, DisplayElement
    {
        private Subject weatherData;

        public NameDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            Display();
        }

        public void Display()
        {
            Console.WriteLine("현제 온도를 보여드리겠습니다.");
        }

    }

    public class EnterDisplay : Observer, DisplayElement
    {
        private Subject weatherData;
        public EnterDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            Display();
        }

        public void Display()
        {
            Console.WriteLine("\n\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //subject객체 생성
            WeatherData weatherData = new WeatherData();
            //옵저버 등록
            NameDisplay nameDisplay = new NameDisplay(weatherData);
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            EnterDisplay enter = new EnterDisplay(weatherData);

            //subject객체에 등록된 옵저버에 따른 출력 상황
            weatherData.SetMeasurement(80, 65, 30.4f);
            weatherData.SetMeasurement(82, 75, 29.2f);
            weatherData.SetMeasurement(78, 90, 29.2f);

        }
    }
}
