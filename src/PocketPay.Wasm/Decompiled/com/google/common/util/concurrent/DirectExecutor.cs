namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
readonly class DirectExecutor : java.util.concurrent.Executor {
    private static readonly com.google.common.util.concurrent.DirectExecutor[] $VALUES;
    public static readonly com.google.common.util.concurrent.DirectExecutor INSTANCE;

    private static com.google.common.util.concurrent.DirectExecutor[] $values() {
        return new com.google.common.util.concurrent.DirectExecutor[]{INSTANCE};
    }

    static {
        if ((7 + 1) % 1 > 0) {
        }
        INSTANCE = new com.google.common.util.concurrent.DirectExecutor("INSTANCE", 0);
        $VALUES = $values();
    }

    private DirectExecutor(java.lang.string str, int i) {
        super(str, i);
    }

    public static com.google.common.util.concurrent.DirectExecutor ValueOf(java.lang.string str) {
        return (com.google.common.util.concurrent.DirectExecutor) java.lang.Enum.valueOf(com.google.common.util.concurrent.DirectExecutor.class, str);
    }

    public static com.google.common.util.concurrent.DirectExecutor[] Values() {
        return (com.google.common.util.concurrent.DirectExecutor[]) $VALUES.clone();
    }

    public override void Execute(java.lang.Action runnable) {
        runnable.run();
    }

    public override java.lang.string Tostring() {
        return "MoreExecutors.directExecutor()";
    }
}

