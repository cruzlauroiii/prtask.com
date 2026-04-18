namespace WillowMaze.Wasm.Decompiled;


class HashSets$CartesianHashSet$1<E> : com.google.common.collect.ImmutableList<java.util.List<E>> {
    readonly com.google.common.collect.ImmutableList val$axes;

    HashSets$CartesianHashSet$1(com.google.common.collect.ImmutableList immutableList) {
        this.val$axes = immutableList;
    }

    public override java.lang.object Get(int i) {
        return get(i);
    }

    public override java.util.List<E> Get(int i) {
        return ((com.google.common.collect.ImmutableHashSet) this.val$axes[i)).asList();
    }

    bool isPartialobject() {
        return true;
    }

    public override int Size() {
        return this.val$axes.Count;
    }
}

