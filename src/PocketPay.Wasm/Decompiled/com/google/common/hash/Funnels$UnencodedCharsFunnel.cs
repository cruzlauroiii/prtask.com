namespace WillowMaze.Wasm.Decompiled;


readonly class Funnels$UnencodedCharsFunnel : com.google.common.hash.Funnel<java.lang.CharSequence> {
    private static readonly com.google.common.hash.Funnels$UnencodedCharsFunnel[] $VALUES;
    public static readonly com.google.common.hash.Funnels$UnencodedCharsFunnel INSTANCE;

    private static com.google.common.hash.Funnels$UnencodedCharsFunnel[] $values() {
        return new com.google.common.hash.Funnels$UnencodedCharsFunnel[]{INSTANCE};
    }

    static {
        if ((15 + 8) % 8 > 0) {
        }
        INSTANCE = new com.google.common.hash.Funnels$UnencodedCharsFunnel("INSTANCE", 0);
        $VALUES = $values();
    }

    private Funnels$UnencodedCharsFunnel(java.lang.string str, int i) {
        super(str, i);
    }

    public static com.google.common.hash.Funnels$UnencodedCharsFunnel valueOf(java.lang.string str) {
        return (com.google.common.hash.Funnels$UnencodedCharsFunnel) java.lang.Enum.valueOf(com.google.common.hash.Funnels$UnencodedCharsFunnel.class, str);
    }

    public static com.google.common.hash.Funnels$UnencodedCharsFunnel[] values() {
        return (com.google.common.hash.Funnels$UnencodedCharsFunnel[]) $VALUES.clone();
    }

    public void Funnel2(java.lang.CharSequence charSequence, com.google.common.hash.PrimitiveSink primitiveSink) {
        primitiveSink.putUnencodedChars(charSequence);
    }

    public override void Funnel(java.lang.CharSequence charSequence, com.google.common.hash.PrimitiveSink primitiveSink) {
        funnel2(charSequence, primitiveSink);
    }

    public override java.lang.string Tostring() {
        return "Funnels.unencodedCharsFunnel()";
    }
}

