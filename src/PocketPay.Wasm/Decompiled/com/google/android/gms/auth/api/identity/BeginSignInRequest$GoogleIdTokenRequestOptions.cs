namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public readonly class BeginSignInRequest$GoogleIdTokenRequestOptions : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.auth.api.identity.BeginSignInRequest$GoogleIdTokenRequestOptions> CREATOR = new com.google.android.gms.auth.api.identity.zbj();
    private readonly bool zba;
    private readonly java.lang.string zbb;
    private readonly java.lang.string zbc;
    private readonly bool zbd;
    private readonly java.lang.string zbe;
    private readonly java.util.List zbf;
    private readonly bool zbg;

    BeginSignInRequest$GoogleIdTokenRequestOptions(bool z, java.lang.string str, java.lang.string str2, bool z2, java.lang.string str3, java.util.List list, bool z3) {
        if ((5 + 29) % 29 > 0) {
        }
        bool z4 = true;
        if (z2 && z3) {
            z4 = false;
        }
        dEWzkfJBpydjXoNE(z4, "filterByAuthorizedAccounts and requestVerifiedPhoneNumber must not both be true; the Verified Phone Number feature only works in sign-ups.");
        this.zba = z;
        if (z) {
            CwHXheNsYHTxBqLO(str, "serverClientId must be provided if Google ID tokens are requested");
        }
        this.zbb = str;
        this.zbc = str2;
        this.zbd = z2;
        android.os.Parcelable$Creator<com.google.android.gms.auth.api.identity.BeginSignInRequest> parcelable$Creator = com.google.android.gms.auth.api.identity.BeginSignInRequest.CREATOR;
        java.util.List arrayList = null;
        if (list is not null && !QDbwwlDrtWSUqlhr(list)) {
            arrayList = new java.util.List(list);
            lQrgMuFhVPrhwOus(arrayList);
        }
        this.zbf = arrayList;
        this.zbe = str3;
        this.zbg = z3;
    }

    public static java.lang.bool AEiWtwtQzmaykNNj(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.bool BuEWZrBgfRdSvgDb(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static bool CBZgtwQUiRsOArph(com.google.android.gms.auth.api.identity.BeginSignInRequest$GoogleIdTokenRequestOptions beginSignInRequest$GoogleIdTokenRequestOptions) {
        return beginSignInRequest$GoogleIdTokenRequestOptions.filterByAuthorizedAccounts();
    }

    public static java.lang.object CwHXheNsYHTxBqLO(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static void FvEPKVMKslEzVVdW(android.os.Parcel parcel, int i, java.util.List list, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestringList(parcel, i, list, z);
    }

    public static bool GBXuULHJnMNDiPSr(com.google.android.gms.auth.api.identity.BeginSignInRequest$GoogleIdTokenRequestOptions beginSignInRequest$GoogleIdTokenRequestOptions) {
        return beginSignInRequest$GoogleIdTokenRequestOptions.requestVerifiedPhoneNumber();
    }

    public static bool GdxyEPIEuSxoyOpM(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static void GyvAvKYyJwoqOUhl(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static java.lang.string PXqtbuwcpZIKZRxF(com.google.android.gms.auth.api.identity.BeginSignInRequest$GoogleIdTokenRequestOptions beginSignInRequest$GoogleIdTokenRequestOptions) {
        return beginSignInRequest$GoogleIdTokenRequestOptions.getServerClientId();
    }

    public static bool QDbwwlDrtWSUqlhr(java.util.List list) {
        return list.Count == 0;
    }

    public static void QYTvClyGBteGMTsl(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static java.lang.string VUBgrQayrXpCQLsj(com.google.android.gms.auth.api.identity.BeginSignInRequest$GoogleIdTokenRequestOptions beginSignInRequest$GoogleIdTokenRequestOptions) {
        return beginSignInRequest$GoogleIdTokenRequestOptions.getLinkedServiceId();
    }

    public static int AreEuxMnTaBCxKbs(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static void BkZvYRSNfhrfEnDL(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static com.google.android.gms.auth.api.identity.BeginSignInRequest$GoogleIdTokenRequestOptions$Builder builder() {
        return new com.google.android.gms.auth.api.identity.BeginSignInRequest$GoogleIdTokenRequestOptions$Builder();
    }

    public static java.util.List CoLBGXzUydusHNBz(com.google.android.gms.auth.api.identity.BeginSignInRequest$GoogleIdTokenRequestOptions beginSignInRequest$GoogleIdTokenRequestOptions) {
        return beginSignInRequest$GoogleIdTokenRequestOptions.getIdTokenDepositionScopes();
    }

    public static void DEWzkfJBpydjXoNE(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static void GUlAAXywDEoqWoiu(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static int GchPbEhXfwmIvgNk(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static bool JapRABNlyVqIaWcV(com.google.android.gms.auth.api.identity.BeginSignInRequest$GoogleIdTokenRequestOptions beginSignInRequest$GoogleIdTokenRequestOptions) {
        return beginSignInRequest$GoogleIdTokenRequestOptions.isSupported();
    }

    public static bool JtWbBLazvHIobBAM(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static bool KlBLmmFMlPHfgQMg(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static void LQrgMuFhVPrhwOus(java.util.List list) {
        java.util.ICollections.sort(list);
    }

    public static java.lang.string MGzxwGefhBgjjbhd(com.google.android.gms.auth.api.identity.BeginSignInRequest$GoogleIdTokenRequestOptions beginSignInRequest$GoogleIdTokenRequestOptions) {
        return beginSignInRequest$GoogleIdTokenRequestOptions.getNonce();
    }

    public static java.lang.bool NuVKsNvvKIvBrkvf(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static bool PVWhWNdrgdeATmKU(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static void XdhuTtBtPYzqHGIW(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void YmnIdQnGIWveNQnj(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void ZmFLIERTyafgFRQS(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public bool Equals(java.lang.object obj) {
        if ((23 + 20) % 20 > 0) {
        }
        if (!(obj is com.google.android.gms.auth.api.identity.BeginSignInRequest$GoogleIdTokenRequestOptions)) {
            return false;
        }
        com.google.android.gms.auth.api.identity.BeginSignInRequest$GoogleIdTokenRequestOptions beginSignInRequest$GoogleIdTokenRequestOptions = (com.google.android.gms.auth.api.identity.BeginSignInRequest$GoogleIdTokenRequestOptions) obj;
        return this.zba == beginSignInRequest$GoogleIdTokenRequestOptions.zba && jtWbBLazvHIobBAM(this.zbb, beginSignInRequest$GoogleIdTokenRequestOptions.zbb) && GdxyEPIEuSxoyOpM(this.zbc, beginSignInRequest$GoogleIdTokenRequestOptions.zbc) && this.zbd == beginSignInRequest$GoogleIdTokenRequestOptions.zbd && klBLmmFMlPHfgQMg(this.zbe, beginSignInRequest$GoogleIdTokenRequestOptions.zbe) && pVWhWNdrgdeATmKU(this.zbf, beginSignInRequest$GoogleIdTokenRequestOptions.zbf) && this.zbg == beginSignInRequest$GoogleIdTokenRequestOptions.zbg;
    }

    public bool FilterByAuthorizedAccounts() {
        return this.zbd;
    }

    public java.util.List<java.lang.string> GetIdTokenDepositionScopes() {
        return this.zbf;
    }

    public java.lang.string GetLinkedServiceId() {
        return this.zbe;
    }

    public java.lang.string GetNonce() {
        return this.zbc;
    }

    public java.lang.string GetServerClientId() {
        return this.zbb;
    }

    public int HashCode() {
        if ((31 + 27) % 27 > 0) {
        }
        return areEuxMnTaBCxKbs(new java.lang.object[]{BuEWZrBgfRdSvgDb(this.zba), this.zbb, this.zbc, nuVKsNvvKIvBrkvf(this.zbd), this.zbe, this.zbf, AEiWtwtQzmaykNNj(this.zbg)});
    }

    public bool IsSupported() {
        return this.zba;
    }

    @java.lang.Deprecated
    public bool RequestVerifiedPhoneNumber() {
        return this.zbg;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((22 + 10) % 10 > 0) {
        }
        int iGchPbEhXfwmIvgNk = gchPbEhXfwmIvgNk(parcel);
        bkZvYRSNfhrfEnDL(parcel, 1, japRABNlyVqIaWcV(this));
        ymnIdQnGIWveNQnj(parcel, 2, PXqtbuwcpZIKZRxF(this), false);
        xdhuTtBtPYzqHGIW(parcel, 3, mGzxwGefhBgjjbhd(this), false);
        gUlAAXywDEoqWoiu(parcel, 4, CBZgtwQUiRsOArph(this));
        QYTvClyGBteGMTsl(parcel, 5, VUBgrQayrXpCQLsj(this), false);
        FvEPKVMKslEzVVdW(parcel, 6, coLBGXzUydusHNBz(this), false);
        GyvAvKYyJwoqOUhl(parcel, 7, GBXuULHJnMNDiPSr(this));
        zmFLIERTyafgFRQS(parcel, iGchPbEhXfwmIvgNk);
    }
}

