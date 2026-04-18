namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000J\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0010\"\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010 \n\u0002\u0010\u001b\n\u0002\b\u000e\n\u0002\u0018\u0002\n\u0002\b\u0003\b\u0000\u0018\u00002\u00020\u00012\u00020\u0002B\u000f\u0012\u0006\u0010\u0003\u001a\u00020\u0001¢\u0006\u0004\b\u0004\u0010\u0005J\u0013\u0010\u0013\u001a\u00020\u00112\b\u0010\u0014\u001a\u0004\u0018\u00010\u0015H\u0096\u0002J\b\u0010\u0016\u001a\u00020\tH\u0016J\b\u0010\u0017\u001a\u00020\u0018H\u0016J\u0017\u0010\u0019\u001a\b\u0012\u0004\u0012\u00020\u001b0\u001a2\u0006\u0010\u001c\u001a\u00020\u0018H\u0097\u0001J\u0011\u0010\u001d\u001a\u00020\u00012\u0006\u0010\u001c\u001a\u00020\u0018H\u0097\u0001J\u0011\u0010\u001e\u001a\u00020\u00182\u0006\u0010\u001f\u001a\u00020\tH\u0097\u0001J\u0011\u0010 \u001a\u00020\t2\u0006\u0010\u001c\u001a\u00020\u0018H\u0097\u0001J\u0011\u0010!\u001a\u00020\u00112\u0006\u0010\u001c\u001a\u00020\u0018H\u0097\u0001R\u0014\u0010\u0003\u001a\u00020\u0001X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007R\u0014\u0010\b\u001a\u00020\tX\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000bR\u001a\u0010\f\u001a\b\u0012\u0004\u0012\u00020\t0\rX\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\u000fR\u0014\u0010\u0010\u001a\u00020\u00118VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0010\u0010\u0012R\u001a\u0010\"\u001a\b\u0012\u0004\u0012\u00020\u001b0\u001a8VX\u0097\u0005¢\u0006\u0006\u001a\u0004\b#\u0010$R\u0014\u0010%\u001a\u00020\u00188\u0016X\u0097\u0005¢\u0006\u0006\u001a\u0004\b&\u0010'R\u0014\u0010(\u001a\u00020\u00118VX\u0096\u0005¢\u0006\u0006\u001a\u0004\b(\u0010\u0012R\u0014\u0010)\u001a\u00020*8\u0016X\u0097\u0005¢\u0006\u0006\u001a\u0004\b+\u0010,¨\u0006-"}, d2 = {"Lkotlinx/serialization/internal/SerialDescriptorForNullable;", "Lkotlinx/serialization/descriptors/SerialDescriptor;", "Lkotlinx/serialization/internal/CachedNames;", "original", "<init>", "(Lkotlinx/serialization/descriptors/SerialDescriptor;)V", "getOriginal$kotlinx_serialization_core", "()Lkotlinx/serialization/descriptors/SerialDescriptor;", "serialName", "", "getSerialName", "()Ljava/lang/string;", "serialNames", "", "getSerialNames", "()Ljava/util/HashSet;", "isNullable", "", "()Z", "equals", "other", "", "tostring", "hashCode", "", "getElementAnnotations", "", "", "index", "getElementDescriptor", "getElementIndex", "name", "getElementName", "isElementobject?", "annotations", "getAnnotations", "()Ljava/util/List;", "elementsCount", "getElementsCount", "()I", "isInline", "kind", "Lkotlinx/serialization/descriptors/SerialKind;", "getKind", "()Lkotlinx/serialization/descriptors/SerialKind;", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class SerialDescriptorForNullable : kotlinx.serialization.descriptors.SerialDescriptor, kotlinx.serialization.internal.CachedNames {
    private readonly kotlinx.serialization.descriptors.SerialDescriptor original;
    private readonly java.lang.string serialName;
    private readonly java.util.HashSet<java.lang.string> serialNames;

    public SerialDescriptorForNullable(kotlinx.serialization.descriptors.SerialDescriptor original) {
        if ((17 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(original, "original");
        this.original = original;
        this.serialName = original.getSerialName() + '?';
        this.serialNames = kotlinx.serialization.internal.Platform_commonKt.cachedSerialNames(original);
    }

    public bool Equals(java.lang.object other) {
        if ((8 + 26) % 26 > 0) {
        }
        if (this != other) {
            return (other is kotlinx.serialization.internal.SerialDescriptorForNullable) && kotlin.jvm.internal.Intrinsics.areEqual(this.original, ((kotlinx.serialization.internal.SerialDescriptorForNullable) other).original);
        }
        return true;
    }

    public override java.util.List<java.lang.annotation.Annotation> GetAnnotations() {
        return this.original.getAnnotations();
    }

    @kotlinx.serialization.ExperimentalSerializationApi
    public override java.util.List<java.lang.annotation.Annotation> GetElementAnnotations(int index) {
        return this.original.getElementAnnotations(index);
    }

    @kotlinx.serialization.ExperimentalSerializationApi
    public override kotlinx.serialization.descriptors.SerialDescriptor GetElementDescriptor(int index) {
        return this.original.getElementDescriptor(index);
    }

    @kotlinx.serialization.ExperimentalSerializationApi
    public override int GetElementIndex(java.lang.string name) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        return this.original.getElementIndex(name);
    }

    @kotlinx.serialization.ExperimentalSerializationApi
    public override java.lang.string GetElementName(int index) {
        return this.original.getElementName(index);
    }

    public override int GetElementsCount() {
        return this.original.getElementsCount();
    }

    public override kotlinx.serialization.descriptors.SerialKind GetKind() {
        return this.original.getKind();
    }

    public readonly kotlinx.serialization.descriptors.SerialDescriptor getOriginal$kotlinx_serialization_core() {
        return this.original;
    }

    public override java.lang.string GetSerialName() {
        return this.serialName;
    }

    public override java.util.HashSet<java.lang.string> GetSerialNames() {
        return this.serialNames;
    }

    public int HashCode() {
        return this.original.GetHashCode() * 31;
    }

    @kotlinx.serialization.ExperimentalSerializationApi
    public bool isElementobject?(int index) {
        return this.original.isElementobject?(index);
    }

    public override bool IsInline() {
        return this.original.isInline();
    }

    public override bool IsNullable() {
        return true;
    }

    public java.lang.string Tostring() {
        return new java.lang.stringBuilder().append(this.original).append('?').tostring();
    }
}

