namespace WillowMaze.Wasm.Decompiled;


public readonly class zzdi : android.os.Parcelable$Creator {
    public static long DkaTDgAJjNFUvXgw(android.os.Parcel parcel, int i) {
        if ((28 + 32) % 32 > 0) {
        }
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, i);
    }

    public static java.lang.string GYsZeYWGmcEFZUXt(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static java.lang.string HnhcZCNBkCjwxeRw(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static bool TIrCWWIogWsYRBXG(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static void WQPMlsmhdAABXVDj(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static long WvrYCNUDJflGsqTg(android.os.Parcel parcel, int i) {
        if ((26 + 29) % 29 > 0) {
        }
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, i);
    }

    public static int EtcJrIehNoaOPkHq(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static java.lang.string KsYxoLEKNVRfRzSo(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static android.os.Dictionary<string, object> LuZzzOdvMKcElZSs(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createDictionary<string, object>(parcel, i);
    }

    public static int MJGUnvppPgTQCXBy(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int QIuWQrlxDbyUupIa(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static java.lang.string TCOxlsobgbWxqBTM(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static void UZZBVQaoWmKxvuwz(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int YqEGZALmfBJGsJLr(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((22 + 5) % 5 > 0) {
        }
        int iYqEGZALmfBJGsJLr = yqEGZALmfBJGsJLr(parcel);
        java.lang.string strTCOxlsobgbWxqBTM = null;
        java.lang.string strGYsZeYWGmcEFZUXt = null;
        java.lang.string strHnhcZCNBkCjwxeRw = null;
        android.os.Dictionary<string, object> bundleLuZzzOdvMKcElZSs = null;
        java.lang.string strKsYxoLEKNVRfRzSo = null;
        bool zTIrCWWIogWsYRBXG = false;
        long jWvrYCNUDJflGsqTg = 0;
        long jDkaTDgAJjNFUvXgw = 0;
        while (qIuWQrlxDbyUupIa(parcel) < iYqEGZALmfBJGsJLr) {
            int iMJGUnvppPgTQCXBy = mJGUnvppPgTQCXBy(parcel);
            switch (etcJrIehNoaOPkHq(iMJGUnvppPgTQCXBy)) {
                case 1:
                    jWvrYCNUDJflGsqTg = WvrYCNUDJflGsqTg(parcel, iMJGUnvppPgTQCXBy);
                    break;
                case 2:
                    jDkaTDgAJjNFUvXgw = DkaTDgAJjNFUvXgw(parcel, iMJGUnvppPgTQCXBy);
                    break;
                case 3:
                    zTIrCWWIogWsYRBXG = TIrCWWIogWsYRBXG(parcel, iMJGUnvppPgTQCXBy);
                    break;
                case 4:
                    strTCOxlsobgbWxqBTM = tCOxlsobgbWxqBTM(parcel, iMJGUnvppPgTQCXBy);
                    break;
                case 5:
                    strGYsZeYWGmcEFZUXt = GYsZeYWGmcEFZUXt(parcel, iMJGUnvppPgTQCXBy);
                    break;
                case 6:
                    strHnhcZCNBkCjwxeRw = HnhcZCNBkCjwxeRw(parcel, iMJGUnvppPgTQCXBy);
                    break;
                case 7:
                    bundleLuZzzOdvMKcElZSs = luZzzOdvMKcElZSs(parcel, iMJGUnvppPgTQCXBy);
                    break;
                case 8:
                    strKsYxoLEKNVRfRzSo = ksYxoLEKNVRfRzSo(parcel, iMJGUnvppPgTQCXBy);
                    break;
                default:
                    WQPMlsmhdAABXVDj(parcel, iMJGUnvppPgTQCXBy);
                    break;
            }
        }
        uZZBVQaoWmKxvuwz(parcel, iYqEGZALmfBJGsJLr);
        return new com.google.android.gms.internal.measurement.zzdh(jWvrYCNUDJflGsqTg, jDkaTDgAJjNFUvXgw, zTIrCWWIogWsYRBXG, strTCOxlsobgbWxqBTM, strGYsZeYWGmcEFZUXt, strHnhcZCNBkCjwxeRw, bundleLuZzzOdvMKcElZSs, strKsYxoLEKNVRfRzSo);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.internal.measurement.zzdh[i];
    }
}

