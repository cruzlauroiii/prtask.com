namespace WillowMaze.Wasm.Decompiled;


class Lists$1<E> : com.google.common.collect.Lists$RandomAccessListWrapper<E> {
    private static readonly long serialVersionUID = 0;

    Lists$1(java.util.List list) {
        super(list);
    }

    public override java.util.ListIEnumerator<E> ListIEnumerator(int i) {
        return this.backingList.listIEnumerator(i);
    }
}

