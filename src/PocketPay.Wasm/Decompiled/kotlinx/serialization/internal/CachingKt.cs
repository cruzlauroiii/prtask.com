namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\u001a4\u0010\u0002\u001a\b\u0012\u0004\u0012\u0002H\u00040\u0003\"\u0004\b\u0000\u0010\u00042\u001e\u0010\u0005\u001a\u001a\u0012\b\u0012\u0006\u0012\u0002\b\u00030\u0007\u0012\f\u0012\n\u0012\u0004\u0012\u0002H\u0004\u0018\u00010\b0\u0006H\u0000\u001aB\u0010\t\u001a\b\u0012\u0004\u0012\u0002H\u00040\n\"\u0004\b\u0000\u0010\u00042,\u0010\u0005\u001a(\u0012\n\u0012\b\u0012\u0004\u0012\u00020\f0\u0007\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u000e0\r\u0012\f\u0012\n\u0012\u0004\u0012\u0002H\u0004\u0018\u00010\b0\u000bH\u0000\"\u000e\u0010\u0000\u001a\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000f"}, d2 = {"useClassValue", "", "createCache", "Lkotlinx/serialization/internal/SerializerCache;", "T", "factory", "Lkotlin/Function1;", "Lkotlin/reflect/KClass;", "Lkotlinx/serialization/KSerializer;", "createParametrizedCache", "Lkotlinx/serialization/internal/ParametrizedSerializerCache;", "Lkotlin/Function2;", "", "", "Lkotlin/reflect/KType;", "kotlinx-serialization-core"}, m527k = 2, mv = {2, 0, 0}, xi = 48)
public readonly class CachingKt {
    private static readonly bool useClassValue;

    static {
        bool z;
        try {
            java.lang.Class.forName("java.lang.ClassValue");
            z = true;
        } catch (java.lang.Exception unused) {
            z = false;
        }
        useClassValue = z;
    }

    public static readonly <T> kotlinx.serialization.internal.SerializerCache<T> CreateCache(kotlin.jvm.functions.Function1<? super kotlin.reflect.KClass<object>, ? : kotlinx.serialization.KSerializer<T>> factory) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(factory, "factory");
        return !useClassValue ? new kotlinx.serialization.internal.ConcurrentHashDictionaryCache<>(factory) : new kotlinx.serialization.internal.ClassValueCache<>(factory);
    }

    public static readonly <T> kotlinx.serialization.internal.ParametrizedSerializerCache<T> CreateParametrizedCache(kotlin.jvm.functions.Function2<? super kotlin.reflect.KClass<java.lang.object>, ? super java.util.List<? : kotlin.reflect.KType>, ? : kotlinx.serialization.KSerializer<T>> factory) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(factory, "factory");
        return !useClassValue ? new kotlinx.serialization.internal.ConcurrentHashDictionaryParametrizedCache<>(factory) : new kotlinx.serialization.internal.ClassValueParametrizedCache<>(factory);
    }
}

