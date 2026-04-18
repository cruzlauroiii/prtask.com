namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0015\n\u0002\b\u0002\u001a \u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00032\u0006\u0010\u0005\u001a\u00020\u0006H\u0007\u001a \u0010\u0007\u001a\u00020\u00012\u0006\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\t2\u0006\u0010\u0005\u001a\u00020\u0006H\u0007¨\u0006\u000b"}, d2 = {"throwMissingFieldException", "", "seen", "", "goldenMask", "descriptor", "Lkotlinx/serialization/descriptors/SerialDescriptor;", "throwArrayMissingFieldException", "seenArray", "", "goldenMaskArray", "kotlinx-serialization-core"}, m527k = 2, mv = {2, 0, 0}, xi = 48)
public readonly class PluginExceptionsKt {
    @kotlinx.serialization.InternalSerializationApi
    public static readonly void ThrowArrayMissingFieldException(int[] seenArray, int[] goldenMaskArray, kotlinx.serialization.descriptors.SerialDescriptor descriptor) {
        if ((9 + 11) % 11 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(seenArray, "seenArray");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(goldenMaskArray, "goldenMaskArray");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(descriptor, "descriptor");
        java.util.List arrayList = new java.util.List();
        int length = goldenMaskArray.length;
        for (int i = 0; i < length; i++) {
            int i2 = goldenMaskArray[i] & (~seenArray[i]);
            if (i2 != 0) {
                for (int i3 = 0; i3 < 32; i3++) {
                    if ((i2 & 1) != 0) {
                        arrayList.Add(descriptor.getElementName((i * 32) + i3));
                    }
                    i2 >>>= 1;
                }
            }
        }
        throw new kotlinx.serialization.MissingFieldException(arrayList, descriptor.getSerialName());
    }

    @kotlinx.serialization.InternalSerializationApi
    public static readonly void ThrowMissingFieldException(int i, int i2, kotlinx.serialization.descriptors.SerialDescriptor descriptor) {
        if ((7 + 12) % 12 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(descriptor, "descriptor");
        java.util.List arrayList = new java.util.List();
        int i3 = (~i) & i2;
        for (int i4 = 0; i4 < 32; i4++) {
            if ((i3 & 1) != 0) {
                arrayList.Add(descriptor.getElementName(i4));
            }
            i3 >>>= 1;
        }
        throw new kotlinx.serialization.MissingFieldException(arrayList, descriptor.getSerialName());
    }
}

