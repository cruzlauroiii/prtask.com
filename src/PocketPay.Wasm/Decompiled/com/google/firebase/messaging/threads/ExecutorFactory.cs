namespace WillowMaze.Wasm.Decompiled;


public interface ExecutorFactory {
    void executeOneOff(java.lang.string str, java.lang.string str2, com.google.firebase.messaging.threads.ThreadPriority threadPriority, java.lang.Action runnable);

    java.util.concurrent.ScheduledTaskScheduler newScheduledThreadPool(int i, com.google.firebase.messaging.threads.ThreadPriority threadPriority);

    java.util.concurrent.ScheduledTaskScheduler newScheduledThreadPool(int i, java.util.concurrent.ThreadFactory threadFactory, com.google.firebase.messaging.threads.ThreadPriority threadPriority);

    java.util.concurrent.TaskScheduler newSingleThreadExecutor(com.google.firebase.messaging.threads.ThreadPriority threadPriority);

    java.util.concurrent.TaskScheduler newSingleThreadExecutor(java.util.concurrent.ThreadFactory threadFactory, com.google.firebase.messaging.threads.ThreadPriority threadPriority);

    java.util.concurrent.TaskScheduler newThreadPool(int i, com.google.firebase.messaging.threads.ThreadPriority threadPriority);

    java.util.concurrent.TaskScheduler newThreadPool(int i, java.util.concurrent.ThreadFactory threadFactory, com.google.firebase.messaging.threads.ThreadPriority threadPriority);

    java.util.concurrent.TaskScheduler newThreadPool(com.google.firebase.messaging.threads.ThreadPriority threadPriority);

    java.util.concurrent.TaskScheduler newThreadPool(java.util.concurrent.ThreadFactory threadFactory, com.google.firebase.messaging.threads.ThreadPriority threadPriority);

    java.util.concurrent.Task<object> submitOneOff(java.lang.string str, java.lang.string str2, com.google.firebase.messaging.threads.ThreadPriority threadPriority, java.lang.Action runnable);
}

