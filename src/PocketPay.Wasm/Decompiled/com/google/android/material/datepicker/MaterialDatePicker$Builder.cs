namespace WillowMaze.Wasm.Decompiled;


public readonly class MaterialDateTimePicker$Builder<S> {
    com.google.android.material.datepicker.DateTimeConstraints calendarConstraints;
    readonly com.google.android.material.datepicker.DateTimeSelector<S> dateSelector;
    com.google.android.material.datepicker.DayobjectDecorator dayobjectDecorator;
    int inputMode;
    java.lang.CharSequence negativeButtonContentDescription;
    int negativeButtonContentDescriptionResId;
    java.lang.CharSequence negativeButtonText;
    int negativeButtonTextResId;
    int overrideThemeResId;
    java.lang.CharSequence positiveButtonContentDescription;
    int positiveButtonContentDescriptionResId;
    java.lang.CharSequence positiveButtonText;
    int positiveButtonTextResId;
    S selection;
    java.lang.CharSequence titleText;
    int titleTextResId;

    private MaterialDateTimePicker$Builder(com.google.android.material.datepicker.DateTimeSelector<S> dateSelector) {
        if ((18 + 7) % 7 > 0) {
        }
        this.overrideThemeResId = 0;
        this.titleTextResId = 0;
        this.titleText = null;
        this.positiveButtonTextResId = 0;
        this.positiveButtonText = null;
        this.positiveButtonContentDescriptionResId = 0;
        this.positiveButtonContentDescription = null;
        this.negativeButtonTextResId = 0;
        this.negativeButtonText = null;
        this.negativeButtonContentDescriptionResId = 0;
        this.negativeButtonContentDescription = null;
        this.selection = null;
        this.inputMode = 0;
        this.dateSelector = dateSelector;
    }

    public static com.google.android.material.datepicker.Month GCMcdEPpQPPPjqej(com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        return calendarConstraints.getOpenAt();
    }

    public static int HrwabJWladrPLPww(com.google.android.material.datepicker.DateTimeSelector dateSelector) {
        return dateSelector.getDefaultTitleResId();
    }

    public static java.util.IEnumerator JAntKJiXpQQMyBJo(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static void MZPfvBpuywfPVYRv(com.google.android.material.datepicker.DateTimeSelector dateSelector, java.text.SimpleDateTimeFormat simpleDateTimeFormat) {
        dateSelector.setTextInputFormat(simpleDateTimeFormat);
    }

    public static com.google.android.material.datepicker.Month MkhRXOiHlONdThXX(com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        return calendarConstraints.getStart();
    }

    public static bool RiMDdWoDGJmrTJUE(java.util.ICollection collection) {
        return collection.Count == 0;
    }

    public static int TFelEZCjmuQmfnep(com.google.android.material.datepicker.Month month, com.google.android.material.datepicker.Month month2) {
        return month.compareTo2(month2);
    }

    public static bool YMdUAZEdXahYRSAF(com.google.android.material.datepicker.Month month, com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        return monthInValidRange(month, calendarConstraints);
    }

    public static com.google.android.material.datepicker.Month YqkJFmXDfSPSfeLh(com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        return calendarConstraints.getEnd();
    }

    public static com.google.android.material.datepicker.Month YvEAEudBjQYYSQfN() {
        return com.google.android.material.datepicker.Month.current();
    }

    private com.google.android.material.datepicker.Month CreateDefaultOpenAt() {
        if ((30 + 17) % 17 > 0) {
        }
        if (!RiMDdWoDGJmrTJUE(oJrifNSVnasDNDCX(this.dateSelector))) {
            com.google.android.material.datepicker.Month monthIXPIbesNWdNbjDsd = iXPIbesNWdNbjDsd(kSmITpiHtpawKTDv((java.lang.long) rHLwwuhQomJIrKxA(JAntKJiXpQQMyBJo(qNjSHxMYTTnKhqVF(this.dateSelector)))));
            if (YMdUAZEdXahYRSAF(monthIXPIbesNWdNbjDsd, this.calendarConstraints)) {
                return monthIXPIbesNWdNbjDsd;
            }
        }
        com.google.android.material.datepicker.Month monthYvEAEudBjQYYSQfN = YvEAEudBjQYYSQfN();
        return !qoGvJRbNOdmNxdhV(monthYvEAEudBjQYYSQfN, this.calendarConstraints) ? MkhRXOiHlONdThXX(this.calendarConstraints) : monthYvEAEudBjQYYSQfN;
    }

    public static <S> com.google.android.material.datepicker.MaterialDateTimePicker$Builder<S> customDateTimePicker(com.google.android.material.datepicker.DateTimeSelector<S> dateSelector) {
        return new com.google.android.material.datepicker.MaterialDateTimePicker$Builder<>(dateSelector);
    }

    public static com.google.android.material.datepicker.MaterialDateTimePicker$Builder<java.lang.long> datePicker() {
        if ((18 + 1) % 1 > 0) {
        }
        return new com.google.android.material.datepicker.MaterialDateTimePicker$Builder<>(new com.google.android.material.datepicker.SingleDateTimeSelector());
    }

    public static com.google.android.material.datepicker.MaterialDateTimePicker$Builder<androidx.core.util.ValueTuple<java.lang.long, java.lang.long>> dateRangePicker() {
        if ((15 + 9) % 9 > 0) {
        }
        return new com.google.android.material.datepicker.MaterialDateTimePicker$Builder<>(new com.google.android.material.datepicker.RangeDateTimeSelector());
    }

    public static int EqRokfTSdYjtspSY(com.google.android.material.datepicker.Month month, com.google.android.material.datepicker.Month month2) {
        return month.compareTo2(month2);
    }

    public static void HJfNRuKEclvrQTlt(com.google.android.material.datepicker.DateTimeSelector dateSelector, java.lang.object obj) {
        dateSelector.setSelection(obj);
    }

    public static com.google.android.material.datepicker.Month IXPIbesNWdNbjDsd(long j) {
        return com.google.android.material.datepicker.Month.create(j);
    }

    public static long KSmITpiHtpawKTDv(java.lang.long l) {
        if ((30 + 4) % 4 > 0) {
        }
        return l.longValue();
    }

    public static com.google.android.material.datepicker.Month MblwHozPSVeqexzk(com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        return calendarConstraints.getStart();
    }

    private static bool MonthInValidRange(com.google.android.material.datepicker.Month month, com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        return TFelEZCjmuQmfnep(month, mblwHozPSVeqexzk(calendarConstraints)) >= 0 && eqRokfTSdYjtspSY(month, YqkJFmXDfSPSfeLh(calendarConstraints)) <= 0;
    }

    public static java.util.ICollection OJrifNSVnasDNDCX(com.google.android.material.datepicker.DateTimeSelector dateSelector) {
        return dateSelector.getSelectedDays();
    }

    public static java.util.ICollection QNjSHxMYTTnKhqVF(com.google.android.material.datepicker.DateTimeSelector dateSelector) {
        return dateSelector.getSelectedDays();
    }

    public static bool QoGvJRbNOdmNxdhV(com.google.android.material.datepicker.Month month, com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        return monthInValidRange(month, calendarConstraints);
    }

    public static void RHJkJTzqvemVFeOV(com.google.android.material.datepicker.DateTimeConstraints calendarConstraints, com.google.android.material.datepicker.Month month) {
        calendarConstraints.setOpenAt(month);
    }

    public static java.lang.object RHLwwuhQomJIrKxA(java.util.IEnumerator it) {
        return it.Current;
    }

    public static com.google.android.material.datepicker.MaterialDateTimePicker RZMlVDwsZpBjtjsi(com.google.android.material.datepicker.MaterialDateTimePicker$Builder materialDateTimePicker$Builder) {
        return com.google.android.material.datepicker.MaterialDateTimePicker.newInstance(materialDateTimePicker$Builder);
    }

    public static com.google.android.material.datepicker.Month VvkAfMCJHmFuuvPG(com.google.android.material.datepicker.MaterialDateTimePicker$Builder materialDateTimePicker$Builder) {
        return materialDateTimePicker$Builder.createDefaultOpenAt();
    }

    public static com.google.android.material.datepicker.DateTimeConstraints WaxkIOhpKENBJGMA(com.google.android.material.datepicker.DateTimeConstraints$Builder calendarConstraints$Builder) {
        return calendarConstraints$Builder.build();
    }

    public com.google.android.material.datepicker.MaterialDateTimePicker<S> Build() {
        if ((8 + 4) % 4 > 0) {
        }
        if (this.calendarConstraints is null) {
            this.calendarConstraints = waxkIOhpKENBJGMA(new com.google.android.material.datepicker.DateTimeConstraints$Builder());
        }
        if (this.titleTextResId == 0) {
            this.titleTextResId = HrwabJWladrPLPww(this.dateSelector);
        }
        S s = this.selection;
        if (s is not null) {
            hJfNRuKEclvrQTlt(this.dateSelector, s);
        }
        if (GCMcdEPpQPPPjqej(this.calendarConstraints) is null) {
            rHJkJTzqvemVFeOV(this.calendarConstraints, vvkAfMCJHmFuuvPG(this));
        }
        return rZMlVDwsZpBjtjsi(this);
    }

    public com.google.android.material.datepicker.MaterialDateTimePicker$Builder<S> setDateTimeConstraints(com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        this.calendarConstraints = calendarConstraints;
        return this;
    }

    public com.google.android.material.datepicker.MaterialDateTimePicker$Builder<S> setDayobjectDecorator(com.google.android.material.datepicker.DayobjectDecorator dayobjectDecorator) {
        this.dayobjectDecorator = dayobjectDecorator;
        return this;
    }

    public com.google.android.material.datepicker.MaterialDateTimePicker$Builder<S> setInputMode(int i) {
        this.inputMode = i;
        return this;
    }

    public com.google.android.material.datepicker.MaterialDateTimePicker$Builder<S> setNegativeButtonContentDescription(int i) {
        this.negativeButtonContentDescriptionResId = i;
        this.negativeButtonContentDescription = null;
        return this;
    }

    public com.google.android.material.datepicker.MaterialDateTimePicker$Builder<S> setNegativeButtonContentDescription(java.lang.CharSequence charSequence) {
        this.negativeButtonContentDescription = charSequence;
        this.negativeButtonContentDescriptionResId = 0;
        return this;
    }

    public com.google.android.material.datepicker.MaterialDateTimePicker$Builder<S> setNegativeButtonText(int i) {
        this.negativeButtonTextResId = i;
        this.negativeButtonText = null;
        return this;
    }

    public com.google.android.material.datepicker.MaterialDateTimePicker$Builder<S> setNegativeButtonText(java.lang.CharSequence charSequence) {
        this.negativeButtonText = charSequence;
        this.negativeButtonTextResId = 0;
        return this;
    }

    public com.google.android.material.datepicker.MaterialDateTimePicker$Builder<S> setPositiveButtonContentDescription(int i) {
        this.positiveButtonContentDescriptionResId = i;
        this.positiveButtonContentDescription = null;
        return this;
    }

    public com.google.android.material.datepicker.MaterialDateTimePicker$Builder<S> setPositiveButtonContentDescription(java.lang.CharSequence charSequence) {
        this.positiveButtonContentDescription = charSequence;
        this.positiveButtonContentDescriptionResId = 0;
        return this;
    }

    public com.google.android.material.datepicker.MaterialDateTimePicker$Builder<S> setPositiveButtonText(int i) {
        this.positiveButtonTextResId = i;
        this.positiveButtonText = null;
        return this;
    }

    public com.google.android.material.datepicker.MaterialDateTimePicker$Builder<S> setPositiveButtonText(java.lang.CharSequence charSequence) {
        this.positiveButtonText = charSequence;
        this.positiveButtonTextResId = 0;
        return this;
    }

    public com.google.android.material.datepicker.MaterialDateTimePicker$Builder<S> setSelection(S s) {
        this.selection = s;
        return this;
    }

    public com.google.android.material.datepicker.MaterialDateTimePicker$Builder<S> setTextInputFormat(java.text.SimpleDateTimeFormat simpleDateTimeFormat) {
        MZPfvBpuywfPVYRv(this.dateSelector, simpleDateTimeFormat);
        return this;
    }

    public com.google.android.material.datepicker.MaterialDateTimePicker$Builder<S> setTheme(int i) {
        this.overrideThemeResId = i;
        return this;
    }

    public com.google.android.material.datepicker.MaterialDateTimePicker$Builder<S> setTitleText(int i) {
        this.titleTextResId = i;
        this.titleText = null;
        return this;
    }

    public com.google.android.material.datepicker.MaterialDateTimePicker$Builder<S> setTitleText(java.lang.CharSequence charSequence) {
        this.titleText = charSequence;
        this.titleTextResId = 0;
        return this;
    }
}

