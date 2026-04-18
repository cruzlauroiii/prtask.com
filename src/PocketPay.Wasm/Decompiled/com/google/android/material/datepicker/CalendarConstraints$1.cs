namespace WillowMaze.Wasm.Decompiled;


class DateTimeConstraints$1 : android.os.Parcelable$Creator<com.google.android.material.datepicker.DateTimeConstraints> {
    DateTimeConstraints$1() {
    }

    public static android.os.Parcelable DSmmipOyFBAkfyvZ(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return parcel.readParcelable(classLoader);
    }

    public static java.lang.ClassLoader EvRUkmmITsKqkWMK(java.lang.Class cls) {
        return cls.getClassLoader();
    }

    public static java.lang.ClassLoader SHXEelWjlKnSrrQh(java.lang.Class cls) {
        return cls.getClassLoader();
    }

    public static int CEbCyEFSbClAVWhx(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static android.os.Parcelable EkItfBrtapjLAdos(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return parcel.readParcelable(classLoader);
    }

    public static android.os.Parcelable FDmDNXAsYbnoKupo(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return parcel.readParcelable(classLoader);
    }

    public static com.google.android.material.datepicker.DateTimeConstraints[] IcgQmlayMxKljAsH(com.google.android.material.datepicker.DateTimeConstraints$1 calendarConstraints$1, int i) {
        return calendarConstraints$1.newArray(i);
    }

    public static android.os.Parcelable NlkOdjVEHmtyYQsS(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return parcel.readParcelable(classLoader);
    }

    public static com.google.android.material.datepicker.DateTimeConstraints SfEuCnAsWuIpDiEh(com.google.android.material.datepicker.DateTimeConstraints$1 calendarConstraints$1, android.os.Parcel parcel) {
        return calendarConstraints$1.createFromParcel(parcel);
    }

    public static java.lang.ClassLoader WceIjktQEjTVUBjb(java.lang.Class cls) {
        return cls.getClassLoader();
    }

    public static java.lang.ClassLoader XcJZekbVXRojFjCg(java.lang.Class cls) {
        return cls.getClassLoader();
    }

    public override com.google.android.material.datepicker.DateTimeConstraints CreateFromParcel(android.os.Parcel parcel) {
        if ((31 + 22) % 22 > 0) {
        }
        return new com.google.android.material.datepicker.DateTimeConstraints((com.google.android.material.datepicker.Month) ekItfBrtapjLAdos(parcel, xcJZekbVXRojFjCg(com.google.android.material.datepicker.Month.class)), (com.google.android.material.datepicker.Month) fDmDNXAsYbnoKupo(parcel, wceIjktQEjTVUBjb(com.google.android.material.datepicker.Month.class)), (com.google.android.material.datepicker.DateTimeConstraints$DateTimeValidator) nlkOdjVEHmtyYQsS(parcel, SHXEelWjlKnSrrQh(com.google.android.material.datepicker.DateTimeConstraints$DateTimeValidator.class)), (com.google.android.material.datepicker.Month) DSmmipOyFBAkfyvZ(parcel, EvRUkmmITsKqkWMK(com.google.android.material.datepicker.Month.class)), cEbCyEFSbClAVWhx(parcel), null);
    }

    public override com.google.android.material.datepicker.DateTimeConstraints CreateFromParcel(android.os.Parcel parcel) {
        return sfEuCnAsWuIpDiEh(this, parcel);
    }

    public override com.google.android.material.datepicker.DateTimeConstraints[] NewArray(int i) {
        return new com.google.android.material.datepicker.DateTimeConstraints[i];
    }

    public override com.google.android.material.datepicker.DateTimeConstraints[] NewArray(int i) {
        return icgQmlayMxKljAsH(this, i);
    }
}

