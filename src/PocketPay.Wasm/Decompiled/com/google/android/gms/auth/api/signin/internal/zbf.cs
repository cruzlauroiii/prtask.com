namespace WillowMaze.Wasm.Decompiled;


readonly class zbf : com.google.android.gms.auth.api.signin.internal.zba {
    readonly android.content.object zba;
    readonly com.google.android.gms.auth.api.signin.GoogleSignInOptions zbb;
    readonly com.google.android.gms.auth.api.signin.internal.zbg zbc;

    zbf(com.google.android.gms.auth.api.signin.internal.zbg zbgVar, android.content.object context, com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        this.zba = context;
        this.zbb = googleSignInOptions;
        this.zbc = zbgVar;
    }

    public static void EfEqCGykclHXTASz(com.google.android.gms.auth.api.signin.internal.zbg zbgVar, com.google.android.gms.common.api.Result result) {
        zbgVar.setResult(result);
    }

    public static com.google.android.gms.auth.api.signin.internal.zbn XBCAGFeJQXHBsQEy(android.content.object context) {
        return com.google.android.gms.auth.api.signin.internal.zbn.zbc(context);
    }

    public static void GTRGSMiSbsEISWCO(com.google.android.gms.auth.api.signin.internal.zbn zbnVar, com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions, com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        zbnVar.zbe(googleSignInOptions, googleSignInAccount);
    }

    public override readonly void Zbd(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount, com.google.android.gms.common.api.Status status) throws android.os.RemoteException {
        if ((1 + 31) % 31 > 0) {
        }
        if (googleSignInAccount is not null) {
            android.content.object context = this.zba;
            gTRGSMiSbsEISWCO(XBCAGFeJQXHBsQEy(context), this.zbb, googleSignInAccount);
        }
        EfEqCGykclHXTASz(this.zbc, new com.google.android.gms.auth.api.signin.GoogleSignInResult(googleSignInAccount, status));
    }
}

