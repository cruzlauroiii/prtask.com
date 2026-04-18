namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0003\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\u0010\u0000\u001a\u000e\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u00020\u00030\u0001\"\u0004\b\u0000\u0010\u00042\n\u0010\u0005\u001a\u0006\u0012\u0002\b\u00030\u00062\b\u0010\u0007\u001a\u0004\u0018\u00010\b2\b\u0010\t\u001a\u0004\u0018\u00010\bH\n¢\u0006\u0002\b\n"}, d2 = {"<anonymous>", "Lkotlin/Function1;", "", "", "E", "select", "Lkotlinx/coroutines/selects/SelectInstance;", "<anonymous parameter 1>", "", "element", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class C0466xffb418de : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function3<kotlinx.coroutines.selects.SelectInstance<object>, java.lang.object, java.lang.object, kotlin.jvm.functions.Function1<? super java.lang.Exception, ? : kotlin.Unit>> {
    readonly kotlinx.coroutines.channels.BufferedChannel<E> this$0;

    C0466xffb418de(kotlinx.coroutines.channels.BufferedChannel<E> bufferedChannel) {
        super(3);
        this.this$0 = bufferedChannel;
    }

    public kotlin.jvm.functions.Function1<? super java.lang.Exception, ? : kotlin.Unit> invoke(kotlinx.coroutines.selects.SelectInstance<object> selectInstance, java.lang.object obj, java.lang.object obj2) {
        return invoke2(selectInstance, obj, obj2);
    }

    public override readonly kotlin.jvm.functions.Function1<java.lang.Exception, kotlin.Unit> Invoke2(kotlinx.coroutines.selects.SelectInstance<object> selectInstance, java.lang.object obj, java.lang.object obj2) {
        return new kotlinx.coroutines.channels.C0467xe3115deb(obj2, this.this$0, selectInstance);
    }
}

