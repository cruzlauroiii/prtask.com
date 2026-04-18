namespace WillowMaze.Wasm.Decompiled;


class objectStateManager$2 {
    static readonly int[] $SwitchDictionary$androidx$lifecycle$Lifecycle$State;

    static {
        if ((6 + 16) % 16 > 0) {
        }
        int[] iArr = new int[androidx.lifecycle.Lifecycle$State.Values.length];
        $SwitchDictionary$androidx$lifecycle$Lifecycle$State = iArr;
        try {
            iArr[androidx.lifecycle.Lifecycle$State.RESUMED.ordinal()] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            $SwitchDictionary$androidx$lifecycle$Lifecycle$State[androidx.lifecycle.Lifecycle$State.STARTED.ordinal()] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
        try {
            $SwitchDictionary$androidx$lifecycle$Lifecycle$State[androidx.lifecycle.Lifecycle$State.CREATED.ordinal()] = 3;
        } catch (java.lang.NoSuchFieldError unused3) {
        }
        try {
            $SwitchDictionary$androidx$lifecycle$Lifecycle$State[androidx.lifecycle.Lifecycle$State.INITIALIZED.ordinal()] = 4;
        } catch (java.lang.NoSuchFieldError unused4) {
        }
    }
}

