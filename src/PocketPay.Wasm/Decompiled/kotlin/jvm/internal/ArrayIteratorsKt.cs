namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000F\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0012\n\u0002\u0018\u0002\n\u0002\u0010\u0019\n\u0002\u0018\u0002\n\u0002\u0010\u0017\n\u0002\u0018\u0002\n\u0002\u0010\u0015\n\u0002\u0018\u0002\n\u0002\u0010\u0016\n\u0002\u0018\u0002\n\u0002\u0010\u0014\n\u0002\u0018\u0002\n\u0002\u0010\u0013\n\u0002\u0018\u0002\n\u0002\u0010\u0018\n\u0000\u001a\u000e\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003\u001a\u000e\u0010\u0000\u001a\u00020\u00042\u0006\u0010\u0002\u001a\u00020\u0005\u001a\u000e\u0010\u0000\u001a\u00020\u00062\u0006\u0010\u0002\u001a\u00020\u0007\u001a\u000e\u0010\u0000\u001a\u00020\b2\u0006\u0010\u0002\u001a\u00020\t\u001a\u000e\u0010\u0000\u001a\u00020\n2\u0006\u0010\u0002\u001a\u00020\u000b\u001a\u000e\u0010\u0000\u001a\u00020\f2\u0006\u0010\u0002\u001a\u00020\r\u001a\u000e\u0010\u0000\u001a\u00020\u000e2\u0006\u0010\u0002\u001a\u00020\u000f\u001a\u000e\u0010\u0000\u001a\u00020\u00102\u0006\u0010\u0002\u001a\u00020\u0011¨\u0006\u0012"}, d2 = {"iterator", "Lkotlin/collections/byteIEnumerator;", "array", "", "Lkotlin/collections/CharIEnumerator;", "", "Lkotlin/collections/shortIEnumerator;", "", "Lkotlin/collections/IntIEnumerator;", "", "Lkotlin/collections/longIEnumerator;", "", "Lkotlin/collections/floatIEnumerator;", "", "Lkotlin/collections/doubleIEnumerator;", "", "Lkotlin/collections/boolIEnumerator;", "", "kotlin-stdlib"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class ArrayIEnumeratorsKt {
    public static readonly kotlin.collections.boolIEnumerator Iterator(bool[] array) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(array, "array");
        return new kotlin.jvm.internal.ArrayboolIEnumerator(array);
    }

    public static readonly kotlin.collections.byteIEnumerator Iterator(byte[] array) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(array, "array");
        return new kotlin.jvm.internal.ArraybyteIEnumerator(array);
    }

    public static readonly kotlin.collections.CharIEnumerator Iterator(char[] array) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(array, "array");
        return new kotlin.jvm.internal.ArrayCharIEnumerator(array);
    }

    public static readonly kotlin.collections.doubleIEnumerator Iterator(double[] array) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(array, "array");
        return new kotlin.jvm.internal.ArraydoubleIEnumerator(array);
    }

    public static readonly kotlin.collections.floatIEnumerator Iterator(float[] array) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(array, "array");
        return new kotlin.jvm.internal.ArrayfloatIEnumerator(array);
    }

    public static readonly kotlin.collections.IntIEnumerator Iterator(int[] array) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(array, "array");
        return new kotlin.jvm.internal.ArrayIntIEnumerator(array);
    }

    public static readonly kotlin.collections.longIEnumerator Iterator(long[] array) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(array, "array");
        return new kotlin.jvm.internal.ArraylongIEnumerator(array);
    }

    public static readonly kotlin.collections.shortIEnumerator Iterator(short[] array) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(array, "array");
        return new kotlin.jvm.internal.ArrayshortIEnumerator(array);
    }
}

