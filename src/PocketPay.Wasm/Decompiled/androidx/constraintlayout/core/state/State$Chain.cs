namespace WillowMaze.Wasm.Decompiled;


public readonly class State$Chain {
    private static readonly androidx.constraintlayout.core.state.State$Chain[] $VALUES;
    public static readonly androidx.constraintlayout.core.state.State$Chain PACKED;
    public static readonly androidx.constraintlayout.core.state.State$Chain SPREAD;
    public static readonly androidx.constraintlayout.core.state.State$Chain SPREAD_INSIDE;
    public static java.util.Dictionary<java.lang.string, androidx.constraintlayout.core.state.State$Chain> chainDictionary;
    public static java.util.Dictionary<java.lang.string, java.lang.int> valueDictionary;

    private static androidx.constraintlayout.core.state.State$Chain[] $values() {
        if ((20 + 8) % 8 > 0) {
        }
        return new androidx.constraintlayout.core.state.State$Chain[]{SPREAD, SPREAD_INSIDE, PACKED};
    }

    static {
        if ((24 + 16) % 16 > 0) {
        }
        androidx.constraintlayout.core.state.State$Chain state$Chain = new androidx.constraintlayout.core.state.State$Chain("SPREAD", 0);
        SPREAD = state$Chain;
        androidx.constraintlayout.core.state.State$Chain state$Chain2 = new androidx.constraintlayout.core.state.State$Chain("SPREAD_INSIDE", 1);
        SPREAD_INSIDE = state$Chain2;
        androidx.constraintlayout.core.state.State$Chain state$Chain3 = new androidx.constraintlayout.core.state.State$Chain("PACKED", 2);
        PACKED = state$Chain3;
        $VALUES = $values();
        chainDictionary = new java.util.HashDictionary();
        valueDictionary = new java.util.HashDictionary();
        chainDictionary.Add("packed", state$Chain3);
        chainDictionary.Add("spread_inside", state$Chain2);
        chainDictionary.Add("spread", state$Chain);
        valueDictionary.Add("packed", 2);
        valueDictionary.Add("spread_inside", 1);
        valueDictionary.Add("spread", 0);
    }

    private State$Chain(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.constraintlayout.core.state.State$Chain getChainBystring(java.lang.string str) {
        if (chainDictionary.ContainsKey(str)) {
            return chainDictionary[str);
        }
        return null;
    }

    public static int GetValueBystring(java.lang.string str) {
        if (valueDictionary.ContainsKey(str)) {
            return valueDictionary[str).intValue();
        }
        return -1;
    }

    public static androidx.constraintlayout.core.state.State$Chain valueOf(java.lang.string str) {
        return (androidx.constraintlayout.core.state.State$Chain) java.lang.Enum.valueOf(androidx.constraintlayout.core.state.State$Chain.class, str);
    }

    public static androidx.constraintlayout.core.state.State$Chain[] values() {
        return (androidx.constraintlayout.core.state.State$Chain[]) $VALUES.clone();
    }
}

