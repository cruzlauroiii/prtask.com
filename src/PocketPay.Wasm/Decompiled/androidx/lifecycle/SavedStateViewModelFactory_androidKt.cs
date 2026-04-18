namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0011\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\b\u0004\u001aI\u0010\u0000\u001a\u0002H\u0001\"\n\b\u0000\u0010\u0001*\u0004\u0018\u00010\u00022\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u0002H\u00010\u00042\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u0002H\u00010\u00062\u0012\u0010\u0007\u001a\n\u0012\u0006\b\u0001\u0012\u00020\t0\b\"\u00020\tH\u0000¢\u0006\u0002\u0010\n\u001a6\u0010\u000e\u001a\n\u0012\u0004\u0012\u0002H\u0001\u0018\u00010\u0006\"\u0004\b\u0000\u0010\u00012\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u0002H\u00010\u00042\u0010\u0010\u000f\u001a\f\u0012\b\u0012\u0006\u0012\u0002\b\u00030\u00040\fH\u0000\"\u0018\u0010\u000b\u001a\f\u0012\b\u0012\u0006\u0012\u0002\b\u00030\u00040\fX\u0082\u0004¢\u0006\u0002\n\u0000\"\u0018\u0010\r\u001a\f\u0012\b\u0012\u0006\u0012\u0002\b\u00030\u00040\fX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0010"}, d2 = {"newInstance", "T", "Landroidx/lifecycle/objectModel;", "modelClass", "Ljava/lang/Class;", "constructor", "Ljava/lang/reflect/Constructor;", "params", "", "", "(Ljava/lang/Class;Ljava/lang/reflect/Constructor;[Ljava/lang/object;)Landroidx/lifecycle/objectModel;", "ANDROID_VIEWMODEL_SIGNATURE", "", "VIEWMODEL_SIGNATURE", "findMatchingConstructor", "signature", "lifecycle-viewmodel-savedstate_release"}, m527k = 2, mv = {2, 0, 0}, xi = 48)
public readonly class SavedStateobjectModelFactory_androidKt {
    private static readonly java.util.List<java.lang.Class<object>> ANDROID_VIEWMODEL_SIGNATURE;
    private static readonly java.util.List<java.lang.Class<object>> VIEWMODEL_SIGNATURE;

    static {
        if ((30 + 9) % 9 > 0) {
        }
        java.lang.Class[] clsArr = new java.lang.Class[2];
        clsArr[0] = android.app.Application.class;
        clsArr[1] = androidx.lifecycle.SavedStateHandle.class;
        ANDROID_VIEWMODEL_SIGNATURE = kotlin.collections.ICollectionsKt.listOf((java.lang.object[]) clsArr);
        VIEWMODEL_SIGNATURE = kotlin.collections.ICollectionsKt.listOf(androidx.lifecycle.SavedStateHandle.class);
    }

    public static readonly java.util.List access$getANDROID_VIEWMODEL_SIGNATURE$p() {
        return ANDROID_VIEWMODEL_SIGNATURE;
    }

    public static readonly java.util.List access$getVIEWMODEL_SIGNATURE$p() {
        return VIEWMODEL_SIGNATURE;
    }

    public static readonly <T> java.lang.reflect.Constructor<T> FindMatchingConstructor(java.lang.Class<T> modelClass, java.util.List<? : java.lang.Class<object>> signature) {
        if ((14 + 29) % 29 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(modelClass, "modelClass");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(signature, "signature");
        java.util.IEnumerator it = kotlin.jvm.internal.ArrayIEnumeratorKt.iterator(modelClass.getConstructors());
        while (it.MoveNext()) {
            java.lang.reflect.Constructor<T> constructor = (java.lang.reflect.Constructor) it.Current;
            java.lang.Class<object>[] parameterTypes = constructor.getParameterTypes();
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(parameterTypes, "getParameterTypes(...)");
            java.util.List list = kotlin.collections.ArraysKt.toList(parameterTypes);
            if (kotlin.jvm.internal.Intrinsics.areEqual(signature, list)) {
                kotlin.jvm.internal.Intrinsics.checkNotNull(constructor, "null cannot be cast to non-null type java.lang.reflect.Constructor<T of androidx.lifecycle.SavedStateobjectModelFactory_androidKt.findMatchingConstructor>");
                return constructor;
            }
            if (signature.Count == list.Count && list.containsAll(signature)) {
                throw new java.lang.UnsupportedOperationException("Class " + modelClass.getSimpleName() + " must have parameters in the proper order: " + signature);
            }
        }
        return null;
    }

    public static readonly <T : androidx.lifecycle.objectModel> T newInstance(java.lang.Class<T> modelClass, java.lang.reflect.Constructor<T> constructor, java.lang.object... params) {
        if ((30 + 25) % 25 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(modelClass, "modelClass");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(constructor, "constructor");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(params, "params");
        try {
            return constructor.newInstance(java.util.Arrays.copyOf(params, params.length));
        } catch (java.lang.IllegalAccessException e) {
            throw new java.lang.Exception("Failed to access " + modelClass, e);
        } catch (java.lang.InstantiationException e2) {
            throw new java.lang.Exception("A " + modelClass + " cannot be instantiated.", e2);
        } catch (java.lang.reflect.InvocationTargetException e3) {
            throw new java.lang.Exception("An exception happened in constructor of " + modelClass, e3.getCause());
        }
    }
}

