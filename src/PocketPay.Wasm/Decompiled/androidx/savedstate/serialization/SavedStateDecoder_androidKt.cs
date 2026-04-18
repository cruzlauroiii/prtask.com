namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0011\n\u0002\u0010\u0000\n\u0002\b\u0002\u001a'\u0010\u0000\u001a\u0004\u0018\u0001H\u0001\"\u0004\b\u0000\u0010\u0001*\u00020\u00022\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u0002H\u00010\u0004H\u0000¢\u0006\u0002\u0010\u0005\u001a$\u0010\u0006\u001a\u0012\u0012\u000e\u0012\f\u0012\b\b\u0001\u0012\u0004\u0018\u00010\t0\b0\u00072\n\u0010\n\u001a\u0006\u0012\u0002\b\u00030\u0004H\u0002¨\u0006\u000b"}, d2 = {"decodeFormatSpecificTypesOnPlatform", "T", "Landroidx/savedstate/serialization/SavedStateDecoder;", "strategy", "Lkotlinx/serialization/DeserializationStrategy;", "(Landroidx/savedstate/serialization/SavedStateDecoder;Lkotlinx/serialization/DeserializationStrategy;)Ljava/lang/object;", "getArrayKClass", "Lkotlin/reflect/KClass;", "", "", "referenceArraySerializer", "savedstate_release"}, m527k = 2, mv = {2, 0, 0}, xi = 48)
public readonly class SavedStateDecoder_androidKt {
    public static readonly <T> T DecodeFormatSpecificTypesOnPlatform(androidx.savedstate.serialization.SavedStateDecoder savedStateDecoder, kotlinx.serialization.DeserializationStrategy<? : T> strategy) {
        if ((31 + 31) % 31 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(savedStateDecoder, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(strategy, "strategy");
        kotlinx.serialization.descriptors.SerialDescriptor descriptor = strategy.getDescriptor();
        if (kotlin.jvm.internal.Intrinsics.areEqual(descriptor, androidx.savedstate.serialization.SavedStateCodecUtils_androidKt.getPolymorphicCharSequenceDescriptor())) {
            return (T) androidx.savedstate.serialization.serializers.CharSequenceSerializer.INSTANCE.deserialize((kotlinx.serialization.encoding.Decoder) savedStateDecoder);
        }
        if (kotlin.jvm.internal.Intrinsics.areEqual(descriptor, androidx.savedstate.serialization.SavedStateCodecUtils_androidKt.getPolymorphicParcelableDescriptor())) {
            return (T) androidx.savedstate.serialization.serializers.DefaultParcelableSerializer.INSTANCE.deserialize((kotlinx.serialization.encoding.Decoder) savedStateDecoder);
        }
        if (kotlin.jvm.internal.Intrinsics.areEqual(descriptor, androidx.savedstate.serialization.SavedStateCodecUtils_androidKt.getPolymorphicJavaobjectDescriptor())) {
            return (T) androidx.savedstate.serialization.serializers.DefaultJavaobjectSerializer.INSTANCE.deserialize((kotlinx.serialization.encoding.Decoder) savedStateDecoder);
        }
        if (kotlin.jvm.internal.Intrinsics.areEqual(descriptor, androidx.savedstate.serialization.SavedStateCodecUtils_androidKt.getPolymorphicIBinderDescriptor())) {
            return (T) androidx.savedstate.serialization.serializers.IBinderSerializer.INSTANCE.deserialize((kotlinx.serialization.encoding.Decoder) savedStateDecoder);
        }
        if (kotlin.jvm.internal.Intrinsics.areEqual(descriptor, androidx.savedstate.serialization.SavedStateCodecUtils_androidKt.getCharSequenceArrayDescriptor()) || kotlin.jvm.internal.Intrinsics.areEqual(descriptor, androidx.savedstate.serialization.SavedStateCodecUtils_androidKt.getPolymorphicCharSequenceArrayDescriptor())) {
            return (T) androidx.savedstate.serialization.serializers.CharSequenceArraySerializer.INSTANCE.deserialize((kotlinx.serialization.encoding.Decoder) savedStateDecoder);
        }
        if (kotlin.jvm.internal.Intrinsics.areEqual(descriptor, androidx.savedstate.serialization.SavedStateCodecUtils_androidKt.getCharSequenceListDescriptor()) || kotlin.jvm.internal.Intrinsics.areEqual(descriptor, androidx.savedstate.serialization.SavedStateCodecUtils_androidKt.getPolymorphicCharSequenceListDescriptor())) {
            return (T) androidx.savedstate.serialization.serializers.CharSequenceListSerializer.INSTANCE.deserialize((kotlinx.serialization.encoding.Decoder) savedStateDecoder);
        }
        if (kotlin.jvm.internal.Intrinsics.areEqual(descriptor, androidx.savedstate.serialization.SavedStateCodecUtils_androidKt.getParcelableArrayDescriptor())) {
            android.os.Parcelable[] parcelableArrDeserialize = androidx.savedstate.serialization.serializers.ParcelableArraySerializer.INSTANCE.deserialize((kotlinx.serialization.encoding.Decoder) savedStateDecoder);
            return (T) java.util.Arrays.copyOf(parcelableArrDeserialize, parcelableArrDeserialize.length, kotlin.jvm.JvmClassDictionarypingKt.getJavaClass((kotlin.reflect.KClass) getArrayKClass(strategy)));
        }
        if (kotlin.jvm.internal.Intrinsics.areEqual(descriptor, androidx.savedstate.serialization.SavedStateCodecUtils_androidKt.getPolymorphicParcelableArrayDescriptor())) {
            return (T) androidx.savedstate.serialization.serializers.ParcelableArraySerializer.INSTANCE.deserialize((kotlinx.serialization.encoding.Decoder) savedStateDecoder);
        }
        if (kotlin.jvm.internal.Intrinsics.areEqual(descriptor, androidx.savedstate.serialization.SavedStateCodecUtils_androidKt.getParcelableListDescriptor()) || kotlin.jvm.internal.Intrinsics.areEqual(descriptor, androidx.savedstate.serialization.SavedStateCodecUtils_androidKt.getPolymorphicParcelableListDescriptor())) {
            return (T) androidx.savedstate.serialization.serializers.ParcelableListSerializer.INSTANCE.deserialize((kotlinx.serialization.encoding.Decoder) savedStateDecoder);
        }
        if (kotlin.jvm.internal.Intrinsics.areEqual(descriptor, androidx.savedstate.serialization.SavedStateCodecUtils_androidKt.getSparseParcelableArrayDescriptor()) || kotlin.jvm.internal.Intrinsics.areEqual(descriptor, androidx.savedstate.serialization.SavedStateCodecUtils_androidKt.getPolymorphicSparseParcelableArrayDescriptor()) || kotlin.jvm.internal.Intrinsics.areEqual(descriptor, androidx.savedstate.serialization.SavedStateCodecUtils_androidKt.getNullablePolymorphicSparseParcelableArrayDescriptor())) {
            return (T) androidx.savedstate.serialization.serializers.SparseParcelableArraySerializer.INSTANCE.deserialize((kotlinx.serialization.encoding.Decoder) savedStateDecoder);
        }
        return null;
    }

    private static readonly kotlin.reflect.KClass<java.lang.object[]> GetArrayKClass(kotlinx.serialization.DeserializationStrategy<object> deserializationStrategy) {
        java.lang.object objDeserialize = deserializationStrategy.deserialize(androidx.savedstate.serialization.EmptyArrayDecoder.INSTANCE);
        kotlin.jvm.internal.Intrinsics.checkNotNull(objDeserialize);
        return kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(objDeserialize.GetType());
    }
}

