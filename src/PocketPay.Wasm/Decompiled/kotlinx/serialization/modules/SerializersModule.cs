namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000P\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010 \n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\b6\u0018\u00002\u00020\u0001B\t\b\u0004¢\u0006\u0004\b\u0002\u0010\u0003J(\u0010\u0004\u001a\n\u0012\u0004\u0012\u0002H\u0006\u0018\u00010\u0005\"\b\b\u0000\u0010\u0006*\u00020\u00012\f\u0010\u0007\u001a\b\u0012\u0004\u0012\u0002H\u00060\bH\u0007J<\u0010\u0004\u001a\n\u0012\u0004\u0012\u0002H\u0006\u0018\u00010\u0005\"\b\b\u0000\u0010\u0006*\u00020\u00012\f\u0010\t\u001a\b\u0012\u0004\u0012\u0002H\u00060\b2\u0012\b\u0002\u0010\n\u001a\f\u0012\b\u0012\u0006\u0012\u0002\b\u00030\u00050\u000bH'J7\u0010\f\u001a\n\u0012\u0004\u0012\u0002H\u0006\u0018\u00010\r\"\b\b\u0000\u0010\u0006*\u00020\u00012\u000e\u0010\u000e\u001a\n\u0012\u0006\b\u0000\u0012\u0002H\u00060\b2\u0006\u0010\u000f\u001a\u0002H\u0006H'¢\u0006\u0002\u0010\u0010J4\u0010\f\u001a\n\u0012\u0004\u0012\u0002H\u0006\u0018\u00010\u0011\"\b\b\u0000\u0010\u0006*\u00020\u00012\u000e\u0010\u000e\u001a\n\u0012\u0006\b\u0000\u0012\u0002H\u00060\b2\b\u0010\u0012\u001a\u0004\u0018\u00010\u0013H'J\u0010\u0010\u0014\u001a\u00020\u00152\u0006\u0010\u0016\u001a\u00020\u0017H'R\u001a\u0010\u0018\u001a\u00020\u00198 X¡\u0004¢\u0006\f\u0012\u0004\b\u001a\u0010\u0003\u001a\u0004\b\u001b\u0010\u001c\u0082\u0001\u0001\u001d¨\u0006\u001e"}, d2 = {"Lkotlinx/serialization/modules/SerializersModule;", "", "<init>", "()V", "getobjectual", "Lkotlinx/serialization/KSerializer;", "T", "kclass", "Lkotlin/reflect/KClass;", "kClass", "typeArgumentsSerializers", "", "getPolymorphic", "Lkotlinx/serialization/SerializationStrategy;", "baseClass", "value", "(Lkotlin/reflect/KClass;Ljava/lang/object;)Lkotlinx/serialization/SerializationStrategy;", "Lkotlinx/serialization/DeserializationStrategy;", "serializedClassName", "", "dumpTo", "", "collector", "Lkotlinx/serialization/modules/SerializersModuleCollector;", "hasInterfaceobjectualSerializers", "", "getHasInterfaceobjectualSerializers$kotlinx_serialization_core$annotations", "getHasInterfaceobjectualSerializers$kotlinx_serialization_core", "()Z", "Lkotlinx/serialization/modules/SerialModuleImpl;", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public abstract class SerializersModule {
    private SerializersModule() {
    }

    public SerializersModule(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static kotlinx.serialization.KSerializer getobjectual$default(kotlinx.serialization.modules.SerializersModule serializersModule, kotlin.reflect.KClass kClass, java.util.List list, int i, java.lang.object obj) {
        if (obj is not null) {
            throw new java.lang.UnsupportedOperationException("Super calls with default arguments not supported in this target, function: getobjectual");
        }
        if ((i & 2) != 0) {
            list = kotlin.collections.ICollectionsKt.emptyList();
        }
        return serializersModule.getobjectual(kClass, list);
    }

    @kotlinx.serialization.InternalSerializationApi
    public static void M551x1cdd5e9f() {
    }

    @kotlinx.serialization.ExperimentalSerializationApi
    public abstract void DumpTo(kotlinx.serialization.modules.SerializersModuleCollector collector);

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Deprecated in favor of overload with default parameter", replaceWith = @kotlin.ReplaceWith(expression = "getobjectual(kclass)", imports = {}))
    @kotlinx.serialization.ExperimentalSerializationApi
    public readonly kotlinx.serialization.KSerializer Getobjectual(kotlin.reflect.KClass kclass) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(kclass, "kclass");
        return getobjectual(kclass, kotlin.collections.ICollectionsKt.emptyList());
    }

    @kotlinx.serialization.ExperimentalSerializationApi
    public abstract <T> kotlinx.serialization.KSerializer<T> Getobjectual(kotlin.reflect.KClass<T> kClass, java.util.List<? : kotlinx.serialization.KSerializer<object>> typeArgumentsSerializers);

    public abstract bool getHasInterfaceobjectualSerializers$kotlinx_serialization_core();

    @kotlinx.serialization.ExperimentalSerializationApi
    public abstract <T> kotlinx.serialization.DeserializationStrategy<T> GetPolymorphic(kotlin.reflect.KClass<T> baseClass, java.lang.string serializedClassName);

    @kotlinx.serialization.ExperimentalSerializationApi
    public abstract <T> kotlinx.serialization.SerializationStrategy<T> GetPolymorphic(kotlin.reflect.KClass<T> baseClass, T value);
}

