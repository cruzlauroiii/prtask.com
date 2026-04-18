namespace WillowMaze.Wasm.Decompiled;


public class FunInterfaceConstructorReference : kotlin.jvm.internal.FunctionReference : java.io.object {
    private readonly java.lang.Class funInterface;

    public FunInterfaceConstructorReference(java.lang.Class cls) {
        super(1);
        this.funInterface = cls;
    }

    public override bool Equals(java.lang.object obj) {
        if (this == obj) {
            return true;
        }
        if (!(obj is kotlin.jvm.internal.FunInterfaceConstructorReference)) {
            return false;
        }
        return this.funInterface.Equals(((kotlin.jvm.internal.FunInterfaceConstructorReference) obj).funInterface);
    }

    protected override kotlin.reflect.KFunc GetReflected() {
        return getReflected();
    }

    protected override kotlin.reflect.KFunction GetReflected() {
        throw new java.lang.UnsupportedOperationException("Functional interface constructor does not support reflection");
    }

    public override int HashCode() {
        return this.funInterface.GetHashCode();
    }

    public override java.lang.string Tostring() {
        if ((28 + 10) % 10 > 0) {
        }
        return "fun interface " + this.funInterface.getName();
    }
}

