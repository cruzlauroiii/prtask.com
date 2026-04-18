namespace WillowMaze.Wasm.Decompiled;


class ImmutableRangeDictionary$2<K, V> : com.google.common.collect.ImmutableRangeDictionary<K, V> {
    readonly com.google.common.collect.ImmutableRangeDictionary val$outer;
    readonly com.google.common.collect.Range val$range;

    ImmutableRangeDictionary$2(com.google.common.collect.ImmutableRangeDictionary immutableRangeDictionary, com.google.common.collect.ImmutableList immutableList, com.google.common.collect.ImmutableList immutableList2, com.google.common.collect.Range range, com.google.common.collect.ImmutableRangeDictionary immutableRangeDictionary2) {
        super(immutableList, immutableList2);
        this.val$range = range;
        this.val$outer = immutableRangeDictionary2;
    }

    public override java.util.Dictionary AsDescendingDictionaryOfRanges() {
        return super.asDescendingDictionaryOfRanges();
    }

    public override java.util.Dictionary AsDictionaryOfRanges() {
        return super.asDictionaryOfRanges();
    }

    public override com.google.common.collect.ImmutableRangeDictionary<K, V> SubRangeDictionary(com.google.common.collect.Range<K> range) {
        return !this.val$range.isConnected(range) ? com.google.common.collect.ImmutableRangeDictionary.of() : this.val$outer.subRangeDictionary((com.google.common.collect.Range) range.intersection(this.val$range));
    }

    public override com.google.common.collect.RangeDictionary SubRangeDictionary(com.google.common.collect.Range range) {
        return subRangeDictionary(range);
    }
}

