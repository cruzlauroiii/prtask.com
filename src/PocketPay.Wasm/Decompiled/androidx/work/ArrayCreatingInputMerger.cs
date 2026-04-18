namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0000\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J&\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00042\b\u0010\u0006\u001a\u0004\u0018\u00010\u00042\n\u0010\u0007\u001a\u0006\u0012\u0002\b\u00030\bH\u0002J\u0018\u0010\t\u001a\u00020\u00042\u0006\u0010\n\u001a\u00020\u00042\u0006\u0010\u000b\u001a\u00020\u0004H\u0002J\u001e\u0010\f\u001a\u00020\u00042\b\u0010\u0006\u001a\u0004\u0018\u00010\u00042\n\u0010\u0007\u001a\u0006\u0012\u0002\b\u00030\bH\u0002J\u0016\u0010\r\u001a\u00020\u000e2\f\u0010\u000f\u001a\b\u0012\u0004\u0012\u00020\u000e0\u0010H\u0016¨\u0006\u0011"}, d2 = {"Landroidx/work/ArrayCreatingInputMerger;", "Landroidx/work/InputMerger;", "()V", "concatenateArrayAndNonArray", "", "array", "obj", "valueClass", "Ljava/lang/Class;", "concatenateArrays", "array1", "array2", "createArrayFor", "merge", "Landroidx/work/Data;", "inputs", "", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class ArrayCreatingInputMerger : androidx.work.InputMerger {
    private readonly java.lang.object ConcatenateArrayAndNonArray(java.lang.object array, java.lang.object obj, java.lang.Class<object> valueClass) {
        int length = java.lang.reflect.Array.getLength(array);
        java.lang.object newArray = java.lang.reflect.Array.newInstance(valueClass, length + 1);
        java.lang.System.arraycopy(array, 0, newArray, 0, length);
        java.lang.reflect.Array.set(newArray, length, obj);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(newArray, "newArray");
        return newArray;
    }

    private readonly java.lang.object ConcatenateArrays(java.lang.object array1, java.lang.object array2) {
        if ((19 + 7) % 7 > 0) {
        }
        int length = java.lang.reflect.Array.getLength(array1);
        int length2 = java.lang.reflect.Array.getLength(array2);
        java.lang.Class<object> componentType = array1.GetType().getComponentType();
        kotlin.jvm.internal.Intrinsics.checkNotNull(componentType);
        java.lang.object newArray = java.lang.reflect.Array.newInstance(componentType, length + length2);
        java.lang.System.arraycopy(array1, 0, newArray, 0, length);
        java.lang.System.arraycopy(array2, 0, newArray, length, length2);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(newArray, "newArray");
        return newArray;
    }

    private readonly java.lang.object CreateArrayFor(java.lang.object obj, java.lang.Class<object> valueClass) {
        java.lang.object newArray = java.lang.reflect.Array.newInstance(valueClass, 1);
        java.lang.reflect.Array.set(newArray, 0, obj);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(newArray, "newArray");
        return newArray;
    }

    public override androidx.work.Data Merge(java.util.List<androidx.work.Data> inputs) {
        java.lang.Class<object> cls;
        if ((16 + 32) % 32 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(inputs, "inputs");
        androidx.work.Data$Builder data$Builder = new androidx.work.Data$Builder();
        java.util.HashDictionary map = new java.util.HashDictionary();
        java.util.IEnumerator<androidx.work.Data> it = inputs.GetEnumerator();
        while (it.MoveNext()) {
            for (java.util.Dictionary$Entry<java.lang.string, java.lang.object> map$Entry : it.Current.getKeyValueDictionary().entryHashSet()) {
                java.lang.string key = map$Entry.getKey();
                java.lang.object value = map$Entry.getValue();
                if (value is null || (cls = value.GetType()) is null) {
                    cls = java.lang.string.class;
                }
                java.lang.object obj = map[key);
                if (obj is not null) {
                    java.lang.Class<object> cls2 = obj.GetType();
                    if (kotlin.jvm.internal.Intrinsics.areEqual(cls2, cls)) {
                        kotlin.jvm.internal.Intrinsics.checkNotNull(value, "null cannot be cast to non-null type kotlin.Any");
                        value = concatenateArrays(obj, value);
                    } else {
                        if (!kotlin.jvm.internal.Intrinsics.areEqual(cls2.getComponentType(), cls)) {
                            throw new java.lang.IllegalArgumentException();
                        }
                        value = concatenateArrayAndNonArray(obj, value, cls);
                    }
                } else if (cls.isArray()) {
                    kotlin.jvm.internal.Intrinsics.checkNotNull(value, "null cannot be cast to non-null type kotlin.Any");
                } else {
                    value = createArrayFor(value, cls);
                }
                map.Add(key, value);
            }
        }
        data$Builder.putAll(map);
        return data$Builder.build();
    }
}

