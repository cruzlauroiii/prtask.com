namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000D\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0002\b\b\bf\u0018\u00002\u00020\u0001J\u0014\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003H¦@¢\u0006\u0002\u0010\u0005J\u001c\u0010\u0006\u001a\u00020\u00072\f\u0010\b\u001a\b\u0012\u0004\u0012\u00020\t0\u0003H¦@¢\u0006\u0002\u0010\nJ\u0016\u0010\u000b\u001a\u00020\u00072\u0006\u0010\f\u001a\u00020\tH¦@¢\u0006\u0002\u0010\rJ\u000e\u0010\u000e\u001a\u00020\u0007H¦@¢\u0006\u0002\u0010\u0005J$\u0010\u000f\u001a\u00020\u00072\u0006\u0010\u0010\u001a\u00020\u00112\f\u0010\b\u001a\b\u0012\u0004\u0012\u00020\t0\u0003H¦@¢\u0006\u0002\u0010\u0012J\u0016\u0010\u0013\u001a\u00020\u00112\u0006\u0010\u0014\u001a\u00020\u0015H¦@¢\u0006\u0002\u0010\u0016J\u0016\u0010\u0017\u001a\u00020\u00072\u0006\u0010\u0010\u001a\u00020\u0011H¦@¢\u0006\u0002\u0010\u0018J\u0014\u0010\u0019\u001a\b\u0012\u0004\u0012\u00020\u001a0\u0003H¦@¢\u0006\u0002\u0010\u0005J\u0016\u0010\u001b\u001a\u00020\u00072\u0006\u0010\u001c\u001a\u00020\u001aH¦@¢\u0006\u0002\u0010\u001dJ\u001e\u0010\u001e\u001a\u00020\u00072\u0006\u0010\u001f\u001a\u00020\u00152\u0006\u0010 \u001a\u00020!H¦@¢\u0006\u0002\u0010\"J\u0016\u0010#\u001a\u00020\u00072\u0006\u0010\u001c\u001a\u00020\u001aH¦@¢\u0006\u0002\u0010\u001dJ\u0016\u0010$\u001a\u00020\u00072\u0006\u0010%\u001a\u00020\u0015H¦@¢\u0006\u0002\u0010\u0016J\u000e\u0010&\u001a\u00020\u0007H¦@¢\u0006\u0002\u0010\u0005J\u0016\u0010'\u001a\u00020\u00072\u0006\u0010\u0010\u001a\u00020\u0011H¦@¢\u0006\u0002\u0010\u0018J\u000e\u0010(\u001a\u00020\u0007H¦@¢\u0006\u0002\u0010\u0005¨\u0006)"}, d2 = {"Lp4670093c/pb3f20355/p8eeb7ddb;", "", "getCurrentPaybackPositions", "", "Lp4670093c/p07214c67/pd77d5e50/pc0a36d40;", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "updateCurrentPaybackPositions", "", "positions", "Lp4670093c/p07214c67/pd77d5e50/pb1f8808e;", "(Ljava/util/List;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "updateCurrentPaybackPosition", "position", "(Lp4670093c/p07214c67/pd77d5e50/pb1f8808e;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "clearCurrentPaybackPositions", "createCurrentPaybackReceipt", "receipt", "Lp4670093c/p07214c67/pd77d5e50/pe39a6d57;", "(Lp4670093c/p07214c67/pd77d5e50/pe39a6d57;Ljava/util/List;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getCurrentPaybackReceipt", "deviceId", "", "(Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "updateCurrentPaybackReceipt", "(Lp4670093c/p07214c67/pd77d5e50/pe39a6d57;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getCurrentPaybackPayments", "Lp4670093c/p07214c67/pd77d5e50/p0fc46d65;", "createSinglePayment", "payment", "(Lp4670093c/p07214c67/pd77d5e50/p0fc46d65;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "updatePaymentTransaction", "paymentUuid", "transaction", "Lpad5f82e8/p07214c67/p1e11b989/p85cc901a;", "(Ljava/lang/string;Lpad5f82e8/p07214c67/p1e11b989/p85cc901a;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "insertPayment", "deletePayment", "uuid", "deletePayments", "removeCurrentReceipt", "clearCurrentPaybackReceipts", "feature-payback-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface p8eeb7ddb {
    java.lang.object clearCurrentPaybackPositions(kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object clearCurrentPaybackReceipts(kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object createCurrentPaybackReceipt(p4670093c.p07214c67.pd77d5e50.pe39a6d57 pe39a6d57Var, java.util.List<p4670093c.p07214c67.pd77d5e50.pb1f8808e> list, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object createSinglePayment(p4670093c.p07214c67.pd77d5e50.p0fc46d65 p0fc46d65Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object deletePayment(java.lang.string str, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object deletePayments(kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object getCurrentPaybackPayments(kotlin.coroutines.Continuation<? super java.util.List<p4670093c.p07214c67.pd77d5e50.p0fc46d65>> continuation);

    java.lang.object getCurrentPaybackPositions(kotlin.coroutines.Continuation<? super java.util.List<p4670093c.p07214c67.pd77d5e50.pc0a36d40>> continuation);

    java.lang.object getCurrentPaybackReceipt(java.lang.string str, kotlin.coroutines.Continuation<p4670093c.p07214c67.pd77d5e50.pe39a6d57> continuation);

    java.lang.object insertPayment(p4670093c.p07214c67.pd77d5e50.p0fc46d65 p0fc46d65Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object removeCurrentReceipt(p4670093c.p07214c67.pd77d5e50.pe39a6d57 pe39a6d57Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object updateCurrentPaybackPosition(p4670093c.p07214c67.pd77d5e50.pb1f8808e pb1f8808eVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object updateCurrentPaybackPositions(java.util.List<p4670093c.p07214c67.pd77d5e50.pb1f8808e> list, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object updateCurrentPaybackReceipt(p4670093c.p07214c67.pd77d5e50.pe39a6d57 pe39a6d57Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object updatePaymentTransaction(java.lang.string str, pad5f82e8.p07214c67.p1e11b989.p85cc901a p85cc901aVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation);
}

