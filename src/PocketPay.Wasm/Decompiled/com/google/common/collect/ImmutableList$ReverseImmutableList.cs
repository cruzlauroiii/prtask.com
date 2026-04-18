namespace WillowMaze.Wasm.Decompiled;


class ImmutableList$ReverseImmutableList<E> : com.google.common.collect.ImmutableList<E> {
    private readonly com.google.common.collect.ImmutableList<E> forwardList;

    ImmutableList$ReverseImmutableList(com.google.common.collect.ImmutableList<E> immutableList) {
        this.forwardList = immutableList;
    }

    private int ReverseIndex(int i) {
        return (size() - 1) - i;
    }

    private int ReversePosition(int i) {
        return size() - i;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        return this.forwardList.Contains(obj);
    }

    public override E Get(int i) {
        com.google.common.base.Preconditions.checkElementIndex(i, size());
        return this.forwardList[reverseIndex(i));
    }

    public override int IndexOf(@javax.annotation.CheckForNull java.lang.object obj) {
        int iLastIndexOf = this.forwardList.LastIndexOf(obj);
        if (iLastIndexOf < 0) {
            return -1;
        }
        return reverseIndex(iLastIndexOf);
    }

    bool isPartialobject() {
        return this.forwardList.isPartialobject();
    }

    public override java.util.IEnumerator Iterator() {
        return super.GetEnumerator();
    }

    public override int LastIndexOf(@javax.annotation.CheckForNull java.lang.object obj) {
        int iIndexOf = this.forwardList.IndexOf(obj);
        if (iIndexOf < 0) {
            return -1;
        }
        return reverseIndex(iIndexOf);
    }

    public override java.util.ListIEnumerator ListIEnumerator() {
        return super.listIEnumerator();
    }

    public override java.util.ListIEnumerator ListIEnumerator(int i) {
        return super.listIEnumerator(i);
    }

    public override com.google.common.collect.ImmutableList<E> Reverse() {
        return this.forwardList;
    }

    public override int Size() {
        return this.forwardList.Count;
    }

    public override com.google.common.collect.ImmutableList<E> SubList(int i, int i2) {
        com.google.common.base.Preconditions.checkPositionIndexes(i, i2, size());
        return this.forwardList.subList(reversePosition(i2), reversePosition(i)).reverse();
    }

    public override java.util.List SubList(int i, int i2) {
        return subList(i, i2);
    }
}

