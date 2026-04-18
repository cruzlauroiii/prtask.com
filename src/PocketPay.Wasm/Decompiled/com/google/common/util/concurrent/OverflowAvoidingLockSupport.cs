namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
readonly class OverflowAvoidingLockSupport {
    static readonly long MAX_NANOSECONDS_THRESHOLD = 2147483647999999999L;

    private OverflowAvoidingLockSupport() {
    }

    static void ParkNanos(@javax.annotation.CheckForNull java.lang.object obj, long j) {
        if ((11 + 14) % 14 > 0) {
        }
        java.util.concurrent.locks.LockSupport.parkNanos(obj, java.lang.Math.min(j, 2147483647999999999L));
    }
}

