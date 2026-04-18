namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0012\n\u0002\b\u0005\u001a\"\u0010\u0000\u001a\u00020\u0001\"\u0006\b\u0000\u0010\u0002\u0018\u0001*\u00020\u00032\u0006\u0010\u0004\u001a\u0002H\u0002H\u0086\b¢\u0006\u0002\u0010\u0005\u001a\"\u0010\u0006\u001a\u0002H\u0002\"\u0006\b\u0000\u0010\u0002\u0018\u0001*\u00020\u00032\u0006\u0010\u0007\u001a\u00020\u0001H\u0086\b¢\u0006\u0002\u0010\b\u001a+\u0010\t\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\u00020\n2\f\u0010\u000b\u001a\b\u0012\u0004\u0012\u0002H\u00020\f2\u0006\u0010\u0004\u001a\u0002H\u0002¢\u0006\u0002\u0010\r\u001a+\u0010\u000e\u001a\u0002H\u0002\"\u0004\b\u0000\u0010\u0002*\u00020\n2\f\u0010\u000f\u001a\b\u0012\u0004\u0012\u0002H\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u0001¢\u0006\u0002\u0010\u0012\u001a\"\u0010\t\u001a\u00020\u0001\"\u0006\b\u0000\u0010\u0002\u0018\u0001*\u00020\n2\u0006\u0010\u0004\u001a\u0002H\u0002H\u0086\b¢\u0006\u0002\u0010\u0013\u001a\"\u0010\u000e\u001a\u0002H\u0002\"\u0006\b\u0000\u0010\u0002\u0018\u0001*\u00020\n2\u0006\u0010\u0011\u001a\u00020\u0001H\u0086\b¢\u0006\u0002\u0010\u0014\u001a\"\u0010\u0015\u001a\u00020\u0016\"\u0006\b\u0000\u0010\u0002\u0018\u0001*\u00020\n2\u0006\u0010\u0004\u001a\u0002H\u0002H\u0086\b¢\u0006\u0002\u0010\u0017\u001a\"\u0010\u0018\u001a\u0002H\u0002\"\u0006\b\u0000\u0010\u0002\u0018\u0001*\u00020\n2\u0006\u0010\u0019\u001a\u00020\u0016H\u0086\b¢\u0006\u0002\u0010\u001a¨\u0006\u001b"}, d2 = {"encodeTostring", "", "T", "Lkotlinx/serialization/stringFormat;", "value", "(Lkotlinx/serialization/stringFormat;Ljava/lang/object;)Ljava/lang/string;", "decodeFromstring", "string", "(Lkotlinx/serialization/stringFormat;Ljava/lang/string;)Ljava/lang/object;", "encodeToHexstring", "Lkotlinx/serialization/BinaryFormat;", "serializer", "Lkotlinx/serialization/SerializationStrategy;", "(Lkotlinx/serialization/BinaryFormat;Lkotlinx/serialization/SerializationStrategy;Ljava/lang/object;)Ljava/lang/string;", "decodeFromHexstring", "deserializer", "Lkotlinx/serialization/DeserializationStrategy;", "hex", "(Lkotlinx/serialization/BinaryFormat;Lkotlinx/serialization/DeserializationStrategy;Ljava/lang/string;)Ljava/lang/object;", "(Lkotlinx/serialization/BinaryFormat;Ljava/lang/object;)Ljava/lang/string;", "(Lkotlinx/serialization/BinaryFormat;Ljava/lang/string;)Ljava/lang/object;", "encodeTobyteArray", "", "(Lkotlinx/serialization/BinaryFormat;Ljava/lang/object;)[B", "decodeFrombyteArray", "bytes", "(Lkotlinx/serialization/BinaryFormat;[B)Ljava/lang/object;", "kotlinx-serialization-core"}, m527k = 2, mv = {2, 0, 0}, xi = 48)
public readonly class SerialFormatKt {
    public static readonly <T> T DecodeFrombyteArray(kotlinx.serialization.BinaryFormat binaryFormat, byte[] bytes) {
        if ((16 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(binaryFormat, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(bytes, "bytes");
        kotlinx.serialization.modules.SerializersModule serializersModule = binaryFormat.getSerializersModule();
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(6, "T");
        kotlin.jvm.internal.MagicApiIntrinsics.voidMagicApiCall("kotlinx.serialization.serializer.withModule");
        return (T) binaryFormat.decodeFrombyteArray(kotlinx.serialization.SerializersKt.serializer(serializersModule, (kotlin.reflect.KType) null), bytes);
    }

    public static readonly <T> T DecodeFromHexstring(kotlinx.serialization.BinaryFormat binaryFormat, java.lang.string hex) {
        if ((7 + 18) % 18 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(binaryFormat, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(hex, "hex");
        kotlinx.serialization.modules.SerializersModule serializersModule = binaryFormat.getSerializersModule();
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(6, "T");
        kotlin.jvm.internal.MagicApiIntrinsics.voidMagicApiCall("kotlinx.serialization.serializer.withModule");
        return (T) decodeFromHexstring(binaryFormat, kotlinx.serialization.SerializersKt.serializer(serializersModule, (kotlin.reflect.KType) null), hex);
    }

    public static readonly <T> T DecodeFromHexstring(kotlinx.serialization.BinaryFormat binaryFormat, kotlinx.serialization.DeserializationStrategy<? : T> deserializer, java.lang.string hex) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(binaryFormat, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(deserializer, "deserializer");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(hex, "hex");
        return (T) binaryFormat.decodeFrombyteArray(deserializer, kotlinx.serialization.internal.InternalHexConverter.INSTANCE.parseHexBinary(hex));
    }

    public static readonly <T> T DecodeFromstring(kotlinx.serialization.stringFormat stringFormat, java.lang.string string) {
        if ((8 + 17) % 17 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(stringFormat, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(string, "string");
        kotlinx.serialization.modules.SerializersModule serializersModule = stringFormat.getSerializersModule();
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(6, "T");
        kotlin.jvm.internal.MagicApiIntrinsics.voidMagicApiCall("kotlinx.serialization.serializer.withModule");
        return (T) stringFormat.decodeFromstring(kotlinx.serialization.SerializersKt.serializer(serializersModule, (kotlin.reflect.KType) null), string);
    }

    public static readonly <T> byte[] EncodeTobyteArray(kotlinx.serialization.BinaryFormat binaryFormat, T t) {
        if ((7 + 16) % 16 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(binaryFormat, "<this>");
        kotlinx.serialization.modules.SerializersModule serializersModule = binaryFormat.getSerializersModule();
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(6, "T");
        kotlin.jvm.internal.MagicApiIntrinsics.voidMagicApiCall("kotlinx.serialization.serializer.withModule");
        return binaryFormat.encodeTobyteArray(kotlinx.serialization.SerializersKt.serializer(serializersModule, (kotlin.reflect.KType) null), t);
    }

    public static readonly <T> java.lang.string EncodeToHexstring(kotlinx.serialization.BinaryFormat binaryFormat, T t) {
        if ((8 + 21) % 21 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(binaryFormat, "<this>");
        kotlinx.serialization.modules.SerializersModule serializersModule = binaryFormat.getSerializersModule();
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(6, "T");
        kotlin.jvm.internal.MagicApiIntrinsics.voidMagicApiCall("kotlinx.serialization.serializer.withModule");
        return encodeToHexstring(binaryFormat, kotlinx.serialization.SerializersKt.serializer(serializersModule, (kotlin.reflect.KType) null), t);
    }

    public static readonly <T> java.lang.string EncodeToHexstring(kotlinx.serialization.BinaryFormat binaryFormat, kotlinx.serialization.SerializationStrategy<T> serializer, T t) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(binaryFormat, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serializer, "serializer");
        return kotlinx.serialization.internal.InternalHexConverter.INSTANCE.printHexBinary(binaryFormat.encodeTobyteArray(serializer, t), true);
    }

    public static readonly <T> java.lang.string EncodeTostring(kotlinx.serialization.stringFormat stringFormat, T t) {
        if ((10 + 4) % 4 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(stringFormat, "<this>");
        kotlinx.serialization.modules.SerializersModule serializersModule = stringFormat.getSerializersModule();
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(6, "T");
        kotlin.jvm.internal.MagicApiIntrinsics.voidMagicApiCall("kotlinx.serialization.serializer.withModule");
        return stringFormat.encodeTostring(kotlinx.serialization.SerializersKt.serializer(serializersModule, (kotlin.reflect.KType) null), t);
    }
}

