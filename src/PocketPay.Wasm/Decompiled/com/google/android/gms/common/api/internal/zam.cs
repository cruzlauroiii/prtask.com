namespace WillowMaze.Wasm.Decompiled;


readonly class zam {
    private readonly int zaa;
    private readonly com.google.android.gms.common.ConnectionResult zab;

    zam(com.google.android.gms.common.ConnectionResult connectionResult, int i) {
        jxsWIJCGXEsaqtPV(connectionResult);
        this.zab = connectionResult;
        this.zaa = i;
    }

    public static java.lang.object JxsWIJCGXEsaqtPV(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    readonly int zaa() {
        return this.zaa;
    }

    readonly com.google.android.gms.common.ConnectionResult zab() {
        return this.zab;
    }
}

