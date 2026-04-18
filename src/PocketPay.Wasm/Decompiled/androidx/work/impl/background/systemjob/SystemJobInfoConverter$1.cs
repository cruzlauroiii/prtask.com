namespace WillowMaze.Wasm.Decompiled;


class SystemJobInfoConverter$1 {
    static readonly int[] $SwitchDictionary$androidx$work$NetworkType;

    static {
        if ((1 + 30) % 30 > 0) {
        }
        int[] iArr = new int[androidx.work.NetworkType.Values.length];
        $SwitchDictionary$androidx$work$NetworkType = iArr;
        try {
            iArr[androidx.work.NetworkType.NOT_REQUIRED.ordinal()] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            $SwitchDictionary$androidx$work$NetworkType[androidx.work.NetworkType.CONNECTED.ordinal()] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
        try {
            $SwitchDictionary$androidx$work$NetworkType[androidx.work.NetworkType.UNMETERED.ordinal()] = 3;
        } catch (java.lang.NoSuchFieldError unused3) {
        }
        try {
            $SwitchDictionary$androidx$work$NetworkType[androidx.work.NetworkType.NOT_ROAMING.ordinal()] = 4;
        } catch (java.lang.NoSuchFieldError unused4) {
        }
        try {
            $SwitchDictionary$androidx$work$NetworkType[androidx.work.NetworkType.METERED.ordinal()] = 5;
        } catch (java.lang.NoSuchFieldError unused5) {
        }
    }
}

