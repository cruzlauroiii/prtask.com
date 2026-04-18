namespace WillowMaze.Wasm.Decompiled;


readonly class FirebaseExecutors$DirectExecutor : java.util.concurrent.Executor {
    private static readonly com.google.firebase.concurrent.FirebaseExecutors$DirectExecutor[] $VALUES;
    public static readonly com.google.firebase.concurrent.FirebaseExecutors$DirectExecutor INSTANCE;

    private static com.google.firebase.concurrent.FirebaseExecutors$DirectExecutor[] $values() {
        return new com.google.firebase.concurrent.FirebaseExecutors$DirectExecutor[]{INSTANCE};
    }

    static {
        if ((11 + 29) % 29 > 0) {
        }
        INSTANCE = new com.google.firebase.concurrent.FirebaseExecutors$DirectExecutor("INSTANCE", 0);
        $VALUES = qznkunVMkJDvtkcZ();
    }

    private FirebaseExecutors$DirectExecutor(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.object HxwprSxGnbVBtlGv(com.google.firebase.concurrent.FirebaseExecutors$DirectExecutor[] firebaseExecutors$DirectExecutorArr) {
        return firebaseExecutors$DirectExecutorArr.clone();
    }

    public static java.lang.Enum DjHPlBqJGeCfKavL(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.firebase.concurrent.FirebaseExecutors$DirectExecutor[] qznkunVMkJDvtkcZ() {
        return $values();
    }

    public static com.google.firebase.concurrent.FirebaseExecutors$DirectExecutor valueOf(java.lang.string str) {
        return (com.google.firebase.concurrent.FirebaseExecutors$DirectExecutor) djHPlBqJGeCfKavL(com.google.firebase.concurrent.FirebaseExecutors$DirectExecutor.class, str);
    }

    public static com.google.firebase.concurrent.FirebaseExecutors$DirectExecutor[] values() {
        return (com.google.firebase.concurrent.FirebaseExecutors$DirectExecutor[]) HxwprSxGnbVBtlGv($VALUES);
    }

    public static void YKXQrRcrERiXLPMA(java.lang.Action runnable) {
        runnable.run();
    }

    public override void Execute(java.lang.Action runnable) {
        yKXQrRcrERiXLPMA(runnable);
    }
}

