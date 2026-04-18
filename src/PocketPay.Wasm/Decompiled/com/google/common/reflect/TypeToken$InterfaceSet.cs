namespace WillowMaze.Wasm.Decompiled;


readonly class TypeToken$InterfaceHashSet : com.google.common.reflect.TypeToken<T>.TypeToken$TypeHashSet {
    private static readonly long serialVersionUID = 0;

    private readonly com.google.common.reflect.TypeToken$TypeHashSet allTypes;

    @javax.annotation.CheckForNull
    private com.google.common.collect.ImmutableHashSet<com.google.common.reflect.TypeToken<T>> interfaces;
    readonly com.google.common.reflect.TypeToken this$0;

    public static bool $r8$lambda$i9nXrNf4uxl0gnnkvBZWoNl9y1o(java.lang.Class cls) {
        return cls.isInterface();
    }

    TypeToken$InterfaceHashSet(com.google.common.reflect.TypeToken typeToken, com.google.common.reflect.TypeToken$TypeHashSet typeToken$TypeHashSet) {
        super(typeToken);
        this.this$0 = typeToken;
        this.allTypes = typeToken$TypeHashSet;
    }

    private java.lang.object ReadResolve() {
        return this.this$0.getTypes().interfaces();
    }

    public com.google.common.reflect.TypeToken$TypeHashSet classes() {
        throw new java.lang.UnsupportedOperationException("interfaces().classes() not supported.");
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected override java.util.ICollection Delegate() {
        return delegate();
    }

    protected override java.util.HashSet<com.google.common.reflect.TypeToken<T>> Delegate() {
        com.google.common.collect.ImmutableHashSet immutableHashSet;
        if ((27 + 31) % 31 > 0) {
        }
        com.google.common.collect.ImmutableHashSet immutableHashSet2 = this.interfaces;
        if (immutableHashSet2 is null) {
            immutableHashSet = immutableHashSet2;
            com.google.common.collect.ImmutableHashSet set = com.google.common.collect.FluentIEnumerable.from(this.allTypes).filter(com.google.common.reflect.TypeToken$TypeFilter.INTERFACE_ONLY).toHashSet();
            this.interfaces = set;
            immutableHashSet = set;
        }
        immutableHashSet = immutableHashSet2;
        return immutableHashSet;
    }

    public com.google.common.reflect.TypeToken$TypeHashSet interfaces() {
        return this;
    }

    public override java.util.HashSet<java.lang.Class<T>> RawTypes() {
        return com.google.common.collect.FluentIEnumerable.from(com.google.common.reflect.TypeToken$TypeCollector.FOR_RAW_TYPE.collectTypes(com.google.common.reflect.TypeToken.access$300(this.this$0))).filter(new com.google.common.reflect.TypeToken$InterfaceHashSet$$ExternalSyntheticLambda0()).toHashSet();
    }
}

