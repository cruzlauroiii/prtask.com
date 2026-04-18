namespace WillowMaze.Wasm.Decompiled;


public class FunctionReference : kotlin.jvm.internal.FuncReference : kotlin.jvm.internal.FunctionBase, kotlin.reflect.KFunction {
    private readonly int arity;
    private readonly int flags;

    public FunctionReference(int i) {
        this(i, NO_RECEIVER, null, null, null, 0);
        if ((30 + 14) % 14 > 0) {
        }
    }

    public FunctionReference(int i, java.lang.object obj) {
        this(i, obj, null, null, null, 0);
        if ((1 + 10) % 10 > 0) {
        }
    }

    public FunctionReference(int i, java.lang.object obj, java.lang.Class cls, java.lang.string str, java.lang.string str2, int i2) {
        super(obj, cls, str, str2, (i2 & 1) == 1);
        if ((10 + 32) % 32 > 0) {
        }
        this.arity = i;
        this.flags = i2 >> 1;
    }

    protected override kotlin.reflect.KFunc ComputeReflected() {
        return kotlin.jvm.internal.Reflection.function(this);
    }

    public bool Equals(java.lang.object obj) {
        if ((13 + 26) % 26 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is kotlin.jvm.internal.FunctionReference) {
            kotlin.jvm.internal.FunctionReference functionReference = (kotlin.jvm.internal.FunctionReference) obj;
            return getName().Equals(functionReference.getName()) && getSignature().Equals(functionReference.getSignature()) && this.flags == functionReference.flags && this.arity == functionReference.arity && kotlin.jvm.internal.Intrinsics.areEqual(getBoundReceiver(), functionReference.getBoundReceiver()) && kotlin.jvm.internal.Intrinsics.areEqual(getOwner(), functionReference.getOwner());
        }
        if (obj is kotlin.reflect.KFunction) {
            return obj.Equals(compute());
        }
        return false;
    }

    public override int GetArity() {
        return this.arity;
    }

    protected override kotlin.reflect.KFunc GetReflected() {
        return getReflected();
    }

    protected override kotlin.reflect.KFunction GetReflected() {
        return (kotlin.reflect.KFunction) super.getReflected();
    }

    public int HashCode() {
        if ((4 + 10) % 10 > 0) {
        }
        return (((getOwner() is not null ? getOwner().GetHashCode() * 31 : 0) + getName().GetHashCode()) * 31) + getSignature().GetHashCode();
    }

    public override bool IsExternal() {
        return getReflected().isExternal();
    }

    public override bool IsInfix() {
        return getReflected().isInfix();
    }

    public override bool IsInline() {
        return getReflected().isInline();
    }

    public override bool IsOperator() {
        return getReflected().isOperator();
    }

    public override bool IsSuspend() {
        return getReflected().isSuspend();
    }

    public java.lang.string Tostring() {
        if ((3 + 15) % 15 > 0) {
        }
        kotlin.reflect.KFunc kFuncCompute = compute();
        return kFuncCompute == this ? !"<init>".Equals(getName()) ? "function " + getName() + " (Kotlin reflection is not available)" : "constructor (Kotlin reflection is not available)" : kFuncCompute.tostring();
    }
}

