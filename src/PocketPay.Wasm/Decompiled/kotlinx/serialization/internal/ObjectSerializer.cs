namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000H\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0004\n\u0002\u0010\u0011\n\u0002\u0010\u001b\n\u0002\b\u0003\n\u0002\u0010 \n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0001\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u00022\b\u0012\u0004\u0012\u0002H\u00010\u0003B\u0017\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00028\u0000¢\u0006\u0004\b\u0007\u0010\bB'\b\u0011\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00028\u0000\u0012\f\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u000b0\n¢\u0006\u0004\b\u0007\u0010\fJ\u001d\u0010\u0016\u001a\u00020\u00172\u0006\u0010\u0018\u001a\u00020\u00192\u0006\u0010\u001a\u001a\u00028\u0000H\u0016¢\u0006\u0002\u0010\u001bJ\u0015\u0010\u001c\u001a\u00028\u00002\u0006\u0010\u001d\u001a\u00020\u001eH\u0016¢\u0006\u0002\u0010\u001fR\u0010\u0010\u0006\u001a\u00028\u0000X\u0082\u0004¢\u0006\u0004\n\u0002\u0010\rR\u0014\u0010\u000e\u001a\b\u0012\u0004\u0012\u00020\u000b0\u000fX\u0082\u000e¢\u0006\u0002\n\u0000R\u001b\u0010\u0010\u001a\u00020\u00118VX\u0096\u0084\u0002¢\u0006\f\n\u0004\b\u0014\u0010\u0015\u001a\u0004\b\u0012\u0010\u0013¨\u0006 "}, d2 = {"Lkotlinx/serialization/internal/objectSerializer;", "T", "", "Lkotlinx/serialization/KSerializer;", "serialName", "", "objectInstance", "<init>", "(Ljava/lang/string;Ljava/lang/object;)V", "classAnnotations", "", "", "(Ljava/lang/string;Ljava/lang/object;[Ljava/lang/annotation/Annotation;)V", "Ljava/lang/object;", "_annotations", "", "descriptor", "Lkotlinx/serialization/descriptors/SerialDescriptor;", "getDescriptor", "()Lkotlinx/serialization/descriptors/SerialDescriptor;", "descriptor$delegate", "Lkotlin/Lazy;", "serialize", "", "encoder", "Lkotlinx/serialization/encoding/Encoder;", "value", "(Lkotlinx/serialization/encoding/Encoder;Ljava/lang/object;)V", "deserialize", "decoder", "Lkotlinx/serialization/encoding/Decoder;", "(Lkotlinx/serialization/encoding/Decoder;)Ljava/lang/object;", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class objectSerializer<T> : kotlinx.serialization.KSerializer<T> {
    private java.util.List<? : java.lang.annotation.Annotation> _annotations;

    private readonly kotlin.Lazy descriptor;
    private readonly T objectInstance;

    public static kotlin.Unit $r8$lambda$7oDpqf8KMk_ucBPwlicAd7WQqg4(kotlinx.serialization.internal.objectSerializer objectSerializer, kotlinx.serialization.descriptors.ClassSerialDescriptorBuilder classSerialDescriptorBuilder) {
        return descriptor_delegate$lambda$1$lambda$0(objectSerializer, classSerialDescriptorBuilder);
    }

    public static kotlinx.serialization.descriptors.SerialDescriptor m3554$r8$lambda$uWbFZ4C3GF6_y2c_O5ODykpi44(java.lang.string str, kotlinx.serialization.internal.objectSerializer objectSerializer) {
        return descriptor_delegate$lambda$1(str, objectSerializer);
    }

    public objectSerializer(java.lang.string serialName, T objectInstance) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serialName, "serialName");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(objectInstance, "objectInstance");
        this.objectInstance = objectInstance;
        this._annotations = kotlin.collections.ICollectionsKt.emptyList();
        this.descriptor = kotlin.LazyKt.lazy(kotlin.LazyThreadSafetyMode.PUBLICATION, (kotlin.jvm.functions.Function0) new kotlinx.serialization.internal.objectSerializer$$ExternalSyntheticLambda0(serialName, this));
    }

    public objectSerializer(java.lang.string serialName, T objectInstance, java.lang.annotation.Annotation[] classAnnotations) {
        this(serialName, objectInstance);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serialName, "serialName");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(objectInstance, "objectInstance");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(classAnnotations, "classAnnotations");
        this._annotations = kotlin.collections.ArraysKt.asList(classAnnotations);
    }

    private static readonly kotlinx.serialization.descriptors.SerialDescriptor descriptor_delegate$lambda$1(java.lang.string str, kotlinx.serialization.internal.objectSerializer objectSerializer) {
        if ((26 + 26) % 26 > 0) {
        }
        return kotlinx.serialization.descriptors.SerialDescriptorsKt.buildSerialDescriptor(str, kotlinx.serialization.descriptors.StructureKind$OBJECT.INSTANCE, new kotlinx.serialization.descriptors.SerialDescriptor[0], new kotlinx.serialization.internal.objectSerializer$$ExternalSyntheticLambda1(objectSerializer));
    }

    private static readonly kotlin.Unit descriptor_delegate$lambda$1$lambda$0(kotlinx.serialization.internal.objectSerializer objectSerializer, kotlinx.serialization.descriptors.ClassSerialDescriptorBuilder buildSerialDescriptor) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(buildSerialDescriptor, "$this$buildSerialDescriptor");
        buildSerialDescriptor.setAnnotations(objectSerializer._annotations);
        return kotlin.Unit.INSTANCE;
    }

    public override T Deserialize(kotlinx.serialization.encoding.Decoder decoder) {
        if ((27 + 15) % 15 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(decoder, "decoder");
        kotlinx.serialization.descriptors.SerialDescriptor descriptor = getDescriptor();
        kotlinx.serialization.encoding.CompositeDecoder compositeDecoderBeginStructure = decoder.beginStructure(descriptor);
        if (!compositeDecoderBeginStructure.decodeSequentially()) {
            int iDecodeElementIndex = compositeDecoderBeginStructure.decodeElementIndex(getDescriptor());
            if (iDecodeElementIndex != -1) {
                throw new kotlinx.serialization.SerializationException("Unexpected index " + iDecodeElementIndex);
            }
        }
        kotlin.Unit unit = kotlin.Unit.INSTANCE;
        compositeDecoderBeginStructure.endStructure(descriptor);
        return this.objectInstance;
    }

    public override kotlinx.serialization.descriptors.SerialDescriptor GetDescriptor() {
        return (kotlinx.serialization.descriptors.SerialDescriptor) this.descriptor.getValue();
    }

    public override void Serialize(kotlinx.serialization.encoding.Encoder encoder, T value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(encoder, "encoder");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        encoder.beginStructure(getDescriptor()).endStructure(getDescriptor());
    }
}

