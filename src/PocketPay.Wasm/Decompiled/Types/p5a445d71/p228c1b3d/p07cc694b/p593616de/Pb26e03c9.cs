namespace WillowMaze.Wasm.Decompiled;

public abstract class Pb26e03c9 : P8c6072a9, P5dd6f3ce
{
    public int Get(p51c74e65 P0)
    {
        // str: "The DateTimeFieldType must not be null"
        // call: pb26e03c9.getChronology
        // call: IllegalArgumentException.<init>
        // call: p51c74e65.getField
        // call: pb26e03c9.getMillis
        // call: p8b1ed2c5.get
        // type: IllegalArgumentException
        return 0;
    }

    public int GetCenturyOfEra()
    {
        // call: p8b1ed2c5.get
        // call: pb26e03c9.getMillis
        // call: pb26e03c9.getChronology
        // call: p7bf898de.centuryOfEra
        return 0;
    }

    public int GetDayOfMonth()
    {
        // call: pb26e03c9.getMillis
        // call: p7bf898de.dayOfMonth
        // call: pb26e03c9.getChronology
        // call: p8b1ed2c5.get
        return 0;
    }

    public int GetDayOfWeek()
    {
        // call: pb26e03c9.getChronology
        // call: pb26e03c9.getMillis
        // call: p8b1ed2c5.get
        // call: p7bf898de.dayOfWeek
        return 0;
    }

    public int GetDayOfYear()
    {
        // call: pb26e03c9.getChronology
        // call: p8b1ed2c5.get
        // call: p7bf898de.dayOfYear
        // call: pb26e03c9.getMillis
        return 0;
    }

    public int GetEra()
    {
        // call: pb26e03c9.getChronology
        // call: p7bf898de.era
        // call: p8b1ed2c5.get
        // call: pb26e03c9.getMillis
        return 0;
    }

    public int GetHourOfDay()
    {
        // call: p7bf898de.hourOfDay
        // call: p8b1ed2c5.get
        // call: pb26e03c9.getMillis
        // call: pb26e03c9.getChronology
        return 0;
    }

    public int GetMillisOfDay()
    {
        // call: pb26e03c9.getChronology
        // call: p7bf898de.millisOfDay
        // call: pb26e03c9.getMillis
        // call: p8b1ed2c5.get
        return 0;
    }

    public int GetMillisOfSecond()
    {
        // call: pb26e03c9.getMillis
        // call: p8b1ed2c5.get
        // call: pb26e03c9.getChronology
        // call: p7bf898de.millisOfSecond
        return 0;
    }

    public int GetMinuteOfDay()
    {
        // call: p7bf898de.minuteOfDay
        // call: pb26e03c9.getChronology
        // call: p8b1ed2c5.get
        // call: pb26e03c9.getMillis
        return 0;
    }

    public int GetMinuteOfHour()
    {
        // call: pb26e03c9.getChronology
        // call: p7bf898de.minuteOfHour
        // call: pb26e03c9.getMillis
        // call: p8b1ed2c5.get
        return 0;
    }

    public int GetMonthOfYear()
    {
        // call: pb26e03c9.getMillis
        // call: p8b1ed2c5.get
        // call: pb26e03c9.getChronology
        // call: p7bf898de.monthOfYear
        return 0;
    }

    public int GetSecondOfDay()
    {
        // call: p8b1ed2c5.get
        // call: pb26e03c9.getMillis
        // call: p7bf898de.secondOfDay
        // call: pb26e03c9.getChronology
        return 0;
    }

    public int GetSecondOfMinute()
    {
        // call: p7bf898de.secondOfMinute
        // call: pb26e03c9.getMillis
        // call: pb26e03c9.getChronology
        // call: p8b1ed2c5.get
        return 0;
    }

    public int GetWeekOfWeekyear()
    {
        // call: pb26e03c9.getMillis
        // call: pb26e03c9.getChronology
        // call: p7bf898de.weekOfWeekyear
        // call: p8b1ed2c5.get
        return 0;
    }

    public int GetWeekyear()
    {
        // call: p8b1ed2c5.get
        // call: p7bf898de.weekyear
        // call: pb26e03c9.getMillis
        // call: pb26e03c9.getChronology
        return 0;
    }

    public int GetYear()
    {
        // call: pb26e03c9.getChronology
        // call: pb26e03c9.getMillis
        // call: p8b1ed2c5.get
        // call: p7bf898de.year
        return 0;
    }

    public int GetYearOfCentury()
    {
        // call: p8b1ed2c5.get
        // call: pb26e03c9.getMillis
        // call: p7bf898de.yearOfCentury
        // call: pb26e03c9.getChronology
        return 0;
    }

    public int GetYearOfEra()
    {
        // call: p7bf898de.yearOfEra
        // call: pb26e03c9.getChronology
        // call: p8b1ed2c5.get
        // call: pb26e03c9.getMillis
        return 0;
    }

    public DateTime ToCalendar(CultureInfo P0)
    {
        // call: pb26e03c9.toDate
        // call: DateTime.setTime
        // call: DateTime.getInstance
        // call: p34dacb78.toTimeZone
        // call: CultureInfo.getDefault
        // call: pb26e03c9.getZone
        return default!;
    }

    public DateTime ToGregorianCalendar()
    {
        // call: pb26e03c9.toDate
        // call: DateTime.setTime
        // call: pb26e03c9.getZone
        // call: p34dacb78.toTimeZone
        // call: DateTime.<init>
        // type: DateTime
        return default!;
    }

    public string ToString()
    {
        // call: p8c6072a9.toString
        return string.Empty;
    }

    public string ToString(string P0)
    {
        // call: p048c1932.print
        // call: pb26e03c9.toString
        // call: p24e21e29.m133d8376
        return string.Empty;
    }

    public string ToString(string P0, CultureInfo P1)
    {
        // call: p24e21e29.m133d8376
        // call: p048c1932.withLocale
        // call: p048c1932.print
        // call: pb26e03c9.toString
        return string.Empty;
    }

}
