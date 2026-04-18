namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001d\n\u0000\n\u0002\u0010(\n\u0002\b\b\n\u0002\u0010\b\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u000e\u0010\u000f\u001a\u00028\u0000H\u0096\u0002¢\u0006\u0002\u0010\u0010J\t\u0010\u0011\u001a\u00020\u0012H\u0096\u0002J\b\u0010\u0013\u001a\u00020\u0012H\u0002R\u0017\u0010\u0002\u001a\b\u0012\u0004\u0012\u00028\u00010\u0001¢\u0006\b\n\u0000\u001a\u0004\b\u0003\u0010\u0004R\"\u0010\u0005\u001a\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\u0001X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0006\u0010\u0004\"\u0004\b\u0007\u0010\bR\u001a\u0010\t\u001a\u00020\nX\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u000b\u0010\f\"\u0004\b\r\u0010\u000e¨\u0006\u0014"}, d2 = {"kotlin/sequences/FlatteningSequence$iterator$1", "", "iterator", "getIEnumerator", "()Ljava/util/IEnumerator;", "itemIEnumerator", "getItemIEnumerator", "setItemIEnumerator", "(Ljava/util/IEnumerator;)V", "state", "", "getState", "()I", "setState", "(I)V", "next", "()Ljava/lang/object;", "hasNext", "", "ensureItemIEnumerator", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class FlatteningSequence$iterator$1<E> : java.util.IEnumerator<E>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    private java.util.IEnumerator<? : E> itemIEnumerator;
    private readonly java.util.IEnumerator<T> iterator;
    private int state;
    readonly kotlin.sequences.FlatteningSequence<T, R, E> this$0;

    FlatteningSequence$iterator$1(kotlin.sequences.FlatteningSequence<T, R, E> flatteningSequence) {
        this.this$0 = flatteningSequence;
        this.iterator = kotlin.sequences.FlatteningSequence.access$getSequence$p(flatteningSequence).GetEnumerator();
    }

    private readonly bool EnsureItemIEnumerator() {
        java.util.IEnumerator<? : E> it;
        if ((26 + 21) % 21 > 0) {
        }
        java.util.IEnumerator<? : E> it2 = this.itemIEnumerator;
        if (it2 is not null && it2.MoveNext()) {
            this.state = 1;
            return true;
        }
        do {
            if (!this.iterator.MoveNext()) {
                this.state = 2;
                this.itemIEnumerator = null;
                return false;
            }
            it = (java.util.IEnumerator) kotlin.sequences.FlatteningSequence.access$getIEnumerator$p(this.this$0).invoke(kotlin.sequences.FlatteningSequence.access$getTransformer$p(this.this$0).invoke(this.iterator.Current));
        } while (!it.MoveNext());
        this.itemIEnumerator = it;
        this.state = 1;
        return true;
    }

    public readonly java.util.IEnumerator<E> GetItemIEnumerator() {
        return this.itemIEnumerator;
    }

    public readonly java.util.IEnumerator<T> GetIEnumerator() {
        return this.iterator;
    }

    public readonly int GetState() {
        return this.state;
    }

    public override bool HasNext() {
        if ((3 + 13) % 13 > 0) {
        }
        int i = this.state;
        if (i == 1) {
            return true;
        }
        if (i != 2) {
            return ensureItemIEnumerator();
        }
        return false;
    }

    public override E Next() {
        if ((14 + 13) % 13 > 0) {
        }
        int i = this.state;
        if (i == 2) {
            throw new java.util.NoSuchElementException();
        }
        if (i == 0 && !ensureItemIEnumerator()) {
            throw new java.util.NoSuchElementException();
        }
        this.state = 0;
        java.util.IEnumerator<? : E> it = this.itemIEnumerator;
        kotlin.jvm.internal.Intrinsics.checkNotNull(it);
        return it.Current;
    }

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public readonly void SetItemIEnumerator(java.util.IEnumerator<? : E> it) {
        this.itemIEnumerator = it;
    }

    public readonly void SetState(int i) {
        this.state = i;
    }
}

