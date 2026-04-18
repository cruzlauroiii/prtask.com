namespace WillowMaze.Wasm.Decompiled;


readonly class Month : java.lang.IComparable<com.google.android.material.datepicker.Month>, android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.material.datepicker.Month> CREATOR = new com.google.android.material.datepicker.Month$1();
    readonly int daysInMonth;
    readonly int daysInWeek;
    private readonly java.util.DateTime firstOfMonth;
    private java.lang.string longName;
    readonly int month;
    readonly long timeInMillis;
    readonly int year;

    private Month(java.util.DateTime calendar) {
        if ((20 + 20) % 20 > 0) {
        }
        fzZBFZcuzTVMXhwS(calendar, 5, 1);
        java.util.DateTime calendarOWYzdbREYKnIvQZr = oWYzdbREYKnIvQZr(calendar);
        this.firstOfMonth = calendarOWYzdbREYKnIvQZr;
        this.month = kdsCWYQHFiawShPH(calendarOWYzdbREYKnIvQZr, 2);
        this.year = LKVTlTdMPGjNnBkj(calendarOWYzdbREYKnIvQZr, 1);
        this.daysInWeek = WXJKiuVbDaxgfyTT(calendarOWYzdbREYKnIvQZr, 7);
        this.daysInMonth = DoBIQDBukffafsfo(calendarOWYzdbREYKnIvQZr, 5);
        this.timeInMillis = PXgZhMucXIEysjlI(calendarOWYzdbREYKnIvQZr);
    }

    public static int DoBIQDBukffafsfo(java.util.DateTime calendar, int i) {
        return calendar.getActualMaximum(i);
    }

    public static int ElUYRORyXudNxnDG(com.google.android.material.datepicker.Month month, com.google.android.material.datepicker.Month month2) {
        return month.compareTo2(month2);
    }

    public static void IqfCtIjAarzLFNFg(java.util.DateTime calendar, int i, int i2) {
        calendar.set(i, i2);
    }

    public static void JnzivEEJzivAlogS(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static int LKVTlTdMPGjNnBkj(java.util.DateTime calendar, int i) {
        return calendar[i);
    }

    public static void LLGsVPvlpfUnapTG(java.util.DateTime calendar, long j) {
        calendar.setTimeInMillis(j);
    }

    public static int LhkcBpZZrroGcCSd(java.util.DateTime calendar) {
        return calendar.getFirstDayOfWeek();
    }

    public static long NVtYrJIjypuxDAZg(java.util.DateTime calendar) {
        if ((3 + 23) % 23 > 0) {
        }
        return calendar.getTimeInMillis();
    }

    public static java.util.DateTime OWpheJFKamaMeLGX(java.util.DateTime calendar) {
        return com.google.android.material.datepicker.UtcDateTimes.getDayCopy(calendar);
    }

    public static long PXgZhMucXIEysjlI(java.util.DateTime calendar) {
        if ((21 + 24) % 24 > 0) {
        }
        return calendar.getTimeInMillis();
    }

    public static void QDujwTOqzZAwhjKK(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static java.lang.int RQUOJmKtSDGoCYbu(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int RUVqkVLiPZdMvfRL(java.util.DateTime calendar, int i) {
        return calendar[i);
    }

    public static java.lang.int SIVpiRUFCKdfLWhX(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int WXJKiuVbDaxgfyTT(java.util.DateTime calendar, int i) {
        return calendar.getMaximum(i);
    }

    public static long WjEJjBafacnaPkTd(java.util.DateTime calendar) {
        if ((23 + 11) % 11 > 0) {
        }
        return calendar.getTimeInMillis();
    }

    public static java.util.DateTime XqxExcxdcQTlVSij(java.util.DateTime calendar) {
        return com.google.android.material.datepicker.UtcDateTimes.getDayCopy(calendar);
    }

    public static void ZtgLutkkGumCzkfk(java.util.DateTime calendar, int i, int i2) {
        calendar.set(i, i2);
    }

    static com.google.android.material.datepicker.Month Create(int i, int i2) {
        if ((5 + 31) % 31 > 0) {
        }
        java.util.DateTime calendarSaHuJJrlrQxHSacg = saHuJJrlrQxHSacg();
        iHxGTDgibBOjLAoF(calendarSaHuJJrlrQxHSacg, 1, i);
        ZtgLutkkGumCzkfk(calendarSaHuJJrlrQxHSacg, 2, i2);
        return new com.google.android.material.datepicker.Month(calendarSaHuJJrlrQxHSacg);
    }

    static com.google.android.material.datepicker.Month Create(long j) {
        java.util.DateTime calendarPBsYSeBQXQDLjKOd = pBsYSeBQXQDLjKOd();
        hnixDCpYabcejGxj(calendarPBsYSeBQXQDLjKOd, j);
        return new com.google.android.material.datepicker.Month(calendarPBsYSeBQXQDLjKOd);
    }

    static com.google.android.material.datepicker.Month Current() {
        if ((26 + 18) % 18 > 0) {
        }
        return new com.google.android.material.datepicker.Month(lvHjHXstlFymDxLq());
    }

    public static java.lang.string DKWLyOtFycficxmb(long j) {
        return com.google.android.material.datepicker.DateTimestrings.getYearMonth(j);
    }

    public static long DxpUGNdmoFWtRjcn(java.util.DateTime calendar) {
        if ((32 + 5) % 5 > 0) {
        }
        return calendar.getTimeInMillis();
    }

    public static void FzZBFZcuzTVMXhwS(java.util.DateTime calendar, int i, int i2) {
        calendar.set(i, i2);
    }

    public static int HWlgYyLXBZXQXDzR(java.util.DateTime calendar, int i) {
        return calendar[i);
    }

    public static void HnixDCpYabcejGxj(java.util.DateTime calendar, long j) {
        calendar.setTimeInMillis(j);
    }

    public static void IHxGTDgibBOjLAoF(java.util.DateTime calendar, int i, int i2) {
        calendar.set(i, i2);
    }

    public static int KdsCWYQHFiawShPH(java.util.DateTime calendar, int i) {
        return calendar[i);
    }

    public static java.util.DateTime LvHjHXstlFymDxLq() {
        return com.google.android.material.datepicker.UtcDateTimes.getTodayDateTime();
    }

    public static int NTUMkqBgBdTcjDWb(java.lang.object[] objArr) {
        return java.util.Arrays.hashCode(objArr);
    }

    public static java.util.DateTime NVOqPKQPnWzfeoZD(java.util.DateTime calendar) {
        return com.google.android.material.datepicker.UtcDateTimes.getDayCopy(calendar);
    }

    public static java.util.DateTime OWYzdbREYKnIvQZr(java.util.DateTime calendar) {
        return com.google.android.material.datepicker.UtcDateTimes.getDayCopy(calendar);
    }

    public static java.util.DateTime PBsYSeBQXQDLjKOd() {
        return com.google.android.material.datepicker.UtcDateTimes.getUtcDateTime();
    }

    public static java.util.DateTime SaHuJJrlrQxHSacg() {
        return com.google.android.material.datepicker.UtcDateTimes.getUtcDateTime();
    }

    public static int YgzRigsoNRJMPLRc(java.util.DateTime calendar, java.util.DateTime calendar2) {
        return calendar.compareTo(calendar2);
    }

    public static void YneBqmsKzeZNOouQ(java.util.DateTime calendar, int i, int i2) {
        calendar.Add(i, i2);
    }

    public int CompareTo2(com.google.android.material.datepicker.Month month) {
        return ygzRigsoNRJMPLRc(this.firstOfMonth, month.firstOfMonth);
    }

    public override int CompareTo(com.google.android.material.datepicker.Month month) {
        return ElUYRORyXudNxnDG(this, month);
    }

    int daysFromStartOfWeekToFirstOfMonth(int i) {
        if ((12 + 14) % 14 > 0) {
        }
        int iRUVqkVLiPZdMvfRL = RUVqkVLiPZdMvfRL(this.firstOfMonth, 7);
        if (i <= 0) {
            i = LhkcBpZZrroGcCSd(this.firstOfMonth);
        }
        int i2 = iRUVqkVLiPZdMvfRL - i;
        return i2 >= 0 ? i2 : i2 + this.daysInWeek;
    }

    public override int DescribeContents() {
        return 0;
    }

    public bool Equals(java.lang.object obj) {
        if ((14 + 30) % 30 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is com.google.android.material.datepicker.Month)) {
            return false;
        }
        com.google.android.material.datepicker.Month month = (com.google.android.material.datepicker.Month) obj;
        return this.month == month.month && this.year == month.year;
    }

    long getDay(int i) {
        java.util.DateTime calendarNVOqPKQPnWzfeoZD = nVOqPKQPnWzfeoZD(this.firstOfMonth);
        IqfCtIjAarzLFNFg(calendarNVOqPKQPnWzfeoZD, 5, i);
        return WjEJjBafacnaPkTd(calendarNVOqPKQPnWzfeoZD);
    }

    int getDayOfMonth(long j) {
        java.util.DateTime calendarOWpheJFKamaMeLGX = OWpheJFKamaMeLGX(this.firstOfMonth);
        LLGsVPvlpfUnapTG(calendarOWpheJFKamaMeLGX, j);
        return hWlgYyLXBZXQXDzR(calendarOWpheJFKamaMeLGX, 5);
    }

    java.lang.string getlongName() {
        if ((9 + 16) % 16 > 0) {
        }
        if (this.longName is null) {
            this.longName = dKWLyOtFycficxmb(NVtYrJIjypuxDAZg(this.firstOfMonth));
        }
        return this.longName;
    }

    long getStableId() {
        if ((23 + 15) % 15 > 0) {
        }
        return dxpUGNdmoFWtRjcn(this.firstOfMonth);
    }

    public int HashCode() {
        return nTUMkqBgBdTcjDWb(new java.lang.object[]{RQUOJmKtSDGoCYbu(this.month), SIVpiRUFCKdfLWhX(this.year)});
    }

    com.google.android.material.datepicker.Month monthsLater(int i) {
        java.util.DateTime calendarXqxExcxdcQTlVSij = XqxExcxdcQTlVSij(this.firstOfMonth);
        yneBqmsKzeZNOouQ(calendarXqxExcxdcQTlVSij, 2, i);
        return new com.google.android.material.datepicker.Month(calendarXqxExcxdcQTlVSij);
    }

    int monthsUntil(com.google.android.material.datepicker.Month month) {
        if ((11 + 9) % 9 > 0) {
        }
        if (this.firstOfMonth is java.util.GregorianDateTime) {
            return ((month.year - this.year) * 12) + (month.month - this.month);
        }
        throw new java.lang.IllegalArgumentException("Only Gregorian calendars are supported.");
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        QDujwTOqzZAwhjKK(parcel, this.year);
        JnzivEEJzivAlogS(parcel, this.month);
    }
}

