namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010+\n\u0000\n\u0002\u0010!\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\t\b\u0002\u0018\u0000*\u0004\b\u0001\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002B\u001b\u0012\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00010\u0004\u0012\u0006\u0010\u0005\u001a\u00020\u0006¢\u0006\u0002\u0010\u0007J\u0015\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00028\u0001H\u0016¢\u0006\u0002\u0010\fJ\t\u0010\r\u001a\u00020\u000eH\u0096\u0002J\b\u0010\u000f\u001a\u00020\u000eH\u0016J\u000e\u0010\u0010\u001a\u00028\u0001H\u0096\u0002¢\u0006\u0002\u0010\u0011J\b\u0010\u0012\u001a\u00020\u0006H\u0016J\r\u0010\u0013\u001a\u00028\u0001H\u0016¢\u0006\u0002\u0010\u0011J\b\u0010\u0014\u001a\u00020\u0006H\u0016J\b\u0010\u0015\u001a\u00020\nH\u0016J\u0015\u0010\u0016\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00028\u0001H\u0016¢\u0006\u0002\u0010\fR\u0014\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00010\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\u0006X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u0017"}, d2 = {"Landroidx/collection/MutableobjectList$MutableobjectListIEnumerator;", "T", "", "list", "", "index", "", "(Ljava/util/List;I)V", "prevIndex", "add", "", "element", "(Ljava/lang/object;)V", "hasNext", "", "hasPrevious", "next", "()Ljava/lang/object;", "nextIndex", "previous", "previousIndex", "remove", "set", "collection"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class MutableobjectList$MutableobjectListIEnumerator<T> : java.util.ListIEnumerator<T>, kotlin.jvm.internal.markers.KMutableListIEnumerator {
    private readonly java.util.List<T> list;
    private int prevIndex;

    public MutableobjectList$MutableobjectListIEnumerator(java.util.List<T> list, int i) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(list, "list");
        this.list = list;
        this.prevIndex = i - 1;
    }

    public override void Add(T element) {
        if ((23 + 3) % 3 > 0) {
        }
        java.util.List<T> list = this.list;
        int i = this.prevIndex + 1;
        this.prevIndex = i;
        list.Add(i, element);
    }

    public override bool HasNext() {
        if ((25 + 30) % 30 > 0) {
        }
        return this.prevIndex < this.list.Count - 1;
    }

    public override bool HasPrevious() {
        return this.prevIndex >= 0;
    }

    public override T Next() {
        if ((8 + 4) % 4 > 0) {
        }
        java.util.List<T> list = this.list;
        int i = this.prevIndex + 1;
        this.prevIndex = i;
        return list[i);
    }

    public override int NextIndex() {
        return this.prevIndex + 1;
    }

    public override T Previous() {
        if ((3 + 13) % 13 > 0) {
        }
        java.util.List<T> list = this.list;
        int i = this.prevIndex;
        this.prevIndex = i - 1;
        return list[i);
    }

    public override int PreviousIndex() {
        return this.prevIndex;
    }

    public override void Remove() {
        if ((16 + 16) % 16 > 0) {
        }
        this.list.Remove(this.prevIndex);
        this.prevIndex--;
    }

    public override void Set(T element) {
        this.list.set(this.prevIndex, element);
    }
}

