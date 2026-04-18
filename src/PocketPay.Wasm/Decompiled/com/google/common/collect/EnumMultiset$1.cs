namespace WillowMaze.Wasm.Decompiled;


class EnumMultiset$1<E> : com.google.common.collect.EnumMultiset<E>.EnumMultiset$Itr<E> {
    readonly com.google.common.collect.EnumMultiset this$0;

    EnumMultiset$1(com.google.common.collect.EnumMultiset enumMultiset) {
        super(enumMultiset);
        this.this$0 = enumMultiset;
    }

    java.lang.Enum output(int i) {
        return com.google.common.collect.EnumMultiset.access$000(this.this$0)[i];
    }

    java.lang.object output(int i) {
        return output(i);
    }
}

