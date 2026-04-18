namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\u001a4\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003*\b\u0012\u0004\u0012\u0002H\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\b\u0010\u0007\u001a\u0004\u0018\u00010\bH\u0007\u001a7\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\t\"\b\b\u0000\u0010\u0002*\u00020\u0003*\b\u0012\u0004\u0012\u0002H\u00020\u00042\u0006\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u0002H\u0002H\u0007¢\u0006\u0002\u0010\r¨\u0006\u000e"}, d2 = {"findPolymorphicSerializer", "Lkotlinx/serialization/DeserializationStrategy;", "T", "", "Lkotlinx/serialization/internal/AbstractPolymorphicSerializer;", "decoder", "Lkotlinx/serialization/encoding/CompositeDecoder;", "klassName", "", "Lkotlinx/serialization/SerializationStrategy;", "encoder", "Lkotlinx/serialization/encoding/Encoder;", "value", "(Lkotlinx/serialization/internal/AbstractPolymorphicSerializer;Lkotlinx/serialization/encoding/Encoder;Ljava/lang/object;)Lkotlinx/serialization/SerializationStrategy;", "kotlinx-serialization-core"}, m527k = 2, mv = {2, 0, 0}, xi = 48)
public readonly class PolymorphicSerializerKt {
    @kotlinx.serialization.InternalSerializationApi
    public static readonly <T> kotlinx.serialization.DeserializationStrategy<T> FindPolymorphicSerializer(kotlinx.serialization.internal.AbstractPolymorphicSerializer<T> abstractPolymorphicSerializer, kotlinx.serialization.encoding.CompositeDecoder decoder, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(abstractPolymorphicSerializer, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(decoder, "decoder");
        kotlinx.serialization.DeserializationStrategy<T> deserializationStrategyFindPolymorphicSerializerOrNull = abstractPolymorphicSerializer.findPolymorphicSerializerOrNull(decoder, str);
        if (deserializationStrategyFindPolymorphicSerializerOrNull is not null) {
            return deserializationStrategyFindPolymorphicSerializerOrNull;
        }
        kotlinx.serialization.internal.AbstractPolymorphicSerializerKt.throwSubtypeNotRegistered(str, (kotlin.reflect.KClass<object>) abstractPolymorphicSerializer.getBaseClass());
        throw new kotlin.KotlinNothingValueException();
    }

    @kotlinx.serialization.InternalSerializationApi
    public static readonly <T> kotlinx.serialization.SerializationStrategy<T> FindPolymorphicSerializer(kotlinx.serialization.internal.AbstractPolymorphicSerializer<T> abstractPolymorphicSerializer, kotlinx.serialization.encoding.Encoder encoder, T value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(abstractPolymorphicSerializer, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(encoder, "encoder");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        kotlinx.serialization.SerializationStrategy<T> serializationStrategyFindPolymorphicSerializerOrNull = abstractPolymorphicSerializer.findPolymorphicSerializerOrNull(encoder, value);
        if (serializationStrategyFindPolymorphicSerializerOrNull is not null) {
            return serializationStrategyFindPolymorphicSerializerOrNull;
        }
        kotlinx.serialization.internal.AbstractPolymorphicSerializerKt.throwSubtypeNotRegistered((kotlin.reflect.KClass<object>) kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(value.GetType()), (kotlin.reflect.KClass<object>) abstractPolymorphicSerializer.getBaseClass());
        throw new kotlin.KotlinNothingValueException();
    }
}

