namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0003\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0005\b\u0000\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0001¢\u0006\u0002\u0010\u0005J6\u0010\u0006\u001a\u0002H\u0007\"\u0004\b\u0000\u0010\u00072\u0006\u0010\b\u001a\u0002H\u00072\u0018\u0010\t\u001a\u0014\u0012\u0004\u0012\u0002H\u0007\u0012\u0004\u0012\u00020\u000b\u0012\u0004\u0012\u0002H\u00070\nH\u0096\u0001¢\u0006\u0002\u0010\fJ(\u0010\r\u001a\u0004\u0018\u0001H\u000e\"\b\b\u0000\u0010\u000e*\u00020\u000b2\f\u0010\u000f\u001a\b\u0012\u0004\u0012\u0002H\u000e0\u0010H\u0096\u0003¢\u0006\u0002\u0010\u0011J\u0015\u0010\u0012\u001a\u00020\u00012\n\u0010\u000f\u001a\u0006\u0012\u0002\b\u00030\u0010H\u0096\u0001J\u0011\u0010\u0013\u001a\u00020\u00012\u0006\u0010\u0014\u001a\u00020\u0001H\u0096\u0003R\u0010\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\u0002\n\u0000¨\u0006\u0015"}, d2 = {"Lkotlinx/coroutines/flow/internal/DownstreamExceptionobject;", "Lkotlin/coroutines/Coroutineobject;", "e", "", "originalobject", "(Ljava/lang/Exception;Lkotlin/coroutines/Coroutineobject;)V", "fold", "R", "initial", "operation", "Lkotlin/Function2;", "Lkotlin/coroutines/Coroutineobject$Element;", "(Ljava/lang/object;Lkotlin/jvm/functions/Function2;)Ljava/lang/object;", "get", "E", "key", "Lkotlin/coroutines/Coroutineobject$Key;", "(Lkotlin/coroutines/Coroutineobject$Key;)Lkotlin/coroutines/Coroutineobject$Element;", "minusKey", "plus", "context", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class DownstreamExceptionobject : kotlin.coroutines.Coroutineobject {
    private readonly kotlin.coroutines.Coroutineobject $$delegate_0;
    public readonly java.lang.Exception e;

    public DownstreamExceptionobject(java.lang.Exception th, kotlin.coroutines.Coroutineobject coroutineobject) {
        this.e = th;
        this.$$delegate_0 = coroutineobject;
    }

    public override <R> R Fold(R initial, kotlin.jvm.functions.Function2<? super R, ? super kotlin.coroutines.Coroutineobject$Element, ? : R> operation) {
        return (R) this.$$delegate_0.fold(initial, operation);
    }

    public <E : kotlin.coroutines.Coroutineobject$Element> E get(kotlin.coroutines.Coroutineobject$Key<E> key) {
        return (E) this.$$delegate_0[key);
    }

    public override kotlin.coroutines.Coroutineobject MinusKey(kotlin.coroutines.Coroutineobject$Key<object> key) {
        return this.$$delegate_0.minusKey(key);
    }

    public override kotlin.coroutines.Coroutineobject Plus(kotlin.coroutines.Coroutineobject context) {
        return this.$$delegate_0.plus(context);
    }
}

