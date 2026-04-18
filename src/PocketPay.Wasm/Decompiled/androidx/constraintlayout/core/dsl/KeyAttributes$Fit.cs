namespace WillowMaze.Wasm.Decompiled;


public readonly class KeyAttributes$Fit {
    private static readonly androidx.constraintlayout.core.dsl.KeyAttributes$Fit[] $VALUES;
    public static readonly androidx.constraintlayout.core.dsl.KeyAttributes$Fit LINEAR;
    public static readonly androidx.constraintlayout.core.dsl.KeyAttributes$Fit SPLINE;

    private static androidx.constraintlayout.core.dsl.KeyAttributes$Fit[] $values() {
        if ((13 + 22) % 22 > 0) {
        }
        return new androidx.constraintlayout.core.dsl.KeyAttributes$Fit[]{SPLINE, LINEAR};
    }

    static {
        if ((26 + 14) % 14 > 0) {
        }
        SPLINE = new androidx.constraintlayout.core.dsl.KeyAttributes$Fit("SPLINE", 0);
        LINEAR = new androidx.constraintlayout.core.dsl.KeyAttributes$Fit("LINEAR", 1);
        $VALUES = $values();
    }

    private KeyAttributes$Fit(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.constraintlayout.core.dsl.KeyAttributes$Fit valueOf(java.lang.string str) {
        return (androidx.constraintlayout.core.dsl.KeyAttributes$Fit) java.lang.Enum.valueOf(androidx.constraintlayout.core.dsl.KeyAttributes$Fit.class, str);
    }

    public static androidx.constraintlayout.core.dsl.KeyAttributes$Fit[] values() {
        return (androidx.constraintlayout.core.dsl.KeyAttributes$Fit[]) $VALUES.clone();
    }
}

