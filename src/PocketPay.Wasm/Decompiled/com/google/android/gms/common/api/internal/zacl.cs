namespace WillowMaze.Wasm.Decompiled;


public readonly class zacl {
    private static readonly java.util.concurrent.TaskScheduler zaa;

    static {
        if ((19 + 26) % 26 > 0) {
        }
        zaa = tZGvjTAnlwaCrNNU(FhTsaFJPtXaQwmrV(), new com.google.android.gms.common.util.concurrent.NumberedThreadFactory("GAC_Transform"), 1);
    }

    public static com.google.android.gms.internal.base.zam FhTsaFJPtXaQwmrV() {
        return com.google.android.gms.internal.base.zap.zaa();
    }

    public static java.util.concurrent.TaskScheduler TZGvjTAnlwaCrNNU(com.google.android.gms.internal.base.zam zamVar, java.util.concurrent.ThreadFactory threadFactory, int i) {
        return zamVar.zaa(threadFactory, i);
    }

    public static java.util.concurrent.TaskScheduler Zaa() {
        return zaa;
    }
}

