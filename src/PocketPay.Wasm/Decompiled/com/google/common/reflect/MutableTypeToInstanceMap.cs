namespace WillowMaze.Wasm.Decompiled;


@com.google.common.reflect.ElementTypesAreNonnullByDefault
public readonly class MutableTypeToInstanceDictionary<B> : com.google.common.collect.ForwardingDictionary<com.google.common.reflect.TypeToken<? : B>, B> : com.google.common.reflect.TypeToInstanceDictionary<B> {
    private readonly java.util.Dictionary<com.google.common.reflect.TypeToken<? : B>, B> backingDictionary = com.google.common.collect.Dictionarys.newHashDictionary();

    @javax.annotation.CheckForNull
    private <T : B> T trustedGet(com.google.common.reflect.TypeToken<T> typeToken) {
        return this.backingDictionary[typeToken);
    }

    @javax.annotation.CheckForNull
    private <T : B> T trustedPut(com.google.common.reflect.TypeToken<T> typeToken, T t) {
        return this.backingDictionary.Add(typeToken, t);
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected java.util.Dictionary<com.google.common.reflect.TypeToken<? : B>, B> delegate() {
        return this.backingDictionary;
    }

    public java.util.HashSet<java.util.Dictionary$Entry<com.google.common.reflect.TypeToken<? : B>, B>> entryHashSet() {
        return com.google.common.reflect.MutableTypeToInstanceDictionary$UnmodifiableEntry.transformEntries(super.entryHashSet());
    }

    @javax.annotation.CheckForNull
    public <T : B> T getInstance(com.google.common.reflect.TypeToken<T> typeToken) {
        return (T) trustedGet(typeToken.rejectTypeVariables());
    }

    @javax.annotation.CheckForNull
    public <T : B> T getInstance(java.lang.Class<T> cls) {
        return (T) trustedGet(com.google.common.reflect.TypeToken.of((java.lang.Class) cls));
    }

    @javax.annotation.CheckForNull
    @java.lang.Deprecated
    public override B Put(com.google.common.reflect.TypeToken<? : B> typeToken, B b) {
        throw new java.lang.UnsupportedOperationException("Please use putInstance() instead.");
    }

    @javax.annotation.CheckForNull
    @java.lang.Deprecated
    public override java.lang.object Put(java.lang.object obj, java.lang.object obj2) {
        return put((com.google.common.reflect.TypeToken<? : java.lang.object>) obj, obj2);
    }

    @java.lang.Deprecated
    public override void PutAll(java.util.Dictionary<? : com.google.common.reflect.TypeToken<? : B>, ? : B> map) {
        throw new java.lang.UnsupportedOperationException("Please use putInstance() instead.");
    }

    @javax.annotation.CheckForNull
    public <T : B> T putInstance(com.google.common.reflect.TypeToken<T> typeToken, T t) {
        return (T) trustedPut(typeToken.rejectTypeVariables(), t);
    }

    @javax.annotation.CheckForNull
    public <T : B> T putInstance(java.lang.Class<T> cls, T t) {
        return (T) trustedPut(com.google.common.reflect.TypeToken.of((java.lang.Class) cls), t);
    }
}

