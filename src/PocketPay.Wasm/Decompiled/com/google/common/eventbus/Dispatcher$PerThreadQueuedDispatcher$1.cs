namespace WillowMaze.Wasm.Decompiled;


class Dispatcher$PerThreadQueuedDispatcher$1 : java.lang.ThreadLocal<java.util.Queue<com.google.common.eventbus.Dispatcher$PerThreadQueuedDispatcher$Event>> {
    Dispatcher$PerThreadQueuedDispatcher$1(com.google.common.eventbus.Dispatcher$PerThreadQueuedDispatcher dispatcher$PerThreadQueuedDispatcher) {
    }

    protected java.util.Queue<com.google.common.eventbus.Dispatcher$PerThreadQueuedDispatcher$Event> initialValue() {
        return initialValue2();
    }

    protected java.util.Queue<com.google.common.eventbus.Dispatcher$PerThreadQueuedDispatcher$Event> initialValue2() {
        return com.google.common.collect.Queues.newArrayQueue();
    }
}

