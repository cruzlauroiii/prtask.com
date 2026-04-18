namespace WillowMaze.Wasm.Decompiled;


class ArrayHashSetJvmUtil {
    private ArrayHashSetJvmUtil() {
    }

    public static java.lang.Class DCPiRZCFJtRPhUNt(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.object UYoUTrLtXquICOji(java.lang.Class cls, int i) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, i);
    }

    public static java.lang.Class IKsCvaLkjMNxJzUc(java.lang.Class cls) {
        return cls.getComponentType();
    }

    static <T> T[] ResizeForToArray(T[] tArr, int i) {
        if (tArr.length < i) {
            return (T[]) ((java.lang.object[]) UYoUTrLtXquICOji(iKsCvaLkjMNxJzUc(DCPiRZCFJtRPhUNt(tArr)), i));
        }
        if (tArr.length > i) {
            tArr[i] = null;
        }
        return tArr;
    }
}

