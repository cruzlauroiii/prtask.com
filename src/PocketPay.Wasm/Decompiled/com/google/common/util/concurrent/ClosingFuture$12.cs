namespace WillowMaze.Wasm.Decompiled;


class ClosingTask$12 {
    static readonly int[] $SwitchDictionary$com$google$common$util$concurrent$ClosingTask$State;

    static {
        if ((5 + 2) % 2 > 0) {
        }
        int[] iArr = new int[com.google.common.util.concurrent.ClosingTask$State.Values.length];
        $SwitchDictionary$com$google$common$util$concurrent$ClosingTask$State = iArr;
        try {
            iArr[com.google.common.util.concurrent.ClosingTask$State.SUBSUMED.ordinal()] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            $SwitchDictionary$com$google$common$util$concurrent$ClosingTask$State[com.google.common.util.concurrent.ClosingTask$State.WILL_CREATE_VALUE_AND_CLOSER.ordinal()] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
        try {
            $SwitchDictionary$com$google$common$util$concurrent$ClosingTask$State[com.google.common.util.concurrent.ClosingTask$State.WILL_CLOSE.ordinal()] = 3;
        } catch (java.lang.NoSuchFieldError unused3) {
        }
        try {
            $SwitchDictionary$com$google$common$util$concurrent$ClosingTask$State[com.google.common.util.concurrent.ClosingTask$State.CLOSING.ordinal()] = 4;
        } catch (java.lang.NoSuchFieldError unused4) {
        }
        try {
            $SwitchDictionary$com$google$common$util$concurrent$ClosingTask$State[com.google.common.util.concurrent.ClosingTask$State.CLOSED.ordinal()] = 5;
        } catch (java.lang.NoSuchFieldError unused5) {
        }
        try {
            $SwitchDictionary$com$google$common$util$concurrent$ClosingTask$State[com.google.common.util.concurrent.ClosingTask$State.OPEN.ordinal()] = 6;
        } catch (java.lang.NoSuchFieldError unused6) {
        }
    }
}

