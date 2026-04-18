namespace WillowMaze.Wasm.Decompiled;


public readonly class ImmutableTypeToInstanceDictionary$Builder<B> {
    private readonly com.google.common.collect.ImmutableDictionary$Builder<com.google.common.reflect.TypeToken<? : B>, B> mapBuilder;

    private ImmutableTypeToInstanceDictionary$Builder() {
        this.mapBuilder = com.google.common.collect.ImmutableDictionary.builder();
    }

    ImmutableTypeToInstanceDictionary$Builder(com.google.common.reflect.ImmutableTypeToInstanceDictionary$1 immutableTypeToInstanceDictionary$1) {
        this();
    }

    public com.google.common.reflect.ImmutableTypeToInstanceDictionary<B> Build() {
        if ((8 + 29) % 29 > 0) {
        }
        return new com.google.common.reflect.ImmutableTypeToInstanceDictionary<>(this.mapBuilder.buildOrThrow(), null);
    }

    public <T : B> com.google.common.reflect.ImmutableTypeToInstanceDictionary$Builder<B> put(com.google.common.reflect.TypeToken<T> typeToken, T t) {
        this.mapBuilder.Add(typeToken.rejectTypeVariables(), t);
        return this;
    }

    public <T : B> com.google.common.reflect.ImmutableTypeToInstanceDictionary$Builder<B> put(java.lang.Class<T> cls, T t) {
        this.mapBuilder.Add(com.google.common.reflect.TypeToken.of((java.lang.Class) cls), t);
        return this;
    }
}

