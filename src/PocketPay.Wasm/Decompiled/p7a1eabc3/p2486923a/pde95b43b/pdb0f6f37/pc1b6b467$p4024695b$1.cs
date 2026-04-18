namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "inventory.presentation.edit.group.InventoryGroupEditobjectModel$editInventoryGroupName$1", m533f = "InventoryGroupEditobjectModel.kt", m534i = {}, m535l = {61}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class pc1b6b467$p4024695b$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly java.lang.string $parentId;
    java.lang.object L$0;
    int f14349ee5;
    int f38c4e087;
    int f5ec9ca75;
    int fd304ba20;
    readonly p7a1eabc3.p2486923a.pde95b43b.pdb0f6f37.pc1b6b467 this$0;

    pc1b6b467$p4024695b$1(p7a1eabc3.p2486923a.pde95b43b.pdb0f6f37.pc1b6b467 pc1b6b467Var, java.lang.string str, kotlin.coroutines.Continuation<? super p7a1eabc3.p2486923a.pde95b43b.pdb0f6f37.pc1b6b467$p4024695b$1> continuation) {
        super(2, continuation);
        this.this$0 = pc1b6b467Var;
        this.$parentId = str;
    }

    public static androidx.lifecycle.MutableLiveData AwQdJbVzPfxlLFvx(p7a1eabc3.p2486923a.pde95b43b.pdb0f6f37.pc1b6b467 pc1b6b467Var) {
        return p7a1eabc3.p2486923a.pde95b43b.pdb0f6f37.pc1b6b467.m200ccad8(pc1b6b467Var);
    }

    public static java.lang.object BOZnqGZVtqpUfxVF() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void DNakVBxusZKBOVbG(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object EBmaejjfiCSZlECd(p7a1eabc3.p2486923a.pde95b43b.pdb0f6f37.pc1b6b467$p4024695b$1 pc1b6b467_p4024695b_1, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return pc1b6b467_p4024695b_1.invoke2(coroutineScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static void NdkColwGoLKnxPZU(androidx.lifecycle.MutableLiveData mutableLiveData, java.lang.object obj) {
        mutableLiveData.postValue(obj);
    }

    public static java.lang.object TLkAEwFTVFCpkvrx(p7a1eabc3.pac143fb7.p05b57ece p05b57eceVar, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return p05b57eceVar.getGroupParentName(str, continuation);
    }

    public static void DTEjBCjqVzlHOilJ(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object MszbxCYoDJYZWJeW(p7a1eabc3.p2486923a.pde95b43b.pdb0f6f37.pc1b6b467$p4024695b$1 pc1b6b467_p4024695b_1, java.lang.object obj) {
        return pc1b6b467_p4024695b_1.invokeSuspend(obj);
    }

    public static kotlin.coroutines.Continuation OEsStiHYiKaxlbtA(p7a1eabc3.p2486923a.pde95b43b.pdb0f6f37.pc1b6b467$p4024695b$1 pc1b6b467_p4024695b_1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return pc1b6b467_p4024695b_1.create(obj, continuation);
    }

    public static p7a1eabc3.pac143fb7.p05b57ece WKTFNpBQhXueLOly(p7a1eabc3.p2486923a.pde95b43b.pdb0f6f37.pc1b6b467 pc1b6b467Var) {
        return p7a1eabc3.p2486923a.pde95b43b.pdb0f6f37.pc1b6b467.mc3d84d69(pc1b6b467Var);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p7a1eabc3.p2486923a.pde95b43b.pdb0f6f37.pc1b6b467$p4024695b$1(this.this$0, this.$parentId, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return EBmaejjfiCSZlECd(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return mszbxCYoDJYZWJeW((p7a1eabc3.p2486923a.pde95b43b.pdb0f6f37.pc1b6b467$p4024695b$1) oEsStiHYiKaxlbtA(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        androidx.lifecycle.MutableLiveData mutableLiveData;
        if ((8 + 16) % 16 > 0) {
        }
        java.lang.object objBOZnqGZVtqpUfxVF = BOZnqGZVtqpUfxVF();
        int i = this.fd304ba20;
        if (i == 0) {
            DNakVBxusZKBOVbG(obj);
            androidx.lifecycle.MutableLiveData mutableLiveDataAwQdJbVzPfxlLFvx = AwQdJbVzPfxlLFvx(this.this$0);
            p7a1eabc3.pac143fb7.p05b57ece p05b57eceVarWKTFNpBQhXueLOly = wKTFNpBQhXueLOly(this.this$0);
            java.lang.string str = this.$parentId;
            p7a1eabc3.p2486923a.pde95b43b.pdb0f6f37.pc1b6b467$p4024695b$1 pc1b6b467_p4024695b_1 = this;
            this.L$0 = mutableLiveDataAwQdJbVzPfxlLFvx;
            this.fd304ba20 = 1;
            java.lang.object objTLkAEwFTVFCpkvrx = TLkAEwFTVFCpkvrx(p05b57eceVarWKTFNpBQhXueLOly, str, pc1b6b467_p4024695b_1);
            if (objTLkAEwFTVFCpkvrx == objBOZnqGZVtqpUfxVF) {
                return objBOZnqGZVtqpUfxVF;
            }
            obj = objTLkAEwFTVFCpkvrx;
            mutableLiveData = mutableLiveDataAwQdJbVzPfxlLFvx;
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            mutableLiveData = (androidx.lifecycle.MutableLiveData) this.L$0;
            dTEjBCjqVzlHOilJ(obj);
        }
        NdkColwGoLKnxPZU(mutableLiveData, obj);
        return kotlin.Unit.INSTANCE;
    }
}

