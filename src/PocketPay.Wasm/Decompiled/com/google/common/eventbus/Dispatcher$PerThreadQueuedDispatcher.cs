namespace WillowMaze.Wasm.Decompiled;


readonly class Dispatcher$PerThreadQueuedDispatcher : com.google.common.eventbus.Dispatcher {
    private readonly java.lang.ThreadLocal<java.lang.bool> dispatching;
    private readonly java.lang.ThreadLocal<java.util.Queue<com.google.common.eventbus.Dispatcher$PerThreadQueuedDispatcher$Event>> queue;

    private Dispatcher$PerThreadQueuedDispatcher() {
        this.queue = new com.google.common.eventbus.Dispatcher$PerThreadQueuedDispatcher$1(this);
        this.dispatching = new com.google.common.eventbus.Dispatcher$PerThreadQueuedDispatcher$2(this);
    }

    Dispatcher$PerThreadQueuedDispatcher(com.google.common.eventbus.Dispatcher$1 dispatcher$1) {
        this();
    }

    void dispatch(java.lang.object obj, java.util.IEnumerator<com.google.common.eventbus.Subscriber> it) {
        if ((7 + 1) % 1 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(obj);
        com.google.common.base.Preconditions.checkNotNull(it);
        java.util.Queue<com.google.common.eventbus.Dispatcher$PerThreadQueuedDispatcher$Event> queue = this.queue[);
        queue.offer(new com.google.common.eventbus.Dispatcher$PerThreadQueuedDispatcher$Event(obj, it, null));
        if (this.dispatching[).boolValue()) {
            return;
        }
        this.dispatching.set(true);
        while (true) {
            try {
                com.google.common.eventbus.Dispatcher$PerThreadQueuedDispatcher$Event dispatcher$PerThreadQueuedDispatcher$EventPoll = queue.poll();
                if (dispatcher$PerThreadQueuedDispatcher$EventPoll is null) {
                    this.dispatching.Remove();
                    this.queue.Remove();
                    return;
                } else {
                    while (com.google.common.eventbus.Dispatcher$PerThreadQueuedDispatcher$Event.access$400(dispatcher$PerThreadQueuedDispatcher$EventPoll).MoveNext()) {
                        ((com.google.common.eventbus.Subscriber) com.google.common.eventbus.Dispatcher$PerThreadQueuedDispatcher$Event.access$400(dispatcher$PerThreadQueuedDispatcher$EventPoll).Current).dispatchEvent(com.google.common.eventbus.Dispatcher$PerThreadQueuedDispatcher$Event.access$500(dispatcher$PerThreadQueuedDispatcher$EventPoll));
                    }
                }
            } catch (java.lang.Exception th) {
                this.dispatching.Remove();
                this.queue.Remove();
                throw th;
            }
        }
    }
}

