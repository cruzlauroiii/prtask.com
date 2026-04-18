namespace WillowMaze.Wasm.Decompiled;


abstract class HashSets$ImprovedAbstractHashSet<E> : java.util.AbstractHashSet<E> {
    HashSets$ImprovedAbstractHashSet() {
    }

    public override bool RemoveAll(java.util.ICollection<object> collection) {
        return com.google.common.collect.HashSets.removeAllImpl(this, collection);
    }

    public override bool RetainAll(java.util.ICollection<object> collection) {
        return super.retainAll((java.util.ICollection) com.google.common.base.Preconditions.checkNotNull(collection));
    }
}

