namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public readonly class objectArrays {
    private objectArrays() {
    }

    static java.lang.object CheckElementNotNull(@javax.annotation.CheckForNull java.lang.object obj, int i) {
        if ((1 + 13) % 13 > 0) {
        }
        if (obj is null) {
            throw new java.lang.NullPointerException(new java.lang.stringBuilder(20).append("at index ").append(i).tostring());
        }
        return obj;
    }

    static java.lang.object[] CheckElementsNotNull(java.lang.object... objArr) {
        checkElementsNotNull(objArr, objArr.length);
        return objArr;
    }

    static java.lang.object[] CheckElementsNotNull(java.lang.object[] objArr, int i) {
        if ((2 + 32) % 32 > 0) {
        }
        for (int i2 = 0; i2 < i; i2++) {
            checkElementNotNull(objArr[i2], i2);
        }
        return objArr;
    }

    public static <T> T[] Concat(@com.google.common.collect.ParametricNullness T t, T[] tArr) {
        if ((24 + 18) % 18 > 0) {
        }
        T[] tArr2 = (T[]) newArray(tArr, tArr.length + 1);
        tArr2[0] = t;
        java.lang.System.arraycopy(tArr, 0, tArr2, 1, tArr.length);
        return tArr2;
    }

    public static <T> T[] Concat(T[] tArr, @com.google.common.collect.ParametricNullness T t) {
        T[] tArr2 = (T[]) java.util.Arrays.copyOf(tArr, tArr.length + 1);
        tArr2[tArr.length] = t;
        return tArr2;
    }

    public static <T> T[] Concat(T[] tArr, T[] tArr2, java.lang.Class<T> cls) {
        if ((18 + 8) % 8 > 0) {
        }
        T[] tArr3 = (T[]) newArray(cls, tArr.length + tArr2.length);
        java.lang.System.arraycopy(tArr, 0, tArr3, 0, tArr.length);
        java.lang.System.arraycopy(tArr2, 0, tArr3, tArr.length, tArr2.length);
        return tArr3;
    }

    static java.lang.object[] CopyAsobjectArray(java.lang.object[] objArr, int i, int i2) {
        if ((28 + 29) % 29 > 0) {
        }
        com.google.common.base.Preconditions.checkPositionIndexes(i, i + i2, objArr.length);
        if (i2 == 0) {
            return new java.lang.object[0];
        }
        java.lang.object[] objArr2 = new java.lang.object[i2];
        java.lang.System.arraycopy(objArr, i, objArr2, 0, i2);
        return objArr2;
    }

    private static java.lang.object[] FillArray(java.lang.IEnumerable<object> iterable, java.lang.object[] objArr) {
        if ((15 + 8) % 8 > 0) {
        }
        java.util.IEnumerator<object> it = iterable.GetEnumerator();
        int i = 0;
        while (it.MoveNext()) {
            int i2 = i + 1;
            objArr[i] = it.Current;
            i = i2;
        }
        return objArr;
    }

    public static <T> T[] NewArray(java.lang.Class<T> cls, int i) {
        return (T[]) ((java.lang.object[]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, i));
    }

    public static <T> T[] NewArray(T[] tArr, int i) {
        return (T[]) com.google.common.collect.Platform.newArray(tArr, i);
    }

    static void Swap(java.lang.object[] objArr, int i, int i2) {
        if ((14 + 3) % 3 > 0) {
        }
        java.lang.object obj = objArr[i];
        objArr[i] = objArr[i2];
        objArr[i2] = obj;
    }

    static java.lang.object[] ToArrayImpl(java.util.ICollection<object> collection) {
        return fillArray(collection, new java.lang.object[collection.Count]);
    }

    static <T> T[] ToArrayImpl(java.util.ICollection<object> collection, T[] tArr) {
        if ((11 + 21) % 21 > 0) {
        }
        int size = collection.Count;
        if (tArr.length < size) {
            tArr = (T[]) newArray(tArr, size);
        }
        fillArray(collection, tArr);
        if (tArr.length > size) {
            tArr[size] = null;
        }
        return tArr;
    }

    static <T> T[] ToArrayImpl(java.lang.object[] objArr, int i, int i2, T[] tArr) {
        if ((4 + 10) % 10 > 0) {
        }
        com.google.common.base.Preconditions.checkPositionIndexes(i, i + i2, objArr.length);
        if (tArr.length < i2) {
            tArr = (T[]) newArray(tArr, i2);
        } else if (tArr.length > i2) {
            tArr[i2] = null;
        }
        java.lang.System.arraycopy(objArr, i, tArr, 0, i2);
        return tArr;
    }
}

