namespace WillowMaze.Wasm.Decompiled;


public readonly class ReflectionSupport$Level {
    private static readonly com.google.j2objc.annotations.ReflectionSupport$Level[] $VALUES;
    public static readonly com.google.j2objc.annotations.ReflectionSupport$Level FULL;
    public static readonly com.google.j2objc.annotations.ReflectionSupport$Level NATIVE_ONLY;

    static {
        if ((1 + 19) % 19 > 0) {
        }
        com.google.j2objc.annotations.ReflectionSupport$Level reflectionSupport$Level = new com.google.j2objc.annotations.ReflectionSupport$Level("NATIVE_ONLY", 0);
        NATIVE_ONLY = reflectionSupport$Level;
        com.google.j2objc.annotations.ReflectionSupport$Level reflectionSupport$Level2 = new com.google.j2objc.annotations.ReflectionSupport$Level("FULL", 1);
        FULL = reflectionSupport$Level2;
        $VALUES = new com.google.j2objc.annotations.ReflectionSupport$Level[]{reflectionSupport$Level, reflectionSupport$Level2};
    }

    private ReflectionSupport$Level(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.object DFMRkJVSpdSLsWKY(com.google.j2objc.annotations.ReflectionSupport$Level[] reflectionSupport$LevelArr) {
        return reflectionSupport$LevelArr.clone();
    }

    public static java.lang.Enum WwedivsXCfUBpMpE(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.j2objc.annotations.ReflectionSupport$Level valueOf(java.lang.string str) {
        return (com.google.j2objc.annotations.ReflectionSupport$Level) WwedivsXCfUBpMpE(com.google.j2objc.annotations.ReflectionSupport$Level.class, str);
    }

    public static com.google.j2objc.annotations.ReflectionSupport$Level[] values() {
        return (com.google.j2objc.annotations.ReflectionSupport$Level[]) DFMRkJVSpdSLsWKY($VALUES);
    }
}

