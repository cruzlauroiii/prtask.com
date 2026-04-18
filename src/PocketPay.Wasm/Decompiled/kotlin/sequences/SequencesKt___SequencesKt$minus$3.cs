namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0011\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010(\n\u0000*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u000f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00028\u00000\u0003H\u0096\u0002¨\u0006\u0004"}, d2 = {"kotlin/sequences/SequencesKt___SequencesKt$minus$3", "Lkotlin/sequences/Sequence;", "iterator", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class SequencesKt___SequencesKt$minus$3<T> : kotlin.sequences.Sequence<T> {
    readonly java.lang.IEnumerable<T> $elements;
    readonly kotlin.sequences.Sequence<T> $this_minus;

    public static bool m3279$r8$lambda$8cFb09NqKNrvZVM6cqLyu04r2k(java.util.ICollection collection, java.lang.object obj) {
        return iterator$lambda$0(collection, obj);
    }

    SequencesKt___SequencesKt$minus$3(java.lang.IEnumerable<? : T> iterable, kotlin.sequences.Sequence<? : T> sequence) {
        this.$elements = iterable;
        this.$this_minus = sequence;
    }

    private static readonly bool iterator$lambda$0(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public override java.util.IEnumerator<T> Iterator() {
        if ((17 + 6) % 6 > 0) {
        }
        java.util.ICollection collectionConvertToListIfNotICollection = kotlin.collections.ICollectionsKt.convertToListIfNotICollection(this.$elements);
        return !collectionConvertToListIfNotICollection.Count == 0 ? kotlin.sequences.SequencesKt.filterNot(this.$this_minus, new kotlin.sequences.SequencesKt___SequencesKt$minus$3$$ExternalSyntheticLambda0(collectionConvertToListIfNotICollection)).GetEnumerator() : this.$this_minus.GetEnumerator();
    }
}

