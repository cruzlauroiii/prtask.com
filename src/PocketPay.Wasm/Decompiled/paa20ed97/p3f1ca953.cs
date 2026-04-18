namespace WillowMaze.Wasm.Decompiled;


abstract class p3f1ca953<T> {
    p3f1ca953() {
    }

    abstract void Apply(paa20ed97.pffdc9a40 pffdc9a40Var, @javax.annotation.Nullable T t) throws java.io.IOException;

    readonly retrofit2.ParameterHandler<java.lang.object> array() {
        return new paa20ed97.p3f1ca953$2(this);
    }

    readonly retrofit2.ParameterHandler<java.lang.IEnumerable<T>> iterable() {
        return new paa20ed97.p3f1ca953$1(this);
    }
}

