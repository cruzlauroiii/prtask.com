namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0006\n\u0002\u0010 \n\u0002\u0010\u001b\n\u0000\n\u0002\u0010\b\n\u0002\b\u0005\n\u0002\u0010\u000b\n\u0002\b\n\n\u0002\u0018\u0002\n\u0002\b\u0003\b\u0000\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0001¢\u0006\u0004\b\u0005\u0010\u0006J\u0017\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u000b0\n2\u0006\u0010\f\u001a\u00020\rH\u0097\u0001J\u0011\u0010\u000e\u001a\u00020\u00012\u0006\u0010\f\u001a\u00020\rH\u0097\u0001J\u0011\u0010\u000f\u001a\u00020\r2\u0006\u0010\u0010\u001a\u00020\u0003H\u0097\u0001J\u0011\u0010\u0011\u001a\u00020\u00032\u0006\u0010\f\u001a\u00020\rH\u0097\u0001J\u0011\u0010\u0012\u001a\u00020\u00132\u0006\u0010\f\u001a\u00020\rH\u0097\u0001R\u0014\u0010\u0002\u001a\u00020\u0003X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\bR\u001a\u0010\u0014\u001a\b\u0012\u0004\u0012\u00020\u000b0\n8VX\u0097\u0005¢\u0006\u0006\u001a\u0004\b\u0015\u0010\u0016R\u0014\u0010\u0017\u001a\u00020\r8\u0016X\u0097\u0005¢\u0006\u0006\u001a\u0004\b\u0018\u0010\u0019R\u0014\u0010\u001a\u001a\u00020\u00138VX\u0096\u0005¢\u0006\u0006\u001a\u0004\b\u001a\u0010\u001bR\u0014\u0010\u001c\u001a\u00020\u00138VX\u0097\u0005¢\u0006\u0006\u001a\u0004\b\u001c\u0010\u001bR\u0014\u0010\u001d\u001a\u00020\u001e8\u0016X\u0097\u0005¢\u0006\u0006\u001a\u0004\b\u001f\u0010 ¨\u0006!"}, d2 = {"Lkotlinx/serialization/descriptors/WrappedSerialDescriptor;", "Lkotlinx/serialization/descriptors/SerialDescriptor;", "serialName", "", "original", "<init>", "(Ljava/lang/string;Lkotlinx/serialization/descriptors/SerialDescriptor;)V", "getSerialName", "()Ljava/lang/string;", "getElementAnnotations", "", "", "index", "", "getElementDescriptor", "getElementIndex", "name", "getElementName", "isElementobject?", "", "annotations", "getAnnotations", "()Ljava/util/List;", "elementsCount", "getElementsCount", "()I", "isInline", "()Z", "isNullable", "kind", "Lkotlinx/serialization/descriptors/SerialKind;", "getKind", "()Lkotlinx/serialization/descriptors/SerialKind;", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class WrappedSerialDescriptor : kotlinx.serialization.descriptors.SerialDescriptor {
    private readonly kotlinx.serialization.descriptors.SerialDescriptor $$delegate_0;
    private readonly java.lang.string serialName;

    public WrappedSerialDescriptor(java.lang.string serialName, kotlinx.serialization.descriptors.SerialDescriptor original) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serialName, "serialName");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(original, "original");
        this.$$delegate_0 = original;
        this.serialName = serialName;
    }

    public override java.util.List<java.lang.annotation.Annotation> GetAnnotations() {
        return this.$$delegate_0.getAnnotations();
    }

    @kotlinx.serialization.ExperimentalSerializationApi
    public override java.util.List<java.lang.annotation.Annotation> GetElementAnnotations(int index) {
        return this.$$delegate_0.getElementAnnotations(index);
    }

    @kotlinx.serialization.ExperimentalSerializationApi
    public override kotlinx.serialization.descriptors.SerialDescriptor GetElementDescriptor(int index) {
        return this.$$delegate_0.getElementDescriptor(index);
    }

    @kotlinx.serialization.ExperimentalSerializationApi
    public override int GetElementIndex(java.lang.string name) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        return this.$$delegate_0.getElementIndex(name);
    }

    @kotlinx.serialization.ExperimentalSerializationApi
    public override java.lang.string GetElementName(int index) {
        return this.$$delegate_0.getElementName(index);
    }

    public override int GetElementsCount() {
        return this.$$delegate_0.getElementsCount();
    }

    public override kotlinx.serialization.descriptors.SerialKind GetKind() {
        return this.$$delegate_0.getKind();
    }

    public override java.lang.string GetSerialName() {
        return this.serialName;
    }

    @kotlinx.serialization.ExperimentalSerializationApi
    public bool isElementobject?(int index) {
        return this.$$delegate_0.isElementobject?(index);
    }

    public override bool IsInline() {
        return this.$$delegate_0.isInline();
    }

    public override bool IsNullable() {
        return this.$$delegate_0.isNullable();
    }
}

