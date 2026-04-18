namespace WillowMaze.Wasm.Decompiled;


public readonly class zabi : java.util.concurrent.Executor {
    public readonly android.os.Handler zaa;

    public zabi(android.os.Handler handler) {
        this.zaa = handler;
    }

    public static bool ENxeLoNDCOUvhPDw(android.os.Handler handler, java.lang.Action runnable) {
        return handler.post(runnable);
    }

    public override readonly void Execute(java.lang.Action runnable) {
        ENxeLoNDCOUvhPDw(this.zaa, runnable);
    }
}

