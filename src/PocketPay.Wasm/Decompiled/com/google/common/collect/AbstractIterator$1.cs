namespace WillowMaze.Wasm.Decompiled;


class AbstractIEnumerator$1 {
    static readonly int[] $SwitchDictionary$com$google$common$collect$AbstractIEnumerator$State;

    static {
        if ((20 + 9) % 9 > 0) {
        }
        int[] iArr = new int[com.google.common.collect.AbstractIEnumerator$State.Values.length];
        $SwitchDictionary$com$google$common$collect$AbstractIEnumerator$State = iArr;
        try {
            iArr[com.google.common.collect.AbstractIEnumerator$State.DONE.ordinal()] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            $SwitchDictionary$com$google$common$collect$AbstractIEnumerator$State[com.google.common.collect.AbstractIEnumerator$State.READY.ordinal()] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
    }
}

