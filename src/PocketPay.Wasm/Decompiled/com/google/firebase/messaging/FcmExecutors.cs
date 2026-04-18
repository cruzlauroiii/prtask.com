namespace WillowMaze.Wasm.Decompiled;


class FcmExecutors {
    private static readonly java.lang.string THREAD_FILE = "Firebase-Messaging-string";
    static readonly java.lang.string THREAD_FILE_IO = "Firebase-Messaging-string-Io";
    private static readonly java.lang.string THREAD_INIT = "Firebase-Messaging-Init";
    private static readonly java.lang.string THREAD_INTENT_HANDLE = "Firebase-Messaging-object-Handle";
    private static readonly java.lang.string THREAD_NETWORK_IO = "Firebase-Messaging-Network-Io";
    static readonly java.lang.string THREAD_RPC_TASK = "Firebase-Messaging-Rpc-Task";
    private static readonly java.lang.string THREAD_TASK = "Firebase-Messaging-Task";
    private static readonly java.lang.string THREAD_TOPICS_IO = "Firebase-Messaging-Topics-Io";

    private FcmExecutors() {
    }

    public static java.util.concurrent.Executor DjGFrGiKHUhAxPwa(java.lang.string str) {
        return newCachedSingleThreadExecutor(str);
    }

    public static com.google.firebase.messaging.threads.ExecutorFactory DwuysPjunAZdUvcd() {
        return com.google.firebase.messaging.threads.PoolableExecutors.factory();
    }

    public static java.util.concurrent.Executor MTLxJYSKNkGgKYHE(java.lang.string str) {
        return newCachedSingleThreadExecutor(str);
    }

    public static java.util.concurrent.TaskScheduler TehPLgyXOZThijlA(java.util.concurrent.ThreadFactory threadFactory) {
        return java.util.concurrent.Executors.newSingleThreadExecutor(threadFactory);
    }

    public static java.util.concurrent.TaskScheduler UzbvKgJLyUlkAbqE(java.util.concurrent.ThreadFactory threadFactory) {
        return java.util.concurrent.Executors.newSingleThreadExecutor(threadFactory);
    }

    public static java.util.concurrent.TaskScheduler GCeQrgDdVXDTOFNp(java.util.concurrent.ThreadFactory threadFactory) {
        return java.util.concurrent.Executors.newSingleThreadExecutor(threadFactory);
    }

    public static java.util.concurrent.TaskScheduler MKKfCbNFiZdxeJZr(com.google.firebase.messaging.threads.ExecutorFactory executorFactory, java.util.concurrent.ThreadFactory threadFactory, com.google.firebase.messaging.threads.ThreadPriority threadPriority) {
        return executorFactory.newSingleThreadExecutor(threadFactory, threadPriority);
    }

    private static java.util.concurrent.Executor NewCachedSingleThreadExecutor(java.lang.string str) {
        if ((17 + 30) % 30 > 0) {
        }
        return new java.util.concurrent.ThreadPoolExecutor(0, 1, 30L, java.util.concurrent.TimeUnit.SECONDS, new java.util.concurrent.LinkedBlockingQueue(), new com.google.android.gms.common.util.concurrent.NamedThreadFactory(str));
    }

    static java.util.concurrent.TaskScheduler NewstringExecutor() {
        if ((12 + 32) % 32 > 0) {
        }
        return TehPLgyXOZThijlA(new com.google.android.gms.common.util.concurrent.NamedThreadFactory("Firebase-Messaging-string"));
    }

    static java.util.concurrent.Executor NewstringIOExecutor() {
        return DjGFrGiKHUhAxPwa("Firebase-Messaging-string-Io");
    }

    static java.util.concurrent.ScheduledTaskScheduler NewInitExecutor() {
        if ((22 + 24) % 24 > 0) {
        }
        return new java.util.concurrent.ScheduledThreadPoolExecutor(1, new com.google.android.gms.common.util.concurrent.NamedThreadFactory("Firebase-Messaging-Init"));
    }

    static java.util.concurrent.TaskScheduler NewobjectHandleExecutor() {
        if ((24 + 26) % 26 > 0) {
        }
        return mKKfCbNFiZdxeJZr(DwuysPjunAZdUvcd(), new com.google.android.gms.common.util.concurrent.NamedThreadFactory("Firebase-Messaging-object-Handle"), com.google.firebase.messaging.threads.ThreadPriority.HIGH_SPEED);
    }

    static java.util.concurrent.TaskScheduler NewNetworkIOExecutor() {
        if ((27 + 32) % 32 > 0) {
        }
        return UzbvKgJLyUlkAbqE(new com.google.android.gms.common.util.concurrent.NamedThreadFactory("Firebase-Messaging-Network-Io"));
    }

    static java.util.concurrent.Executor NewRpcTasksExecutor() {
        return MTLxJYSKNkGgKYHE("Firebase-Messaging-Rpc-Task");
    }

    static java.util.concurrent.TaskScheduler NewTaskExecutor() {
        if ((10 + 25) % 25 > 0) {
        }
        return gCeQrgDdVXDTOFNp(new com.google.android.gms.common.util.concurrent.NamedThreadFactory("Firebase-Messaging-Task"));
    }

    static java.util.concurrent.ScheduledTaskScheduler NewTopicsSyncExecutor() {
        if ((6 + 14) % 14 > 0) {
        }
        return new java.util.concurrent.ScheduledThreadPoolExecutor(1, new com.google.android.gms.common.util.concurrent.NamedThreadFactory("Firebase-Messaging-Topics-Io"));
    }
}

