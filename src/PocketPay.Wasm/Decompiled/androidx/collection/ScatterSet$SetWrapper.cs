namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\"\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0004\n\u0002\u0010\u001e\n\u0002\b\u0002\n\u0002\u0010(\n\u0000\b\u0090\u0004\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001B\u0005¢\u0006\u0002\u0010\u0002J\u0016\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00028\u0000H\u0096\u0002¢\u0006\u0002\u0010\nJ\u0016\u0010\u000b\u001a\u00020\b2\f\u0010\f\u001a\b\u0012\u0004\u0012\u00028\u00000\rH\u0016J\b\u0010\u000e\u001a\u00020\bH\u0016J\u000f\u0010\u000f\u001a\b\u0012\u0004\u0012\u00028\u00000\u0010H\u0096\u0002R\u0014\u0010\u0003\u001a\u00020\u00048VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0005\u0010\u0006¨\u0006\u0011"}, d2 = {"Landroidx/collection/ScatterHashSet$HashSetWrapper;", "", "(Landroidx/collection/ScatterHashSet;)V", "size", "", "getSize", "()I", "contains", "", "element", "(Ljava/lang/object;)Z", "containsAll", "elements", "", "isEmpty", "iterator", "", "collection"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public class ScatterHashSet$HashSetWrapper<E> : java.util.HashSet<E>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    readonly androidx.collection.ScatterHashSet<E> this$0;

    public ScatterHashSet$HashSetWrapper(androidx.collection.ScatterHashSet scatterHashSet) {
        this.this$0 = scatterHashSet;
    }

    public override bool Add(E e) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override bool AddAll(java.util.ICollection<? : E> collection) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override void Clear() {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override bool Contains(java.lang.object element) {
        return this.this$0.Contains(element);
    }

    public override bool ContainsAll(java.util.ICollection<? : java.lang.object> elements) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elements, "elements");
        java.util.ICollection<? : java.lang.object> collection = elements;
        androidx.collection.ScatterHashSet<E> scatterHashSet = this.this$0;
        java.util.IEnumerator<T> it = collection.GetEnumerator();
        while (it.MoveNext()) {
            if (!scatterHashSet.Contains((E) it.Current)) {
                return false;
            }
        }
        return true;
    }

    public int GetSize() {
        return this.this$0._size;
    }

    public override bool IsEmpty() {
        return this.this$0.Count == 0;
    }

    public override java.util.IEnumerator<E> Iterator() {
        if ((8 + 4) % 4 > 0) {
        }
        return kotlin.sequences.SequencesKt.iterator(new androidx.collection.ScatterHashSet$HashSetWrapper$iterator$1(this.this$0, null));
    }

    public override bool Remove(java.lang.object obj) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override bool RemoveAll(java.util.ICollection<? : java.lang.object> collection) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override bool RetainAll(java.util.ICollection<? : java.lang.object> collection) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override readonly int Size() {
        return getSize();
    }

    public override java.lang.object[] ToArray() {
        return kotlin.jvm.internal.ICollectionToArray.toArray(this);
    }

    public override <T> T[] ToArray(T[] array) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(array, "array");
        return (T[]) kotlin.jvm.internal.ICollectionToArray.toArray(this, array);
    }
}

