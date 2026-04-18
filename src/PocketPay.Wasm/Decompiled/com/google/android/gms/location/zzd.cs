namespace WillowMaze.Wasm.Decompiled;


public readonly class zzd : android.os.Parcelable$Creator {
    public static long AxneaKmtDgJcGToi(android.os.Parcel parcel, int i) {
        if ((15 + 19) % 19 > 0) {
        }
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, i);
    }

    public static android.os.Dictionary<string, object> LiQfcpyIcCcFCEXL(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createDictionary<string, object>(parcel, i);
    }

    public static void OJAyqGejzwxMxmCx(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int WBOihnLjhyIYXYrt(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static java.util.List XjeGxNkfucFkzUOI(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createTypedList(parcel, i, parcelable$Creator);
    }

    public static int ZySEDPrAZVaRjRqC(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static int CGpMiBFSTcbfDATR(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int GApptfBQkUkdfxCv(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static long NGcfHfzwjcMklHKJ(android.os.Parcel parcel, int i) {
        if ((14 + 5) % 5 > 0) {
        }
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, i);
    }

    public static void YQeohQaHquuvpIAf(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int ZDfBQDbgEQalfCum(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((24 + 17) % 17 > 0) {
        }
        int iCGpMiBFSTcbfDATR = cGpMiBFSTcbfDATR(parcel);
        java.util.List arrayListXjeGxNkfucFkzUOI = null;
        android.os.Dictionary<string, object> bundleLiQfcpyIcCcFCEXL = null;
        int iZDfBQDbgEQalfCum = 0;
        long jAxneaKmtDgJcGToi = 0;
        long jNGcfHfzwjcMklHKJ = 0;
        while (ZySEDPrAZVaRjRqC(parcel) < iCGpMiBFSTcbfDATR) {
            int iWBOihnLjhyIYXYrt = WBOihnLjhyIYXYrt(parcel);
            int iGApptfBQkUkdfxCv = gApptfBQkUkdfxCv(iWBOihnLjhyIYXYrt);
            if (iGApptfBQkUkdfxCv == 1) {
                arrayListXjeGxNkfucFkzUOI = XjeGxNkfucFkzUOI(parcel, iWBOihnLjhyIYXYrt, com.google.android.gms.location.Detectedobject.CREATOR);
            } else if (iGApptfBQkUkdfxCv == 2) {
                jAxneaKmtDgJcGToi = AxneaKmtDgJcGToi(parcel, iWBOihnLjhyIYXYrt);
            } else if (iGApptfBQkUkdfxCv == 3) {
                jNGcfHfzwjcMklHKJ = nGcfHfzwjcMklHKJ(parcel, iWBOihnLjhyIYXYrt);
            } else if (iGApptfBQkUkdfxCv == 4) {
                iZDfBQDbgEQalfCum = zDfBQDbgEQalfCum(parcel, iWBOihnLjhyIYXYrt);
            } else if (iGApptfBQkUkdfxCv == 5) {
                bundleLiQfcpyIcCcFCEXL = LiQfcpyIcCcFCEXL(parcel, iWBOihnLjhyIYXYrt);
            } else {
                OJAyqGejzwxMxmCx(parcel, iWBOihnLjhyIYXYrt);
            }
        }
        yQeohQaHquuvpIAf(parcel, iCGpMiBFSTcbfDATR);
        return new com.google.android.gms.location.objectRecognitionResult(arrayListXjeGxNkfucFkzUOI, jAxneaKmtDgJcGToi, jNGcfHfzwjcMklHKJ, iZDfBQDbgEQalfCum, bundleLiQfcpyIcCcFCEXL);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.location.objectRecognitionResult[i];
    }
}

