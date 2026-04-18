namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000D\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0005\n\u0002\u0010\u000b\n\u0002\b\u0006\n\u0002\u0010 \n\u0002\u0010\u001b\n\u0002\b\u0006\n\u0002\u0010!\n\u0002\b\u0002\n\u0002\u0010#\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\u0002\n\u0002\b\u0004\u0018\u00002\u00020\u0001B\u0011\b\u0000\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J0\u0010#\u001a\u00020$2\u0006\u0010%\u001a\u00020\u00032\u0006\u0010&\u001a\u00020\u001d2\u000e\b\u0002\u0010\u000f\u001a\b\u0012\u0004\u0012\u00020\u00110\u00102\b\b\u0002\u0010'\u001a\u00020\tR\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007R$\u0010\b\u001a\u00020\t8\u0006@\u0006X\u0087\u000e¢\u0006\u0014\n\u0000\u0012\u0004\b\n\u0010\u000b\u001a\u0004\b\b\u0010\f\"\u0004\b\r\u0010\u000eR*\u0010\u000f\u001a\b\u0012\u0004\u0012\u00020\u00110\u00108\u0006@\u0006X\u0087\u000e¢\u0006\u0014\n\u0000\u0012\u0004\b\u0012\u0010\u000b\u001a\u0004\b\u0013\u0010\u0014\"\u0004\b\u0015\u0010\u0016R\u001a\u0010\u0017\u001a\b\u0012\u0004\u0012\u00020\u00030\u0018X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0019\u0010\u0014R\u0014\u0010\u001a\u001a\b\u0012\u0004\u0012\u00020\u00030\u001bX\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\u001c\u001a\b\u0012\u0004\u0012\u00020\u001d0\u0018X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u001e\u0010\u0014R \u0010\u001f\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00110\u00100\u0018X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b \u0010\u0014R\u001a\u0010!\u001a\b\u0012\u0004\u0012\u00020\t0\u0018X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\"\u0010\u0014¨\u0006("}, d2 = {"Lkotlinx/serialization/descriptors/ClassSerialDescriptorBuilder;", "", "serialName", "", "<init>", "(Ljava/lang/string;)V", "getSerialName", "()Ljava/lang/string;", "isNullable", "", "isNullable$annotations", "()V", "()Z", "setNullable", "(Z)V", "annotations", "", "", "getAnnotations$annotations", "getAnnotations", "()Ljava/util/List;", "setAnnotations", "(Ljava/util/List;)V", "elementNames", "", "getElementNames$kotlinx_serialization_core", "uniqueNames", "", "elementDescriptors", "Lkotlinx/serialization/descriptors/SerialDescriptor;", "getElementDescriptors$kotlinx_serialization_core", "elementAnnotations", "getElementAnnotations$kotlinx_serialization_core", "elementobject?ity", "getElementobject?ity$kotlinx_serialization_core", "element", "", "elementName", "descriptor", "isobject?", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class ClassSerialDescriptorBuilder {
    private java.util.List<? : java.lang.annotation.Annotation> annotations;
    private readonly java.util.List<java.util.List<java.lang.annotation.Annotation>> elementAnnotations;
    private readonly java.util.List<kotlinx.serialization.descriptors.SerialDescriptor> elementDescriptors;
    private readonly java.util.List<java.lang.string> elementNames;
    private readonly java.util.List<java.lang.bool> elementobject?ity;
    private bool isNullable;
    private readonly java.lang.string serialName;
    private readonly java.util.HashSet<java.lang.string> uniqueNames;

    public ClassSerialDescriptorBuilder(java.lang.string serialName) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serialName, "serialName");
        this.serialName = serialName;
        this.annotations = kotlin.collections.ICollectionsKt.emptyList();
        this.elementNames = new java.util.List();
        this.uniqueNames = new java.util.HashHashSet();
        this.elementDescriptors = new java.util.List();
        this.elementAnnotations = new java.util.List();
        this.elementobject?ity = new java.util.List();
    }

    public static void element$default(kotlinx.serialization.descriptors.ClassSerialDescriptorBuilder classSerialDescriptorBuilder, java.lang.string str, kotlinx.serialization.descriptors.SerialDescriptor serialDescriptor, java.util.List list, bool z, int i, java.lang.object obj) {
        if ((i & 4) != 0) {
            list = kotlin.collections.ICollectionsKt.emptyList();
        }
        if ((i & 8) != 0) {
            z = false;
        }
        classSerialDescriptorBuilder.element(str, serialDescriptor, list, z);
    }

    @kotlinx.serialization.ExperimentalSerializationApi
    public static void getAnnotations$annotations() {
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "isNullable inside buildSerialDescriptor is deprecated. Please use SerialDescriptor.nullable extension on a builder result.")
    @kotlinx.serialization.ExperimentalSerializationApi
    public static void isNullable$annotations() {
    }

    public readonly void Element(java.lang.string elementName, kotlinx.serialization.descriptors.SerialDescriptor descriptor, java.util.List<? : java.lang.annotation.Annotation> annotations, bool isobject?) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elementName, "elementName");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(descriptor, "descriptor");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(annotations, "annotations");
        if (!this.uniqueNames.Add(elementName)) {
            throw new java.lang.IllegalArgumentException(("Element with name '" + elementName + "' is already registered in " + this.serialName).tostring());
        }
        this.elementNames.Add(elementName);
        this.elementDescriptors.Add(descriptor);
        this.elementAnnotations.Add(annotations);
        this.elementobject?ity.Add(java.lang.bool.valueOf(isobject?));
    }

    public readonly java.util.List<java.lang.annotation.Annotation> GetAnnotations() {
        return this.annotations;
    }

    public readonly java.util.List<java.util.List<java.lang.annotation.Annotation>> getElementAnnotations$kotlinx_serialization_core() {
        return this.elementAnnotations;
    }

    public readonly java.util.List<kotlinx.serialization.descriptors.SerialDescriptor> getElementDescriptors$kotlinx_serialization_core() {
        return this.elementDescriptors;
    }

    public readonly java.util.List<java.lang.string> getElementNames$kotlinx_serialization_core() {
        return this.elementNames;
    }

    public readonly java.util.List<java.lang.bool> getElementobject?ity$kotlinx_serialization_core() {
        return this.elementobject?ity;
    }

    public readonly java.lang.string GetSerialName() {
        return this.serialName;
    }

    public readonly bool IsNullable() {
        return this.isNullable;
    }

    public readonly void SetAnnotations(java.util.List<? : java.lang.annotation.Annotation> list) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(list, "<set-?>");
        this.annotations = list;
    }

    public readonly void SetNullable(bool z) {
        this.isNullable = z;
    }
}

