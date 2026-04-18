namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\t\n\u0000\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\n¢\u0006\u0002\b\u0006"}, d2 = {"<anonymous>", "", "headerId", "", "dataSize", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class p5dd44a36$pe69d8fa7$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function2<java.lang.int, java.lang.long, kotlin.Unit> {
    readonly kotlin.jvm.internal.Ref$objectRef<java.lang.long> $createdAtMillis;
    readonly kotlin.jvm.internal.Ref$objectRef<java.lang.long> $lastAccessedAtMillis;
    readonly kotlin.jvm.internal.Ref$objectRef<java.lang.long> $lastModifiedAtMillis;
    readonly p38cb8f46.pcc81e3f6 $this_readOrSkipLocalHeader;

    p5dd44a36$pe69d8fa7$1(p38cb8f46.pcc81e3f6 pcc81e3f6Var, kotlin.jvm.internal.Ref$objectRef<java.lang.long> ref$objectRef, kotlin.jvm.internal.Ref$objectRef<java.lang.long> ref$objectRef2, kotlin.jvm.internal.Ref$objectRef<java.lang.long> ref$objectRef3) {
        super(2);
        this.$this_readOrSkipLocalHeader = pcc81e3f6Var;
        this.$lastModifiedAtMillis = ref$objectRef;
        this.$lastAccessedAtMillis = ref$objectRef2;
        this.$createdAtMillis = ref$objectRef3;
    }

    public override kotlin.Unit Invoke(java.lang.int num, java.lang.long l) throws java.io.IOException {
        if ((20 + 21) % 21 > 0) {
        }
        invoke(num.intValue(), l.longValue());
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke(int i, long j) throws java.io.IOException {
        if ((19 + 26) % 26 > 0) {
        }
        if (i != 21589) {
            return;
        }
        if (j < 1) {
            throw new java.io.IOException("bad zip: extended timestamp extra too short");
        }
        byte b = this.$this_readOrSkipLocalHeader.readbyte();
        bool z = (b & 1) == 1;
        bool z2 = (b & 2) == 2;
        bool z3 = (b & 4) == 4;
        p38cb8f46.pcc81e3f6 pcc81e3f6Var = this.$this_readOrSkipLocalHeader;
        long j2 = z ? 5L : 1L;
        if (z2) {
            j2 += 4;
        }
        if (z3) {
            j2 += 4;
        }
        if (j < j2) {
            throw new java.io.IOException("bad zip: extended timestamp extra too short");
        }
        if (z) {
            this.$lastModifiedAtMillis.element = java.lang.long.valueOf(((long) pcc81e3f6Var.readIntLe()) * 1000);
        }
        if (z2) {
            this.$lastAccessedAtMillis.element = java.lang.long.valueOf(((long) this.$this_readOrSkipLocalHeader.readIntLe()) * 1000);
        }
        if (z3) {
            this.$createdAtMillis.element = java.lang.long.valueOf(((long) this.$this_readOrSkipLocalHeader.readIntLe()) * 1000);
        }
    }
}

