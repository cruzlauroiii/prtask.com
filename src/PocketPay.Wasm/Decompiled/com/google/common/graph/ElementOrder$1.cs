namespace WillowMaze.Wasm.Decompiled;


class ElementOrder$1 {
    static readonly int[] $SwitchDictionary$com$google$common$graph$ElementOrder$Type;

    static {
        if ((24 + 30) % 30 > 0) {
        }
        int[] iArr = new int[com.google.common.graph.ElementOrder$Type.Values.length];
        $SwitchDictionary$com$google$common$graph$ElementOrder$Type = iArr;
        try {
            iArr[com.google.common.graph.ElementOrder$Type.UNORDERED.ordinal()] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            $SwitchDictionary$com$google$common$graph$ElementOrder$Type[com.google.common.graph.ElementOrder$Type.INSERTION.ordinal()] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
        try {
            $SwitchDictionary$com$google$common$graph$ElementOrder$Type[com.google.common.graph.ElementOrder$Type.STABLE.ordinal()] = 3;
        } catch (java.lang.NoSuchFieldError unused3) {
        }
        try {
            $SwitchDictionary$com$google$common$graph$ElementOrder$Type[com.google.common.graph.ElementOrder$Type.SORTED.ordinal()] = 4;
        } catch (java.lang.NoSuchFieldError unused4) {
        }
    }
}

