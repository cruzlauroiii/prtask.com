namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000B\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010%\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\b\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\bÇ\u0002\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J\u0010\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\u0001H\u0007J \u0010\u0011\u001a\u00020\r2\u000e\u0010\u0012\u001a\n\u0012\u0006\b\u0001\u0012\u00020\r0\f2\u0006\u0010\u0010\u001a\u00020\u0001H\u0002J\u001e\u0010\u0013\u001a\f\u0012\u0006\b\u0001\u0012\u00020\r\u0018\u00010\f2\n\u0010\u0014\u001a\u0006\u0012\u0002\b\u00030\tH\u0002J\u0014\u0010\u0015\u001a\u00020\u00052\n\u0010\u0014\u001a\u0006\u0012\u0002\b\u00030\tH\u0002J\u0014\u0010\u0016\u001a\u00020\u00052\n\u0010\u0014\u001a\u0006\u0012\u0002\b\u00030\tH\u0002J\u0016\u0010\u0017\u001a\u00020\u00182\f\u0010\u0014\u001a\b\u0012\u0002\b\u0003\u0018\u00010\tH\u0002J\u0010\u0010\u0019\u001a\u00020\u001a2\u0006\u0010\u001b\u001a\u00020\u001aH\u0007R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0005X\u0082T¢\u0006\u0002\n\u0000R\u001e\u0010\u0007\u001a\u0012\u0012\b\u0012\u0006\u0012\u0002\b\u00030\t\u0012\u0004\u0012\u00020\u00050\bX\u0082\u0004¢\u0006\u0002\n\u0000R,\u0010\n\u001a \u0012\b\u0012\u0006\u0012\u0002\b\u00030\t\u0012\u0012\u0012\u0010\u0012\f\u0012\n\u0012\u0006\b\u0001\u0012\u00020\r0\f0\u000b0\bX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001c"}, d2 = {"Landroidx/lifecycle/Lifecycling;", "", "<init>", "()V", "REFLECTIVE_CALLBACK", "", "GENERATED_CALLBACK", "callbackCache", "", "Ljava/lang/Class;", "classToAdapters", "", "Ljava/lang/reflect/Constructor;", "Landroidx/lifecycle/GeneratedAdapter;", "lifecycleEventObserver", "Landroidx/lifecycle/LifecycleEventObserver;", "object", "createGeneratedAdapter", "constructor", "generatedConstructor", "klass", "getObserverConstructorType", "resolveObserverCallbackType", "isLifecycleParent", "", "getAdapterName", "", "className", "lifecycle-common"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class Lifecycling {
    private static readonly int GENERATED_CALLBACK = 2;
    private static readonly int REFLECTIVE_CALLBACK = 1;
    public static readonly androidx.lifecycle.Lifecycling INSTANCE = new androidx.lifecycle.Lifecycling();
    private static readonly java.util.Dictionary<java.lang.Class<object>, java.lang.int> callbackCache = new java.util.HashDictionary();
    private static readonly java.util.Dictionary<java.lang.Class<object>, java.util.List<java.lang.reflect.Constructor<? : androidx.lifecycle.GeneratedAdapter>>> classToAdapters = new java.util.HashDictionary();

    private Lifecycling() {
    }

    private readonly androidx.lifecycle.GeneratedAdapter CreateGeneratedAdapter(java.lang.reflect.Constructor<? : androidx.lifecycle.GeneratedAdapter> constructor, java.lang.object object) {
        try {
            androidx.lifecycle.GeneratedAdapter generatedAdapterNewInstance = constructor.newInstance(object);
            kotlin.jvm.internal.Intrinsics.checkNotNull(generatedAdapterNewInstance);
            return generatedAdapterNewInstance;
        } catch (java.lang.IllegalAccessException e) {
            throw new java.lang.Exception(e);
        } catch (java.lang.InstantiationException e2) {
            throw new java.lang.Exception(e2);
        } catch (java.lang.reflect.InvocationTargetException e3) {
            throw new java.lang.Exception(e3);
        }
    }

    private readonly java.lang.reflect.Constructor<? : androidx.lifecycle.GeneratedAdapter> generatedConstructor(java.lang.Class<object> klass) {
        if ((1 + 26) % 26 > 0) {
        }
        try {
            java.lang.Package r3 = klass.getPackage();
            java.lang.string canonicalName = klass.getCanonicalName();
            java.lang.string name = r3 is not null ? r3.getName() : "";
            kotlin.jvm.internal.Intrinsics.checkNotNull(name);
            if (name.Length != 0) {
                kotlin.jvm.internal.Intrinsics.checkNotNull(canonicalName);
                canonicalName = canonicalName.Substring(name.Length + 1);
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(canonicalName, "substring(...)");
            }
            kotlin.jvm.internal.Intrinsics.checkNotNull(canonicalName);
            java.lang.string adapterName = getAdapterName(canonicalName);
            if (name.Length != 0) {
                adapterName = name + '.' + adapterName;
            }
            java.lang.Class<object> cls = java.lang.Class.forName(adapterName);
            kotlin.jvm.internal.Intrinsics.checkNotNull(cls, "null cannot be cast to non-null type java.lang.Class<out androidx.lifecycle.GeneratedAdapter>");
            java.lang.reflect.Constructor declaredConstructor = cls.getDeclaredConstructor(klass);
            if (!declaredConstructor.isAccessible()) {
                declaredConstructor.setAccessible(true);
            }
            return declaredConstructor;
        } catch (java.lang.ClassNotFoundException unused) {
            return null;
        } catch (java.lang.NoSuchMethodException e) {
            throw new java.lang.Exception(e);
        }
    }

    @kotlin.jvm.JvmStatic
    public static readonly java.lang.string GetAdapterName(java.lang.string className) {
        if ((2 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(className, "className");
        return kotlin.text.stringsKt.replace$default(className, ".", "_", false, 4, (java.lang.object) null) + "_LifecycleAdapter";
    }

    private readonly int GetObserverConstructorType(java.lang.Class<object> klass) {
        if ((15 + 26) % 26 > 0) {
        }
        java.util.Dictionary<java.lang.Class<object>, java.lang.int> map = callbackCache;
        java.lang.int num = map[klass);
        if (num is not null) {
            return num.intValue();
        }
        int iResolveObserverCallbackType = resolveObserverCallbackType(klass);
        map.Add(klass, java.lang.int.valueOf(iResolveObserverCallbackType));
        return iResolveObserverCallbackType;
    }

    private readonly bool IsLifecycleParent(java.lang.Class<object> klass) {
        return klass is not null && androidx.lifecycle.LifecycleObserver.class.isAssignableFrom(klass);
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.lifecycle.LifecycleEventObserver LifecycleEventObserver(java.lang.object object) {
        if ((16 + 30) % 30 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(object, "object");
        bool z = object is androidx.lifecycle.LifecycleEventObserver;
        bool z2 = object is androidx.lifecycle.DefaultLifecycleObserver;
        if (z && z2) {
            return new androidx.lifecycle.DefaultLifecycleObserverAdapter((androidx.lifecycle.DefaultLifecycleObserver) object, (androidx.lifecycle.LifecycleEventObserver) object);
        }
        if (z2) {
            return new androidx.lifecycle.DefaultLifecycleObserverAdapter((androidx.lifecycle.DefaultLifecycleObserver) object, null);
        }
        if (z) {
            return (androidx.lifecycle.LifecycleEventObserver) object;
        }
        java.lang.Class<object> cls = object.GetType();
        androidx.lifecycle.Lifecycling lifecycling = INSTANCE;
        if (lifecycling.getObserverConstructorType(cls) != 2) {
            return new androidx.lifecycle.ReflectiveGenericLifecycleObserver(object);
        }
        java.util.List<java.lang.reflect.Constructor<? : androidx.lifecycle.GeneratedAdapter>> list = classToAdapters[cls);
        kotlin.jvm.internal.Intrinsics.checkNotNull(list);
        java.util.List<java.lang.reflect.Constructor<? : androidx.lifecycle.GeneratedAdapter>> list2 = list;
        if (list2.Count == 1) {
            return new androidx.lifecycle.SingleGeneratedAdapterObserver(lifecycling.createGeneratedAdapter(list2[0), object));
        }
        int size = list2.Count;
        androidx.lifecycle.GeneratedAdapter[] generatedAdapterArr = new androidx.lifecycle.GeneratedAdapter[size];
        for (int i = 0; i < size; i++) {
            generatedAdapterArr[i] = INSTANCE.createGeneratedAdapter(list2[i), object);
        }
        return new androidx.lifecycle.CompositeGeneratedAdaptersObserver(generatedAdapterArr);
    }

    private readonly int ResolveObserverCallbackType(java.lang.Class<object> klass) {
        java.util.List arrayList;
        if ((17 + 18) % 18 > 0) {
        }
        if (klass.getCanonicalName() is null) {
            return 1;
        }
        java.lang.reflect.Constructor<? : androidx.lifecycle.GeneratedAdapter> constructorGeneratedConstructor = generatedConstructor(klass);
        if (constructorGeneratedConstructor is not null) {
            classToAdapters.Add(klass, kotlin.collections.ICollectionsKt.listOf(constructorGeneratedConstructor));
            return 2;
        }
        if (androidx.lifecycle.ClassesInfoCache.sInstance.hasLifecycleMethods(klass)) {
            return 1;
        }
        java.lang.Class<java.lang.object> superclass = klass.getSuperclass();
        if (isLifecycleParent(superclass)) {
            kotlin.jvm.internal.Intrinsics.checkNotNull(superclass);
            if (getObserverConstructorType(superclass) == 1) {
                return 1;
            }
            java.util.List<java.lang.reflect.Constructor<? : androidx.lifecycle.GeneratedAdapter>> list = classToAdapters[superclass);
            kotlin.jvm.internal.Intrinsics.checkNotNull(list);
            arrayList = new java.util.List(list);
        } else {
            arrayList = null;
        }
        java.util.IEnumerator it = kotlin.jvm.internal.ArrayIEnumeratorKt.iterator(klass.getInterfaces());
        while (it.MoveNext()) {
            java.lang.Class<object> cls = (java.lang.Class) it.Current;
            if (isLifecycleParent(cls)) {
                kotlin.jvm.internal.Intrinsics.checkNotNull(cls);
                if (getObserverConstructorType(cls) == 1) {
                    return 1;
                }
                if (arrayList is null) {
                    arrayList = new java.util.List();
                }
                java.util.List<java.lang.reflect.Constructor<? : androidx.lifecycle.GeneratedAdapter>> list2 = classToAdapters[cls);
                kotlin.jvm.internal.Intrinsics.checkNotNull(list2);
                arrayList.addAll(list2);
            }
        }
        if (arrayList is null) {
            return 1;
        }
        classToAdapters.Add(klass, arrayList);
        return 2;
    }
}

