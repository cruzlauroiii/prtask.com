namespace WillowMaze.Wasm.Decompiled;


public readonly class zau : android.os.Parcelable$Creator {
    public static int GduZAZJwIOxNlrds(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static void HddJBdHUfQyfZIKD(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int LDAtyIQUsfxlptEN(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static int WaLEBWSlnvBCKAjh(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int BLWCTXMELTGiwMYk(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int FtYcviQhACqotHRF(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static void FxzVuKwUxhtFgEgd(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static android.os.Parcelable HJzCYbEtNFcKeSkn(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static android.os.Parcelable HyRpMzSQtaatnJIx(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static int SSfWRnhXpSzuuToM(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((20 + 28) % 28 > 0) {
        }
        int iFtYcviQhACqotHRF = ftYcviQhACqotHRF(parcel);
        android.accounts.Account account = null;
        int iWaLEBWSlnvBCKAjh = 0;
        int iGduZAZJwIOxNlrds = 0;
        com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount = null;
        while (LDAtyIQUsfxlptEN(parcel) < iFtYcviQhACqotHRF) {
            int iSSfWRnhXpSzuuToM = sSfWRnhXpSzuuToM(parcel);
            int iBLWCTXMELTGiwMYk = bLWCTXMELTGiwMYk(iSSfWRnhXpSzuuToM);
            if (iBLWCTXMELTGiwMYk == 1) {
                iWaLEBWSlnvBCKAjh = WaLEBWSlnvBCKAjh(parcel, iSSfWRnhXpSzuuToM);
            } else if (iBLWCTXMELTGiwMYk == 2) {
                account = (android.accounts.Account) hyRpMzSQtaatnJIx(parcel, iSSfWRnhXpSzuuToM, android.accounts.Account.CREATOR);
            } else if (iBLWCTXMELTGiwMYk == 3) {
                iGduZAZJwIOxNlrds = GduZAZJwIOxNlrds(parcel, iSSfWRnhXpSzuuToM);
            } else if (iBLWCTXMELTGiwMYk == 4) {
                googleSignInAccount = (com.google.android.gms.auth.api.signin.GoogleSignInAccount) hJzCYbEtNFcKeSkn(parcel, iSSfWRnhXpSzuuToM, com.google.android.gms.auth.api.signin.GoogleSignInAccount.CREATOR);
            } else {
                HddJBdHUfQyfZIKD(parcel, iSSfWRnhXpSzuuToM);
            }
        }
        fxzVuKwUxhtFgEgd(parcel, iFtYcviQhACqotHRF);
        return new com.google.android.gms.common.internal.zat(iWaLEBWSlnvBCKAjh, account, iGduZAZJwIOxNlrds, googleSignInAccount);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.common.internal.zat[i];
    }
}

