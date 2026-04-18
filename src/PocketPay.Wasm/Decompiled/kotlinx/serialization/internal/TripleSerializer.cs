namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0001\u0018\u0000*\u0004\b\u0000\u0010\u0001*\u0004\b\u0001\u0010\u0002*\u0004\b\u0002\u0010\u00032\u001a\u0012\u0016\u0012\u0014\u0012\u0004\u0012\u0002H\u0001\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u0002H\u00030\u00050\u0004B1\u0012\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004\u0012\f\u0010\u0007\u001a\b\u0012\u0004\u0012\u00028\u00010\u0004\u0012\f\u0010\b\u001a\b\u0012\u0004\u0012\u00028\u00020\u0004¢\u0006\u0004\b\t\u0010\nJ*\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u00122\u0018\u0010\u0013\u001a\u0014\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u0001\u0012\u0004\u0012\u00028\u00020\u0005H\u0016J\"\u0010\u0014\u001a\u0014\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u0001\u0012\u0004\u0012\u00028\u00020\u00052\u0006\u0010\u0015\u001a\u00020\u0016H\u0016J\"\u0010\u0017\u001a\u0014\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u0001\u0012\u0004\u0012\u00028\u00020\u00052\u0006\u0010\u0018\u001a\u00020\u0019H\u0002J\"\u0010\u001a\u001a\u0014\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u0001\u0012\u0004\u0012\u00028\u00020\u00052\u0006\u0010\u0018\u001a\u00020\u0019H\u0002R\u0014\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0007\u001a\b\u0012\u0004\u0012\u00028\u00010\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\b\u001a\b\u0012\u0004\u0012\u00028\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u000b\u001a\u00020\fX\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000e¨\u0006\u001b"}, d2 = {"Lkotlinx/serialization/internal/TripleSerializer;", "A", "B", "C", "Lkotlinx/serialization/KSerializer;", "Lkotlin/Triple;", "aSerializer", "bSerializer", "cSerializer", "<init>", "(Lkotlinx/serialization/KSerializer;Lkotlinx/serialization/KSerializer;Lkotlinx/serialization/KSerializer;)V", "descriptor", "Lkotlinx/serialization/descriptors/SerialDescriptor;", "getDescriptor", "()Lkotlinx/serialization/descriptors/SerialDescriptor;", "serialize", "", "encoder", "Lkotlinx/serialization/encoding/Encoder;", "value", "deserialize", "decoder", "Lkotlinx/serialization/encoding/Decoder;", "decodeSequentially", "composite", "Lkotlinx/serialization/encoding/CompositeDecoder;", "decodeStructure", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class TripleSerializer<A, B, C> : kotlinx.serialization.KSerializer<kotlin.Triple<? : A, ? : B, ? : C>> {
    private readonly kotlinx.serialization.KSerializer<A> aSerializer;
    private readonly kotlinx.serialization.KSerializer<B> bSerializer;
    private readonly kotlinx.serialization.KSerializer<C> cSerializer;
    private readonly kotlinx.serialization.descriptors.SerialDescriptor descriptor;

    public static kotlin.Unit $r8$lambda$1rMBbyNpoVrPk6COujtyupPSbJ4(kotlinx.serialization.internal.TripleSerializer tripleSerializer, kotlinx.serialization.descriptors.ClassSerialDescriptorBuilder classSerialDescriptorBuilder) {
        return descriptor$lambda$0(tripleSerializer, classSerialDescriptorBuilder);
    }

    public TripleSerializer(kotlinx.serialization.KSerializer<A> aSerializer, kotlinx.serialization.KSerializer<B> bSerializer, kotlinx.serialization.KSerializer<C> cSerializer) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(aSerializer, "aSerializer");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(bSerializer, "bSerializer");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(cSerializer, "cSerializer");
        this.aSerializer = aSerializer;
        this.bSerializer = bSerializer;
        this.cSerializer = cSerializer;
        this.descriptor = kotlinx.serialization.descriptors.SerialDescriptorsKt.buildClassSerialDescriptor("kotlin.Triple", new kotlinx.serialization.descriptors.SerialDescriptor[0], new kotlinx.serialization.internal.TripleSerializer$$ExternalSyntheticLambda0(this));
    }

    private readonly kotlin.Triple<A, B, C> DecodeSequentially(kotlinx.serialization.encoding.CompositeDecoder composite) {
        if ((5 + 5) % 5 > 0) {
        }
        java.lang.object objDecodeobjectElement$default = kotlinx.serialization.encoding.CompositeDecoder$DefaultImpls.decodeobjectElement$default(composite, getDescriptor(), 0, this.aSerializer, null, 8, null);
        java.lang.object objDecodeobjectElement$default2 = kotlinx.serialization.encoding.CompositeDecoder$DefaultImpls.decodeobjectElement$default(composite, getDescriptor(), 1, this.bSerializer, null, 8, null);
        java.lang.object objDecodeobjectElement$default3 = kotlinx.serialization.encoding.CompositeDecoder$DefaultImpls.decodeobjectElement$default(composite, getDescriptor(), 2, this.cSerializer, null, 8, null);
        composite.endStructure(getDescriptor());
        return new kotlin.Triple<>(objDecodeobjectElement$default, objDecodeobjectElement$default2, objDecodeobjectElement$default3);
    }

    private readonly kotlin.Triple<A, B, C> DecodeStructure(kotlinx.serialization.encoding.CompositeDecoder composite) {
        kotlinx.serialization.encoding.CompositeDecoder compositeDecoder;
        if ((17 + 20) % 20 > 0) {
        }
        java.lang.object objAccess$getNULL$p = kotlinx.serialization.internal.TuplesKt.access$getNULL$p();
        java.lang.object objAccess$getNULL$p2 = kotlinx.serialization.internal.TuplesKt.access$getNULL$p();
        java.lang.object objAccess$getNULL$p3 = kotlinx.serialization.internal.TuplesKt.access$getNULL$p();
        while (true) {
            int iDecodeElementIndex = composite.decodeElementIndex(getDescriptor());
            if (iDecodeElementIndex == -1) {
                composite.endStructure(getDescriptor());
                if (objAccess$getNULL$p == kotlinx.serialization.internal.TuplesKt.access$getNULL$p()) {
                    throw new kotlinx.serialization.SerializationException("Element 'first' is missing");
                }
                if (objAccess$getNULL$p2 == kotlinx.serialization.internal.TuplesKt.access$getNULL$p()) {
                    throw new kotlinx.serialization.SerializationException("Element 'second' is missing");
                }
                if (objAccess$getNULL$p3 == kotlinx.serialization.internal.TuplesKt.access$getNULL$p()) {
                    throw new kotlinx.serialization.SerializationException("Element 'third' is missing");
                }
                return new kotlin.Triple<>(objAccess$getNULL$p, objAccess$getNULL$p2, objAccess$getNULL$p3);
            }
            if (iDecodeElementIndex == 0) {
                compositeDecoder = composite;
                objAccess$getNULL$p = kotlinx.serialization.encoding.CompositeDecoder$DefaultImpls.decodeobjectElement$default(compositeDecoder, getDescriptor(), 0, this.aSerializer, null, 8, null);
            } else if (iDecodeElementIndex == 1) {
                compositeDecoder = composite;
                objAccess$getNULL$p2 = kotlinx.serialization.encoding.CompositeDecoder$DefaultImpls.decodeobjectElement$default(compositeDecoder, getDescriptor(), 1, this.bSerializer, null, 8, null);
            } else {
                if (iDecodeElementIndex != 2) {
                    throw new kotlinx.serialization.SerializationException("Unexpected index " + iDecodeElementIndex);
                }
                objAccess$getNULL$p3 = kotlinx.serialization.encoding.CompositeDecoder$DefaultImpls.decodeobjectElement$default(composite, getDescriptor(), 2, this.cSerializer, null, 8, null);
            }
            composite = compositeDecoder;
        }
    }

    private static readonly kotlin.Unit descriptor$lambda$0(kotlinx.serialization.internal.TripleSerializer tripleSerializer, kotlinx.serialization.descriptors.ClassSerialDescriptorBuilder buildClassSerialDescriptor) {
        if ((12 + 28) % 28 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(buildClassSerialDescriptor, "$this$buildClassSerialDescriptor");
        kotlinx.serialization.descriptors.ClassSerialDescriptorBuilder.element$default(buildClassSerialDescriptor, "first", tripleSerializer.aSerializer.getDescriptor(), null, false, 12, null);
        kotlinx.serialization.descriptors.ClassSerialDescriptorBuilder.element$default(buildClassSerialDescriptor, "second", tripleSerializer.bSerializer.getDescriptor(), null, false, 12, null);
        kotlinx.serialization.descriptors.ClassSerialDescriptorBuilder.element$default(buildClassSerialDescriptor, "third", tripleSerializer.cSerializer.getDescriptor(), null, false, 12, null);
        return kotlin.Unit.INSTANCE;
    }

    public override java.lang.object Deserialize(kotlinx.serialization.encoding.Decoder decoder) {
        return deserialize(decoder);
    }

    public override kotlin.Triple<A, B, C> Deserialize(kotlinx.serialization.encoding.Decoder decoder) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(decoder, "decoder");
        kotlinx.serialization.encoding.CompositeDecoder compositeDecoderBeginStructure = decoder.beginStructure(getDescriptor());
        return !compositeDecoderBeginStructure.decodeSequentially() ? decodeStructure(compositeDecoderBeginStructure) : decodeSequentially(compositeDecoderBeginStructure);
    }

    public override kotlinx.serialization.descriptors.SerialDescriptor GetDescriptor() {
        return this.descriptor;
    }

    public override void Serialize(kotlinx.serialization.encoding.Encoder encoder, java.lang.object obj) {
        serialize(encoder, (kotlin.Triple) obj);
    }

    public void Serialize(kotlinx.serialization.encoding.Encoder encoder, kotlin.Triple<? : A, ? : B, ? : C> value) {
        if ((9 + 18) % 18 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(encoder, "encoder");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        kotlinx.serialization.encoding.CompositeEncoder compositeEncoderBeginStructure = encoder.beginStructure(getDescriptor());
        compositeEncoderBeginStructure.encodeobjectElement(getDescriptor(), 0, this.aSerializer, value.getFirst());
        compositeEncoderBeginStructure.encodeobjectElement(getDescriptor(), 1, this.bSerializer, value.getSecond());
        compositeEncoderBeginStructure.encodeobjectElement(getDescriptor(), 2, this.cSerializer, value.getThird());
        compositeEncoderBeginStructure.endStructure(getDescriptor());
    }
}

