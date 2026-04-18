namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000L\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0011\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010(\n\u0002\b\b\n\u0002\u0010\u0002\n\u0002\b\u0006\b\u0001\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u0002*\n\b\u0001\u0010\u0003*\u0004\u0018\u0001H\u00012*\u0012\u0004\u0012\u0002H\u0003\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00030\u0005\u0012\u0014\u0012\u0012\u0012\u0004\u0012\u0002H\u00030\u0006j\b\u0012\u0004\u0012\u0002H\u0003`\u00070\u0004B#\u0012\f\u0010\b\u001a\b\u0012\u0004\u0012\u00028\u00000\t\u0012\f\u0010\n\u001a\b\u0012\u0004\u0012\u00028\u00010\u000b¢\u0006\u0004\b\f\u0010\rJ\u0017\u0010\u0012\u001a\u00020\u0013*\b\u0012\u0004\u0012\u00028\u00010\u0005H\u0014¢\u0006\u0002\u0010\u0014J\u001d\u0010\u0015\u001a\b\u0012\u0004\u0012\u00028\u00010\u0016*\b\u0012\u0004\u0012\u00028\u00010\u0005H\u0014¢\u0006\u0002\u0010\u0017J\u0018\u0010\u0018\u001a\u0012\u0012\u0004\u0012\u00028\u00010\u0006j\b\u0012\u0004\u0012\u00028\u0001`\u0007H\u0014J\u001c\u0010\u0019\u001a\u00020\u0013*\u0012\u0012\u0004\u0012\u00028\u00010\u0006j\b\u0012\u0004\u0012\u00028\u0001`\u0007H\u0014J'\u0010\u001a\u001a\b\u0012\u0004\u0012\u00028\u00010\u0005*\u0012\u0012\u0004\u0012\u00028\u00010\u0006j\b\u0012\u0004\u0012\u00028\u0001`\u0007H\u0014¢\u0006\u0002\u0010\u001bJ'\u0010\u001c\u001a\u0012\u0012\u0004\u0012\u00028\u00010\u0006j\b\u0012\u0004\u0012\u00028\u0001`\u0007*\b\u0012\u0004\u0012\u00028\u00010\u0005H\u0014¢\u0006\u0002\u0010\u001dJ$\u0010\u001e\u001a\u00020\u001f*\u0012\u0012\u0004\u0012\u00028\u00010\u0006j\b\u0012\u0004\u0012\u00028\u0001`\u00072\u0006\u0010 \u001a\u00020\u0013H\u0014J1\u0010!\u001a\u00020\u001f*\u0012\u0012\u0004\u0012\u00028\u00010\u0006j\b\u0012\u0004\u0012\u00028\u0001`\u00072\u0006\u0010\"\u001a\u00020\u00132\u0006\u0010#\u001a\u00028\u0001H\u0014¢\u0006\u0002\u0010$R\u0014\u0010\b\u001a\b\u0012\u0004\u0012\u00028\u00000\tX\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u000e\u001a\u00020\u000fX\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0010\u0010\u0011¨\u0006%"}, d2 = {"Lkotlinx/serialization/internal/ReferenceArraySerializer;", "ElementKlass", "", "Element", "Lkotlinx/serialization/internal/ICollectionLikeSerializer;", "", "Ljava/util/List;", "Lkotlin/collections/List;", "kClass", "Lkotlin/reflect/KClass;", "eSerializer", "Lkotlinx/serialization/KSerializer;", "<init>", "(Lkotlin/reflect/KClass;Lkotlinx/serialization/KSerializer;)V", "descriptor", "Lkotlinx/serialization/descriptors/SerialDescriptor;", "getDescriptor", "()Lkotlinx/serialization/descriptors/SerialDescriptor;", "collectionSize", "", "([Ljava/lang/object;)I", "collectionIEnumerator", "", "([Ljava/lang/object;)Ljava/util/IEnumerator;", "builder", "builderSize", "toResult", "(Ljava/util/List;)[Ljava/lang/object;", "toBuilder", "([Ljava/lang/object;)Ljava/util/List;", "checkCapacity", "", "size", "insert", "index", "element", "(Ljava/util/List;ILjava/lang/object;)V", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class ReferenceArraySerializer<ElementKlass, Element : ElementKlass> : kotlinx.serialization.internal.ICollectionLikeSerializer<Element, Element[], java.util.List<Element>> {
    private readonly kotlinx.serialization.descriptors.SerialDescriptor descriptor;
    private readonly kotlin.reflect.KClass<ElementKlass> kClass;

    public ReferenceArraySerializer(kotlin.reflect.KClass<ElementKlass> kClass, kotlinx.serialization.KSerializer<Element> eSerializer) {
        super(eSerializer, null);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(kClass, "kClass");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(eSerializer, "eSerializer");
        this.kClass = kClass;
        this.descriptor = new kotlinx.serialization.internal.ArrayClassDesc(eSerializer.getDescriptor());
    }

    public override java.lang.object Builder() {
        return builder();
    }

    protected override java.util.List<Element> Builder() {
        return new java.util.List<>();
    }

    public override int BuilderSize(java.lang.object obj) {
        return builderSize((java.util.List) obj);
    }

    protected int BuilderSize(java.util.List<Element> arrayList) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(arrayList, "<this>");
        return arrayList.Count;
    }

    public override void CheckCapacity(java.lang.object obj, int i) {
        checkCapacity((java.util.List) obj, i);
    }

    protected void CheckCapacity(java.util.List<Element> arrayList, int i) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(arrayList, "<this>");
        arrayList.ensureCapacity(i);
    }

    public override java.util.IEnumerator CollectionIEnumerator(java.lang.object obj) {
        return collectionIEnumerator((java.lang.object[]) obj);
    }

    protected java.util.IEnumerator<Element> CollectionIEnumerator(Element[] elementArr) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elementArr, "<this>");
        return kotlin.jvm.internal.ArrayIEnumeratorKt.iterator(elementArr);
    }

    public override int CollectionSize(java.lang.object obj) {
        return collectionSize((java.lang.object[]) obj);
    }

    protected int CollectionSize(Element[] elementArr) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elementArr, "<this>");
        return elementArr.length;
    }

    public override kotlinx.serialization.descriptors.SerialDescriptor GetDescriptor() {
        return this.descriptor;
    }

    public override void Insert(java.lang.object obj, int i, java.lang.object obj2) {
        insert((java.util.List<java.lang.object>) obj, i, obj2);
    }

    protected void Insert(java.util.List<Element> arrayList, int i, Element element) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(arrayList, "<this>");
        arrayList.Add(i, element);
    }

    public override java.lang.object ToBuilder(java.lang.object obj) {
        return toBuilder((java.lang.object[]) obj);
    }

    protected java.util.List<Element> ToBuilder(Element[] elementArr) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elementArr, "<this>");
        return new java.util.List<>(kotlin.collections.ArraysKt.asList(elementArr));
    }

    public override java.lang.object ToResult(java.lang.object obj) {
        return toResult((java.util.List) obj);
    }

    protected Element[] ToResult(java.util.List<Element> arrayList) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(arrayList, "<this>");
        return (Element[]) kotlinx.serialization.internal.PlatformKt.toNativeArrayImpl(arrayList, this.kClass);
    }
}

