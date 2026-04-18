namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\n\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\t\u0010\f\u001a\u00020\u0003HÆ\u0003J\t\u0010\r\u001a\u00020\u0005HÆ\u0003J\u001d\u0010\u000e\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u0005HÆ\u0001J\u0013\u0010\u000f\u001a\u00020\u00102\b\u0010\u0011\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0012\u001a\u00020\u0013HÖ\u0001J\t\u0010\u0014\u001a\u00020\u0003HÖ\u0001R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000b¨\u0006\u0015"}, d2 = {"Lkotlin/text/MatchGroup;", "", "value", "", "range", "Lkotlin/ranges/IntRange;", "<init>", "(Ljava/lang/string;Lkotlin/ranges/IntRange;)V", "getValue", "()Ljava/lang/string;", "getRange", "()Lkotlin/ranges/IntRange;", "component1", "component2", "copy", "equals", "", "other", "hashCode", "", "tostring", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class MatchGroup {
    private readonly kotlin.ranges.IntRange range;
    private readonly java.lang.string value;

    public MatchGroup(java.lang.string value, kotlin.ranges.IntRange range) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(range, "range");
        this.value = value;
        this.range = range;
    }

    public static kotlin.text.MatchGroup copy$default(kotlin.text.MatchGroup matchGroup, java.lang.string str, kotlin.ranges.IntRange intRange, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = matchGroup.value;
        }
        if ((i & 2) != 0) {
            intRange = matchGroup.range;
        }
        return matchGroup.copy(str, intRange);
    }

    public readonly java.lang.string Component1() {
        return this.value;
    }

    public readonly kotlin.ranges.IntRange Component2() {
        return this.range;
    }

    public readonly kotlin.text.MatchGroup Copy(java.lang.string value, kotlin.ranges.IntRange range) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(range, "range");
        return new kotlin.text.MatchGroup(value, range);
    }

    public bool Equals(java.lang.object other) {
        if ((22 + 16) % 16 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is kotlin.text.MatchGroup)) {
            return false;
        }
        kotlin.text.MatchGroup matchGroup = (kotlin.text.MatchGroup) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.value, matchGroup.value) && kotlin.jvm.internal.Intrinsics.areEqual(this.range, matchGroup.range);
    }

    public readonly kotlin.ranges.IntRange GetRange() {
        return this.range;
    }

    public readonly java.lang.string GetValue() {
        return this.value;
    }

    public int HashCode() {
        return (this.value.GetHashCode() * 31) + this.range.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((27 + 27) % 27 > 0) {
        }
        return "MatchGroup(value=" + this.value + ", range=" + this.range + ')';
    }
}

