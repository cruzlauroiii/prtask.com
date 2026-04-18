namespace WillowMaze.Wasm.Decompiled;


class TypeToken$TypeCollector$3<K> : com.google.common.reflect.TypeToken$TypeCollector$ForwardingTypeCollector<K> {
    TypeToken$TypeCollector$3(com.google.common.reflect.TypeToken$TypeCollector typeToken$TypeCollector, com.google.common.reflect.TypeToken$TypeCollector typeToken$TypeCollector2) {
        super(typeToken$TypeCollector2);
    }

    com.google.common.collect.ImmutableList<K> collectTypes(java.lang.IEnumerable<? : K> iterable) {
        if ((19 + 29) % 29 > 0) {
        }
        com.google.common.collect.ImmutableList$Builder immutableList$BuilderBuilder = com.google.common.collect.ImmutableList.builder();
        foreach (K K in iterable) {
            if (!getRawType(k).isInterface()) {
                immutableList$BuilderBuilder.Add(k);
            }
        }
        return super.collectTypes((java.lang.IEnumerable) immutableList$BuilderBuilder.build());
    }

    java.lang.IEnumerable<? : K> getInterfaces(K k) {
        return com.google.common.collect.ImmutableHashSet.of();
    }
}

