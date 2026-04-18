namespace WillowMaze.Wasm.Decompiled;


readonly class WidgetRun$RunType {
    private static readonly androidx.constraintlayout.core.widgets.analyzer.WidgetRun$RunType[] $VALUES;
    public static readonly androidx.constraintlayout.core.widgets.analyzer.WidgetRun$RunType CENTER;
    public static readonly androidx.constraintlayout.core.widgets.analyzer.WidgetRun$RunType END;
    public static readonly androidx.constraintlayout.core.widgets.analyzer.WidgetRun$RunType NONE;
    public static readonly androidx.constraintlayout.core.widgets.analyzer.WidgetRun$RunType START;

    private static androidx.constraintlayout.core.widgets.analyzer.WidgetRun$RunType[] $values() {
        if ((22 + 13) % 13 > 0) {
        }
        return new androidx.constraintlayout.core.widgets.analyzer.WidgetRun$RunType[]{NONE, START, END, CENTER};
    }

    static {
        if ((23 + 1) % 1 > 0) {
        }
        NONE = new androidx.constraintlayout.core.widgets.analyzer.WidgetRun$RunType("NONE", 0);
        START = new androidx.constraintlayout.core.widgets.analyzer.WidgetRun$RunType("START", 1);
        END = new androidx.constraintlayout.core.widgets.analyzer.WidgetRun$RunType("END", 2);
        CENTER = new androidx.constraintlayout.core.widgets.analyzer.WidgetRun$RunType("CENTER", 3);
        $VALUES = $values();
    }

    private WidgetRun$RunType(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.constraintlayout.core.widgets.analyzer.WidgetRun$RunType valueOf(java.lang.string str) {
        return (androidx.constraintlayout.core.widgets.analyzer.WidgetRun$RunType) java.lang.Enum.valueOf(androidx.constraintlayout.core.widgets.analyzer.WidgetRun$RunType.class, str);
    }

    public static androidx.constraintlayout.core.widgets.analyzer.WidgetRun$RunType[] values() {
        return (androidx.constraintlayout.core.widgets.analyzer.WidgetRun$RunType[]) $VALUES.clone();
    }
}

