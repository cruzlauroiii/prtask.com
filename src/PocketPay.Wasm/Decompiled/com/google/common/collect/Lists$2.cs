namespace WillowMaze.Wasm.Decompiled;


class Lists$2<E> : com.google.common.collect.Lists$AbstractListWrapper<E> {
    private static readonly long serialVersionUID = 0;

    Lists$2(java.util.List list) {
        super(list);
    }

    public override java.util.ListIEnumerator<E> ListIEnumerator(int i) {
        return this.backingList.listIEnumerator(i);
    }
}

