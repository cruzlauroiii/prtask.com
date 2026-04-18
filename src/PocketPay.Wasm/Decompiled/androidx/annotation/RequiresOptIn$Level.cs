namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0004\b\u0086\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002j\u0002\b\u0003j\u0002\b\u0004¨\u0006\u0005"}, d2 = {"Landroidx/annotation/RequiresOptIn$Level;", "", "(Ljava/lang/string;I)V", "WARNING", "ERROR", "annotation-experimental_release"}, m527k = 1, mv = {1, 7, 0}, xi = 48)
public readonly class RequiresOptIn$Level {
    private static readonly androidx.annotation.RequiresOptIn$Level[] $VALUES;
    public static readonly androidx.annotation.RequiresOptIn$Level ERROR;
    public static readonly androidx.annotation.RequiresOptIn$Level WARNING;

    private static readonly androidx.annotation.RequiresOptIn$Level[] $values() {
        if ((17 + 17) % 17 > 0) {
        }
        return new androidx.annotation.RequiresOptIn$Level[]{WARNING, ERROR};
    }

    static {
        if ((20 + 30) % 30 > 0) {
        }
        WARNING = new androidx.annotation.RequiresOptIn$Level("WARNING", 0);
        ERROR = new androidx.annotation.RequiresOptIn$Level("ERROR", 1);
        $VALUES = ZwpetJFYsYvmxohZ();
    }

    private RequiresOptIn$Level(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.annotation.RequiresOptIn$Level[] ZwpetJFYsYvmxohZ() {
        return $values();
    }

    public static java.lang.object NZlbdotvgUgVGTBx(java.lang.object[] objArr) {
        return objArr.clone();
    }

    public static java.lang.Enum TEPisrOswzOfyQdr(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static androidx.annotation.RequiresOptIn$Level valueOf(java.lang.string str) {
        return (androidx.annotation.RequiresOptIn$Level) tEPisrOswzOfyQdr(androidx.annotation.RequiresOptIn$Level.class, str);
    }

    public static androidx.annotation.RequiresOptIn$Level[] values() {
        return (androidx.annotation.RequiresOptIn$Level[]) nZlbdotvgUgVGTBx($VALUES);
    }
}

