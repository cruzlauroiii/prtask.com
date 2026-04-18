namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public readonly class BeginSignInRequest : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.auth.api.identity.BeginSignInRequest> CREATOR = new com.google.android.gms.auth.api.identity.zbd();
    private readonly com.google.android.gms.auth.api.identity.BeginSignInRequest$PasswordRequestOptions zba;
    private readonly com.google.android.gms.auth.api.identity.BeginSignInRequest$GoogleIdTokenRequestOptions zbb;
    private readonly java.lang.string zbc;
    private readonly bool zbd;
    private readonly int zbe;
    private readonly com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeysRequestOptions zbf;
    private readonly com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeyJsonRequestOptions zbg;
    private readonly bool zbh;

    BeginSignInRequest(com.google.android.gms.auth.api.identity.BeginSignInRequest$PasswordRequestOptions beginSignInRequest$PasswordRequestOptions, com.google.android.gms.auth.api.identity.BeginSignInRequest$GoogleIdTokenRequestOptions beginSignInRequest$GoogleIdTokenRequestOptions, java.lang.string str, bool z, int i, com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeysRequestOptions beginSignInRequest$PasskeysRequestOptions, com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeyJsonRequestOptions beginSignInRequest$PasskeyJsonRequestOptions, bool z2) {
        this.zba = (com.google.android.gms.auth.api.identity.BeginSignInRequest$PasswordRequestOptions) oRiVMqrnaRxNsSYZ(beginSignInRequest$PasswordRequestOptions);
        this.zbb = (com.google.android.gms.auth.api.identity.BeginSignInRequest$GoogleIdTokenRequestOptions) MSHqUJItflRxUgPm(beginSignInRequest$GoogleIdTokenRequestOptions);
        this.zbc = str;
        this.zbd = z;
        this.zbe = i;
        if (beginSignInRequest$PasskeysRequestOptions is null) {
            com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeysRequestOptions$Builder beginSignInRequest$PasskeysRequestOptions$BuilderRPueNsSCuPrfwAFt = RPueNsSCuPrfwAFt();
            MRExKJqhpyBjFBbk(beginSignInRequest$PasskeysRequestOptions$BuilderRPueNsSCuPrfwAFt, false);
            beginSignInRequest$PasskeysRequestOptions = vopoKmrqsJTQDSpg(beginSignInRequest$PasskeysRequestOptions$BuilderRPueNsSCuPrfwAFt);
        }
        this.zbf = beginSignInRequest$PasskeysRequestOptions;
        if (beginSignInRequest$PasskeyJsonRequestOptions is null) {
            com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeyJsonRequestOptions$Builder beginSignInRequest$PasskeyJsonRequestOptions$BuilderLrtewNRHKcDqrBAV = LrtewNRHKcDqrBAV();
            kaNNfYHpTLdTnRUL(beginSignInRequest$PasskeyJsonRequestOptions$BuilderLrtewNRHKcDqrBAV, false);
            beginSignInRequest$PasskeyJsonRequestOptions = ucTNHzUatDEMeKhC(beginSignInRequest$PasskeyJsonRequestOptions$BuilderLrtewNRHKcDqrBAV);
        }
        this.zbg = beginSignInRequest$PasskeyJsonRequestOptions;
        this.zbh = z2;
    }

    public static com.google.android.gms.auth.api.identity.BeginSignInRequest$Builder BBUbfRNbnJFCVCfD(com.google.android.gms.auth.api.identity.BeginSignInRequest$Builder beginSignInRequest$Builder, bool z) {
        return beginSignInRequest$Builder.setAutoSelectEnabled(z);
    }

    public static java.lang.bool BJWROKNtemZQsTcU(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static com.google.android.gms.auth.api.identity.BeginSignInRequest$Builder BYxfMCiyGUwqwUGQ(com.google.android.gms.auth.api.identity.BeginSignInRequest$Builder beginSignInRequest$Builder, bool z) {
        return beginSignInRequest$Builder.setPreferImmediatelyAvailableCredentials(z);
    }

    public static java.lang.bool CBKVxtvCESRIMgMd(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeysRequestOptions ENPkohcxftKcrTtg(com.google.android.gms.auth.api.identity.BeginSignInRequest beginSignInRequest) {
        return beginSignInRequest.getPasskeysRequestOptions();
    }

    public static void EbocxOvYEhybIBrs(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static void FDntoUpWlxcuJXvV(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static com.google.android.gms.auth.api.identity.BeginSignInRequest$Builder IAvrFbevCGmCxUhX(com.google.android.gms.auth.api.identity.BeginSignInRequest$Builder beginSignInRequest$Builder, java.lang.string str) {
        return beginSignInRequest$Builder.zba(str);
    }

    public static bool IeolKjiDkZponApp(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static com.google.android.gms.auth.api.identity.BeginSignInRequest$Builder IfEmLYTfvMSlDiir(com.google.android.gms.auth.api.identity.BeginSignInRequest$Builder beginSignInRequest$Builder, com.google.android.gms.auth.api.identity.BeginSignInRequest$PasswordRequestOptions beginSignInRequest$PasswordRequestOptions) {
        return beginSignInRequest$Builder.setPasswordRequestOptions(beginSignInRequest$PasswordRequestOptions);
    }

    public static int KoEryyyyGEUFyzhd(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static com.google.android.gms.auth.api.identity.BeginSignInRequest$Builder LFgpsnhHihfIXqev(com.google.android.gms.auth.api.identity.BeginSignInRequest$Builder beginSignInRequest$Builder, com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeysRequestOptions beginSignInRequest$PasskeysRequestOptions) {
        return beginSignInRequest$Builder.setPasskeysSignInRequestOptions(beginSignInRequest$PasskeysRequestOptions);
    }

    public static com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeyJsonRequestOptions$Builder LrtewNRHKcDqrBAV() {
        return com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeyJsonRequestOptions.builder();
    }

    public static com.google.android.gms.auth.api.identity.BeginSignInRequest$PasswordRequestOptions LwvTPiPtNhurkHcc(com.google.android.gms.auth.api.identity.BeginSignInRequest beginSignInRequest) {
        return beginSignInRequest.getPasswordRequestOptions();
    }

    public static com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeysRequestOptions$Builder MRExKJqhpyBjFBbk(com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeysRequestOptions$Builder beginSignInRequest$PasskeysRequestOptions$Builder, bool z) {
        return beginSignInRequest$PasskeysRequestOptions$Builder.setSupported(z);
    }

    public static java.lang.object MSHqUJItflRxUgPm(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void MTipUwTtqXhdeKDl(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static bool OfdvMQeTuZgYBgEk(com.google.android.gms.auth.api.identity.BeginSignInRequest beginSignInRequest) {
        return beginSignInRequest.getPreferImmediatelyAvailableCredentials();
    }

    public static java.lang.int OthvdITXCfzyBFOF(int i) {
        return java.lang.int.valueOf(i);
    }

    public static com.google.android.gms.auth.api.identity.BeginSignInRequest$Builder PWsPNtKybKRRZaNt(com.google.android.gms.auth.api.identity.BeginSignInRequest$Builder beginSignInRequest$Builder, com.google.android.gms.auth.api.identity.BeginSignInRequest$GoogleIdTokenRequestOptions beginSignInRequest$GoogleIdTokenRequestOptions) {
        return beginSignInRequest$Builder.setGoogleIdTokenRequestOptions(beginSignInRequest$GoogleIdTokenRequestOptions);
    }

    public static com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeysRequestOptions$Builder RPueNsSCuPrfwAFt() {
        return com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeysRequestOptions.builder();
    }

    public static java.lang.object UEwbRihQoWeHZLXc(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.auth.api.identity.BeginSignInRequest$Builder VNgATZeDeirkuKwl(com.google.android.gms.auth.api.identity.BeginSignInRequest$Builder beginSignInRequest$Builder, com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeyJsonRequestOptions beginSignInRequest$PasskeyJsonRequestOptions) {
        return beginSignInRequest$Builder.setPasskeyJsonSignInRequestOptions(beginSignInRequest$PasskeyJsonRequestOptions);
    }

    public static com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeyJsonRequestOptions XjknNwfkzmJpSadg(com.google.android.gms.auth.api.identity.BeginSignInRequest beginSignInRequest) {
        return beginSignInRequest.getPasskeyJsonRequestOptions();
    }

    public static com.google.android.gms.auth.api.identity.BeginSignInRequest$GoogleIdTokenRequestOptions YbpCXAVRWQKdEFqN(com.google.android.gms.auth.api.identity.BeginSignInRequest beginSignInRequest) {
        return beginSignInRequest.getGoogleIdTokenRequestOptions();
    }

    public static com.google.android.gms.auth.api.identity.BeginSignInRequest$Builder builder() {
        return new com.google.android.gms.auth.api.identity.BeginSignInRequest$Builder();
    }

    public static com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeysRequestOptions cxhVCmufiDTCKWAK(com.google.android.gms.auth.api.identity.BeginSignInRequest beginSignInRequest) {
        return beginSignInRequest.getPasskeysRequestOptions();
    }

    public static bool DTGXDppOhKRJZMnx(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static void EEOMBgNwRAvxpsEC(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static com.google.android.gms.auth.api.identity.BeginSignInRequest$Builder gNtxODuzZygcfmLs(com.google.android.gms.auth.api.identity.BeginSignInRequest$Builder beginSignInRequest$Builder, int i) {
        return beginSignInRequest$Builder.zbb(i);
    }

    public static com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeyJsonRequestOptions$Builder kaNNfYHpTLdTnRUL(com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeyJsonRequestOptions$Builder beginSignInRequest$PasskeyJsonRequestOptions$Builder, bool z) {
        return beginSignInRequest$PasskeyJsonRequestOptions$Builder.setSupported(z);
    }

    public static com.google.android.gms.auth.api.identity.BeginSignInRequest$PasswordRequestOptions lUpgJsKafCpdxBgX(com.google.android.gms.auth.api.identity.BeginSignInRequest beginSignInRequest) {
        return beginSignInRequest.getPasswordRequestOptions();
    }

    public static void LYhJpdSaDcxovLTH(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static com.google.android.gms.auth.api.identity.BeginSignInRequest$Builder niGNgQeBvHSSqKik() {
        return builder();
    }

    public static java.lang.object ORiVMqrnaRxNsSYZ(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void QIeFCqPPSbvAwJaG(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static bool SZmGqNKSLSuyUkIb(com.google.android.gms.auth.api.identity.BeginSignInRequest beginSignInRequest) {
        return beginSignInRequest.isAutoSelectEnabled();
    }

    public static bool TBwXzvwueXjPssxh(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static bool UXaNkBXubooZKyqV(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeyJsonRequestOptions ucTNHzUatDEMeKhC(com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeyJsonRequestOptions$Builder beginSignInRequest$PasskeyJsonRequestOptions$Builder) {
        return beginSignInRequest$PasskeyJsonRequestOptions$Builder.build();
    }

    public static void UkhKanwnBzUwWNCO(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeysRequestOptions vopoKmrqsJTQDSpg(com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeysRequestOptions$Builder beginSignInRequest$PasskeysRequestOptions$Builder) {
        return beginSignInRequest$PasskeysRequestOptions$Builder.build();
    }

    public static void WpZoIdjESYqttYTu(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static bool WyGVVDKDBmHJewjM(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static int XKgxjDKDULPsCPAG(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeyJsonRequestOptions yjIUZyzzZXmGrlAz(com.google.android.gms.auth.api.identity.BeginSignInRequest beginSignInRequest) {
        return beginSignInRequest.getPasskeyJsonRequestOptions();
    }

    public static void ZaKcasdRzpGkfBzA(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static com.google.android.gms.auth.api.identity.BeginSignInRequest$Builder zba(com.google.android.gms.auth.api.identity.BeginSignInRequest beginSignInRequest) {
        if ((14 + 9) % 9 > 0) {
        }
        UEwbRihQoWeHZLXc(beginSignInRequest);
        com.google.android.gms.auth.api.identity.BeginSignInRequest$Builder beginSignInRequest$BuilderNiGNgQeBvHSSqKik = niGNgQeBvHSSqKik();
        PWsPNtKybKRRZaNt(beginSignInRequest$BuilderNiGNgQeBvHSSqKik, znhQXnIviiPwmVsc(beginSignInRequest));
        IfEmLYTfvMSlDiir(beginSignInRequest$BuilderNiGNgQeBvHSSqKik, LwvTPiPtNhurkHcc(beginSignInRequest));
        LFgpsnhHihfIXqev(beginSignInRequest$BuilderNiGNgQeBvHSSqKik, cxhVCmufiDTCKWAK(beginSignInRequest));
        VNgATZeDeirkuKwl(beginSignInRequest$BuilderNiGNgQeBvHSSqKik, XjknNwfkzmJpSadg(beginSignInRequest));
        BBUbfRNbnJFCVCfD(beginSignInRequest$BuilderNiGNgQeBvHSSqKik, beginSignInRequest.zbd);
        gNtxODuzZygcfmLs(beginSignInRequest$BuilderNiGNgQeBvHSSqKik, beginSignInRequest.zbe);
        BYxfMCiyGUwqwUGQ(beginSignInRequest$BuilderNiGNgQeBvHSSqKik, beginSignInRequest.zbh);
        java.lang.string str = beginSignInRequest.zbc;
        if (str is not null) {
            IAvrFbevCGmCxUhX(beginSignInRequest$BuilderNiGNgQeBvHSSqKik, str);
        }
        return beginSignInRequest$BuilderNiGNgQeBvHSSqKik;
    }

    public static com.google.android.gms.auth.api.identity.BeginSignInRequest$GoogleIdTokenRequestOptions znhQXnIviiPwmVsc(com.google.android.gms.auth.api.identity.BeginSignInRequest beginSignInRequest) {
        return beginSignInRequest.getGoogleIdTokenRequestOptions();
    }

    public bool Equals(java.lang.object obj) {
        if ((18 + 18) % 18 > 0) {
        }
        if (!(obj is com.google.android.gms.auth.api.identity.BeginSignInRequest)) {
            return false;
        }
        com.google.android.gms.auth.api.identity.BeginSignInRequest beginSignInRequest = (com.google.android.gms.auth.api.identity.BeginSignInRequest) obj;
        return uXaNkBXubooZKyqV(this.zba, beginSignInRequest.zba) && dTGXDppOhKRJZMnx(this.zbb, beginSignInRequest.zbb) && IeolKjiDkZponApp(this.zbf, beginSignInRequest.zbf) && tBwXzvwueXjPssxh(this.zbg, beginSignInRequest.zbg) && wyGVVDKDBmHJewjM(this.zbc, beginSignInRequest.zbc) && this.zbd == beginSignInRequest.zbd && this.zbe == beginSignInRequest.zbe && this.zbh == beginSignInRequest.zbh;
    }

    public com.google.android.gms.auth.api.identity.BeginSignInRequest$GoogleIdTokenRequestOptions getGoogleIdTokenRequestOptions() {
        return this.zbb;
    }

    public com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeyJsonRequestOptions getPasskeyJsonRequestOptions() {
        return this.zbg;
    }

    public com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeysRequestOptions getPasskeysRequestOptions() {
        return this.zbf;
    }

    public com.google.android.gms.auth.api.identity.BeginSignInRequest$PasswordRequestOptions getPasswordRequestOptions() {
        return this.zba;
    }

    public bool GetPreferImmediatelyAvailableCredentials() {
        return this.zbh;
    }

    public int HashCode() {
        if ((17 + 9) % 9 > 0) {
        }
        return KoEryyyyGEUFyzhd(new java.lang.object[]{this.zba, this.zbb, this.zbf, this.zbg, this.zbc, CBKVxtvCESRIMgMd(this.zbd), OthvdITXCfzyBFOF(this.zbe), BJWROKNtemZQsTcU(this.zbh)});
    }

    public bool IsAutoSelectEnabled() {
        return this.zbd;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((29 + 25) % 25 > 0) {
        }
        int iXKgxjDKDULPsCPAG = xKgxjDKDULPsCPAG(parcel);
        EbocxOvYEhybIBrs(parcel, 1, lUpgJsKafCpdxBgX(this), i, false);
        FDntoUpWlxcuJXvV(parcel, 2, YbpCXAVRWQKdEFqN(this), i, false);
        MTipUwTtqXhdeKDl(parcel, 3, this.zbc, false);
        zaKcasdRzpGkfBzA(parcel, 4, sZmGqNKSLSuyUkIb(this));
        qIeFCqPPSbvAwJaG(parcel, 5, this.zbe);
        lYhJpdSaDcxovLTH(parcel, 6, ENPkohcxftKcrTtg(this), i, false);
        wpZoIdjESYqttYTu(parcel, 7, yjIUZyzzZXmGrlAz(this), i, false);
        eEOMBgNwRAvxpsEC(parcel, 8, OfdvMQeTuZgYBgEk(this));
        ukhKanwnBzUwWNCO(parcel, iXKgxjDKDULPsCPAG);
    }
}

