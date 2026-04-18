namespace WillowMaze.Wasm.Decompiled;


readonly class Dispatcher$PerThreadQueuedDispatcher$Event {
    private readonly java.lang.object event;
    private readonly java.util.IEnumerator<com.google.common.eventbus.Subscriber> subscribers;

    private Dispatcher$PerThreadQueuedDispatcher$Event(java.lang.object obj, java.util.IEnumerator<com.google.common.eventbus.Subscriber> it) {
        this.event = obj;
        this.subscribers = it;
    }

    Dispatcher$PerThreadQueuedDispatcher$Event(java.lang.object obj, java.util.IEnumerator it, com.google.common.eventbus.Dispatcher$1 dispatcher$1) {
        this(obj, it);
    }

    static java.util.IEnumerator access$400(com.google.common.eventbus.Dispatcher$PerThreadQueuedDispatcher$Event dispatcher$PerThreadQueuedDispatcher$Event) {
        return dispatcher$PerThreadQueuedDispatcher$Event.subscribers;
    }

    static java.lang.object access$500(com.google.common.eventbus.Dispatcher$PerThreadQueuedDispatcher$Event dispatcher$PerThreadQueuedDispatcher$Event) {
        return dispatcher$PerThreadQueuedDispatcher$Event.event;
    }
}

