namespace WillowMaze.Wasm.Decompiled;


public readonly class zza : android.os.Parcelable$Creator {
    public static int BygtZOhEeaKTrINx(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int CQmelvUeoAvFtCTz(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static java.lang.string DCpvezyxhAAYflXh(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static int KlLnbFyFnykOpwlL(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static void LJxQUqfpkBhMHdev(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int PZrZAWFgDnPRNdWF(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int FNipGyAdQrGEQzTO(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static long HLuSzGpyRqXFeuEX(android.os.Parcel parcel, int i) {
        if ((21 + 10) % 10 > 0) {
        }
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, i);
    }

    public static int YPZyJqYAzBmKEZMQ(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int YqtZzTngwPyuFUxv(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static java.lang.string ZIapwBZcnKLPjmxW(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static void ZUPPvNABwOvbcBiA(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((27 + 17) % 17 > 0) {
        }
        int iBygtZOhEeaKTrINx = BygtZOhEeaKTrINx(parcel);
        java.lang.string strZIapwBZcnKLPjmxW = null;
        java.lang.string strDCpvezyxhAAYflXh = null;
        int iCQmelvUeoAvFtCTz = 0;
        int iPZrZAWFgDnPRNdWF = 0;
        int iKlLnbFyFnykOpwlL = 0;
        long jHLuSzGpyRqXFeuEX = 0;
        while (fNipGyAdQrGEQzTO(parcel) < iBygtZOhEeaKTrINx) {
            int iYqtZzTngwPyuFUxv = yqtZzTngwPyuFUxv(parcel);
            switch (yPZyJqYAzBmKEZMQ(iYqtZzTngwPyuFUxv)) {
                case 1:
                    iCQmelvUeoAvFtCTz = CQmelvUeoAvFtCTz(parcel, iYqtZzTngwPyuFUxv);
                    break;
                case 2:
                    jHLuSzGpyRqXFeuEX = hLuSzGpyRqXFeuEX(parcel, iYqtZzTngwPyuFUxv);
                    break;
                case 3:
                    strZIapwBZcnKLPjmxW = zIapwBZcnKLPjmxW(parcel, iYqtZzTngwPyuFUxv);
                    break;
                case 4:
                    iPZrZAWFgDnPRNdWF = PZrZAWFgDnPRNdWF(parcel, iYqtZzTngwPyuFUxv);
                    break;
                case 5:
                    iKlLnbFyFnykOpwlL = KlLnbFyFnykOpwlL(parcel, iYqtZzTngwPyuFUxv);
                    break;
                case 6:
                    strDCpvezyxhAAYflXh = DCpvezyxhAAYflXh(parcel, iYqtZzTngwPyuFUxv);
                    break;
                default:
                    zUPPvNABwOvbcBiA(parcel, iYqtZzTngwPyuFUxv);
                    break;
            }
        }
        LJxQUqfpkBhMHdev(parcel, iBygtZOhEeaKTrINx);
        return new com.google.android.gms.auth.AccountChangeEvent(iCQmelvUeoAvFtCTz, jHLuSzGpyRqXFeuEX, strZIapwBZcnKLPjmxW, iPZrZAWFgDnPRNdWF, iKlLnbFyFnykOpwlL, strDCpvezyxhAAYflXh);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.auth.AccountChangeEvent[i];
    }
}

