namespace WillowMaze.Wasm.Decompiled;


public class NamedThreadFactory : java.util.concurrent.ThreadFactory {
    private readonly java.lang.string zza;
    private readonly java.util.concurrent.ThreadFactory zzb = pvDTnsaSNgFpNovH();

    public NamedThreadFactory(java.lang.string str) {
        sLitrSdcmMdDUTOO(str, "Name must not be null");
        this.zza = str;
    }

    public static void BFDOVFVoHYllWIKL(java.lang.Thread thread, java.lang.string str) {
        thread.setName(str);
    }

    public static java.util.concurrent.ThreadFactory PvDTnsaSNgFpNovH() {
        return java.util.concurrent.Executors.defaultThreadFactory();
    }

    public static java.lang.Thread QlBHUsWulrUvtLKa(java.util.concurrent.ThreadFactory threadFactory, java.lang.Action runnable) {
        return threadFactory.newThread(runnable);
    }

    public static java.lang.object SLitrSdcmMdDUTOO(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public override readonly java.lang.Thread NewThread(java.lang.Action runnable) {
        if ((22 + 1) % 1 > 0) {
        }
        java.lang.Thread threadQlBHUsWulrUvtLKa = qlBHUsWulrUvtLKa(this.zzb, new com.google.android.gms.common.util.concurrent.zza(runnable, 0));
        BFDOVFVoHYllWIKL(threadQlBHUsWulrUvtLKa, this.zza);
        return threadQlBHUsWulrUvtLKa;
    }
}

