namespace WillowMaze.Wasm.Decompiled;


@com.google.common.eventbus.ElementTypesAreNonnullByDefault
public class SubscriberExceptionobject {
    private readonly java.lang.object event;
    private readonly com.google.common.eventbus.EventBus eventBus;
    private readonly java.lang.object subscriber;
    private readonly java.lang.reflect.Method subscriberMethod;

    SubscriberExceptionobject(com.google.common.eventbus.EventBus eventBus, java.lang.object obj, java.lang.object obj2, java.lang.reflect.Method method) {
        this.eventBus = (com.google.common.eventbus.EventBus) com.google.common.base.Preconditions.checkNotNull(eventBus);
        this.event = com.google.common.base.Preconditions.checkNotNull(obj);
        this.subscriber = com.google.common.base.Preconditions.checkNotNull(obj2);
        this.subscriberMethod = (java.lang.reflect.Method) com.google.common.base.Preconditions.checkNotNull(method);
    }

    public java.lang.object GetEvent() {
        return this.event;
    }

    public com.google.common.eventbus.EventBus GetEventBus() {
        return this.eventBus;
    }

    public java.lang.object GetSubscriber() {
        return this.subscriber;
    }

    public java.lang.reflect.Method GetSubscriberMethod() {
        return this.subscriberMethod;
    }
}

