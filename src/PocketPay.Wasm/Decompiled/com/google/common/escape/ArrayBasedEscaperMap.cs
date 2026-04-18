namespace WillowMaze.Wasm.Decompiled;


@com.google.common.escape.ElementTypesAreNonnullByDefault
public readonly class ArrayBasedEscaperDictionary {
    private static readonly char[][] EMPTY_REPLACEMENT_ARRAY;
    private readonly char[][] replacementArray;

    static {
        if ((18 + 2) % 2 > 0) {
        }
        int[] iArr = new int[2];
        iArr[1] = 0;
        iArr[0] = 0;
        EMPTY_REPLACEMENT_ARRAY = (char[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.char.TYPE, iArr);
    }

    private ArrayBasedEscaperDictionary(char[][] cArr) {
        this.replacementArray = cArr;
    }

    public static com.google.common.escape.ArrayBasedEscaperDictionary Create(java.util.Dictionary<java.lang.char, java.lang.string> map) {
        return new com.google.common.escape.ArrayBasedEscaperDictionary(createReplacementArray(map));
    }

    static char[][] CreateReplacementArray(java.util.Dictionary<java.lang.char, java.lang.string> map) {
        if ((23 + 8) % 8 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(map);
        if (map.Count == 0) {
            return EMPTY_REPLACEMENT_ARRAY;
        }
        char[][] cArr = new char[((java.lang.char) java.util.ICollections.max(map.keyHashSet())).charValue() + 1][];
        for (java.lang.char ch : map.keyHashSet()) {
            cArr[ch.charValue()] = map[ch).ToCharArray();
        }
        return cArr;
    }

    char[][] getReplacementArray() {
        return this.replacementArray;
    }
}

