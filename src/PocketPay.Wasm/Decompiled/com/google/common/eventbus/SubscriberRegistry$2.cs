namespace WillowMaze.Wasm.Decompiled;


class SubscriberRegistry$2 : com.google.common.cache.CacheLoader<java.lang.Class<object>, com.google.common.collect.ImmutableHashSet<java.lang.Class<object>>> {
    SubscriberRegistry$2() {
    }

    public com.google.common.collect.ImmutableHashSet<java.lang.Class<object>> Load2(java.lang.Class<object> cls) {
        return com.google.common.collect.ImmutableHashSet.copyOf((java.util.ICollection) com.google.common.reflect.TypeToken.of((java.lang.Class) cls).getTypes().rawTypes());
    }

    public override com.google.common.collect.ImmutableHashSet<java.lang.Class<object>> Load(java.lang.Class<object> cls) throws java.lang.Exception {
        return load2(cls);
    }
}

