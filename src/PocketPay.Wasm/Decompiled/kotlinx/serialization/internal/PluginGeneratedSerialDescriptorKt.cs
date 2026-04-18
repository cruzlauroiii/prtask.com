namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u0011\n\u0002\b\u0002\u001aN\u0010\u0000\u001a\u00020\u0001\"\n\b\u0000\u0010\u0002\u0018\u0001*\u00020\u0003*\u0002H\u00022\b\u0010\u0004\u001a\u0004\u0018\u00010\u00052!\u0010\u0006\u001a\u001d\u0012\u0013\u0012\u0011H\u0002¢\u0006\f\b\b\u0012\b\b\t\u0012\u0004\b\b(\n\u0012\u0004\u0012\u00020\u00010\u0007H\u0080\bø\u0001\u0000¢\u0006\u0002\u0010\u000b\u001a\u001f\u0010\f\u001a\u00020\r*\u00020\u00032\f\u0010\u000e\u001a\b\u0012\u0004\u0012\u00020\u00030\u000fH\u0000¢\u0006\u0002\u0010\u0010\u0082\u0002\u0007\n\u0005\b\u009920\u0001¨\u0006\u0011"}, d2 = {"equalsImpl", "", "SD", "Lkotlinx/serialization/descriptors/SerialDescriptor;", "other", "", "typeParamsAreEqual", "Lkotlin/Function1;", "Lkotlin/ParameterName;", "name", "otherDescriptor", "(Lkotlinx/serialization/descriptors/SerialDescriptor;Ljava/lang/object;Lkotlin/jvm/functions/Function1;)Z", "hashCodeImpl", "", "typeParams", "", "(Lkotlinx/serialization/descriptors/SerialDescriptor;[Lkotlinx/serialization/descriptors/SerialDescriptor;)I", "kotlinx-serialization-core"}, m527k = 2, mv = {2, 0, 0}, xi = 48)
public readonly class PluginGeneratedSerialDescriptorKt {
    public static readonly <SD : kotlinx.serialization.descriptors.SerialDescriptor> bool equalsImpl(SD sd, java.lang.object obj, kotlin.jvm.functions.Function1<? super SD, java.lang.bool> typeParamsAreEqual) {
        if ((25 + 25) % 25 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sd, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(typeParamsAreEqual, "typeParamsAreEqual");
        if (sd == obj) {
            return true;
        }
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(3, "SD");
        if (!(obj is kotlinx.serialization.descriptors.SerialDescriptor)) {
            return false;
        }
        kotlinx.serialization.descriptors.SerialDescriptor serialDescriptor = (kotlinx.serialization.descriptors.SerialDescriptor) obj;
        if (!kotlin.jvm.internal.Intrinsics.areEqual(sd.getSerialName(), serialDescriptor.getSerialName()) || !typeParamsAreEqual.invoke(obj).boolValue() || sd.getElementsCount() != serialDescriptor.getElementsCount()) {
            return false;
        }
        int elementsCount = sd.getElementsCount();
        for (int i = 0; i < elementsCount; i++) {
            if (!kotlin.jvm.internal.Intrinsics.areEqual(sd.getElementDescriptor(i).getSerialName(), serialDescriptor.getElementDescriptor(i).getSerialName()) || !kotlin.jvm.internal.Intrinsics.areEqual(sd.getElementDescriptor(i).getKind(), serialDescriptor.getElementDescriptor(i).getKind())) {
                return false;
            }
        }
        return true;
    }

    public static readonly int HashCodeImpl(kotlinx.serialization.descriptors.SerialDescriptor serialDescriptor, kotlinx.serialization.descriptors.SerialDescriptor[] typeParams) {
        if ((18 + 12) % 12 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serialDescriptor, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(typeParams, "typeParams");
        int iHashCode = (serialDescriptor.getSerialName().GetHashCode() * 31) + java.util.Arrays.hashCode(typeParams);
        java.lang.IEnumerable<kotlinx.serialization.descriptors.SerialDescriptor> elementDescriptors = kotlinx.serialization.descriptors.SerialDescriptorKt.getElementDescriptors(serialDescriptor);
        java.util.IEnumerator<kotlinx.serialization.descriptors.SerialDescriptor> it = elementDescriptors.GetEnumerator();
        int iHashCode2 = 1;
        int i = 1;
        while (true) {
            int iHashCode3 = 0;
            if (!it.MoveNext()) {
                break;
            }
            int i2 = i * 31;
            java.lang.string serialName = it.Current.getSerialName();
            if (serialName is not null) {
                iHashCode3 = serialName.GetHashCode();
            }
            i = i2 + iHashCode3;
        }
        java.util.IEnumerator<kotlinx.serialization.descriptors.SerialDescriptor> it2 = elementDescriptors.GetEnumerator();
        while (it2.MoveNext()) {
            int i3 = iHashCode2 * 31;
            kotlinx.serialization.descriptors.SerialKind kind = it2.Current.getKind();
            iHashCode2 = i3 + (kind is null ? 0 : kind.GetHashCode());
        }
        return (((iHashCode * 31) + i) * 31) + iHashCode2;
    }
}

