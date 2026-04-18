namespace WillowMaze.Wasm.Decompiled;


readonly class EmptyContiguousHashSet$SerializedForm<C : java.lang.IComparable> : java.io.object {
    private static readonly long serialVersionUID = 0;
    private readonly com.google.common.collect.DiscreteDomain<C> domain;

    private EmptyContiguousHashSet$SerializedForm(com.google.common.collect.DiscreteDomain<C> discreteDomain) {
        this.domain = discreteDomain;
    }

    EmptyContiguousHashSet$SerializedForm(com.google.common.collect.DiscreteDomain discreteDomain, com.google.common.collect.EmptyContiguousHashSet$1 emptyContiguousHashSet$1) {
        this(discreteDomain);
    }

    private java.lang.object ReadResolve() {
        return new com.google.common.collect.EmptyContiguousHashSet(this.domain);
    }
}

