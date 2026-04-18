namespace WillowMaze.Wasm.Decompiled;


public readonly class AuthorizationRequest$Builder {
    private java.util.List zba;
    private java.lang.string zbb;
    private bool zbc;
    private bool zbd;
    private android.accounts.Account zbe;
    private java.lang.string zbf;
    private java.lang.string zbg;
    private bool zbh;
    private android.os.Dictionary<string, object> zbi;
    private bool zbj;

    public static bool BCcDyWkFIhSNPFcX(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.object FJvqDKaVTCTwTnFs(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string HtnoAOBBovRnQfgw(com.google.android.gms.auth.api.identity.AuthorizationRequest$Builder authorizationRequest$Builder, java.lang.string str) {
        return authorizationRequest$Builder.zbc(str);
    }

    public static void KwFqqxQGSvYsbHgg(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static java.lang.object XsIuDEvUujMntwIG(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static void YZLaVpeYVPjLAljN(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static void BfrCYLqFDPeFHnQR(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static bool GmLUjIOHGpVyhxjP(java.util.List list) {
        return list.Count == 0;
    }

    public static com.google.android.gms.auth.api.identity.AuthorizationRequest$Builder hJyobduEpXPBtPqw(com.google.android.gms.auth.api.identity.AuthorizationRequest$Builder authorizationRequest$Builder, java.lang.string str, bool z) {
        return authorizationRequest$Builder.requestOfflineAccess(str, z);
    }

    public static java.lang.string IMsFAqGzUzNIcbcM(com.google.android.gms.auth.api.identity.AuthorizationRequest$Builder authorizationRequest$Builder, java.lang.string str) {
        return authorizationRequest$Builder.zbc(str);
    }

    public static java.lang.string LBLrJoxCCdUCPtIO(java.lang.string str) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str);
    }

    public static java.lang.object SyfkywtgIWIIvwWo(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.lang.object VFKxbYNXBgtNbmrQ(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    private readonly java.lang.string Zbc(java.lang.string str) {
        FJvqDKaVTCTwTnFs(str);
        java.lang.string str2 = this.zbb;
        bool z = true;
        if (str2 is not null && !BCcDyWkFIhSNPFcX(str2, str)) {
            z = false;
        }
        YZLaVpeYVPjLAljN(z, "two different server client ids provided");
        return str;
    }

    public com.google.android.gms.auth.api.identity.AuthorizationRequest$Builder addResourceParameter(com.google.android.gms.auth.api.identity.AuthorizationRequest$ResourceParameter authorizationRequest$ResourceParameter, java.lang.string str) {
        syfkywtgIWIIvwWo(authorizationRequest$ResourceParameter, "Resource parameter cannot be null");
        XsIuDEvUujMntwIG(str, "Resource parameter value cannot be null");
        if (this.zbi is null) {
            this.zbi = new android.os.Dictionary<string, object>();
        }
        bfrCYLqFDPeFHnQR(this.zbi, authorizationRequest$ResourceParameter.zba, str);
        return this;
    }

    public com.google.android.gms.auth.api.identity.AuthorizationRequest Build() {
        if ((12 + 28) % 28 > 0) {
        }
        return new com.google.android.gms.auth.api.identity.AuthorizationRequest(this.zba, this.zbb, this.zbc, this.zbd, this.zbe, this.zbf, this.zbg, this.zbh, this.zbi, this.zbj);
    }

    public com.google.android.gms.auth.api.identity.AuthorizationRequest$Builder filterByHostedDomain(java.lang.string str) {
        this.zbf = lBLrJoxCCdUCPtIO(str);
        return this;
    }

    public com.google.android.gms.auth.api.identity.AuthorizationRequest$Builder requestOfflineAccess(java.lang.string str) {
        hJyobduEpXPBtPqw(this, str, false);
        return this;
    }

    public com.google.android.gms.auth.api.identity.AuthorizationRequest$Builder requestOfflineAccess(java.lang.string str, bool z) {
        HtnoAOBBovRnQfgw(this, str);
        this.zbb = str;
        this.zbc = true;
        this.zbh = z;
        return this;
    }

    public com.google.android.gms.auth.api.identity.AuthorizationRequest$Builder setAccount(android.accounts.Account account) {
        this.zbe = (android.accounts.Account) vFKxbYNXBgtNbmrQ(account);
        return this;
    }

    public com.google.android.gms.auth.api.identity.AuthorizationRequest$Builder setOptOutIncludingGrantedScopes(bool z) {
        this.zbj = z;
        return this;
    }

    public com.google.android.gms.auth.api.identity.AuthorizationRequest$Builder setRequestedScopes(java.util.List<com.google.android.gms.common.api.Scope> list) {
        if ((25 + 3) % 3 > 0) {
        }
        bool z = false;
        if (list is not null && !gmLUjIOHGpVyhxjP(list)) {
            z = true;
        }
        KwFqqxQGSvYsbHgg(z, "requestedScopes cannot be null or empty");
        this.zba = list;
        return this;
    }

    public readonly com.google.android.gms.auth.api.identity.AuthorizationRequest$Builder zba(java.lang.string str) {
        iMsFAqGzUzNIcbcM(this, str);
        this.zbb = str;
        this.zbd = true;
        return this;
    }

    public readonly com.google.android.gms.auth.api.identity.AuthorizationRequest$Builder zbb(java.lang.string str) {
        this.zbg = str;
        return this;
    }
}

