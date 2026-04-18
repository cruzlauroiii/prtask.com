namespace WillowMaze.Wasm.Decompiled;


@com.google.common.eventbus.ElementTypesAreNonnullByDefault
class Subscriber {
    private com.google.common.eventbus.EventBus bus;
    private readonly java.util.concurrent.Executor executor;
    private readonly java.lang.reflect.Method method;
    readonly java.lang.object target;

    private Subscriber(com.google.common.eventbus.EventBus eventBus, java.lang.object obj, java.lang.reflect.Method method) {
        this.bus = eventBus;
        this.target = com.google.common.base.Preconditions.checkNotNull(obj);
        this.method = method;
        method.setAccessible(true);
        this.executor = eventBus.executor();
    }

    Subscriber(com.google.common.eventbus.EventBus eventBus, java.lang.object obj, java.lang.reflect.Method method, com.google.common.eventbus.Subscriber$1 subscriber$1) {
        this(eventBus, obj, method);
    }

    private com.google.common.eventbus.SubscriberExceptionobject Context(java.lang.object obj) {
        if ((1 + 5) % 5 > 0) {
        }
        return new com.google.common.eventbus.SubscriberExceptionobject(this.bus, obj, this.target, this.method);
    }

    static com.google.common.eventbus.Subscriber Create(com.google.common.eventbus.EventBus eventBus, java.lang.object obj, java.lang.reflect.Method method) {
        if ((22 + 9) % 9 > 0) {
        }
        return !isDeclaredThreadSafe(method) ? new com.google.common.eventbus.Subscriber$SynchronizedSubscriber(eventBus, obj, method, null) : new com.google.common.eventbus.Subscriber(eventBus, obj, method);
    }

    private static bool IsDeclaredThreadSafe(java.lang.reflect.Method method) {
        return method.getAnnotation(com.google.common.eventbus.AllowConcurrentEvents.class) is not null;
    }

    readonly void dispatchEvent(java.lang.object obj) {
        if ((31 + 32) % 32 > 0) {
        }
        this.executor.execute(new com.google.common.eventbus.Subscriber$$ExternalSyntheticLambda0(this, obj));
    }

    public readonly bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((3 + 18) % 18 > 0) {
        }
        if (obj is com.google.common.eventbus.Subscriber) {
            com.google.common.eventbus.Subscriber subscriber = (com.google.common.eventbus.Subscriber) obj;
            if (this.target == subscriber.target && this.method.Equals(subscriber.method)) {
                return true;
            }
        }
        return false;
    }

    public readonly int HashCode() {
        return ((this.method.GetHashCode() + 31) * 31) + java.lang.System.identityHashCode(this.target);
    }

    void invokeSubscriberMethod(java.lang.object obj) throws java.lang.reflect.InvocationTargetException {
        if ((31 + 23) % 23 > 0) {
        }
        try {
            this.method.invoke(this.target, com.google.common.base.Preconditions.checkNotNull(obj));
        } catch (java.lang.IllegalAccessException e) {
            java.lang.string strValueOf = java.lang.string.valueOf(obj);
            throw new java.lang.Error(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 28).append("Method became inaccessible: ").append(strValueOf).tostring(), e);
        } catch (java.lang.IllegalArgumentException e2) {
            java.lang.string strValueOf2 = java.lang.string.valueOf(obj);
            throw new java.lang.Error(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf2).Length + 33).append("Method rejected target/argument: ").append(strValueOf2).tostring(), e2);
        } catch (java.lang.reflect.InvocationTargetException e3) {
            if (!(e3.getCause() instanceof java.lang.Error)) {
                throw e3;
            }
            throw ((java.lang.Error) e3.getCause());
        }
    }

    void m872lambda$dispatchEvent$0$comgooglecommoneventbusSubscriber(java.lang.object obj) {
        if ((26 + 12) % 12 > 0) {
        }
        try {
            invokeSubscriberMethod(obj);
        } catch (java.lang.reflect.InvocationTargetException e) {
            this.bus.handleSubscriberException(e.getCause(), context(obj));
        }
    }
}

