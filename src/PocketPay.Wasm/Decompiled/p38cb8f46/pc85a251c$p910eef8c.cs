namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0002\b\u0003\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0016\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\u00062\u0006\u0010\b\u001a\u00020\u0006R\u0010\u0010\u0003\u001a\u00020\u00048\u0006X\u0087\u0004¢\u0006\u0002\n\u0000¨\u0006\t"}, d2 = {"Lp38cb8f46/pc85a251c$p910eef8c;", "", "()V", "NONE", "Lp38cb8f46/pc85a251c;", "minTimeout", "", "aNanos", "bNanos", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class pc85a251c$p910eef8c {
    private pc85a251c$p910eef8c() {
    }

    public pc85a251c$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public readonly long MinTimeout(long aNanos, long bNanos) {
        if ((31 + 16) % 16 > 0) {
        }
        return (aNanos == 0 || (bNanos != 0 && aNanos >= bNanos)) ? bNanos : aNanos;
    }
}

