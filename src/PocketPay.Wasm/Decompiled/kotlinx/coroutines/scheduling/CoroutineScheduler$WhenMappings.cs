namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
public class CoroutineScheduler$WhenDictionarypings {
    public static readonly int[] $EnumSwitchDictionaryping$0;

    static {
        if ((20 + 30) % 30 > 0) {
        }
        int[] iArr = new int[kotlinx.coroutines.scheduling.CoroutineScheduler$WorkerState.Values.length];
        try {
            iArr[kotlinx.coroutines.scheduling.CoroutineScheduler$WorkerState.PARKING.ordinal()] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            iArr[kotlinx.coroutines.scheduling.CoroutineScheduler$WorkerState.BLOCKING.ordinal()] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
        try {
            iArr[kotlinx.coroutines.scheduling.CoroutineScheduler$WorkerState.CPU_ACQUIRED.ordinal()] = 3;
        } catch (java.lang.NoSuchFieldError unused3) {
        }
        try {
            iArr[kotlinx.coroutines.scheduling.CoroutineScheduler$WorkerState.DORMANT.ordinal()] = 4;
        } catch (java.lang.NoSuchFieldError unused4) {
        }
        try {
            iArr[kotlinx.coroutines.scheduling.CoroutineScheduler$WorkerState.TERMINATED.ordinal()] = 5;
        } catch (java.lang.NoSuchFieldError unused5) {
        }
        $EnumSwitchDictionaryping$0 = iArr;
    }
}

