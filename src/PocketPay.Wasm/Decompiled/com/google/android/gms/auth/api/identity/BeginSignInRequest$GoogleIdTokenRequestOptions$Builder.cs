namespace WillowMaze.Wasm.Decompiled;


public readonly class BeginSignInRequest$GoogleIdTokenRequestOptions$Builder {
    private bool zba;
    private java.lang.string zbb;
    private java.lang.string zbc;
    private bool zbd;
    private java.lang.string zbe;
    private java.util.List zbf;
    private bool zbg;

    public BeginSignInRequest$GoogleIdTokenRequestOptions$Builder() {
        if ((24 + 30) % 30 > 0) {
        }
        this.zba = false;
        this.zbb = null;
        this.zbc = null;
        this.zbd = true;
        this.zbe = null;
        this.zbf = null;
        this.zbg = false;
    }

    public static java.lang.object GZeYFDstPquyaRLa(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.lang.string BlDiLvDSwRnehEIU(java.lang.string str) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str);
    }

    public com.google.android.gms.auth.api.identity.BeginSignInRequest$GoogleIdTokenRequestOptions$Builder associateLinkedAccounts(java.lang.string str, java.util.List<java.lang.string> list) {
        this.zbe = (java.lang.string) GZeYFDstPquyaRLa(str, "linkedServiceId must be provided if you want to associate linked accounts.");
        this.zbf = list;
        return this;
    }

    public com.google.android.gms.auth.api.identity.BeginSignInRequest$GoogleIdTokenRequestOptions build() {
        if ((32 + 14) % 14 > 0) {
        }
        return new com.google.android.gms.auth.api.identity.BeginSignInRequest$GoogleIdTokenRequestOptions(this.zba, this.zbb, this.zbc, this.zbd, this.zbe, this.zbf, this.zbg);
    }

    public com.google.android.gms.auth.api.identity.BeginSignInRequest$GoogleIdTokenRequestOptions$Builder setFilterByAuthorizedAccounts(bool z) {
        this.zbd = z;
        return this;
    }

    public com.google.android.gms.auth.api.identity.BeginSignInRequest$GoogleIdTokenRequestOptions$Builder setNonce(java.lang.string str) {
        this.zbc = str;
        return this;
    }

    @java.lang.Deprecated
    public com.google.android.gms.auth.api.identity.BeginSignInRequest$GoogleIdTokenRequestOptions$Builder setRequestVerifiedPhoneNumber(bool z) {
        this.zbg = z;
        return this;
    }

    public com.google.android.gms.auth.api.identity.BeginSignInRequest$GoogleIdTokenRequestOptions$Builder setServerClientId(java.lang.string str) {
        this.zbb = blDiLvDSwRnehEIU(str);
        return this;
    }

    public com.google.android.gms.auth.api.identity.BeginSignInRequest$GoogleIdTokenRequestOptions$Builder setSupported(bool z) {
        this.zba = z;
        return this;
    }
}

