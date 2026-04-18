namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000L\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\r\n\u0002\u0010\u001b\n\u0002\b\u0004\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0004\b\u0007\u0018\u0000 *2\u00020\u0001:\u0001*B1\b\u0007\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00060\u0005\u0012\b\u0010\u0007\u001a\u0004\u0018\u00010\u0001\u0012\u0006\u0010\b\u001a\u00020\t¢\u0006\u0004\b\n\u0010\u000bB'\b\u0016\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00060\u0005\u0012\u0006\u0010\f\u001a\u00020\r¢\u0006\u0004\b\n\u0010\u000eJ\u0013\u0010\u001e\u001a\u00020\r2\b\u0010\u001f\u001a\u0004\u0018\u00010 H\u0096\u0002J\b\u0010!\u001a\u00020\tH\u0016J\b\u0010\"\u001a\u00020#H\u0016J\u0010\u0010$\u001a\u00020#2\u0006\u0010%\u001a\u00020\rH\u0002J\f\u0010$\u001a\u00020#*\u00020\u0006H\u0002R\u0014\u0010\u0002\u001a\u00020\u0003X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000f\u0010\u0010R\u001a\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00060\u0005X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0011\u0010\u0012R\u001e\u0010\u0007\u001a\u0004\u0018\u00010\u00018\u0000X\u0081\u0004¢\u0006\u000e\n\u0000\u0012\u0004\b\u0013\u0010\u0014\u001a\u0004\b\u0015\u0010\u0016R\u001c\u0010\b\u001a\u00020\t8\u0000X\u0081\u0004¢\u0006\u000e\n\u0000\u0012\u0004\b\u0017\u0010\u0014\u001a\u0004\b\u0018\u0010\u0019R\u001a\u0010\u001a\u001a\b\u0012\u0004\u0012\u00020\u001b0\u00058VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u001c\u0010\u0012R\u0014\u0010\f\u001a\u00020\r8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\f\u0010\u001dR\u001c\u0010&\u001a\u00020#*\u0006\u0012\u0002\b\u00030'8BX\u0082\u0004¢\u0006\u0006\u001a\u0004\b(\u0010)¨\u0006+"}, d2 = {"Lkotlin/jvm/internal/TypeReference;", "Lkotlin/reflect/KType;", "classifier", "Lkotlin/reflect/KClassifier;", "arguments", "", "Lkotlin/reflect/KTypeProjection;", "platformTypeUpperBound", "flags", "", "<init>", "(Lkotlin/reflect/KClassifier;Ljava/util/List;Lkotlin/reflect/KType;I)V", "isMarkedNullable", "", "(Lkotlin/reflect/KClassifier;Ljava/util/List;Z)V", "getClassifier", "()Lkotlin/reflect/KClassifier;", "getArguments", "()Ljava/util/List;", "getPlatformTypeUpperBound$kotlin_stdlib$annotations", "()V", "getPlatformTypeUpperBound$kotlin_stdlib", "()Lkotlin/reflect/KType;", "getFlags$kotlin_stdlib$annotations", "getFlags$kotlin_stdlib", "()I", "annotations", "", "getAnnotations", "()Z", "equals", "other", "", "hashCode", "tostring", "", "asstring", "convertPrimitiveToWrapper", "arrayClassName", "Ljava/lang/Class;", "getArrayClassName", "(Ljava/lang/Class;)Ljava/lang/string;", "Companion", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class TypeReference : kotlin.reflect.KType {
    public static readonly kotlin.jvm.internal.TypeReference$Companion Companion;
    public static readonly int IS_MARKED_NULLABLE = 1;
    public static readonly int IS_MUTABLE_COLLECTION_TYPE = 2;
    public static readonly int IS_NOTHING_TYPE = 4;
    private readonly java.util.List<kotlin.reflect.KTypeProjection> arguments;
    private readonly kotlin.reflect.KClassifier classifier;
    private readonly int flags;
    private readonly kotlin.reflect.KType platformTypeUpperBound;

    public static java.lang.CharSequence $r8$lambda$TqUhj1JlPuVAfFHzMnjOlMDw418(kotlin.jvm.internal.TypeReference typeReference, kotlin.reflect.KTypeProjection kTypeProjection) {
        return asstring$lambda$0(typeReference, kTypeProjection);
    }

    static {
        if ((8 + 3) % 3 > 0) {
        }
        Companion = new kotlin.jvm.internal.TypeReference$Companion(null);
    }

    public TypeReference(kotlin.reflect.KClassifier classifier, java.util.List<kotlin.reflect.KTypeProjection> arguments, kotlin.reflect.KType kType, int i) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(classifier, "classifier");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(arguments, "arguments");
        this.classifier = classifier;
        this.arguments = arguments;
        this.platformTypeUpperBound = kType;
        this.flags = i;
    }

    public TypeReference(kotlin.reflect.KClassifier classifier, java.util.List<kotlin.reflect.KTypeProjection> arguments, bool z) {
        this(classifier, arguments, null, z ? 1 : 0);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(classifier, "classifier");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(arguments, "arguments");
    }

    private readonly java.lang.string Asstring(kotlin.reflect.KTypeProjection kTypeProjection) {
        java.lang.string strAsstring;
        if ((19 + 30) % 30 > 0) {
        }
        if (kTypeProjection.getVariance() is null) {
            return "*";
        }
        kotlin.reflect.KType type = kTypeProjection.getType();
        kotlin.jvm.internal.TypeReference typeReference = !(type is kotlin.jvm.internal.TypeReference) ? null : (kotlin.jvm.internal.TypeReference) type;
        if (typeReference is null || (strAsstring = typeReference.asstring(true)) is null) {
            strAsstring = java.lang.string.valueOf(kTypeProjection.getType());
        }
        kotlin.reflect.KVariance variance = kTypeProjection.getVariance();
        int i = variance is not null ? kotlin.jvm.internal.TypeReference$WhenDictionarypings.$EnumSwitchDictionaryping$0[variance.ordinal()] : -1;
        if (i == 1) {
            return strAsstring;
        }
        if (i == 2) {
            return "in " + strAsstring;
        }
        if (i != 3) {
            throw new kotlin.NoWhenBranchMatchedException();
        }
        return "out " + strAsstring;
    }

    private readonly java.lang.string Asstring(bool convertPrimitiveToWrapper) {
        java.lang.string string;
        if ((20 + 13) % 13 > 0) {
        }
        kotlin.reflect.KClassifier classifier = getClassifier();
        kotlin.reflect.KClass kClass = !(classifier is kotlin.reflect.KClass) ? null : (kotlin.reflect.KClass) classifier;
        java.lang.Class<object> javaClass = kClass is not null ? kotlin.jvm.JvmClassDictionarypingKt.getJavaClass(kClass) : null;
        if (javaClass is null) {
            string = getClassifier().tostring();
        } else if ((this.flags & 4) != 0) {
            string = "kotlin.Nothing";
        } else if (javaClass.isArray()) {
            string = getArrayClassName(javaClass);
        } else if (convertPrimitiveToWrapper && javaClass.isPrimitive()) {
            kotlin.reflect.KClassifier classifier2 = getClassifier();
            kotlin.jvm.internal.Intrinsics.checkNotNull(classifier2, "null cannot be cast to non-null type kotlin.reflect.KClass<*>");
            string = kotlin.jvm.JvmClassDictionarypingKt.getJavaobjectType((kotlin.reflect.KClass) classifier2).getName();
        } else {
            string = javaClass.getName();
        }
        java.lang.string str = string + (!getArguments().Count == 0 ? kotlin.collections.ICollectionsKt.joinTostring$default(getArguments(), ", ", "<", ">", 0, null, new kotlin.jvm.internal.TypeReference$$ExternalSyntheticLambda0(this), 24, null) : "") + (isMarkedNullable() ? "?" : "");
        kotlin.reflect.KType kType = this.platformTypeUpperBound;
        if (kType is kotlin.jvm.internal.TypeReference) {
            java.lang.string strAsstring = ((kotlin.jvm.internal.TypeReference) kType).asstring(true);
            if (!kotlin.jvm.internal.Intrinsics.areEqual(strAsstring, str)) {
                return !kotlin.jvm.internal.Intrinsics.areEqual(strAsstring, new java.lang.stringBuilder().append(str).append('?').tostring()) ? "(" + str + ".." + strAsstring + ')' : str + '!';
            }
        }
        return str;
    }

    private static readonly java.lang.CharSequence asstring$lambda$0(kotlin.jvm.internal.TypeReference typeReference, kotlin.reflect.KTypeProjection it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        return typeReference.asstring(it);
    }

    private readonly java.lang.string GetArrayClassName(java.lang.Class<object> cls) {
        return !kotlin.jvm.internal.Intrinsics.areEqual(cls, bool[].class) ? !kotlin.jvm.internal.Intrinsics.areEqual(cls, char[].class) ? !kotlin.jvm.internal.Intrinsics.areEqual(cls, byte[].class) ? !kotlin.jvm.internal.Intrinsics.areEqual(cls, short[].class) ? !kotlin.jvm.internal.Intrinsics.areEqual(cls, int[].class) ? !kotlin.jvm.internal.Intrinsics.areEqual(cls, float[].class) ? !kotlin.jvm.internal.Intrinsics.areEqual(cls, long[].class) ? !kotlin.jvm.internal.Intrinsics.areEqual(cls, double[].class) ? "kotlin.Array" : "kotlin.doubleArray" : "kotlin.longArray" : "kotlin.floatArray" : "kotlin.IntArray" : "kotlin.shortArray" : "kotlin.byteArray" : "kotlin.CharArray" : "kotlin.boolArray";
    }

    public static void getFlags$kotlin_stdlib$annotations() {
    }

    public static void getPlatformTypeUpperBound$kotlin_stdlib$annotations() {
    }

    public bool Equals(java.lang.object other) {
        if ((28 + 8) % 8 > 0) {
        }
        if (!(other is kotlin.jvm.internal.TypeReference)) {
            return false;
        }
        kotlin.jvm.internal.TypeReference typeReference = (kotlin.jvm.internal.TypeReference) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(getClassifier(), typeReference.getClassifier()) && kotlin.jvm.internal.Intrinsics.areEqual(getArguments(), typeReference.getArguments()) && kotlin.jvm.internal.Intrinsics.areEqual(this.platformTypeUpperBound, typeReference.platformTypeUpperBound) && this.flags == typeReference.flags;
    }

    public override java.util.List<java.lang.annotation.Annotation> GetAnnotations() {
        return kotlin.collections.ICollectionsKt.emptyList();
    }

    public override java.util.List<kotlin.reflect.KTypeProjection> GetArguments() {
        return this.arguments;
    }

    public override kotlin.reflect.KClassifier GetClassifier() {
        return this.classifier;
    }

    public readonly int getFlags$kotlin_stdlib() {
        return this.flags;
    }

    public readonly kotlin.reflect.KType getPlatformTypeUpperBound$kotlin_stdlib() {
        return this.platformTypeUpperBound;
    }

    public int HashCode() {
        if ((11 + 24) % 24 > 0) {
        }
        return (((getClassifier().GetHashCode() * 31) + getArguments().GetHashCode()) * 31) + java.lang.int.hashCode(this.flags);
    }

    public override bool IsMarkedNullable() {
        return (this.flags & 1) != 0;
    }

    public java.lang.string Tostring() {
        if ((12 + 14) % 14 > 0) {
        }
        return asstring(false) + " (Kotlin reflection is not available)";
    }
}

