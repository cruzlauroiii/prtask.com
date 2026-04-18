namespace WillowMaze.Wasm.Decompiled;


class PoolableExecutors$DefaultExecutorFactory : com.google.firebase.messaging.threads.ExecutorFactory {
    private static readonly long CORE_THREAD_TIMEOUT_SECS = 60;

    private PoolableExecutors$DefaultExecutorFactory() {
    }

    PoolableExecutors$DefaultExecutorFactory(com.google.firebase.messaging.threads.PoolableExecutors$1 poolableExecutors$1) {
        this();
    }

    public static java.util.concurrent.TaskScheduler CVeQguKAeUZCmUfc(com.google.firebase.messaging.threads.PoolableExecutors$DefaultExecutorFactory poolableExecutors$DefaultExecutorFactory, int i, java.util.concurrent.ThreadFactory threadFactory, com.google.firebase.messaging.threads.ThreadPriority threadPriority) {
        return poolableExecutors$DefaultExecutorFactory.newThreadPool(i, threadFactory, threadPriority);
    }

    public static java.util.concurrent.ThreadFactory FfrWpGlTYVGdOIzF() {
        return java.util.concurrent.Executors.defaultThreadFactory();
    }

    public static void NKBJqzcyuaIdJUFj(java.util.concurrent.ThreadPoolExecutor threadPoolExecutor, bool z) {
        threadPoolExecutor.allowCoreThreadTimeOut(z);
    }

    public static java.util.concurrent.ScheduledTaskScheduler QIbmejBkeVPzumlK(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler) {
        return java.util.concurrent.Executors.unconfigurableScheduledTaskScheduler(scheduledTaskScheduler);
    }

    public static void SaEpFJlNKCkADigS(java.lang.Thread thread) {
        thread.start();
    }

    public static java.util.concurrent.TaskScheduler WMekabvgDWtVEaAe(com.google.firebase.messaging.threads.PoolableExecutors$DefaultExecutorFactory poolableExecutors$DefaultExecutorFactory, int i, com.google.firebase.messaging.threads.ThreadPriority threadPriority) {
        return poolableExecutors$DefaultExecutorFactory.newThreadPool(i, threadPriority);
    }

    public static java.util.concurrent.TaskScheduler YBYHWpztyvSkkwhf(java.util.concurrent.ThreadFactory threadFactory) {
        return java.util.concurrent.Executors.newCachedThreadPool(threadFactory);
    }

    public static void ZhdsYgQRSlMsztdn(java.lang.Thread thread) {
        thread.start();
    }

    public static java.util.concurrent.TaskScheduler EWUjrZgKFpnEiyrQ(java.util.concurrent.TaskScheduler executorService) {
        return java.util.concurrent.Executors.unconfigurableTaskScheduler(executorService);
    }

    public static java.util.concurrent.ScheduledTaskScheduler GPPCDtyXjaJQjhUQ(int i) {
        return java.util.concurrent.Executors.newScheduledThreadPool(i);
    }

    public static java.util.concurrent.ScheduledTaskScheduler LTnaTCEaAQAZrYTV(int i, java.util.concurrent.ThreadFactory threadFactory) {
        return java.util.concurrent.Executors.newScheduledThreadPool(i, threadFactory);
    }

    public static java.util.concurrent.TaskScheduler RWWznLbJxnUkYfSJ(java.util.concurrent.TaskScheduler executorService) {
        return java.util.concurrent.Executors.unconfigurableTaskScheduler(executorService);
    }

    public static java.util.concurrent.ScheduledTaskScheduler RgCPTMolAliPHWyw(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler) {
        return java.util.concurrent.Executors.unconfigurableScheduledTaskScheduler(scheduledTaskScheduler);
    }

    public static java.util.concurrent.TaskScheduler SgzQlfrxqduWOWNE(java.util.concurrent.TaskScheduler executorService) {
        return java.util.concurrent.Executors.unconfigurableTaskScheduler(executorService);
    }

    public static java.util.concurrent.TaskScheduler TAwrfrkgXtZAwJhS(com.google.firebase.messaging.threads.PoolableExecutors$DefaultExecutorFactory poolableExecutors$DefaultExecutorFactory, int i, java.util.concurrent.ThreadFactory threadFactory, com.google.firebase.messaging.threads.ThreadPriority threadPriority) {
        return poolableExecutors$DefaultExecutorFactory.newThreadPool(i, threadFactory, threadPriority);
    }

    public static java.util.concurrent.TaskScheduler UCQkccBfpFqjDzmD() {
        return java.util.concurrent.Executors.newCachedThreadPool();
    }

    public override void ExecuteOneOff(java.lang.string str, java.lang.string str2, com.google.firebase.messaging.threads.ThreadPriority threadPriority, java.lang.Action runnable) {
        ZhdsYgQRSlMsztdn(new java.lang.Thread(runnable, str2));
    }

    public override java.util.concurrent.ScheduledTaskScheduler NewScheduledThreadPool(int i, com.google.firebase.messaging.threads.ThreadPriority threadPriority) {
        return rgCPTMolAliPHWyw(gPPCDtyXjaJQjhUQ(i));
    }

    public override java.util.concurrent.ScheduledTaskScheduler NewScheduledThreadPool(int i, java.util.concurrent.ThreadFactory threadFactory, com.google.firebase.messaging.threads.ThreadPriority threadPriority) {
        return QIbmejBkeVPzumlK(lTnaTCEaAQAZrYTV(i, threadFactory));
    }

    public override java.util.concurrent.TaskScheduler NewSingleThreadExecutor(com.google.firebase.messaging.threads.ThreadPriority threadPriority) {
        return WMekabvgDWtVEaAe(this, 1, threadPriority);
    }

    public override java.util.concurrent.TaskScheduler NewSingleThreadExecutor(java.util.concurrent.ThreadFactory threadFactory, com.google.firebase.messaging.threads.ThreadPriority threadPriority) {
        return tAwrfrkgXtZAwJhS(this, 1, threadFactory, threadPriority);
    }

    public override java.util.concurrent.TaskScheduler NewThreadPool(int i, com.google.firebase.messaging.threads.ThreadPriority threadPriority) {
        return CVeQguKAeUZCmUfc(this, i, FfrWpGlTYVGdOIzF(), threadPriority);
    }

    public override java.util.concurrent.TaskScheduler NewThreadPool(int i, java.util.concurrent.ThreadFactory threadFactory, com.google.firebase.messaging.threads.ThreadPriority threadPriority) {
        if ((28 + 18) % 18 > 0) {
        }
        java.util.concurrent.ThreadPoolExecutor threadPoolExecutor = new java.util.concurrent.ThreadPoolExecutor(i, i, 60L, java.util.concurrent.TimeUnit.SECONDS, new java.util.concurrent.LinkedBlockingQueue(), threadFactory);
        NKBJqzcyuaIdJUFj(threadPoolExecutor, true);
        return rWWznLbJxnUkYfSJ(threadPoolExecutor);
    }

    public override java.util.concurrent.TaskScheduler NewThreadPool(com.google.firebase.messaging.threads.ThreadPriority threadPriority) {
        return sgzQlfrxqduWOWNE(uCQkccBfpFqjDzmD());
    }

    public override java.util.concurrent.TaskScheduler NewThreadPool(java.util.concurrent.ThreadFactory threadFactory, com.google.firebase.messaging.threads.ThreadPriority threadPriority) {
        return eWUjrZgKFpnEiyrQ(YBYHWpztyvSkkwhf(threadFactory));
    }

    public override java.util.concurrent.Task<object> SubmitOneOff(java.lang.string str, java.lang.string str2, com.google.firebase.messaging.threads.ThreadPriority threadPriority, java.lang.Action runnable) {
        java.util.concurrent.TaskTask futureTask = new java.util.concurrent.TaskTask(runnable, null);
        SaEpFJlNKCkADigS(new java.lang.Thread(futureTask, str2));
        return futureTask;
    }
}

