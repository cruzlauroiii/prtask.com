namespace WillowMaze.Wasm.Decompiled;


public readonly class zbu : android.os.Parcelable$Creator {
    public static int BdSEPRGAIsWffsnz(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static int DWRxMZCBJJFcaepe(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int PVDkbgiEyRiTJQVR(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int WBtbbtJldSwcmYEK(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static void DaTespLpgLgeiKIu(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static android.os.Parcelable PLcQrSTJWCGVVPgj(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static java.lang.string QGXEfwgZPmINyvCh(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static void TXlhdFuMiPBvnBAY(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((12 + 2) % 2 > 0) {
        }
        int iWBtbbtJldSwcmYEK = WBtbbtJldSwcmYEK(parcel);
        java.lang.string strQGXEfwgZPmINyvCh = null;
        com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions = null;
        while (BdSEPRGAIsWffsnz(parcel) < iWBtbbtJldSwcmYEK) {
            int iPVDkbgiEyRiTJQVR = PVDkbgiEyRiTJQVR(parcel);
            int iDWRxMZCBJJFcaepe = DWRxMZCBJJFcaepe(iPVDkbgiEyRiTJQVR);
            if (iDWRxMZCBJJFcaepe == 2) {
                strQGXEfwgZPmINyvCh = qGXEfwgZPmINyvCh(parcel, iPVDkbgiEyRiTJQVR);
            } else if (iDWRxMZCBJJFcaepe == 5) {
                googleSignInOptions = (com.google.android.gms.auth.api.signin.GoogleSignInOptions) pLcQrSTJWCGVVPgj(parcel, iPVDkbgiEyRiTJQVR, com.google.android.gms.auth.api.signin.GoogleSignInOptions.CREATOR);
            } else {
                daTespLpgLgeiKIu(parcel, iPVDkbgiEyRiTJQVR);
            }
        }
        tXlhdFuMiPBvnBAY(parcel, iWBtbbtJldSwcmYEK);
        return new com.google.android.gms.auth.api.signin.internal.SignInConfiguration(strQGXEfwgZPmINyvCh, googleSignInOptions);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.auth.api.signin.internal.SignInConfiguration[i];
    }
}

