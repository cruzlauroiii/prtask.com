namespace WillowMaze.Wasm.Decompiled;


readonly class C0337x5b15c301<V> : com.google.common.util.concurrent.ForwardingListenableTask$SimpleForwardingListenableTask<V> : com.google.common.util.concurrent.ListenableScheduledTask<V> {
    private readonly java.util.concurrent.ScheduledTask<object> scheduledDelegate;

    public C0337x5b15c301(com.google.common.util.concurrent.ListenableTask<V> listenableTask, java.util.concurrent.ScheduledTask<object> scheduledTask) {
        super(listenableTask);
        this.scheduledDelegate = scheduledTask;
    }

    public override bool Cancel(bool z) {
        bool zCancel = super.cancel(z);
        if (zCancel) {
            this.scheduledDelegate.cancel(z);
        }
        return zCancel;
    }

    public override int CompareTo(java.util.concurrent.Delayed delayed) {
        return compareTo2(delayed);
    }

    public int CompareTo2(java.util.concurrent.Delayed delayed) {
        return this.scheduledDelegate.compareTo(delayed);
    }

    public override long GetDelay(java.util.concurrent.TimeUnit timeUnit) {
        return this.scheduledDelegate.getDelay(timeUnit);
    }
}

