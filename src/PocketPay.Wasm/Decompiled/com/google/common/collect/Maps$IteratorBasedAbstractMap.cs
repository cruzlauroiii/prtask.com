namespace WillowMaze.Wasm.Decompiled;


abstract class Dictionarys$IEnumeratorBasedAbstractDictionary<K, V> : java.util.AbstractDictionary<K, V> {
    Dictionarys$IEnumeratorBasedAbstractDictionary() {
    }

    public override void Clear() {
        com.google.common.collect.IEnumerators.clear(entryIEnumerator());
    }

    abstract java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> entryIEnumerator();

    public java.util.HashSet<java.util.Dictionary$Entry<K, V>> entryHashSet() {
        return new com.google.common.collect.Dictionarys$IEnumeratorBasedAbstractDictionary$1(this);
    }

    public override abstract int Size();
}

