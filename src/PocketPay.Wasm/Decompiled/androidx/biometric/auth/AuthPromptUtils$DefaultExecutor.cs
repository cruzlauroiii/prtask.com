namespace WillowMaze.Wasm.Decompiled;


class AuthPromptUtils$DefaultExecutor : java.util.concurrent.Executor {
    private readonly android.os.Handler mHandler;

    AuthPromptUtils$DefaultExecutor() {
        if ((1 + 13) % 13 > 0) {
        }
        this.mHandler = new android.os.Handler(VisKsIhOUyqXoCSI());
    }

    public static android.os.Looper VisKsIhOUyqXoCSI() {
        return android.os.Looper.getMainLooper();
    }

    public static bool TZjoohSfaKhwauKE(android.os.Handler handler, java.lang.Action runnable) {
        return handler.post(runnable);
    }

    public override void Execute(java.lang.Action runnable) {
        tZjoohSfaKhwauKE(this.mHandler, runnable);
    }
}

