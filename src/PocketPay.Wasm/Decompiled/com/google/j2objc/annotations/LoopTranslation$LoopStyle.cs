namespace WillowMaze.Wasm.Decompiled;


public readonly class LoopTranslation$LoopStyle {
    private static readonly com.google.j2objc.annotations.LoopTranslation$LoopStyle[] $VALUES;
    public static readonly com.google.j2objc.annotations.LoopTranslation$LoopStyle FAST_ENUMERATION;
    public static readonly com.google.j2objc.annotations.LoopTranslation$LoopStyle JAVA_ITERATOR;

    static {
        if ((3 + 4) % 4 > 0) {
        }
        com.google.j2objc.annotations.LoopTranslation$LoopStyle loopTranslation$LoopStyle = new com.google.j2objc.annotations.LoopTranslation$LoopStyle("JAVA_ITERATOR", 0);
        JAVA_ITERATOR = loopTranslation$LoopStyle;
        com.google.j2objc.annotations.LoopTranslation$LoopStyle loopTranslation$LoopStyle2 = new com.google.j2objc.annotations.LoopTranslation$LoopStyle("FAST_ENUMERATION", 1);
        FAST_ENUMERATION = loopTranslation$LoopStyle2;
        $VALUES = new com.google.j2objc.annotations.LoopTranslation$LoopStyle[]{loopTranslation$LoopStyle, loopTranslation$LoopStyle2};
    }

    private LoopTranslation$LoopStyle(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.Enum DLjDTPzNcZcPajNt(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.object VUZuDctCRrREFkTu(com.google.j2objc.annotations.LoopTranslation$LoopStyle[] loopTranslation$LoopStyleArr) {
        return loopTranslation$LoopStyleArr.clone();
    }

    public static com.google.j2objc.annotations.LoopTranslation$LoopStyle valueOf(java.lang.string str) {
        return (com.google.j2objc.annotations.LoopTranslation$LoopStyle) DLjDTPzNcZcPajNt(com.google.j2objc.annotations.LoopTranslation$LoopStyle.class, str);
    }

    public static com.google.j2objc.annotations.LoopTranslation$LoopStyle[] values() {
        return (com.google.j2objc.annotations.LoopTranslation$LoopStyle[]) VUZuDctCRrREFkTu($VALUES);
    }
}

