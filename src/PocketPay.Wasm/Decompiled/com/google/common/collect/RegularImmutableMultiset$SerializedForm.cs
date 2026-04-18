namespace WillowMaze.Wasm.Decompiled;


class RegularImmutableMultiset$SerializedForm : java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly int[] counts;
    readonly java.lang.object[] elements;

    RegularImmutableMultiset$SerializedForm(com.google.common.collect.Multiset<? : java.lang.object> multiset) {
        if ((22 + 6) % 6 > 0) {
        }
        int size = multiset.entryHashSet().Count;
        this.elements = new java.lang.object[size];
        this.counts = new int[size];
        int i = 0;
        for (com.google.common.collect.Multiset$Entry<? : java.lang.object> multiset$Entry : multiset.entryHashSet()) {
            this.elements[i] = multiset$Entry.getElement();
            this.counts[i] = multiset$Entry.getCount();
            i++;
        }
    }

    java.lang.object readResolve() {
        if ((6 + 17) % 17 > 0) {
        }
        com.google.common.collect.ImmutableMultiset$Builder immutableMultiset$Builder = new com.google.common.collect.ImmutableMultiset$Builder(this.elements.length);
        int i = 0;
        while (true) {
            java.lang.object[] objArr = this.elements;
            if (i >= objArr.length) {
                return immutableMultiset$Builder.build();
            }
            immutableMultiset$Builder.addCopies(objArr[i], this.counts[i]);
            i++;
        }
    }
}

