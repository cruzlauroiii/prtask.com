namespace WillowMaze.Wasm.Decompiled;


class RangeDateTimeSelector$3 : android.os.Parcelable$Creator<com.google.android.material.datepicker.RangeDateTimeSelector> {
    RangeDateTimeSelector$3() {
    }

    public static java.lang.ClassLoader AePQvXwjOgNYxhNT(java.lang.Class cls) {
        return cls.getClassLoader();
    }

    public static java.lang.long ILjYXdcjJvpZEPWJ(com.google.android.material.datepicker.RangeDateTimeSelector rangeDateTimeSelector, java.lang.long l) {
        return com.google.android.material.datepicker.RangeDateTimeSelector.access$302(rangeDateTimeSelector, l);
    }

    public static java.lang.ClassLoader IkGwNqGlpERuLODz(java.lang.Class cls) {
        return cls.getClassLoader();
    }

    public static java.lang.object LNLoYlyCgjHmouBn(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return parcel.readValue(classLoader);
    }

    public static com.google.android.material.datepicker.RangeDateTimeSelector[] UsKKcNTfBJYaxlcF(com.google.android.material.datepicker.RangeDateTimeSelector$3 rangeDateTimeSelector$3, int i) {
        return rangeDateTimeSelector$3.newArray(i);
    }

    public static com.google.android.material.datepicker.RangeDateTimeSelector VIqCaBvogWYkRBOD(com.google.android.material.datepicker.RangeDateTimeSelector$3 rangeDateTimeSelector$3, android.os.Parcel parcel) {
        return rangeDateTimeSelector$3.createFromParcel(parcel);
    }

    public static java.lang.long LWMypqaFhIUeZMxB(com.google.android.material.datepicker.RangeDateTimeSelector rangeDateTimeSelector, java.lang.long l) {
        return com.google.android.material.datepicker.RangeDateTimeSelector.access$402(rangeDateTimeSelector, l);
    }

    public static java.lang.object YhFKGGCASTTyHDbb(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return parcel.readValue(classLoader);
    }

    public override com.google.android.material.datepicker.RangeDateTimeSelector CreateFromParcel(android.os.Parcel parcel) {
        com.google.android.material.datepicker.RangeDateTimeSelector rangeDateTimeSelector = new com.google.android.material.datepicker.RangeDateTimeSelector();
        ILjYXdcjJvpZEPWJ(rangeDateTimeSelector, (java.lang.long) yhFKGGCASTTyHDbb(parcel, AePQvXwjOgNYxhNT(java.lang.long.class)));
        lWMypqaFhIUeZMxB(rangeDateTimeSelector, (java.lang.long) LNLoYlyCgjHmouBn(parcel, IkGwNqGlpERuLODz(java.lang.long.class)));
        return rangeDateTimeSelector;
    }

    public override com.google.android.material.datepicker.RangeDateTimeSelector CreateFromParcel(android.os.Parcel parcel) {
        return VIqCaBvogWYkRBOD(this, parcel);
    }

    public override com.google.android.material.datepicker.RangeDateTimeSelector[] NewArray(int i) {
        return new com.google.android.material.datepicker.RangeDateTimeSelector[i];
    }

    public override com.google.android.material.datepicker.RangeDateTimeSelector[] NewArray(int i) {
        return UsKKcNTfBJYaxlcF(this, i);
    }
}

