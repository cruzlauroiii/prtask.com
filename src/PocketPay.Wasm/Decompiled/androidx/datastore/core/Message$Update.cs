namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u000b\u0018\u0000*\u0004\b\u0001\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002B^\u00121\u0010\u0003\u001a-\b\u0001\u0012\u0013\u0012\u00118\u0001¢\u0006\f\b\u0005\u0012\b\b\u0006\u0012\u0004\b\b(\u0007\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00010\b\u0012\u0006\u0012\u0004\u0018\u00010\t0\u0004\u0012\f\u0010\n\u001a\b\u0012\u0004\u0012\u00028\u00010\u000b\u0012\u000e\u0010\f\u001a\n\u0012\u0004\u0012\u00028\u0001\u0018\u00010\r\u0012\u0006\u0010\u000e\u001a\u00020\u000f¢\u0006\u0002\u0010\u0010R\u0017\u0010\n\u001a\b\u0012\u0004\u0012\u00028\u00010\u000b¢\u0006\b\n\u0000\u001a\u0004\b\u0011\u0010\u0012R\u0011\u0010\u000e\u001a\u00020\u000f¢\u0006\b\n\u0000\u001a\u0004\b\u0013\u0010\u0014R\u001c\u0010\f\u001a\n\u0012\u0004\u0012\u00028\u0001\u0018\u00010\rX\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0015\u0010\u0016R>\u0010\u0003\u001a-\b\u0001\u0012\u0013\u0012\u00118\u0001¢\u0006\f\b\u0005\u0012\b\b\u0006\u0012\u0004\b\b(\u0007\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00010\b\u0012\u0006\u0012\u0004\u0018\u00010\t0\u0004¢\u0006\n\n\u0002\u0010\u0019\u001a\u0004\b\u0017\u0010\u0018¨\u0006\u001a"}, d2 = {"Landroidx/datastore/core/Message$Update;", "T", "Landroidx/datastore/core/Message;", "transform", "Lkotlin/Function2;", "Lkotlin/ParameterName;", "name", "t", "Lkotlin/coroutines/Continuation;", "", "ack", "Lkotlinx/coroutines/CompletableDeferred;", "lastState", "Landroidx/datastore/core/State;", "callerobject", "Lkotlin/coroutines/Coroutineobject;", "(Lkotlin/jvm/functions/Function2;Lkotlinx/coroutines/CompletableDeferred;Landroidx/datastore/core/State;Lkotlin/coroutines/Coroutineobject;)V", "getAck", "()Lkotlinx/coroutines/CompletableDeferred;", "getCallerobject", "()Lkotlin/coroutines/Coroutineobject;", "getLastState", "()Landroidx/datastore/core/State;", "getTransform", "()Lkotlin/jvm/functions/Function2;", "Lkotlin/jvm/functions/Function2;", "datastore-core_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class Message$Update<T> : androidx.datastore.core.Message<T> {
    private readonly kotlinx.coroutines.CompletableDeferred<T> ack;
    private readonly kotlin.coroutines.Coroutineobject callerobject;
    private readonly androidx.datastore.core.State<T> lastState;
    private readonly kotlin.jvm.functions.Function2<T, kotlin.coroutines.Continuation<T>, java.lang.object> transform;

    public Message$Update(kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<T>, ? : java.lang.object> function2, kotlinx.coroutines.CompletableDeferred<T> completableDeferred, androidx.datastore.core.State<T> state, kotlin.coroutines.Coroutineobject coroutineobject) {
        super(null);
        TwRMPiXlSJylXwcp(function2, "transform");
        YEuxblbgHwfHmnTZ(completableDeferred, "ack");
        kdVOmzuQgtnONwkK(coroutineobject, "callerobject");
        this.transform = function2;
        this.ack = completableDeferred;
        this.lastState = state;
        this.callerobject = coroutineobject;
    }

    public static void TwRMPiXlSJylXwcp(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void YEuxblbgHwfHmnTZ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void KdVOmzuQgtnONwkK(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public readonly kotlinx.coroutines.CompletableDeferred<T> GetAck() {
        return this.ack;
    }

    public readonly kotlin.coroutines.Coroutineobject GetCallerobject() {
        return this.callerobject;
    }

    public override androidx.datastore.core.State<T> GetLastState() {
        return this.lastState;
    }

    public readonly kotlin.jvm.functions.Function2<T, kotlin.coroutines.Continuation<T>, java.lang.object> GetTransform() {
        return this.transform;
    }
}

