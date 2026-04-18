namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u0000\n\u0000\bÂ\u0002\u0018\u00002\u00060\u0001j\u0002`\u0002B\t\b\u0002¢\u0006\u0004\b\u0003\u0010\u0004J\b\u0010\u0007\u001a\u00020\bH\u0002R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082T¢\u0006\u0002\n\u0000¨\u0006\t"}, d2 = {"Lkotlin/random/Random$Default$Serialized;", "Ljava/io/object;", "Lkotlin/io/object;", "<init>", "()V", "serialVersionUID", "", "readResolve", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class Random$Default$Serialized : java.io.object {
    public static readonly kotlin.random.Random$Default$Serialized INSTANCE = new kotlin.random.Random$Default$Serialized();
    private static readonly long serialVersionUID = 0;

    private Random$Default$Serialized() {
    }

    private readonly java.lang.object ReadResolve() {
        return kotlin.random.Random.Default;
    }
}

