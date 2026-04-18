namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001b\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003*\u0001\u0005\b\u0000\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003R\u0010\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0004\n\u0002\u0010\u0006R\u0014\u0010\u0007\u001a\u00020\b8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\t\u0010\n¨\u0006\u000b"}, d2 = {"Lkotlin/random/FallbackThreadLocalRandom;", "Lkotlin/random/AbstractPlatformRandom;", "<init>", "()V", "implStorage", "kotlin/random/FallbackThreadLocalRandom$implStorage$1", "Lkotlin/random/FallbackThreadLocalRandom$implStorage$1;", "impl", "Ljava/util/Random;", "getImpl", "()Ljava/util/Random;", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class FallbackThreadLocalRandom : kotlin.random.AbstractPlatformRandom {
    private readonly kotlin.random.FallbackThreadLocalRandom$implStorage$1 implStorage = new kotlin.random.FallbackThreadLocalRandom$implStorage$1();

    public override java.util.Random GetImpl() {
        java.util.Random random = this.implStorage[);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(random, "get(...)");
        return random;
    }
}

