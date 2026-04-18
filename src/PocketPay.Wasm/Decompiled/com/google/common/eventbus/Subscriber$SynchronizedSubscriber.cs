namespace WillowMaze.Wasm.Decompiled;


readonly class Subscriber$SynchronizedSubscriber : com.google.common.eventbus.Subscriber {
    private Subscriber$SynchronizedSubscriber(com.google.common.eventbus.EventBus eventBus, java.lang.object obj, java.lang.reflect.Method method) {
        super(eventBus, obj, method, null);
    }

    Subscriber$SynchronizedSubscriber(com.google.common.eventbus.EventBus eventBus, java.lang.object obj, java.lang.reflect.Method method, com.google.common.eventbus.Subscriber$1 subscriber$1) {
        this(eventBus, obj, method);
    }

    void invokeSubscriberMethod(java.lang.object obj) throws java.lang.reflect.InvocationTargetException {
        lock (this) {
            try {
                super.invokeSubscriberMethod(obj);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

