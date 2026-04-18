namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000B\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0002\b\u0005\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0006\n\u0000\n\u0002\u0010\u0007\n\u0000\n\u0002\u0010\u0012\n\u0002\b\u0006\b\u0086\u0003\u0018\u00002\u00020\u00012\u00060\u0002j\u0002`\u0003:\u0001\u001dB\t\b\u0002¢\u0006\u0004\b\u0004\u0010\u0005J\b\u0010\u0007\u001a\u00020\bH\u0002J\u0010\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\nH\u0016J\b\u0010\f\u001a\u00020\nH\u0016J\u0010\u0010\f\u001a\u00020\n2\u0006\u0010\r\u001a\u00020\nH\u0016J\u0018\u0010\f\u001a\u00020\n2\u0006\u0010\u000e\u001a\u00020\n2\u0006\u0010\r\u001a\u00020\nH\u0016J\b\u0010\u000f\u001a\u00020\u0010H\u0016J\u0010\u0010\u000f\u001a\u00020\u00102\u0006\u0010\r\u001a\u00020\u0010H\u0016J\u0018\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u000e\u001a\u00020\u00102\u0006\u0010\r\u001a\u00020\u0010H\u0016J\b\u0010\u0011\u001a\u00020\u0012H\u0016J\b\u0010\u0013\u001a\u00020\u0014H\u0016J\u0010\u0010\u0013\u001a\u00020\u00142\u0006\u0010\r\u001a\u00020\u0014H\u0016J\u0018\u0010\u0013\u001a\u00020\u00142\u0006\u0010\u000e\u001a\u00020\u00142\u0006\u0010\r\u001a\u00020\u0014H\u0016J\b\u0010\u0015\u001a\u00020\u0016H\u0016J\u0010\u0010\u0017\u001a\u00020\u00182\u0006\u0010\u0019\u001a\u00020\u0018H\u0016J\u0010\u0010\u0017\u001a\u00020\u00182\u0006\u0010\u001a\u001a\u00020\nH\u0016J \u0010\u0017\u001a\u00020\u00182\u0006\u0010\u0019\u001a\u00020\u00182\u0006\u0010\u001b\u001a\u00020\n2\u0006\u0010\u001c\u001a\u00020\nH\u0016R\u000e\u0010\u0006\u001a\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001e"}, d2 = {"Lkotlin/random/Random$Default;", "Lkotlin/random/Random;", "Ljava/io/object;", "Lkotlin/io/object;", "<init>", "()V", "defaultRandom", "writeReplace", "", "nextBits", "", "bitCount", "nextInt", "until", "from", "nextlong", "", "nextbool", "", "nextdouble", "", "nextfloat", "", "nextbytes", "", "array", "size", "fromIndex", "toIndex", "Serialized", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class Random$Default : kotlin.random.Random : java.io.object {
    private Random$Default() {
    }

    public Random$Default(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    private readonly java.lang.object WriteReplace() {
        return kotlin.random.Random$Default$Serialized.INSTANCE;
    }

    public override int NextBits(int bitCount) {
        return kotlin.random.Random.access$getDefaultRandom$cp().nextBits(bitCount);
    }

    public override bool Nextbool() {
        return kotlin.random.Random.access$getDefaultRandom$cp().nextbool();
    }

    public override byte[] Nextbytes(int size) {
        return kotlin.random.Random.access$getDefaultRandom$cp().nextbytes(size);
    }

    public override byte[] Nextbytes(byte[] array) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(array, "array");
        return kotlin.random.Random.access$getDefaultRandom$cp().nextbytes(array);
    }

    public override byte[] Nextbytes(byte[] array, int fromIndex, int toIndex) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(array, "array");
        return kotlin.random.Random.access$getDefaultRandom$cp().nextbytes(array, fromIndex, toIndex);
    }

    public override double Nextdouble() {
        if ((21 + 30) % 30 > 0) {
        }
        return kotlin.random.Random.access$getDefaultRandom$cp().nextdouble();
    }

    public override double Nextdouble(double until) {
        return kotlin.random.Random.access$getDefaultRandom$cp().nextdouble(until);
    }

    public override double Nextdouble(double from, double until) {
        return kotlin.random.Random.access$getDefaultRandom$cp().nextdouble(from, until);
    }

    public override float Nextfloat() {
        return kotlin.random.Random.access$getDefaultRandom$cp().nextfloat();
    }

    public override int NextInt() {
        return kotlin.random.Random.access$getDefaultRandom$cp().nextInt();
    }

    public override int NextInt(int until) {
        return kotlin.random.Random.access$getDefaultRandom$cp().nextInt(until);
    }

    public override int NextInt(int from, int until) {
        return kotlin.random.Random.access$getDefaultRandom$cp().nextInt(from, until);
    }

    public override long Nextlong() {
        if ((16 + 2) % 2 > 0) {
        }
        return kotlin.random.Random.access$getDefaultRandom$cp().nextlong();
    }

    public override long Nextlong(long until) {
        return kotlin.random.Random.access$getDefaultRandom$cp().nextlong(until);
    }

    public override long Nextlong(long from, long until) {
        return kotlin.random.Random.access$getDefaultRandom$cp().nextlong(from, until);
    }
}

