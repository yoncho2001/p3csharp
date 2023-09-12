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
        }

        public int HoursIdle
        {
            get
            {
                return hoursIdle;
            }
        }

        public int HoursTalk
        {
            get
            {
                return hoursTalk;
            }
        }

        public BatteryType BatteryType
        {
            get
            {
                return batteryType;
            }
        }

        public Battery()
        {
            this.model = "";
            this.hoursIdle = 0;
            this.hoursTalk = 0;
            this. batteryType = default(BatteryType);
        }

        public Battery(string model)
        {
            this.model = model;
            this.hoursIdle = 0;
            this.hoursTalk = 0;
            this.batteryType = default(BatteryType);
        }

        public Battery(string model, int hoursIdle, int hoursTalk, BatteryType batteryType)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.batteryType = batteryType;
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
        }

        public int Size
        {
            get
            {
                return size;
            }
        }

        public Display()
        {
            this.numberColor = 0;
            this.size = 0;
        }

        public Display(int numberColor, int size)
        {
            this.numberColor = numberColor;
            this.size = size;
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
        }

        public string DialledPhone
        {
            get
            {
                return dialledPhone;
            }
        }

        public int Duration
        {
            get
            {
                return duration;
            }
        }

        public Call()
        {
            this.dateTime = new DateTime();;
            this.dialledPhone = "0100000000";
            this.duration = 0;
        }

        public Call(DateTime dateTime, string dialledPhone, int duration)
        {
            this.dateTime = dateTime;
            this.dialledPhone = dialledPhone;
            this.duration = duration;
        }

        public Call(string dateTimeIput, string dialledPhone, int duration)
        {
            if (!DateTime.TryParseExact(dateTimeIput, "dd.MM.yyyy:HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime newDate))
            {
                throw new ArgumentException("The date dont mach the patern dd.MM.yyyy:HH:mm");
            }

            this.dateTime = newDate;
            this.dialledPhone = dialledPhone;
            this.duration = duration;
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
        }

        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }
        }

        public string Owner
        {
            get
            {
                return owner;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
        }

        public Battery Battery
        {
            get
            {
                return battery;
            }
        }

        public Display Display
        {
            get
            {
                return display;
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
            this.model = model;
            this.manufacturer = manufacturer;
            this.owner = "null";
            this.price = 0;
            this.battery = new Battery();
            this.display = new Display();
            this.calls = new List<Call>();
        }

        public GSM(string model, string manufacturer, string owner, double price, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.owner = owner;
            this.price = price;
            this.battery = battery;
            this.display = display;
            this.calls = new List<Call>();
        }

        public GSM(string model, string manufacturer, string owner, double price
            , string modelBattery, int batteryHoursIdle, int batteryHoursTalk, BatteryType batteryType
            , int displayNumberColor, int displaySize)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.owner = owner;
            this.price = price;
            this.battery = new Battery(modelBattery, batteryHoursIdle, batteryHoursTalk, batteryType);
            this.display = new Display(displayNumberColor, displaySize);
            this.calls = new List<Call>();
        }

        public void addCalls(Call newCall)
        {
           this.calls.Add(newCall);
        }

        public void addCalls(DateTime dateTime, string dialledPhone, int duration)
        {
           this.calls.Add(new Call(dateTime, dialledPhone, duration));
        }

        public void deleteLastCall()
        {
           this.calls.RemoveAt(calls.Count - 1);
        }

        public void clearCalls()
        {
           this.calls.Clear();
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