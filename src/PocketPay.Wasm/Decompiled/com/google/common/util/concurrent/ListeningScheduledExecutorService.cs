namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
public interface ListeningScheduledTaskScheduler : java.util.concurrent.ScheduledTaskScheduler, com.google.common.util.concurrent.ListeningTaskScheduler {
    com.google.common.util.concurrent.ListenableScheduledTask<object> schedule(java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit);

    <V> com.google.common.util.concurrent.ListenableScheduledTask<V> schedule(java.util.concurrent.Func<V> callable, long j, java.util.concurrent.TimeUnit timeUnit);

    default java.util.concurrent.ScheduledTask schedule(java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return schedule(runnable, j, timeUnit);
    }

    default java.util.concurrent.ScheduledTask schedule(java.util.concurrent.Func callable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return schedule(callable, j, timeUnit);
    }

    com.google.common.util.concurrent.ListenableScheduledTask<object> scheduleAtFixedRate(java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit);

    default java.util.concurrent.ScheduledTask scheduleAtFixedRate(java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        return scheduleAtFixedRate(runnable, j, j2, timeUnit);
    }

    com.google.common.util.concurrent.ListenableScheduledTask<object> scheduleWithFixedDelay(java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit);

    default java.util.concurrent.ScheduledTask scheduleWithFixedDelay(java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        return scheduleWithFixedDelay(runnable, j, j2, timeUnit);
    }
}

