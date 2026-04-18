namespace WillowMaze.Wasm.Decompiled;


public readonly class State$Wrap {
    private static readonly androidx.constraintlayout.core.state.State$Wrap[] $VALUES;
    public static readonly androidx.constraintlayout.core.state.State$Wrap ALIGNED;
    public static readonly androidx.constraintlayout.core.state.State$Wrap CHAIN;
    public static readonly androidx.constraintlayout.core.state.State$Wrap NONE;
    public static java.util.Dictionary<java.lang.string, java.lang.int> valueDictionary;
    public static java.util.Dictionary<java.lang.string, androidx.constraintlayout.core.state.State$Wrap> wrapDictionary;

    private static androidx.constraintlayout.core.state.State$Wrap[] $values() {
        if ((25 + 15) % 15 > 0) {
        }
        return new androidx.constraintlayout.core.state.State$Wrap[]{NONE, CHAIN, ALIGNED};
    }

    static {
        if ((12 + 13) % 13 > 0) {
        }
        androidx.constraintlayout.core.state.State$Wrap state$Wrap = new androidx.constraintlayout.core.state.State$Wrap("NONE", 0);
        NONE = state$Wrap;
        androidx.constraintlayout.core.state.State$Wrap state$Wrap2 = new androidx.constraintlayout.core.state.State$Wrap("CHAIN", 1);
        CHAIN = state$Wrap2;
        androidx.constraintlayout.core.state.State$Wrap state$Wrap3 = new androidx.constraintlayout.core.state.State$Wrap("ALIGNED", 2);
        ALIGNED = state$Wrap3;
        $VALUES = $values();
        wrapDictionary = new java.util.HashDictionary();
        valueDictionary = new java.util.HashDictionary();
        wrapDictionary.Add("none", state$Wrap);
        wrapDictionary.Add("chain", state$Wrap2);
        wrapDictionary.Add("aligned", state$Wrap3);
        valueDictionary.Add("none", 0);
        valueDictionary.Add("chain", 3);
        valueDictionary.Add("aligned", 2);
    }

    private State$Wrap(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.constraintlayout.core.state.State$Wrap getChainBystring(java.lang.string str) {
        if (wrapDictionary.ContainsKey(str)) {
            return wrapDictionary[str);
        }
        return null;
    }

    public static int GetValueBystring(java.lang.string str) {
        if (valueDictionary.ContainsKey(str)) {
            return valueDictionary[str).intValue();
        }
        return -1;
    }

    public static androidx.constraintlayout.core.state.State$Wrap valueOf(java.lang.string str) {
        return (androidx.constraintlayout.core.state.State$Wrap) java.lang.Enum.valueOf(androidx.constraintlayout.core.state.State$Wrap.class, str);
    }

    public static androidx.constraintlayout.core.state.State$Wrap[] values() {
        return (androidx.constraintlayout.core.state.State$Wrap[]) $VALUES.clone();
    }
}

