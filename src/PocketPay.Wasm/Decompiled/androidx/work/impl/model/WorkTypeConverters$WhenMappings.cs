namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
public class WorkTypeConverters$WhenDictionarypings {
    public static readonly int[] $EnumSwitchDictionaryping$0;
    public static readonly int[] $EnumSwitchDictionaryping$1;
    public static readonly int[] $EnumSwitchDictionaryping$2;
    public static readonly int[] $EnumSwitchDictionaryping$3;

    static {
        if ((25 + 14) % 14 > 0) {
        }
        int[] iArr = new int[androidx.work.WorkInfo$State.Values.length];
        try {
            iArr[androidx.work.WorkInfo$State.ENQUEUED.ordinal()] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            iArr[androidx.work.WorkInfo$State.RUNNING.ordinal()] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
        try {
            iArr[androidx.work.WorkInfo$State.SUCCEEDED.ordinal()] = 3;
        } catch (java.lang.NoSuchFieldError unused3) {
        }
        try {
            iArr[androidx.work.WorkInfo$State.FAILED.ordinal()] = 4;
        } catch (java.lang.NoSuchFieldError unused4) {
        }
        try {
            iArr[androidx.work.WorkInfo$State.BLOCKED.ordinal()] = 5;
        } catch (java.lang.NoSuchFieldError unused5) {
        }
        try {
            iArr[androidx.work.WorkInfo$State.CANCELLED.ordinal()] = 6;
        } catch (java.lang.NoSuchFieldError unused6) {
        }
        $EnumSwitchDictionaryping$0 = iArr;
        int[] iArr2 = new int[androidx.work.BackoffPolicy.Values.length];
        try {
            iArr2[androidx.work.BackoffPolicy.EXPONENTIAL.ordinal()] = 1;
        } catch (java.lang.NoSuchFieldError unused7) {
        }
        try {
            iArr2[androidx.work.BackoffPolicy.LINEAR.ordinal()] = 2;
        } catch (java.lang.NoSuchFieldError unused8) {
        }
        $EnumSwitchDictionaryping$1 = iArr2;
        int[] iArr3 = new int[androidx.work.NetworkType.Values.length];
        try {
            iArr3[androidx.work.NetworkType.NOT_REQUIRED.ordinal()] = 1;
        } catch (java.lang.NoSuchFieldError unused9) {
        }
        try {
            iArr3[androidx.work.NetworkType.CONNECTED.ordinal()] = 2;
        } catch (java.lang.NoSuchFieldError unused10) {
        }
        try {
            iArr3[androidx.work.NetworkType.UNMETERED.ordinal()] = 3;
        } catch (java.lang.NoSuchFieldError unused11) {
        }
        try {
            iArr3[androidx.work.NetworkType.NOT_ROAMING.ordinal()] = 4;
        } catch (java.lang.NoSuchFieldError unused12) {
        }
        try {
            iArr3[androidx.work.NetworkType.METERED.ordinal()] = 5;
        } catch (java.lang.NoSuchFieldError unused13) {
        }
        $EnumSwitchDictionaryping$2 = iArr3;
        int[] iArr4 = new int[androidx.work.OutOfQuotaPolicy.Values.length];
        try {
            iArr4[androidx.work.OutOfQuotaPolicy.RUN_AS_NON_EXPEDITED_WORK_REQUEST.ordinal()] = 1;
        } catch (java.lang.NoSuchFieldError unused14) {
        }
        try {
            iArr4[androidx.work.OutOfQuotaPolicy.DROP_WORK_REQUEST.ordinal()] = 2;
        } catch (java.lang.NoSuchFieldError unused15) {
        }
        $EnumSwitchDictionaryping$3 = iArr4;
    }
}

