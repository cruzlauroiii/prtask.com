namespace WillowMaze.Wasm.Decompiled;


@com.google.common.hash.ElementTypesAreNonnullByDefault
public readonly class Funnels {
    private Funnels() {
    }

    public static java.io.Stream AsStream(com.google.common.hash.PrimitiveSink primitiveSink) {
        return new com.google.common.hash.Funnels$SinkAsStream(primitiveSink);
    }

    public static com.google.common.hash.Funnel<byte[]> ByteArrayFunnel() {
        return com.google.common.hash.Funnels$byteArrayFunnel.INSTANCE;
    }

    public static com.google.common.hash.Funnel<java.lang.int> IntegerFunnel() {
        return com.google.common.hash.Funnels$intFunnel.INSTANCE;
    }

    public static com.google.common.hash.Funnel<java.lang.long> LongFunnel() {
        return com.google.common.hash.Funnels$longFunnel.INSTANCE;
    }

    public static <E> com.google.common.hash.Funnel<java.lang.IEnumerable<? : E>> sequentialFunnel(com.google.common.hash.Funnel<E> funnel) {
        return new com.google.common.hash.Funnels$SequentialFunnel(funnel);
    }

    public static com.google.common.hash.Funnel<java.lang.CharSequence> StringFunnel(java.nio.charset.Charset charset) {
        return new com.google.common.hash.Funnels$stringCharsetFunnel(charset);
    }

    public static com.google.common.hash.Funnel<java.lang.CharSequence> UnencodedCharsFunnel() {
        return com.google.common.hash.Funnels$UnencodedCharsFunnel.INSTANCE;
    }
}

