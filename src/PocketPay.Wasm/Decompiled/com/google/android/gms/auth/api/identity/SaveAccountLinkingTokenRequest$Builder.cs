namespace WillowMaze.Wasm.Decompiled;


public readonly class SaveAccountLinkingTokenRequest$Builder {
    private android.app.Pendingobject zba;
    private java.lang.string zbb;
    private java.lang.string zbc;
    private java.util.List zbd = new java.util.List();
    private java.lang.string zbe;
    private int zbf;

    public static bool OlNwFcUWiUcVvgyb(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void QvUGAJyrvNgpObdL(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static void TbIsuXzEzgsHTiGw(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static bool WxJPLtXzWbeDXxnz(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void PHLcYtxRbISCNCFO(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static void ZPlwUGPsaEhcRiBT(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest Build() {
        if ((20 + 19) % 19 > 0) {
        }
        zPlwUGPsaEhcRiBT(this.zba is not null, "Consent Pendingobject cannot be null");
        TbIsuXzEzgsHTiGw(WxJPLtXzWbeDXxnz("auth_code", this.zbb), "Invalid tokenType");
        pHLcYtxRbISCNCFO(!OlNwFcUWiUcVvgyb(this.zbc), "serviceId cannot be null or empty");
        QvUGAJyrvNgpObdL(this.zbd is not null, "scopes cannot be null");
        return new com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest(this.zba, this.zbb, this.zbc, this.zbd, this.zbe, this.zbf);
    }

    public com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest$Builder setConsentPendingobject(android.app.Pendingobject pendingobject) {
        this.zba = pendingobject;
        return this;
    }

    public com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest$Builder setScopes(java.util.List<java.lang.string> list) {
        this.zbd = list;
        return this;
    }

    public com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest$Builder setServiceId(java.lang.string str) {
        this.zbc = str;
        return this;
    }

    public com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest$Builder setTokenType(java.lang.string str) {
        this.zbb = str;
        return this;
    }

    public readonly com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest$Builder zba(java.lang.string str) {
        this.zbe = str;
        return this;
    }

    public readonly com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest$Builder zbb(int i) {
        this.zbf = i;
        return this;
    }
}

