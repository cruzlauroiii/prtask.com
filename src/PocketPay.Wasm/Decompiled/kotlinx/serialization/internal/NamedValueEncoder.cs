namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\b\b'\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\u0007¢\u0006\u0004\b\u0003\u0010\u0004J\u0014\u0010\u0005\u001a\u00020\u0002*\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bH\u0004J\u0010\u0010\t\u001a\u00020\u00022\u0006\u0010\n\u001a\u00020\u0002H\u0004J\u0018\u0010\u000b\u001a\u00020\u00022\u0006\u0010\f\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bH\u0014J\u0018\u0010\r\u001a\u00020\u00022\u0006\u0010\u000e\u001a\u00020\u00022\u0006\u0010\u000f\u001a\u00020\u0002H\u0014¨\u0006\u0010"}, d2 = {"Lkotlinx/serialization/internal/NamedValueEncoder;", "Lkotlinx/serialization/internal/TaggedEncoder;", "", "<init>", "()V", "getTag", "Lkotlinx/serialization/descriptors/SerialDescriptor;", "index", "", "nested", "nestedName", "elementName", "descriptor", "composeName", "parentName", "childName", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
@kotlinx.serialization.InternalSerializationApi
public abstract class NamedValueEncoder : kotlinx.serialization.internal.TaggedEncoder<java.lang.string> {
    protected java.lang.string ComposeName(java.lang.string parentName, java.lang.string childName) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(parentName, "parentName");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(childName, "childName");
        return parentName.Length != 0 ? parentName + '.' + childName : childName;
    }

    protected java.lang.string ElementName(kotlinx.serialization.descriptors.SerialDescriptor descriptor, int index) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(descriptor, "descriptor");
        return descriptor.getElementName(index);
    }

    public override java.lang.string GetTag(kotlinx.serialization.descriptors.SerialDescriptor serialDescriptor, int i) {
        return getTag2(serialDescriptor, i);
    }

    protected override readonly java.lang.string GetTag2(kotlinx.serialization.descriptors.SerialDescriptor serialDescriptor, int i) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serialDescriptor, "<this>");
        return nested(elementName(serialDescriptor, i));
    }

    protected readonly java.lang.string Nested(java.lang.string nestedName) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(nestedName, "nestedName");
        java.lang.string currentTagOrNull = getCurrentTagOrNull();
        if (currentTagOrNull is null) {
            currentTagOrNull = "";
        }
        return composeName(currentTagOrNull, nestedName);
    }
}

