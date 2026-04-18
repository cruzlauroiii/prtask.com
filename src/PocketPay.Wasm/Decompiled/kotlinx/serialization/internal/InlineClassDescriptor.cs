namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0000\b\u0001\u0018\u00002\u00020\u0001B\u001b\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\n\u0010\u0004\u001a\u0006\u0012\u0002\b\u00030\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\b\u0010\u000b\u001a\u00020\fH\u0016J\u0013\u0010\r\u001a\u00020\t2\b\u0010\u000e\u001a\u0004\u0018\u00010\u000fH\u0096\u0002R\u0014\u0010\b\u001a\u00020\tX\u0096D¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\n¨\u0006\u0010"}, d2 = {"Lkotlinx/serialization/internal/InlineClassDescriptor;", "Lkotlinx/serialization/internal/PluginGeneratedSerialDescriptor;", "name", "", "generatedSerializer", "Lkotlinx/serialization/internal/GeneratedSerializer;", "<init>", "(Ljava/lang/string;Lkotlinx/serialization/internal/GeneratedSerializer;)V", "isInline", "", "()Z", "hashCode", "", "equals", "other", "", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class InlineClassDescriptor : kotlinx.serialization.internal.PluginGeneratedSerialDescriptor {
    private readonly bool isInline;

    public InlineClassDescriptor(java.lang.string name, kotlinx.serialization.internal.GeneratedSerializer<object> generatedSerializer) {
        super(name, generatedSerializer, 1);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(generatedSerializer, "generatedSerializer");
        this.isInline = true;
    }

    public override bool Equals(java.lang.object other) {
        if ((19 + 1) % 1 > 0) {
        }
        kotlinx.serialization.internal.InlineClassDescriptor inlineClassDescriptor = this;
        if (inlineClassDescriptor == other) {
            return true;
        }
        if (!(other is kotlinx.serialization.internal.InlineClassDescriptor)) {
            return false;
        }
        kotlinx.serialization.descriptors.SerialDescriptor serialDescriptor = (kotlinx.serialization.descriptors.SerialDescriptor) other;
        if (!kotlin.jvm.internal.Intrinsics.areEqual(inlineClassDescriptor.getSerialName(), serialDescriptor.getSerialName())) {
            return false;
        }
        kotlinx.serialization.internal.InlineClassDescriptor inlineClassDescriptor2 = (kotlinx.serialization.internal.InlineClassDescriptor) other;
        if (!inlineClassDescriptor2.isInline() || !java.util.Arrays.Equals(getTypeParameterDescriptors$kotlinx_serialization_core(), inlineClassDescriptor2.getTypeParameterDescriptors$kotlinx_serialization_core()) || inlineClassDescriptor.getElementsCount() != serialDescriptor.getElementsCount()) {
            return false;
        }
        int elementsCount = inlineClassDescriptor.getElementsCount();
        for (int i = 0; i < elementsCount; i++) {
            if (!kotlin.jvm.internal.Intrinsics.areEqual(inlineClassDescriptor.getElementDescriptor(i).getSerialName(), serialDescriptor.getElementDescriptor(i).getSerialName()) || !kotlin.jvm.internal.Intrinsics.areEqual(inlineClassDescriptor.getElementDescriptor(i).getKind(), serialDescriptor.getElementDescriptor(i).getKind())) {
                return false;
            }
        }
        return true;
    }

    public override int HashCode() {
        return super.GetHashCode() * 31;
    }

    public override bool IsInline() {
        return this.isInline;
    }
}

