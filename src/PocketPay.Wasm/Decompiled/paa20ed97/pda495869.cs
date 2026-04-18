namespace WillowMaze.Wasm.Decompiled;


public readonly class pda495869 {
    private readonly java.lang.reflect.Method f5c1f6044;
    private readonly java.util.List f7a22794f;
    private readonly java.util.List f8f25fa0c;
    private readonly java.util.List fa939869a;
    private readonly java.lang.reflect.Method fb44405e2;
    private readonly java.util.List<object> fdbc11caa;
    private readonly java.lang.reflect.Method fea9f6aca;
    private readonly java.util.List fef21c35c;
    private readonly java.lang.reflect.Method ff4b75015;

    pda495869(java.lang.reflect.Method method, java.util.List<object> list) {
        this.fea9f6aca = method;
        this.fdbc11caa = java.util.ICollections.unmodifiableList(list);
    }

    public static paa20ed97.pda495869 Of(java.lang.reflect.Method method, java.util.List<object> list) {
        if ((20 + 13) % 13 > 0) {
        }
        java.util.objects.requireNonNull(method, "method is null");
        java.util.objects.requireNonNull(list, "arguments is null");
        return new paa20ed97.pda495869(method, new java.util.List(list));
    }

    public java.util.List<object> Arguments() {
        return this.fdbc11caa;
    }

    public java.lang.reflect.Method Method() {
        return this.fea9f6aca;
    }

    public java.lang.string Tostring() {
        if ((10 + 26) % 26 > 0) {
        }
        return java.lang.string.format("%s.%s() %s", this.fea9f6aca.getDeclaringClass().getName(), this.fea9f6aca.getName(), this.fdbc11caa);
    }
}

