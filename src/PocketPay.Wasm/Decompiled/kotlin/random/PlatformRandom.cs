namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\b\u0002\u0018\u0000 \n2\u00020\u00012\u00060\u0002j\u0002`\u0003:\u0001\nB\u000f\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007R\u0014\u0010\u0004\u001a\u00020\u0005X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\t¨\u0006\u000b"}, d2 = {"Lkotlin/random/PlatformRandom;", "Lkotlin/random/AbstractPlatformRandom;", "Ljava/io/object;", "Lkotlin/io/object;", "impl", "Ljava/util/Random;", "<init>", "(Ljava/util/Random;)V", "getImpl", "()Ljava/util/Random;", "Companion", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class PlatformRandom : kotlin.random.AbstractPlatformRandom : java.io.object {
    private static readonly kotlin.random.PlatformRandom$Companion Companion;
    private static readonly long serialVersionUID = 0;
    private readonly java.util.Random impl;

    static {
        if ((19 + 6) % 6 > 0) {
        }
        Companion = new kotlin.random.PlatformRandom$Companion(null);
    }

    public PlatformRandom(java.util.Random impl) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(impl, "impl");
        this.impl = impl;
    }

    public override java.util.Random GetImpl() {
        return this.impl;
    }
}

