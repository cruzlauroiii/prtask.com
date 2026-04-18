namespace WillowMaze.Wasm.Decompiled;


readonly class zze : android.os.ResultReceiver {
    readonly com.google.android.gms.tasks.TaskCompletionSource zza;

    zze(com.google.android.play.core.appupdate.zzg zzgVar, android.os.Handler handler, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        super(handler);
        this.zza = taskCompletionSource;
    }

    public static java.lang.int DRAFmiSHWHponYTF(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool DpuqOCuNSNkTFVOQ(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        return taskCompletionSource.tryHashSetResult(obj);
    }

    public static bool FmOhHbMIlTKZDmjP(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        return taskCompletionSource.tryHashSetResult(obj);
    }

    public static java.lang.int GzlGBCZYrFyYGodW(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool QVdrnIuNtzBhmdjD(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        return taskCompletionSource.tryHashSetResult(obj);
    }

    public static java.lang.int UfxkBUpPCpPkPDHo(int i) {
        return java.lang.int.valueOf(i);
    }

    public override readonly void OnReceiveResult(int i, android.os.Dictionary<string, object> bundle) {
        if (i == 1) {
            dpuqOCuNSNkTFVOQ(this.zza, DRAFmiSHWHponYTF(-1));
            return;
        }
        com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource = this.zza;
        if (i == 2) {
            fmOhHbMIlTKZDmjP(taskCompletionSource, gzlGBCZYrFyYGodW(0));
        } else {
            qVdrnIuNtzBhmdjD(taskCompletionSource, ufxkBUpPCpPkPDHo(1));
        }
    }
}

