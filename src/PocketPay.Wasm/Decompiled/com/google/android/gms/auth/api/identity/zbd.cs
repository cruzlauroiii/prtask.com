namespace WillowMaze.Wasm.Decompiled;


public readonly class zbd : android.os.Parcelable$Creator {
    public static android.os.Parcelable AaadgohtEybyJmFs(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static void DzeWpbdbuvjZRkJJ(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int EMZbtfpPykEhaiuI(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int EUdIPOQqHmOwWtbf(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int LPwuaRIxqcijhTDX(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static java.lang.string NyjKrGFptQUUncbD(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static int PgQTaYBMpNIJZPxE(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static bool PhihmzndajKrPIrQ(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static int XXzLjtHpXkFOfZJv(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static android.os.Parcelable FNBlKevXYicxvYOr(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static void JBvbfEAAQDNlpubl(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static android.os.Parcelable QEPsBhEEVSqrVPVq(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static bool RFyTQQtUWRLTyMzq(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static android.os.Parcelable TrGtUHJweuygLzGv(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((20 + 24) % 24 > 0) {
        }
        int iXXzLjtHpXkFOfZJv = XXzLjtHpXkFOfZJv(parcel);
        bool zRFyTQQtUWRLTyMzq = false;
        int iEMZbtfpPykEhaiuI = 0;
        bool zPhihmzndajKrPIrQ = false;
        com.google.android.gms.auth.api.identity.BeginSignInRequest$PasswordRequestOptions beginSignInRequest$PasswordRequestOptions = null;
        com.google.android.gms.auth.api.identity.BeginSignInRequest$GoogleIdTokenRequestOptions beginSignInRequest$GoogleIdTokenRequestOptions = null;
        java.lang.string strNyjKrGFptQUUncbD = null;
        com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeysRequestOptions beginSignInRequest$PasskeysRequestOptions = null;
        com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeyJsonRequestOptions beginSignInRequest$PasskeyJsonRequestOptions = null;
        while (PgQTaYBMpNIJZPxE(parcel) < iXXzLjtHpXkFOfZJv) {
            int iEUdIPOQqHmOwWtbf = EUdIPOQqHmOwWtbf(parcel);
            switch (LPwuaRIxqcijhTDX(iEUdIPOQqHmOwWtbf)) {
                case 1:
                    beginSignInRequest$PasswordRequestOptions = (com.google.android.gms.auth.api.identity.BeginSignInRequest$PasswordRequestOptions) fNBlKevXYicxvYOr(parcel, iEUdIPOQqHmOwWtbf, com.google.android.gms.auth.api.identity.BeginSignInRequest$PasswordRequestOptions.CREATOR);
                    break;
                case 2:
                    beginSignInRequest$GoogleIdTokenRequestOptions = (com.google.android.gms.auth.api.identity.BeginSignInRequest$GoogleIdTokenRequestOptions) trGtUHJweuygLzGv(parcel, iEUdIPOQqHmOwWtbf, com.google.android.gms.auth.api.identity.BeginSignInRequest$GoogleIdTokenRequestOptions.CREATOR);
                    break;
                case 3:
                    strNyjKrGFptQUUncbD = NyjKrGFptQUUncbD(parcel, iEUdIPOQqHmOwWtbf);
                    break;
                case 4:
                    zRFyTQQtUWRLTyMzq = rFyTQQtUWRLTyMzq(parcel, iEUdIPOQqHmOwWtbf);
                    break;
                case 5:
                    iEMZbtfpPykEhaiuI = EMZbtfpPykEhaiuI(parcel, iEUdIPOQqHmOwWtbf);
                    break;
                case 6:
                    beginSignInRequest$PasskeysRequestOptions = (com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeysRequestOptions) qEPsBhEEVSqrVPVq(parcel, iEUdIPOQqHmOwWtbf, com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeysRequestOptions.CREATOR);
                    break;
                case 7:
                    beginSignInRequest$PasskeyJsonRequestOptions = (com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeyJsonRequestOptions) AaadgohtEybyJmFs(parcel, iEUdIPOQqHmOwWtbf, com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeyJsonRequestOptions.CREATOR);
                    break;
                case 8:
                    zPhihmzndajKrPIrQ = PhihmzndajKrPIrQ(parcel, iEUdIPOQqHmOwWtbf);
                    break;
                default:
                    jBvbfEAAQDNlpubl(parcel, iEUdIPOQqHmOwWtbf);
                    break;
            }
        }
        DzeWpbdbuvjZRkJJ(parcel, iXXzLjtHpXkFOfZJv);
        return new com.google.android.gms.auth.api.identity.BeginSignInRequest(beginSignInRequest$PasswordRequestOptions, beginSignInRequest$GoogleIdTokenRequestOptions, strNyjKrGFptQUUncbD, zRFyTQQtUWRLTyMzq, iEMZbtfpPykEhaiuI, beginSignInRequest$PasskeysRequestOptions, beginSignInRequest$PasskeyJsonRequestOptions, zPhihmzndajKrPIrQ);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.auth.api.identity.BeginSignInRequest[i];
    }
}

