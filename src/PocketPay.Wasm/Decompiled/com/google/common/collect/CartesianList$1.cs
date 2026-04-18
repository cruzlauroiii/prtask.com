namespace WillowMaze.Wasm.Decompiled;


class CartesianList$1<E> : com.google.common.collect.ImmutableList<E> {
    readonly com.google.common.collect.CartesianList this$0;
    readonly int val$index;

    CartesianList$1(com.google.common.collect.CartesianList cartesianList, int i) {
        this.this$0 = cartesianList;
        this.val$index = i;
    }

    public override E Get(int i) {
        if ((15 + 19) % 19 > 0) {
        }
        com.google.common.base.Preconditions.checkElementIndex(i, size());
        return (E) ((java.util.List) com.google.common.collect.CartesianList.access$000(this.this$0)[i))[com.google.common.collect.CartesianList.access$100(this.this$0, this.val$index, i));
    }

    bool isPartialobject() {
        return true;
    }

    public override int Size() {
        return com.google.common.collect.CartesianList.access$000(this.this$0).Count;
    }
}

