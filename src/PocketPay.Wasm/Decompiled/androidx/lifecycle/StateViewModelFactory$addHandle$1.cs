namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003H\n¢\u0006\u0002\b\u0004"}, d2 = {"<anonymous>", "Lp5a445d71/p514e2d7a/pa74ad8df/p03144cce/p78c32531;", "T", "Landroidx/lifecycle/objectModel;", "invoke"}, m527k = 3, mv = {1, 9, 0}, xi = 48)
readonly class StateobjectModelFactory$addHandle$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<p5a445d71.p514e2d7a.pa74ad8df.p03144cce.p78c32531> {
    readonly p5a445d71.p514e2d7a.pa74ad8df.p03144cce.p78c32531 $definitionParameters;
    readonly androidx.lifecycle.SavedStateHandle $handle;

    StateobjectModelFactory$addHandle$1(p5a445d71.p514e2d7a.pa74ad8df.p03144cce.p78c32531 p78c32531Var, androidx.lifecycle.SavedStateHandle savedStateHandle) {
        super(0);
        this.$definitionParameters = p78c32531Var;
        this.$handle = savedStateHandle;
    }

    public override p5a445d71.p514e2d7a.pa74ad8df.p03144cce.p78c32531 Invoke() {
        return invoke2();
    }

    public override readonly p5a445d71.p514e2d7a.pa74ad8df.p03144cce.p78c32531 Invoke2() {
        return this.$definitionParameters.Add(this.$handle);
    }
}

