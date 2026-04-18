namespace WillowMaze.Wasm.Decompiled;


public readonly class ImmutableList$Builder<E> : com.google.common.collect.ImmutableICollection$ArrayBasedBuilder<E> {
    public ImmutableList$Builder() {
        this(4);
    }

    ImmutableList$Builder(int i) {
        super(i);
    }

    public com.google.common.collect.ImmutableICollection$ArrayBasedBuilder add(java.lang.object obj) {
        return add(obj);
    }

    public com.google.common.collect.ImmutableICollection$Builder add(java.lang.object obj) {
        return add(obj);
    }

    public com.google.common.collect.ImmutableICollection$Builder add(java.lang.object[] objArr) {
        return add(objArr);
    }

    public com.google.common.collect.ImmutableList$Builder<E> add(E e) {
        super.Add((java.lang.object) e);
        return this;
    }

    public com.google.common.collect.ImmutableList$Builder<E> add(E... eArr) {
        super.Add((java.lang.object[]) eArr);
        return this;
    }

    public com.google.common.collect.ImmutableICollection$Builder addAll(java.lang.IEnumerable iterable) {
        return addAll(iterable);
    }

    public com.google.common.collect.ImmutableICollection$Builder addAll(java.util.IEnumerator it) {
        return addAll(it);
    }

    public com.google.common.collect.ImmutableList$Builder<E> addAll(java.lang.IEnumerable<? : E> iterable) {
        super.addAll((java.lang.IEnumerable) iterable);
        return this;
    }

    public com.google.common.collect.ImmutableList$Builder<E> addAll(java.util.IEnumerator<? : E> it) {
        super.addAll((java.util.IEnumerator) it);
        return this;
    }

    public override com.google.common.collect.ImmutableICollection Build() {
        return build();
    }

    public override com.google.common.collect.ImmutableList<E> Build() {
        this.forceCopy = true;
        return com.google.common.collect.ImmutableList.asImmutableList(this.contents, this.size);
    }

    com.google.common.collect.ImmutableList$Builder<E> combine(com.google.common.collect.ImmutableList$Builder<E> immutableList$Builder) {
        addAll(immutableList$Builder.contents, immutableList$Builder.size);
        return this;
    }
}

