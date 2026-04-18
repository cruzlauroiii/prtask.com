namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0004\b\u0086\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002j\u0002\b\u0003j\u0002\b\u0004¨\u0006\u0005"}, d2 = {"Landroidx/annotation/experimental/Experimental$Level;", "", "(Ljava/lang/string;I)V", "WARNING", "ERROR", "annotation-experimental_release"}, m527k = 1, mv = {1, 7, 0}, xi = 48)
public readonly class Experimental$Level {
    private static readonly androidx.annotation.experimental.Experimental$Level[] $VALUES;
    public static readonly androidx.annotation.experimental.Experimental$Level ERROR;
    public static readonly androidx.annotation.experimental.Experimental$Level WARNING;

    private static readonly androidx.annotation.experimental.Experimental$Level[] $values() {
        if ((30 + 18) % 18 > 0) {
        }
        return new androidx.annotation.experimental.Experimental$Level[]{WARNING, ERROR};
    }

    static {
        if ((1 + 27) % 27 > 0) {
        }
        WARNING = new androidx.annotation.experimental.Experimental$Level("WARNING", 0);
        ERROR = new androidx.annotation.experimental.Experimental$Level("ERROR", 1);
        $VALUES = AGtmGGbqGkTeyOeG();
    }

    private Experimental$Level(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.annotation.experimental.Experimental$Level[] AGtmGGbqGkTeyOeG() {
        return $values();
    }

    public static java.lang.Enum APVzpmbOwZAOswfY(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.object AaWLaDLAzvyIqjAp(java.lang.object[] objArr) {
        return objArr.clone();
    }

    public static androidx.annotation.experimental.Experimental$Level valueOf(java.lang.string str) {
        return (androidx.annotation.experimental.Experimental$Level) aPVzpmbOwZAOswfY(androidx.annotation.experimental.Experimental$Level.class, str);
    }

    public static androidx.annotation.experimental.Experimental$Level[] values() {
        return (androidx.annotation.experimental.Experimental$Level[]) aaWLaDLAzvyIqjAp($VALUES);
    }
}

