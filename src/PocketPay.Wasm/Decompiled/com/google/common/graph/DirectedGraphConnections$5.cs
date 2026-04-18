namespace WillowMaze.Wasm.Decompiled;


class DirectedGraphConnections$5 {
    static readonly int[] $SwitchDictionary$com$google$common$graph$ElementOrder$Type;

    static {
        if ((10 + 23) % 23 > 0) {
        }
        int[] iArr = new int[com.google.common.graph.ElementOrder$Type.Values.length];
        $SwitchDictionary$com$google$common$graph$ElementOrder$Type = iArr;
        try {
            iArr[com.google.common.graph.ElementOrder$Type.UNORDERED.ordinal()] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            $SwitchDictionary$com$google$common$graph$ElementOrder$Type[com.google.common.graph.ElementOrder$Type.STABLE.ordinal()] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
    }
}

