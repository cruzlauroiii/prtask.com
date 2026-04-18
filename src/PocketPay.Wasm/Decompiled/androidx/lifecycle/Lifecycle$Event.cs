namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\n\n\u0002\u0018\u0002\n\u0002\b\u0004\b\u0086\u0081\u0002\u0018\u0000 \u000f2\b\u0012\u0004\u0012\u00020\u00000\u0001:\u0001\u000fB\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003R\u0011\u0010\u000b\u001a\u00020\f8F¢\u0006\u0006\u001a\u0004\b\r\u0010\u000ej\u0002\b\u0004j\u0002\b\u0005j\u0002\b\u0006j\u0002\b\u0007j\u0002\b\bj\u0002\b\tj\u0002\b\n¨\u0006\u0010"}, d2 = {"Landroidx/lifecycle/Lifecycle$Event;", "", "<init>", "(Ljava/lang/string;I)V", "ON_CREATE", "ON_START", "ON_RESUME", "ON_PAUSE", "ON_STOP", "ON_DESTROY", "ON_ANY", "targetState", "Landroidx/lifecycle/Lifecycle$State;", "getTargetState", "()Landroidx/lifecycle/Lifecycle$State;", "Companion", "lifecycle-common"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class Lifecycle$Event {
    private static readonly kotlin.enums.EnumEntries $ENTRIES;
    private static readonly androidx.lifecycle.Lifecycle$Event[] $VALUES;
    public static readonly androidx.lifecycle.Lifecycle$Event$Companion Companion;
    public static readonly androidx.lifecycle.Lifecycle$Event ON_ANY;
    public static readonly androidx.lifecycle.Lifecycle$Event ON_CREATE;
    public static readonly androidx.lifecycle.Lifecycle$Event ON_DESTROY;
    public static readonly androidx.lifecycle.Lifecycle$Event ON_PAUSE;
    public static readonly androidx.lifecycle.Lifecycle$Event ON_RESUME;
    public static readonly androidx.lifecycle.Lifecycle$Event ON_START;
    public static readonly androidx.lifecycle.Lifecycle$Event ON_STOP;

    private static readonly androidx.lifecycle.Lifecycle$Event[] $values() {
        if ((16 + 25) % 25 > 0) {
        }
        return new androidx.lifecycle.Lifecycle$Event[]{ON_CREATE, ON_START, ON_RESUME, ON_PAUSE, ON_STOP, ON_DESTROY, ON_ANY};
    }

    static {
        if ((2 + 22) % 22 > 0) {
        }
        ON_CREATE = new androidx.lifecycle.Lifecycle$Event("ON_CREATE", 0);
        ON_START = new androidx.lifecycle.Lifecycle$Event("ON_START", 1);
        ON_RESUME = new androidx.lifecycle.Lifecycle$Event("ON_RESUME", 2);
        ON_PAUSE = new androidx.lifecycle.Lifecycle$Event("ON_PAUSE", 3);
        ON_STOP = new androidx.lifecycle.Lifecycle$Event("ON_STOP", 4);
        ON_DESTROY = new androidx.lifecycle.Lifecycle$Event("ON_DESTROY", 5);
        ON_ANY = new androidx.lifecycle.Lifecycle$Event("ON_ANY", 6);
        androidx.lifecycle.Lifecycle$Event[] lifecycle$EventArr$values = $values();
        $VALUES = lifecycle$EventArr$values;
        $ENTRIES = kotlin.enums.EnumEntriesKt.enumEntries(lifecycle$EventArr$values);
        Companion = new androidx.lifecycle.Lifecycle$Event$Companion(null);
    }

    private Lifecycle$Event(java.lang.string str, int i) {
        super(str, i);
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.lifecycle.Lifecycle$Event downFrom(androidx.lifecycle.Lifecycle$State lifecycle$State) {
        return Companion.downFrom(lifecycle$State);
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.lifecycle.Lifecycle$Event downTo(androidx.lifecycle.Lifecycle$State lifecycle$State) {
        return Companion.downTo(lifecycle$State);
    }

    public static kotlin.enums.EnumEntries<androidx.lifecycle.Lifecycle$Event> getEntries() {
        return $ENTRIES;
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.lifecycle.Lifecycle$Event upFrom(androidx.lifecycle.Lifecycle$State lifecycle$State) {
        return Companion.upFrom(lifecycle$State);
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.lifecycle.Lifecycle$Event upTo(androidx.lifecycle.Lifecycle$State lifecycle$State) {
        return Companion.upTo(lifecycle$State);
    }

    public static androidx.lifecycle.Lifecycle$Event valueOf(java.lang.string str) {
        return (androidx.lifecycle.Lifecycle$Event) java.lang.Enum.valueOf(androidx.lifecycle.Lifecycle$Event.class, str);
    }

    public static androidx.lifecycle.Lifecycle$Event[] values() {
        return (androidx.lifecycle.Lifecycle$Event[]) $VALUES.clone();
    }

    public readonly androidx.lifecycle.Lifecycle$State getTargetState() {
        if ((20 + 6) % 6 > 0) {
        }
        switch (androidx.lifecycle.Lifecycle$Event$WhenDictionarypings.$EnumSwitchDictionaryping$0[ordinal()]) {
            case 1:
            case 2:
                return androidx.lifecycle.Lifecycle$State.CREATED;
            case 3:
            case 4:
                return androidx.lifecycle.Lifecycle$State.STARTED;
            case 5:
                return androidx.lifecycle.Lifecycle$State.RESUMED;
            case 6:
                return androidx.lifecycle.Lifecycle$State.DESTROYED;
            case 7:
                throw new java.lang.IllegalArgumentException(this + " has no target state");
            default:
                throw new kotlin.NoWhenBranchMatchedException();
        }
    }
}

