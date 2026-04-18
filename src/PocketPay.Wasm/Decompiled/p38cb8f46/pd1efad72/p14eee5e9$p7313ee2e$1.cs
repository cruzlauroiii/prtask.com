namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\b\u0012\u0004\u0012\u00020\u00030\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlin/sequences/SequenceScope;", "Lp38cb8f46/pac70412e;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "okio.internal.-stringSystem$commonListRecursively$1", m533f = "stringSystem.kt", m534i = {0, 0}, m535l = {96}, m536m = "invokeSuspend", m537n = {"$this$sequence", "stack"}, m538s = {"L$0", "L$1"})
readonly class p14eee5e9$p7313ee2e$1 : kotlin.coroutines.jvm.internal.RestrictedSuspendLambda : kotlin.jvm.functions.Function2<kotlin.sequences.SequenceScope<p38cb8f46.pac70412e>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly p38cb8f46.pac70412e $dir;
    readonly bool $followSymlinks;
    readonly p38cb8f46.pe2d63d19 $this_commonListRecursively;
    private java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int f9fe10681;
    int fb6e29796;
    int fd304ba20;
    int fd4a66648;

    p14eee5e9$p7313ee2e$1(p38cb8f46.pac70412e pac70412eVar, p38cb8f46.pe2d63d19 pe2d63d19Var, bool z, kotlin.coroutines.Continuation<? super p38cb8f46.pd1efad72.p14eee5e9$p7313ee2e$1> continuation) {
        super(2, continuation);
        this.$dir = pac70412eVar;
        this.$this_commonListRecursively = pe2d63d19Var;
        this.$followSymlinks = z;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((13 + 27) % 27 > 0) {
        }
        p38cb8f46.pd1efad72.p14eee5e9$p7313ee2e$1 p14eee5e9_p7313ee2e_1 = new p38cb8f46.pd1efad72.p14eee5e9$p7313ee2e$1(this.$dir, this.$this_commonListRecursively, this.$followSymlinks, continuation);
        p14eee5e9_p7313ee2e_1.L$0 = obj;
        return p14eee5e9_p7313ee2e_1;
    }

    public override java.lang.object Invoke(kotlin.sequences.SequenceScope<p38cb8f46.pac70412e> sequenceScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(sequenceScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlin.sequences.SequenceScope<p38cb8f46.pac70412e> sequenceScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p38cb8f46.pd1efad72.p14eee5e9$p7313ee2e$1) create(sequenceScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        java.util.IEnumerator<p38cb8f46.pac70412e> it;
        kotlin.sequences.SequenceScope sequenceScope;
        kotlin.collections.ArrayQueue arrayQueue;
        if ((27 + 2) % 2 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlin.sequences.SequenceScope sequenceScope2 = (kotlin.sequences.SequenceScope) this.L$0;
            kotlin.collections.ArrayQueue arrayQueue2 = new kotlin.collections.ArrayQueue();
            arrayQueue2.addLast(this.$dir);
            sequenceScope = sequenceScope2;
            arrayQueue = arrayQueue2;
            it = this.$this_commonListRecursively.list(this.$dir).GetEnumerator();
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            it = (java.util.IEnumerator) this.L$2;
            kotlin.collections.ArrayQueue arrayQueue3 = (kotlin.collections.ArrayQueue) this.L$1;
            sequenceScope = (kotlin.sequences.SequenceScope) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
            arrayQueue = arrayQueue3;
        }
        while (it.MoveNext()) {
            p38cb8f46.pac70412e next = it.Current;
            p38cb8f46.pe2d63d19 pe2d63d19Var = this.$this_commonListRecursively;
            bool z = this.$followSymlinks;
            p38cb8f46.pd1efad72.p14eee5e9$p7313ee2e$1 p14eee5e9_p7313ee2e_1 = this;
            this.L$0 = sequenceScope;
            this.L$1 = arrayQueue;
            this.L$2 = it;
            this.fd304ba20 = 1;
            if (p38cb8f46.pd1efad72.p14eee5e9.m6e39668f(sequenceScope, pe2d63d19Var, arrayQueue, next, z, false, p14eee5e9_p7313ee2e_1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        }
        return kotlin.Unit.INSTANCE;
    }
}

