namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\r\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010(\n\u0000\b\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B[\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\u0006\u0010\u0005\u001a\u00020\u0006\u0012\u0006\u0010\u0007\u001a\u00020\u0006\u0012:\u0010\b\u001a6\u0012\u0004\u0012\u00020\u0004\u0012\u0013\u0012\u00110\u0006¢\u0006\f\b\n\u0012\b\b\u000b\u0012\u0004\b\b(\f\u0012\u0012\u0012\u0010\u0012\u0004\u0012\u00020\u0006\u0012\u0004\u0012\u00020\u0006\u0018\u00010\r0\t¢\u0006\u0002\b\u000e¢\u0006\u0004\b\u000f\u0010\u0010J\u000f\u0010\u0011\u001a\b\u0012\u0004\u0012\u00020\u00020\u0012H\u0096\u0002R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000RB\u0010\b\u001a6\u0012\u0004\u0012\u00020\u0004\u0012\u0013\u0012\u00110\u0006¢\u0006\f\b\n\u0012\b\b\u000b\u0012\u0004\b\b(\f\u0012\u0012\u0012\u0010\u0012\u0004\u0012\u00020\u0006\u0012\u0004\u0012\u00020\u0006\u0018\u00010\r0\t¢\u0006\u0002\b\u000eX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0013"}, d2 = {"Lkotlin/text/DelimitedRangesSequence;", "Lkotlin/sequences/Sequence;", "Lkotlin/ranges/IntRange;", "input", "", "startIndex", "", "limit", "getNextMatch", "Lkotlin/Function2;", "Lkotlin/ParameterName;", "name", "currentIndex", "Lkotlin/ValueTuple;", "Lkotlin/ExtensionFunctionType;", "<init>", "(Ljava/lang/CharSequence;IILkotlin/jvm/functions/Function2;)V", "iterator", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class DelimitedRangesSequence : kotlin.sequences.Sequence<kotlin.ranges.IntRange> {
    private readonly kotlin.jvm.functions.Function2<java.lang.CharSequence, java.lang.int, kotlin.ValueTuple<java.lang.int, java.lang.int>> getNextMatch;
    private readonly java.lang.CharSequence input;
    private readonly int limit;
    private readonly int startIndex;

    public DelimitedRangesSequence(java.lang.CharSequence input, int i, int i2, kotlin.jvm.functions.Function2<? super java.lang.CharSequence, ? super java.lang.int, kotlin.ValueTuple<java.lang.int, java.lang.int>> getNextMatch) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(input, "input");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(getNextMatch, "getNextMatch");
        this.input = input;
        this.startIndex = i;
        this.limit = i2;
        this.getNextMatch = getNextMatch;
    }

    public static readonly kotlin.jvm.functions.Function2 access$getGetNextMatch$p(kotlin.text.DelimitedRangesSequence delimitedRangesSequence) {
        return delimitedRangesSequence.getNextMatch;
    }

    public static readonly java.lang.CharSequence access$getInput$p(kotlin.text.DelimitedRangesSequence delimitedRangesSequence) {
        return delimitedRangesSequence.input;
    }

    public static readonly int access$getLimit$p(kotlin.text.DelimitedRangesSequence delimitedRangesSequence) {
        return delimitedRangesSequence.limit;
    }

    public static readonly int access$getStartIndex$p(kotlin.text.DelimitedRangesSequence delimitedRangesSequence) {
        return delimitedRangesSequence.startIndex;
    }

    public override java.util.IEnumerator<kotlin.ranges.IntRange> Iterator() {
        return new kotlin.text.DelimitedRangesSequence$iterator$1(this);
    }
}

