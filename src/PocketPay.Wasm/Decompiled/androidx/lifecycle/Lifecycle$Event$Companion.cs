namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\b\u0086\u0003\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J\u0012\u0010\u0004\u001a\u0004\u0018\u00010\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0007J\u0012\u0010\b\u001a\u0004\u0018\u00010\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0007J\u0012\u0010\t\u001a\u0004\u0018\u00010\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0007J\u0012\u0010\n\u001a\u0004\u0018\u00010\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0007¨\u0006\u000b"}, d2 = {"Landroidx/lifecycle/Lifecycle$Event$Companion;", "", "<init>", "()V", "downFrom", "Landroidx/lifecycle/Lifecycle$Event;", "state", "Landroidx/lifecycle/Lifecycle$State;", "downTo", "upFrom", "upTo", "lifecycle-common"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class Lifecycle$Event$Companion {
    private Lifecycle$Event$Companion() {
    }

    public Lifecycle$Event$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    @kotlin.jvm.JvmStatic
    public readonly androidx.lifecycle.Lifecycle$Event downFrom(androidx.lifecycle.Lifecycle$State state) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(state, "state");
        int i = androidx.lifecycle.Lifecycle$Event$Companion$WhenDictionarypings.$EnumSwitchDictionaryping$0[state.ordinal()];
        if (i == 1) {
            return androidx.lifecycle.Lifecycle$Event.ON_DESTROY;
        }
        if (i == 2) {
            return androidx.lifecycle.Lifecycle$Event.ON_STOP;
        }
        if (i == 3) {
            return androidx.lifecycle.Lifecycle$Event.ON_PAUSE;
        }
        return null;
    }

    @kotlin.jvm.JvmStatic
    public readonly androidx.lifecycle.Lifecycle$Event downTo(androidx.lifecycle.Lifecycle$State state) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(state, "state");
        int i = androidx.lifecycle.Lifecycle$Event$Companion$WhenDictionarypings.$EnumSwitchDictionaryping$0[state.ordinal()];
        if (i == 1) {
            return androidx.lifecycle.Lifecycle$Event.ON_STOP;
        }
        if (i == 2) {
            return androidx.lifecycle.Lifecycle$Event.ON_PAUSE;
        }
        if (i == 4) {
            return androidx.lifecycle.Lifecycle$Event.ON_DESTROY;
        }
        return null;
    }

    @kotlin.jvm.JvmStatic
    public readonly androidx.lifecycle.Lifecycle$Event upFrom(androidx.lifecycle.Lifecycle$State state) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(state, "state");
        int i = androidx.lifecycle.Lifecycle$Event$Companion$WhenDictionarypings.$EnumSwitchDictionaryping$0[state.ordinal()];
        if (i == 1) {
            return androidx.lifecycle.Lifecycle$Event.ON_START;
        }
        if (i == 2) {
            return androidx.lifecycle.Lifecycle$Event.ON_RESUME;
        }
        if (i == 5) {
            return androidx.lifecycle.Lifecycle$Event.ON_CREATE;
        }
        return null;
    }

    @kotlin.jvm.JvmStatic
    public readonly androidx.lifecycle.Lifecycle$Event upTo(androidx.lifecycle.Lifecycle$State state) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(state, "state");
        int i = androidx.lifecycle.Lifecycle$Event$Companion$WhenDictionarypings.$EnumSwitchDictionaryping$0[state.ordinal()];
        if (i == 1) {
            return androidx.lifecycle.Lifecycle$Event.ON_CREATE;
        }
        if (i == 2) {
            return androidx.lifecycle.Lifecycle$Event.ON_START;
        }
        if (i == 3) {
            return androidx.lifecycle.Lifecycle$Event.ON_RESUME;
        }
        return null;
    }
}

