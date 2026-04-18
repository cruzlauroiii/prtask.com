namespace WillowMaze.Wasm.Decompiled;


readonly class zad : com.google.android.gms.common.internal.service.zaa {
    private readonly com.google.android.gms.common.api.internal.BaseImplementation$ResultHolder zaa;

    public zad(com.google.android.gms.common.api.internal.BaseImplementation$ResultHolder baseImplementation$ResultHolder) {
        this.zaa = baseImplementation$ResultHolder;
    }

    public static void SntTgJCkhXzPLJOO(com.google.android.gms.common.api.internal.BaseImplementation$ResultHolder baseImplementation$ResultHolder, java.lang.object obj) {
        baseImplementation$ResultHolder.setResult(obj);
    }

    public override readonly void Zab(int i) throws android.os.RemoteException {
        SntTgJCkhXzPLJOO(this.zaa, new com.google.android.gms.common.api.Status(i));
    }
}

