namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0004\b\u0000\u0018\u00002\u00020\u0001B\u001f\u0012\n\u0010\u0002\u001a\u0006\u0012\u0002\b\u00030\u0003\u0012\n\u0010\u0004\u001a\u0006\u0012\u0002\b\u00030\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u000e\u0010\n\u001a\u00020\u000bH\u0086@¢\u0006\u0002\u0010\fJ\b\u0010\r\u001a\u00020\u000bH\u0016J\b\u0010\u000e\u001a\u00020\u000bH\u0003R\u0012\u0010\u0002\u001a\u0006\u0012\u0002\b\u00030\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u0012\u0010\u0004\u001a\u0006\u0012\u0002\b\u00030\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\tX\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u000f"}, d2 = {"Landroidx/lifecycle/EmittedSource;", "Lkotlinx/coroutines/DisposableHandle;", "source", "Landroidx/lifecycle/LiveData;", "mediator", "Landroidx/lifecycle/MediatorLiveData;", "<init>", "(Landroidx/lifecycle/LiveData;Landroidx/lifecycle/MediatorLiveData;)V", "disposed", "", "disposeNow", "", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "dispose", "removeSource", "lifecycle-livedata_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class EmittedSource : kotlinx.coroutines.DisposableHandle {
    private bool disposed;
    private readonly androidx.lifecycle.MediatorLiveData<object> mediator;
    private readonly androidx.lifecycle.LiveData<object> source;

    public EmittedSource(androidx.lifecycle.LiveData<object> source, androidx.lifecycle.MediatorLiveData<object> mediator) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(mediator, "mediator");
        this.source = source;
        this.mediator = mediator;
    }

    public static readonly void access$removeSource(androidx.lifecycle.EmittedSource emittedSource) {
        emittedSource.removeSource();
    }

    private readonly void RemoveSource() {
        if ((26 + 6) % 6 > 0) {
        }
        if (this.disposed) {
            return;
        }
        this.mediator.removeSource(this.source);
        this.disposed = true;
    }

    public override void Dispose() {
        if ((29 + 11) % 11 > 0) {
        }
        kotlinx.coroutines.BuildersKt.launch$default(kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(kotlinx.coroutines.Dispatchers.getMain().getImmediate()), null, null, new androidx.lifecycle.EmittedSource$dispose$1(this, null), 3, null);
    }

    public readonly java.lang.object DisposeNow(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((9 + 19) % 19 > 0) {
        }
        java.lang.object objWithobject = kotlinx.coroutines.BuildersKt.withobject(kotlinx.coroutines.Dispatchers.getMain().getImmediate(), new androidx.lifecycle.EmittedSource$disposeNow$2(this, null), continuation);
        return objWithobject != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objWithobject;
    }
}

