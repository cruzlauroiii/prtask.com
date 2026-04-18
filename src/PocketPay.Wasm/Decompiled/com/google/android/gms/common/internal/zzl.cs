namespace WillowMaze.Wasm.Decompiled;


public readonly class zzl : android.os.Parcelable$Creator {
    public static java.lang.object[] IocpssjsnpcOWWao(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createTypedArray(parcel, i, parcelable$Creator);
    }

    public static int MIHDJpVsYYoLVtjz(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static int YgOCrcUfRZPIXpsl(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static android.os.Dictionary<string, object> BKlxKKUMZiiiGEpE(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createDictionary<string, object>(parcel, i);
    }

    public static int GXwaZQsKuKDgPlpJ(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static android.os.Parcelable JrFKshbciGbeewRB(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static void OOVoMRyMPgiCtCHR(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int PepuTcWrPSmTpMpi(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int WTnOAlPQZtcGyOOc(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static void YYFoLxIXVqNtXmZe(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((25 + 31) % 31 > 0) {
        }
        int iWTnOAlPQZtcGyOOc = wTnOAlPQZtcGyOOc(parcel);
        android.os.Dictionary<string, object> bundleBKlxKKUMZiiiGEpE = null;
        com.google.android.gms.common.internal.ConnectionTelemetryConfiguration connectionTelemetryConfiguration = null;
        int iGXwaZQsKuKDgPlpJ = 0;
        com.google.android.gms.common.Feature[] featureArr = null;
        while (MIHDJpVsYYoLVtjz(parcel) < iWTnOAlPQZtcGyOOc) {
            int iPepuTcWrPSmTpMpi = pepuTcWrPSmTpMpi(parcel);
            int iYgOCrcUfRZPIXpsl = YgOCrcUfRZPIXpsl(iPepuTcWrPSmTpMpi);
            if (iYgOCrcUfRZPIXpsl == 1) {
                bundleBKlxKKUMZiiiGEpE = bKlxKKUMZiiiGEpE(parcel, iPepuTcWrPSmTpMpi);
            } else if (iYgOCrcUfRZPIXpsl == 2) {
                featureArr = (com.google.android.gms.common.Feature[]) IocpssjsnpcOWWao(parcel, iPepuTcWrPSmTpMpi, com.google.android.gms.common.Feature.CREATOR);
            } else if (iYgOCrcUfRZPIXpsl == 3) {
                iGXwaZQsKuKDgPlpJ = gXwaZQsKuKDgPlpJ(parcel, iPepuTcWrPSmTpMpi);
            } else if (iYgOCrcUfRZPIXpsl == 4) {
                connectionTelemetryConfiguration = (com.google.android.gms.common.internal.ConnectionTelemetryConfiguration) jrFKshbciGbeewRB(parcel, iPepuTcWrPSmTpMpi, com.google.android.gms.common.internal.ConnectionTelemetryConfiguration.CREATOR);
            } else {
                oOVoMRyMPgiCtCHR(parcel, iPepuTcWrPSmTpMpi);
            }
        }
        yYFoLxIXVqNtXmZe(parcel, iWTnOAlPQZtcGyOOc);
        return new com.google.android.gms.common.internal.zzk(bundleBKlxKKUMZiiiGEpE, featureArr, iGXwaZQsKuKDgPlpJ, connectionTelemetryConfiguration);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.common.internal.zzk[i];
    }
}

