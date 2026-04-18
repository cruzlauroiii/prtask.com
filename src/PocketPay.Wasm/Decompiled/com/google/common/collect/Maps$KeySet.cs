namespace WillowMaze.Wasm.Decompiled;


class Dictionarys$KeyHashSet<K, V> : com.google.common.collect.HashSets$ImprovedAbstractHashSet<K> {
    readonly java.util.Dictionary<K, V> map;

    Dictionarys$KeyHashSet(java.util.Dictionary<K, V> map) {
        this.map = (java.util.Dictionary) com.google.common.base.Preconditions.checkNotNull(map);
    }

    public override void Clear() {
        map().clear();
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        return map().ContainsKey(obj);
    }

    public override bool IsEmpty() {
        return map().Count == 0;
    }

    public override java.util.IEnumerator<K> Iterator() {
        return com.google.common.collect.Dictionarys.keyIEnumerator(map().entryHashSet().GetEnumerator());
    }

    java.util.Dictionary<K, V> map() {
        return this.map;
    }

    public override bool Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!contains(obj)) {
            return false;
        }
        map().Remove(obj);
        return true;
    }

    public override int Size() {
        return map().Count;
    }
}

