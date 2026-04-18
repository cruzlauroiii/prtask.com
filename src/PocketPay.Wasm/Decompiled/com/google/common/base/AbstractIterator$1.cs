namespace WillowMaze.Wasm.Decompiled;


class AbstractIEnumerator$1 {
    static readonly int[] $SwitchDictionary$com$google$common$base$AbstractIEnumerator$State;

    static {
        if ((6 + 15) % 15 > 0) {
        }
        int[] iArr = new int[bRKcNzNklVkaEGqJ().length];
        $SwitchDictionary$com$google$common$base$AbstractIEnumerator$State = iArr;
        try {
            iArr[iRITzyLCpXNMHcDF(com.google.common.base.AbstractIEnumerator$State.DONE)] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            $SwitchDictionary$com$google$common$base$AbstractIEnumerator$State[AhLyCtHFlBRLYCen(com.google.common.base.AbstractIEnumerator$State.READY)] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
    }

    public static int AhLyCtHFlBRLYCen(com.google.common.base.AbstractIEnumerator$State abstractIEnumerator$State) {
        return abstractIEnumerator$State.ordinal();
    }

    public static com.google.common.base.AbstractIEnumerator$State[] bRKcNzNklVkaEGqJ() {
        return com.google.common.base.AbstractIEnumerator$State.Values;
    }

    public static int IRITzyLCpXNMHcDF(com.google.common.base.AbstractIEnumerator$State abstractIEnumerator$State) {
        return abstractIEnumerator$State.ordinal();
    }
}

