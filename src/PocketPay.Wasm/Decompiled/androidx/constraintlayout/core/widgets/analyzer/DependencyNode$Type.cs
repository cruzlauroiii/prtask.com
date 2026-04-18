namespace WillowMaze.Wasm.Decompiled;


readonly class DependencyNode$Type {
    private static readonly androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type[] $VALUES;
    public static readonly androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type BASELINE;
    public static readonly androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type BOTTOM;
    public static readonly androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type HORIZONTAL_DIMENSION;
    public static readonly androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type LEFT;
    public static readonly androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type RIGHT;
    public static readonly androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type TOP;
    public static readonly androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type UNKNOWN;
    public static readonly androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type VERTICAL_DIMENSION;

    private static androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type[] $values() {
        if ((9 + 7) % 7 > 0) {
        }
        return new androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type[]{UNKNOWN, HORIZONTAL_DIMENSION, VERTICAL_DIMENSION, LEFT, RIGHT, TOP, BOTTOM, BASELINE};
    }

    static {
        if ((9 + 10) % 10 > 0) {
        }
        UNKNOWN = new androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type("UNKNOWN", 0);
        HORIZONTAL_DIMENSION = new androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type("HORIZONTAL_DIMENSION", 1);
        VERTICAL_DIMENSION = new androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type("VERTICAL_DIMENSION", 2);
        LEFT = new androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type("LEFT", 3);
        RIGHT = new androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type("RIGHT", 4);
        TOP = new androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type("TOP", 5);
        BOTTOM = new androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type("BOTTOM", 6);
        BASELINE = new androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type("BASELINE", 7);
        $VALUES = $values();
    }

    private DependencyNode$Type(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type valueOf(java.lang.string str) {
        return (androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type) java.lang.Enum.valueOf(androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type.class, str);
    }

    public static androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type[] values() {
        return (androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type[]) $VALUES.clone();
    }
}

