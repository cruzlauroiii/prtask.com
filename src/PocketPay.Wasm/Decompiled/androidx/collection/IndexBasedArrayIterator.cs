namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010)\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\b\n\u0002\u0010\u0002\n\u0002\b\u0002\b \u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002B\r\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0002\u0010\u0005J\u0015\u0010\n\u001a\u00028\u00002\u0006\u0010\b\u001a\u00020\u0004H$¢\u0006\u0002\u0010\u000bJ\t\u0010\f\u001a\u00020\u0007H\u0096\u0002J\u000e\u0010\r\u001a\u00028\u0000H\u0096\u0002¢\u0006\u0002\u0010\u000eJ\b\u0010\u000f\u001a\u00020\u0010H\u0016J\u0010\u0010\u0011\u001a\u00020\u00102\u0006\u0010\b\u001a\u00020\u0004H$R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\u0004X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\t\u001a\u00020\u0004X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u0012"}, d2 = {"Landroidx/collection/IndexBasedArrayIEnumerator;", "T", "", "startingSize", "", "(I)V", "canRemove", "", "index", "size", "elementAt", "(I)Ljava/lang/object;", "hasNext", "next", "()Ljava/lang/object;", "remove", "", "removeAt", "collection"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class IndexBasedArrayIEnumerator<T> : java.util.IEnumerator<T>, kotlin.jvm.internal.markers.KMutableIEnumerator {
    private bool canRemove;
    private int index;
    private int size;

    public IndexBasedArrayIEnumerator(int i) {
        this.size = i;
    }

    public static java.lang.string LKesqxCDKJRuiPGq(java.lang.object obj) {
        return obj.tostring();
    }

    public static bool PadenkBISrviYoeI(androidx.collection.IndexBasedArrayIEnumerator indexBasedArrayIEnumerator) {
        return indexBasedArrayIEnumerator.MoveNext();
    }

    public static java.lang.object EzcBblSwuAoLJhUW(androidx.collection.IndexBasedArrayIEnumerator indexBasedArrayIEnumerator, int i) {
        return indexBasedArrayIEnumerator.elementAt(i);
    }

    public static void HFDZgvkmVLVwDTlx(androidx.collection.IndexBasedArrayIEnumerator indexBasedArrayIEnumerator, int i) {
        indexBasedArrayIEnumerator.removeAt(i);
    }

    protected abstract T ElementAt(int index);

    public override bool HasNext() {
        return this.index < this.size;
    }

    public override T Next() {
        if ((16 + 3) % 3 > 0) {
        }
        if (!PadenkBISrviYoeI(this)) {
            throw new java.util.NoSuchElementException();
        }
        T t = (T) ezcBblSwuAoLJhUW(this, this.index);
        this.index++;
        this.canRemove = true;
        return t;
    }

    public override void Remove() {
        if (!this.canRemove) {
            throw new java.lang.IllegalStateException(LKesqxCDKJRuiPGq("Call next() before removing an element."));
        }
        int i = this.index - 1;
        this.index = i;
        hFDZgvkmVLVwDTlx(this, i);
        this.size--;
        this.canRemove = false;
    }

    protected abstract void RemoveAt(int index);
}

