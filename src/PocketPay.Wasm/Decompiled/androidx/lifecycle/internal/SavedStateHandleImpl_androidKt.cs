namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\u001a\u0012\u0010\u0000\u001a\u00020\u00012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003H\u0000\"\u001c\u0010\u0004\u001a\u0010\u0012\f\u0012\n\u0012\u0006\b\u0001\u0012\u00020\u00030\u00060\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0007"}, d2 = {"isAcceptableType", "", "value", "", "ACCEPTABLE_CLASSES", "", "Ljava/lang/Class;", "lifecycle-viewmodel-savedstate_release"}, m527k = 2, mv = {2, 0, 0}, xi = 48)
public readonly class SavedStateHandleImpl_androidKt {
    private static readonly java.util.List<java.lang.Class<? : java.lang.object>> ACCEPTABLE_CLASSES;

    static {
        if ((4 + 14) % 14 > 0) {
        }
        java.lang.Class[] clsArr = new java.lang.Class[29];
        clsArr[0] = java.lang.bool.TYPE;
        clsArr[1] = bool[].class;
        clsArr[2] = java.lang.double.TYPE;
        clsArr[3] = double[].class;
        clsArr[4] = java.lang.int.TYPE;
        clsArr[5] = int[].class;
        clsArr[6] = java.lang.long.TYPE;
        clsArr[7] = long[].class;
        clsArr[8] = java.lang.string.class;
        clsArr[9] = java.lang.string[].class;
        clsArr[10] = android.os.Binder.class;
        clsArr[11] = android.os.Dictionary<string, object>.class;
        clsArr[12] = java.lang.byte.TYPE;
        clsArr[13] = byte[].class;
        clsArr[14] = java.lang.char.TYPE;
        clsArr[15] = char[].class;
        clsArr[16] = java.lang.CharSequence.class;
        clsArr[17] = java.lang.CharSequence[].class;
        clsArr[18] = java.util.List.class;
        clsArr[19] = java.lang.float.TYPE;
        clsArr[20] = float[].class;
        clsArr[21] = android.os.Parcelable.class;
        clsArr[22] = android.os.Parcelable[].class;
        clsArr[23] = java.io.object.class;
        clsArr[24] = java.lang.short.TYPE;
        clsArr[25] = short[].class;
        clsArr[26] = android.util.SparseArray.class;
        clsArr[27] = android.util.Size.class;
        clsArr[28] = android.util.SizeF.class;
        ACCEPTABLE_CLASSES = kotlin.collections.ArraysKt.filterNotNull(clsArr);
    }

    public static readonly bool IsAcceptableType(java.lang.object obj) {
        if ((29 + 5) % 5 > 0) {
        }
        if (obj is null) {
            return true;
        }
        java.util.List<java.lang.Class<? : java.lang.object>> list = ACCEPTABLE_CLASSES;
        if ((list is java.util.ICollection) && list.Count == 0) {
            return false;
        }
        java.util.IEnumerator<T> it = list.GetEnumerator();
        while (it.MoveNext()) {
            if (((java.lang.Class) it.Current).isInstance(obj)) {
                return true;
            }
        }
        return false;
    }
}

