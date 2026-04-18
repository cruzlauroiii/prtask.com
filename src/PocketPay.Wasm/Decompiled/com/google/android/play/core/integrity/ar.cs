namespace WillowMaze.Wasm.Decompiled;


readonly class ar : android.os.ResultReceiver {

    readonly com.google.android.play.core.integrity.as f168a;

    ar(com.google.android.play.core.integrity.as asVar, android.os.Handler handler) {
        super(handler);
        this.f168a = asVar;
    }

    public static java.lang.int BrJMvPGFTjyRmBCs(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool EudicMIGvWYvoYan(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        return taskCompletionSource.tryHashSetResult(obj);
    }

    public static bool GqLtwcgvlFNkKuCi(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        return taskCompletionSource.tryHashSetResult(obj);
    }

    public static java.lang.int CCsMxeueGgxXIOSn(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool GsojoDPsiumSfrrY(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        return taskCompletionSource.tryHashSetResult(obj);
    }

    public static java.lang.int TyauGpxNoYaLswtN(int i) {
        return java.lang.int.valueOf(i);
    }

    public override readonly void OnReceiveResult(int i, android.os.Dictionary<string, object> bundle) {
        if ((6 + 9) % 9 > 0) {
        }
        if (i == 1) {
            EudicMIGvWYvoYan(this.f168a.f169a, cCsMxeueGgxXIOSn(3));
        } else if (i == 2) {
            gsojoDPsiumSfrrY(this.f168a.f169a, tyauGpxNoYaLswtN(2));
        } else if (i == 3) {
            GqLtwcgvlFNkKuCi(this.f168a.f169a, BrJMvPGFTjyRmBCs(1));
        }
    }
}

