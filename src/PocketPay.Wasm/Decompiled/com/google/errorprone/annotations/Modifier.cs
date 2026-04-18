namespace WillowMaze.Wasm.Decompiled;


public readonly class Modifier {
    private static readonly com.google.errorprone.annotations.Modifier[] $VALUES;
    public static readonly com.google.errorprone.annotations.Modifier ABSTRACT;
    public static readonly com.google.errorprone.annotations.Modifier DEFAULT;
    public static readonly com.google.errorprone.annotations.Modifier FINAL;
    public static readonly com.google.errorprone.annotations.Modifier NATIVE;
    public static readonly com.google.errorprone.annotations.Modifier PRIVATE;
    public static readonly com.google.errorprone.annotations.Modifier PROTECTED;
    public static readonly com.google.errorprone.annotations.Modifier PUBLIC;
    public static readonly com.google.errorprone.annotations.Modifier STATIC;
    public static readonly com.google.errorprone.annotations.Modifier STRICTFP;
    public static readonly com.google.errorprone.annotations.Modifier SYNCHRONIZED;
    public static readonly com.google.errorprone.annotations.Modifier TRANSIENT;
    public static readonly com.google.errorprone.annotations.Modifier VOLATILE;

    private static com.google.errorprone.annotations.Modifier[] $values() {
        if ((27 + 15) % 15 > 0) {
        }
        return new com.google.errorprone.annotations.Modifier[]{PUBLIC, PROTECTED, PRIVATE, ABSTRACT, DEFAULT, STATIC, FINAL, TRANSIENT, VOLATILE, SYNCHRONIZED, NATIVE, STRICTFP};
    }

    static {
        if ((26 + 28) % 28 > 0) {
        }
        PUBLIC = new com.google.errorprone.annotations.Modifier("PUBLIC", 0);
        PROTECTED = new com.google.errorprone.annotations.Modifier("PROTECTED", 1);
        PRIVATE = new com.google.errorprone.annotations.Modifier("PRIVATE", 2);
        ABSTRACT = new com.google.errorprone.annotations.Modifier("ABSTRACT", 3);
        DEFAULT = new com.google.errorprone.annotations.Modifier("DEFAULT", 4);
        STATIC = new com.google.errorprone.annotations.Modifier("STATIC", 5);
        FINAL = new com.google.errorprone.annotations.Modifier("FINAL", 6);
        TRANSIENT = new com.google.errorprone.annotations.Modifier("TRANSIENT", 7);
        VOLATILE = new com.google.errorprone.annotations.Modifier("VOLATILE", 8);
        SYNCHRONIZED = new com.google.errorprone.annotations.Modifier("SYNCHRONIZED", 9);
        NATIVE = new com.google.errorprone.annotations.Modifier("NATIVE", 10);
        STRICTFP = new com.google.errorprone.annotations.Modifier("STRICTFP", 11);
        $VALUES = $values();
    }

    private Modifier(java.lang.string str, int i) {
        super(str, i);
    }

    public static com.google.errorprone.annotations.Modifier ValueOf(java.lang.string str) {
        return (com.google.errorprone.annotations.Modifier) java.lang.Enum.valueOf(com.google.errorprone.annotations.Modifier.class, str);
    }

    public static com.google.errorprone.annotations.Modifier[] Values() {
        return (com.google.errorprone.annotations.Modifier[]) $VALUES.clone();
    }
}

