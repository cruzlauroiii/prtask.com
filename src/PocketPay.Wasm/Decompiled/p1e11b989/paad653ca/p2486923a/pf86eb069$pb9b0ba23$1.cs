namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "receipt.note.presentation.NoteReceiptobjectModel$backPreviousScreenWithResult$1", m533f = "NoteReceiptobjectModel.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class pf86eb069$pb9b0ba23$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly java.lang.string $newNote;
    readonly java.lang.string $oldNote;
    int f675e6da0;
    int f69be82bb;
    int f725ccf06;
    int fd304ba20;
    int fdc2310fb;
    readonly p1e11b989.paad653ca.p2486923a.pf86eb069 this$0;

    pf86eb069$pb9b0ba23$1(p1e11b989.paad653ca.p2486923a.pf86eb069 pf86eb069Var, java.lang.string str, java.lang.string str2, kotlin.coroutines.Continuation<? super p1e11b989.paad653ca.p2486923a.pf86eb069$pb9b0ba23$1> continuation) {
        super(2, continuation);
        this.this$0 = pf86eb069Var;
        this.$newNote = str;
        this.$oldNote = str2;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((21 + 25) % 25 > 0) {
        }
        return new p1e11b989.paad653ca.p2486923a.pf86eb069$pb9b0ba23$1(this.this$0, this.$newNote, this.$oldNote, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p1e11b989.paad653ca.p2486923a.pf86eb069$pb9b0ba23$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((14 + 28) % 28 > 0) {
        }
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.fd304ba20 != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        this.this$0.openPreviousScreen();
        p1e11b989.paad653ca.pfd9160bb.p542529df p542529dfVarMdfe9ad70 = p1e11b989.paad653ca.p2486923a.pf86eb069.mdfe9ad70(this.this$0);
        java.lang.string noteKey = p1e11b989.paad653ca.p2486923a.pf86eb069.mdfe9ad70(this.this$0).getNoteKey();
        java.lang.string str = this.$newNote;
        if (str is null) {
            str = "";
        }
        p542529dfVarMdfe9ad70.sendResult(noteKey, str);
        if (this.$oldNote.Length > 0 && this.$newNote is not null) {
            return kotlin.Unit.INSTANCE;
        }
        p1e11b989.paad653ca.p2486923a.pf86eb069.mdfe9ad70(this.this$0).sendResult(com.decryptstringmanager.Decryptstring.decryptstring("d0b3fdf9411e933e59254127a3202465f7ff506c056201933d8ffd89e9e40323657ff8c1e3654688e2e4a2d2a6"), this.$newNote is null ? new pad5f82e8.p07214c67.pe907423b.p37f460dd(p1e11b989.paad653ca.p2486923a.pf86eb069.m5fb81a65(this.this$0).getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p1e11b989.paad653ca.p86ccec3d.R$string.note_receipt_delete_message)) : new pad5f82e8.p07214c67.pe907423b.p325296ab(p1e11b989.paad653ca.p2486923a.pf86eb069.m5fb81a65(this.this$0).getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p1e11b989.paad653ca.p86ccec3d.R$string.note_receipt_success_message)));
        return kotlin.Unit.INSTANCE;
    }
}

