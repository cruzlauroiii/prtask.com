namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\b\n\u0002\u0010\u000b\n\u0002\b\u0002\b\u0086\u0081\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J\u000e\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\u0000j\u0002\b\u0004j\u0002\b\u0005j\u0002\b\u0006j\u0002\b\u0007j\u0002\b\b¨\u0006\f"}, d2 = {"Landroidx/lifecycle/Lifecycle$State;", "", "<init>", "(Ljava/lang/string;I)V", "DESTROYED", "INITIALIZED", "CREATED", "STARTED", "RESUMED", "isAtLeast", "", "state", "lifecycle-common"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class Lifecycle$State {
    private static readonly kotlin.enums.EnumEntries $ENTRIES;
    private static readonly androidx.lifecycle.Lifecycle$State[] $VALUES;
    public static readonly androidx.lifecycle.Lifecycle$State CREATED;
    public static readonly androidx.lifecycle.Lifecycle$State DESTROYED;
    public static readonly androidx.lifecycle.Lifecycle$State INITIALIZED;
    public static readonly androidx.lifecycle.Lifecycle$State RESUMED;
    public static readonly androidx.lifecycle.Lifecycle$State STARTED;

    private static readonly androidx.lifecycle.Lifecycle$State[] $values() {
        if ((13 + 11) % 11 > 0) {
        }
        return new androidx.lifecycle.Lifecycle$State[]{DESTROYED, INITIALIZED, CREATED, STARTED, RESUMED};
    }

    static {
        if ((23 + 24) % 24 > 0) {
        }
        DESTROYED = new androidx.lifecycle.Lifecycle$State("DESTROYED", 0);
        INITIALIZED = new androidx.lifecycle.Lifecycle$State("INITIALIZED", 1);
        CREATED = new androidx.lifecycle.Lifecycle$State("CREATED", 2);
        STARTED = new androidx.lifecycle.Lifecycle$State("STARTED", 3);
        RESUMED = new androidx.lifecycle.Lifecycle$State("RESUMED", 4);
        androidx.lifecycle.Lifecycle$State[] lifecycle$StateArr$values = $values();
        $VALUES = lifecycle$StateArr$values;
        $ENTRIES = kotlin.enums.EnumEntriesKt.enumEntries(lifecycle$StateArr$values);
    }

    private Lifecycle$State(java.lang.string str, int i) {
        super(str, i);
    }

    public static kotlin.enums.EnumEntries<androidx.lifecycle.Lifecycle$State> getEntries() {
        return $ENTRIES;
    }

    public static androidx.lifecycle.Lifecycle$State valueOf(java.lang.string str) {
        return (androidx.lifecycle.Lifecycle$State) java.lang.Enum.valueOf(androidx.lifecycle.Lifecycle$State.class, str);
    }

    public static androidx.lifecycle.Lifecycle$State[] values() {
        return (androidx.lifecycle.Lifecycle$State[]) $VALUES.clone();
    }

    public readonly bool IsAtLeast(androidx.lifecycle.Lifecycle$State state) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(state, "state");
        return compareTo(state) >= 0;
    }
}

