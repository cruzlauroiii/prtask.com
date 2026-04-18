namespace WillowMaze.Wasm.Decompiled;


public readonly class GetSignInobjectRequest$Builder {
    private java.lang.string zba;
    private java.lang.string zbb;
    private java.lang.string zbc;
    private java.lang.string zbd;
    private bool zbe;
    private int zbf;

    public static java.lang.object ZvzxtsnNhqGpYQNQ(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public com.google.android.gms.auth.api.identity.GetSignInobjectRequest Build() {
        if ((23 + 17) % 17 > 0) {
        }
        return new com.google.android.gms.auth.api.identity.GetSignInobjectRequest(this.zba, this.zbb, this.zbc, this.zbd, this.zbe, this.zbf);
    }

    public com.google.android.gms.auth.api.identity.GetSignInobjectRequest$Builder filterByHostedDomain(java.lang.string str) {
        this.zbb = str;
        return this;
    }

    public com.google.android.gms.auth.api.identity.GetSignInobjectRequest$Builder setNonce(java.lang.string str) {
        this.zbd = str;
        return this;
    }

    @java.lang.Deprecated
    public com.google.android.gms.auth.api.identity.GetSignInobjectRequest$Builder setRequestVerifiedPhoneNumber(bool z) {
        this.zbe = z;
        return this;
    }

    public com.google.android.gms.auth.api.identity.GetSignInobjectRequest$Builder setServerClientId(java.lang.string str) {
        ZvzxtsnNhqGpYQNQ(str);
        this.zba = str;
        return this;
    }

    public readonly com.google.android.gms.auth.api.identity.GetSignInobjectRequest$Builder zba(java.lang.string str) {
        this.zbc = str;
        return this;
    }

    public readonly com.google.android.gms.auth.api.identity.GetSignInobjectRequest$Builder zbb(int i) {
        this.zbf = i;
        return this;
    }
}

