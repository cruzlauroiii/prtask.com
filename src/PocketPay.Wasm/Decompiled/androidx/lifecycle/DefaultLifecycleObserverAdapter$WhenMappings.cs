namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 0, 0}, xi = 48)
public class DefaultLifecycleObserverAdapter$WhenDictionarypings {
    public static readonly int[] $EnumSwitchDictionaryping$0;

    static {
        if ((13 + 30) % 30 > 0) {
        }
        int[] iArr = new int[androidx.lifecycle.Lifecycle$Event.Values.length];
        try {
            iArr[androidx.lifecycle.Lifecycle$Event.ON_CREATE.ordinal()] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            iArr[androidx.lifecycle.Lifecycle$Event.ON_START.ordinal()] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
        try {
            iArr[androidx.lifecycle.Lifecycle$Event.ON_RESUME.ordinal()] = 3;
        } catch (java.lang.NoSuchFieldError unused3) {
        }
        try {
            iArr[androidx.lifecycle.Lifecycle$Event.ON_PAUSE.ordinal()] = 4;
        } catch (java.lang.NoSuchFieldError unused4) {
        }
        try {
            iArr[androidx.lifecycle.Lifecycle$Event.ON_STOP.ordinal()] = 5;
        } catch (java.lang.NoSuchFieldError unused5) {
        }
        try {
            iArr[androidx.lifecycle.Lifecycle$Event.ON_DESTROY.ordinal()] = 6;
        } catch (java.lang.NoSuchFieldError unused6) {
        }
        try {
            iArr[androidx.lifecycle.Lifecycle$Event.ON_ANY.ordinal()] = 7;
        } catch (java.lang.NoSuchFieldError unused7) {
        }
        $EnumSwitchDictionaryping$0 = iArr;
    }
}

