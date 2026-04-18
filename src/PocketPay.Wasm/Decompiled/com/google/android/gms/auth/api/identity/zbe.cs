namespace WillowMaze.Wasm.Decompiled;


public readonly class zbe : android.os.Parcelable$Creator {
    public static int ByvASDHWMXrAgthp(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static int MTjrxQrEsjtxPwyp(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int SSJXUcsGBaIvEdHb(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static void ZQzhhiIzAqXlssGb(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int DmINSjOmEZTfSfaK(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static android.os.Parcelable OFaZLVQyDPgHsPXm(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static void QNiPEFpArHZhdqQY(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((3 + 22) % 22 > 0) {
        }
        int iDmINSjOmEZTfSfaK = dmINSjOmEZTfSfaK(parcel);
        android.app.Pendingobject pendingobject = null;
        while (ByvASDHWMXrAgthp(parcel) < iDmINSjOmEZTfSfaK) {
            int iSSJXUcsGBaIvEdHb = SSJXUcsGBaIvEdHb(parcel);
            if (MTjrxQrEsjtxPwyp(iSSJXUcsGBaIvEdHb) == 1) {
                pendingobject = (android.app.Pendingobject) oFaZLVQyDPgHsPXm(parcel, iSSJXUcsGBaIvEdHb, android.app.Pendingobject.CREATOR);
            } else {
                ZQzhhiIzAqXlssGb(parcel, iSSJXUcsGBaIvEdHb);
            }
        }
        qNiPEFpArHZhdqQY(parcel, iDmINSjOmEZTfSfaK);
        return new com.google.android.gms.auth.api.identity.BeginSignInResult(pendingobject);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.auth.api.identity.BeginSignInResult[i];
    }
}

