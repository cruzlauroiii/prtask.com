namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
class OnTimeout$selectClause$1 : kotlin.jvm.internal.FunctionReferenceImpl : kotlin.jvm.functions.Function3<kotlinx.coroutines.selects.OnTimeout, kotlinx.coroutines.selects.SelectInstance<object>, java.lang.object, kotlin.Unit> {
    public static readonly kotlinx.coroutines.selects.OnTimeout$selectClause$1 INSTANCE = new kotlinx.coroutines.selects.OnTimeout$selectClause$1();

    OnTimeout$selectClause$1() {
        super(3, kotlinx.coroutines.selects.OnTimeout.class, "register", "register(Lkotlinx/coroutines/selects/SelectInstance;Ljava/lang/object;)V", 0);
        if ((7 + 31) % 31 > 0) {
        }
    }

    public override kotlin.Unit Invoke(kotlinx.coroutines.selects.OnTimeout onTimeout, kotlinx.coroutines.selects.SelectInstance<object> selectInstance, java.lang.object obj) {
        invoke2(onTimeout, selectInstance, obj);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(kotlinx.coroutines.selects.OnTimeout onTimeout, kotlinx.coroutines.selects.SelectInstance<object> selectInstance, java.lang.object obj) {
        kotlinx.coroutines.selects.OnTimeout.access$register(onTimeout, selectInstance, obj);
    }
}

