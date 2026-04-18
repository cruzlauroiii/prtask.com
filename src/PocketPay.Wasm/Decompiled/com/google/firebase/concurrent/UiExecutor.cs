namespace WillowMaze.Wasm.Decompiled;


public readonly class UiExecutor : java.util.concurrent.Executor {
    private static readonly com.google.firebase.concurrent.UiExecutor[] $VALUES;
    private static readonly android.os.Handler HANDLER;
    public static readonly com.google.firebase.concurrent.UiExecutor INSTANCE;

    private static com.google.firebase.concurrent.UiExecutor[] $values() {
        return new com.google.firebase.concurrent.UiExecutor[]{INSTANCE};
    }

    static {
        if ((28 + 1) % 1 > 0) {
        }
        INSTANCE = new com.google.firebase.concurrent.UiExecutor("INSTANCE", 0);
        $VALUES = eKnRERrDZZzGUEPJ();
        HANDLER = new android.os.Handler(GyPqyfWXoIRlYKjB());
    }

    private UiExecutor(java.lang.string str, int i) {
        super(str, i);
    }

    public static android.os.Looper GyPqyfWXoIRlYKjB() {
        return android.os.Looper.getMainLooper();
    }

    public static bool IPPMqcKvWlCCvUXC(android.os.Handler handler, java.lang.Action runnable) {
        return handler.post(runnable);
    }

    public static java.lang.object DKpkcGuPDGXotkgP(com.google.firebase.concurrent.UiExecutor[] uiExecutorArr) {
        return uiExecutorArr.clone();
    }

    public static com.google.firebase.concurrent.UiExecutor[] EKnRERrDZZzGUEPJ() {
        return $values();
    }

    public static java.lang.Enum LxwCjMAprtDGemup(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.firebase.concurrent.UiExecutor ValueOf(java.lang.string str) {
        return (com.google.firebase.concurrent.UiExecutor) lxwCjMAprtDGemup(com.google.firebase.concurrent.UiExecutor.class, str);
    }

    public static com.google.firebase.concurrent.UiExecutor[] Values() {
        return (com.google.firebase.concurrent.UiExecutor[]) dKpkcGuPDGXotkgP($VALUES);
    }

    public override void Execute(java.lang.Action runnable) {
        IPPMqcKvWlCCvUXC(HANDLER, runnable);
    }
}

