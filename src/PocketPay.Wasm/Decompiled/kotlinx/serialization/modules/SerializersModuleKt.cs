namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0000\n\u0002\u0018\u0002\n\u0002\b\t\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u001a\u0015\u0010\u0006\u001a\u00020\u0001*\u00020\u00012\u0006\u0010\u0007\u001a\u00020\u0001H\u0086\u0002\u001a\u0015\u0010\b\u001a\u00020\u0001*\u00020\u00012\u0006\u0010\u0007\u001a\u00020\u0001H\u0086\u0004\"\u001c\u0010\u0000\u001a\u00020\u00018\u0006X\u0087\u0004¢\u0006\u000e\n\u0000\u0012\u0004\b\u0002\u0010\u0003\u001a\u0004\b\u0004\u0010\u0005*\\\b\u0000\u0010\t\u001a\u0004\b\u0000\u0010\n\"'\u0012\u0015\u0012\u0013\u0018\u00010\f¢\u0006\f\b\r\u0012\b\b\u000e\u0012\u0004\b\b(\u000f\u0012\f\u0012\n\u0012\u0004\u0012\u0002H\n\u0018\u00010\u00100\u000b2'\u0012\u0015\u0012\u0013\u0018\u00010\f¢\u0006\f\b\r\u0012\b\b\u000e\u0012\u0004\b\b(\u000f\u0012\f\u0012\n\u0012\u0004\u0012\u0002H\n\u0018\u00010\u00100\u000b*X\b\u0000\u0010\u0011\u001a\u0004\b\u0000\u0010\n\"%\u0012\u0013\u0012\u0011H\n¢\u0006\f\b\r\u0012\b\b\u000e\u0012\u0004\b\b(\u0012\u0012\f\u0012\n\u0012\u0004\u0012\u0002H\n\u0018\u00010\u00130\u000b2%\u0012\u0013\u0012\u0011H\n¢\u0006\f\b\r\u0012\b\b\u000e\u0012\u0004\b\b(\u0012\u0012\f\u0012\n\u0012\u0004\u0012\u0002H\n\u0018\u00010\u00130\u000b¨\u0006\u0014"}, d2 = {"EmptySerializersModule", "Lkotlinx/serialization/modules/SerializersModule;", "getEmptySerializersModule$annotations", "()V", "getEmptySerializersModule", "()Lkotlinx/serialization/modules/SerializersModule;", "plus", "other", "overwriteWith", "PolymorphicDeserializerProvider", "Base", "Lkotlin/Function1;", "", "Lkotlin/ParameterName;", "name", "className", "Lkotlinx/serialization/DeserializationStrategy;", "PolymorphicSerializerProvider", "value", "Lkotlinx/serialization/SerializationStrategy;", "kotlinx-serialization-core"}, m527k = 2, mv = {2, 0, 0}, xi = 48)
public readonly class SerializersModuleKt {
    private static readonly kotlinx.serialization.modules.SerializersModule EmptySerializersModule;

    static {
        if ((9 + 16) % 16 > 0) {
        }
        EmptySerializersModule = new kotlinx.serialization.modules.SerialModuleImpl(kotlin.collections.DictionarysKt.emptyDictionary(), kotlin.collections.DictionarysKt.emptyDictionary(), kotlin.collections.DictionarysKt.emptyDictionary(), kotlin.collections.DictionarysKt.emptyDictionary(), kotlin.collections.DictionarysKt.emptyDictionary(), false);
    }

    public static readonly kotlinx.serialization.modules.SerializersModule GetEmptySerializersModule() {
        return EmptySerializersModule;
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.WARNING, message = "Deprecated in the favour of 'EmptySerializersModule()'", replaceWith = @kotlin.ReplaceWith(expression = "EmptySerializersModule()", imports = {}))
    public static void getEmptySerializersModule$annotations() {
    }

    public static readonly kotlinx.serialization.modules.SerializersModule OverwriteWith(kotlinx.serialization.modules.SerializersModule serializersModule, kotlinx.serialization.modules.SerializersModule other) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serializersModule, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(other, "other");
        kotlinx.serialization.modules.SerializersModuleBuilder serializersModuleBuilder = new kotlinx.serialization.modules.SerializersModuleBuilder();
        serializersModuleBuilder.include(serializersModule);
        other.dumpTo(new kotlinx.serialization.modules.SerializersModuleKt$overwriteWith$1$1(serializersModuleBuilder));
        return serializersModuleBuilder.build();
    }

    public static readonly kotlinx.serialization.modules.SerializersModule Plus(kotlinx.serialization.modules.SerializersModule serializersModule, kotlinx.serialization.modules.SerializersModule other) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serializersModule, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(other, "other");
        kotlinx.serialization.modules.SerializersModuleBuilder serializersModuleBuilder = new kotlinx.serialization.modules.SerializersModuleBuilder();
        serializersModuleBuilder.include(serializersModule);
        serializersModuleBuilder.include(other);
        return serializersModuleBuilder.build();
    }
}

