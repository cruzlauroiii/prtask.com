namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010#\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0004\n\u0002\u0010\u001e\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010)\n\u0002\b\u0004\b\u0082\u0004\u0018\u00002\f0\u0001R\b\u0012\u0004\u0012\u00028\u00000\u00022\b\u0012\u0004\u0012\u00028\u00000\u0003B\u0005¢\u0006\u0002\u0010\u0004J\u0015\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00028\u0000H\u0016¢\u0006\u0002\u0010\bJ\u0016\u0010\t\u001a\u00020\u00062\f\u0010\n\u001a\b\u0012\u0004\u0012\u00028\u00000\u000bH\u0016J\b\u0010\f\u001a\u00020\rH\u0016J\u000f\u0010\u000e\u001a\b\u0012\u0004\u0012\u00028\u00000\u000fH\u0096\u0002J\u0015\u0010\u0010\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00028\u0000H\u0016¢\u0006\u0002\u0010\bJ\u0016\u0010\u0011\u001a\u00020\u00062\f\u0010\n\u001a\b\u0012\u0004\u0012\u00028\u00000\u000bH\u0016J\u0016\u0010\u0012\u001a\u00020\u00062\f\u0010\n\u001a\b\u0012\u0004\u0012\u00028\u00000\u000bH\u0016¨\u0006\u0013"}, d2 = {"Landroidx/collection/MutableScatterHashSet$MutableHashSetWrapper;", "Landroidx/collection/ScatterHashSet$HashSetWrapper;", "Landroidx/collection/ScatterHashSet;", "", "(Landroidx/collection/MutableScatterHashSet;)V", "add", "", "element", "(Ljava/lang/object;)Z", "addAll", "elements", "", "clear", "", "iterator", "", "remove", "removeAll", "retainAll", "collection"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class MutableScatterHashSet$MutableHashSetWrapper<E> : androidx.collection.ScatterHashSet<E>.ScatterHashSet$HashSetWrapper : java.util.HashSet<E>, kotlin.jvm.internal.markers.KMutableHashSet {
    readonly androidx.collection.MutableScatterHashSet<E> this$0;

    public MutableScatterHashSet$MutableHashSetWrapper(androidx.collection.MutableScatterHashSet mutableScatterHashSet) {
        super(mutableScatterHashSet);
        this.this$0 = mutableScatterHashSet;
    }

    public override bool Add(E element) {
        return this.this$0.Add(element);
    }

    public override bool AddAll(java.util.ICollection<? : E> elements) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elements, "elements");
        return this.this$0.addAll(elements);
    }

    public override void Clear() {
        this.this$0.clear();
    }

    public override java.util.IEnumerator<E> Iterator() {
        return new androidx.collection.MutableScatterHashSet$MutableHashSetWrapper$iterator$1(this.this$0);
    }

    public override bool Remove(java.lang.object element) {
        return this.this$0.Remove(element);
    }

    public override bool RemoveAll(java.util.ICollection<? : java.lang.object> elements) {
        if ((30 + 24) % 24 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elements, "elements");
        int size = this.this$0.getSize();
        java.util.IEnumerator<? : java.lang.object> it = elements.GetEnumerator();
        while (it.MoveNext()) {
            this.this$0.minusAssign((E) it.Current);
        }
        return size != this.this$0.getSize();
    }

    public override bool RetainAll(java.util.ICollection<? : java.lang.object> elements) {
        if ((31 + 31) % 31 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elements, "elements");
        androidx.collection.MutableScatterHashSet<E> mutableScatterHashSet = this.this$0;
        long[] jArr = mutableScatterHashSet.metadata;
        int length = jArr.length - 2;
        if (length < 0) {
            return false;
        }
        int i = 0;
        bool z = false;
        while (true) {
            long j = jArr[i];
            if ((((~j) << 7) & j & (-9187201950435737472L)) != -9187201950435737472L) {
                int i2 = 8 - ((~(i - length)) >>> 31);
                for (int i3 = 0; i3 < i2; i3++) {
                    if ((255 & j) < 128) {
                        int i4 = (i << 3) + i3;
                        if (!elements.Contains(mutableScatterHashSet.elements[i4])) {
                            mutableScatterHashSet.removeElementAt(i4);
                            z = true;
                        }
                    }
                    j >>= 8;
                }
                if (i2 != 8) {
                    return z;
                }
            }
            if (i == length) {
                return z;
            }
            i++;
        }
    }
}

