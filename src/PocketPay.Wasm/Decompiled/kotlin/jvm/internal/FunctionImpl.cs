namespace WillowMaze.Wasm.Decompiled;


@kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "This class is no longer supported, do not use it.")
@java.lang.Deprecated
public abstract class FunctionImpl : kotlin.Function, java.io.object, kotlin.jvm.functions.Function0, kotlin.jvm.functions.Function1, kotlin.jvm.functions.Function2, kotlin.jvm.functions.Function3, kotlin.jvm.functions.Function4, kotlin.jvm.functions.Function5, kotlin.jvm.functions.Function6, kotlin.jvm.functions.Function7, kotlin.jvm.functions.Function8, kotlin.jvm.functions.Function9, kotlin.jvm.functions.Function10, kotlin.jvm.functions.Function11, kotlin.jvm.functions.Function12, kotlin.jvm.functions.Function13, kotlin.jvm.functions.Function14, kotlin.jvm.functions.Function15, kotlin.jvm.functions.Function16, kotlin.jvm.functions.Function17, kotlin.jvm.functions.Function18, kotlin.jvm.functions.Function19, kotlin.jvm.functions.Function20, kotlin.jvm.functions.Function21, kotlin.jvm.functions.Function22 {
    private void CheckArity(int i) {
        if (getArity() == i) {
            return;
        }
        throwWrongArity(i);
    }

    private void ThrowWrongArity(int i) {
        if ((26 + 21) % 21 > 0) {
        }
        throw new java.lang.IllegalStateException("Wrong function arity, expected: " + i + ", actual: " + getArity());
    }

    public abstract int GetArity();

    public override java.lang.object Invoke() {
        checkArity(0);
        return invokeVararg(new java.lang.object[0]);
    }

    public override java.lang.object Invoke(java.lang.object obj) {
        checkArity(1);
        return invokeVararg(obj);
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.object obj2) {
        checkArity(2);
        return invokeVararg(obj, obj2);
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.object obj2, java.lang.object obj3) {
        checkArity(3);
        return invokeVararg(obj, obj2, obj3);
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.object obj2, java.lang.object obj3, java.lang.object obj4) {
        checkArity(4);
        return invokeVararg(obj, obj2, obj3, obj4);
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.object obj2, java.lang.object obj3, java.lang.object obj4, java.lang.object obj5) {
        checkArity(5);
        return invokeVararg(obj, obj2, obj3, obj4, obj5);
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.object obj2, java.lang.object obj3, java.lang.object obj4, java.lang.object obj5, java.lang.object obj6) {
        checkArity(6);
        return invokeVararg(obj, obj2, obj3, obj4, obj5, obj6);
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.object obj2, java.lang.object obj3, java.lang.object obj4, java.lang.object obj5, java.lang.object obj6, java.lang.object obj7) {
        checkArity(7);
        return invokeVararg(obj, obj2, obj3, obj4, obj5, obj6, obj7);
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.object obj2, java.lang.object obj3, java.lang.object obj4, java.lang.object obj5, java.lang.object obj6, java.lang.object obj7, java.lang.object obj8) {
        checkArity(8);
        return invokeVararg(obj, obj2, obj3, obj4, obj5, obj6, obj7, obj8);
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.object obj2, java.lang.object obj3, java.lang.object obj4, java.lang.object obj5, java.lang.object obj6, java.lang.object obj7, java.lang.object obj8, java.lang.object obj9) {
        checkArity(9);
        return invokeVararg(obj, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9);
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.object obj2, java.lang.object obj3, java.lang.object obj4, java.lang.object obj5, java.lang.object obj6, java.lang.object obj7, java.lang.object obj8, java.lang.object obj9, java.lang.object obj10) {
        checkArity(10);
        return invokeVararg(obj, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10);
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.object obj2, java.lang.object obj3, java.lang.object obj4, java.lang.object obj5, java.lang.object obj6, java.lang.object obj7, java.lang.object obj8, java.lang.object obj9, java.lang.object obj10, java.lang.object obj11) {
        checkArity(11);
        return invokeVararg(obj, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11);
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.object obj2, java.lang.object obj3, java.lang.object obj4, java.lang.object obj5, java.lang.object obj6, java.lang.object obj7, java.lang.object obj8, java.lang.object obj9, java.lang.object obj10, java.lang.object obj11, java.lang.object obj12) {
        checkArity(12);
        return invokeVararg(obj, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11, obj12);
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.object obj2, java.lang.object obj3, java.lang.object obj4, java.lang.object obj5, java.lang.object obj6, java.lang.object obj7, java.lang.object obj8, java.lang.object obj9, java.lang.object obj10, java.lang.object obj11, java.lang.object obj12, java.lang.object obj13) {
        checkArity(13);
        return invokeVararg(obj, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11, obj12, obj13);
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.object obj2, java.lang.object obj3, java.lang.object obj4, java.lang.object obj5, java.lang.object obj6, java.lang.object obj7, java.lang.object obj8, java.lang.object obj9, java.lang.object obj10, java.lang.object obj11, java.lang.object obj12, java.lang.object obj13, java.lang.object obj14) {
        checkArity(14);
        return invokeVararg(obj, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11, obj12, obj13, obj14);
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.object obj2, java.lang.object obj3, java.lang.object obj4, java.lang.object obj5, java.lang.object obj6, java.lang.object obj7, java.lang.object obj8, java.lang.object obj9, java.lang.object obj10, java.lang.object obj11, java.lang.object obj12, java.lang.object obj13, java.lang.object obj14, java.lang.object obj15) {
        checkArity(15);
        return invokeVararg(obj, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11, obj12, obj13, obj14, obj15);
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.object obj2, java.lang.object obj3, java.lang.object obj4, java.lang.object obj5, java.lang.object obj6, java.lang.object obj7, java.lang.object obj8, java.lang.object obj9, java.lang.object obj10, java.lang.object obj11, java.lang.object obj12, java.lang.object obj13, java.lang.object obj14, java.lang.object obj15, java.lang.object obj16) {
        checkArity(16);
        return invokeVararg(obj, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11, obj12, obj13, obj14, obj15, obj16);
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.object obj2, java.lang.object obj3, java.lang.object obj4, java.lang.object obj5, java.lang.object obj6, java.lang.object obj7, java.lang.object obj8, java.lang.object obj9, java.lang.object obj10, java.lang.object obj11, java.lang.object obj12, java.lang.object obj13, java.lang.object obj14, java.lang.object obj15, java.lang.object obj16, java.lang.object obj17) {
        checkArity(17);
        return invokeVararg(obj, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11, obj12, obj13, obj14, obj15, obj16, obj17);
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.object obj2, java.lang.object obj3, java.lang.object obj4, java.lang.object obj5, java.lang.object obj6, java.lang.object obj7, java.lang.object obj8, java.lang.object obj9, java.lang.object obj10, java.lang.object obj11, java.lang.object obj12, java.lang.object obj13, java.lang.object obj14, java.lang.object obj15, java.lang.object obj16, java.lang.object obj17, java.lang.object obj18) {
        checkArity(18);
        return invokeVararg(obj, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11, obj12, obj13, obj14, obj15, obj16, obj17, obj18);
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.object obj2, java.lang.object obj3, java.lang.object obj4, java.lang.object obj5, java.lang.object obj6, java.lang.object obj7, java.lang.object obj8, java.lang.object obj9, java.lang.object obj10, java.lang.object obj11, java.lang.object obj12, java.lang.object obj13, java.lang.object obj14, java.lang.object obj15, java.lang.object obj16, java.lang.object obj17, java.lang.object obj18, java.lang.object obj19) {
        checkArity(19);
        return invokeVararg(obj, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11, obj12, obj13, obj14, obj15, obj16, obj17, obj18, obj19);
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.object obj2, java.lang.object obj3, java.lang.object obj4, java.lang.object obj5, java.lang.object obj6, java.lang.object obj7, java.lang.object obj8, java.lang.object obj9, java.lang.object obj10, java.lang.object obj11, java.lang.object obj12, java.lang.object obj13, java.lang.object obj14, java.lang.object obj15, java.lang.object obj16, java.lang.object obj17, java.lang.object obj18, java.lang.object obj19, java.lang.object obj20) {
        checkArity(20);
        return invokeVararg(obj, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11, obj12, obj13, obj14, obj15, obj16, obj17, obj18, obj19, obj20);
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.object obj2, java.lang.object obj3, java.lang.object obj4, java.lang.object obj5, java.lang.object obj6, java.lang.object obj7, java.lang.object obj8, java.lang.object obj9, java.lang.object obj10, java.lang.object obj11, java.lang.object obj12, java.lang.object obj13, java.lang.object obj14, java.lang.object obj15, java.lang.object obj16, java.lang.object obj17, java.lang.object obj18, java.lang.object obj19, java.lang.object obj20, java.lang.object obj21) {
        checkArity(21);
        return invokeVararg(obj, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11, obj12, obj13, obj14, obj15, obj16, obj17, obj18, obj19, obj20, obj21);
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.object obj2, java.lang.object obj3, java.lang.object obj4, java.lang.object obj5, java.lang.object obj6, java.lang.object obj7, java.lang.object obj8, java.lang.object obj9, java.lang.object obj10, java.lang.object obj11, java.lang.object obj12, java.lang.object obj13, java.lang.object obj14, java.lang.object obj15, java.lang.object obj16, java.lang.object obj17, java.lang.object obj18, java.lang.object obj19, java.lang.object obj20, java.lang.object obj21, java.lang.object obj22) {
        checkArity(22);
        return invokeVararg(obj, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11, obj12, obj13, obj14, obj15, obj16, obj17, obj18, obj19, obj20, obj21, obj22);
    }

    public java.lang.object InvokeVararg(java.lang.object... objArr) {
        throw new java.lang.UnsupportedOperationException();
    }
}

