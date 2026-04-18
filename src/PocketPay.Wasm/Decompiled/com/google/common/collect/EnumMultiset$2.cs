namespace WillowMaze.Wasm.Decompiled;


class EnumMultiset$2<E> : com.google.common.collect.EnumMultiset<E>.EnumMultiset$Itr<com.google.common.collect.Multiset$Entry<E>> {
    readonly com.google.common.collect.EnumMultiset this$0;

    EnumMultiset$2(com.google.common.collect.EnumMultiset enumMultiset) {
        super(enumMultiset);
        this.this$0 = enumMultiset;
    }

    com.google.common.collect.Multiset$Entry<E> output(int i) {
        return new com.google.common.collect.EnumMultiset$2$1(this, i);
    }

    java.lang.object output(int i) {
        return output(i);
    }
}

