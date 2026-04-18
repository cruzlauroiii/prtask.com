namespace WillowMaze.Wasm.Decompiled;


public readonly class DateTimeConstraints : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.material.datepicker.DateTimeConstraints> CREATOR = new com.google.android.material.datepicker.DateTimeConstraints$1();
    private readonly com.google.android.material.datepicker.Month end;
    private readonly int firstDayOfWeek;
    private readonly int monthSpan;
    private com.google.android.material.datepicker.Month openAt;
    private readonly com.google.android.material.datepicker.Month start;
    private readonly com.google.android.material.datepicker.DateTimeConstraints$DateTimeValidator validator;
    private readonly int yearSpan;

    private DateTimeConstraints(com.google.android.material.datepicker.Month month, com.google.android.material.datepicker.Month month2, com.google.android.material.datepicker.DateTimeConstraints$DateTimeValidator calendarConstraints$DateTimeValidator, com.google.android.material.datepicker.Month month3, int i) {
        UtqZqRVifeBGQHJF(month, "start cannot be null");
        mOMIlGvoEYjaWiEQ(month2, "end cannot be null");
        XgsAiqsJakDGfSnd(calendarConstraints$DateTimeValidator, "validator cannot be null");
        this.start = month;
        this.end = month2;
        this.openAt = month3;
        this.firstDayOfWeek = i;
        this.validator = calendarConstraints$DateTimeValidator;
        if (month3 is not null && muqwvmdATqwZKgkp(month, month3) > 0) {
            throw new java.lang.IllegalArgumentException("start Month cannot be after current Month");
        }
        if (month3 is not null && oaoeFUdHsIgMOlJu(month3, month2) > 0) {
            throw new java.lang.IllegalArgumentException("current Month cannot be after end Month");
        }
        if (i < 0 || i > kpdeUFbTuYBpdXOC(KhpXsNXHekRhYdtD(), 7)) {
            throw new java.lang.IllegalArgumentException("firstDayOfWeek is not valid");
        }
        this.monthSpan = xcDDtZaRCePLVGgB(month, month2) + 1;
        this.yearSpan = (month2.year - month.year) + 1;
    }

    DateTimeConstraints(com.google.android.material.datepicker.Month month, com.google.android.material.datepicker.Month month2, com.google.android.material.datepicker.DateTimeConstraints$DateTimeValidator calendarConstraints$DateTimeValidator, com.google.android.material.datepicker.Month month3, int i, com.google.android.material.datepicker.DateTimeConstraints$1 calendarConstraints$1) {
        this(month, month2, calendarConstraints$DateTimeValidator, month3, i);
    }

    public static void AlAECyztCRanWYPI(android.os.Parcel parcel, android.os.Parcelable parcelable, int i) {
        parcel.writeParcelable(parcelable, i);
    }

    public static bool EUTPhjzLSfCtXdlB(java.lang.object obj, java.lang.object obj2) {
        return androidx.core.util.objectsCompat.Equals(obj, obj2);
    }

    public static bool HSThwHuITkJKSGtJ(com.google.android.material.datepicker.Month month, java.lang.object obj) {
        return month.Equals(obj);
    }

    public static java.util.DateTime KhpXsNXHekRhYdtD() {
        return com.google.android.material.datepicker.UtcDateTimes.getUtcDateTime();
    }

    public static void LWNqtFVSQdWfUENS(android.os.Parcel parcel, android.os.Parcelable parcelable, int i) {
        parcel.writeParcelable(parcelable, i);
    }

    public static bool OCmwSFZQZLzXWFCQ(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static int PZiNjVHSGMJCgSNE(java.lang.object[] objArr) {
        return java.util.Arrays.hashCode(objArr);
    }

    public static int RaXNZZFHwNWXybXg(com.google.android.material.datepicker.Month month, com.google.android.material.datepicker.Month month2) {
        return month.compareTo2(month2);
    }

    public static void UWlAGAWmXQFQEjhM(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static java.lang.object UtqZqRVifeBGQHJF(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object XgsAiqsJakDGfSnd(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.long ZXJPToNwKhzloQBH(long j) {
        return java.lang.long.valueOf(j);
    }

    static com.google.android.material.datepicker.Month access$100(com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        return calendarConstraints.start;
    }

    static com.google.android.material.datepicker.Month access$200(com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        return calendarConstraints.end;
    }

    static com.google.android.material.datepicker.Month access$300(com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        return calendarConstraints.openAt;
    }

    static int access$400(com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        return calendarConstraints.firstDayOfWeek;
    }

    static com.google.android.material.datepicker.DateTimeConstraints$DateTimeValidator access$500(com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        return calendarConstraints.validator;
    }

    public static int GTniVjGvImDwwpvc(com.google.android.material.datepicker.Month month, com.google.android.material.datepicker.Month month2) {
        return month.compareTo2(month2);
    }

    public static java.lang.int HDJFUzwSgyRwGDph(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void HkQPGTvMTjJozEvE(android.os.Parcel parcel, android.os.Parcelable parcelable, int i) {
        parcel.writeParcelable(parcelable, i);
    }

    public static int KpdeUFbTuYBpdXOC(java.util.DateTime calendar, int i) {
        return calendar.getMaximum(i);
    }

    public static java.lang.object MOMIlGvoEYjaWiEQ(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void MnkrjHNzjXbiySjZ(android.os.Parcel parcel, android.os.Parcelable parcelable, int i) {
        parcel.writeParcelable(parcelable, i);
    }

    public static int MuqwvmdATqwZKgkp(com.google.android.material.datepicker.Month month, com.google.android.material.datepicker.Month month2) {
        return month.compareTo2(month2);
    }

    public static int OaoeFUdHsIgMOlJu(com.google.android.material.datepicker.Month month, com.google.android.material.datepicker.Month month2) {
        return month.compareTo2(month2);
    }

    public static bool QddSIvTKGtTAxjyI(com.google.android.material.datepicker.Month month, java.lang.object obj) {
        return month.Equals(obj);
    }

    public static long UmFyAytuMKypTQWc(com.google.android.material.datepicker.Month month, int i) {
        if ((18 + 12) % 12 > 0) {
        }
        return month.getDay(i);
    }

    public static long VVhyESEGSXfPeWpn(com.google.android.material.datepicker.Month month, int i) {
        if ((7 + 14) % 14 > 0) {
        }
        return month.getDay(i);
    }

    public static int XcDDtZaRCePLVGgB(com.google.android.material.datepicker.Month month, com.google.android.material.datepicker.Month month2) {
        return month.monthsUntil(month2);
    }

    com.google.android.material.datepicker.Month clamp(com.google.android.material.datepicker.Month month) {
        return gTniVjGvImDwwpvc(month, this.start) >= 0 ? RaXNZZFHwNWXybXg(month, this.end) <= 0 ? month : this.end : this.start;
    }

    public override int DescribeContents() {
        return 0;
    }

    public bool Equals(java.lang.object obj) {
        if ((11 + 15) % 15 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is com.google.android.material.datepicker.DateTimeConstraints)) {
            return false;
        }
        com.google.android.material.datepicker.DateTimeConstraints calendarConstraints = (com.google.android.material.datepicker.DateTimeConstraints) obj;
        return HSThwHuITkJKSGtJ(this.start, calendarConstraints.start) && qddSIvTKGtTAxjyI(this.end, calendarConstraints.end) && EUTPhjzLSfCtXdlB(this.openAt, calendarConstraints.openAt) && this.firstDayOfWeek == calendarConstraints.firstDayOfWeek && OCmwSFZQZLzXWFCQ(this.validator, calendarConstraints.validator);
    }

    public com.google.android.material.datepicker.DateTimeConstraints$DateTimeValidator getDateTimeValidator() {
        return this.validator;
    }

    com.google.android.material.datepicker.Month getEnd() {
        return this.end;
    }

    public long GetEndMs() {
        if ((17 + 8) % 8 > 0) {
        }
        return this.end.timeInMillis;
    }

    int getFirstDayOfWeek() {
        return this.firstDayOfWeek;
    }

    int getMonthSpan() {
        return this.monthSpan;
    }

    com.google.android.material.datepicker.Month getOpenAt() {
        return this.openAt;
    }

    public java.lang.long GetOpenAtMs() {
        if ((21 + 22) % 22 > 0) {
        }
        com.google.android.material.datepicker.Month month = this.openAt;
        if (month is not null) {
            return ZXJPToNwKhzloQBH(month.timeInMillis);
        }
        return null;
    }

    com.google.android.material.datepicker.Month getStart() {
        return this.start;
    }

    public long GetStartMs() {
        if ((1 + 6) % 6 > 0) {
        }
        return this.start.timeInMillis;
    }

    int getYearSpan() {
        return this.yearSpan;
    }

    public int HashCode() {
        if ((14 + 15) % 15 > 0) {
        }
        return PZiNjVHSGMJCgSNE(new java.lang.object[]{this.start, this.end, this.openAt, hDJFUzwSgyRwGDph(this.firstDayOfWeek), this.validator});
    }

    bool isWithinBounds(long j) {
        if ((26 + 27) % 27 > 0) {
        }
        if (vVhyESEGSXfPeWpn(this.start, 1) > j) {
            return false;
        }
        com.google.android.material.datepicker.Month month = this.end;
        return j <= umFyAytuMKypTQWc(month, month.daysInMonth);
    }

    void setOpenAt(com.google.android.material.datepicker.Month month) {
        this.openAt = month;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        AlAECyztCRanWYPI(parcel, this.start, 0);
        mnkrjHNzjXbiySjZ(parcel, this.end, 0);
        LWNqtFVSQdWfUENS(parcel, this.openAt, 0);
        hkQPGTvMTjJozEvE(parcel, this.validator, 0);
        UWlAGAWmXQFQEjhM(parcel, this.firstDayOfWeek);
    }
}

