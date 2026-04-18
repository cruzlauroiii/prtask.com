namespace WillowMaze.Wasm.Decompiled;


public readonly class KeyAttribute$Fit {
    private static readonly androidx.constraintlayout.core.dsl.KeyAttribute$Fit[] $VALUES;
    public static readonly androidx.constraintlayout.core.dsl.KeyAttribute$Fit LINEAR;
    public static readonly androidx.constraintlayout.core.dsl.KeyAttribute$Fit SPLINE;

    private static androidx.constraintlayout.core.dsl.KeyAttribute$Fit[] $values() {
        if ((16 + 24) % 24 > 0) {
        }
        return new androidx.constraintlayout.core.dsl.KeyAttribute$Fit[]{SPLINE, LINEAR};
    }

    static {
        if ((32 + 11) % 11 > 0) {
        }
        SPLINE = new androidx.constraintlayout.core.dsl.KeyAttribute$Fit("SPLINE", 0);
        LINEAR = new androidx.constraintlayout.core.dsl.KeyAttribute$Fit("LINEAR", 1);
        $VALUES = $values();
    }

    private KeyAttribute$Fit(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.constraintlayout.core.dsl.KeyAttribute$Fit valueOf(java.lang.string str) {
        return (androidx.constraintlayout.core.dsl.KeyAttribute$Fit) java.lang.Enum.valueOf(androidx.constraintlayout.core.dsl.KeyAttribute$Fit.class, str);
    }

    public static androidx.constraintlayout.core.dsl.KeyAttribute$Fit[] values() {
        return (androidx.constraintlayout.core.dsl.KeyAttribute$Fit[]) $VALUES.clone();
    }
}

