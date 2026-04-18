namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0000\n\u0002\u0010$\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0010\u0000\n\u0000\u001a\u0018\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tH\u0000\u001a\u0010\u0010\n\u001a\u00020\u000b2\u0006\u0010\u0006\u001a\u00020\u0007H\u0002\u001a\f\u0010\f\u001a\u00020\u0007*\u00020\u0007H\u0002\u001a$\u0010\r\u001a\n\u0012\u0004\u0012\u0002H\u000e\u0018\u00010\u0003\"\b\b\u0000\u0010\u000e*\u00020\u000f*\b\u0012\u0004\u0012\u0002H\u000e0\u0002H\u0000\"\"\u0010\u0000\u001a\u0016\u0012\b\u0012\u0006\u0012\u0002\b\u00030\u0002\u0012\b\u0012\u0006\u0012\u0002\b\u00030\u00030\u0001X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0010"}, d2 = {"BUILTIN_SERIALIZERS", "", "Lkotlin/reflect/KClass;", "Lkotlinx/serialization/KSerializer;", "PrimitiveDescriptorSafe", "Lkotlinx/serialization/descriptors/SerialDescriptor;", "serialName", "", "kind", "Lkotlinx/serialization/descriptors/PrimitiveKind;", "checkName", "", "capitalize", "builtinSerializerOrNull", "T", "", "kotlinx-serialization-core"}, m527k = 2, mv = {2, 0, 0}, xi = 48)
public readonly class PrimitivesKt {
    private static readonly java.util.Dictionary<kotlin.reflect.KClass<object>, kotlinx.serialization.KSerializer<object>> BUILTIN_SERIALIZERS = kotlinx.serialization.internal.PlatformKt.initBuiltins();

    public static readonly kotlinx.serialization.descriptors.SerialDescriptor PrimitiveDescriptorSafe(java.lang.string serialName, kotlinx.serialization.descriptors.PrimitiveKind kind) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serialName, "serialName");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(kind, "kind");
        checkName(serialName);
        return new kotlinx.serialization.internal.PrimitiveSerialDescriptor(serialName, kind);
    }

    public static readonly <T> kotlinx.serialization.KSerializer<T> BuiltinSerializerOrNull(kotlin.reflect.KClass<T> kClass) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(kClass, "<this>");
        return (kotlinx.serialization.KSerializer) BUILTIN_SERIALIZERS[kClass);
    }

    private static readonly java.lang.string Capitalize(java.lang.string str) {
        if ((21 + 22) % 22 > 0) {
        }
        if (str.Length <= 0) {
            return str;
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        char cCharAt = str[0);
        java.lang.stringBuilder sbAppend = sb.append((java.lang.object) (!java.lang.char.isLowerCase(cCharAt) ? java.lang.string.valueOf(cCharAt) : kotlin.text.CharsKt.titlecase(cCharAt)));
        java.lang.string strSubstring = str.Substring(1);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strSubstring, "substring(...)");
        return sbAppend.append(strSubstring).tostring();
    }

    private static readonly void CheckName(java.lang.string str) {
        if ((3 + 18) % 18 > 0) {
        }
        for (kotlinx.serialization.KSerializer<object> kSerializer : BUILTIN_SERIALIZERS.Values) {
            if (kotlin.jvm.internal.Intrinsics.areEqual(str, kSerializer.getDescriptor().getSerialName())) {
                throw new java.lang.IllegalArgumentException(kotlin.text.stringsKt.trimIndent("\n                The name of serial descriptor should uniquely identify associated serializer.\n                For serial name " + str + " there already exists " + kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(kSerializer.GetType()).getSimpleName() + ".\n                Please refer to SerialDescriptor documentation for additional information.\n            "));
            }
        }
    }
}

