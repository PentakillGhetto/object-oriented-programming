namespace WindowsFormsApp3
{
    class MyDate
    {
        int day;
        int month;
        int year;

        public int Day { get { return day; } private set { day = value <= DaysInMonth(Year, Month) & value > 0 ? value : day; } }
        public int Month { get { return month; } private set { month = value <= 12 & value > 0 ? value : month; } }
        public int Year { get { return year; } private set { year = value > 0 ? value : year; } }

        public MyDate() { }
        public MyDate(int day, int month, int year)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        public void NextDate()
        {
            if (Day + 1 > DaysInMonth(Year, Month))
            {
                if (Month + 1 > 12)
                {
                    Year++;
                    Month = 1;
                    Day = 1;
                }
                else if (Month == 2 & (Day == 28 || Day == 29))
                {
                    Month++;
                    Day = 1;
                }
                else
                {
                    Month++;
                    Day = 1;
                }
            }
            else Day++;
        }

        private int DaysInMonth(int year, int month)
        {
            if (year > 0 & month > 0 & month <= 12)
            {
                if (month == 2)
                {
                    if (IsLeap(year))
                    {
                        return 29;
                    }
                    return 28;
                }

                if ((month + 1) % 2 == 0) return 30;
                return 31;
            }
            return -1;
        }

        private bool IsLeap(int year)
        {
            if (year % 400 == 0 || year % 4 == 0)
            {
                return true;
            }
            return false;
        }

        private bool IsValid(int day, int month, int year)
        {
            if (month > 0 & month <= 12 & day > 0 & day <= DaysInMonth(year, month))
            {                
                return true;
            }
            return false;
        }

        public void SetDate(int day, int month, int year)
        {
            if (IsValid(day, month, year))
            {
                this.day = day;
                this.month = month;
                this.year = year;
            }
        }

        public override string ToString()
        {
            return Day.ToString() + '.' + Month.ToString() + '.' + Year.ToString();
        }
    }
}
