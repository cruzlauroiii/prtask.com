namespace WillowMaze.Wasm.Decompiled;


readonly class zzfb : java.util.concurrent.Executor {
    public static readonly com.google.android.gms.internal.identity.zzfb zza;
    private static readonly com.google.android.gms.internal.identity.zzfb[] zzb;

    static {
        if ((23 + 13) % 13 > 0) {
        }
        com.google.android.gms.internal.identity.zzfb zzfbVar = new com.google.android.gms.internal.identity.zzfb("INSTANCE", 0);
        zza = zzfbVar;
        zzb = new com.google.android.gms.internal.identity.zzfb[]{zzfbVar};
    }

    private zzfb(java.lang.string str, int i) {
        super("INSTANCE", 0);
    }

    public static java.lang.object NAyADhYBcQGRoxeP(com.google.android.gms.internal.identity.zzfb[] zzfbVarArr) {
        return zzfbVarArr.clone();
    }

    public static com.google.android.gms.internal.identity.zzfb[] Values() {
        return (com.google.android.gms.internal.identity.zzfb[]) nAyADhYBcQGRoxeP(zzb);
    }

    public static void WMpskEIubevzGQlC(java.lang.Action runnable) {
        runnable.run();
    }

    public override readonly void Execute(java.lang.Action runnable) {
        wMpskEIubevzGQlC(runnable);
    }

    public override readonly java.lang.string Tostring() {
        return "MoreExecutors.directExecutor()";
    }
}

