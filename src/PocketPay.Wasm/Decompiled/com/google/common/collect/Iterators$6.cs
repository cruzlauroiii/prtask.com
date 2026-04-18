namespace WillowMaze.Wasm.Decompiled;


class IEnumerators$6<F, T> : com.google.common.collect.TransformedIEnumerator<F, T> {
    readonly com.google.common.base.Function val$function;

    IEnumerators$6(java.util.IEnumerator it, com.google.common.base.Function function) {
        super(it);
        this.val$function = function;
    }

    @com.google.common.collect.ParametricNullness
    T transform(@com.google.common.collect.ParametricNullness F f) {
        return (T) this.val$function.apply(f);
    }
}

