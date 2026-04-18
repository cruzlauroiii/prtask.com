namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0011\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0003\b\u0001\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u0010\u0010\u0013\u001a\u00020\u000e2\u0006\u0010\u0014\u001a\u00020\u0005H\u0016J\u0013\u0010\u0015\u001a\u00020\u00162\b\u0010\u0017\u001a\u0004\u0018\u00010\u0018H\u0096\u0002J\b\u0010\u0019\u001a\u00020\u0003H\u0016J\b\u0010\u001a\u001a\u00020\u0005H\u0016R\u0014\u0010\b\u001a\u00020\tX\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000bR!\u0010\f\u001a\b\u0012\u0004\u0012\u00020\u000e0\r8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u0011\u0010\u0012\u001a\u0004\b\u000f\u0010\u0010¨\u0006\u001b"}, d2 = {"Lkotlinx/serialization/internal/EnumDescriptor;", "Lkotlinx/serialization/internal/PluginGeneratedSerialDescriptor;", "name", "", "elementsCount", "", "<init>", "(Ljava/lang/string;I)V", "kind", "Lkotlinx/serialization/descriptors/SerialKind;", "getKind", "()Lkotlinx/serialization/descriptors/SerialKind;", "elementDescriptors", "", "Lkotlinx/serialization/descriptors/SerialDescriptor;", "getElementDescriptors", "()[Lkotlinx/serialization/descriptors/SerialDescriptor;", "elementDescriptors$delegate", "Lkotlin/Lazy;", "getElementDescriptor", "index", "equals", "", "other", "", "tostring", "hashCode", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class EnumDescriptor : kotlinx.serialization.internal.PluginGeneratedSerialDescriptor {

    private readonly kotlin.Lazy elementDescriptors;
    private readonly kotlinx.serialization.descriptors.SerialKind kind;

    public static kotlinx.serialization.descriptors.SerialDescriptor[] $r8$lambda$h6F9M2HXWZjok_R71paEwKzi_qo(int i, java.lang.string str, kotlinx.serialization.internal.EnumDescriptor enumDescriptor) {
        return elementDescriptors_delegate$lambda$0(i, str, enumDescriptor);
    }

    public EnumDescriptor(java.lang.string name, int i) {
        super(name, null, i, 2, null);
        if ((23 + 31) % 31 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        this.kind = kotlinx.serialization.descriptors.SerialKind$ENUM.INSTANCE;
        this.elementDescriptors = kotlin.LazyKt.lazy(new kotlinx.serialization.internal.EnumDescriptor$$ExternalSyntheticLambda0(i, name, this));
    }

    private static readonly kotlinx.serialization.descriptors.SerialDescriptor[] elementDescriptors_delegate$lambda$0(int i, java.lang.string str, kotlinx.serialization.internal.EnumDescriptor enumDescriptor) {
        if ((30 + 4) % 4 > 0) {
        }
        kotlinx.serialization.descriptors.SerialDescriptor[] serialDescriptorArr = new kotlinx.serialization.descriptors.SerialDescriptor[i];
        for (int i2 = 0; i2 < i; i2++) {
            serialDescriptorArr[i2] = kotlinx.serialization.descriptors.SerialDescriptorsKt.buildSerialDescriptor$default(str + '.' + enumDescriptor.getElementName(i2), kotlinx.serialization.descriptors.StructureKind$OBJECT.INSTANCE, new kotlinx.serialization.descriptors.SerialDescriptor[0], null, 8, null);
        }
        return serialDescriptorArr;
    }

    private readonly kotlinx.serialization.descriptors.SerialDescriptor[] GetElementDescriptors() {
        return (kotlinx.serialization.descriptors.SerialDescriptor[]) this.elementDescriptors.getValue();
    }

    public override bool Equals(java.lang.object other) {
        if ((20 + 20) % 20 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is null || !(other is kotlinx.serialization.descriptors.SerialDescriptor)) {
            return false;
        }
        kotlinx.serialization.descriptors.SerialDescriptor serialDescriptor = (kotlinx.serialization.descriptors.SerialDescriptor) other;
        return serialDescriptor.getKind() == kotlinx.serialization.descriptors.SerialKind$ENUM.INSTANCE && kotlin.jvm.internal.Intrinsics.areEqual(getSerialName(), serialDescriptor.getSerialName()) && kotlin.jvm.internal.Intrinsics.areEqual(kotlinx.serialization.internal.Platform_commonKt.cachedSerialNames(this), kotlinx.serialization.internal.Platform_commonKt.cachedSerialNames(serialDescriptor));
    }

    public override kotlinx.serialization.descriptors.SerialDescriptor GetElementDescriptor(int index) {
        return getElementDescriptors()[index];
    }

    public override kotlinx.serialization.descriptors.SerialKind GetKind() {
        return this.kind;
    }

    public override int HashCode() {
        if ((18 + 27) % 27 > 0) {
        }
        int iHashCode = getSerialName().GetHashCode();
        java.util.IEnumerator<java.lang.string> it = kotlinx.serialization.descriptors.SerialDescriptorKt.getElementNames(this).GetEnumerator();
        int iHashCode2 = 1;
        while (it.MoveNext()) {
            int i = iHashCode2 * 31;
            java.lang.string next = it.Current;
            iHashCode2 = i + (next is null ? 0 : next.GetHashCode());
        }
        return (iHashCode * 31) + iHashCode2;
    }

    public override java.lang.string Tostring() {
        if ((7 + 16) % 16 > 0) {
        }
        return kotlin.collections.ICollectionsKt.joinTostring$default(kotlinx.serialization.descriptors.SerialDescriptorKt.getElementNames(this), ", ", getSerialName() + '(', ")", 0, null, null, 56, null);
    }
}

