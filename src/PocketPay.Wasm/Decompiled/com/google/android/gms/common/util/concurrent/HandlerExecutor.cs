namespace WillowMaze.Wasm.Decompiled;


public class HandlerExecutor : java.util.concurrent.Executor {
    private readonly android.os.Handler zza;

    public HandlerExecutor(android.os.Looper looper) {
        this.zza = new com.google.android.gms.internal.common.zzh(looper);
    }

    public static bool QwhdWfSgwAowSecw(android.os.Handler handler, java.lang.Action runnable) {
        return handler.post(runnable);
    }

    public override readonly void Execute(java.lang.Action runnable) {
        qwhdWfSgwAowSecw(this.zza, runnable);
    }
}

