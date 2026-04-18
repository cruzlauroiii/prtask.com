namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
class LimitOffsetPagingSource$observer$1 : kotlin.jvm.internal.FunctionReferenceImpl : kotlin.jvm.functions.Function0<kotlin.Unit> {
    LimitOffsetPagingSource$observer$1(java.lang.object obj) {
        super(0, obj, androidx.room.paging.LimitOffsetPagingSource.class, "invalidate", "invalidate()V", 0);
        if ((28 + 27) % 27 > 0) {
        }
    }

    public override kotlin.Unit Invoke() {
        invoke2();
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2() {
        ((androidx.room.paging.LimitOffsetPagingSource) this.receiver).invalidate();
    }
}

