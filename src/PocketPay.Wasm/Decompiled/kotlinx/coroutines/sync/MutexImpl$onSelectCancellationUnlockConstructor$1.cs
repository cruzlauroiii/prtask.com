namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\u0010\u0000\u001a\u000e\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u00020\u00030\u00012\n\u0010\u0004\u001a\u0006\u0012\u0002\b\u00030\u00052\b\u0010\u0006\u001a\u0004\u0018\u00010\u00072\b\u0010\b\u001a\u0004\u0018\u00010\u0007H\n¢\u0006\u0002\b\t"}, d2 = {"<anonymous>", "Lkotlin/Function1;", "", "", "<anonymous parameter 0>", "Lkotlinx/coroutines/selects/SelectInstance;", "owner", "", "<anonymous parameter 2>", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class MutexImpl$onSelectCancellationUnlockConstructor$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function3<kotlinx.coroutines.selects.SelectInstance<object>, java.lang.object, java.lang.object, kotlin.jvm.functions.Function1<? super java.lang.Exception, ? : kotlin.Unit>> {
    readonly kotlinx.coroutines.sync.MutexImpl this$0;

    MutexImpl$onSelectCancellationUnlockConstructor$1(kotlinx.coroutines.sync.MutexImpl mutexImpl) {
        super(3);
        this.this$0 = mutexImpl;
    }

    public kotlin.jvm.functions.Function1<? super java.lang.Exception, ? : kotlin.Unit> invoke(kotlinx.coroutines.selects.SelectInstance<object> selectInstance, java.lang.object obj, java.lang.object obj2) {
        return invoke2(selectInstance, obj, obj2);
    }

    public override readonly kotlin.jvm.functions.Function1<java.lang.Exception, kotlin.Unit> Invoke2(kotlinx.coroutines.selects.SelectInstance<object> selectInstance, java.lang.object obj, java.lang.object obj2) {
        return new kotlinx.coroutines.sync.MutexImpl$onSelectCancellationUnlockConstructor$1$1(this.this$0, obj);
    }
}

