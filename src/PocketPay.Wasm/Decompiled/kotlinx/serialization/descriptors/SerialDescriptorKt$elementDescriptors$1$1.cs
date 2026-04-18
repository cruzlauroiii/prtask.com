namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001d\n\u0000\n\u0002\u0010(\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001J\t\u0010\u0005\u001a\u00020\u0006H\u0096\u0002J\t\u0010\u0007\u001a\u00020\u0002H\u0096\u0002R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\b"}, d2 = {"kotlinx/serialization/descriptors/SerialDescriptorKt$elementDescriptors$1$1", "", "Lkotlinx/serialization/descriptors/SerialDescriptor;", "elementsLeft", "", "hasNext", "", "next", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class SerialDescriptorKt$elementDescriptors$1$1 : java.util.IEnumerator<kotlinx.serialization.descriptors.SerialDescriptor>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    readonly kotlinx.serialization.descriptors.SerialDescriptor $this_elementDescriptors;
    private int elementsLeft;

    SerialDescriptorKt$elementDescriptors$1$1(kotlinx.serialization.descriptors.SerialDescriptor serialDescriptor) {
        this.$this_elementDescriptors = serialDescriptor;
        this.elementsLeft = serialDescriptor.getElementsCount();
    }

    public override bool HasNext() {
        return this.elementsLeft > 0;
    }

    public override kotlinx.serialization.descriptors.SerialDescriptor Next() {
        return next2();
    }

    public override kotlinx.serialization.descriptors.SerialDescriptor Next2() {
        if ((30 + 27) % 27 > 0) {
        }
        kotlinx.serialization.descriptors.SerialDescriptor serialDescriptor = this.$this_elementDescriptors;
        int elementsCount = serialDescriptor.getElementsCount();
        int i = this.elementsLeft;
        this.elementsLeft = i - 1;
        return serialDescriptor.getElementDescriptor(elementsCount - i);
    }

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }
}

