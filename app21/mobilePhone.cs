using System;
using System.Globalization;
using validate;

namespace Phone
{
    public enum BatteryType
    {
        LiIon,
        NiMH,
        NiCd
    }
    public class Battery
    {
        private string model;
        private int hoursIdle;
        private int hoursTalk;
        private BatteryType batteryType;

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                Validate.isString(value);
                model = value;
            }
        }

        public int HoursIdle
        {
            get
            {
                return hoursIdle;
            }

            set
            {
                Validate.isPositive(value);
                hoursIdle = value;
            }
        }

        public int HoursTalk
        {
            get
            {
                return hoursTalk;
            }

            set
            {
                Validate.isPositive(value);
                hoursTalk = value;
            }
        }

        public BatteryType BatteryType
        {
            get
            {
                return batteryType;
            }

            set
            {
                batteryType = value;
            }
        }

        public Battery()
        {
            Model = "null";
            HoursIdle = 0;
            HoursTalk = 0;
            BatteryType = BatteryType.LiIon;
        }

        public Battery(string model)
        {

            Model = model;
            HoursIdle = 0;
            HoursTalk = 0;
            BatteryType = BatteryType.LiIon;
        }

        public Battery(string model, int hoursIdle, int hoursTalk, BatteryType batteryType)
        {
            Model = model;
            HoursIdle = hoursIdle;
            HoursTalk = hoursTalk;
            BatteryType = batteryType;
        }

        public override string ToString()
        {
            return "Battery: \nModel- " + Model + ", HoursIdle- " + HoursIdle.ToString() + ", HoursTalk- " + HoursTalk.ToString() + ", BatteryType- " + BatteryType;
        }
    }

    public class Display
    {
        private int numberColor;
        private int size;

        public int NumberColor
        {
            get
            {
                return numberColor;
            }

            set
            {
                Validate.isPositive(value);
                numberColor = value;
            }
        }

        public int Size
        {
            get
            {
                return size;
            }

            set
            {
                Validate.isPositive(value);
                size = value;
            }
        }

        public Display()
        {
            NumberColor = 0;
            Size = 0;
        }

        public Display(int numberColor, int size)
        {
            NumberColor = numberColor;
            Size = size;
        }

        public override string ToString()
        {
            return "Display: \nNumber of colors- " + NumberColor.ToString() + ", Size- " + Size.ToString();
        }
    }

    public class Call
    {
        private DateTime dateTime;
        private string dialledPhone;
        private int duration;

        public DateTime DateTimeElement
        {
            get
            {
                return dateTime;
            }

            set
            {
                dateTime = value;
            }
        }

        public string DialledPhone
        {
            get
            {
                return dialledPhone;
            }

            set
            {
                Validate.isPhone(value);
                dialledPhone = value;
            }
        }

        public int Duration
        {
            get
            {
                return duration;
            }

            set
            {
                Validate.isPositive(value);
                duration = value;
            }
        }

        public Call()
        {
            DateTimeElement = new DateTime();;
            DialledPhone = "0100000000";
            Duration = 0;
        }

        public Call(DateTime dateTime, string dialledPhone, int duration)
        {
            DateTimeElement = dateTime;
            DialledPhone = dialledPhone;
            Duration = duration;
        }

        public Call(string dateTime, string dialledPhone, int duration)
        {
            if (!DateTime.TryParseExact(dateTime, "dd.MM.yyyy:HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime newDate))
            {
                throw new ArgumentException("The date dont mach the patern dd.MM.yyyy:HH:mm");
            }

            DateTimeElement = newDate;
            DialledPhone = dialledPhone;
            Duration = duration;
        }

        public override string ToString()
        {
            return "Date and time- " + DateTimeElement.ToString() + ", DialledPhone- " + DialledPhone + ", Duration- " + Duration.ToString();
        }
    }

    public class GSM
    {
        public static GSM iPhone4S = new GSM("4S", "Iphone", "Apple", 10000
            , "4X24H", 30, 20, BatteryType.NiMH
            , 2587, 12);

        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
        }
        private string model;
        private string manufacturer;
        private string owner;
        private double price;
        private Battery battery;
        private Display display;
        private List<Call> calls;

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                Validate.isString(value);
                model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }

            set
            {
                Validate.isString(value);
                manufacturer = value;
            }
        }

        public string Owner
        {
            get
            {
                return owner;
            }

            set
            {
                Validate.isString(value);
                owner = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                Validate.isPositive(value);
                price = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return battery;
            }

            set
            {
                Validate.isNull(value);
                battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return display;
            }

            set
            {
                Validate.isNull(value);
                display = value;
            }
        }

        public string CallHistory
        {
            get
            {
                string returnCalls = "Call history: \n";
            
                for (int i = calls.Count - 1; i >= 0 ; i--)
                {
                    returnCalls += calls[i].ToString() + "\n";
                }

                return returnCalls;
            }
        }

        public GSM(string model, string manufacturer)
        {
            Model = model;
            Manufacturer = manufacturer;
            Owner = "null";
            Price = 0;
            Battery = new Battery();
            Display = new Display();
            calls = new List<Call>();

        }

        public GSM(string model, string manufacturer, string owner, double price, Battery battery, Display display)
        {
            Model = model;
            Manufacturer = manufacturer;
            Owner = owner;
            Price = price;
            Battery = battery;
            Display = display;
            calls = new List<Call>();
        }

        public GSM(string model, string manufacturer, string owner, double price
            , string modelBattery, int batteryHoursIdle, int batteryHoursTalk, BatteryType batteryType
            , int displayNumberColor, int displaySize)
        {
            Model = model;
            Manufacturer = manufacturer;
            Owner = owner;
            Price = price;
            Battery = new Battery(modelBattery, batteryHoursIdle, batteryHoursTalk, batteryType);
            Display = new Display(displayNumberColor, displaySize);
            calls = new List<Call>();
        }

        public void addCalls(Call newCall)
        {
           calls.Add(newCall);
        }

        public void addCalls(DateTime dateTime, string dialledPhone, int duration)
        {
           calls.Add(new Call(dateTime, dialledPhone, duration));
        }

        public void deleteLastCall()
        {
           calls.RemoveAt(calls.Count - 1);
        }

        public void clearCalls()
        {
           calls.Clear();
        }

        public double CallPrice(double price)
        {
            Validate.isPositive(price);
            double seconds = 0;
            for (int i = 0; i < calls.Count; i++)
            {
                seconds += calls[i].Duration;
            }

            double fullPrice = (seconds / 60) * price;
            return fullPrice;
        }

        public override string ToString()
        {
            return "GSM: \nModel- " + model + ", Manufacturer- " + manufacturer + ", Owner- " + owner
                + ", Price- " + price.ToString() + "\n" + battery.ToString() + "\n" + display.ToString();
        }
    }
}