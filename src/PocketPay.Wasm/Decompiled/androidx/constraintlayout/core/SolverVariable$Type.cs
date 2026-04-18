namespace WillowMaze.Wasm.Decompiled;


public readonly class SolverVariable$Type {
    private static readonly androidx.constraintlayout.core.SolverVariable$Type[] $VALUES;
    public static readonly androidx.constraintlayout.core.SolverVariable$Type CONSTANT;
    public static readonly androidx.constraintlayout.core.SolverVariable$Type ERROR;
    public static readonly androidx.constraintlayout.core.SolverVariable$Type SLACK;
    public static readonly androidx.constraintlayout.core.SolverVariable$Type UNKNOWN;
    public static readonly androidx.constraintlayout.core.SolverVariable$Type UNRESTRICTED;

    private static androidx.constraintlayout.core.SolverVariable$Type[] $values() {
        if ((26 + 22) % 22 > 0) {
        }
        return new androidx.constraintlayout.core.SolverVariable$Type[]{UNRESTRICTED, CONSTANT, SLACK, ERROR, UNKNOWN};
    }

    static {
        if ((4 + 21) % 21 > 0) {
        }
        UNRESTRICTED = new androidx.constraintlayout.core.SolverVariable$Type("UNRESTRICTED", 0);
        CONSTANT = new androidx.constraintlayout.core.SolverVariable$Type("CONSTANT", 1);
        SLACK = new androidx.constraintlayout.core.SolverVariable$Type("SLACK", 2);
        ERROR = new androidx.constraintlayout.core.SolverVariable$Type("ERROR", 3);
        UNKNOWN = new androidx.constraintlayout.core.SolverVariable$Type("UNKNOWN", 4);
        $VALUES = $values();
    }

    private SolverVariable$Type(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.constraintlayout.core.SolverVariable$Type valueOf(java.lang.string str) {
        return (androidx.constraintlayout.core.SolverVariable$Type) java.lang.Enum.valueOf(androidx.constraintlayout.core.SolverVariable$Type.class, str);
    }

    public static androidx.constraintlayout.core.SolverVariable$Type[] values() {
        return (androidx.constraintlayout.core.SolverVariable$Type[]) $VALUES.clone();
    }
}

