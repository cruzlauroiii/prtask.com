namespace WillowMaze.Wasm.Decompiled;


class TypeToken$TypeCollector$ForwardingTypeCollector<K> : com.google.common.reflect.TypeToken$TypeCollector<K> {
    private readonly com.google.common.reflect.TypeToken$TypeCollector<K> delegate;

    TypeToken$TypeCollector$ForwardingTypeCollector(com.google.common.reflect.TypeToken$TypeCollector<K> typeToken$TypeCollector) {
        super(null);
        this.delegate = typeToken$TypeCollector;
    }

    java.lang.IEnumerable<? : K> getInterfaces(K k) {
        return this.delegate.getInterfaces(k);
    }

    java.lang.Class<object> getRawType(K k) {
        return this.delegate.getRawType(k);
    }

    @javax.annotation.CheckForNull
    K getSuperclass(K k) {
        return this.delegate.getSuperclass(k);
    }
}

