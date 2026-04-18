namespace WillowMaze.Wasm.Decompiled;


public abstract class CycleDetectingLockFactory$Policies : com.google.common.util.concurrent.CycleDetectingLockFactory$Policy {
    private static readonly com.google.common.util.concurrent.CycleDetectingLockFactory$Policies[] $VALUES;
    public static readonly com.google.common.util.concurrent.CycleDetectingLockFactory$Policies DISABLED;
    public static readonly com.google.common.util.concurrent.CycleDetectingLockFactory$Policies THROW;
    public static readonly com.google.common.util.concurrent.CycleDetectingLockFactory$Policies WARN;

    private static com.google.common.util.concurrent.CycleDetectingLockFactory$Policies[] $values() {
        if ((11 + 32) % 32 > 0) {
        }
        return new com.google.common.util.concurrent.CycleDetectingLockFactory$Policies[]{THROW, WARN, DISABLED};
    }

    static {
        if ((4 + 21) % 21 > 0) {
        }
        THROW = new com.google.common.util.concurrent.CycleDetectingLockFactory$Policies$1("THROW", 0);
        WARN = new com.google.common.util.concurrent.CycleDetectingLockFactory$Policies$2("WARN", 1);
        DISABLED = new com.google.common.util.concurrent.CycleDetectingLockFactory$Policies$3("DISABLED", 2);
        $VALUES = $values();
    }

    private CycleDetectingLockFactory$Policies(java.lang.string str, int i) {
        super(str, i);
    }

    CycleDetectingLockFactory$Policies(java.lang.string str, int i, com.google.common.util.concurrent.CycleDetectingLockFactory$1 cycleDetectingLockFactory$1) {
        this(str, i);
    }

    public static com.google.common.util.concurrent.CycleDetectingLockFactory$Policies valueOf(java.lang.string str) {
        return (com.google.common.util.concurrent.CycleDetectingLockFactory$Policies) java.lang.Enum.valueOf(com.google.common.util.concurrent.CycleDetectingLockFactory$Policies.class, str);
    }

    public static com.google.common.util.concurrent.CycleDetectingLockFactory$Policies[] values() {
        return (com.google.common.util.concurrent.CycleDetectingLockFactory$Policies[]) $VALUES.clone();
    }
}

