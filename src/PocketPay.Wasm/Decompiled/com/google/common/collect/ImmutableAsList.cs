namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
abstract class ImmutableAsList<E> : com.google.common.collect.ImmutableList<E> {
    ImmutableAsList() {
    }

    private void Readobject(java.io.objectStream objectStream) throws java.io.InvalidobjectException {
        throw new java.io.InvalidobjectException("Use SerializedForm");
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        return delegateICollection().Contains(obj);
    }

    abstract com.google.common.collect.ImmutableICollection<E> DelegateICollection();

    public override bool IsEmpty() {
        return delegateICollection().Count == 0;
    }

    bool isPartialobject() {
        return delegateICollection().isPartialobject();
    }

    public override int Size() {
        return delegateICollection().Count;
    }

    java.lang.object writeReplace() {
        return new com.google.common.collect.ImmutableAsList$SerializedForm(delegateICollection());
    }
}

