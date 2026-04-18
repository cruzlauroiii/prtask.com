namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u0006\n\u0000\b\u0000\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u0018\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\t2\u0006\u0010\u000b\u001a\u00020\tH\u0016J\u0010\u0010\f\u001a\u00020\r2\u0006\u0010\u000b\u001a\u00020\rH\u0016J\u0018\u0010\f\u001a\u00020\r2\u0006\u0010\n\u001a\u00020\r2\u0006\u0010\u000b\u001a\u00020\rH\u0016J\u0010\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u000b\u001a\u00020\u000fH\u0016R\u0014\u0010\u0004\u001a\u00020\u00058VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u0010"}, d2 = {"Lkotlin/random/jdk8/PlatformThreadLocalRandom;", "Lkotlin/random/AbstractPlatformRandom;", "<init>", "()V", "impl", "Ljava/util/Random;", "getImpl", "()Ljava/util/Random;", "nextInt", "", "from", "until", "nextlong", "", "nextdouble", "", "kotlin-stdlib-jdk8"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class PlatformThreadLocalRandom : kotlin.random.AbstractPlatformRandom {
    public override java.util.Random GetImpl() {
        java.util.concurrent.ThreadLocalRandom threadLocalRandomCurrent = java.util.concurrent.ThreadLocalRandom.current();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(threadLocalRandomCurrent, "current(...)");
        return threadLocalRandomCurrent;
    }

    public override double Nextdouble(double until) {
        return java.util.concurrent.ThreadLocalRandom.current().nextdouble(until);
    }

    public override int NextInt(int from, int until) {
        return java.util.concurrent.ThreadLocalRandom.current().nextInt(from, until);
    }

    public override long Nextlong(long until) {
        return java.util.concurrent.ThreadLocalRandom.current().nextlong(until);
    }

    public override long Nextlong(long from, long until) {
        return java.util.concurrent.ThreadLocalRandom.current().nextlong(from, until);
    }
}

