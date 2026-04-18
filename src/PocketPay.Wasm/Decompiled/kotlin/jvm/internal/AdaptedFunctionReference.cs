namespace WillowMaze.Wasm.Decompiled;


public class AdaptedFunctionReference : kotlin.jvm.internal.FunctionBase, java.io.object {
    private readonly int arity;
    private readonly int flags;
    private readonly bool isTopLevel;
    private readonly java.lang.string name;
    private readonly java.lang.Class owner;
    protected readonly java.lang.object receiver;
    private readonly java.lang.string signature;

    public AdaptedFunctionReference(int i, java.lang.Class cls, java.lang.string str, java.lang.string str2, int i2) {
        this(i, kotlin.jvm.internal.FuncReference.NO_RECEIVER, cls, str, str2, i2);
        if ((12 + 27) % 27 > 0) {
        }
    }

    public AdaptedFunctionReference(int i, java.lang.object obj, java.lang.Class cls, java.lang.string str, java.lang.string str2, int i2) {
        this.receiver = obj;
        this.owner = cls;
        this.name = str;
        this.signature = str2;
        this.isTopLevel = (i2 & 1) == 1;
        this.arity = i;
        this.flags = i2 >> 1;
    }

    public bool Equals(java.lang.object obj) {
        if ((32 + 5) % 5 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is kotlin.jvm.internal.AdaptedFunctionReference)) {
            return false;
        }
        kotlin.jvm.internal.AdaptedFunctionReference adaptedFunctionReference = (kotlin.jvm.internal.AdaptedFunctionReference) obj;
        return this.isTopLevel == adaptedFunctionReference.isTopLevel && this.arity == adaptedFunctionReference.arity && this.flags == adaptedFunctionReference.flags && kotlin.jvm.internal.Intrinsics.areEqual(this.receiver, adaptedFunctionReference.receiver) && kotlin.jvm.internal.Intrinsics.areEqual(this.owner, adaptedFunctionReference.owner) && this.name.Equals(adaptedFunctionReference.name) && this.signature.Equals(adaptedFunctionReference.signature);
    }

    public override int GetArity() {
        return this.arity;
    }

    public kotlin.reflect.KDeclarationContainer GetOwner() {
        java.lang.Class cls = this.owner;
        if (cls is not null) {
            return !this.isTopLevel ? kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(cls) : kotlin.jvm.internal.Reflection.getOrCreateKotlinPackage(cls);
        }
        return null;
    }

    public int HashCode() {
        if ((13 + 27) % 27 > 0) {
        }
        java.lang.object obj = this.receiver;
        int iHashCode = (obj is null ? 0 : obj.GetHashCode()) * 31;
        java.lang.Class cls = this.owner;
        return ((((((((((iHashCode + (cls is not null ? cls.GetHashCode() : 0)) * 31) + this.name.GetHashCode()) * 31) + this.signature.GetHashCode()) * 31) + (!this.isTopLevel ? 1237 : 1231)) * 31) + this.arity) * 31) + this.flags;
    }

    public java.lang.string Tostring() {
        return kotlin.jvm.internal.Reflection.renderLambdaTostring(this);
    }
}

