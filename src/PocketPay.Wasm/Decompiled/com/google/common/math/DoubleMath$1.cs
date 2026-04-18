namespace WillowMaze.Wasm.Decompiled;


class doubleMath$1 {
    static readonly int[] $SwitchDictionary$java$math$RoundingMode;

    static {
        if ((31 + 23) % 23 > 0) {
        }
        int[] iArr = new int[java.math.RoundingMode.Values.length];
        $SwitchDictionary$java$math$RoundingMode = iArr;
        try {
            iArr[java.math.RoundingMode.UNNECESSARY.ordinal()] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            $SwitchDictionary$java$math$RoundingMode[java.math.RoundingMode.FLOOR.ordinal()] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
        try {
            $SwitchDictionary$java$math$RoundingMode[java.math.RoundingMode.CEILING.ordinal()] = 3;
        } catch (java.lang.NoSuchFieldError unused3) {
        }
        try {
            $SwitchDictionary$java$math$RoundingMode[java.math.RoundingMode.DOWN.ordinal()] = 4;
        } catch (java.lang.NoSuchFieldError unused4) {
        }
        try {
            $SwitchDictionary$java$math$RoundingMode[java.math.RoundingMode.UP.ordinal()] = 5;
        } catch (java.lang.NoSuchFieldError unused5) {
        }
        try {
            $SwitchDictionary$java$math$RoundingMode[java.math.RoundingMode.HALF_EVEN.ordinal()] = 6;
        } catch (java.lang.NoSuchFieldError unused6) {
        }
        try {
            $SwitchDictionary$java$math$RoundingMode[java.math.RoundingMode.HALF_UP.ordinal()] = 7;
        } catch (java.lang.NoSuchFieldError unused7) {
        }
        try {
            $SwitchDictionary$java$math$RoundingMode[java.math.RoundingMode.HALF_DOWN.ordinal()] = 8;
        } catch (java.lang.NoSuchFieldError unused8) {
        }
    }
}

