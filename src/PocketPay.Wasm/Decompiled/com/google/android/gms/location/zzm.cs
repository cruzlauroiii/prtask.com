namespace WillowMaze.Wasm.Decompiled;


public readonly class zzm : android.os.Parcelable$Creator {
    public static void EGJOZphPjnemMpBX(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static float KXZAKAkemfLcSrEW(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readfloat(parcel, i);
    }

    public static int NCBfXSyRwteiyXKk(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static float NNGLAJLninNztsjS(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readfloat(parcel, i);
    }

    public static byte DIpsNwQsAwcIqSKl(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbyte(parcel, i);
    }

    public static int DqqtZdwzRtyIdAfc(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static float KOoYPHfATlWdtUDB(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readfloat(parcel, i);
    }

    public static float LNOsfAFKOsFlTDeK(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readfloat(parcel, i);
    }

    public static long MZbpXNoqatxCClUC(android.os.Parcel parcel, int i) {
        if ((13 + 27) % 27 > 0) {
        }
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, i);
    }

    public static void PaVVribQGbtJRVxu(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int PoFGncOnbPfZtpAL(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static float[] XMDWWtikbFjSoXUh(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createfloatArray(parcel, i);
    }

    public static int XsgFNyyQZoDAtsaQ(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((24 + 2) % 2 > 0) {
        }
        int iPoFGncOnbPfZtpAL = poFGncOnbPfZtpAL(parcel);
        float fNNGLAJLninNztsjS = 0.0f;
        float fKOoYPHfATlWdtUDB = 0.0f;
        float fKXZAKAkemfLcSrEW = 0.0f;
        float fLNOsfAFKOsFlTDeK = 0.0f;
        byte bDIpsNwQsAwcIqSKl = 0;
        long jMZbpXNoqatxCClUC = 0;
        float[] fArrXMDWWtikbFjSoXUh = null;
        while (NCBfXSyRwteiyXKk(parcel) < iPoFGncOnbPfZtpAL) {
            int iXsgFNyyQZoDAtsaQ = xsgFNyyQZoDAtsaQ(parcel);
            int iDqqtZdwzRtyIdAfc = dqqtZdwzRtyIdAfc(iXsgFNyyQZoDAtsaQ);
            if (iDqqtZdwzRtyIdAfc != 1) {
                switch (iDqqtZdwzRtyIdAfc) {
                    case 4:
                        fNNGLAJLninNztsjS = NNGLAJLninNztsjS(parcel, iXsgFNyyQZoDAtsaQ);
                        break;
                    case 5:
                        fKOoYPHfATlWdtUDB = kOoYPHfATlWdtUDB(parcel, iXsgFNyyQZoDAtsaQ);
                        break;
                    case 6:
                        jMZbpXNoqatxCClUC = mZbpXNoqatxCClUC(parcel, iXsgFNyyQZoDAtsaQ);
                        break;
                    case 7:
                        bDIpsNwQsAwcIqSKl = dIpsNwQsAwcIqSKl(parcel, iXsgFNyyQZoDAtsaQ);
                        break;
                    case 8:
                        fKXZAKAkemfLcSrEW = KXZAKAkemfLcSrEW(parcel, iXsgFNyyQZoDAtsaQ);
                        break;
                    case 9:
                        fLNOsfAFKOsFlTDeK = lNOsfAFKOsFlTDeK(parcel, iXsgFNyyQZoDAtsaQ);
                        break;
                    default:
                        EGJOZphPjnemMpBX(parcel, iXsgFNyyQZoDAtsaQ);
                        break;
                }
            } else {
                fArrXMDWWtikbFjSoXUh = xMDWWtikbFjSoXUh(parcel, iXsgFNyyQZoDAtsaQ);
            }
        }
        paVVribQGbtJRVxu(parcel, iPoFGncOnbPfZtpAL);
        return new com.google.android.gms.location.DeviceOrientation(fArrXMDWWtikbFjSoXUh, fNNGLAJLninNztsjS, fKOoYPHfATlWdtUDB, jMZbpXNoqatxCClUC, bDIpsNwQsAwcIqSKl, fKXZAKAkemfLcSrEW, fLNOsfAFKOsFlTDeK);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.location.DeviceOrientation[i];
    }
}

