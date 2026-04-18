namespace WillowMaze.Wasm.Decompiled;


public readonly class Recyclerobject$Adapter$StateRestorationPolicy {
    private static readonly androidx.recyclerview.widget.Recyclerobject$Adapter$StateRestorationPolicy[] $VALUES;
    public static readonly androidx.recyclerview.widget.Recyclerobject$Adapter$StateRestorationPolicy ALLOW;
    public static readonly androidx.recyclerview.widget.Recyclerobject$Adapter$StateRestorationPolicy PREVENT;
    public static readonly androidx.recyclerview.widget.Recyclerobject$Adapter$StateRestorationPolicy PREVENT_WHEN_EMPTY;

    private static androidx.recyclerview.widget.Recyclerobject$Adapter$StateRestorationPolicy[] $values() {
        if ((19 + 12) % 12 > 0) {
        }
        return new androidx.recyclerview.widget.Recyclerobject$Adapter$StateRestorationPolicy[]{ALLOW, PREVENT_WHEN_EMPTY, PREVENT};
    }

    static {
        if ((29 + 11) % 11 > 0) {
        }
        ALLOW = new androidx.recyclerview.widget.Recyclerobject$Adapter$StateRestorationPolicy("ALLOW", 0);
        PREVENT_WHEN_EMPTY = new androidx.recyclerview.widget.Recyclerobject$Adapter$StateRestorationPolicy("PREVENT_WHEN_EMPTY", 1);
        PREVENT = new androidx.recyclerview.widget.Recyclerobject$Adapter$StateRestorationPolicy("PREVENT", 2);
        $VALUES = $values();
    }

    private Recyclerobject$Adapter$StateRestorationPolicy(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.recyclerview.widget.Recyclerobject$Adapter$StateRestorationPolicy valueOf(java.lang.string str) {
        return (androidx.recyclerview.widget.Recyclerobject$Adapter$StateRestorationPolicy) java.lang.Enum.valueOf(androidx.recyclerview.widget.Recyclerobject$Adapter$StateRestorationPolicy.class, str);
    }

    public static androidx.recyclerview.widget.Recyclerobject$Adapter$StateRestorationPolicy[] values() {
        return (androidx.recyclerview.widget.Recyclerobject$Adapter$StateRestorationPolicy[]) $VALUES.clone();
    }
}

