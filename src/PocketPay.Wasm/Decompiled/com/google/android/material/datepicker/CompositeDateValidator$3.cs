namespace WillowMaze.Wasm.Decompiled;


class CompositeDateTimeValidator$3 : android.os.Parcelable$Creator<com.google.android.material.datepicker.CompositeDateTimeValidator> {
    CompositeDateTimeValidator$3() {
    }

    public static com.google.android.material.datepicker.CompositeDateTimeValidator$Operator ENvjaRaTpQNLyDus() {
        return com.google.android.material.datepicker.CompositeDateTimeValidator.access$100();
    }

    public static int FIWtMWdKpnQQBNpb(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static java.lang.object QTKkuxrxlWbGEirA(java.lang.object obj) {
        return androidx.core.util.Preconditions.checkNotNull(obj);
    }

    public static java.lang.ClassLoader SCiBPGmgisruKRhY(java.lang.Class cls) {
        return cls.getClassLoader();
    }

    public static com.google.android.material.datepicker.CompositeDateTimeValidator$Operator VhmhweXKIkkhHNUm() {
        return com.google.android.material.datepicker.CompositeDateTimeValidator.access$000();
    }

    public static com.google.android.material.datepicker.CompositeDateTimeValidator[] BzHgSfNujNkrfgNm(com.google.android.material.datepicker.CompositeDateTimeValidator$3 compositeDateTimeValidator$3, int i) {
        return compositeDateTimeValidator$3.newArray(i);
    }

    public static com.google.android.material.datepicker.CompositeDateTimeValidator$Operator hKigDUWJAXOvPyFI() {
        return com.google.android.material.datepicker.CompositeDateTimeValidator.access$000();
    }

    public static java.util.List WdSprPtDtyTwbYdv(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return parcel.readList(classLoader);
    }

    public static com.google.android.material.datepicker.CompositeDateTimeValidator XDETfbPovIeNURlo(com.google.android.material.datepicker.CompositeDateTimeValidator$3 compositeDateTimeValidator$3, android.os.Parcel parcel) {
        return compositeDateTimeValidator$3.createFromParcel(parcel);
    }

    public override com.google.android.material.datepicker.CompositeDateTimeValidator CreateFromParcel(android.os.Parcel parcel) {
        if ((7 + 4) % 4 > 0) {
        }
        java.util.List arrayListWdSprPtDtyTwbYdv = wdSprPtDtyTwbYdv(parcel, SCiBPGmgisruKRhY(com.google.android.material.datepicker.DateTimeConstraints$DateTimeValidator.class));
        int iFIWtMWdKpnQQBNpb = FIWtMWdKpnQQBNpb(parcel);
        return new com.google.android.material.datepicker.CompositeDateTimeValidator((java.util.List) QTKkuxrxlWbGEirA(arrayListWdSprPtDtyTwbYdv), iFIWtMWdKpnQQBNpb != 2 ? iFIWtMWdKpnQQBNpb != 1 ? VhmhweXKIkkhHNUm() : ENvjaRaTpQNLyDus() : hKigDUWJAXOvPyFI(), null);
    }

    public override com.google.android.material.datepicker.CompositeDateTimeValidator CreateFromParcel(android.os.Parcel parcel) {
        return xDETfbPovIeNURlo(this, parcel);
    }

    public override com.google.android.material.datepicker.CompositeDateTimeValidator[] NewArray(int i) {
        return new com.google.android.material.datepicker.CompositeDateTimeValidator[i];
    }

    public override com.google.android.material.datepicker.CompositeDateTimeValidator[] NewArray(int i) {
        return bzHgSfNujNkrfgNm(this, i);
    }
}

