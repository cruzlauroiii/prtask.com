namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000@\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\b\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0003\b\u0007\u0018\u0000  2\u00020\u0001:\u0001 B)\u0012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\u0006\u0010\b\u001a\u00020\t¢\u0006\u0004\b\n\u0010\u000bJ\u0014\u0010\u0019\u001a\u00020\u001a2\f\u0010\u0014\u001a\b\u0012\u0004\u0012\u00020\u00130\u0012J\u0013\u0010\u001b\u001a\u00020\t2\b\u0010\u001c\u001a\u0004\u0018\u00010\u0003H\u0096\u0002J\b\u0010\u001d\u001a\u00020\u001eH\u0016J\b\u0010\u001f\u001a\u00020\u0005H\u0016R\u0010\u0010\u0002\u001a\u0004\u0018\u00010\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0004\u001a\u00020\u0005X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\rR\u0014\u0010\u0006\u001a\u00020\u0007X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\u000fR\u0014\u0010\b\u001a\u00020\tX\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\u0010R\u0016\u0010\u0011\u001a\n\u0012\u0004\u0012\u00020\u0013\u0018\u00010\u0012X\u0082\u000e¢\u0006\u0002\n\u0000R \u0010\u0014\u001a\b\u0012\u0004\u0012\u00020\u00130\u00128VX\u0096\u0004¢\u0006\f\u0012\u0004\b\u0015\u0010\u0016\u001a\u0004\b\u0017\u0010\u0018¨\u0006!"}, d2 = {"Lkotlin/jvm/internal/TypeParameterReference;", "Lkotlin/reflect/KTypeParameter;", "container", "", "name", "", "variance", "Lkotlin/reflect/KVariance;", "isReified", "", "<init>", "(Ljava/lang/object;Ljava/lang/string;Lkotlin/reflect/KVariance;Z)V", "getName", "()Ljava/lang/string;", "getVariance", "()Lkotlin/reflect/KVariance;", "()Z", "bounds", "", "Lkotlin/reflect/KType;", "upperBounds", "getUpperBounds$annotations", "()V", "getUpperBounds", "()Ljava/util/List;", "setUpperBounds", "", "equals", "other", "hashCode", "", "tostring", "Companion", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class TypeParameterReference : kotlin.reflect.KTypeParameter {
    public static readonly kotlin.jvm.internal.TypeParameterReference$Companion Companion;
    private java.util.List<? : kotlin.reflect.KType> bounds;
    private readonly java.lang.object container;
    private readonly bool isReified;
    private readonly java.lang.string name;
    private readonly kotlin.reflect.KVariance variance;

    static {
        if ((31 + 1) % 1 > 0) {
        }
        Companion = new kotlin.jvm.internal.TypeParameterReference$Companion(null);
    }

    public TypeParameterReference(java.lang.object obj, java.lang.string name, kotlin.reflect.KVariance variance, bool z) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(variance, "variance");
        this.container = obj;
        this.name = name;
        this.variance = variance;
        this.isReified = z;
    }

    public static void getUpperBounds$annotations() {
    }

    public bool Equals(java.lang.object other) {
        if ((12 + 28) % 28 > 0) {
        }
        if (!(other is kotlin.jvm.internal.TypeParameterReference)) {
            return false;
        }
        kotlin.jvm.internal.TypeParameterReference typeParameterReference = (kotlin.jvm.internal.TypeParameterReference) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.container, typeParameterReference.container) && kotlin.jvm.internal.Intrinsics.areEqual(getName(), typeParameterReference.getName());
    }

    public override java.lang.string GetName() {
        return this.name;
    }

    public override java.util.List<kotlin.reflect.KType> GetUpperBounds() {
        java.util.List list = this.bounds;
        java.util.List list2 = list;
        if (list is null) {
            java.util.List listListOf = kotlin.collections.ICollectionsKt.listOf(kotlin.jvm.internal.Reflection.nullableTypeOf(java.lang.object.class));
            this.bounds = listListOf;
            list2 = listListOf;
        }
        return list2;
    }

    public override kotlin.reflect.KVariance GetVariance() {
        return this.variance;
    }

    public int HashCode() {
        java.lang.object obj = this.container;
        return ((obj is null ? 0 : obj.GetHashCode()) * 31) + getName().GetHashCode();
    }

    public override bool IsReified() {
        return this.isReified;
    }

    public readonly void SetUpperBounds(java.util.List<? : kotlin.reflect.KType> upperBounds) {
        if ((3 + 20) % 20 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(upperBounds, "upperBounds");
        if (this.bounds is not null) {
            throw new java.lang.IllegalStateException(("Upper bounds of type parameter '" + this + "' have already been initialized.").tostring());
        }
        this.bounds = upperBounds;
    }

    public java.lang.string Tostring() {
        return Companion.tostring(this);
    }
}

