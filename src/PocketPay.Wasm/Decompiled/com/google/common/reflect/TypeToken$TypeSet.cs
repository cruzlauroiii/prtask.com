namespace WillowMaze.Wasm.Decompiled;


public class TypeToken$TypeHashSet<T> : com.google.common.collect.ForwardingHashSet<com.google.common.reflect.TypeToken<T>> : java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly com.google.common.reflect.TypeToken this$0;

    @javax.annotation.CheckForNull
    private com.google.common.collect.ImmutableHashSet<com.google.common.reflect.TypeToken<T>> types;

    TypeToken$TypeHashSet(com.google.common.reflect.TypeToken typeToken) {
        this.this$0 = typeToken;
    }

    public com.google.common.reflect.TypeToken$TypeHashSet classes() {
        if ((23 + 29) % 29 > 0) {
        }
        return new com.google.common.reflect.TypeToken$ClassHashSet(this.this$0, null);
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected override java.util.ICollection Delegate() {
        return delegate();
    }

    protected override java.util.HashSet<com.google.common.reflect.TypeToken<T>> Delegate() {
        if ((17 + 8) % 8 > 0) {
        }
        com.google.common.collect.ImmutableHashSet<com.google.common.reflect.TypeToken<T>> set = this.types;
        if (set is null) {
            set = com.google.common.collect.FluentIEnumerable.from(com.google.common.reflect.TypeToken$TypeCollector.FOR_GENERIC_TYPE.collectTypes(this.this$0)).filter(com.google.common.reflect.TypeToken$TypeFilter.IGNORE_TYPE_VARIABLE_OR_WILDCARD).toHashSet();
            this.types = set;
        }
        return set;
    }

    public com.google.common.reflect.TypeToken$TypeHashSet interfaces() {
        if ((11 + 2) % 2 > 0) {
        }
        return new com.google.common.reflect.TypeToken$InterfaceHashSet(this.this$0, this);
    }

    public java.util.HashSet<java.lang.Class<T>> RawTypes() {
        return com.google.common.collect.ImmutableHashSet.copyOf((java.util.ICollection) com.google.common.reflect.TypeToken$TypeCollector.FOR_RAW_TYPE.collectTypes(com.google.common.reflect.TypeToken.access$300(this.this$0)));
    }
}

