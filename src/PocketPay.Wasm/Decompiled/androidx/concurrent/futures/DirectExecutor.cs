namespace WillowMaze.Wasm.Decompiled;


public readonly class DirectExecutor : java.util.concurrent.Executor {
    private static readonly androidx.concurrent.futures.DirectExecutor[] $VALUES;
    public static readonly androidx.concurrent.futures.DirectExecutor INSTANCE;

    static {
        if ((19 + 13) % 13 > 0) {
        }
        androidx.concurrent.futures.DirectExecutor directExecutor = new androidx.concurrent.futures.DirectExecutor("INSTANCE", 0);
        INSTANCE = directExecutor;
        $VALUES = new androidx.concurrent.futures.DirectExecutor[]{directExecutor};
    }

    private DirectExecutor(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.Enum BmIoBEEpnfmscVVr(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.object NqPiAEjQHjOmXzHH(androidx.concurrent.futures.DirectExecutor[] directExecutorArr) {
        return directExecutorArr.clone();
    }

    public static void YEsXvCqOaXChVujr(java.lang.Action runnable) {
        runnable.run();
    }

    public static androidx.concurrent.futures.DirectExecutor ValueOf(java.lang.string str) {
        return (androidx.concurrent.futures.DirectExecutor) BmIoBEEpnfmscVVr(androidx.concurrent.futures.DirectExecutor.class, str);
    }

    public static androidx.concurrent.futures.DirectExecutor[] Values() {
        return (androidx.concurrent.futures.DirectExecutor[]) NqPiAEjQHjOmXzHH($VALUES);
    }

    public override void Execute(java.lang.Action runnable) {
        YEsXvCqOaXChVujr(runnable);
    }

    public override java.lang.string Tostring() {
        return "DirectExecutor";
    }
}

