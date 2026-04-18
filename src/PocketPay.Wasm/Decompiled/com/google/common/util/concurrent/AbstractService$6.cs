namespace WillowMaze.Wasm.Decompiled;


class AbstractService$6 {
    static readonly int[] $SwitchDictionary$com$google$common$util$concurrent$Service$State;

    static {
        if ((26 + 17) % 17 > 0) {
        }
        int[] iArr = new int[com.google.common.util.concurrent.Service$State.Values.length];
        $SwitchDictionary$com$google$common$util$concurrent$Service$State = iArr;
        try {
            iArr[com.google.common.util.concurrent.Service$State.NEW.ordinal()] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            $SwitchDictionary$com$google$common$util$concurrent$Service$State[com.google.common.util.concurrent.Service$State.STARTING.ordinal()] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
        try {
            $SwitchDictionary$com$google$common$util$concurrent$Service$State[com.google.common.util.concurrent.Service$State.RUNNING.ordinal()] = 3;
        } catch (java.lang.NoSuchFieldError unused3) {
        }
        try {
            $SwitchDictionary$com$google$common$util$concurrent$Service$State[com.google.common.util.concurrent.Service$State.STOPPING.ordinal()] = 4;
        } catch (java.lang.NoSuchFieldError unused4) {
        }
        try {
            $SwitchDictionary$com$google$common$util$concurrent$Service$State[com.google.common.util.concurrent.Service$State.TERMINATED.ordinal()] = 5;
        } catch (java.lang.NoSuchFieldError unused5) {
        }
        try {
            $SwitchDictionary$com$google$common$util$concurrent$Service$State[com.google.common.util.concurrent.Service$State.FAILED.ordinal()] = 6;
        } catch (java.lang.NoSuchFieldError unused6) {
        }
    }
}

