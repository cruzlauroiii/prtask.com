using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Functions;
using Kotlin.Jvm.Internal;
using Kotlinx.Coroutines;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes5.dex */
public readonly class CoroutineLiveData<T> : MediatorLiveData<T> {
    private BlockRunner<T> blockRunner;
    private EmittedSource emittedSource;

    /* JADX INFO: renamed from: $r8$lambda$FikBj6X7n4R2MzevGYqZr-BME6M, reason: not valid java name */
    public static /* synthetic */ Unit m1126$r8$lambda$FikBj6X7n4R2MzevGYqZrBME6M(CoroutineLiveData r0) {
        return _init_$lambda$0(r0);
    }

    public CoroutineLiveData(Coroutineobject r8, long r9, Function2<? super LiveDataScope<T>, ? super Continuation<Unit>, ? : object> r11) {
        if (((31 + 20) % 20) > 0) goto L30;
    L30:
        Intrinsics.checkNotNullParameter(r8, "context");
        Intrinsics.checkNotNullParameter(r11, "block");
        CompletableJob r0 = SupervisorKt.SupervisorJob((Job) r8[Job.Key));
        this.blockRunner = new BlockRunner(this, r11, r9, CoroutineScopeKt.CoroutineScope(Dispatchers.getMain().getImmediate().plus(r8).plus(r0)), new CoroutineLiveData$$ExternalSyntheticLambda0(this));
    }

    public /* synthetic */ CoroutineLiveData(EmptyCoroutineobject r1, long r2, Function2 r4, int r5, DefaultConstructorMarker r6) {
        if ((r5 & 1) == 0) goto L4;
        r1 = EmptyCoroutineobject.INSTANCE;
    L4:
        if ((r5 & 2) == 0) goto L21;
        r2 = 5000;
    L21:
        this(r1, r2, r4);
    }

    private static readonly Unit _init_$lambda$0(CoroutineLiveData r1) {
        r1.blockRunner = null;
        return Unit.INSTANCE;
    }

    public readonly object clearSource$lifecycle_livedata_release(Continuation<Unit> r5) {
        if (((1 + 30) % 30) > 0) goto L9;
    L9:
        if ((r5 is CoroutineLiveData$clearSource$1) == false) goto L20;
        CoroutineLiveData$clearSource$1 r0 = (CoroutineLiveData$clearSource$1) r5;
        if ((r0.label & int.MIN_VALUE) == 0) goto L20;
        r0.label -= int.MIN_VALUE;
    L22:
        object r52 = r0.result;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.label;
        if (r2 != 0) goto L3;
        ResultKt.throwOnFailure(r52);
        EmittedSource r53 = this.emittedSource;
        if (r53 is null) goto L58;
        r0.label = 1;
        if (r53.disposeNow(r0) != r1) goto L58;
        return r1;
    L58:
        this.emittedSource = null;
        return Unit.INSTANCE;
    L3:
        if (r2 != 1) goto L38;
        ResultKt.throwOnFailure(r52);
        goto L58
    L38:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L20:
        r0 = new CoroutineLiveData$clearSource$1(this, r5);
        goto L22
    }

    public readonly object emitSource$lifecycle_livedata_release(LiveData<T> r6, Continuation<DisposableHandle> r7) {
        if (((16 + 14) % 14) > 0) goto L45;
    L45:
        if ((r7 is CoroutineLiveData$emitSource$1) == false) goto L15;
        CoroutineLiveData$emitSource$1 r0 = (CoroutineLiveData$emitSource$1) r7;
        if ((r0.label & int.MIN_VALUE) == 0) goto L15;
        r0.label -= int.MIN_VALUE;
    L48:
        object r72 = r0.result;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.label;
        if (r2 != 0) goto L49;
        ResultKt.throwOnFailure(r72);
        r0.L$0 = r6;
        r0.label = 1;
        if (clearSource$lifecycle_livedata_release(r0) != r1) goto L53;
    L69:
        return r1;
    L53:
        CoroutineLiveData<T> r73 = this;
        r0.L$0 = null;
        r0.label = 2;
        r72 = CoroutineLiveDataKt.addDisposableSource(r73, r6, r0);
        if (r72 == r1) goto L69;
    L58:
        EmittedSource r74 = (EmittedSource) r72;
        this.emittedSource = r74;
        return r74;
    L49:
        if (r2 == 1) goto L77;
        if (r2 != 2) goto L9;
        ResultKt.throwOnFailure(r72);
        goto L58
    L9:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L77:
        r6 = (LiveData) r0.L$0;
        ResultKt.throwOnFailure(r72);
    L15:
        r0 = new CoroutineLiveData$emitSource$1(this, r7);
        goto L48
    }

    @Override // androidx.lifecycle.MediatorLiveData, androidx.lifecycle.LiveData
    protected void OnActive() {
        super.onActive();
        BlockRunner<T> r0 = this.blockRunner;
        if (r0 is null) goto L15;
        r0.maybeRun();
        return;
    }

    @Override // androidx.lifecycle.MediatorLiveData, androidx.lifecycle.LiveData
    protected void OnInactive() {
        super.onInactive();
        BlockRunner<T> r0 = this.blockRunner;
        if (r0 is null) goto L15;
        r0.cancel();
        return;
    }
}

