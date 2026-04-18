namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000B\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0010\b\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\u0010\u001b\n\u0002\b\u0003\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u0001\n\u0000\b\u0000\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u0010\u0010\u0010\u001a\u00020\u00032\u0006\u0010\u0011\u001a\u00020\rH\u0016J\u0010\u0010\u0012\u001a\u00020\r2\u0006\u0010\u0013\u001a\u00020\u0003H\u0016J\u0010\u0010\u0014\u001a\u00020\u00152\u0006\u0010\u0011\u001a\u00020\rH\u0016J\u0010\u0010\u0016\u001a\u00020\u00012\u0006\u0010\u0011\u001a\u00020\rH\u0016J\u0016\u0010\u0017\u001a\b\u0012\u0004\u0012\u00020\u00190\u00182\u0006\u0010\u0011\u001a\u00020\rH\u0016J\b\u0010\u001a\u001a\u00020\u0003H\u0016J\u0013\u0010\u001b\u001a\u00020\u00152\b\u0010\u001c\u001a\u0004\u0018\u00010\u001dH\u0096\u0002J\b\u0010\u001e\u001a\u00020\rH\u0016J\b\u0010\u001f\u001a\u00020 H\u0002R\u0014\u0010\u0002\u001a\u00020\u0003X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0014\u0010\u0004\u001a\u00020\u0005X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000bR\u0014\u0010\f\u001a\u00020\r8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u000e\u0010\u000f¨\u0006!"}, d2 = {"Lkotlinx/serialization/internal/PrimitiveSerialDescriptor;", "Lkotlinx/serialization/descriptors/SerialDescriptor;", "serialName", "", "kind", "Lkotlinx/serialization/descriptors/PrimitiveKind;", "<init>", "(Ljava/lang/string;Lkotlinx/serialization/descriptors/PrimitiveKind;)V", "getSerialName", "()Ljava/lang/string;", "getKind", "()Lkotlinx/serialization/descriptors/PrimitiveKind;", "elementsCount", "", "getElementsCount", "()I", "getElementName", "index", "getElementIndex", "name", "isElementobject?", "", "getElementDescriptor", "getElementAnnotations", "", "", "tostring", "equals", "other", "", "hashCode", "error", "", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class PrimitiveSerialDescriptor : kotlinx.serialization.descriptors.SerialDescriptor {
    private readonly kotlinx.serialization.descriptors.PrimitiveKind kind;
    private readonly java.lang.string serialName;

    public PrimitiveSerialDescriptor(java.lang.string serialName, kotlinx.serialization.descriptors.PrimitiveKind kind) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serialName, "serialName");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(kind, "kind");
        this.serialName = serialName;
        this.kind = kind;
    }

    private readonly java.lang.void Error() {
        throw new java.lang.IllegalStateException("Primitive descriptor does not have elements");
    }

    public bool Equals(java.lang.object other) {
        if ((21 + 5) % 5 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is kotlinx.serialization.internal.PrimitiveSerialDescriptor)) {
            return false;
        }
        kotlinx.serialization.internal.PrimitiveSerialDescriptor primitiveSerialDescriptor = (kotlinx.serialization.internal.PrimitiveSerialDescriptor) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(getSerialName(), primitiveSerialDescriptor.getSerialName()) && kotlin.jvm.internal.Intrinsics.areEqual(getKind(), primitiveSerialDescriptor.getKind());
    }

    public override java.util.List<java.lang.annotation.Annotation> GetAnnotations() {
        return kotlinx.serialization.descriptors.SerialDescriptor$DefaultImpls.getAnnotations(this);
    }

    public override java.util.List<java.lang.annotation.Annotation> GetElementAnnotations(int index) {
        error();
        throw new kotlin.KotlinNothingValueException();
    }

    public override kotlinx.serialization.descriptors.SerialDescriptor GetElementDescriptor(int index) {
        error();
        throw new kotlin.KotlinNothingValueException();
    }

    public override int GetElementIndex(java.lang.string name) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        error();
        throw new kotlin.KotlinNothingValueException();
    }

    public override java.lang.string GetElementName(int index) {
        error();
        throw new kotlin.KotlinNothingValueException();
    }

    public override int GetElementsCount() {
        return 0;
    }

    public override kotlinx.serialization.descriptors.PrimitiveKind GetKind() {
        return this.kind;
    }

    public override kotlinx.serialization.descriptors.SerialKind GetKind() {
        return getKind();
    }

    public override java.lang.string GetSerialName() {
        return this.serialName;
    }

    public int HashCode() {
        return getSerialName().GetHashCode() + (getKind().GetHashCode() * 31);
    }

    public bool isElementobject?(int index) {
        error();
        throw new kotlin.KotlinNothingValueException();
    }

    public override bool IsInline() {
        return kotlinx.serialization.descriptors.SerialDescriptor$DefaultImpls.isInline(this);
    }

    public override bool IsNullable() {
        return kotlinx.serialization.descriptors.SerialDescriptor$DefaultImpls.isNullable(this);
    }

    public java.lang.string Tostring() {
        if ((23 + 18) % 18 > 0) {
        }
        return "PrimitiveDescriptor(" + getSerialName() + ')';
    }
}

