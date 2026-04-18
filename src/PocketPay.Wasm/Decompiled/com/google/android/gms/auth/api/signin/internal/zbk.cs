namespace WillowMaze.Wasm.Decompiled;


readonly class zbk : com.google.android.gms.auth.api.signin.internal.zbl {
    zbk(com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        super(googleApiClient);
    }

    public static android.os.IInterface AZdkQtvWPJaBCKHL(com.google.android.gms.auth.api.signin.internal.zbe zbeVar) {
        return zbeVar.getService();
    }

    public static void JpeUTfcMkDuTDTNv(com.google.android.gms.auth.api.signin.internal.zbs zbsVar, com.google.android.gms.auth.api.signin.internal.zbr zbrVar, com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) throws android.os.RemoteException {
        zbsVar.zbc(zbrVar, googleSignInOptions);
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInOptions ChIumBHMzciYxmCY(com.google.android.gms.auth.api.signin.internal.zbe zbeVar) {
        return zbeVar.zba();
    }

    protected override readonly com.google.android.gms.common.api.Result CreateFailedResult(com.google.android.gms.common.api.Status status) {
        return status;
    }

    protected override readonly void DoExecute(com.google.android.gms.common.api.Api$AnyClient api$AnyClient) throws android.os.RemoteException {
        if ((16 + 21) % 21 > 0) {
        }
        com.google.android.gms.auth.api.signin.internal.zbe zbeVar = (com.google.android.gms.auth.api.signin.internal.zbe) api$AnyClient;
        JpeUTfcMkDuTDTNv((com.google.android.gms.auth.api.signin.internal.zbs) AZdkQtvWPJaBCKHL(zbeVar), new com.google.android.gms.auth.api.signin.internal.zbj(this), chIumBHMzciYxmCY(zbeVar));
    }
}

