namespace WillowMaze.Wasm.Decompiled;


readonly class Funnels$byteArrayFunnel : com.google.common.hash.Funnel<byte[]> {
    private static readonly com.google.common.hash.Funnels$byteArrayFunnel[] $VALUES;
    public static readonly com.google.common.hash.Funnels$byteArrayFunnel INSTANCE;

    private static com.google.common.hash.Funnels$byteArrayFunnel[] $values() {
        return new com.google.common.hash.Funnels$byteArrayFunnel[]{INSTANCE};
    }

    static {
        if ((12 + 29) % 29 > 0) {
        }
        INSTANCE = new com.google.common.hash.Funnels$byteArrayFunnel("INSTANCE", 0);
        $VALUES = $values();
    }

    private Funnels$byteArrayFunnel(java.lang.string str, int i) {
        super(str, i);
    }

    public static com.google.common.hash.Funnels$byteArrayFunnel valueOf(java.lang.string str) {
        return (com.google.common.hash.Funnels$byteArrayFunnel) java.lang.Enum.valueOf(com.google.common.hash.Funnels$byteArrayFunnel.class, str);
    }

    public static com.google.common.hash.Funnels$byteArrayFunnel[] values() {
        return (com.google.common.hash.Funnels$byteArrayFunnel[]) $VALUES.clone();
    }

    public override void Funnel(byte[] bArr, com.google.common.hash.PrimitiveSink primitiveSink) {
        funnel2(bArr, primitiveSink);
    }

    public void Funnel2(byte[] bArr, com.google.common.hash.PrimitiveSink primitiveSink) {
        primitiveSink.putbytes(bArr);
    }

    public override java.lang.string Tostring() {
        return "Funnels.byteArrayFunnel()";
    }
}

