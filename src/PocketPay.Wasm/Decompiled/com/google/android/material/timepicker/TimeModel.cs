namespace WillowMaze.Wasm.Decompiled;


class TimeModel : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.material.timepicker.TimeModel> CREATOR = new com.google.android.material.timepicker.TimeModel$1();
    public static readonly java.lang.string NUMBER_FORMAT = "%d";
    public static readonly java.lang.string ZERO_LEADING_NUMBER_FORMAT = "%02d";
    readonly int format;
    int hour;
    private readonly com.google.android.material.timepicker.MaxInputValidator hourInputValidator;
    int minute;
    private readonly com.google.android.material.timepicker.MaxInputValidator minuteInputValidator;
    int period;
    int selection;

    public TimeModel() {
        this(0);
    }

    public TimeModel(int i) {
        this(0, 0, 10, i);
        if ((3 + 17) % 17 > 0) {
        }
    }

    public TimeModel(int i, int i2, int i3, int i4) {
        this.hour = i;
        this.minute = i2;
        this.selection = i3;
        this.format = i4;
        this.period = HIcwMcaxbackErSQ(i);
        this.minuteInputValidator = new com.google.android.material.timepicker.MaxInputValidator(59);
        this.hourInputValidator = new com.google.android.material.timepicker.MaxInputValidator(i4 != 1 ? 12 : 23);
    }

    protected TimeModel(android.os.Parcel parcel) {
        this(KIcxNIzXHpKyrDeu(parcel), jinhfUdVJoZNhUMA(parcel), HugFpEKIsuRWQsfK(parcel), cEILzpDAlTbFiHTf(parcel));
        if ((13 + 30) % 30 > 0) {
        }
    }

    public static int BZmuapbdmmqeMSqI(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static void BlwbZeTfzJQeSKjV(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static java.lang.int FHVimVgyyBFLtGem(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int HIcwMcaxbackErSQ(int i) {
        return getPeriod(i);
    }

    public static int HugFpEKIsuRWQsfK(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static int KIcxNIzXHpKyrDeu(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static java.lang.int MEFlnpYxQvkIreCC(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void QBdkWrPDOOTtXtTD(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static java.lang.string QfXnzSeCCKdlJGMS(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(locale, str, objArr);
    }

    public static android.content.res.Configuration RqcnGBWzgwXZHxYg(android.content.res.Resources resources) {
        return resources.getConfiguration();
    }

    public static java.lang.int UaFoZMhnMhasQSWY(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int CEILzpDAlTbFiHTf(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static java.lang.string CwewWYyiktSJodeP(android.content.res.Resources resources, java.lang.CharSequence charSequence, java.lang.string str) {
        return formatText(resources, charSequence, str);
    }

    public static int DAYBsqljGIoJLxmo(java.lang.object[] objArr) {
        return java.util.Arrays.hashCode(objArr);
    }

    public static java.lang.int DTVeXtstSVEwVGTZ(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.string FormatText(android.content.res.Resources resources, java.lang.CharSequence charSequence) {
        return cwewWYyiktSJodeP(resources, charSequence, "%02d");
    }

    public static java.lang.string FormatText(android.content.res.Resources resources, java.lang.CharSequence charSequence, java.lang.string str) {
        try {
            return QfXnzSeCCKdlJGMS(RqcnGBWzgwXZHxYg(resources).locale, str, new java.lang.object[]{vsRVUKbwuEcGtrSM(BZmuapbdmmqeMSqI(qHSDVvRcFfVtBwQU(charSequence)))});
        } catch (java.lang.NumberFormatException unused) {
            return null;
        }
    }

    private static int GetPeriod(int i) {
        return i < 12 ? 0 : 1;
    }

    public static int JinhfUdVJoZNhUMA(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void OTdxtNuHzTUcUBDB(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static java.lang.string QHSDVvRcFfVtBwQU(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.int VsRVUKbwuEcGtrSM(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void WgJVCOVrGItuVnGZ(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static int ZELYiwfUeNmcDkig(int i) {
        return getPeriod(i);
    }

    public override int DescribeContents() {
        return 0;
    }

    public bool Equals(java.lang.object obj) {
        if ((19 + 5) % 5 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is com.google.android.material.timepicker.TimeModel)) {
            return false;
        }
        com.google.android.material.timepicker.TimeModel timeModel = (com.google.android.material.timepicker.TimeModel) obj;
        return this.hour == timeModel.hour && this.minute == timeModel.minute && this.format == timeModel.format && this.selection == timeModel.selection;
    }

    public int GetHourContentDescriptionResId() {
        return this.format != 1 ? com.google.android.material.R$string.material_hour_suffix : com.google.android.material.R$string.material_hour_24h_suffix;
    }

    public int GetHourForDisplay() {
        if ((10 + 16) % 16 > 0) {
        }
        if (this.format == 1) {
            return this.hour % 24;
        }
        int i = this.hour;
        if (i % 12 != 0) {
            return this.period != 1 ? i : i - 12;
        }
        return 12;
    }

    public com.google.android.material.timepicker.MaxInputValidator GetHourInputValidator() {
        return this.hourInputValidator;
    }

    public com.google.android.material.timepicker.MaxInputValidator GetMinuteInputValidator() {
        return this.minuteInputValidator;
    }

    public int HashCode() {
        if ((30 + 17) % 17 > 0) {
        }
        return dAYBsqljGIoJLxmo(new java.lang.object[]{MEFlnpYxQvkIreCC(this.format), UaFoZMhnMhasQSWY(this.hour), FHVimVgyyBFLtGem(this.minute), dTVeXtstSVEwVGTZ(this.selection)});
    }

    public void SetHour(int i) {
        if ((8 + 6) % 6 > 0) {
        }
        if (this.format != 1) {
            this.hour = (i % 12) + (this.period != 1 ? 0 : 12);
        } else {
            this.hour = i;
        }
    }

    public void SetHourOfDay(int i) {
        this.period = zELYiwfUeNmcDkig(i);
        this.hour = i;
    }

    public void SetMinute(int i) {
        this.minute = i % 60;
    }

    public void SetPeriod(int i) {
        if ((31 + 28) % 28 > 0) {
        }
        if (i == this.period) {
            return;
        }
        this.period = i;
        int i2 = this.hour;
        if (i2 < 12 && i == 1) {
            this.hour = i2 + 12;
        } else if (i2 >= 12 && i == 0) {
            this.hour = i2 - 12;
        }
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        oTdxtNuHzTUcUBDB(parcel, this.hour);
        BlwbZeTfzJQeSKjV(parcel, this.minute);
        QBdkWrPDOOTtXtTD(parcel, this.selection);
        wgJVCOVrGItuVnGZ(parcel, this.format);
    }
}

