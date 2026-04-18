namespace WillowMaze.Wasm.Decompiled;


class EnumMultiset$2$1<E> : com.google.common.collect.Multisets$AbstractEntry<E> {
    readonly com.google.common.collect.EnumMultiset$2 this$1;
    readonly int val$index;

    EnumMultiset$2$1(com.google.common.collect.EnumMultiset$2 enumMultiset$2, int i) {
        this.this$1 = enumMultiset$2;
        this.val$index = i;
    }

    public override int GetCount() {
        return com.google.common.collect.EnumMultiset.access$100(this.this$1.this$0)[this.val$index];
    }

    public override java.lang.Enum GetElement() {
        return com.google.common.collect.EnumMultiset.access$000(this.this$1.this$0)[this.val$index];
    }

    public override java.lang.object GetElement() {
        return getElement();
    }
}

