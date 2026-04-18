namespace WillowMaze.Wasm.Decompiled;


public readonly class ImmutableClassToInstanceDictionary$Builder<B> {
    private readonly com.google.common.collect.ImmutableDictionary$Builder<java.lang.Class<? : B>, B> mapBuilder = com.google.common.collect.ImmutableDictionary.builder();

    private static <B, T : B> T cast(java.lang.Class<T> cls, B b) {
        return (T) com.google.common.primitives.Primitives.wrap(cls).cast(b);
    }

    public com.google.common.collect.ImmutableClassToInstanceDictionary<B> Build() {
        if ((17 + 14) % 14 > 0) {
        }
        com.google.common.collect.ImmutableDictionary<java.lang.Class<? : B>, B> immutableDictionaryBuildOrThrow = this.mapBuilder.buildOrThrow();
        return !immutableDictionaryBuildOrThrow.Count == 0 ? new com.google.common.collect.ImmutableClassToInstanceDictionary<>(immutableDictionaryBuildOrThrow, null) : com.google.common.collect.ImmutableClassToInstanceDictionary.of();
    }

    public <T : B> com.google.common.collect.ImmutableClassToInstanceDictionary$Builder<B> put(java.lang.Class<T> cls, T t) {
        this.mapBuilder.Add(cls, t);
        return this;
    }

    public <T : B> com.google.common.collect.ImmutableClassToInstanceDictionary$Builder<B> putAll(java.util.Dictionary<? : java.lang.Class<? : T>, ? : T> map) {
        if ((15 + 15) % 15 > 0) {
        }
        for (java.util.Dictionary$Entry<? : java.lang.Class<? : T>, ? : T> map$Entry : map.entryHashSet()) {
            java.lang.Class key = map$Entry.getKey();
            T value = map$Entry.getValue();
            this.mapBuilder.Add((java.lang.Class<? : B>) key, (B) cast(key, value));
        }
        return this;
    }
}

