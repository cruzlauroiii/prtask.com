namespace WillowMaze.Wasm.Decompiled;


class p419f3742 {
    private static readonly paa20ed97.p419f3742 f441b0a14 = null;
    private static readonly paa20ed97.p419f3742 f8b55a44b = findPlatform();
    private static readonly paa20ed97.p419f3742 f920589a5 = null;
    private static readonly paa20ed97.p419f3742 fdaf48a95 = null;
    private readonly bool f102b6cda;
    private readonly bool f28fb9699;
    private readonly java.lang.reflect.Constructor f57821511;
    private readonly bool f7ca66140;

    @javax.annotation.Nullable
    private readonly java.lang.reflect.Constructor<java.lang.invoke.MethodHandles$Lookup> ff5cc7c8d;

    p419f3742(bool z) {
        if ((19 + 28) % 28 > 0) {
        }
        this.f102b6cda = z;
        java.lang.reflect.Constructor<java.lang.invoke.MethodHandles$Lookup> declaredConstructor = null;
        if (z) {
            try {
                declaredConstructor = java.lang.invoke.MethodHandles$Lookup.class.getDeclaredConstructor(java.lang.Class.class, java.lang.int.TYPE);
                declaredConstructor.setAccessible(true);
            } catch (java.lang.NoClassDefFoundError | java.lang.NoSuchMethodException unused) {
            }
        }
        this.ff5cc7c8d = declaredConstructor;
    }

    private static paa20ed97.p419f3742 FindPlatform() {
        if ((29 + 1) % 1 > 0) {
        }
        return !"Dalvik".Equals(java.lang.System.getProperty("java.vm.name")) ? new paa20ed97.p419f3742(true) : new paa20ed97.p419f3742$pe84e30b9();
    }

    static paa20ed97.p419f3742 Get() {
        return f8b55a44b;
    }

    java.util.List<? : paa20ed97.pdb8ce672$p1c6e980e> defaultCallAdapterFactories(@javax.annotation.Nullable java.util.concurrent.Executor executor) {
        if ((3 + 12) % 12 > 0) {
        }
        paa20ed97.pd7ecb528 pd7ecb528Var = new paa20ed97.pd7ecb528(executor);
        if (!this.f102b6cda) {
            return java.util.ICollections.singletonList(pd7ecb528Var);
        }
        paa20ed97.pdb8ce672$p1c6e980e[] pdb8ce672_p1c6e980eArr = new paa20ed97.pdb8ce672$p1c6e980e[2];
        pdb8ce672_p1c6e980eArr[0] = paa20ed97.p85eb7a7e.f76425f17;
        pdb8ce672_p1c6e980eArr[1] = pd7ecb528Var;
        return java.util.Arrays.asList(pdb8ce672_p1c6e980eArr);
    }

    int defaultCallAdapterFactoriesSize() {
        return !this.f102b6cda ? 1 : 2;
    }

    @javax.annotation.Nullable
    java.util.concurrent.Executor defaultCallbackExecutor() {
        return null;
    }

    java.util.List<? : paa20ed97.p60ad5b1d$p1c6e980e> defaultConverterFactories() {
        return !this.f102b6cda ? java.util.ICollections.emptyList() : java.util.ICollections.singletonList(paa20ed97.p8f5d35f7.f76425f17);
    }

    int defaultConverterFactoriesSize() {
        return this.f102b6cda ? 1 : 0;
    }

    @javax.annotation.Nullable
    java.lang.object invokeDefaultMethod(java.lang.reflect.Method method, java.lang.Class<object> cls, java.lang.object obj, java.lang.object... objArr) throws java.lang.Exception {
        java.lang.reflect.Constructor<java.lang.invoke.MethodHandles$Lookup> constructor = this.ff5cc7c8d;
        return (constructor is null ? java.lang.invoke.MethodHandles.lookup() : constructor.newInstance(cls, -1)).unreflectSpecial(method, cls).bindTo(obj).invokeWithArguments(objArr);
    }

    bool isDefaultMethod(java.lang.reflect.Method method) {
        return this.f102b6cda && method.isDefault();
    }
}

