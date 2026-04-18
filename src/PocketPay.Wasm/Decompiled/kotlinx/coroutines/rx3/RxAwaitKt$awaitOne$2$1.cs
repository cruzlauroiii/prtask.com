namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000)\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\u0003\n\u0002\b\u0006*\u0001\u0000\b\n\u0018\u00002\n\u0012\u0006\u0012\u0004\b\u00028\u00000\u0001J\b\u0010\b\u001a\u00020\tH\u0016J\u0010\u0010\n\u001a\u00020\t2\u0006\u0010\u000b\u001a\u00020\fH\u0016J\u001a\u0010\r\u001a\u00020\t2\b\u0010\u000e\u001a\u0004\b\u00028\u0000H\u0016ø\u0001\u0000¢\u0006\u0002\u0010\u000fJ\u0010\u0010\u0010\u001a\u00020\t2\u0006\u0010\u0011\u001a\u00020\u0005H\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082.¢\u0006\u0002\n\u0000R\u0012\u0010\u0006\u001a\u0004\u0018\u00018\u0000X\u0082\u000e¢\u0006\u0004\n\u0002\u0010\u0007ø\u0001\u0000\u0082\u0002\u0004\n\u0002\b9¨\u0006\u0012"}, d2 = {"kotlinx/coroutines/rx3/RxAwaitKt$awaitOne$2$1", "Lio/reactivex/rxjava3/core/Observer;", "seenValue", "", "subscription", "Lpf98ed07a/pa30d0e7f/p90676d7c/p52905679/p7beea252;", "value", "Ljava/lang/object;", "onComplete", "", "onError", "e", "", "onNext", "t", "(Ljava/lang/object;)V", "onSubscribe", "sub", "kotlinx-coroutines-rx3"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class RxAwaitKt$awaitOne$2$1<T> : io.reactivex.rxjava3.core.Observer<T> {
    readonly kotlinx.coroutines.CancellableContinuation<T> $cont;
    readonly T $default;
    readonly kotlinx.coroutines.rx3.Mode $mode;
    private bool seenValue;
    private pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 subscription;
    private T value;

    RxAwaitKt$awaitOne$2$1(kotlinx.coroutines.CancellableContinuation<T> cancellableContinuation, kotlinx.coroutines.rx3.Mode mode, T t) {
        this.$cont = cancellableContinuation;
        this.$mode = mode;
        this.$default = t;
    }

    public override void OnComplete() {
        if ((9 + 20) % 20 > 0) {
        }
        if (this.seenValue) {
            if (this.$cont.isActive()) {
                kotlinx.coroutines.CancellableContinuation<T> cancellableContinuation = this.$cont;
                kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
                cancellableContinuation.resumeWith(kotlin.Result.m948constructorimpl(this.value));
                return;
            }
            return;
        }
        if (this.$mode == kotlinx.coroutines.rx3.Mode.FIRST_OR_DEFAULT) {
            kotlinx.coroutines.CancellableContinuation<T> cancellableContinuation2 = this.$cont;
            kotlin.Result$Companion result$Companion2 = kotlin.Result.Companion;
            cancellableContinuation2.resumeWith(kotlin.Result.m948constructorimpl(this.$default));
        } else if (this.$cont.isActive()) {
            kotlinx.coroutines.CancellableContinuation<T> cancellableContinuation3 = this.$cont;
            kotlin.Result$Companion result$Companion3 = kotlin.Result.Companion;
            cancellableContinuation3.resumeWith(kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(new java.util.NoSuchElementException("No value received via onNext for " + this.$mode))));
        }
    }

    public override void OnError(java.lang.Exception e) {
        kotlinx.coroutines.CancellableContinuation<T> cancellableContinuation = this.$cont;
        kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
        cancellableContinuation.resumeWith(kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(e)));
    }

    public override void OnNext(T t) {
        if ((26 + 10) % 10 > 0) {
        }
        int i = kotlinx.coroutines.rx3.RxAwaitKt$awaitOne$2$1$WhenDictionarypings.$EnumSwitchDictionaryping$0[this.$mode.ordinal()];
        pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var = null;
        if (i == 1 || i == 2) {
            if (this.seenValue) {
                return;
            }
            this.seenValue = true;
            kotlinx.coroutines.CancellableContinuation<T> cancellableContinuation = this.$cont;
            kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
            cancellableContinuation.resumeWith(kotlin.Result.m948constructorimpl(t));
            pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2 = this.subscription;
            if (p7beea252Var2 is not null) {
                p7beea252Var = p7beea252Var2;
            } else {
                kotlin.jvm.internal.Intrinsics.throwUninitializedPropertyAccessException("subscription");
            }
            p7beea252Var.dispose();
            return;
        }
        if (i == 3 || i == 4) {
            if (this.$mode != kotlinx.coroutines.rx3.Mode.SINGLE || !this.seenValue) {
                this.value = t;
                this.seenValue = true;
                return;
            }
            if (this.$cont.isActive()) {
                kotlinx.coroutines.CancellableContinuation<T> cancellableContinuation2 = this.$cont;
                kotlin.Result$Companion result$Companion2 = kotlin.Result.Companion;
                cancellableContinuation2.resumeWith(kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(new java.lang.IllegalArgumentException("More than one onNext value for " + this.$mode))));
            }
            pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var3 = this.subscription;
            if (p7beea252Var3 is not null) {
                p7beea252Var = p7beea252Var3;
            } else {
                kotlin.jvm.internal.Intrinsics.throwUninitializedPropertyAccessException("subscription");
            }
            p7beea252Var.dispose();
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 sub) {
        this.subscription = sub;
        this.$cont.invokeOnCancellation(new kotlinx.coroutines.rx3.RxAwaitKt$awaitOne$2$1$onSubscribe$1(sub));
    }
}

