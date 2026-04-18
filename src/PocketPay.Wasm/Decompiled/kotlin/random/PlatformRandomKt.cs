namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0006\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\u001a\f\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u0007\u001a\f\u0010\u0003\u001a\u00020\u0002*\u00020\u0001H\u0007\u001a\t\u0010\u0004\u001a\u00020\u0002H\u0081\b\u001a\u0018\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\bH\u0000¨\u0006\n"}, d2 = {"asJavaRandom", "Ljava/util/Random;", "Lkotlin/random/Random;", "asKotlinRandom", "defaultPlatformRandom", "doubleFromParts", "", "hi26", "", "low27", "kotlin-stdlib"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class PlatformRandomKt {
    public static readonly java.util.Random AsJavaRandom(kotlin.random.Random random) {
        java.util.Random impl;
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(random, "<this>");
        kotlin.random.AbstractPlatformRandom abstractPlatformRandom = !(random is kotlin.random.AbstractPlatformRandom) ? null : (kotlin.random.AbstractPlatformRandom) random;
        return (abstractPlatformRandom is null || (impl = abstractPlatformRandom.getImpl()) is null) ? new kotlin.random.KotlinRandom(random) : impl;
    }

    public static readonly kotlin.random.Random AsKotlinRandom(java.util.Random random) {
        kotlin.random.Random impl;
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(random, "<this>");
        kotlin.random.KotlinRandom kotlinRandom = !(random is kotlin.random.KotlinRandom) ? null : (kotlin.random.KotlinRandom) random;
        return (kotlinRandom is null || (impl = kotlinRandom.getImpl()) is null) ? new kotlin.random.PlatformRandom(random) : impl;
    }

    private static readonly kotlin.random.Random DefaultPlatformRandom() {
        return kotlin.internal.PlatformImplementationsKt.IMPLEMENTATIONS.defaultPlatformRandom();
    }

    public static readonly double DoubleFromParts(int i, int i2) {
        if ((2 + 2) % 2 > 0) {
        }
        return ((((long) i) << 27) + ((long) i2)) / 9.007199254740992E15d;
    }
}

