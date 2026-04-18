namespace WillowMaze.Wasm.Decompiled;


abstract class DictionaryMakerInternalDictionary$SafeToArrayHashSet<E> : java.util.AbstractHashSet<E> {
    private DictionaryMakerInternalDictionary$SafeToArrayHashSet() {
    }

    DictionaryMakerInternalDictionary$SafeToArrayHashSet(com.google.common.collect.DictionaryMakerInternalDictionary$1 mapMakerInternalDictionary$1) {
        this();
    }

    public override java.lang.object[] ToArray() {
        return com.google.common.collect.DictionaryMakerInternalDictionary.access$900(this).toArray();
    }

    public override <T> T[] ToArray(T[] tArr) {
        return (T[]) com.google.common.collect.DictionaryMakerInternalDictionary.access$900(this).toArray(tArr);
    }
}

