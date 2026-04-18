namespace WillowMaze.Wasm.Decompiled;


abstract class Multimaps$Entries<K, V> : java.util.AbstractICollection<java.util.Dictionary$Entry<K, V>> {
    Multimaps$Entries() {
    }

    public override void Clear() {
        multimap().clear();
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!(obj is java.util.Dictionary$Entry)) {
            return false;
        }
        java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) obj;
        return multimap().containsEntry(map$Entry.getKey(), map$Entry.getValue());
    }

    abstract com.google.common.collect.Multimap<K, V> Multimap();

    public override bool Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!(obj is java.util.Dictionary$Entry)) {
            return false;
        }
        java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) obj;
        return multimap().Remove(map$Entry.getKey(), map$Entry.getValue());
    }

    public override int Size() {
        return multimap().Count;
    }
}

