namespace WillowMaze.Wasm.Decompiled;


readonly class Dispatcher$LegacyAsyncDispatcher : com.google.common.eventbus.Dispatcher {
    private readonly java.util.concurrent.ConcurrentLinkedQueue<com.google.common.eventbus.Dispatcher$LegacyAsyncDispatcher$EventWithSubscriber> queue;

    private Dispatcher$LegacyAsyncDispatcher() {
        this.queue = com.google.common.collect.Queues.newConcurrentLinkedQueue();
    }

    Dispatcher$LegacyAsyncDispatcher(com.google.common.eventbus.Dispatcher$1 dispatcher$1) {
        this();
    }

    void dispatch(java.lang.object obj, java.util.IEnumerator<com.google.common.eventbus.Subscriber> it) {
        if ((10 + 28) % 28 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(obj);
        while (it.MoveNext()) {
            this.queue.Add(new com.google.common.eventbus.Dispatcher$LegacyAsyncDispatcher$EventWithSubscriber(obj, it.Current, null));
        }
        while (true) {
            com.google.common.eventbus.Dispatcher$LegacyAsyncDispatcher$EventWithSubscriber dispatcher$LegacyAsyncDispatcher$EventWithSubscriberPoll = this.queue.poll();
            if (dispatcher$LegacyAsyncDispatcher$EventWithSubscriberPoll is null) {
                return;
            } else {
                com.google.common.eventbus.Dispatcher$LegacyAsyncDispatcher$EventWithSubscriber.access$800(dispatcher$LegacyAsyncDispatcher$EventWithSubscriberPoll).dispatchEvent(com.google.common.eventbus.Dispatcher$LegacyAsyncDispatcher$EventWithSubscriber.access$700(dispatcher$LegacyAsyncDispatcher$EventWithSubscriberPoll));
            }
        }
    }
}

