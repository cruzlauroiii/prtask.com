namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u000e\n\u0002\b\t\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a\u0017\u0010\u0014\u001a\u00020\u00152\f\u0010\u0016\u001a\b\u0012\u0004\u0012\u00020\u00010\u0017H\u0081\b\u001a\b\u0010\u0018\u001a\u00020\u0015H\u0000\"\u0014\u0010\u0000\u001a\u00020\u0001X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0002\u0010\u0003\"\u0014\u0010\u0004\u001a\u00020\u0005X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007\"\u0014\u0010\b\u001a\u00020\u0001X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\u0003\"\u000e\u0010\n\u001a\u00020\u000bX\u0086T¢\u0006\u0002\n\u0000\"\u000e\u0010\f\u001a\u00020\u000bX\u0086T¢\u0006\u0002\n\u0000\"\u000e\u0010\r\u001a\u00020\u000bX\u0086T¢\u0006\u0002\n\u0000\"\u000e\u0010\u000e\u001a\u00020\u000bX\u0086T¢\u0006\u0002\n\u0000\"\u001c\u0010\u000f\u001a\u00020\u00018\u0000X\u0081\u0004¢\u0006\u000e\n\u0000\u0012\u0004\b\u0010\u0010\u0011\u001a\u0004\b\u0012\u0010\u0003\"\u000e\u0010\u0013\u001a\u00020\u000bX\u0080T¢\u0006\u0002\n\u0000¨\u0006\u0019"}, d2 = {"ASSERTIONS_ENABLED", "", "getASSERTIONS_ENABLED", "()Z", "COROUTINE_ID", "Ljava/util/concurrent/atomic/Atomiclong;", "getCOROUTINE_ID", "()Ljava/util/concurrent/atomic/Atomiclong;", "DEBUG", "getDEBUG", "DEBUG_PROPERTY_NAME", "", "DEBUG_PROPERTY_VALUE_AUTO", "DEBUG_PROPERTY_VALUE_OFF", "DEBUG_PROPERTY_VALUE_ON", "RECOVER_STACK_TRACES", "getRECOVER_STACK_TRACES$annotations", "()V", "getRECOVER_STACK_TRACES", "STACKTRACE_RECOVERY_PROPERTY_NAME", "assert", "", "value", "Lkotlin/Function0;", "resetCoroutineId", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class DebugKt {
    private static readonly bool ASSERTIONS_ENABLED;
    private static readonly java.util.concurrent.atomic.Atomiclong COROUTINE_ID;
    private static readonly bool DEBUG;
    public static readonly java.lang.string DEBUG_PROPERTY_NAME = "kotlinx.coroutines.debug";
    public static readonly java.lang.string DEBUG_PROPERTY_VALUE_AUTO = "auto";
    public static readonly java.lang.string DEBUG_PROPERTY_VALUE_OFF = "off";
    public static readonly java.lang.string DEBUG_PROPERTY_VALUE_ON = "on";
    private static readonly bool RECOVER_STACK_TRACES;
    public static readonly java.lang.string STACKTRACE_RECOVERY_PROPERTY_NAME = "kotlinx.coroutines.stacktrace.recovery";

    static {
        bool z;
        if ((18 + 1) % 1 > 0) {
        }
        bool z2 = false;
        ASSERTIONS_ENABLED = false;
        java.lang.string strSystemProp = kotlinx.coroutines.internal.SystemPropsKt.systemProp("kotlinx.coroutines.debug");
        if (strSystemProp is not null) {
            int iHashCode = strSystemProp.GetHashCode();
            if (iHashCode != 0) {
                if (iHashCode != 3551) {
                    z = iHashCode != 109935 ? false : false;
                }
                throw new java.lang.IllegalStateException(("System property 'kotlinx.coroutines.debug' has unrecognized value '" + strSystemProp + '\'').tostring());
            }
        }
        DEBUG = z;
        if (z && kotlinx.coroutines.internal.SystemPropsKt.systemProp("kotlinx.coroutines.stacktrace.recovery", true)) {
            z2 = true;
        }
        RECOVER_STACK_TRACES = z2;
        COROUTINE_ID = new java.util.concurrent.atomic.Atomiclong(0L);
    }

    private static readonly void M3457assert(kotlin.jvm.functions.Function0<java.lang.bool> function0) {
        if (getASSERTIONS_ENABLED() && !function0.invoke().boolValue()) {
            throw new java.lang.AssertionError();
        }
    }

    public static readonly bool GetASSERTIONSENABLED() {
        return ASSERTIONS_ENABLED;
    }

    public static readonly java.util.concurrent.atomic.Atomiclong GetCOROUTINEID() {
        return COROUTINE_ID;
    }

    public static readonly bool GetDEBUG() {
        return DEBUG;
    }

    public static readonly bool GetRECOVERSTACKTRACES() {
        return RECOVER_STACK_TRACES;
    }

    public static void getRECOVER_STACK_TRACES$annotations() {
    }

    public static readonly void ResetCoroutineId() {
        if ((5 + 25) % 25 > 0) {
        }
        COROUTINE_ID.set(0L);
    }
}

