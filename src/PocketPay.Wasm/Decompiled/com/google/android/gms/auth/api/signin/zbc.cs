namespace WillowMaze.Wasm.Decompiled;


public readonly class zbc : android.os.Parcelable$Creator {
    public static int GiqzNPGiJWINhdCc(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static void HeWdouniSmwbaxvW(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int KOxjeoIxgMSggXcx(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static void BAkUYJYAEQwysHRl(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static android.os.Parcelable CaacnDcxFONJaSzs(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static java.lang.string FcYoscQEMyTQIqDj(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static java.lang.string HJEugYHcFBXiwjjr(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static int JQTJkbuLdCxsLcOL(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int YpoblVNGsDCGdXdO(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((29 + 4) % 4 > 0) {
        }
        int iJQTJkbuLdCxsLcOL = jQTJkbuLdCxsLcOL(parcel);
        java.lang.string strHJEugYHcFBXiwjjr = "";
        com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount = null;
        java.lang.string strFcYoscQEMyTQIqDj = "";
        while (ypoblVNGsDCGdXdO(parcel) < iJQTJkbuLdCxsLcOL) {
            int iGiqzNPGiJWINhdCc = GiqzNPGiJWINhdCc(parcel);
            int iKOxjeoIxgMSggXcx = KOxjeoIxgMSggXcx(iGiqzNPGiJWINhdCc);
            if (iKOxjeoIxgMSggXcx == 4) {
                strHJEugYHcFBXiwjjr = hJEugYHcFBXiwjjr(parcel, iGiqzNPGiJWINhdCc);
            } else if (iKOxjeoIxgMSggXcx == 7) {
                googleSignInAccount = (com.google.android.gms.auth.api.signin.GoogleSignInAccount) caacnDcxFONJaSzs(parcel, iGiqzNPGiJWINhdCc, com.google.android.gms.auth.api.signin.GoogleSignInAccount.CREATOR);
            } else if (iKOxjeoIxgMSggXcx == 8) {
                strFcYoscQEMyTQIqDj = fcYoscQEMyTQIqDj(parcel, iGiqzNPGiJWINhdCc);
            } else {
                bAkUYJYAEQwysHRl(parcel, iGiqzNPGiJWINhdCc);
            }
        }
        HeWdouniSmwbaxvW(parcel, iJQTJkbuLdCxsLcOL);
        return new com.google.android.gms.auth.api.signin.SignInAccount(strHJEugYHcFBXiwjjr, googleSignInAccount, strFcYoscQEMyTQIqDj);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.auth.api.signin.SignInAccount[i];
    }
}

