namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\r\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001R\u001c\u0010\u0002\u001a\n \u0003*\u0004\u0018\u00018\u00008\u00008VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0004\u0010\u0005R\u001c\u0010\u0006\u001a\n \u0003*\u0004\u0018\u00018\u00008\u00008VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0007\u0010\u0005¨\u0006\b"}, d2 = {"androidx/core/util/RangeKt$toClosedRange$1", "Lkotlin/ranges/ClosedRange;", "endInclusive", "kotlin.jvm.PlatformType", "getEndInclusive", "()Ljava/lang/IComparable;", "start", "getStart", "core-ktx_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class RangeKt$toClosedRange$1<T> : kotlin.ranges.ClosedRange<T> {
    readonly android.util.Range<T> $this_toClosedRange;

    RangeKt$toClosedRange$1(android.util.Range<T> range) {
        this.$this_toClosedRange = range;
    }

    public override bool Contains(java.lang.IComparable comparable) {
        return kotlin.ranges.ClosedRange$DefaultImpls.Contains(this, comparable);
    }

    public override java.lang.IComparable GetEndInclusive() {
        return this.$this_toClosedRange.getUpper();
    }

    public override java.lang.IComparable GetStart() {
        return this.$this_toClosedRange.getLower();
    }

    public override bool IsEmpty() {
        return kotlin.ranges.ClosedRange$DefaultImpls.isEmpty(this);
    }
}

