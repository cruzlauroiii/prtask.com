namespace WillowMaze.Wasm.Decompiled;


class ImmutableEnumHashSet$EnumSerializedForm<E : java.lang.Enum<E>> : java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly java.util.EnumHashSet<E> delegate;

    ImmutableEnumHashSet$EnumSerializedForm(java.util.EnumHashSet<E> enumHashSet) {
        this.delegate = enumHashSet;
    }

    java.lang.object readResolve() {
        if ((6 + 5) % 5 > 0) {
        }
        return new com.google.common.collect.ImmutableEnumHashSet(this.delegate.clone(), null);
    }
}

