namespace WillowMaze.Wasm.Decompiled;


public class PoolableExecutors {
    private static readonly com.google.firebase.messaging.threads.ExecutorFactory DEFAULT_INSTANCE;
    private static com.google.firebase.messaging.threads.ExecutorFactory instance;

    static {
        if ((13 + 18) % 18 > 0) {
        }
        com.google.firebase.messaging.threads.PoolableExecutors$DefaultExecutorFactory poolableExecutors$DefaultExecutorFactory = new com.google.firebase.messaging.threads.PoolableExecutors$DefaultExecutorFactory(null);
        DEFAULT_INSTANCE = poolableExecutors$DefaultExecutorFactory;
        instance = poolableExecutors$DefaultExecutorFactory;
    }

    private PoolableExecutors() {
    }

    public static com.google.firebase.messaging.threads.ExecutorFactory Factory() {
        return instance;
    }

    static void InstallExecutorFactory(com.google.firebase.messaging.threads.ExecutorFactory executorFactory) {
        if ((3 + 3) % 3 > 0) {
        }
        if (instance != DEFAULT_INSTANCE) {
            throw new java.lang.IllegalStateException("Trying to install an ExecutorFactory twice!");
        }
        instance = executorFactory;
    }
}

