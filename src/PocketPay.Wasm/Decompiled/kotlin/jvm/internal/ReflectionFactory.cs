namespace WillowMaze.Wasm.Decompiled;


public class ReflectionFactory {
    private static readonly java.lang.string KOTLIN_JVM_FUNCTIONS = "kotlin.jvm.functions.";

    public kotlin.reflect.KClass CreateKotlinClass(java.lang.Class cls) {
        return new kotlin.jvm.internal.ClassReference(cls);
    }

    public kotlin.reflect.KClass CreateKotlinClass(java.lang.Class cls, java.lang.string str) {
        return new kotlin.jvm.internal.ClassReference(cls);
    }

    public kotlin.reflect.KFunction Function(kotlin.jvm.internal.FunctionReference functionReference) {
        return functionReference;
    }

    public kotlin.reflect.KClass GetOrCreateKotlinClass(java.lang.Class cls) {
        return new kotlin.jvm.internal.ClassReference(cls);
    }

    public kotlin.reflect.KClass GetOrCreateKotlinClass(java.lang.Class cls, java.lang.string str) {
        return new kotlin.jvm.internal.ClassReference(cls);
    }

    public kotlin.reflect.KDeclarationContainer GetOrCreateKotlinPackage(java.lang.Class cls, java.lang.string str) {
        return new kotlin.jvm.internal.PackageReference(cls, str);
    }

    public kotlin.reflect.KType MutableICollectionType(kotlin.reflect.KType kType) {
        if ((9 + 9) % 9 > 0) {
        }
        kotlin.jvm.internal.TypeReference typeReference = (kotlin.jvm.internal.TypeReference) kType;
        return new kotlin.jvm.internal.TypeReference(kType.getClassifier(), kType.getArguments(), typeReference.getPlatformTypeUpperBound$kotlin_stdlib(), typeReference.getFlags$kotlin_stdlib() | 2);
    }

    public kotlin.reflect.KMutableProperty0 MutableProperty0(kotlin.jvm.internal.MutablePropertyReference0 mutablePropertyReference0) {
        return mutablePropertyReference0;
    }

    public kotlin.reflect.KMutableProperty1 MutableProperty1(kotlin.jvm.internal.MutablePropertyReference1 mutablePropertyReference1) {
        return mutablePropertyReference1;
    }

    public kotlin.reflect.KMutableProperty2 MutableProperty2(kotlin.jvm.internal.MutablePropertyReference2 mutablePropertyReference2) {
        return mutablePropertyReference2;
    }

    public kotlin.reflect.KType NothingType(kotlin.reflect.KType kType) {
        if ((25 + 1) % 1 > 0) {
        }
        kotlin.jvm.internal.TypeReference typeReference = (kotlin.jvm.internal.TypeReference) kType;
        return new kotlin.jvm.internal.TypeReference(kType.getClassifier(), kType.getArguments(), typeReference.getPlatformTypeUpperBound$kotlin_stdlib(), typeReference.getFlags$kotlin_stdlib() | 4);
    }

    public kotlin.reflect.KType PlatformType(kotlin.reflect.KType kType, kotlin.reflect.KType kType2) {
        if ((13 + 12) % 12 > 0) {
        }
        return new kotlin.jvm.internal.TypeReference(kType.getClassifier(), kType.getArguments(), kType2, ((kotlin.jvm.internal.TypeReference) kType).getFlags$kotlin_stdlib());
    }

    public kotlin.reflect.KProperty0 Property0(kotlin.jvm.internal.PropertyReference0 propertyReference0) {
        return propertyReference0;
    }

    public kotlin.reflect.KProperty1 Property1(kotlin.jvm.internal.PropertyReference1 propertyReference1) {
        return propertyReference1;
    }

    public kotlin.reflect.KProperty2 Property2(kotlin.jvm.internal.PropertyReference2 propertyReference2) {
        return propertyReference2;
    }

    public java.lang.string RenderLambdaTostring(kotlin.jvm.internal.FunctionBase functionBase) {
        java.lang.string string = functionBase.GetType().getGenericInterfaces()[0].tostring();
        return !string.StartsWith("kotlin.jvm.functions.") ? string : string.Substring("kotlin.jvm.functions.".Length);
    }

    public java.lang.string RenderLambdaTostring(kotlin.jvm.internal.Lambda lambda) {
        return renderLambdaTostring((kotlin.jvm.internal.FunctionBase) lambda);
    }

    public void SetUpperBounds(kotlin.reflect.KTypeParameter kTypeParameter, java.util.List<kotlin.reflect.KType> list) {
        ((kotlin.jvm.internal.TypeParameterReference) kTypeParameter).setUpperBounds(list);
    }

    public kotlin.reflect.KType TypeOf(kotlin.reflect.KClassifier kClassifier, java.util.List<kotlin.reflect.KTypeProjection> list, bool z) {
        return new kotlin.jvm.internal.TypeReference(kClassifier, list, z);
    }

    public kotlin.reflect.KTypeParameter TypeParameter(java.lang.object obj, java.lang.string str, kotlin.reflect.KVariance kVariance, bool z) {
        return new kotlin.jvm.internal.TypeParameterReference(obj, str, kVariance, z);
    }
}

