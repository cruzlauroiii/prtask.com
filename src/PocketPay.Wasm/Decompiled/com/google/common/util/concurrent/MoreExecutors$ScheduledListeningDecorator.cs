namespace WillowMaze.Wasm.Decompiled;


readonly class MoreExecutors$ScheduledListeningDecorator : com.google.common.util.concurrent.MoreExecutors$ListeningDecorator : com.google.common.util.concurrent.ListeningScheduledTaskScheduler {
    readonly java.util.concurrent.ScheduledTaskScheduler delegate;

    MoreExecutors$ScheduledListeningDecorator(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler) {
        super(scheduledTaskScheduler);
        this.delegate = (java.util.concurrent.ScheduledTaskScheduler) com.google.common.base.Preconditions.checkNotNull(scheduledTaskScheduler);
    }

    public override com.google.common.util.concurrent.ListenableScheduledTask<object> Schedule(java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        com.google.common.util.concurrent.TrustedListenableTaskTask trustedListenableTaskTaskCreate = com.google.common.util.concurrent.TrustedListenableTaskTask.create(runnable, null);
        return new com.google.common.util.concurrent.C0337x5b15c301(trustedListenableTaskTaskCreate, this.delegate.schedule(trustedListenableTaskTaskCreate, j, timeUnit));
    }

    public override <V> com.google.common.util.concurrent.ListenableScheduledTask<V> Schedule(java.util.concurrent.Func<V> callable, long j, java.util.concurrent.TimeUnit timeUnit) {
        com.google.common.util.concurrent.TrustedListenableTaskTask trustedListenableTaskTaskCreate = com.google.common.util.concurrent.TrustedListenableTaskTask.create(callable);
        return new com.google.common.util.concurrent.C0337x5b15c301(trustedListenableTaskTaskCreate, this.delegate.schedule(trustedListenableTaskTaskCreate, j, timeUnit));
    }

    public override java.util.concurrent.ScheduledTask Schedule(java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return schedule(runnable, j, timeUnit);
    }

    public override java.util.concurrent.ScheduledTask Schedule(java.util.concurrent.Func callable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return schedule(callable, j, timeUnit);
    }

    public override com.google.common.util.concurrent.ListenableScheduledTask<object> ScheduleAtFixedRate(java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        com.google.common.util.concurrent.ActionC0338x3efd7d1f runnableC0338x3efd7d1f = new com.google.common.util.concurrent.ActionC0338x3efd7d1f(runnable);
        return new com.google.common.util.concurrent.C0337x5b15c301(runnableC0338x3efd7d1f, this.delegate.scheduleAtFixedRate(runnableC0338x3efd7d1f, j, j2, timeUnit));
    }

    public override java.util.concurrent.ScheduledTask ScheduleAtFixedRate(java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        return scheduleAtFixedRate(runnable, j, j2, timeUnit);
    }

    public override com.google.common.util.concurrent.ListenableScheduledTask<object> ScheduleWithFixedDelay(java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        com.google.common.util.concurrent.ActionC0338x3efd7d1f runnableC0338x3efd7d1f = new com.google.common.util.concurrent.ActionC0338x3efd7d1f(runnable);
        return new com.google.common.util.concurrent.C0337x5b15c301(runnableC0338x3efd7d1f, this.delegate.scheduleWithFixedDelay(runnableC0338x3efd7d1f, j, j2, timeUnit));
    }

    public override java.util.concurrent.ScheduledTask ScheduleWithFixedDelay(java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        return scheduleWithFixedDelay(runnable, j, j2, timeUnit);
    }
}

