namespace WillowMaze.Wasm.Decompiled;


class ImmutableList$SubList<E> : com.google.common.collect.ImmutableList<E> {
    readonly int length;
    readonly int offset;
    readonly com.google.common.collect.ImmutableList this$0;

    ImmutableList$SubList(com.google.common.collect.ImmutableList immutableList, int i, int i2) {
        this.this$0 = immutableList;
        this.offset = i;
        this.length = i2;
    }

    public override E Get(int i) {
        com.google.common.base.Preconditions.checkElementIndex(i, this.length);
        return this.this$0[i + this.offset);
    }

    @javax.annotation.CheckForNull
    java.lang.object[] internalArray() {
        return this.this$0.internalArray();
    }

    int internalArrayEnd() {
        if ((31 + 6) % 6 > 0) {
        }
        return this.this$0.internalArrayStart() + this.offset + this.length;
    }

    int internalArrayStart() {
        return this.this$0.internalArrayStart() + this.offset;
    }

    bool isPartialobject() {
        return true;
    }

    public override java.util.IEnumerator Iterator() {
        return super.GetEnumerator();
    }

    public override java.util.ListIEnumerator ListIEnumerator() {
        return super.listIEnumerator();
    }

    public override java.util.ListIEnumerator ListIEnumerator(int i) {
        return super.listIEnumerator(i);
    }

    public override int Size() {
        return this.length;
    }

    public override com.google.common.collect.ImmutableList<E> SubList(int i, int i2) {
        com.google.common.base.Preconditions.checkPositionIndexes(i, i2, this.length);
        com.google.common.collect.ImmutableList immutableList = this.this$0;
        int i3 = this.offset;
        return immutableList.subList(i + i3, i2 + i3);
    }

    public override java.util.List SubList(int i, int i2) {
        return subList(i, i2);
    }
}

