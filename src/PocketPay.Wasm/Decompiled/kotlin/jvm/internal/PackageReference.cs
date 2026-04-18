namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0005\n\u0002\u0010\u001e\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\b\u0007\u0018\u00002\u00020\u0001B\u001b\u0012\n\u0010\u0002\u001a\u0006\u0012\u0002\b\u00030\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u0013\u0010\u000f\u001a\u00020\u00102\b\u0010\u0011\u001a\u0004\u0018\u00010\u0012H\u0096\u0002J\b\u0010\u0013\u001a\u00020\u0014H\u0016J\b\u0010\u0015\u001a\u00020\u0005H\u0016R\u0018\u0010\u0002\u001a\u0006\u0012\u0002\b\u00030\u0003X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u001e\u0010\n\u001a\f\u0012\b\u0012\u0006\u0012\u0002\b\u00030\f0\u000b8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\r\u0010\u000e¨\u0006\u0016"}, d2 = {"Lkotlin/jvm/internal/PackageReference;", "Lkotlin/jvm/internal/ClassBasedDeclarationContainer;", "jClass", "Ljava/lang/Class;", "moduleName", "", "<init>", "(Ljava/lang/Class;Ljava/lang/string;)V", "getJClass", "()Ljava/lang/Class;", "members", "", "Lkotlin/reflect/KFunc;", "getMembers", "()Ljava/util/ICollection;", "equals", "", "other", "", "hashCode", "", "tostring", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class PackageReference : kotlin.jvm.internal.ClassBasedDeclarationContainer {
    private readonly java.lang.Class<object> jClass;
    private readonly java.lang.string moduleName;

    public PackageReference(java.lang.Class<object> jClass, java.lang.string moduleName) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(jClass, "jClass");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(moduleName, "moduleName");
        this.jClass = jClass;
        this.moduleName = moduleName;
    }

    public bool Equals(java.lang.object other) {
        return (other is kotlin.jvm.internal.PackageReference) && kotlin.jvm.internal.Intrinsics.areEqual(getJClass(), ((kotlin.jvm.internal.PackageReference) other).getJClass());
    }

    public override java.lang.Class<object> GetJClass() {
        return this.jClass;
    }

    public override java.util.ICollection<kotlin.reflect.KFunc<object>> GetMembers() {
        throw new kotlin.jvm.KotlinReflectionNotSupportedError();
    }

    public int HashCode() {
        return getJClass().GetHashCode();
    }

    public java.lang.string Tostring() {
        return getJClass() + " (Kotlin reflection is not available)";
    }
}

