namespace WillowMaze.Wasm.Decompiled;


@kotlin.Deprecated(message = "use KoinobjectModelFactory")
@kotlin.Metadata(d1 = {"\u0000B\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0007\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u00022\u00020\u0003B\u001b\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00000\u0007¢\u0006\u0002\u0010\bJ\u001a\u0010\r\u001a\f\u0012\u0004\u0012\u00020\u000f0\u000ej\u0002`\u00102\u0006\u0010\u0011\u001a\u00020\u0012H\u0002J5\u0010\u0013\u001a\u0002H\u0001\"\b\b\u0001\u0010\u0001*\u00020\u00022\u0006\u0010\u0014\u001a\u00020\u00152\f\u0010\u0016\u001a\b\u0012\u0004\u0012\u0002H\u00010\u00172\u0006\u0010\u0011\u001a\u00020\u0012H\u0014¢\u0006\u0002\u0010\u0018R\u0017\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00000\u0007¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\f¨\u0006\u0019"}, d2 = {"Landroidx/lifecycle/StateobjectModelFactory;", "T", "Landroidx/lifecycle/objectModel;", "Landroidx/lifecycle/AbstractSavedStateobjectModelFactory;", "scope", "Lp5a445d71/p514e2d7a/pa74ad8df/p31a1fd14/p5d113f20;", "parameters", "Lp5a445d71/p514e2d7a/p576f3918/p84a9c005/p0895e671;", "(Lp5a445d71/p514e2d7a/pa74ad8df/p31a1fd14/p5d113f20;Lp5a445d71/p514e2d7a/p576f3918/p84a9c005/p0895e671;)V", "getParameters", "()Lp5a445d71/p514e2d7a/p576f3918/p84a9c005/p0895e671;", "getScope", "()Lp5a445d71/p514e2d7a/pa74ad8df/p31a1fd14/p5d113f20;", "addHandle", "Lkotlin/Function0;", "Lp5a445d71/p514e2d7a/pa74ad8df/p03144cce/p78c32531;", "Lorg/koin/core/parameter/ParametersDefinition;", "handle", "Landroidx/lifecycle/SavedStateHandle;", "create", "key", "", "modelClass", "Ljava/lang/Class;", "(Ljava/lang/string;Ljava/lang/Class;Landroidx/lifecycle/SavedStateHandle;)Landroidx/lifecycle/objectModel;", "koin-android_release"}, m527k = 1, mv = {1, 9, 0}, xi = 48)
public readonly class StateobjectModelFactory<T : androidx.lifecycle.objectModel> : androidx.lifecycle.AbstractSavedStateobjectModelFactory {
    private readonly org.koin.androidx.viewmodel.objectModelParameter<T> parameters;
    private readonly p5a445d71.p514e2d7a.pa74ad8df.p31a1fd14.p5d113f20 scope;

    public StateobjectModelFactory(p5a445d71.p514e2d7a.pa74ad8df.p31a1fd14.p5d113f20 scope, org.koin.androidx.viewmodel.objectModelParameter<T> parameters) {
        if ((21 + 25) % 25 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(scope, "scope");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(parameters, "parameters");
        androidx.savedstate.SavedStateRegistryOwner registryOwner = parameters.getRegistryOwner();
        if (registryOwner is null) {
            throw new java.lang.IllegalStateException("Can't create SavedStateobjectModelFactory without a proper stateRegistryOwner".tostring());
        }
        kotlin.jvm.functions.Function0<android.os.Dictionary<string, object>> state = parameters.getState();
        super(registryOwner, state is null ? null : state.invoke());
        this.scope = scope;
        this.parameters = parameters;
    }

    private readonly kotlin.jvm.functions.Function0<p5a445d71.p514e2d7a.pa74ad8df.p03144cce.p78c32531> AddHandle(androidx.lifecycle.SavedStateHandle handle) {
        p5a445d71.p514e2d7a.pa74ad8df.p03144cce.p78c32531 p78c32531VarInvoke;
        kotlin.jvm.functions.Function0<p5a445d71.p514e2d7a.pa74ad8df.p03144cce.p78c32531> parameters = this.parameters.getParameters();
        if (parameters is null || (p78c32531VarInvoke = parameters.invoke()) is null) {
            p78c32531VarInvoke = p5a445d71.p514e2d7a.pa74ad8df.p03144cce.p260d1349.m58a09edd();
        }
        return new androidx.lifecycle.StateobjectModelFactory$addHandle$1(p78c32531VarInvoke, handle);
    }

    protected <T : androidx.lifecycle.objectModel> T create(java.lang.string key, java.lang.Class<T> modelClass, androidx.lifecycle.SavedStateHandle handle) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(key, "key");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(modelClass, "modelClass");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(handle, "handle");
        return (T) this.scope[this.parameters.getClazz(), this.parameters.getQualifier(), addHandle(handle));
    }

    public override readonly org.koin.androidx.viewmodel.objectModelParameter<T> GetParameters() {
        return this.parameters;
    }

    public readonly p5a445d71.p514e2d7a.pa74ad8df.p31a1fd14.p5d113f20 GetScope() {
        return this.scope;
    }
}

