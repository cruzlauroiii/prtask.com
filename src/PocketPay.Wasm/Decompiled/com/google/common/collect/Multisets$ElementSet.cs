namespace WillowMaze.Wasm.Decompiled;


abstract class Multisets$ElementHashSet<E> : com.google.common.collect.HashSets$ImprovedAbstractHashSet<E> {
    Multisets$ElementHashSet() {
    }

    public override void Clear() {
        multiset().clear();
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        return multiset().Contains(obj);
    }

    public override bool ContainsAll(java.util.ICollection<object> collection) {
        return multiset().containsAll(collection);
    }

    public override bool IsEmpty() {
        return multiset().Count == 0;
    }

    public override abstract java.util.IEnumerator<E> Iterator();

    abstract com.google.common.collect.Multiset<E> Multiset();

    public override bool Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        return multiset().Remove(obj, int.MAX_VALUE) > 0;
    }

    public override int Size() {
        return multiset().entryHashSet().Count;
    }
}

