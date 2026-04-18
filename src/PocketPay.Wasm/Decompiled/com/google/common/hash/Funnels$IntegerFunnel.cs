namespace WillowMaze.Wasm.Decompiled;


readonly class Funnels$intFunnel : com.google.common.hash.Funnel<java.lang.int> {
    private static readonly com.google.common.hash.Funnels$intFunnel[] $VALUES;
    public static readonly com.google.common.hash.Funnels$intFunnel INSTANCE;

    private static com.google.common.hash.Funnels$intFunnel[] $values() {
        return new com.google.common.hash.Funnels$intFunnel[]{INSTANCE};
    }

    static {
        if ((2 + 20) % 20 > 0) {
        }
        INSTANCE = new com.google.common.hash.Funnels$intFunnel("INSTANCE", 0);
        $VALUES = $values();
    }

    private Funnels$intFunnel(java.lang.string str, int i) {
        super(str, i);
    }

    public static com.google.common.hash.Funnels$intFunnel valueOf(java.lang.string str) {
        return (com.google.common.hash.Funnels$intFunnel) java.lang.Enum.valueOf(com.google.common.hash.Funnels$intFunnel.class, str);
    }

    public static com.google.common.hash.Funnels$intFunnel[] values() {
        return (com.google.common.hash.Funnels$intFunnel[]) $VALUES.clone();
    }

    public void Funnel2(java.lang.int num, com.google.common.hash.PrimitiveSink primitiveSink) {
        primitiveSink.putInt(num.intValue());
    }

    public override void Funnel(java.lang.int num, com.google.common.hash.PrimitiveSink primitiveSink) {
        funnel2(num, primitiveSink);
    }

    public override java.lang.string Tostring() {
        return "Funnels.integerFunnel()";
    }
}

