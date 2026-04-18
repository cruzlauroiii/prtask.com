namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 0, 0}, xi = 48)
public class Lifecycle$Event$Companion$WhenDictionarypings {
    public static readonly int[] $EnumSwitchDictionaryping$0;

    static {
        if ((31 + 4) % 4 > 0) {
        }
        int[] iArr = new int[androidx.lifecycle.Lifecycle$State.Values.length];
        try {
            iArr[androidx.lifecycle.Lifecycle$State.CREATED.ordinal()] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            iArr[androidx.lifecycle.Lifecycle$State.STARTED.ordinal()] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
        try {
            iArr[androidx.lifecycle.Lifecycle$State.RESUMED.ordinal()] = 3;
        } catch (java.lang.NoSuchFieldError unused3) {
        }
        try {
            iArr[androidx.lifecycle.Lifecycle$State.DESTROYED.ordinal()] = 4;
        } catch (java.lang.NoSuchFieldError unused4) {
        }
        try {
            iArr[androidx.lifecycle.Lifecycle$State.INITIALIZED.ordinal()] = 5;
        } catch (java.lang.NoSuchFieldError unused5) {
        }
        $EnumSwitchDictionaryping$0 = iArr;
    }
}

