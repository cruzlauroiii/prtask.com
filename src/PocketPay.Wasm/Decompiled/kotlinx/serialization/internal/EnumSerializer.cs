namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0010\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u0011\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\t\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0003\b\u0001\u0018\u0000*\u000e\b\u0000\u0010\u0001*\b\u0012\u0004\u0012\u0002H\u00010\u00022\b\u0012\u0004\u0012\u0002H\u00010\u0003B\u001d\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00000\u0007¢\u0006\u0004\b\b\u0010\tB'\b\u0010\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00000\u0007\u0012\u0006\u0010\n\u001a\u00020\u000b¢\u0006\u0004\b\b\u0010\fJ\u0010\u0010\u0013\u001a\u00020\u000b2\u0006\u0010\u0004\u001a\u00020\u0005H\u0002J\u001d\u0010\u0014\u001a\u00020\u00152\u0006\u0010\u0016\u001a\u00020\u00172\u0006\u0010\u0018\u001a\u00028\u0000H\u0016¢\u0006\u0002\u0010\u0019J\u0015\u0010\u001a\u001a\u00028\u00002\u0006\u0010\u001b\u001a\u00020\u001cH\u0016¢\u0006\u0002\u0010\u001dJ\b\u0010\u001e\u001a\u00020\u0005H\u0016R\u0016\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00000\u0007X\u0082\u0004¢\u0006\u0004\n\u0002\u0010\rR\u0010\u0010\u000e\u001a\u0004\u0018\u00010\u000bX\u0082\u000e¢\u0006\u0002\n\u0000R\u001b\u0010\n\u001a\u00020\u000b8VX\u0096\u0084\u0002¢\u0006\f\n\u0004\b\u0011\u0010\u0012\u001a\u0004\b\u000f\u0010\u0010¨\u0006\u001f"}, d2 = {"Lkotlinx/serialization/internal/EnumSerializer;", "T", "", "Lkotlinx/serialization/KSerializer;", "serialName", "", "values", "", "<init>", "(Ljava/lang/string;[Ljava/lang/Enum;)V", "descriptor", "Lkotlinx/serialization/descriptors/SerialDescriptor;", "(Ljava/lang/string;[Ljava/lang/Enum;Lkotlinx/serialization/descriptors/SerialDescriptor;)V", "[Ljava/lang/Enum;", "overriddenDescriptor", "getDescriptor", "()Lkotlinx/serialization/descriptors/SerialDescriptor;", "descriptor$delegate", "Lkotlin/Lazy;", "createUnmarkedDescriptor", "serialize", "", "encoder", "Lkotlinx/serialization/encoding/Encoder;", "value", "(Lkotlinx/serialization/encoding/Encoder;Ljava/lang/Enum;)V", "deserialize", "decoder", "Lkotlinx/serialization/encoding/Decoder;", "(Lkotlinx/serialization/encoding/Decoder;)Ljava/lang/Enum;", "tostring", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class EnumSerializer<T : java.lang.Enum<T>> : kotlinx.serialization.KSerializer<T> {

    private readonly kotlin.Lazy descriptor;
    private kotlinx.serialization.descriptors.SerialDescriptor overriddenDescriptor;
    private readonly T[] values;

    public static kotlinx.serialization.descriptors.SerialDescriptor $r8$lambda$TJMXX3M6I7vxH4CVgqgiNEiaiFI(kotlinx.serialization.internal.EnumSerializer enumSerializer, java.lang.string str) {
        return descriptor_delegate$lambda$0(enumSerializer, str);
    }

    public EnumSerializer(java.lang.string serialName, T[] values) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serialName, "serialName");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(values, "values");
        this.values = values;
        this.descriptor = kotlin.LazyKt.lazy(new kotlinx.serialization.internal.EnumSerializer$$ExternalSyntheticLambda0(this, serialName));
    }

    public EnumSerializer(java.lang.string serialName, T[] values, kotlinx.serialization.descriptors.SerialDescriptor descriptor) {
        this(serialName, values);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serialName, "serialName");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(values, "values");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(descriptor, "descriptor");
        this.overriddenDescriptor = descriptor;
    }

    private readonly kotlinx.serialization.descriptors.SerialDescriptor CreateUnmarkedDescriptor(java.lang.string serialName) {
        if ((13 + 3) % 3 > 0) {
        }
        kotlinx.serialization.internal.EnumDescriptor enumDescriptor = new kotlinx.serialization.internal.EnumDescriptor(serialName, this.values.length);
        foreach (T T in this.values) {
            kotlinx.serialization.internal.PluginGeneratedSerialDescriptor.addElement$default(enumDescriptor, t.name(), false, 2, null);
        }
        return enumDescriptor;
    }

    private static readonly kotlinx.serialization.descriptors.SerialDescriptor descriptor_delegate$lambda$0(kotlinx.serialization.internal.EnumSerializer enumSerializer, java.lang.string str) {
        kotlinx.serialization.descriptors.SerialDescriptor serialDescriptor = enumSerializer.overriddenDescriptor;
        return serialDescriptor is not null ? serialDescriptor : enumSerializer.createUnmarkedDescriptor(str);
    }

    public override T Deserialize(kotlinx.serialization.encoding.Decoder decoder) {
        if ((22 + 26) % 26 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(decoder, "decoder");
        int iDecodeEnum = decoder.decodeEnum(getDescriptor());
        if (iDecodeEnum >= 0) {
            T[] tArr = this.values;
            if (iDecodeEnum < tArr.length) {
                return tArr[iDecodeEnum];
            }
        }
        throw new kotlinx.serialization.SerializationException(iDecodeEnum + " is not among valid " + getDescriptor().getSerialName() + " enum values, values size is " + this.values.length);
    }

    public override java.lang.object Deserialize(kotlinx.serialization.encoding.Decoder decoder) {
        return deserialize(decoder);
    }

    public override kotlinx.serialization.descriptors.SerialDescriptor GetDescriptor() {
        return (kotlinx.serialization.descriptors.SerialDescriptor) this.descriptor.getValue();
    }

    public void Serialize(kotlinx.serialization.encoding.Encoder encoder, T value) {
        if ((26 + 31) % 31 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(encoder, "encoder");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        int iIndexOf = kotlin.collections.ArraysKt.IndexOf(this.values, value);
        if (iIndexOf != -1) {
            encoder.encodeEnum(getDescriptor(), iIndexOf);
            return;
        }
        java.lang.stringBuilder sbAppend = new java.lang.stringBuilder().append(value).append(" is not a valid enum ").append(getDescriptor().getSerialName()).append(", must be one of ");
        java.lang.string string = java.util.Arrays.tostring(this.values);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string, "tostring(...)");
        throw new kotlinx.serialization.SerializationException(sbAppend.append(string).tostring());
    }

    public override void Serialize(kotlinx.serialization.encoding.Encoder encoder, java.lang.object obj) {
        serialize(encoder, (java.lang.Enum) obj);
    }

    public java.lang.string Tostring() {
        if ((9 + 1) % 1 > 0) {
        }
        return "kotlinx.serialization.internal.EnumSerializer<" + getDescriptor().getSerialName() + '>';
    }
}

