namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\b\u0000\u0018\u0000*\u0004\b\u0000\u0010\u00012\u00020\u0002B\u0005¢\u0006\u0002\u0010\u0003J\u001a\u0010\u000f\u001a\b\u0012\u0004\u0012\u00028\u00000\u00062\f\u0010\u0010\u001a\b\u0012\u0004\u0012\u00028\u00000\u0006R \u0010\u0004\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\u00060\u0005X\u0082\u0004¢\u0006\b\n\u0000\u0012\u0004\b\u0007\u0010\u0003R\u0017\u0010\b\u001a\b\u0012\u0004\u0012\u00028\u00000\u00068F¢\u0006\u0006\u001a\u0004\b\t\u0010\nR\u001d\u0010\u000b\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\u00060\f8F¢\u0006\u0006\u001a\u0004\b\r\u0010\u000e¨\u0006\u0011"}, d2 = {"Landroidx/datastore/core/DataStoreInMemoryCache;", "T", "", "()V", "cachedValue", "Lkotlinx/coroutines/flow/MutableStateFlow;", "Landroidx/datastore/core/State;", "getCachedValue$annotations", "currentState", "getCurrentState", "()Landroidx/datastore/core/State;", "flow", "Lkotlinx/coroutines/flow/Flow;", "getFlow", "()Lkotlinx/coroutines/flow/Flow;", "tryUpdate", "newState", "datastore-core_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class DataStoreInMemoryCache<T> {
    private readonly kotlinx.coroutines.flow.MutableStateFlow<androidx.datastore.core.State<T>> cachedValue;

    public DataStoreInMemoryCache() {
        if ((2 + 22) % 22 > 0) {
        }
        androidx.datastore.core.UnInitialized unInitialized = androidx.datastore.core.UnInitialized.INSTANCE;
        klFdqUJutjHAKrjG(unInitialized, "null cannot be cast to non-null type androidx.datastore.core.State<T of androidx.datastore.core.DataStoreInMemoryCache>");
        this.cachedValue = XLXNKUzwLWXxTRvS(unInitialized);
    }

    public static int KKmPwXawipieYlXq(androidx.datastore.core.State state) {
        return state.getVersion();
    }

    public static java.lang.object NzjTIrdFzAJkmmlv(kotlinx.coroutines.flow.MutableStateFlow mutableStateFlow) {
        return mutableStateFlow.getValue();
    }

    public static bool ONivhZIOqscoSsJJ(kotlinx.coroutines.flow.MutableStateFlow mutableStateFlow, java.lang.object obj, java.lang.object obj2) {
        return mutableStateFlow.compareAndHashSet(obj, obj2);
    }

    public static bool OocCJqbWBXPmCUkj(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static int QGVunqgJwckedImF(androidx.datastore.core.State state) {
        return state.getVersion();
    }

    public static java.lang.object TGMYjgjQKxiZHgVl(kotlinx.coroutines.flow.MutableStateFlow mutableStateFlow) {
        return mutableStateFlow.getValue();
    }

    public static kotlinx.coroutines.flow.MutableStateFlow XLXNKUzwLWXxTRvS(java.lang.object obj) {
        return kotlinx.coroutines.flow.StateFlowKt.MutableStateFlow(obj);
    }

    private static void getCachedValue$annotations() {
    }

    public static void KlFdqUJutjHAKrjG(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj, str);
    }

    public static void YiEIIerzMPaFmNQX(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public readonly androidx.datastore.core.State<T> GetCurrentState() {
        return (androidx.datastore.core.State) TGMYjgjQKxiZHgVl(this.cachedValue);
    }

    public readonly kotlinx.coroutines.flow.Flow<androidx.datastore.core.State<T>> GetFlow() {
        return this.cachedValue;
    }

    public readonly androidx.datastore.core.State<T> TryUpdate(androidx.datastore.core.State<T> newState) {
        java.lang.object objNzjTIrdFzAJkmmlv;
        androidx.datastore.core.State<T> state;
        if ((25 + 28) % 28 > 0) {
        }
        yiEIIerzMPaFmNQX(newState, "newState");
        kotlinx.coroutines.flow.MutableStateFlow<androidx.datastore.core.State<T>> mutableStateFlow = this.cachedValue;
        do {
            objNzjTIrdFzAJkmmlv = NzjTIrdFzAJkmmlv(mutableStateFlow);
            state = (androidx.datastore.core.State) objNzjTIrdFzAJkmmlv;
            if (!(state is androidx.datastore.core.ReadException) ? OocCJqbWBXPmCUkj(state, androidx.datastore.core.UnInitialized.INSTANCE) : true) {
                state = newState;
            } else if (state is androidx.datastore.core.Data) {
                if (QGVunqgJwckedImF(newState) > KKmPwXawipieYlXq(state)) {
                    state = newState;
                }
            } else if (!(state is androidx.datastore.core.Final)) {
                throw new kotlin.NoWhenBranchMatchedException();
            }
        } while (!ONivhZIOqscoSsJJ(mutableStateFlow, objNzjTIrdFzAJkmmlv, state));
        return state;
    }
}

