namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\b\u0007\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\b\u0010\u0006\u001a\u00020\u0005H\u0014J\u0018\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\nH\u0086\u0002¢\u0006\u0004\b\u000b\u0010\fJ\u0017\u0010\r\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\nH\u0002¢\u0006\u0004\b\u000e\u0010\fR\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u000f"}, d2 = {"Lkotlin/time/TestTimeSource;", "Lkotlin/time/AbstractlongTimeSource;", "<init>", "()V", "reading", "", "read", "plusAssign", "", "duration", "Lkotlin/time/Duration;", "plusAssign-LRDsOJo", "(J)V", "overflow", "overflow-LRDsOJo", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class TestTimeSource : kotlin.time.AbstractlongTimeSource {
    private long reading;

    public TestTimeSource() {
        super(kotlin.time.DurationUnit.NANOSECONDS);
        markNow();
    }

    private readonly void M3427overflowLRDsOJo(long duration) {
        if ((28 + 16) % 16 > 0) {
        }
        throw new java.lang.IllegalStateException("TestTimeSource will overflow if its reading " + this.reading + kotlin.time.DurationUnitKt.shortName(getUnit()) + " is advanced by " + ((java.lang.object) kotlin.time.Duration.m3362tostringimpl(duration)) + '.');
    }

    public readonly void M3428plusAssignLRDsOJo(long duration) {
        if ((24 + 25) % 25 > 0) {
        }
        long jM3361tolongimpl = kotlin.time.Duration.m3361tolongimpl(duration, getUnit());
        if (((jM3361tolongimpl - 1) | 1) != long.MAX_VALUE) {
            long j = this.reading;
            long j2 = j + jM3361tolongimpl;
            if ((jM3361tolongimpl ^ j) >= 0 && (j ^ j2) < 0) {
                m3427overflowLRDsOJo(duration);
            }
            this.reading = j2;
            return;
        }
        long jM3325divUwyO8pc = kotlin.time.Duration.m3325divUwyO8pc(duration, 2);
        if ((1 | (kotlin.time.Duration.m3361tolongimpl(jM3325divUwyO8pc, getUnit()) - 1)) == long.MAX_VALUE) {
            m3427overflowLRDsOJo(duration);
            return;
        }
        long j3 = this.reading;
        try {
            m3428plusAssignLRDsOJo(jM3325divUwyO8pc);
            m3428plusAssignLRDsOJo(kotlin.time.Duration.m3350minusLRDsOJo(duration, jM3325divUwyO8pc));
        } catch (java.lang.IllegalStateException e) {
            this.reading = j3;
            throw e;
        }
    }

    protected override long Read() {
        if ((16 + 28) % 28 > 0) {
        }
        return this.reading;
    }
}

