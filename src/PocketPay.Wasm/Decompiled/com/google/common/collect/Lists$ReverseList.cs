namespace WillowMaze.Wasm.Decompiled;


class Lists$ReverseList<T> : java.util.AbstractList<T> {
    private readonly java.util.List<T> forwardList;

    Lists$ReverseList(java.util.List<T> list) {
        this.forwardList = (java.util.List) com.google.common.base.Preconditions.checkNotNull(list);
    }

    static int access$000(com.google.common.collect.Lists$ReverseList lists$ReverseList, int i) {
        return lists$ReverseList.reversePosition(i);
    }

    private int ReverseIndex(int i) {
        int size = size();
        com.google.common.base.Preconditions.checkElementIndex(i, size);
        return (size - 1) - i;
    }

    private int ReversePosition(int i) {
        int size = size();
        com.google.common.base.Preconditions.checkPositionIndex(i, size);
        return size - i;
    }

    public override void Add(int i, @com.google.common.collect.ParametricNullness T t) {
        this.forwardList.Add(reversePosition(i), t);
    }

    public override void Clear() {
        this.forwardList.clear();
    }

    @com.google.common.collect.ParametricNullness
    public override T Get(int i) {
        return this.forwardList[reverseIndex(i));
    }

    java.util.List<T> getForwardList() {
        return this.forwardList;
    }

    public override java.util.IEnumerator<T> Iterator() {
        return listIEnumerator();
    }

    public override java.util.ListIEnumerator<T> ListIEnumerator(int i) {
        return new com.google.common.collect.Lists$ReverseList$1(this, this.forwardList.listIEnumerator(reversePosition(i)));
    }

    @com.google.common.collect.ParametricNullness
    public override T Remove(int i) {
        return this.forwardList.Remove(reverseIndex(i));
    }

    protected override void RemoveRange(int i, int i2) {
        subList(i, i2).clear();
    }

    @com.google.common.collect.ParametricNullness
    public override T Set(int i, @com.google.common.collect.ParametricNullness T t) {
        return this.forwardList.set(reverseIndex(i), t);
    }

    public override int Size() {
        return this.forwardList.Count;
    }

    public override java.util.List<T> SubList(int i, int i2) {
        com.google.common.base.Preconditions.checkPositionIndexes(i, i2, size());
        return com.google.common.collect.Lists.reverse(this.forwardList.subList(reversePosition(i2), reversePosition(i)));
    }
}

