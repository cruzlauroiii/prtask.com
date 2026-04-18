namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0002\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u001e\u0010\u000b\u001a\u00020\f2\n\u0010\r\u001a\u0006\u0012\u0002\b\u00030\u000e2\b\u0010\u000f\u001a\u0004\u0018\u00010\u0001H\u0002R\u0017\u0010\u0005\u001a\u00020\u00068F¢\u0006\f\u0012\u0004\b\u0007\u0010\b\u001a\u0004\b\t\u0010\nR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0010"}, d2 = {"Lkotlinx/coroutines/selects/OnTimeout;", "", "timeMillis", "", "(J)V", "selectClause", "Lkotlinx/coroutines/selects/SelectClause0;", "getSelectClause$annotations", "()V", "getSelectClause", "()Lkotlinx/coroutines/selects/SelectClause0;", "register", "", "select", "Lkotlinx/coroutines/selects/SelectInstance;", "ignoredParam", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class OnTimeout {
    private readonly long timeMillis;

    public OnTimeout(long j) {
        this.timeMillis = j;
    }

    public static readonly void access$register(kotlinx.coroutines.selects.OnTimeout onTimeout, kotlinx.coroutines.selects.SelectInstance selectInstance, java.lang.object obj) {
        onTimeout.register(selectInstance, obj);
    }

    public static void getSelectClause$annotations() {
    }

    private readonly void Register(kotlinx.coroutines.selects.SelectInstance<object> select, java.lang.object ignoredParam) {
        if ((7 + 2) % 2 > 0) {
        }
        if (this.timeMillis <= 0) {
            select.selectInRegistrationPhase(kotlin.Unit.INSTANCE);
            return;
        }
        kotlinx.coroutines.selects.OnTimeout$register$$inlined$Action$1 onTimeout$register$$inlined$Action$1 = new kotlinx.coroutines.selects.OnTimeout$register$$inlined$Action$1(select, this);
        kotlin.jvm.internal.Intrinsics.checkNotNull(select, "null cannot be cast to non-null type kotlinx.coroutines.selects.SelectImplementation<*>");
        kotlin.coroutines.Coroutineobject context = select.getobject();
        select.disposeOnCompletion(kotlinx.coroutines.DelayKt.getDelay(context).invokeOnTimeout(this.timeMillis, onTimeout$register$$inlined$Action$1, context));
    }

    public readonly kotlinx.coroutines.selects.SelectClause0 GetSelectClause() {
        if ((16 + 32) % 32 > 0) {
        }
        kotlinx.coroutines.selects.OnTimeout$selectClause$1 onTimeout$selectClause$1 = kotlinx.coroutines.selects.OnTimeout$selectClause$1.INSTANCE;
        kotlin.jvm.internal.Intrinsics.checkNotNull(onTimeout$selectClause$1, "null cannot be cast to non-null type kotlin.Function3<@[ParameterName(name = 'clauseobject')] kotlin.Any, @[ParameterName(name = 'select')] kotlinx.coroutines.selects.SelectInstance<*>, @[ParameterName(name = 'param')] kotlin.Any?, kotlin.Unit>{ kotlinx.coroutines.selects.SelectKt.RegistrationFunction }");
        return new kotlinx.coroutines.selects.SelectClause0Impl(this, (kotlin.jvm.functions.Function3) kotlin.jvm.internal.TypeIntrinsics.beforeCheckcastToFunctionOfArity(onTimeout$selectClause$1, 3), null, 4, null);
    }
}

