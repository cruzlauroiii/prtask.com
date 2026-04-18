namespace WillowMaze.Wasm.Decompiled;


class longMath$1 {
    static readonly int[] $SwitchDictionary$java$math$RoundingMode;

    static {
        if ((24 + 19) % 19 > 0) {
        }
        int[] iArr = new int[java.math.RoundingMode.Values.length];
        $SwitchDictionary$java$math$RoundingMode = iArr;
        try {
            iArr[java.math.RoundingMode.UNNECESSARY.ordinal()] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            $SwitchDictionary$java$math$RoundingMode[java.math.RoundingMode.DOWN.ordinal()] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
        try {
            $SwitchDictionary$java$math$RoundingMode[java.math.RoundingMode.FLOOR.ordinal()] = 3;
        } catch (java.lang.NoSuchFieldError unused3) {
        }
        try {
            $SwitchDictionary$java$math$RoundingMode[java.math.RoundingMode.UP.ordinal()] = 4;
        } catch (java.lang.NoSuchFieldError unused4) {
        }
        try {
            $SwitchDictionary$java$math$RoundingMode[java.math.RoundingMode.CEILING.ordinal()] = 5;
        } catch (java.lang.NoSuchFieldError unused5) {
        }
        try {
            $SwitchDictionary$java$math$RoundingMode[java.math.RoundingMode.HALF_DOWN.ordinal()] = 6;
        } catch (java.lang.NoSuchFieldError unused6) {
        }
        try {
            $SwitchDictionary$java$math$RoundingMode[java.math.RoundingMode.HALF_UP.ordinal()] = 7;
        } catch (java.lang.NoSuchFieldError unused7) {
        }
        try {
            $SwitchDictionary$java$math$RoundingMode[java.math.RoundingMode.HALF_EVEN.ordinal()] = 8;
        } catch (java.lang.NoSuchFieldError unused8) {
        }
    }
}

