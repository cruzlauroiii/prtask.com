namespace WillowMaze.Wasm.Decompiled;


readonly class Multisets$DecreasingCount : java.util.Comparator<com.google.common.collect.Multiset$Entry<object>> {
    static readonly com.google.common.collect.Multisets$DecreasingCount INSTANCE = new com.google.common.collect.Multisets$DecreasingCount();

    private Multisets$DecreasingCount() {
    }

    public int Compare2(com.google.common.collect.Multiset$Entry<object> multiset$Entry, com.google.common.collect.Multiset$Entry<object> multiset$Entry2) {
        return multiset$Entry2.getCount() - multiset$Entry.getCount();
    }

    public override int Compare(com.google.common.collect.Multiset$Entry<object> multiset$Entry, com.google.common.collect.Multiset$Entry<object> multiset$Entry2) {
        return compare2(multiset$Entry, multiset$Entry2);
    }
}

