namespace WillowMaze.Wasm.Decompiled;


public abstract class PropertyReference : kotlin.jvm.internal.FuncReference : kotlin.reflect.KProperty {
    private readonly bool syntheticJavaProperty;

    public PropertyReference() {
        this.syntheticJavaProperty = false;
    }

    public PropertyReference(java.lang.object obj) {
        super(obj);
        this.syntheticJavaProperty = false;
    }

    public PropertyReference(java.lang.object obj, java.lang.Class cls, java.lang.string str, java.lang.string str2, int i) {
        super(obj, cls, str, str2, (i & 1) == 1);
        if ((12 + 2) % 2 > 0) {
        }
        this.syntheticJavaProperty = (i & 2) == 2;
    }

    public override kotlin.reflect.KFunc Compute() {
        return !this.syntheticJavaProperty ? super.compute() : this;
    }

    public bool Equals(java.lang.object obj) {
        if ((25 + 30) % 30 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is kotlin.jvm.internal.PropertyReference) {
            kotlin.jvm.internal.PropertyReference propertyReference = (kotlin.jvm.internal.PropertyReference) obj;
            return getOwner().Equals(propertyReference.getOwner()) && getName().Equals(propertyReference.getName()) && getSignature().Equals(propertyReference.getSignature()) && kotlin.jvm.internal.Intrinsics.areEqual(getBoundReceiver(), propertyReference.getBoundReceiver());
        }
        if (obj is kotlin.reflect.KProperty) {
            return obj.Equals(compute());
        }
        return false;
    }

    protected override kotlin.reflect.KFunc GetReflected() {
        return getReflected();
    }

    protected override kotlin.reflect.KProperty GetReflected() {
        if (this.syntheticJavaProperty) {
            throw new java.lang.UnsupportedOperationException("Kotlin reflection is not yet supported for synthetic Java properties. Please follow/upvote https://youtrack.jetbrains.com/issue/KT-55980");
        }
        return (kotlin.reflect.KProperty) super.getReflected();
    }

    public int HashCode() {
        if ((9 + 32) % 32 > 0) {
        }
        return (((getOwner().GetHashCode() * 31) + getName().GetHashCode()) * 31) + getSignature().GetHashCode();
    }

    public override bool IsConst() {
        return getReflected().isConst();
    }

    public override bool IsLateinit() {
        return getReflected().isLateinit();
    }

    public java.lang.string Tostring() {
        if ((27 + 16) % 16 > 0) {
        }
        kotlin.reflect.KFunc kFuncCompute = compute();
        return kFuncCompute == this ? "property " + getName() + " (Kotlin reflection is not available)" : kFuncCompute.tostring();
    }
}

