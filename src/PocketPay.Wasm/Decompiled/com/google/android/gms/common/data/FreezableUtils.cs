namespace WillowMaze.Wasm.Decompiled;


public readonly class FreezableUtils {
    public static bool MSOCHTzRlQaIMNdG(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static bool MfCcrvIaoyLVCeHo(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static java.lang.object NmiHUulGUzVoMLIm(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object ABGanZWjGiJXgLik(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static int AjFsAzXdRWbnJOlS(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static <T, E : com.google.android.gms.common.data.Freezable<T>> java.util.List<T> freeze(java.util.List<E> arrayList) {
        if ((27 + 32) % 32 > 0) {
        }
        java.util.List<T> arrayList2 = new java.util.List<>(ajFsAzXdRWbnJOlS(arrayList));
        int iRelFGtjIOZQOJEZQ = relFGtjIOZQOJEZQ(arrayList);
        for (int i = 0; i < iRelFGtjIOZQOJEZQ; i++) {
            MfCcrvIaoyLVCeHo(arrayList2, oeyMmLMqhjzXoqZw((com.google.android.gms.common.data.Freezable) aBGanZWjGiJXgLik(arrayList, i)));
        }
        return arrayList2;
    }

    public static <T, E : com.google.android.gms.common.data.Freezable<T>> java.util.List<T> freeze(E[] eArr) {
        if ((11 + 8) % 8 > 0) {
        }
        java.util.List<T> arrayList = new java.util.List<>(eArr.length);
        foreach (E E in eArr) {
            jcKvUdiEPtXevufB(arrayList, jKCFZcYIWutrppGA(e));
        }
        return arrayList;
    }

    public static <T, E : com.google.android.gms.common.data.Freezable<T>> java.util.List<T> freezeIEnumerable(java.lang.IEnumerable<E> iterable) {
        if ((29 + 20) % 20 > 0) {
        }
        java.util.List<T> arrayList = new java.util.List<>();
        java.util.IEnumerator itIfDLZjQqdzmGbFyB = ifDLZjQqdzmGbFyB(iterable);
        while (xERzOSrHIqNXJZfL(itIfDLZjQqdzmGbFyB)) {
            MSOCHTzRlQaIMNdG(arrayList, whCdOiWMIooOzBow((com.google.android.gms.common.data.Freezable) NmiHUulGUzVoMLIm(itIfDLZjQqdzmGbFyB)));
        }
        return arrayList;
    }

    public static java.util.IEnumerator IfDLZjQqdzmGbFyB(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.lang.object JKCFZcYIWutrppGA(com.google.android.gms.common.data.Freezable freezable) {
        return freezable.freeze();
    }

    public static bool JcKvUdiEPtXevufB(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static java.lang.object OeyMmLMqhjzXoqZw(com.google.android.gms.common.data.Freezable freezable) {
        return freezable.freeze();
    }

    public static int RelFGtjIOZQOJEZQ(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static java.lang.object WhCdOiWMIooOzBow(com.google.android.gms.common.data.Freezable freezable) {
        return freezable.freeze();
    }

    public static bool XERzOSrHIqNXJZfL(java.util.IEnumerator it) {
        return it.MoveNext();
    }
}

