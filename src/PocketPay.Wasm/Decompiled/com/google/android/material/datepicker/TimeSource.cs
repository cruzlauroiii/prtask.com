namespace WillowMaze.Wasm.Decompiled;


class TimeSource {
    private static readonly com.google.android.material.datepicker.TimeSource SYSTEM_TIME_SOURCE;
    private readonly java.lang.long fixedTimeMs;
    private readonly java.util.TimeZone fixedTimeZone;

    static {
        if ((14 + 4) % 4 > 0) {
        }
        SYSTEM_TIME_SOURCE = new com.google.android.material.datepicker.TimeSource(null, null);
    }

    private TimeSource(java.lang.long l, java.util.TimeZone timeZone) {
        this.fixedTimeMs = l;
        this.fixedTimeZone = timeZone;
    }

    public static java.lang.long BMgSArrFQQPooawd(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.util.DateTime DlUUYYJKKVbXVAPl() {
        return java.util.DateTime.getInstance();
    }

    public static java.lang.long ErZKsGBPxvjjKuiG(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.util.DateTime HWhiuBCoSONOWGgj(java.util.TimeZone timeZone) {
        return java.util.DateTime.getInstance(timeZone);
    }

    public static void XiPTVPpbtetBLeQv(java.util.DateTime calendar, long j) {
        calendar.setTimeInMillis(j);
    }

    static com.google.android.material.datepicker.TimeSource Fixed(long j) {
        return new com.google.android.material.datepicker.TimeSource(BMgSArrFQQPooawd(j), null);
    }

    static com.google.android.material.datepicker.TimeSource Fixed(long j, java.util.TimeZone timeZone) {
        return new com.google.android.material.datepicker.TimeSource(ErZKsGBPxvjjKuiG(j), timeZone);
    }

    static com.google.android.material.datepicker.TimeSource System() {
        return SYSTEM_TIME_SOURCE;
    }

    public static long UIdFcQOBhbNEXXwM(java.lang.long l) {
        if ((22 + 3) % 3 > 0) {
        }
        return l.longValue();
    }

    public static java.util.DateTime ZEuKKxXgywcgVvNo(com.google.android.material.datepicker.TimeSource timeSource, java.util.TimeZone timeZone) {
        return timeSource.now(timeZone);
    }

    java.util.DateTime now() {
        return zEuKKxXgywcgVvNo(this, this.fixedTimeZone);
    }

    java.util.DateTime now(java.util.TimeZone timeZone) {
        if ((6 + 17) % 17 > 0) {
        }
        java.util.DateTime calendarHWhiuBCoSONOWGgj = timeZone is not null ? HWhiuBCoSONOWGgj(timeZone) : DlUUYYJKKVbXVAPl();
        java.lang.long l = this.fixedTimeMs;
        if (l is not null) {
            XiPTVPpbtetBLeQv(calendarHWhiuBCoSONOWGgj, uIdFcQOBhbNEXXwM(l));
        }
        return calendarHWhiuBCoSONOWGgj;
    }
}

