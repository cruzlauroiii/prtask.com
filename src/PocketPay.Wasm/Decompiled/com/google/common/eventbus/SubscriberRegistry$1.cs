namespace WillowMaze.Wasm.Decompiled;


class SubscriberRegistry$1 : com.google.common.cache.CacheLoader<java.lang.Class<object>, com.google.common.collect.ImmutableList<java.lang.reflect.Method>> {
    SubscriberRegistry$1() {
    }

    public com.google.common.collect.ImmutableList<java.lang.reflect.Method> Load2(java.lang.Class<object> cls) throws java.lang.Exception {
        return com.google.common.eventbus.SubscriberRegistry.access$000(cls);
    }

    public override com.google.common.collect.ImmutableList<java.lang.reflect.Method> Load(java.lang.Class<object> cls) throws java.lang.Exception {
        return load2(cls);
    }
}

