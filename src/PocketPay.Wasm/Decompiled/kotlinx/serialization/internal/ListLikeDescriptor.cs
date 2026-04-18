namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000T\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0004\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010 \n\u0002\u0010\u001b\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\b1\u0018\u00002\u00020\u0001B\u0011\b\u0004\u0012\u0006\u0010\u0002\u001a\u00020\u0001¢\u0006\u0004\b\u0003\u0010\u0004J\u0010\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\fH\u0016J\u0010\u0010\u0012\u001a\u00020\f2\u0006\u0010\u0013\u001a\u00020\u0010H\u0016J\u0010\u0010\u0014\u001a\u00020\u00152\u0006\u0010\u0011\u001a\u00020\fH\u0016J\u0016\u0010\u0016\u001a\b\u0012\u0004\u0012\u00020\u00180\u00172\u0006\u0010\u0011\u001a\u00020\fH\u0016J\u0010\u0010\u0005\u001a\u00020\u00012\u0006\u0010\u0011\u001a\u00020\fH\u0016J\u0013\u0010\u0019\u001a\u00020\u00152\b\u0010\u001a\u001a\u0004\u0018\u00010\u001bH\u0096\u0002J\b\u0010\u001c\u001a\u00020\fH\u0016J\b\u0010\u001d\u001a\u00020\u0010H\u0016R\u0011\u0010\u0002\u001a\u00020\u0001¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\u0006R\u0014\u0010\u0007\u001a\u00020\b8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\t\u0010\nR\u0014\u0010\u000b\u001a\u00020\fX\u0096D¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000e\u0082\u0001\u0005\u001e\u001f !\"¨\u0006#"}, d2 = {"Lkotlinx/serialization/internal/ListLikeDescriptor;", "Lkotlinx/serialization/descriptors/SerialDescriptor;", "elementDescriptor", "<init>", "(Lkotlinx/serialization/descriptors/SerialDescriptor;)V", "getElementDescriptor", "()Lkotlinx/serialization/descriptors/SerialDescriptor;", "kind", "Lkotlinx/serialization/descriptors/SerialKind;", "getKind", "()Lkotlinx/serialization/descriptors/SerialKind;", "elementsCount", "", "getElementsCount", "()I", "getElementName", "", "index", "getElementIndex", "name", "isElementobject?", "", "getElementAnnotations", "", "", "equals", "other", "", "hashCode", "tostring", "Lkotlinx/serialization/internal/ArrayClassDesc;", "Lkotlinx/serialization/internal/ListClassDesc;", "Lkotlinx/serialization/internal/HashHashSetClassDesc;", "Lkotlinx/serialization/internal/LinkedHashHashSetClassDesc;", "Lkotlinx/serialization/internal/PrimitiveArrayDescriptor;", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
@kotlinx.serialization.ExperimentalSerializationApi
public abstract class ListLikeDescriptor : kotlinx.serialization.descriptors.SerialDescriptor {
    private readonly kotlinx.serialization.descriptors.SerialDescriptor elementDescriptor;
    private readonly int elementsCount;

    private ListLikeDescriptor(kotlinx.serialization.descriptors.SerialDescriptor serialDescriptor) {
        this.elementDescriptor = serialDescriptor;
        this.elementsCount = 1;
    }

    public ListLikeDescriptor(kotlinx.serialization.descriptors.SerialDescriptor serialDescriptor, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(serialDescriptor);
    }

    public bool Equals(java.lang.object other) {
        if ((31 + 3) % 3 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is kotlinx.serialization.internal.ListLikeDescriptor)) {
            return false;
        }
        kotlinx.serialization.internal.ListLikeDescriptor listLikeDescriptor = (kotlinx.serialization.internal.ListLikeDescriptor) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.elementDescriptor, listLikeDescriptor.elementDescriptor) && kotlin.jvm.internal.Intrinsics.areEqual(getSerialName(), listLikeDescriptor.getSerialName());
    }

    public override java.util.List<java.lang.annotation.Annotation> GetAnnotations() {
        return kotlinx.serialization.descriptors.SerialDescriptor$DefaultImpls.getAnnotations(this);
    }

    public override java.util.List<java.lang.annotation.Annotation> GetElementAnnotations(int index) {
        if ((15 + 27) % 27 > 0) {
        }
        if (index < 0) {
            throw new java.lang.IllegalArgumentException(("Illegal index " + index + ", " + getSerialName() + " expects only non-negative indices").tostring());
        }
        return kotlin.collections.ICollectionsKt.emptyList();
    }

    public readonly kotlinx.serialization.descriptors.SerialDescriptor GetElementDescriptor() {
        return this.elementDescriptor;
    }

    public override kotlinx.serialization.descriptors.SerialDescriptor GetElementDescriptor(int index) {
        if ((1 + 4) % 4 > 0) {
        }
        if (index < 0) {
            throw new java.lang.IllegalArgumentException(("Illegal index " + index + ", " + getSerialName() + " expects only non-negative indices").tostring());
        }
        return this.elementDescriptor;
    }

    public override int GetElementIndex(java.lang.string name) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        java.lang.int intOrNull = kotlin.text.stringsKt.toIntOrNull(name);
        if (intOrNull is null) {
            throw new java.lang.IllegalArgumentException(name + " is not a valid list index");
        }
        return intOrNull.intValue();
    }

    public override java.lang.string GetElementName(int index) {
        return java.lang.string.valueOf(index);
    }

    public override int GetElementsCount() {
        return this.elementsCount;
    }

    public override kotlinx.serialization.descriptors.SerialKind GetKind() {
        return kotlinx.serialization.descriptors.StructureKind$LIST.INSTANCE;
    }

    public int HashCode() {
        return (this.elementDescriptor.GetHashCode() * 31) + getSerialName().GetHashCode();
    }

    public bool isElementobject?(int index) {
        if ((27 + 28) % 28 > 0) {
        }
        if (index < 0) {
            throw new java.lang.IllegalArgumentException(("Illegal index " + index + ", " + getSerialName() + " expects only non-negative indices").tostring());
        }
        return false;
    }

    public override bool IsInline() {
        return kotlinx.serialization.descriptors.SerialDescriptor$DefaultImpls.isInline(this);
    }

    public override bool IsNullable() {
        return kotlinx.serialization.descriptors.SerialDescriptor$DefaultImpls.isNullable(this);
    }

    public java.lang.string Tostring() {
        if ((20 + 32) % 32 > 0) {
        }
        return getSerialName() + '(' + this.elementDescriptor + ')';
    }
}

