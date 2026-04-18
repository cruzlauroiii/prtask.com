namespace WillowMaze.Wasm.Decompiled;


class Month$1 : android.os.Parcelable$Creator<com.google.android.material.datepicker.Month> {
    Month$1() {
    }

    public static com.google.android.material.datepicker.Month BvarKmNtehYDJijs(int i, int i2) {
        return com.google.android.material.datepicker.Month.create(i, i2);
    }

    public static com.google.android.material.datepicker.Month LewCWOdwMzokAOnd(com.google.android.material.datepicker.Month$1 month$1, android.os.Parcel parcel) {
        return month$1.createFromParcel(parcel);
    }

    public static com.google.android.material.datepicker.Month[] ABNsOmsSkbuGaiRl(com.google.android.material.datepicker.Month$1 month$1, int i) {
        return month$1.newArray(i);
    }

    public static int AfUkOPmSoRbimCDF(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static int AibLiFLZuMMSwHOl(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public override com.google.android.material.datepicker.Month CreateFromParcel(android.os.Parcel parcel) {
        return BvarKmNtehYDJijs(aibLiFLZuMMSwHOl(parcel), afUkOPmSoRbimCDF(parcel));
    }

    public override com.google.android.material.datepicker.Month CreateFromParcel(android.os.Parcel parcel) {
        return LewCWOdwMzokAOnd(this, parcel);
    }

    public override com.google.android.material.datepicker.Month[] NewArray(int i) {
        return new com.google.android.material.datepicker.Month[i];
    }

    public override com.google.android.material.datepicker.Month[] NewArray(int i) {
        return aBNsOmsSkbuGaiRl(this, i);
    }
}

