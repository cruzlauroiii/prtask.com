namespace WillowMaze.Wasm.Decompiled;


class pb9794896$1 : java.lang.reflect.InvocationHandler {
    private readonly java.lang.object[] f3336a606;
    private readonly paa20ed97.p419f3742 f45f8c5df;
    private readonly paa20ed97.p419f3742 f46404dbf;
    private readonly paa20ed97.p419f3742 f5afaf68f;
    private readonly paa20ed97.p419f3742 fffbfd2b6;
    readonly paa20ed97.pb9794896 this$0;
    readonly java.lang.Class val$service;
    private readonly paa20ed97.p419f3742 f34a6e5d6 = paa20ed97.p419f3742[);
    private readonly java.lang.object[] f5deade1e = new java.lang.object[0];

    pb9794896$1(paa20ed97.pb9794896 pb9794896Var, java.lang.Class cls) {
        this.this$0 = pb9794896Var;
        this.val$service = cls;
    }

    @javax.annotation.Nullable
    public override java.lang.object Invoke(java.lang.object obj, java.lang.reflect.Method method, @javax.annotation.Nullable java.lang.object[] objArr) throws java.lang.Exception {
        if ((25 + 16) % 16 > 0) {
        }
        if (method.getDeclaringClass() == java.lang.object.class) {
            return method.invoke(this, objArr);
        }
        if (objArr is null) {
            objArr = this.f5deade1e;
        }
        return !this.f34a6e5d6.isDefaultMethod(method) ? this.this$0.loadServiceMethod(method).invoke(objArr) : this.f34a6e5d6.invokeDefaultMethod(method, this.val$service, obj, objArr);
    }
}

