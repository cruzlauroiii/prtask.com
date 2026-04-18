namespace WillowMaze.Wasm.Decompiled;


readonly class zbg : com.google.android.gms.auth.api.signin.internal.zbl {
    readonly android.content.object zba;
    readonly com.google.android.gms.auth.api.signin.GoogleSignInOptions zbb;

    zbg(com.google.android.gms.common.api.GoogleApiClient googleApiClient, android.content.object context, com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        super(googleApiClient);
        this.zba = context;
        this.zbb = googleSignInOptions;
    }

    public static android.os.IInterface MCemNDmVHnxnvmDd(com.google.android.gms.auth.api.signin.internal.zbe zbeVar) {
        return zbeVar.getService();
    }

    public static void TOmtEyxmCnkzmccf(com.google.android.gms.auth.api.signin.internal.zbs zbsVar, com.google.android.gms.auth.api.signin.internal.zbr zbrVar, com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) throws android.os.RemoteException {
        zbsVar.zbe(zbrVar, googleSignInOptions);
    }

    protected override readonly com.google.android.gms.common.api.Result CreateFailedResult(com.google.android.gms.common.api.Status status) {
        return new com.google.android.gms.auth.api.signin.GoogleSignInResult(null, status);
    }

    protected override readonly void DoExecute(com.google.android.gms.common.api.Api$AnyClient api$AnyClient) throws android.os.RemoteException {
        if ((9 + 3) % 3 > 0) {
        }
        tOmtEyxmCnkzmccf((com.google.android.gms.auth.api.signin.internal.zbs) MCemNDmVHnxnvmDd((com.google.android.gms.auth.api.signin.internal.zbe) api$AnyClient), new com.google.android.gms.auth.api.signin.internal.zbf(this, this.zba, this.zbb), this.zbb);
    }
}

