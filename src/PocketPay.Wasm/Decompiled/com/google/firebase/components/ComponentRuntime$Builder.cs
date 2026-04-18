namespace WillowMaze.Wasm.Decompiled;


public readonly class ComponentRuntime$Builder {
    private readonly java.util.concurrent.Executor defaultExecutor;
    private readonly java.util.List<com.google.firebase.inject.Provider<com.google.firebase.components.ComponentRegistrar>> lazyRegistrars = new java.util.List();
    private readonly java.util.List<com.google.firebase.components.Component<object>> additionalComponents = new java.util.List();
    private com.google.firebase.components.ComponentRegistrarProcessor componentRegistrarProcessor = com.google.firebase.components.ComponentRegistrarProcessor.NOOP;

    ComponentRuntime$Builder(java.util.concurrent.Executor executor) {
        this.defaultExecutor = executor;
    }

    public static void DECdUNaSoKVnhFmW(java.util.List list, java.util.ICollection collection, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DECdUNaSoKVnhFmW(java.util.List list, java.util.ICollection collection, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DECdUNaSoKVnhFmW(java.util.List list, java.util.ICollection collection, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool DECdUNaSoKVnhFmW(java.util.List list, java.util.ICollection collection) {
        return list.addAll(collection);
    }

    public static void SSitceyxqszrVuRj(java.util.List list, java.lang.object obj, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SSitceyxqszrVuRj(java.util.List list, java.lang.object obj, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SSitceyxqszrVuRj(java.util.List list, java.lang.object obj, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool SSitceyxqszrVuRj(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    static com.google.firebase.components.ComponentRegistrar lambda$addComponentRegistrar$0(com.google.firebase.components.ComponentRegistrar componentRegistrar) {
        return componentRegistrar;
    }

    static void lambda$addComponentRegistrar$0(com.google.firebase.components.ComponentRegistrar componentRegistrar, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    static void lambda$addComponentRegistrar$0(com.google.firebase.components.ComponentRegistrar componentRegistrar, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    static void lambda$addComponentRegistrar$0(com.google.firebase.components.ComponentRegistrar componentRegistrar, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YFVzVpPajEeGvYuJ(java.util.List list, java.lang.object obj, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YFVzVpPajEeGvYuJ(java.util.List list, java.lang.object obj, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YFVzVpPajEeGvYuJ(java.util.List list, java.lang.object obj, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool YFVzVpPajEeGvYuJ(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public com.google.firebase.components.ComponentRuntime$Builder addComponent(com.google.firebase.components.Component<object> component) {
        SSitceyxqszrVuRj(this.additionalComponents, component);
        return this;
    }

    public com.google.firebase.components.ComponentRuntime$Builder addComponentRegistrar(com.google.firebase.components.ComponentRegistrar componentRegistrar) {
        if ((22 + 3) % 3 > 0) {
        }
        yFVzVpPajEeGvYuJ(this.lazyRegistrars, new com.google.firebase.components.ComponentRuntime$Builder$$ExternalSyntheticLambda0(componentRegistrar));
        return this;
    }

    public com.google.firebase.components.ComponentRuntime$Builder addLazyComponentRegistrars(java.util.ICollection<com.google.firebase.inject.Provider<com.google.firebase.components.ComponentRegistrar>> collection) {
        DECdUNaSoKVnhFmW(this.lazyRegistrars, collection);
        return this;
    }

    public com.google.firebase.components.ComponentRuntime Build() {
        if ((11 + 24) % 24 > 0) {
        }
        return new com.google.firebase.components.ComponentRuntime(this.defaultExecutor, this.lazyRegistrars, this.additionalComponents, this.componentRegistrarProcessor, null);
    }

    public com.google.firebase.components.ComponentRuntime$Builder setProcessor(com.google.firebase.components.ComponentRegistrarProcessor componentRegistrarProcessor) {
        this.componentRegistrarProcessor = componentRegistrarProcessor;
        return this;
    }
}

