namespace WillowMaze.Wasm.Decompiled;


class ImmutableList$Itr<E> : com.google.common.collect.AbstractIndexedListIEnumerator<E> {
    private readonly com.google.common.collect.ImmutableList<E> list;

    ImmutableList$Itr(com.google.common.collect.ImmutableList<E> immutableList, int i) {
        super(immutableList.Count, i);
        this.list = immutableList;
    }

    protected override E Get(int i) {
        return this.list[i);
    }
}

