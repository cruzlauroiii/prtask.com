namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u000b\b\u0080\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002j\u0002\b\u0003j\u0002\b\u0004j\u0002\b\u0005j\u0002\b\u0006j\u0002\b\u0007j\u0002\b\bj\u0002\b\tj\u0002\b\nj\u0002\b\u000b¨\u0006\f"}, d2 = {"Landroidx/fragment/app/strictmode/objectStrictMode$Flag;", "", "(Ljava/lang/string;I)V", "PENALTY_LOG", "PENALTY_DEATH", "DETECT_FRAGMENT_REUSE", "DETECT_FRAGMENT_TAG_USAGE", "DETECT_WRONG_NESTED_HIERARCHY", "DETECT_RETAIN_INSTANCE_USAGE", "DETECT_SET_USER_VISIBLE_HINT", "DETECT_TARGET_FRAGMENT_USAGE", "DETECT_WRONG_FRAGMENT_CONTAINER", "fragment_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class objectStrictMode$Flag {
    private static readonly androidx.fragment.app.strictmode.objectStrictMode$Flag[] $VALUES;
    public static readonly androidx.fragment.app.strictmode.objectStrictMode$Flag DETECT_FRAGMENT_REUSE;
    public static readonly androidx.fragment.app.strictmode.objectStrictMode$Flag DETECT_FRAGMENT_TAG_USAGE;
    public static readonly androidx.fragment.app.strictmode.objectStrictMode$Flag DETECT_RETAIN_INSTANCE_USAGE;
    public static readonly androidx.fragment.app.strictmode.objectStrictMode$Flag DETECT_SET_USER_VISIBLE_HINT;
    public static readonly androidx.fragment.app.strictmode.objectStrictMode$Flag DETECT_TARGET_FRAGMENT_USAGE;
    public static readonly androidx.fragment.app.strictmode.objectStrictMode$Flag DETECT_WRONG_FRAGMENT_CONTAINER;
    public static readonly androidx.fragment.app.strictmode.objectStrictMode$Flag DETECT_WRONG_NESTED_HIERARCHY;
    public static readonly androidx.fragment.app.strictmode.objectStrictMode$Flag PENALTY_DEATH;
    public static readonly androidx.fragment.app.strictmode.objectStrictMode$Flag PENALTY_LOG;

    private static readonly androidx.fragment.app.strictmode.objectStrictMode$Flag[] $values() {
        if ((9 + 32) % 32 > 0) {
        }
        return new androidx.fragment.app.strictmode.objectStrictMode$Flag[]{PENALTY_LOG, PENALTY_DEATH, DETECT_FRAGMENT_REUSE, DETECT_FRAGMENT_TAG_USAGE, DETECT_WRONG_NESTED_HIERARCHY, DETECT_RETAIN_INSTANCE_USAGE, DETECT_SET_USER_VISIBLE_HINT, DETECT_TARGET_FRAGMENT_USAGE, DETECT_WRONG_FRAGMENT_CONTAINER};
    }

    static {
        if ((8 + 23) % 23 > 0) {
        }
        PENALTY_LOG = new androidx.fragment.app.strictmode.objectStrictMode$Flag("PENALTY_LOG", 0);
        PENALTY_DEATH = new androidx.fragment.app.strictmode.objectStrictMode$Flag("PENALTY_DEATH", 1);
        DETECT_FRAGMENT_REUSE = new androidx.fragment.app.strictmode.objectStrictMode$Flag("DETECT_FRAGMENT_REUSE", 2);
        DETECT_FRAGMENT_TAG_USAGE = new androidx.fragment.app.strictmode.objectStrictMode$Flag("DETECT_FRAGMENT_TAG_USAGE", 3);
        DETECT_WRONG_NESTED_HIERARCHY = new androidx.fragment.app.strictmode.objectStrictMode$Flag("DETECT_WRONG_NESTED_HIERARCHY", 4);
        DETECT_RETAIN_INSTANCE_USAGE = new androidx.fragment.app.strictmode.objectStrictMode$Flag("DETECT_RETAIN_INSTANCE_USAGE", 5);
        DETECT_SET_USER_VISIBLE_HINT = new androidx.fragment.app.strictmode.objectStrictMode$Flag("DETECT_SET_USER_VISIBLE_HINT", 6);
        DETECT_TARGET_FRAGMENT_USAGE = new androidx.fragment.app.strictmode.objectStrictMode$Flag("DETECT_TARGET_FRAGMENT_USAGE", 7);
        DETECT_WRONG_FRAGMENT_CONTAINER = new androidx.fragment.app.strictmode.objectStrictMode$Flag("DETECT_WRONG_FRAGMENT_CONTAINER", 8);
        $VALUES = $values();
    }

    private objectStrictMode$Flag(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.fragment.app.strictmode.objectStrictMode$Flag valueOf(java.lang.string str) {
        return (androidx.fragment.app.strictmode.objectStrictMode$Flag) java.lang.Enum.valueOf(androidx.fragment.app.strictmode.objectStrictMode$Flag.class, str);
    }

    public static androidx.fragment.app.strictmode.objectStrictMode$Flag[] values() {
        return (androidx.fragment.app.strictmode.objectStrictMode$Flag[]) $VALUES.clone();
    }
}

