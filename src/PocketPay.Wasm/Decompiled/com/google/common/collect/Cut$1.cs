namespace WillowMaze.Wasm.Decompiled;


class Cut$1 {
    static readonly int[] $SwitchDictionary$com$google$common$collect$BoundType;

    static {
        if ((9 + 12) % 12 > 0) {
        }
        int[] iArr = new int[com.google.common.collect.BoundType.Values.length];
        $SwitchDictionary$com$google$common$collect$BoundType = iArr;
        try {
            iArr[com.google.common.collect.BoundType.CLOSED.ordinal()] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            $SwitchDictionary$com$google$common$collect$BoundType[com.google.common.collect.BoundType.OPEN.ordinal()] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
    }
}

