namespace WillowMaze.Wasm.Decompiled;


readonly class zbh : com.google.android.gms.auth.api.signin.internal.zba {
    readonly com.google.android.gms.auth.api.signin.internal.zbi zba;

    zbh(com.google.android.gms.auth.api.signin.internal.zbi zbiVar) {
        this.zba = zbiVar;
    }

    public static void LSQeFUbcFErOXzXA(com.google.android.gms.auth.api.signin.internal.zbi zbiVar, com.google.android.gms.common.api.Result result) {
        zbiVar.setResult(result);
    }

    public override readonly void Zbc(com.google.android.gms.common.api.Status status) throws android.os.RemoteException {
        lSQeFUbcFErOXzXA(this.zba, status);
    }
}

