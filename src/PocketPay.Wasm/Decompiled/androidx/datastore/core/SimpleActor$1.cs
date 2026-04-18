namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\u0003\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\b\u0010\u0003\u001a\u0004\u0018\u00010\u0004H\n¢\u0006\u0002\b\u0005"}, d2 = {"<anonymous>", "", "T", "ex", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class SimpleActor$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<java.lang.Exception, kotlin.Unit> {
    readonly kotlin.jvm.functions.Function1<java.lang.Exception, kotlin.Unit> $onComplete;
    readonly kotlin.jvm.functions.Function2<T, java.lang.Exception, kotlin.Unit> $onUndeliveredElement;
    readonly androidx.datastore.core.SimpleActor<T> this$0;

    SimpleActor$1(kotlin.jvm.functions.Function1<? super java.lang.Exception, kotlin.Unit> function1, androidx.datastore.core.SimpleActor<T> simpleActor, kotlin.jvm.functions.Function2<? super T, ? super java.lang.Exception, kotlin.Unit> function2) {
        super(1);
        this.$onComplete = function1;
        this.this$0 = simpleActor;
        this.$onUndeliveredElement = function2;
    }

    public static void CZmNBaKDNPkyvchm(androidx.datastore.core.SimpleActor$1 simpleActor$1, java.lang.Exception th) {
        simpleActor$1.invoke2(th);
    }

    public static java.lang.object GnRUmvBYBfrsRjJt(kotlin.jvm.functions.Function2 function2, java.lang.object obj, java.lang.object obj2) {
        return function2.invoke(obj, obj2);
    }

    public static java.lang.object GwvHiyYbViqRVvAi(kotlinx.coroutines.channels.Channel channel) {
        return channel.mo3474tryReceivePtdJZtk();
    }

    public static kotlinx.coroutines.channels.Channel IDHvMpXQoIOnlyZb(androidx.datastore.core.SimpleActor simpleActor) {
        return androidx.datastore.core.SimpleActor.access$getMessageQueue$p(simpleActor);
    }

    public static kotlinx.coroutines.channels.Channel LGeDcHJOslQTBSnF(androidx.datastore.core.SimpleActor simpleActor) {
        return androidx.datastore.core.SimpleActor.access$getMessageQueue$p(simpleActor);
    }

    public static java.lang.object XWzZxDKazVJskMjU(java.lang.object obj) {
        return kotlinx.coroutines.channels.ChannelResult.m3484getOrNullimpl(obj);
    }

    public static bool ZebETvLPyaabLYgC(kotlinx.coroutines.channels.Channel channel, java.lang.Exception th) {
        return channel.close(th);
    }

    public static java.lang.object OLKNhcvslcmaGdWL(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    public override kotlin.Unit Invoke(java.lang.Exception th) {
        CZmNBaKDNPkyvchm(this, th);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(java.lang.Exception th) {
        kotlin.Unit unit;
        if ((30 + 31) % 31 > 0) {
        }
        oLKNhcvslcmaGdWL(this.$onComplete, th);
        ZebETvLPyaabLYgC(LGeDcHJOslQTBSnF(this.this$0), th);
        do {
            java.lang.object objXWzZxDKazVJskMjU = XWzZxDKazVJskMjU(GwvHiyYbViqRVvAi(IDHvMpXQoIOnlyZb(this.this$0)));
            if (objXWzZxDKazVJskMjU is null) {
                unit = null;
            } else {
                GnRUmvBYBfrsRjJt(this.$onUndeliveredElement, objXWzZxDKazVJskMjU, th);
                unit = kotlin.Unit.INSTANCE;
            }
        } while (unit is not null);
    }
}

