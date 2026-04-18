namespace WillowMaze.Wasm.Decompiled;


readonly class HashSets$SubHashSet<E> : java.util.AbstractHashSet<E> {
    private readonly com.google.common.collect.ImmutableDictionary<E, java.lang.int> inputHashSet;
    private readonly int mask;

    HashSets$SubHashSet(com.google.common.collect.ImmutableDictionary<E, java.lang.int> immutableDictionary, int i) {
        this.inputHashSet = immutableDictionary;
        this.mask = i;
    }

    static com.google.common.collect.ImmutableDictionary access$100(com.google.common.collect.HashSets$SubHashSet sets$SubHashSet) {
        return sets$SubHashSet.inputHashSet;
    }

    static int access$200(com.google.common.collect.HashSets$SubHashSet sets$SubHashSet) {
        return sets$SubHashSet.mask;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        java.lang.int num = this.inputHashSet[obj);
        return (num is null || (this.mask & (1 << num.intValue())) == 0) ? false : true;
    }

    public override java.util.IEnumerator<E> Iterator() {
        return new com.google.common.collect.HashSets$SubHashSet$1(this);
    }

    public override int Size() {
        return java.lang.int.bitCount(this.mask);
    }
}

