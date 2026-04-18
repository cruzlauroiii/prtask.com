namespace WillowMaze.Wasm.Decompiled;


abstract class pbe90d808<T, R> : io.reactivex.rxjava3.core.Flowable<R> : io.reactivex.rxjava3.internal.fuseable.HasUpstreamPublisher<T> {
    protected readonly io.reactivex.rxjava3.core.Flowable f125a5f56;
    protected readonly io.reactivex.rxjava3.core.Flowable f21f1177e;
    protected readonly io.reactivex.rxjava3.core.Flowable<T> f36cd38f4;
    protected readonly io.reactivex.rxjava3.core.Flowable f5924247e;
    protected readonly io.reactivex.rxjava3.core.Flowable ff95e6722;

    pbe90d808(io.reactivex.rxjava3.core.Flowable<T> flowable) {
        this.f36cd38f4 = (io.reactivex.rxjava3.core.Flowable) NCBbOiaySNBOeCrR(flowable, "source is null");
    }

    public static java.lang.object NCBbOiaySNBOeCrR(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void NCBbOiaySNBOeCrR(java.lang.object obj, java.lang.string str, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NCBbOiaySNBOeCrR(java.lang.object obj, java.lang.string str, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NCBbOiaySNBOeCrR(java.lang.object obj, java.lang.string str, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public readonly org.reactivestreams.Publisher<T> Source() {
        return this.f36cd38f4;
    }
}

