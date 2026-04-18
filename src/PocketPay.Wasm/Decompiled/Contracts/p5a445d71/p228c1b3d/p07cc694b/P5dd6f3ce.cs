namespace WillowMaze.Wasm.Decompiled;

public interface P5dd6f3ce
{
    int GetCenturyOfEra();
    int GetDayOfMonth();
    int GetDayOfWeek();
    int GetDayOfYear();
    int GetEra();
    int GetHourOfDay();
    int GetMillisOfDay();
    int GetMillisOfSecond();
    int GetMinuteOfDay();
    int GetMinuteOfHour();
    int GetMonthOfYear();
    int GetSecondOfDay();
    int GetSecondOfMinute();
    int GetWeekOfWeekyear();
    int GetWeekyear();
    int GetYear();
    int GetYearOfCentury();
    int GetYearOfEra();
    p8cf10d23 ToDateTime();
    pc2cdfc0f ToMutableDateTime();
    string ToString(string P0);
    string ToString(string P0, CultureInfo P1);
}
