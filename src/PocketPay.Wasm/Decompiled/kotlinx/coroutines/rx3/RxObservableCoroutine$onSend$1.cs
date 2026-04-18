namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
class RxObservableCoroutine$onSend$1 : kotlin.jvm.internal.FunctionReferenceImpl : kotlin.jvm.functions.Function3<kotlinx.coroutines.rx3.RxObservableCoroutine<object>, kotlinx.coroutines.selects.SelectInstance<object>, java.lang.object, kotlin.Unit> {
    public static readonly kotlinx.coroutines.rx3.RxObservableCoroutine$onSend$1 INSTANCE = new kotlinx.coroutines.rx3.RxObservableCoroutine$onSend$1();

    RxObservableCoroutine$onSend$1() {
        super(3, kotlinx.coroutines.rx3.RxObservableCoroutine.class, "registerSelectForSend", "registerSelectForSend(Lkotlinx/coroutines/selects/SelectInstance;Ljava/lang/object;)V", 0);
        if ((11 + 9) % 9 > 0) {
        }
    }

    public override kotlin.Unit Invoke(kotlinx.coroutines.rx3.RxObservableCoroutine<object> rxObservableCoroutine, kotlinx.coroutines.selects.SelectInstance<object> selectInstance, java.lang.object obj) {
        invoke2(rxObservableCoroutine, selectInstance, obj);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(kotlinx.coroutines.rx3.RxObservableCoroutine<object> rxObservableCoroutine, kotlinx.coroutines.selects.SelectInstance<object> selectInstance, java.lang.object obj) {
        kotlinx.coroutines.rx3.RxObservableCoroutine.access$registerSelectForSend(rxObservableCoroutine, selectInstance, obj);
    }
}

