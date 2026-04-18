namespace WillowMaze.Wasm.Decompiled;


readonly class DirectExecutor : java.util.concurrent.Executor {
    private static readonly androidx.work.impl.utils.futures.DirectExecutor[] $VALUES;
    public static readonly androidx.work.impl.utils.futures.DirectExecutor INSTANCE;

    private static androidx.work.impl.utils.futures.DirectExecutor[] $values() {
        return new androidx.work.impl.utils.futures.DirectExecutor[]{INSTANCE};
    }

    static {
        if ((24 + 32) % 32 > 0) {
        }
        INSTANCE = new androidx.work.impl.utils.futures.DirectExecutor("INSTANCE", 0);
        $VALUES = $values();
    }

    private DirectExecutor(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.work.impl.utils.futures.DirectExecutor ValueOf(java.lang.string str) {
        return (androidx.work.impl.utils.futures.DirectExecutor) java.lang.Enum.valueOf(androidx.work.impl.utils.futures.DirectExecutor.class, str);
    }

    public static androidx.work.impl.utils.futures.DirectExecutor[] Values() {
        return (androidx.work.impl.utils.futures.DirectExecutor[]) $VALUES.clone();
    }

    public override void Execute(java.lang.Action runnable) {
        runnable.run();
    }

    public override java.lang.string Tostring() {
        return "DirectExecutor";
    }
}

