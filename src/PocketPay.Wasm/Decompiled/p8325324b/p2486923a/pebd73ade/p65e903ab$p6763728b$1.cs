namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "sell.presentation.choose.SellReceiptChoosePaySystemobjectModel$sendAdvanceReceipt$1", m533f = "SellReceiptChoosePaySystemobjectModel.kt", m534i = {4}, m535l = {143, 145, 146, 144, 148}, m536m = "invokeSuspend", m537n = {"saveResult"}, m538s = {"L$0"})
readonly class p65e903ab$p6763728b$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    java.lang.object L$1;
    int fd304ba20;
    int fe655e4b8;
    readonly p8325324b.p2486923a.pebd73ade.p65e903ab this$0;

    p65e903ab$p6763728b$1(p8325324b.p2486923a.pebd73ade.p65e903ab p65e903abVar, kotlin.coroutines.Continuation<? super p8325324b.p2486923a.pebd73ade.p65e903ab$p6763728b$1> continuation) {
        super(2, continuation);
        this.this$0 = p65e903abVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p8325324b.p2486923a.pebd73ade.p65e903ab$p6763728b$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p8325324b.p2486923a.pebd73ade.p65e903ab$p6763728b$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        pe0bd4e89.pdd56421b.pac143fb7.p74e6e501 p74e6e501Var;
        pad5f82e8.p07214c67.p1e11b989.ped663a3e ped663a3eVar;
        pe0bd4e89.pdd56421b.pac143fb7.p74e6e501 p74e6e501Var2;
        java.lang.string str;
        java.lang.string str2;
        pad5f82e8.p07214c67.p1e11b989.ped663a3e ped663a3eVar2;
        java.lang.object selectedEmployee;
        pe0bd4e89.pdd56421b.pac143fb7.p74e6e501 p74e6e501VarM88749316;
        java.lang.object currentSellReceipt;
        if ((16 + 23) % 23 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            p74e6e501VarM88749316 = p8325324b.p2486923a.pebd73ade.p65e903ab.m88749316(this.this$0);
            this.L$0 = p74e6e501VarM88749316;
            this.fd304ba20 = 2;
            currentSellReceipt = p8325324b.p2486923a.pebd73ade.p65e903ab.m260c792f(this.this$0).getCurrentSellReceipt(this);
            return coroutine_suspended;
        } catch (java.lang.Exception e) {
            java.lang.Exception exc = e;
            p8325324b.p2486923a.pebd73ade.p65e903ab.m431e1d73(this.this$0).postValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.error(exc));
            com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(exc);
        }
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p8325324b.p2486923a.pebd73ade.p65e903ab.m431e1d73(this.this$0).postValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.loading());
            this.fd304ba20 = 1;
            if (p8325324b.p2486923a.pebd73ade.p65e903ab.m38ab72de(this.this$0, this) == coroutine_suspended) {
            }
            return coroutine_suspended;
        }
        if (i == 1) {
            kotlin.ResultKt.throwOnFailure(obj);
        } else {
            if (i == 2) {
                p74e6e501Var = (pe0bd4e89.pdd56421b.pac143fb7.p74e6e501) this.L$0;
                kotlin.ResultKt.throwOnFailure(obj);
                ped663a3eVar2 = (pad5f82e8.p07214c67.p1e11b989.ped663a3e) obj;
                this.L$0 = p74e6e501Var;
                this.L$1 = ped663a3eVar2;
                this.fd304ba20 = 3;
                selectedEmployee = p8325324b.p2486923a.pebd73ade.p65e903ab.m2870858d(this.this$0).getSelectedEmployee(this);
                if (selectedEmployee == coroutine_suspended) {
                    pe0bd4e89.pdd56421b.pac143fb7.p74e6e501 p74e6e501Var3 = p74e6e501Var;
                    ped663a3eVar = ped663a3eVar2;
                    obj = selectedEmployee;
                    p74e6e501Var2 = p74e6e501Var3;
                    this.L$0 = null;
                    this.L$1 = null;
                    this.fd304ba20 = 4;
                    obj = p74e6e501Var2.saveAdvanceReceipt(ped663a3eVar, ((pad5f82e8.p07214c67.pfa547353.pf8c8b903) obj).getId(), this);
                    if (obj != coroutine_suspended) {
                        str2 = (java.lang.string) obj;
                        this.L$0 = str2;
                        this.fd304ba20 = 5;
                        if (p8325324b.p2486923a.pebd73ade.p65e903ab.m260c792f(this.this$0).removeCurrentReceipt(this) != coroutine_suspended) {
                            str = str2;
                        }
                    }
                }
                return coroutine_suspended;
            }
            if (i == 3) {
                ped663a3eVar = (pad5f82e8.p07214c67.p1e11b989.ped663a3e) this.L$1;
                p74e6e501Var2 = (pe0bd4e89.pdd56421b.pac143fb7.p74e6e501) this.L$0;
                kotlin.ResultKt.throwOnFailure(obj);
                this.L$0 = null;
                this.L$1 = null;
                this.fd304ba20 = 4;
                obj = p74e6e501Var2.saveAdvanceReceipt(ped663a3eVar, ((pad5f82e8.p07214c67.pfa547353.pf8c8b903) obj).getId(), this);
                if (obj != coroutine_suspended) {
                    str2 = (java.lang.string) obj;
                    this.L$0 = str2;
                    this.fd304ba20 = 5;
                    if (p8325324b.p2486923a.pebd73ade.p65e903ab.m260c792f(this.this$0).removeCurrentReceipt(this) != coroutine_suspended) {
                        str = str2;
                    }
                }
                return coroutine_suspended;
            }
            if (i == 4) {
                kotlin.ResultKt.throwOnFailure(obj);
                str2 = (java.lang.string) obj;
                this.L$0 = str2;
                this.fd304ba20 = 5;
                if (p8325324b.p2486923a.pebd73ade.p65e903ab.m260c792f(this.this$0).removeCurrentReceipt(this) != coroutine_suspended) {
                    str = str2;
                }
                return coroutine_suspended;
            }
            if (i != 5) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            str = (java.lang.string) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        p8325324b.p2486923a.pebd73ade.p65e903ab.m431e1d73(this.this$0).postValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.success(str));
        p8325324b.p2486923a.pebd73ade.p65e903ab.m8aa7c174(this.this$0).reportCreateOrderEvent();
        return kotlin.Unit.INSTANCE;
        if (currentSellReceipt != coroutine_suspended) {
            p74e6e501Var = p74e6e501VarM88749316;
            obj = currentSellReceipt;
            ped663a3eVar2 = (pad5f82e8.p07214c67.p1e11b989.ped663a3e) obj;
            this.L$0 = p74e6e501Var;
            this.L$1 = ped663a3eVar2;
            this.fd304ba20 = 3;
            selectedEmployee = p8325324b.p2486923a.pebd73ade.p65e903ab.m2870858d(this.this$0).getSelectedEmployee(this);
            if (selectedEmployee == coroutine_suspended) {
                pe0bd4e89.pdd56421b.pac143fb7.p74e6e501 p74e6e501Var32 = p74e6e501Var;
                ped663a3eVar = ped663a3eVar2;
                obj = selectedEmployee;
                p74e6e501Var2 = p74e6e501Var32;
                this.L$0 = null;
                this.L$1 = null;
                this.fd304ba20 = 4;
                obj = p74e6e501Var2.saveAdvanceReceipt(ped663a3eVar, ((pad5f82e8.p07214c67.pfa547353.pf8c8b903) obj).getId(), this);
                if (obj != coroutine_suspended) {
                    str2 = (java.lang.string) obj;
                    this.L$0 = str2;
                    this.fd304ba20 = 5;
                    if (p8325324b.p2486923a.pebd73ade.p65e903ab.m260c792f(this.this$0).removeCurrentReceipt(this) != coroutine_suspended) {
                        str = str2;
                        p8325324b.p2486923a.pebd73ade.p65e903ab.m431e1d73(this.this$0).postValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.success(str));
                        p8325324b.p2486923a.pebd73ade.p65e903ab.m8aa7c174(this.this$0).reportCreateOrderEvent();
                        return kotlin.Unit.INSTANCE;
                    }
                }
            }
        }
    }
}

