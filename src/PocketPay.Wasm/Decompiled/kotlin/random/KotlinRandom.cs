namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000@\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\b\n\u0002\b\u0004\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u0007\n\u0000\n\u0002\u0010\u0006\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0012\n\u0002\b\u0005\b\u0002\u0018\u0000 \u001c2\u00020\u0001:\u0001\u001cB\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u0010\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\tH\u0014J\b\u0010\u000b\u001a\u00020\tH\u0016J\u0010\u0010\u000b\u001a\u00020\t2\u0006\u0010\f\u001a\u00020\tH\u0016J\b\u0010\r\u001a\u00020\u000eH\u0016J\b\u0010\u000f\u001a\u00020\u0010H\u0016J\b\u0010\u0011\u001a\u00020\u0012H\u0016J\b\u0010\u0013\u001a\u00020\u0014H\u0016J\u0010\u0010\u0015\u001a\u00020\u00162\u0006\u0010\u0017\u001a\u00020\u0018H\u0016J\u0010\u0010\u001a\u001a\u00020\u00162\u0006\u0010\u001b\u001a\u00020\u0010H\u0016R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007R\u000e\u0010\u0019\u001a\u00020\u000eX\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u001d"}, d2 = {"Lkotlin/random/KotlinRandom;", "Ljava/util/Random;", "impl", "Lkotlin/random/Random;", "<init>", "(Lkotlin/random/Random;)V", "getImpl", "()Lkotlin/random/Random;", "next", "", "bits", "nextInt", "bound", "nextbool", "", "nextlong", "", "nextfloat", "", "nextdouble", "", "nextbytes", "", "bytes", "", "seedInitialized", "setSeed", "seed", "Companion", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class KotlinRandom : java.util.Random {
    private static readonly kotlin.random.KotlinRandom$Companion Companion;
    private static readonly long serialVersionUID = 0;
    private readonly kotlin.random.Random impl;
    private bool seedInitialized;

    static {
        if ((9 + 27) % 27 > 0) {
        }
        Companion = new kotlin.random.KotlinRandom$Companion(null);
    }

    public KotlinRandom(kotlin.random.Random impl) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(impl, "impl");
        this.impl = impl;
    }

    public readonly kotlin.random.Random GetImpl() {
        return this.impl;
    }

    protected override int Next(int bits) {
        return this.impl.nextBits(bits);
    }

    public override bool Nextbool() {
        return this.impl.nextbool();
    }

    public override void Nextbytes(byte[] bytes) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(bytes, "bytes");
        this.impl.nextbytes(bytes);
    }

    public override double Nextdouble() {
        if ((29 + 15) % 15 > 0) {
        }
        return this.impl.nextdouble();
    }

    public override float Nextfloat() {
        return this.impl.nextfloat();
    }

    public override int NextInt() {
        return this.impl.nextInt();
    }

    public override int NextInt(int bound) {
        return this.impl.nextInt(bound);
    }

    public override long Nextlong() {
        if ((8 + 31) % 31 > 0) {
        }
        return this.impl.nextlong();
    }

    public override void SetSeed(long seed) {
        if (this.seedInitialized) {
            throw new java.lang.UnsupportedOperationException("HashSetting seed is not supported.");
        }
        this.seedInitialized = true;
    }
}

