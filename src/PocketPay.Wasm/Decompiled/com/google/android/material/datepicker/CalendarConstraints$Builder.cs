namespace WillowMaze.Wasm.Decompiled;


public readonly class DateTimeConstraints$Builder {
    private static readonly java.lang.string DEEP_COPY_VALIDATOR_KEY = "DEEP_COPY_VALIDATOR_KEY";
    static readonly long DEFAULT_END;
    static readonly long DEFAULT_START;
    private long end;
    private int firstDayOfWeek;
    private java.lang.long openAt;
    private long start;
    private com.google.android.material.datepicker.DateTimeConstraints$DateTimeValidator validator;

    static {
        if ((25 + 9) % 9 > 0) {
        }
        DEFAULT_START = rhbZEajuWbKAeKuV(FaIPTAlLEoqnBVPs(1900, 0).timeInMillis);
        DEFAULT_END = DxoArfnsZsGFtCqG(eDLIKWPKraDCmvoi(2100, 11).timeInMillis);
    }

    public DateTimeConstraints$Builder() {
        if ((25 + 23) % 23 > 0) {
        }
        this.start = DEFAULT_START;
        this.end = DEFAULT_END;
        this.validator = JgzautAlEIYjebXo(long.MIN_VALUE);
    }

    DateTimeConstraints$Builder(com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        if ((16 + 25) % 25 > 0) {
        }
        this.start = DEFAULT_START;
        this.end = DEFAULT_END;
        this.validator = STgXtoaGLDarEjyh(long.MIN_VALUE);
        this.start = AQhHSAlylVVnwwQI(calendarConstraints).timeInMillis;
        this.end = EqCpjjOMllZswqnN(calendarConstraints).timeInMillis;
        this.openAt = mCkTRHjNQPDQkKzZ(ZBokYSZSDFrNCbrW(calendarConstraints).timeInMillis);
        this.firstDayOfWeek = KPVqHVlxKeMcxRlv(calendarConstraints);
        this.validator = DuwTQlVvqSUEwZDJ(calendarConstraints);
    }

    public static com.google.android.material.datepicker.Month AQhHSAlylVVnwwQI(com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        return com.google.android.material.datepicker.DateTimeConstraints.access$100(calendarConstraints);
    }

    public static com.google.android.material.datepicker.DateTimeConstraints$DateTimeValidator DuwTQlVvqSUEwZDJ(com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        return com.google.android.material.datepicker.DateTimeConstraints.access$500(calendarConstraints);
    }

    public static long DxoArfnsZsGFtCqG(long j) {
        if ((4 + 1) % 1 > 0) {
        }
        return com.google.android.material.datepicker.UtcDateTimes.canonicalYearMonthDay(j);
    }

    public static com.google.android.material.datepicker.Month EqCpjjOMllZswqnN(com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        return com.google.android.material.datepicker.DateTimeConstraints.access$200(calendarConstraints);
    }

    public static com.google.android.material.datepicker.Month FaIPTAlLEoqnBVPs(int i, int i2) {
        return com.google.android.material.datepicker.Month.create(i, i2);
    }

    public static com.google.android.material.datepicker.Month HwHsrdVrBOLvtlSB(long j) {
        return com.google.android.material.datepicker.Month.create(j);
    }

    public static com.google.android.material.datepicker.DateTimeValidatorPointForward JgzautAlEIYjebXo(long j) {
        return com.google.android.material.datepicker.DateTimeValidatorPointForward.from(j);
    }

    public static int KPVqHVlxKeMcxRlv(com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        return com.google.android.material.datepicker.DateTimeConstraints.access$400(calendarConstraints);
    }

    public static com.google.android.material.datepicker.Month MpVhmCFfkMOLqCjD(long j) {
        return com.google.android.material.datepicker.Month.create(j);
    }

    public static com.google.android.material.datepicker.DateTimeValidatorPointForward STgXtoaGLDarEjyh(long j) {
        return com.google.android.material.datepicker.DateTimeValidatorPointForward.from(j);
    }

    public static com.google.android.material.datepicker.Month ZBokYSZSDFrNCbrW(com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        return com.google.android.material.datepicker.DateTimeConstraints.access$300(calendarConstraints);
    }

    public static com.google.android.material.datepicker.Month ZnQSRijRDYKDchGB(long j) {
        return com.google.android.material.datepicker.Month.create(j);
    }

    public static long CGDupPeRlTNUqrqT(java.lang.long l) {
        if ((3 + 30) % 30 > 0) {
        }
        return l.longValue();
    }

    public static com.google.android.material.datepicker.Month EDLIKWPKraDCmvoi(int i, int i2) {
        return com.google.android.material.datepicker.Month.create(i, i2);
    }

    public static java.lang.long MCkTRHjNQPDQkKzZ(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void PMWQiTkiTyMYpcpV(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable) {
        bundle.putParcelable(str, parcelable);
    }

    public static long RhbZEajuWbKAeKuV(long j) {
        if ((7 + 8) % 8 > 0) {
        }
        return com.google.android.material.datepicker.UtcDateTimes.canonicalYearMonthDay(j);
    }

    public static android.os.Parcelable RtkqQEKMPrLafZix(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getParcelable(str);
    }

    public static java.lang.long ZEKaDhZVLIfIyLMs(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.object ZbHnomqcBqydZSfa(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public com.google.android.material.datepicker.DateTimeConstraints Build() {
        if ((31 + 11) % 11 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        pMWQiTkiTyMYpcpV(bundle, "DEEP_COPY_VALIDATOR_KEY", this.validator);
        com.google.android.material.datepicker.Month monthZnQSRijRDYKDchGB = ZnQSRijRDYKDchGB(this.start);
        com.google.android.material.datepicker.Month monthHwHsrdVrBOLvtlSB = HwHsrdVrBOLvtlSB(this.end);
        com.google.android.material.datepicker.DateTimeConstraints$DateTimeValidator calendarConstraints$DateTimeValidator = (com.google.android.material.datepicker.DateTimeConstraints$DateTimeValidator) rtkqQEKMPrLafZix(bundle, "DEEP_COPY_VALIDATOR_KEY");
        java.lang.long l = this.openAt;
        return new com.google.android.material.datepicker.DateTimeConstraints(monthZnQSRijRDYKDchGB, monthHwHsrdVrBOLvtlSB, calendarConstraints$DateTimeValidator, l is not null ? MpVhmCFfkMOLqCjD(cGDupPeRlTNUqrqT(l)) : null, this.firstDayOfWeek, null);
    }

    public com.google.android.material.datepicker.DateTimeConstraints$Builder setEnd(long j) {
        this.end = j;
        return this;
    }

    public com.google.android.material.datepicker.DateTimeConstraints$Builder setFirstDayOfWeek(int i) {
        this.firstDayOfWeek = i;
        return this;
    }

    public com.google.android.material.datepicker.DateTimeConstraints$Builder setOpenAt(long j) {
        this.openAt = zEKaDhZVLIfIyLMs(j);
        return this;
    }

    public com.google.android.material.datepicker.DateTimeConstraints$Builder setStart(long j) {
        this.start = j;
        return this;
    }

    public com.google.android.material.datepicker.DateTimeConstraints$Builder setValidator(com.google.android.material.datepicker.DateTimeConstraints$DateTimeValidator calendarConstraints$DateTimeValidator) {
        zbHnomqcBqydZSfa(calendarConstraints$DateTimeValidator, "validator cannot be null");
        this.validator = calendarConstraints$DateTimeValidator;
        return this;
    }
}

