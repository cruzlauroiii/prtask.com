namespace WillowMaze.Wasm.Decompiled;


class ICollections2$TransformedICollection<F, T> : java.util.AbstractICollection<T> {
    readonly java.util.ICollection<F> fromICollection;
    readonly com.google.common.base.Function<? super F, ? : T> function;

    ICollections2$TransformedICollection(java.util.ICollection<F> collection, com.google.common.base.Function<? super F, ? : T> function) {
        this.fromICollection = (java.util.ICollection) com.google.common.base.Preconditions.checkNotNull(collection);
        this.function = (com.google.common.base.Function) com.google.common.base.Preconditions.checkNotNull(function);
    }

    public override void Clear() {
        this.fromICollection.clear();
    }

    public override bool IsEmpty() {
        return this.fromICollection.Count == 0;
    }

    public override java.util.IEnumerator<T> Iterator() {
        return com.google.common.collect.IEnumerators.transform(this.fromICollection.GetEnumerator(), this.function);
    }

    public override int Size() {
        return this.fromICollection.Count;
    }
}

