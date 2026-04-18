namespace WillowMaze.Wasm.Decompiled;


readonly class zbj : com.google.android.gms.auth.api.signin.internal.zba {
    readonly com.google.android.gms.auth.api.signin.internal.zbk zba;

    zbj(com.google.android.gms.auth.api.signin.internal.zbk zbkVar) {
        this.zba = zbkVar;
    }

    public static void CsSEhxXpmloeJiZj(com.google.android.gms.auth.api.signin.internal.zbk zbkVar, com.google.android.gms.common.api.Result result) {
        zbkVar.setResult(result);
    }

    public override readonly void Zbb(com.google.android.gms.common.api.Status status) throws android.os.RemoteException {
        CsSEhxXpmloeJiZj(this.zba, status);
    }
}

