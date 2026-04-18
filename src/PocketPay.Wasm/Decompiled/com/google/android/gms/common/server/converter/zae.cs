namespace WillowMaze.Wasm.Decompiled;


public readonly class zae : android.os.Parcelable$Creator {
    public static void AsvyVilTlAnZcZWx(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int BMYUkSOOSEssOeri(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int BTEuVwfesdnRpmFW(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int EFNXdyNCBSTjHOHz(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int LXqUBhfodzIEOgDl(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static java.lang.string ZtkCJUlqbzQHOADy(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static void AqCtrDYfYKZIZJVo(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int KmJtWfQIIPvXdLhY(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static int LNJcjMxJbvChMKoZ(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((20 + 16) % 16 > 0) {
        }
        int iLNJcjMxJbvChMKoZ = lNJcjMxJbvChMKoZ(parcel);
        int iLXqUBhfodzIEOgDl = 0;
        java.lang.string strZtkCJUlqbzQHOADy = null;
        int iBTEuVwfesdnRpmFW = 0;
        while (kmJtWfQIIPvXdLhY(parcel) < iLNJcjMxJbvChMKoZ) {
            int iBMYUkSOOSEssOeri = BMYUkSOOSEssOeri(parcel);
            int iEFNXdyNCBSTjHOHz = EFNXdyNCBSTjHOHz(iBMYUkSOOSEssOeri);
            if (iEFNXdyNCBSTjHOHz == 1) {
                iLXqUBhfodzIEOgDl = LXqUBhfodzIEOgDl(parcel, iBMYUkSOOSEssOeri);
            } else if (iEFNXdyNCBSTjHOHz == 2) {
                strZtkCJUlqbzQHOADy = ZtkCJUlqbzQHOADy(parcel, iBMYUkSOOSEssOeri);
            } else if (iEFNXdyNCBSTjHOHz == 3) {
                iBTEuVwfesdnRpmFW = BTEuVwfesdnRpmFW(parcel, iBMYUkSOOSEssOeri);
            } else {
                AsvyVilTlAnZcZWx(parcel, iBMYUkSOOSEssOeri);
            }
        }
        aqCtrDYfYKZIZJVo(parcel, iLNJcjMxJbvChMKoZ);
        return new com.google.android.gms.common.server.converter.zac(iLXqUBhfodzIEOgDl, strZtkCJUlqbzQHOADy, iBTEuVwfesdnRpmFW);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.common.server.converter.zac[i];
    }
}

