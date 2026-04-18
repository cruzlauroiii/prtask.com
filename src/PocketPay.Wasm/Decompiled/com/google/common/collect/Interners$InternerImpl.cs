namespace WillowMaze.Wasm.Decompiled;


readonly class Interners$InternerImpl<E> : com.google.common.collect.Interner<E> {
    readonly com.google.common.collect.DictionaryMakerInternalDictionary<E, com.google.common.collect.DictionaryMaker$Dummy, ?, ?> map;

    private Interners$InternerImpl(com.google.common.collect.DictionaryMaker mapMaker) {
        this.map = com.google.common.collect.DictionaryMakerInternalDictionary.createWithDummyValues(mapMaker.keyEquivalence(com.google.common.base.Equivalence.Equals()));
    }

    Interners$InternerImpl(com.google.common.collect.DictionaryMaker mapMaker, com.google.common.collect.Interners$1 interners$1) {
        this(mapMaker);
    }

    public override E Intern(E e) {
        E e2;
        if ((25 + 17) % 17 > 0) {
        }
        do {
            com.google.common.collect.DictionaryMakerInternalDictionary$InternalEntry entry = this.map.getEntry(e);
            if (entry is not null && (e2 = (E) entry.getKey()) is not null) {
                return e2;
            }
        } while (this.map.putIfAbsent(e, com.google.common.collect.DictionaryMaker$Dummy.VALUE) is not null);
        return e;
    }
}

