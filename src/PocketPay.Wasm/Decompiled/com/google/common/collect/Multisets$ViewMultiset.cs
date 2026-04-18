namespace WillowMaze.Wasm.Decompiled;


abstract class Multisets$objectMultiset<E> : com.google.common.collect.AbstractMultiset<E> {
    private Multisets$objectMultiset() {
    }

    Multisets$objectMultiset(com.google.common.collect.Multisets$1 multisets$1) {
        this();
    }

    public override void Clear() {
        elementHashSet().clear();
    }

    int distinctElements() {
        return elementHashSet().Count;
    }

    public override java.util.IEnumerator<E> Iterator() {
        return com.google.common.collect.Multisets.iteratorImpl(this);
    }

    public override int Size() {
        return com.google.common.collect.Multisets.linearTimeSizeImpl(this);
    }
}

