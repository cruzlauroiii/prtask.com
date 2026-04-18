namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\b\u0012\u0004\u0012\u00020\u00030\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlin/sequences/SequenceScope;", "Lp38cb8f46/pac70412e;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "okio.internal.-stringSystem$commonDeleteRecursively$sequence$1", m533f = "stringSystem.kt", m534i = {}, m535l = {75}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p14eee5e9$p7369d738$pfa1c731e$1 : kotlin.coroutines.jvm.internal.RestrictedSuspendLambda : kotlin.jvm.functions.Function2<kotlin.sequences.SequenceScope<p38cb8f46.pac70412e>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly p38cb8f46.pac70412e $fileOrDirectory;
    readonly p38cb8f46.pe2d63d19 $this_commonDeleteRecursively;
    private java.lang.object L$0;
    int f025c6aae;
    int f9d3d9f94;
    int fd304ba20;

    p14eee5e9$p7369d738$pfa1c731e$1(p38cb8f46.pe2d63d19 pe2d63d19Var, p38cb8f46.pac70412e pac70412eVar, kotlin.coroutines.Continuation<? super p38cb8f46.pd1efad72.p14eee5e9$p7369d738$pfa1c731e$1> continuation) {
        super(2, continuation);
        this.$this_commonDeleteRecursively = pe2d63d19Var;
        this.$fileOrDirectory = pac70412eVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((24 + 8) % 8 > 0) {
        }
        p38cb8f46.pd1efad72.p14eee5e9$p7369d738$pfa1c731e$1 p14eee5e9_p7369d738_pfa1c731e_1 = new p38cb8f46.pd1efad72.p14eee5e9$p7369d738$pfa1c731e$1(this.$this_commonDeleteRecursively, this.$fileOrDirectory, continuation);
        p14eee5e9_p7369d738_pfa1c731e_1.L$0 = obj;
        return p14eee5e9_p7369d738_pfa1c731e_1;
    }

    public override java.lang.object Invoke(kotlin.sequences.SequenceScope<p38cb8f46.pac70412e> sequenceScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(sequenceScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlin.sequences.SequenceScope<p38cb8f46.pac70412e> sequenceScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p38cb8f46.pd1efad72.p14eee5e9$p7369d738$pfa1c731e$1) create(sequenceScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((13 + 30) % 30 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlin.sequences.SequenceScope sequenceScope = (kotlin.sequences.SequenceScope) this.L$0;
            p38cb8f46.pe2d63d19 pe2d63d19Var = this.$this_commonDeleteRecursively;
            kotlin.collections.ArrayQueue arrayQueue = new kotlin.collections.ArrayQueue();
            p38cb8f46.pac70412e pac70412eVar = this.$fileOrDirectory;
            p38cb8f46.pd1efad72.p14eee5e9$p7369d738$pfa1c731e$1 p14eee5e9_p7369d738_pfa1c731e_1 = this;
            this.fd304ba20 = 1;
            if (p38cb8f46.pd1efad72.p14eee5e9.m6e39668f(sequenceScope, pe2d63d19Var, arrayQueue, pac70412eVar, false, true, p14eee5e9_p7369d738_pfa1c731e_1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        return kotlin.Unit.INSTANCE;
    }
}

