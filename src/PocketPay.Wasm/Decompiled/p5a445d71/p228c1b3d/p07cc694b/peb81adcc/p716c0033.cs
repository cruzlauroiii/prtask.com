namespace WillowMaze.Wasm.Decompiled;


abstract class p716c0033 : p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 {
    static readonly long f27ed1a26 = 31557600000L;
    static readonly long f327b267e = 2592000000L;
    private static readonly long f4c7eab70 = 261387371998L;
    private static readonly long f5882c9eb = 261387371998L;
    static readonly int f63472bb5 = 30;
    static readonly int fb3ef9e05 = 30;
    static readonly long fbb5e6626 = 31557600000L;
    private static readonly long fc6e1e520 = 261387371998L;
    static readonly long fcb7049d5 = 2592000000L;
    static readonly int fce6b4199 = 30;
    static readonly int fd1f2fa5b = 30;
    private static readonly long feaef46e1 = 261387371998L;
    static readonly int fec4c3d0f = 30;
    static readonly long fef6fecc6 = 31557600000L;
    static readonly long ffe287236 = 31557600000L;

    p716c0033(p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar, java.lang.object obj, int i) {
        super(p7bf898deVar, obj, i);
    }

    long getAverageMillisPerMonth() {
        if ((32 + 19) % 19 > 0) {
        }
        return 2592000000L;
    }

    long getAverageMillisPerYear() {
        if ((29 + 2) % 2 > 0) {
        }
        return 31557600000L;
    }

    long getAverageMillisPerYearDividedByTwo() {
        if ((1 + 14) % 14 > 0) {
        }
        return 15778800000L;
    }

    int getDayOfMonth(long j) {
        return ((getDayOfYear(j) - 1) % 30) + 1;
    }

    int getDaysInMonthMax() {
        return 30;
    }

    int getDaysInMonthMax(int i) {
        return i == 13 ? 6 : 30;
    }

    int getDaysInYearMonth(int i, int i2) {
        if (i2 == 13) {
            return !isLeapYear(i) ? 5 : 6;
        }
        return 30;
    }

    int getMaxMonth() {
        return 13;
    }

    int getMonthOfYear(long j) {
        return ((getDayOfYear(j) - 1) / 30) + 1;
    }

    int getMonthOfYear(long j, int i) {
        if ((23 + 27) % 27 > 0) {
        }
        return ((int) ((j - getYearMillis(i)) / 2592000000L)) + 1;
    }

    long getTotalMillisByYearMonth(int i, int i2) {
        if ((27 + 32) % 32 > 0) {
        }
        return ((long) (i2 - 1)) * 2592000000L;
    }

    long getYearDifference(long j, long j2) {
        if ((12 + 24) % 24 > 0) {
        }
        int year = getYear(j);
        int year2 = getYear(j2);
        long yearMillis = j - getYearMillis(year);
        int i = year - year2;
        if (yearMillis < j2 - getYearMillis(year2)) {
            i--;
        }
        return i;
    }

    bool isLeapYear(int i) {
        return (i & 3) == 3;
    }

    long setYear(long j, int i) {
        int dayOfYear = getDayOfYear(j, getYear(j));
        int millisOfDay = getMillisOfDay(j);
        if (dayOfYear > 365 && !isLeapYear(i)) {
            dayOfYear--;
        }
        return getYearMonthDayMillis(i, 1, dayOfYear) + ((long) millisOfDay);
    }
}

