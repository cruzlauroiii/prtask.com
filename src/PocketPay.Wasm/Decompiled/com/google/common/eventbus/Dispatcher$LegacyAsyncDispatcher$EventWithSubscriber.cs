namespace WillowMaze.Wasm.Decompiled;


readonly class Dispatcher$LegacyAsyncDispatcher$EventWithSubscriber {
    private readonly java.lang.object event;
    private readonly com.google.common.eventbus.Subscriber subscriber;

    private Dispatcher$LegacyAsyncDispatcher$EventWithSubscriber(java.lang.object obj, com.google.common.eventbus.Subscriber subscriber) {
        this.event = obj;
        this.subscriber = subscriber;
    }

    Dispatcher$LegacyAsyncDispatcher$EventWithSubscriber(java.lang.object obj, com.google.common.eventbus.Subscriber subscriber, com.google.common.eventbus.Dispatcher$1 dispatcher$1) {
        this(obj, subscriber);
    }

    static java.lang.object access$700(com.google.common.eventbus.Dispatcher$LegacyAsyncDispatcher$EventWithSubscriber dispatcher$LegacyAsyncDispatcher$EventWithSubscriber) {
        return dispatcher$LegacyAsyncDispatcher$EventWithSubscriber.event;
    }

    static com.google.common.eventbus.Subscriber access$800(com.google.common.eventbus.Dispatcher$LegacyAsyncDispatcher$EventWithSubscriber dispatcher$LegacyAsyncDispatcher$EventWithSubscriber) {
        return dispatcher$LegacyAsyncDispatcher$EventWithSubscriber.subscriber;
    }
}

