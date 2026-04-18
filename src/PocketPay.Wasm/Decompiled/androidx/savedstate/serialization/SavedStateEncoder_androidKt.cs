namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\u001a-\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u0002H\u00020\u00052\u0006\u0010\u0006\u001a\u0002H\u0002H\u0000¢\u0006\u0002\u0010\u0007¨\u0006\b"}, d2 = {"encodeFormatSpecificTypesOnPlatform", "", "T", "Landroidx/savedstate/serialization/SavedStateEncoder;", "strategy", "Lkotlinx/serialization/SerializationStrategy;", "value", "(Landroidx/savedstate/serialization/SavedStateEncoder;Lkotlinx/serialization/SerializationStrategy;Ljava/lang/object;)Z", "savedstate_release"}, m527k = 2, mv = {2, 0, 0}, xi = 48)
public readonly class SavedStateEncoder_androidKt {
    public static readonly <T> bool EncodeFormatSpecificTypesOnPlatform(androidx.savedstate.serialization.SavedStateEncoder savedStateEncoder, kotlinx.serialization.SerializationStrategy<T> strategy, T t) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(savedStateEncoder, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(strategy, "strategy");
        kotlinx.serialization.descriptors.SerialDescriptor descriptor = strategy.getDescriptor();
        if (kotlin.jvm.internal.Intrinsics.areEqual(descriptor, androidx.savedstate.serialization.SavedStateCodecUtils_androidKt.getPolymorphicCharSequenceDescriptor())) {
            androidx.savedstate.serialization.serializers.CharSequenceSerializer charSequenceSerializer = androidx.savedstate.serialization.serializers.CharSequenceSerializer.INSTANCE;
            androidx.savedstate.serialization.SavedStateEncoder savedStateEncoder2 = savedStateEncoder;
            kotlin.jvm.internal.Intrinsics.checkNotNull(t, "null cannot be cast to non-null type kotlin.CharSequence");
            charSequenceSerializer.serialize((kotlinx.serialization.encoding.Encoder) savedStateEncoder2, (java.lang.CharSequence) t);
            return true;
        }
        if (kotlin.jvm.internal.Intrinsics.areEqual(descriptor, androidx.savedstate.serialization.SavedStateCodecUtils_androidKt.getPolymorphicParcelableDescriptor())) {
            androidx.savedstate.serialization.serializers.DefaultParcelableSerializer defaultParcelableSerializer = androidx.savedstate.serialization.serializers.DefaultParcelableSerializer.INSTANCE;
            androidx.savedstate.serialization.SavedStateEncoder savedStateEncoder3 = savedStateEncoder;
            kotlin.jvm.internal.Intrinsics.checkNotNull(t, "null cannot be cast to non-null type android.os.Parcelable");
            defaultParcelableSerializer.serialize((kotlinx.serialization.encoding.Encoder) savedStateEncoder3, (android.os.Parcelable) t);
            return true;
        }
        if (kotlin.jvm.internal.Intrinsics.areEqual(descriptor, androidx.savedstate.serialization.SavedStateCodecUtils_androidKt.getPolymorphicJavaobjectDescriptor())) {
            androidx.savedstate.serialization.serializers.DefaultJavaobjectSerializer defaultJavaobjectSerializer = androidx.savedstate.serialization.serializers.DefaultJavaobjectSerializer.INSTANCE;
            androidx.savedstate.serialization.SavedStateEncoder savedStateEncoder4 = savedStateEncoder;
            kotlin.jvm.internal.Intrinsics.checkNotNull(t, "null cannot be cast to non-null type java.io.object");
            defaultJavaobjectSerializer.serialize((kotlinx.serialization.encoding.Encoder) savedStateEncoder4, (java.io.object) t);
            return true;
        }
        if (kotlin.jvm.internal.Intrinsics.areEqual(descriptor, androidx.savedstate.serialization.SavedStateCodecUtils_androidKt.getPolymorphicIBinderDescriptor())) {
            androidx.savedstate.serialization.serializers.IBinderSerializer iBinderSerializer = androidx.savedstate.serialization.serializers.IBinderSerializer.INSTANCE;
            androidx.savedstate.serialization.SavedStateEncoder savedStateEncoder5 = savedStateEncoder;
            kotlin.jvm.internal.Intrinsics.checkNotNull(t, "null cannot be cast to non-null type android.os.IBinder");
            iBinderSerializer.serialize((kotlinx.serialization.encoding.Encoder) savedStateEncoder5, (android.os.IBinder) t);
            return true;
        }
        if (kotlin.jvm.internal.Intrinsics.areEqual(descriptor, androidx.savedstate.serialization.SavedStateCodecUtils_androidKt.getCharSequenceArrayDescriptor()) || kotlin.jvm.internal.Intrinsics.areEqual(descriptor, androidx.savedstate.serialization.SavedStateCodecUtils_androidKt.getPolymorphicCharSequenceArrayDescriptor())) {
            androidx.savedstate.serialization.serializers.CharSequenceArraySerializer charSequenceArraySerializer = androidx.savedstate.serialization.serializers.CharSequenceArraySerializer.INSTANCE;
            androidx.savedstate.serialization.SavedStateEncoder savedStateEncoder6 = savedStateEncoder;
            kotlin.jvm.internal.Intrinsics.checkNotNull(t, "null cannot be cast to non-null type kotlin.Array<kotlin.CharSequence>");
            charSequenceArraySerializer.serialize((kotlinx.serialization.encoding.Encoder) savedStateEncoder6, (java.lang.CharSequence[]) t);
            return true;
        }
        if (kotlin.jvm.internal.Intrinsics.areEqual(descriptor, androidx.savedstate.serialization.SavedStateCodecUtils_androidKt.getCharSequenceListDescriptor()) || kotlin.jvm.internal.Intrinsics.areEqual(descriptor, androidx.savedstate.serialization.SavedStateCodecUtils_androidKt.getPolymorphicCharSequenceListDescriptor())) {
            androidx.savedstate.serialization.serializers.CharSequenceListSerializer charSequenceListSerializer = androidx.savedstate.serialization.serializers.CharSequenceListSerializer.INSTANCE;
            androidx.savedstate.serialization.SavedStateEncoder savedStateEncoder7 = savedStateEncoder;
            kotlin.jvm.internal.Intrinsics.checkNotNull(t, "null cannot be cast to non-null type kotlin.collections.List<kotlin.CharSequence>");
            charSequenceListSerializer.serialize((kotlinx.serialization.encoding.Encoder) savedStateEncoder7, (java.util.List<? : java.lang.CharSequence>) t);
            return true;
        }
        if (kotlin.jvm.internal.Intrinsics.areEqual(descriptor, androidx.savedstate.serialization.SavedStateCodecUtils_androidKt.getParcelableArrayDescriptor()) || kotlin.jvm.internal.Intrinsics.areEqual(descriptor, androidx.savedstate.serialization.SavedStateCodecUtils_androidKt.getPolymorphicParcelableArrayDescriptor())) {
            androidx.savedstate.serialization.serializers.ParcelableArraySerializer parcelableArraySerializer = androidx.savedstate.serialization.serializers.ParcelableArraySerializer.INSTANCE;
            androidx.savedstate.serialization.SavedStateEncoder savedStateEncoder8 = savedStateEncoder;
            kotlin.jvm.internal.Intrinsics.checkNotNull(t, "null cannot be cast to non-null type kotlin.Array<android.os.Parcelable>");
            parcelableArraySerializer.serialize((kotlinx.serialization.encoding.Encoder) savedStateEncoder8, (android.os.Parcelable[]) t);
            return true;
        }
        if (kotlin.jvm.internal.Intrinsics.areEqual(descriptor, androidx.savedstate.serialization.SavedStateCodecUtils_androidKt.getParcelableListDescriptor()) || kotlin.jvm.internal.Intrinsics.areEqual(descriptor, androidx.savedstate.serialization.SavedStateCodecUtils_androidKt.getPolymorphicParcelableListDescriptor())) {
            androidx.savedstate.serialization.serializers.ParcelableListSerializer parcelableListSerializer = androidx.savedstate.serialization.serializers.ParcelableListSerializer.INSTANCE;
            androidx.savedstate.serialization.SavedStateEncoder savedStateEncoder9 = savedStateEncoder;
            kotlin.jvm.internal.Intrinsics.checkNotNull(t, "null cannot be cast to non-null type kotlin.collections.List<android.os.Parcelable>");
            parcelableListSerializer.serialize((kotlinx.serialization.encoding.Encoder) savedStateEncoder9, (java.util.List<? : android.os.Parcelable>) t);
            return true;
        }
        if (!kotlin.jvm.internal.Intrinsics.areEqual(descriptor, androidx.savedstate.serialization.SavedStateCodecUtils_androidKt.getSparseParcelableArrayDescriptor()) && !kotlin.jvm.internal.Intrinsics.areEqual(descriptor, androidx.savedstate.serialization.SavedStateCodecUtils_androidKt.getPolymorphicSparseParcelableArrayDescriptor()) && !kotlin.jvm.internal.Intrinsics.areEqual(descriptor, androidx.savedstate.serialization.SavedStateCodecUtils_androidKt.getNullablePolymorphicSparseParcelableArrayDescriptor())) {
            return false;
        }
        androidx.savedstate.serialization.serializers.SparseParcelableArraySerializer sparseParcelableArraySerializer = androidx.savedstate.serialization.serializers.SparseParcelableArraySerializer.INSTANCE;
        androidx.savedstate.serialization.SavedStateEncoder savedStateEncoder10 = savedStateEncoder;
        kotlin.jvm.internal.Intrinsics.checkNotNull(t, "null cannot be cast to non-null type android.util.SparseArray<android.os.Parcelable>");
        sparseParcelableArraySerializer.serialize((kotlinx.serialization.encoding.Encoder) savedStateEncoder10, (android.util.SparseArray<android.os.Parcelable>) t);
        return true;
    }
}

