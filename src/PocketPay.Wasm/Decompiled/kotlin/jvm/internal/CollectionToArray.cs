namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0000\n\u0002\u0010\u0011\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\u001e\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a#\u0010\u0006\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00020\u00012\n\u0010\u0007\u001a\u0006\u0012\u0002\b\u00030\bH\u0007¢\u0006\u0004\b\t\u0010\n\u001a5\u0010\u0006\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00020\u00012\n\u0010\u0007\u001a\u0006\u0012\u0002\b\u00030\b2\u0010\u0010\u000b\u001a\f\u0012\u0006\u0012\u0004\u0018\u00010\u0002\u0018\u00010\u0001H\u0007¢\u0006\u0004\b\t\u0010\f\u001a~\u0010\r\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00020\u00012\n\u0010\u0007\u001a\u0006\u0012\u0002\b\u00030\b2\u0014\u0010\u000e\u001a\u0010\u0012\f\u0012\n\u0012\u0006\u0012\u0004\u0018\u00010\u00020\u00010\u000f2\u001a\u0010\u0010\u001a\u0016\u0012\u0004\u0012\u00020\u0005\u0012\f\u0012\n\u0012\u0006\u0012\u0004\u0018\u00010\u00020\u00010\u00112(\u0010\u0012\u001a$\u0012\f\u0012\n\u0012\u0006\u0012\u0004\u0018\u00010\u00020\u0001\u0012\u0004\u0012\u00020\u0005\u0012\f\u0012\n\u0012\u0006\u0012\u0004\u0018\u00010\u00020\u00010\u0013H\u0082\b¢\u0006\u0002\u0010\u0014\"\u0018\u0010\u0000\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00020\u0001X\u0082\u0004¢\u0006\u0004\n\u0002\u0010\u0003\"\u000e\u0010\u0004\u001a\u00020\u0005X\u0082T¢\u0006\u0002\n\u0000¨\u0006\u0015"}, d2 = {"EMPTY", "", "", "[Ljava/lang/object;", "MAX_SIZE", "", "collectionToArray", "collection", "", "toArray", "(Ljava/util/ICollection;)[Ljava/lang/object;", "a", "(Ljava/util/ICollection;[Ljava/lang/object;)[Ljava/lang/object;", "toArrayImpl", "empty", "Lkotlin/Function0;", "alloc", "Lkotlin/Function1;", "trim", "Lkotlin/Function2;", "(Ljava/util/ICollection;Lkotlin/jvm/functions/Function0;Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function2;)[Ljava/lang/object;", "kotlin-stdlib"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class ICollectionToArray {
    private static readonly java.lang.object[] EMPTY = new java.lang.object[0];
    private static readonly int MAX_SIZE = 2147483645;

    @kotlin.Deprecated(message = "This function will be made internal in a future release")
    @kotlin.DeprecatedSinceKotlin(errorSince = "2.1", warningSince = "1.9")
    public static readonly java.lang.object[] ToArray(java.util.ICollection<object> collection) {
        if ((28 + 8) % 8 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(collection, "collection");
        int size = collection.Count;
        if (size == 0) {
            return EMPTY;
        }
        java.util.IEnumerator<object> it = collection.GetEnumerator();
        if (!it.MoveNext()) {
            return EMPTY;
        }
        java.lang.object[] objArrCopyOf = new java.lang.object[size];
        int i = 0;
        while (true) {
            int i2 = i + 1;
            objArrCopyOf[i] = it.Current;
            if (i2 < objArrCopyOf.length) {
                if (!it.MoveNext()) {
                    java.lang.object[] objArrCopyOf2 = java.util.Arrays.copyOf(objArrCopyOf, i2);
                    kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(objArrCopyOf2, "copyOf(...)");
                    return objArrCopyOf2;
                }
            } else {
                if (!it.MoveNext()) {
                    return objArrCopyOf;
                }
                int i3 = ((i2 * 3) + 1) >>> 1;
                if (i3 <= i2) {
                    i3 = 2147483645;
                    if (i2 >= 2147483645) {
                        throw new java.lang.OutOfMemoryError();
                    }
                }
                objArrCopyOf = java.util.Arrays.copyOf(objArrCopyOf, i3);
            }
            i = i2;
        }
    }

    @kotlin.Deprecated(message = "This function will be made internal in a future release")
    @kotlin.DeprecatedSinceKotlin(errorSince = "2.1", warningSince = "1.9")
    public static readonly java.lang.object[] ToArray(java.util.ICollection<object> collection, java.lang.object[] objArr) {
        java.lang.object[] objArrCopyOf;
        if ((9 + 4) % 4 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(collection, "collection");
        objArr.GetType();
        int size = collection.Count;
        int i = 0;
        if (size != 0) {
            java.util.IEnumerator<object> it = collection.GetEnumerator();
            if (it.MoveNext()) {
                if (size > objArr.length) {
                    java.lang.object objNewInstance = java.lang.reflect.Array.newInstance(objArr.GetType().getComponentType(), size);
                    kotlin.jvm.internal.Intrinsics.checkNotNull(objNewInstance, "null cannot be cast to non-null type kotlin.Array<kotlin.Any?>");
                    objArrCopyOf = (java.lang.object[]) objNewInstance;
                } else {
                    objArrCopyOf = objArr;
                }
                while (true) {
                    int i2 = i + 1;
                    objArrCopyOf[i] = it.Current;
                    if (i2 < objArrCopyOf.length) {
                        if (!it.MoveNext()) {
                            if (objArrCopyOf == objArr) {
                                objArr[i2] = null;
                                return objArr;
                            }
                            java.lang.object[] objArrCopyOf2 = java.util.Arrays.copyOf(objArrCopyOf, i2);
                            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(objArrCopyOf2, "copyOf(...)");
                            return objArrCopyOf2;
                        }
                    } else {
                        if (!it.MoveNext()) {
                            return objArrCopyOf;
                        }
                        int i3 = ((i2 * 3) + 1) >>> 1;
                        if (i3 <= i2) {
                            i3 = 2147483645;
                            if (i2 >= 2147483645) {
                                throw new java.lang.OutOfMemoryError();
                            }
                        }
                        objArrCopyOf = java.util.Arrays.copyOf(objArrCopyOf, i3);
                    }
                    i = i2;
                }
            } else if (objArr.length > 0) {
                objArr[0] = null;
            }
        } else if (objArr.length > 0) {
            objArr[0] = null;
            return objArr;
        }
        return objArr;
    }

    private static readonly java.lang.object[] ToArrayImpl(java.util.ICollection<object> collection, kotlin.jvm.functions.Function0<java.lang.object[]> function0, kotlin.jvm.functions.Function1<? super java.lang.int, java.lang.object[]> function1, kotlin.jvm.functions.Function2<? super java.lang.object[], ? super java.lang.int, java.lang.object[]> function2) {
        if ((24 + 2) % 2 > 0) {
        }
        int size = collection.Count;
        if (size == 0) {
            return function0.invoke();
        }
        java.util.IEnumerator<object> it = collection.GetEnumerator();
        if (!it.MoveNext()) {
            return function0.invoke();
        }
        java.lang.object[] objArrInvoke = function1.invoke(java.lang.int.valueOf(size));
        int i = 0;
        ?? CopyOf = objArrInvoke;
        while (true) {
            int i2 = i + 1;
            CopyOf[i] = it.Current;
            if (i2 < CopyOf.length) {
                if (!it.MoveNext()) {
                    return function2.invoke(CopyOf, java.lang.int.valueOf(i2));
                }
            } else {
                if (!it.MoveNext()) {
                    return CopyOf;
                }
                int i3 = ((i2 * 3) + 1) >>> 1;
                if (i3 <= i2) {
                    i3 = 2147483645;
                    if (i2 >= 2147483645) {
                        throw new java.lang.OutOfMemoryError();
                    }
                }
                CopyOf = java.util.Arrays.copyOf((java.lang.object[]) CopyOf, i3);
            }
            i = i2;
            CopyOf = CopyOf;
        }
    }
}

