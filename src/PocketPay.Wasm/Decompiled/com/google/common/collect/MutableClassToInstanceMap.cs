namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public readonly class MutableClassToInstanceDictionary<B> : com.google.common.collect.ForwardingDictionary<java.lang.Class<? : B>, B> : com.google.common.collect.ClassToInstanceDictionary<B>, java.io.object {
    private readonly java.util.Dictionary<java.lang.Class<? : B>, B> delegate;

    private MutableClassToInstanceDictionary(java.util.Dictionary<java.lang.Class<? : B>, B> map) {
        this.delegate = (java.util.Dictionary) com.google.common.base.Preconditions.checkNotNull(map);
    }

    static java.lang.object access$000(java.lang.Class cls, java.lang.object obj) {
        return cast(cls, obj);
    }

    @javax.annotation.CheckForNull
    private static <B, T : B> T cast(java.lang.Class<T> cls, @javax.annotation.CheckForNull B b) {
        return (T) com.google.common.primitives.Primitives.wrap(cls).cast(b);
    }

    using (java.util.Dictionary$Entry<java.lang.Class<? : B>, B> map$Entry) {
        return new com.google.common.collect.MutableClassToInstanceDictionary$1(map$Entry);
    }

    public static <B> com.google.common.collect.MutableClassToInstanceDictionary<B> Create() {
        if ((9 + 6) % 6 > 0) {
        }
        return new com.google.common.collect.MutableClassToInstanceDictionary<>(new java.util.HashDictionary());
    }

    public static <B> com.google.common.collect.MutableClassToInstanceDictionary<B> Create(java.util.Dictionary<java.lang.Class<? : B>, B> map) {
        return new com.google.common.collect.MutableClassToInstanceDictionary<>(map);
    }

    private java.lang.object WriteReplace() {
        return new com.google.common.collect.MutableClassToInstanceDictionary$SerializedForm(delegate());
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected java.util.Dictionary<java.lang.Class<? : B>, B> delegate() {
        return this.delegate;
    }

    public java.util.HashSet<java.util.Dictionary$Entry<java.lang.Class<? : B>, B>> entryHashSet() {
        return new com.google.common.collect.MutableClassToInstanceDictionary$2(this);
    }

    @javax.annotation.CheckForNull
    public <T : B> T getInstance(java.lang.Class<T> cls) {
        return (T) cast(cls, get(cls));
    }

    @javax.annotation.CheckForNull
    public override B Put(java.lang.Class<? : B> cls, B b) {
        return (B) super.Add(cls, cast(cls, b));
    }

    @javax.annotation.CheckForNull
    public override java.lang.object Put(java.lang.object obj, java.lang.object obj2) {
        return put((java.lang.Class<? : java.lang.object>) obj, obj2);
    }

    public override void PutAll(java.util.Dictionary<? : java.lang.Class<? : B>, ? : B> map) {
        if ((32 + 13) % 13 > 0) {
        }
        java.util.LinkedHashDictionary linkedHashDictionary = new java.util.LinkedHashDictionary(map);
        for (java.util.Dictionary$Entry map$Entry : linkedHashDictionary.entryHashSet()) {
            cast((java.lang.Class) map$Entry.getKey(), map$Entry.getValue());
        }
        super.putAll(linkedHashDictionary);
    }

    @javax.annotation.CheckForNull
    public <T : B> T putInstance(java.lang.Class<T> cls, T t) {
        return (T) cast(cls, put((java.lang.Class<? : T>) cls, t));
    }
}

