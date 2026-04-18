namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "inventory.presentation.detail.InventoryDetailobjectModel$removeCommodity$1", m533f = "InventoryDetailobjectModel.kt", m534i = {}, m535l = {48}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class pc7a824b4$pa2221e6c$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly p7a1eabc3.p07214c67.p20f35e63.p4cc9492b$pca87b160 $inventoryItem;
    int f44675d85;
    int fc1040216;
    int fd304ba20;
    readonly p7a1eabc3.p2486923a.p951da6b7.pc7a824b4 this$0;

    pc7a824b4$pa2221e6c$1(p7a1eabc3.p2486923a.p951da6b7.pc7a824b4 pc7a824b4Var, p7a1eabc3.p07214c67.p20f35e63.p4cc9492b$pca87b160 p4cc9492b_pca87b160, kotlin.coroutines.Continuation<? super p7a1eabc3.p2486923a.p951da6b7.pc7a824b4$pa2221e6c$1> continuation) {
        super(2, continuation);
        this.this$0 = pc7a824b4Var;
        this.$inventoryItem = p4cc9492b_pca87b160;
    }

    public static java.lang.string BqXYbxCVWUreXyRr(p2b3583e6.p4a931512.p2e423cc6 p2e423cc6Var, int i) {
        return p2e423cc6Var.getstring(i);
    }

    public static void ChZFTMbvKgbCQVsZ(p7a1eabc3.p2486923a.p951da6b7.pc7a824b4 pc7a824b4Var) {
        pc7a824b4Var.openPreviousScreen();
    }

    public static java.lang.object DpaqKHpQZNHZuDiX(p7a1eabc3.p2486923a.p951da6b7.pc7a824b4$pa2221e6c$1 pc7a824b4_pa2221e6c_1, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return pc7a824b4_pa2221e6c_1.invoke2(coroutineScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static p2b3583e6.p4a931512.p2e423cc6 HwJjzMpRYSQMSmyF(p7a1eabc3.p2486923a.p951da6b7.pc7a824b4 pc7a824b4Var) {
        return p7a1eabc3.p2486923a.p951da6b7.pc7a824b4.m5fb81a65(pc7a824b4Var);
    }

    public static p7a1eabc3.pfd9160bb.p939f9656 NQIiKCMdRDulrRlj(p7a1eabc3.p2486923a.p951da6b7.pc7a824b4 pc7a824b4Var) {
        return p7a1eabc3.p2486923a.p951da6b7.pc7a824b4.m74e3994c(pc7a824b4Var);
    }

    public static void NdjFajnuJUZsqcwI(androidx.lifecycle.MutableLiveData mutableLiveData, java.lang.object obj) {
        mutableLiveData.postValue(obj);
    }

    public static kotlin.coroutines.Continuation QsEbbDVebceeAJRL(p7a1eabc3.p2486923a.p951da6b7.pc7a824b4$pa2221e6c$1 pc7a824b4_pa2221e6c_1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return pc7a824b4_pa2221e6c_1.create(obj, continuation);
    }

    public static pad5f82e8.p07214c67.pa4ecfc70 QtqgpLeAJKrsjDMu(pad5f82e8.p07214c67.pa4ecfc70$p910eef8c pa4ecfc70_p910eef8c, java.lang.object obj, int i, java.lang.object obj2) {
        return pad5f82e8.p07214c67.pa4ecfc70$p910eef8c.m02f94ccf(pa4ecfc70_p910eef8c, obj, i, obj2);
    }

    public static androidx.lifecycle.MutableLiveData REHEABeIwILUYirg(p7a1eabc3.p2486923a.p951da6b7.pc7a824b4 pc7a824b4Var) {
        return p7a1eabc3.p2486923a.p951da6b7.pc7a824b4.m79e7eef2(pc7a824b4Var);
    }

    public static java.lang.object RoviuhyVGqQBTVmg(p7a1eabc3.pac143fb7.p6d73504b p6d73504bVar, p7a1eabc3.p07214c67.p20f35e63.p4cc9492b$pca87b160 p4cc9492b_pca87b160, kotlin.coroutines.Continuation continuation) {
        return p6d73504bVar.removeInventory(p4cc9492b_pca87b160, continuation);
    }

    public static void TLWbJVkhIPnadRJF(androidx.lifecycle.MutableLiveData mutableLiveData, java.lang.object obj) {
        mutableLiveData.setValue(obj);
    }

    public static pad5f82e8.p07214c67.pa4ecfc70 TpShKsPrYuNDSzny(pad5f82e8.p07214c67.pa4ecfc70$p910eef8c pa4ecfc70_p910eef8c, java.lang.Exception th) {
        return pa4ecfc70_p910eef8c.error(th);
    }

    public static androidx.lifecycle.MutableLiveData UfwvQwDfXkISGAPL(p7a1eabc3.p2486923a.p951da6b7.pc7a824b4 pc7a824b4Var) {
        return p7a1eabc3.p2486923a.p951da6b7.pc7a824b4.m31264769(pc7a824b4Var);
    }

    public static void ViYxYLxQqQLayTZL(androidx.lifecycle.MutableLiveData mutableLiveData, java.lang.object obj) {
        mutableLiveData.postValue(obj);
    }

    public static java.lang.object WVnEPNJjrcFRczTi() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static androidx.lifecycle.MutableLiveData YkRVIwTYKNjJssXF(p7a1eabc3.p2486923a.p951da6b7.pc7a824b4 pc7a824b4Var) {
        return p7a1eabc3.p2486923a.p951da6b7.pc7a824b4.m31264769(pc7a824b4Var);
    }

    public static p2b3583e6.p4a931512.p2e423cc6 BAsrQEzYTgYlNFIZ(p7a1eabc3.p2486923a.p951da6b7.pc7a824b4 pc7a824b4Var) {
        return p7a1eabc3.p2486923a.p951da6b7.pc7a824b4.m5fb81a65(pc7a824b4Var);
    }

    public static java.lang.object GjzVLtwAWVRoyAWT(p7a1eabc3.p2486923a.p951da6b7.pc7a824b4$pa2221e6c$1 pc7a824b4_pa2221e6c_1, java.lang.object obj) {
        return pc7a824b4_pa2221e6c_1.invokeSuspend(obj);
    }

    public static p7a1eabc3.pac143fb7.p6d73504b NOczCdFfLOdjFdSw(p7a1eabc3.p2486923a.p951da6b7.pc7a824b4 pc7a824b4Var) {
        return p7a1eabc3.p2486923a.p951da6b7.pc7a824b4.m0234406d(pc7a824b4Var);
    }

    public static void NpquBTBWiOQUPIGu(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.string PaofuauIOyCfzbQa(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static androidx.lifecycle.MutableLiveData QHBxOGdvZGnPyLWy(p7a1eabc3.p2486923a.p951da6b7.pc7a824b4 pc7a824b4Var) {
        return p7a1eabc3.p2486923a.p951da6b7.pc7a824b4.m31264769(pc7a824b4Var);
    }

    public static java.lang.string UOBtuHGqykWSPlRD(p2b3583e6.p4a931512.p2e423cc6 p2e423cc6Var, int i) {
        return p2e423cc6Var.getstring(i);
    }

    public static void UbOgojmlmiNdMOCA(p7a1eabc3.pfd9160bb.p939f9656 p939f9656Var, java.lang.string str, java.lang.object obj) {
        p939f9656Var.sendResult(str, obj);
    }

    public static pad5f82e8.p07214c67.pa4ecfc70 WuQZicpWKZbyQBKa(pad5f82e8.p07214c67.pa4ecfc70$p910eef8c pa4ecfc70_p910eef8c) {
        return pa4ecfc70_p910eef8c.loading();
    }

    public static void XGsqtxtPerxnhkjl(androidx.lifecycle.MutableLiveData mutableLiveData, java.lang.object obj) {
        mutableLiveData.postValue(obj);
    }

    public static void YzwGshjPSVHTajrl(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p7a1eabc3.p2486923a.p951da6b7.pc7a824b4$pa2221e6c$1(this.this$0, this.$inventoryItem, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return DpaqKHpQZNHZuDiX(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return gjzVLtwAWVRoyAWT((p7a1eabc3.p2486923a.p951da6b7.pc7a824b4$pa2221e6c$1) QsEbbDVebceeAJRL(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((15 + 17) % 17 > 0) {
        }
        java.lang.object objWVnEPNJjrcFRczTi = WVnEPNJjrcFRczTi();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                yzwGshjPSVHTajrl(obj);
                ViYxYLxQqQLayTZL(qHBxOGdvZGnPyLWy(this.this$0), wuQZicpWKZbyQBKa(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c));
                this.fd304ba20 = 1;
                if (RoviuhyVGqQBTVmg(nOczCdFfLOdjFdSw(this.this$0), this.$inventoryItem, this) == objWVnEPNJjrcFRczTi) {
                    return objWVnEPNJjrcFRczTi;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                npquBTBWiOQUPIGu(obj);
            }
            NdjFajnuJUZsqcwI(YkRVIwTYKNjJssXF(this.this$0), QtqgpLeAJKrsjDMu(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c, null, 1, null));
            ubOgojmlmiNdMOCA(NQIiKCMdRDulrRlj(this.this$0), paofuauIOyCfzbQa("5283b8df7ed3fc918202bd9df199631c456035b087608a7297ff5ff33d4c76c897382d9d4a6edadde758f5d1ad"), new pad5f82e8.p07214c67.pe907423b.p37f460dd(uOBtuHGqykWSPlRD(HwJjzMpRYSQMSmyF(this.this$0), p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p7a1eabc3.p86ccec3d.R$string.inventory_snack_remove_commodity)));
            ChZFTMbvKgbCQVsZ(this.this$0);
        } catch (java.lang.Exception e) {
            xGsqtxtPerxnhkjl(UfwvQwDfXkISGAPL(this.this$0), TpShKsPrYuNDSzny(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c, e));
            TLWbJVkhIPnadRJF(REHEABeIwILUYirg(this.this$0), new pad5f82e8.p07214c67.pe907423b.p37f460dd(BqXYbxCVWUreXyRr(bAsrQEzYTgYlNFIZ(this.this$0), p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p7a1eabc3.p86ccec3d.R$string.inventory_snack_remove_commodity_error)));
        }
        return kotlin.Unit.INSTANCE;
    }
}

