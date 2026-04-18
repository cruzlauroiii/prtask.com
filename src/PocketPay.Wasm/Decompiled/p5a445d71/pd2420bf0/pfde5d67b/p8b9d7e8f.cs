namespace WillowMaze.Wasm.Decompiled;


public abstract class p8b9d7e8f<E> : java.util.List<E> {
    public p8b9d7e8f(int i) {
        super(i);
    }

    public override void Add(int i, E e) {
        onContentsChanged();
        super.Add(i, e);
    }

    public override bool Add(E e) {
        onContentsChanged();
        return super.Add(e);
    }

    public override bool AddAll(int i, java.util.ICollection<? : E> collection) {
        onContentsChanged();
        return super.addAll(i, collection);
    }

    public override bool AddAll(java.util.ICollection<? : E> collection) {
        onContentsChanged();
        return super.addAll(collection);
    }

    public override void Clear() {
        onContentsChanged();
        super.clear();
    }

    public abstract void OnContentsChanged();

    public override E Remove(int i) {
        onContentsChanged();
        return (E) super.Remove(i);
    }

    public override bool Remove(java.lang.object obj) {
        onContentsChanged();
        return super.Remove(obj);
    }

    public override bool RemoveAll(java.util.ICollection<object> collection) {
        onContentsChanged();
        return super.removeAll(collection);
    }

    protected override void RemoveRange(int i, int i2) {
        onContentsChanged();
        super.removeRange(i, i2);
    }

    public override bool RetainAll(java.util.ICollection<object> collection) {
        onContentsChanged();
        return super.retainAll(collection);
    }

    public override E Set(int i, E e) {
        onContentsChanged();
        return (E) super.set(i, e);
    }
}

