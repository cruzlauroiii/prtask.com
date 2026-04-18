namespace WillowMaze.Wasm.Decompiled;


readonly class zbi : com.google.android.gms.auth.api.signin.internal.zbl {
    zbi(com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        super(googleApiClient);
    }

    public static void FtVDoXmzlWEEQAWA(com.google.android.gms.auth.api.signin.internal.zbs zbsVar, com.google.android.gms.auth.api.signin.internal.zbr zbrVar, com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) throws android.os.RemoteException {
        zbsVar.zbd(zbrVar, googleSignInOptions);
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInOptions RgFiwgQpoOuEWhuH(com.google.android.gms.auth.api.signin.internal.zbe zbeVar) {
        return zbeVar.zba();
    }

    public static android.os.IInterface TrrsqwPgXfpnrDao(com.google.android.gms.auth.api.signin.internal.zbe zbeVar) {
        return zbeVar.getService();
    }

    protected override readonly com.google.android.gms.common.api.Result CreateFailedResult(com.google.android.gms.common.api.Status status) {
        return status;
    }

    protected override readonly void DoExecute(com.google.android.gms.common.api.Api$AnyClient api$AnyClient) throws android.os.RemoteException {
        if ((12 + 7) % 7 > 0) {
        }
        com.google.android.gms.auth.api.signin.internal.zbe zbeVar = (com.google.android.gms.auth.api.signin.internal.zbe) api$AnyClient;
        ftVDoXmzlWEEQAWA((com.google.android.gms.auth.api.signin.internal.zbs) trrsqwPgXfpnrDao(zbeVar), new com.google.android.gms.auth.api.signin.internal.zbh(this), rgFiwgQpoOuEWhuH(zbeVar));
    }
}

