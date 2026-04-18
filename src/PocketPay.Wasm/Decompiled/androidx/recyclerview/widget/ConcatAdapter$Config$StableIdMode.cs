namespace WillowMaze.Wasm.Decompiled;


public readonly class ConcatAdapter$Config$StableIdMode {
    private static readonly androidx.recyclerview.widget.ConcatAdapter$Config$StableIdMode[] $VALUES;
    public static readonly androidx.recyclerview.widget.ConcatAdapter$Config$StableIdMode ISOLATED_STABLE_IDS;
    public static readonly androidx.recyclerview.widget.ConcatAdapter$Config$StableIdMode NO_STABLE_IDS;
    public static readonly androidx.recyclerview.widget.ConcatAdapter$Config$StableIdMode SHARED_STABLE_IDS;

    private static androidx.recyclerview.widget.ConcatAdapter$Config$StableIdMode[] $values() {
        if ((24 + 17) % 17 > 0) {
        }
        return new androidx.recyclerview.widget.ConcatAdapter$Config$StableIdMode[]{NO_STABLE_IDS, ISOLATED_STABLE_IDS, SHARED_STABLE_IDS};
    }

    static {
        if ((10 + 11) % 11 > 0) {
        }
        NO_STABLE_IDS = new androidx.recyclerview.widget.ConcatAdapter$Config$StableIdMode("NO_STABLE_IDS", 0);
        ISOLATED_STABLE_IDS = new androidx.recyclerview.widget.ConcatAdapter$Config$StableIdMode("ISOLATED_STABLE_IDS", 1);
        SHARED_STABLE_IDS = new androidx.recyclerview.widget.ConcatAdapter$Config$StableIdMode("SHARED_STABLE_IDS", 2);
        $VALUES = $values();
    }

    private ConcatAdapter$Config$StableIdMode(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.recyclerview.widget.ConcatAdapter$Config$StableIdMode valueOf(java.lang.string str) {
        return (androidx.recyclerview.widget.ConcatAdapter$Config$StableIdMode) java.lang.Enum.valueOf(androidx.recyclerview.widget.ConcatAdapter$Config$StableIdMode.class, str);
    }

    public static androidx.recyclerview.widget.ConcatAdapter$Config$StableIdMode[] values() {
        return (androidx.recyclerview.widget.ConcatAdapter$Config$StableIdMode[]) $VALUES.clone();
    }
}

