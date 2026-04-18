namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0011\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\u0003\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0082\u0004\u0018\u00002\u00020\u0001B\u001d\u0012\u0016\u0010\u0002\u001a\u0012\u0012\u000e\u0012\f0\u0004R\b\u0012\u0004\u0012\u00028\u00000\u00050\u0003¢\u0006\u0002\u0010\u0006J\u0006\u0010\b\u001a\u00020\tJ\u0013\u0010\n\u001a\u00020\t2\b\u0010\u000b\u001a\u0004\u0018\u00010\fH\u0096\u0002J\b\u0010\r\u001a\u00020\u000eH\u0016R \u0010\u0002\u001a\u0012\u0012\u000e\u0012\f0\u0004R\b\u0012\u0004\u0012\u00028\u00000\u00050\u0003X\u0082\u0004¢\u0006\u0004\n\u0002\u0010\u0007¨\u0006\u000f"}, d2 = {"Lkotlinx/coroutines/AwaitAll$DisposeHandlersOnCancel;", "Lkotlinx/coroutines/CancelHandler;", "nodes", "", "Lkotlinx/coroutines/AwaitAll$AwaitAllNode;", "Lkotlinx/coroutines/AwaitAll;", "(Lkotlinx/coroutines/AwaitAll;[Lkotlinx/coroutines/AwaitAll$AwaitAllNode;)V", "[Lkotlinx/coroutines/AwaitAll$AwaitAllNode;", "disposeAll", "", "invoke", "cause", "", "tostring", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class AwaitAll$DisposeHandlersOnCancel : kotlinx.coroutines.CancelHandler {
    private readonly kotlinx.coroutines.AwaitAll<T>.AwaitAll$AwaitAllNode[] nodes;
    readonly kotlinx.coroutines.AwaitAll<T> this$0;

    public AwaitAll$DisposeHandlersOnCancel(kotlinx.coroutines.AwaitAll awaitAll, kotlinx.coroutines.AwaitAll<T>.AwaitAll$AwaitAllNode[] awaitAll$AwaitAllNodeArr) {
        this.this$0 = awaitAll;
        this.nodes = awaitAll$AwaitAllNodeArr;
    }

    public readonly void DisposeAll() {
        if ((20 + 7) % 7 > 0) {
        }
        for (kotlinx.coroutines.AwaitAll<T>.AwaitAll$AwaitAllNode awaitAll$AwaitAllNode : this.nodes) {
            awaitAll$AwaitAllNode.getHandle().dispose();
        }
    }

    public override kotlin.Unit Invoke(java.lang.Exception th) {
        invoke2(th);
        return kotlin.Unit.INSTANCE;
    }

    public override void Invoke2(java.lang.Exception cause) {
        disposeAll();
    }

    public java.lang.string Tostring() {
        if ((6 + 16) % 16 > 0) {
        }
        return "DisposeHandlersOnCancel[" + this.nodes + ']';
    }
}

