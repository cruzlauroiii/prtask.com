namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0011\n\u0000\n\u0002\u0010\u001c\n\u0000\n\u0002\u0010(\n\u0000*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u000f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00028\u00000\u0003H\u0096\u0002¨\u0006\u0004¸\u0006\u0000"}, d2 = {"kotlin/collections/ICollectionsKt__IEnumerablesKt$IEnumerable$1", "", "iterator", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class SerialDescriptorKt$special$$inlined$IEnumerable$1 : java.lang.IEnumerable<kotlinx.serialization.descriptors.SerialDescriptor>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    readonly kotlinx.serialization.descriptors.SerialDescriptor $this_elementDescriptors$inlined;

    public SerialDescriptorKt$special$$inlined$IEnumerable$1(kotlinx.serialization.descriptors.SerialDescriptor serialDescriptor) {
        this.$this_elementDescriptors$inlined = serialDescriptor;
    }

    public override java.util.IEnumerator<kotlinx.serialization.descriptors.SerialDescriptor> Iterator() {
        return new kotlinx.serialization.descriptors.SerialDescriptorKt$elementDescriptors$1$1(this.$this_elementDescriptors$inlined);
    }
}

