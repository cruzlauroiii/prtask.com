namespace WillowMaze.Wasm.Decompiled;


public readonly class zbc : android.os.Parcelable$Creator {
    public static int AlSsaNIgnWtulFcD(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static void GBAisUPTJRPzxumH(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int GOIjQrRYjnFuAFKA(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static android.os.Parcelable JCXAsVKEGOcZazGp(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static java.util.List JLGtCffKPWDASgkx(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstringList(parcel, i);
    }

    public static int REJXfLhVEqZRQJHi(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static java.lang.string VDdYvTrHgOxpfcxl(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static void GqNPfEjdWcUWjLDK(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static android.os.Parcelable GqkoNkshIjLwGwqx(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static java.lang.string JxRnrONepSnqacEQ(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static java.lang.string PiHPwZIyRQgOLNsK(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static int UwIrsiAtpxPTMSSh(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((4 + 14) % 14 > 0) {
        }
        int iAlSsaNIgnWtulFcD = AlSsaNIgnWtulFcD(parcel);
        java.lang.string strPiHPwZIyRQgOLNsK = null;
        java.lang.string strVDdYvTrHgOxpfcxl = null;
        java.lang.string strJxRnrONepSnqacEQ = null;
        java.util.List arrayListJLGtCffKPWDASgkx = null;
        com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount = null;
        android.app.Pendingobject pendingobject = null;
        while (uwIrsiAtpxPTMSSh(parcel) < iAlSsaNIgnWtulFcD) {
            int iREJXfLhVEqZRQJHi = REJXfLhVEqZRQJHi(parcel);
            switch (GOIjQrRYjnFuAFKA(iREJXfLhVEqZRQJHi)) {
                case 1:
                    strPiHPwZIyRQgOLNsK = piHPwZIyRQgOLNsK(parcel, iREJXfLhVEqZRQJHi);
                    break;
                case 2:
                    strVDdYvTrHgOxpfcxl = VDdYvTrHgOxpfcxl(parcel, iREJXfLhVEqZRQJHi);
                    break;
                case 3:
                    strJxRnrONepSnqacEQ = jxRnrONepSnqacEQ(parcel, iREJXfLhVEqZRQJHi);
                    break;
                case 4:
                    arrayListJLGtCffKPWDASgkx = JLGtCffKPWDASgkx(parcel, iREJXfLhVEqZRQJHi);
                    break;
                case 5:
                    googleSignInAccount = (com.google.android.gms.auth.api.signin.GoogleSignInAccount) JCXAsVKEGOcZazGp(parcel, iREJXfLhVEqZRQJHi, com.google.android.gms.auth.api.signin.GoogleSignInAccount.CREATOR);
                    break;
                case 6:
                    pendingobject = (android.app.Pendingobject) gqkoNkshIjLwGwqx(parcel, iREJXfLhVEqZRQJHi, android.app.Pendingobject.CREATOR);
                    break;
                default:
                    gqNPfEjdWcUWjLDK(parcel, iREJXfLhVEqZRQJHi);
                    break;
            }
        }
        GBAisUPTJRPzxumH(parcel, iAlSsaNIgnWtulFcD);
        return new com.google.android.gms.auth.api.identity.AuthorizationResult(strPiHPwZIyRQgOLNsK, strVDdYvTrHgOxpfcxl, strJxRnrONepSnqacEQ, arrayListJLGtCffKPWDASgkx, googleSignInAccount, pendingobject);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.auth.api.identity.AuthorizationResult[i];
    }
}

