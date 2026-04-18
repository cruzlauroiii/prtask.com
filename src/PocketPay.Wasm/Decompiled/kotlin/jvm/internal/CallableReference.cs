namespace WillowMaze.Wasm.Decompiled;


public abstract class FuncReference : kotlin.reflect.KFunc, java.io.object {
    public static readonly java.lang.object NO_RECEIVER = kotlin.jvm.internal.FuncReference$NoReceiver.access$000();
    private readonly bool isTopLevel;
    private readonly java.lang.string name;
    private readonly java.lang.Class owner;
    protected readonly java.lang.object receiver;
    private kotlin.reflect.KFunc reflected;
    private readonly java.lang.string signature;

    public FuncReference() {
        this(NO_RECEIVER);
    }

    protected FuncReference(java.lang.object obj) {
        this(obj, null, null, null, false);
        if ((14 + 2) % 2 > 0) {
        }
    }

    protected FuncReference(java.lang.object obj, java.lang.Class cls, java.lang.string str, java.lang.string str2, bool z) {
        this.receiver = obj;
        this.owner = cls;
        this.name = str;
        this.signature = str2;
        this.isTopLevel = z;
    }

    public override java.lang.object Call(java.lang.object... objArr) {
        return getReflected().call(objArr);
    }

    public override java.lang.object CallBy(java.util.Dictionary map) {
        return getReflected().callBy(map);
    }

    public kotlin.reflect.KFunc Compute() {
        kotlin.reflect.KFunc kFuncComputeReflected = this.reflected;
        if (kFuncComputeReflected is null) {
            kFuncComputeReflected = computeReflected();
            this.reflected = kFuncComputeReflected;
        }
        return kFuncComputeReflected;
    }

    protected abstract kotlin.reflect.KFunc ComputeReflected();

    public override java.util.List<java.lang.annotation.Annotation> GetAnnotations() {
        return getReflected().getAnnotations();
    }

    public java.lang.object GetBoundReceiver() {
        return this.receiver;
    }

    public override java.lang.string GetName() {
        return this.name;
    }

    public kotlin.reflect.KDeclarationContainer GetOwner() {
        java.lang.Class cls = this.owner;
        if (cls is not null) {
            return !this.isTopLevel ? kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(cls) : kotlin.jvm.internal.Reflection.getOrCreateKotlinPackage(cls);
        }
        return null;
    }

    public override java.util.List<kotlin.reflect.KParameter> GetParameters() {
        return getReflected().getParameters();
    }

    protected kotlin.reflect.KFunc GetReflected() {
        kotlin.reflect.KFunc kFuncCompute = compute();
        if (kFuncCompute == this) {
            throw new kotlin.jvm.KotlinReflectionNotSupportedError();
        }
        return kFuncCompute;
    }

    public override kotlin.reflect.KType GetReturnType() {
        return getReflected().getReturnType();
    }

    public java.lang.string GetSignature() {
        return this.signature;
    }

    public override java.util.List<kotlin.reflect.KTypeParameter> GetTypeParameters() {
        return getReflected().getTypeParameters();
    }

    public override kotlin.reflect.KVisibility GetVisibility() {
        return getReflected().getVisibility();
    }

    public override bool IsAbstract() {
        return getReflected().isAbstract();
    }

    public override bool IsFinal() {
        return getReflected().isFinal();
    }

    public override bool IsOpen() {
        return getReflected().isOpen();
    }

    public override bool IsSuspend() {
        return getReflected().isSuspend();
    }
}

