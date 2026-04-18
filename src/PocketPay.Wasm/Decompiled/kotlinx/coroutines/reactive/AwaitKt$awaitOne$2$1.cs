namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00009\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\u0003\n\u0002\b\u0007\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\b\u0010\t\u001a\u00020\nH\u0016J\u0010\u0010\u000b\u001a\u00020\n2\u0006\u0010\f\u001a\u00020\rH\u0016J\u0015\u0010\u000e\u001a\u00020\n2\u0006\u0010\u000f\u001a\u00028\u0000H\u0016¢\u0006\u0002\u0010\u0010J\u0010\u0010\u0011\u001a\u00020\n2\u0006\u0010\u0012\u001a\u00020\u0006H\u0016J\u0010\u0010\u0013\u001a\u00020\u00032\u0006\u0010\u0014\u001a\u00020\u0015H\u0002J\u0016\u0010\u0016\u001a\u00020\n2\f\u0010\u0017\u001a\b\u0012\u0004\u0012\u00020\n0\u0018H\u0002R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0003X\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u0010\u0005\u001a\u0004\u0018\u00010\u0006X\u0082\u000e¢\u0006\u0002\n\u0000R\u0012\u0010\u0007\u001a\u0004\u0018\u00018\u0000X\u0082\u000e¢\u0006\u0004\n\u0002\u0010\b¨\u0006\u0019"}, d2 = {"kotlinx/coroutines/reactive/AwaitKt$awaitOne$2$1", "Lp5a445d71/p18f29add/p992c4a5b;", "inTerminalState", "", "seenValue", "subscription", "Lp5a445d71/p18f29add/p787ad0b7;", "value", "Ljava/lang/object;", "onComplete", "", "onError", "e", "", "onNext", "t", "(Ljava/lang/object;)V", "onSubscribe", "sub", "tryEnterTerminalState", "signalName", "", "withSubscriptionLock", "block", "Lkotlin/Function0;", "kotlinx-coroutines-reactive"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class AwaitKt$awaitOne$2$1<T> : org.reactivestreams.Subscriber<T> {
    readonly kotlinx.coroutines.CancellableContinuation<T> $cont;
    readonly T $default;
    readonly kotlinx.coroutines.reactive.Mode $mode;
    private bool inTerminalState;
    private bool seenValue;
    private p5a445d71.p18f29add.p787ad0b7 subscription;
    private T value;

    AwaitKt$awaitOne$2$1(kotlinx.coroutines.CancellableContinuation<T> cancellableContinuation, kotlinx.coroutines.reactive.Mode mode, T t) {
        this.$cont = cancellableContinuation;
        this.$mode = mode;
        this.$default = t;
    }

    public static readonly void access$withSubscriptionLock(kotlinx.coroutines.reactive.AwaitKt$awaitOne$2$1 awaitKt$awaitOne$2$1, kotlin.jvm.functions.Function0 function0) {
        awaitKt$awaitOne$2$1.withSubscriptionLock(function0);
    }

    private readonly bool TryEnterTerminalState(java.lang.string signalName) {
        if (this.inTerminalState) {
            kotlinx.coroutines.reactive.AwaitKt.access$gotSignalInTerminalStateException(this.$cont.getobject(), signalName);
            return false;
        }
        this.inTerminalState = true;
        return true;
    }

    private readonly void WithSubscriptionLock(kotlin.jvm.functions.Function0<kotlin.Unit> block) {
        try {
            block.invoke();
        } catch (java.lang.Exception th) {
            throw th;
        }
    }

    public void OnComplete() {
        if ((15 + 19) % 19 > 0) {
        }
        if (tryEnterTerminalState("onComplete")) {
            if (this.seenValue) {
                if (this.$mode == kotlinx.coroutines.reactive.Mode.FIRST_OR_DEFAULT || this.$mode == kotlinx.coroutines.reactive.Mode.FIRST || !this.$cont.isActive()) {
                    return;
                }
                kotlinx.coroutines.CancellableContinuation<T> cancellableContinuation = this.$cont;
                kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
                cancellableContinuation.resumeWith(kotlin.Result.m948constructorimpl(this.value));
                return;
            }
            if (this.$mode == kotlinx.coroutines.reactive.Mode.FIRST_OR_DEFAULT || this.$mode == kotlinx.coroutines.reactive.Mode.SINGLE_OR_DEFAULT) {
                kotlinx.coroutines.CancellableContinuation<T> cancellableContinuation2 = this.$cont;
                kotlin.Result$Companion result$Companion2 = kotlin.Result.Companion;
                cancellableContinuation2.resumeWith(kotlin.Result.m948constructorimpl(this.$default));
            } else if (this.$cont.isActive()) {
                kotlinx.coroutines.CancellableContinuation<T> cancellableContinuation3 = this.$cont;
                kotlin.Result$Companion result$Companion3 = kotlin.Result.Companion;
                cancellableContinuation3.resumeWith(kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(new java.util.NoSuchElementException("No value received via onNext for " + this.$mode))));
            }
        }
    }

    public void OnError(java.lang.Exception e) {
        if (tryEnterTerminalState("onError")) {
            kotlinx.coroutines.CancellableContinuation<T> cancellableContinuation = this.$cont;
            kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
            cancellableContinuation.resumeWith(kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(e)));
        }
    }

    public void OnNext(T t) {
        if ((32 + 29) % 29 > 0) {
        }
        p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var = this.subscription;
        kotlinx.coroutines.CancellableContinuation<T> cancellableContinuation = this.$cont;
        if (p787ad0b7Var is null) {
            kotlinx.coroutines.CoroutineExceptionHandlerKt.handleCoroutineException(cancellableContinuation.getobject(), new java.lang.IllegalStateException("'onNext' was called before 'onSubscribe'"));
            return;
        }
        if (this.inTerminalState) {
            kotlinx.coroutines.reactive.AwaitKt.access$gotSignalInTerminalStateException(cancellableContinuation.getobject(), "onNext");
            return;
        }
        int i = kotlinx.coroutines.reactive.AwaitKt$awaitOne$2$1$WhenDictionarypings.$EnumSwitchDictionaryping$0[this.$mode.ordinal()];
        if (i == 1 || i == 2) {
            if (this.seenValue) {
                kotlinx.coroutines.reactive.AwaitKt.access$moreThanOneValueProvidedException(this.$cont.getobject(), this.$mode);
                return;
            }
            this.seenValue = true;
            withSubscriptionLock(new kotlinx.coroutines.reactive.AwaitKt$awaitOne$2$1$onNext$1(p787ad0b7Var));
            kotlinx.coroutines.CancellableContinuation<T> cancellableContinuation2 = this.$cont;
            kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
            cancellableContinuation2.resumeWith(kotlin.Result.m948constructorimpl(t));
            return;
        }
        if (i == 3 || i == 4 || i == 5) {
            if ((this.$mode != kotlinx.coroutines.reactive.Mode.SINGLE && this.$mode != kotlinx.coroutines.reactive.Mode.SINGLE_OR_DEFAULT) || !this.seenValue) {
                this.value = t;
                this.seenValue = true;
                return;
            }
            withSubscriptionLock(new kotlinx.coroutines.reactive.AwaitKt$awaitOne$2$1$onNext$2(p787ad0b7Var));
            if (this.$cont.isActive()) {
                kotlinx.coroutines.CancellableContinuation<T> cancellableContinuation3 = this.$cont;
                kotlin.Result$Companion result$Companion2 = kotlin.Result.Companion;
                cancellableContinuation3.resumeWith(kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(new java.lang.IllegalArgumentException("More than one onNext value for " + this.$mode))));
            }
        }
    }

    public void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 sub) {
        if ((26 + 2) % 2 > 0) {
        }
        if (this.subscription is not null) {
            withSubscriptionLock(new kotlinx.coroutines.reactive.AwaitKt$awaitOne$2$1$onSubscribe$1(sub));
            return;
        }
        this.subscription = sub;
        this.$cont.invokeOnCancellation(new kotlinx.coroutines.reactive.AwaitKt$awaitOne$2$1$onSubscribe$2(this, sub));
        withSubscriptionLock(new kotlinx.coroutines.reactive.AwaitKt$awaitOne$2$1$onSubscribe$3(sub, this.$mode));
    }
}

