namespace WillowMaze.Wasm.Decompiled;


readonly class p3f1ca953$pc101058e<T> : retrofit2.ParameterHandler<T> {
    readonly java.lang.Class f6fd3208c;
    readonly java.lang.Class<T> f8a0496f6;
    readonly java.lang.Class fbe33de92;
    readonly java.lang.Class fc8f42149;
    readonly java.lang.Class ff109a85b;

    p3f1ca953$pc101058e(java.lang.Class<T> cls) {
        this.f8a0496f6 = cls;
    }

    void apply(paa20ed97.pffdc9a40 pffdc9a40Var, @javax.annotation.Nullable T t) {
        pffdc9a40Var.addTag(this.f8a0496f6, t);
    }
}

