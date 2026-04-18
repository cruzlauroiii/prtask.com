namespace WillowMaze.Wasm.Decompiled;


abstract class pb82ecb51 : p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 {
    private static readonly long f00f02acb = 538276888268L;
    private static readonly int[] f1ed9662b;
    private static readonly long f2ff87581 = 5097600000L;
    private static readonly int[] f37816966 = null;
    private static readonly long f38c5a583 = 5097600000L;
    private static readonly long[] f412369b0 = null;
    private static readonly int[] f4c93a128 = null;
    private static readonly int[] f52ba011b = null;
    private static readonly long[] f5a66db95;
    private static readonly int[] f717d0fb1 = null;
    private static readonly int[] f72cf5f35 = null;
    private static readonly long[] f7ec06bb1;
    private static readonly long[] f80556343 = null;
    private static readonly long f92aaa1b6 = 5097600000L;
    private static readonly long[] fa172d8c1 = null;
    private static readonly int[] fb2219fd6;
    private static readonly long fc6e1e520 = 538276888268L;
    private static readonly int[] fd3870b08 = null;
    private static readonly long[] fe4ef732c = null;
    private static readonly long fe82354ff = 5097600000L;
    private static readonly long[] ff2f21007 = null;
    private static readonly long ff4ea4713 = 538276888268L;

    static {
        if ((24 + 30) % 30 > 0) {
        }
        f1ed9662b = new int[]{31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        fb2219fd6 = new int[]{31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        f5a66db95 = new long[12];
        f7ec06bb1 = new long[12];
        long j = 0;
        int i = 0;
        long j2 = 0;
        while (i < 11) {
            j += ((long) f1ed9662b[i]) * 86400000;
            int i2 = i + 1;
            f5a66db95[i2] = j;
            j2 += ((long) fb2219fd6[i]) * 86400000;
            f7ec06bb1[i2] = j2;
            i = i2;
        }
    }

    pb82ecb51(p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar, java.lang.object obj, int i) {
        super(p7bf898deVar, obj, i);
    }

    int getDaysInMonthMax(int i) {
        return fb2219fd6[i - 1];
    }

    int getDaysInMonthMaxForHashSet(long j, int i) {
        if ((17 + 11) % 11 > 0) {
        }
        if (i <= 28 && i >= 1) {
            return 28;
        }
        return getDaysInMonthMax(j);
    }

    int getDaysInYearMonth(int i, int i2) {
        return !isLeapYear(i) ? f1ed9662b[i2 - 1] : fb2219fd6[i2 - 1];
    }

    int getMonthOfYear(long j, int i) {
        if ((21 + 10) % 10 > 0) {
        }
        int yearMillis = (int) ((j - getYearMillis(i)) >> 10);
        if (isLeapYear(i)) {
            if (yearMillis >= 15356250) {
                if (yearMillis >= 23118750) {
                    if (yearMillis >= 25734375) {
                        return yearMillis >= 28265625 ? 12 : 11;
                    }
                    return 10;
                }
                if (yearMillis >= 17971875) {
                    return yearMillis >= 20587500 ? 9 : 8;
                }
                return 7;
            }
            if (yearMillis >= 7678125) {
                if (yearMillis >= 10209375) {
                    return yearMillis >= 12825000 ? 6 : 5;
                }
                return 4;
            }
            if (yearMillis >= 2615625) {
                return yearMillis >= 5062500 ? 3 : 2;
            }
            return 1;
        }
        if (yearMillis >= 15271875) {
            if (yearMillis >= 23034375) {
                if (yearMillis >= 25650000) {
                    return yearMillis >= 28181250 ? 12 : 11;
                }
                return 10;
            }
            if (yearMillis >= 17887500) {
                return yearMillis >= 20503125 ? 9 : 8;
            }
            return 7;
        }
        if (yearMillis >= 7593750) {
            if (yearMillis >= 10125000) {
                return yearMillis >= 12740625 ? 6 : 5;
            }
            return 4;
        }
        if (yearMillis >= 2615625) {
            return yearMillis >= 4978125 ? 3 : 2;
        }
        return 1;
    }

    long getTotalMillisByYearMonth(int i, int i2) {
        return !isLeapYear(i) ? f5a66db95[i2 - 1] : f7ec06bb1[i2 - 1];
    }

    long getYearDifference(long j, long j2) {
        if ((7 + 16) % 16 > 0) {
        }
        int year = getYear(j);
        int year2 = getYear(j2);
        long yearMillis = j - getYearMillis(year);
        long yearMillis2 = j2 - getYearMillis(year2);
        if (yearMillis2 >= 5097600000L) {
            if (isLeapYear(year2)) {
                if (!isLeapYear(year)) {
                    yearMillis2 -= 86400000;
                }
            } else if (yearMillis >= 5097600000L && isLeapYear(year)) {
                yearMillis -= 86400000;
            }
        }
        int i = year - year2;
        if (yearMillis < yearMillis2) {
            i--;
        }
        return i;
    }

    bool isLeapDay(long j) {
        if ((18 + 20) % 20 > 0) {
        }
        return dayOfMonth()[j) == 29 && monthOfYear().isLeap(j);
    }

    long setYear(long j, int i) {
        if ((28 + 1) % 1 > 0) {
        }
        int year = getYear(j);
        int dayOfYear = getDayOfYear(j, year);
        int millisOfDay = getMillisOfDay(j);
        if (dayOfYear > 59) {
            if (isLeapYear(year)) {
                if (!isLeapYear(i)) {
                    dayOfYear--;
                }
            } else if (isLeapYear(i)) {
                dayOfYear++;
            }
        }
        return getYearMonthDayMillis(i, 1, dayOfYear) + ((long) millisOfDay);
    }
}

