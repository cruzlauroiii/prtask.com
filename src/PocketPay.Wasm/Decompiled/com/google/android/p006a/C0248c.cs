namespace WillowMaze.Wasm.Decompiled;


public readonly class C0248c {
    static {
        hRtAdQKZTSswMhVu(com.google.android.p006a.C0248c.class);
    }

    private C0248c() {
    }

    public static int LQSGrVonRYLfUGyC(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void LwAyOvEgTxOnPkTk(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static java.lang.object OjwFwPrTmOSENzIh(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel) {
        return parcelable$Creator.createFromParcel(parcel);
    }

    public static void TRMYQwTMYaGYIuEz(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static <T : android.os.Parcelable> T m53a(android.os.Parcel parcel, android.os.Parcelable$Creator<T> parcelable$Creator) {
        if (LQSGrVonRYLfUGyC(parcel) != 0) {
            return (T) OjwFwPrTmOSENzIh(parcelable$Creator, parcel);
        }
        return null;
    }

    public static void M54b(android.os.Parcel parcel, android.os.Parcelable parcelable) {
        bsfjytCHpiFOApnG(parcel, 1);
        pHxhtcmzoWtJcbTG(parcelable, parcel, 0);
    }

    public static void BsfjytCHpiFOApnG(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void M55c(android.os.Parcel parcel, android.os.Parcelable parcelable) {
        if (parcelable is null) {
            TRMYQwTMYaGYIuEz(parcel, 0);
        } else {
            LwAyOvEgTxOnPkTk(parcel, 1);
            cUvsOdfCEAnCOuPJ(parcelable, parcel, 1);
        }
    }

    public static void CUvsOdfCEAnCOuPJ(android.os.Parcelable parcelable, android.os.Parcel parcel, int i) {
        parcelable.writeToParcel(parcel, i);
    }

    public static java.lang.ClassLoader HRtAdQKZTSswMhVu(java.lang.Class cls) {
        return cls.getClassLoader();
    }

    public static void PHxhtcmzoWtJcbTG(android.os.Parcelable parcelable, android.os.Parcel parcel, int i) {
        parcelable.writeToParcel(parcel, i);
    }
}

