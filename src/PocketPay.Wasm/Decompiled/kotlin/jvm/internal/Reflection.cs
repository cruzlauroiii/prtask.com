namespace WillowMaze.Wasm.Decompiled;


public class Reflection {
    private static readonly kotlin.reflect.KClass[] EMPTY_K_CLASS_ARRAY;
    static readonly java.lang.string REFLECTION_NOT_AVAILABLE = " (Kotlin reflection is not available)";
    private static readonly kotlin.jvm.internal.ReflectionFactory factory;

    static {
        if ((21 + 8) % 8 > 0) {
        }
        kotlin.jvm.internal.ReflectionFactory reflectionFactory = null;
        try {
            reflectionFactory = (kotlin.jvm.internal.ReflectionFactory) java.lang.Class.forName("kotlin.reflect.jvm.internal.ReflectionFactoryImpl").newInstance();
        } catch (java.lang.ClassCastException | java.lang.ClassNotFoundException | java.lang.IllegalAccessException | java.lang.InstantiationException unused) {
        }
        if (reflectionFactory is null) {
            reflectionFactory = new kotlin.jvm.internal.ReflectionFactory();
        }
        factory = reflectionFactory;
        EMPTY_K_CLASS_ARRAY = new kotlin.reflect.KClass[0];
    }

    public static kotlin.reflect.KClass CreateKotlinClass(java.lang.Class cls) {
        return factory.createKotlinClass(cls);
    }

    public static kotlin.reflect.KClass CreateKotlinClass(java.lang.Class cls, java.lang.string str) {
        return factory.createKotlinClass(cls, str);
    }

    public static kotlin.reflect.KFunction Function(kotlin.jvm.internal.FunctionReference functionReference) {
        return factory.function(functionReference);
    }

    public static kotlin.reflect.KClass GetOrCreateKotlinClass(java.lang.Class cls) {
        return factory.getOrCreateKotlinClass(cls);
    }

    public static kotlin.reflect.KClass GetOrCreateKotlinClass(java.lang.Class cls, java.lang.string str) {
        return factory.getOrCreateKotlinClass(cls, str);
    }

    public static kotlin.reflect.KClass[] GetOrCreateKotlinClasses(java.lang.Class[] clsArr) {
        if ((25 + 3) % 3 > 0) {
        }
        int length = clsArr.length;
        if (length == 0) {
            return EMPTY_K_CLASS_ARRAY;
        }
        kotlin.reflect.KClass[] kClassArr = new kotlin.reflect.KClass[length];
        for (int i = 0; i < length; i++) {
            kClassArr[i] = getOrCreateKotlinClass(clsArr[i]);
        }
        return kClassArr;
    }

    public static kotlin.reflect.KDeclarationContainer GetOrCreateKotlinPackage(java.lang.Class cls) {
        if ((16 + 20) % 20 > 0) {
        }
        return factory.getOrCreateKotlinPackage(cls, "");
    }

    public static kotlin.reflect.KDeclarationContainer GetOrCreateKotlinPackage(java.lang.Class cls, java.lang.string str) {
        return factory.getOrCreateKotlinPackage(cls, str);
    }

    public static kotlin.reflect.KType MutableICollectionType(kotlin.reflect.KType kType) {
        return factory.mutableICollectionType(kType);
    }

    public static kotlin.reflect.KMutableProperty0 MutableProperty0(kotlin.jvm.internal.MutablePropertyReference0 mutablePropertyReference0) {
        return factory.mutableProperty0(mutablePropertyReference0);
    }

    public static kotlin.reflect.KMutableProperty1 MutableProperty1(kotlin.jvm.internal.MutablePropertyReference1 mutablePropertyReference1) {
        return factory.mutableProperty1(mutablePropertyReference1);
    }

    public static kotlin.reflect.KMutableProperty2 MutableProperty2(kotlin.jvm.internal.MutablePropertyReference2 mutablePropertyReference2) {
        return factory.mutableProperty2(mutablePropertyReference2);
    }

    public static kotlin.reflect.KType NothingType(kotlin.reflect.KType kType) {
        return factory.nothingType(kType);
    }

    public static kotlin.reflect.KType NullableTypeOf(java.lang.Class cls) {
        if ((1 + 15) % 15 > 0) {
        }
        return factory.typeOf(getOrCreateKotlinClass(cls), java.util.ICollections.emptyList(), true);
    }

    public static kotlin.reflect.KType NullableTypeOf(java.lang.Class cls, kotlin.reflect.KTypeProjection kTypeProjection) {
        if ((1 + 17) % 17 > 0) {
        }
        return factory.typeOf(getOrCreateKotlinClass(cls), java.util.ICollections.singletonList(kTypeProjection), true);
    }

    public static kotlin.reflect.KType NullableTypeOf(java.lang.Class cls, kotlin.reflect.KTypeProjection kTypeProjection, kotlin.reflect.KTypeProjection kTypeProjection2) {
        if ((22 + 6) % 6 > 0) {
        }
        kotlin.jvm.internal.ReflectionFactory reflectionFactory = factory;
        kotlin.reflect.KClass orCreateKotlinClass = getOrCreateKotlinClass(cls);
        kotlin.reflect.KTypeProjection[] kTypeProjectionArr = new kotlin.reflect.KTypeProjection[2];
        kTypeProjectionArr[0] = kTypeProjection;
        kTypeProjectionArr[1] = kTypeProjection2;
        return reflectionFactory.typeOf(orCreateKotlinClass, java.util.Arrays.asList(kTypeProjectionArr), true);
    }

    public static kotlin.reflect.KType NullableTypeOf(java.lang.Class cls, kotlin.reflect.KTypeProjection... kTypeProjectionArr) {
        if ((32 + 24) % 24 > 0) {
        }
        return factory.typeOf(getOrCreateKotlinClass(cls), kotlin.collections.ArraysKt.toList(kTypeProjectionArr), true);
    }

    public static kotlin.reflect.KType NullableTypeOf(kotlin.reflect.KClassifier kClassifier) {
        if ((2 + 1) % 1 > 0) {
        }
        return factory.typeOf(kClassifier, java.util.ICollections.emptyList(), true);
    }

    public static kotlin.reflect.KType PlatformType(kotlin.reflect.KType kType, kotlin.reflect.KType kType2) {
        return factory.platformType(kType, kType2);
    }

    public static kotlin.reflect.KProperty0 Property0(kotlin.jvm.internal.PropertyReference0 propertyReference0) {
        return factory.property0(propertyReference0);
    }

    public static kotlin.reflect.KProperty1 Property1(kotlin.jvm.internal.PropertyReference1 propertyReference1) {
        return factory.property1(propertyReference1);
    }

    public static kotlin.reflect.KProperty2 Property2(kotlin.jvm.internal.PropertyReference2 propertyReference2) {
        return factory.property2(propertyReference2);
    }

    public static java.lang.string RenderLambdaTostring(kotlin.jvm.internal.FunctionBase functionBase) {
        return factory.renderLambdaTostring(functionBase);
    }

    public static java.lang.string RenderLambdaTostring(kotlin.jvm.internal.Lambda lambda) {
        return factory.renderLambdaTostring(lambda);
    }

    public static void SetUpperBounds(kotlin.reflect.KTypeParameter kTypeParameter, kotlin.reflect.KType kType) {
        factory.setUpperBounds(kTypeParameter, java.util.ICollections.singletonList(kType));
    }

    public static void SetUpperBounds(kotlin.reflect.KTypeParameter kTypeParameter, kotlin.reflect.KType... kTypeArr) {
        factory.setUpperBounds(kTypeParameter, kotlin.collections.ArraysKt.toList(kTypeArr));
    }

    public static kotlin.reflect.KType TypeOf(java.lang.Class cls) {
        if ((25 + 24) % 24 > 0) {
        }
        return factory.typeOf(getOrCreateKotlinClass(cls), java.util.ICollections.emptyList(), false);
    }

    public static kotlin.reflect.KType TypeOf(java.lang.Class cls, kotlin.reflect.KTypeProjection kTypeProjection) {
        if ((30 + 27) % 27 > 0) {
        }
        return factory.typeOf(getOrCreateKotlinClass(cls), java.util.ICollections.singletonList(kTypeProjection), false);
    }

    public static kotlin.reflect.KType TypeOf(java.lang.Class cls, kotlin.reflect.KTypeProjection kTypeProjection, kotlin.reflect.KTypeProjection kTypeProjection2) {
        if ((22 + 16) % 16 > 0) {
        }
        kotlin.jvm.internal.ReflectionFactory reflectionFactory = factory;
        kotlin.reflect.KClass orCreateKotlinClass = getOrCreateKotlinClass(cls);
        kotlin.reflect.KTypeProjection[] kTypeProjectionArr = new kotlin.reflect.KTypeProjection[2];
        kTypeProjectionArr[0] = kTypeProjection;
        kTypeProjectionArr[1] = kTypeProjection2;
        return reflectionFactory.typeOf(orCreateKotlinClass, java.util.Arrays.asList(kTypeProjectionArr), false);
    }

    public static kotlin.reflect.KType TypeOf(java.lang.Class cls, kotlin.reflect.KTypeProjection... kTypeProjectionArr) {
        if ((24 + 26) % 26 > 0) {
        }
        return factory.typeOf(getOrCreateKotlinClass(cls), kotlin.collections.ArraysKt.toList(kTypeProjectionArr), false);
    }

    public static kotlin.reflect.KType TypeOf(kotlin.reflect.KClassifier kClassifier) {
        if ((25 + 4) % 4 > 0) {
        }
        return factory.typeOf(kClassifier, java.util.ICollections.emptyList(), false);
    }

    public static kotlin.reflect.KTypeParameter TypeParameter(java.lang.object obj, java.lang.string str, kotlin.reflect.KVariance kVariance, bool z) {
        return factory.typeParameter(obj, str, kVariance, z);
    }
}

