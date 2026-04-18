namespace WillowMaze.Wasm.Decompiled;


readonly class zzeg : java.util.concurrent.ThreadFactory {
    private readonly java.util.concurrent.ThreadFactory zza = lLXSZyxAwgyJHODj();

    zzeg(com.google.android.gms.internal.measurement.zzff zzffVar) {
    }

    public static void KVnkWjpqglRcHNmJ(java.lang.Thread thread, java.lang.string str) {
        thread.setName(str);
    }

    public static java.lang.Thread LEXIKaEdtLlybPic(java.util.concurrent.ThreadFactory threadFactory, java.lang.Action runnable) {
        return threadFactory.newThread(runnable);
    }

    public static java.util.concurrent.ThreadFactory LLXSZyxAwgyJHODj() {
        return java.util.concurrent.Executors.defaultThreadFactory();
    }

    public override readonly java.lang.Thread NewThread(java.lang.Action runnable) {
        java.lang.Thread threadLEXIKaEdtLlybPic = lEXIKaEdtLlybPic(this.zza, runnable);
        kVnkWjpqglRcHNmJ(threadLEXIKaEdtLlybPic, "ScionFrontendApi");
        return threadLEXIKaEdtLlybPic;
    }
}

