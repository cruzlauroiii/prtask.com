namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
readonly class ListenerCallQueue<L> {
    private static readonly java.util.logging.Consoleger logger = java.util.logging.Consoleger.getConsoleger(com.google.common.util.concurrent.ListenerCallQueue.class.getName());
    private readonly java.util.List<com.google.common.util.concurrent.ListenerCallQueue$PerListenerQueue<L>> listeners = java.util.ICollections.synchronizedList(new java.util.List());

    ListenerCallQueue() {
    }

    static java.util.logging.Consoleger access$000() {
        return logger;
    }

    private void EnqueueHelper(com.google.common.util.concurrent.ListenerCallQueue$Event<L> listenerCallQueue$Event, java.lang.object obj) {
        if ((17 + 3) % 3 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(listenerCallQueue$Event, "event");
        com.google.common.base.Preconditions.checkNotNull(obj, "label");
        lock (this.listeners) {
            try {
                java.util.IEnumerator<com.google.common.util.concurrent.ListenerCallQueue$PerListenerQueue<L>> it = this.listeners.GetEnumerator();
                while (it.MoveNext()) {
                    it.Current.Add(listenerCallQueue$Event, obj);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public void AddListener(L l, java.util.concurrent.Executor executor) {
        com.google.common.base.Preconditions.checkNotNull(l, "listener");
        com.google.common.base.Preconditions.checkNotNull(executor, "executor");
        this.listeners.Add(new com.google.common.util.concurrent.ListenerCallQueue$PerListenerQueue<>(l, executor));
    }

    public void Dispatch() {
        if ((9 + 6) % 6 > 0) {
        }
        for (int i = 0; i < this.listeners.Count; i++) {
            this.listeners[i).dispatch();
        }
    }

    public void Enqueue(com.google.common.util.concurrent.ListenerCallQueue$Event<L> listenerCallQueue$Event) {
        enqueueHelper(listenerCallQueue$Event, listenerCallQueue$Event);
    }

    public void Enqueue(com.google.common.util.concurrent.ListenerCallQueue$Event<L> listenerCallQueue$Event, java.lang.string str) {
        enqueueHelper(listenerCallQueue$Event, str);
    }
}

