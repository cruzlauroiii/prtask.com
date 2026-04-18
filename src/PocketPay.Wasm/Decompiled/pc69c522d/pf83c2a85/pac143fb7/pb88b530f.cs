namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0007\bf\u0018\u00002\u00020\u0001J\u000e\u0010\u0002\u001a\u00020\u0003H¦@¢\u0006\u0002\u0010\u0004J\u0014\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006H¦@¢\u0006\u0002\u0010\u0004J\"\u0010\b\u001a\b\u0012\u0004\u0012\u00020\u00070\u00062\f\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006H¦@¢\u0006\u0002\u0010\nJ$\u0010\u000b\u001a\b\u0012\u0004\u0012\u00020\u00070\u00062\f\u0010\f\u001a\b\u0012\u0004\u0012\u00020\u00070\u00062\u0006\u0010\r\u001a\u00020\u000eH&J \u0010\u000f\u001a\u00020\u00102\b\u0010\u0011\u001a\u0004\u0018\u00010\u00072\f\u0010\f\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006H&J \u0010\u0012\u001a\u00020\u00072\b\u0010\u0011\u001a\u0004\u0018\u00010\u00072\f\u0010\f\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006H&J\u0016\u0010\u0013\u001a\u00020\u00142\u0006\u0010\u0015\u001a\u00020\u0016H¦@¢\u0006\u0002\u0010\u0017J\u000e\u0010\u0018\u001a\u00020\u0014H¦@¢\u0006\u0002\u0010\u0004J\u0016\u0010\u0019\u001a\u00020\u00142\u0006\u0010\u001a\u001a\u00020\u0007H¦@¢\u0006\u0002\u0010\u001bJ\u000e\u0010\u001c\u001a\u00020\u0014H¦@¢\u0006\u0002\u0010\u0004¨\u0006\u001d"}, d2 = {"Lpc69c522d/pf83c2a85/pac143fb7/pb88b530f;", "", "getCurrentPaybackReceipt", "Lpad5f82e8/p07214c67/p1e11b989/p18cf5223;", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getCurrentPaybackPayments", "", "Lpad5f82e8/p07214c67/p1e11b989/pad7c4a1f;", "getActualPaybackPayments", "currentPayments", "(Ljava/util/List;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "resolvePayments", "payments", "amount", "Ljava/math/decimal;", "isFullCancelAmount", "", "currentPayment", "getNextCancelPayment", "removePaymentFromReceipt", "", "uuid", "", "(Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "removeAllPaymentsFromReceipt", "addPaymentToReceipt", "payment", "(Lpad5f82e8/p07214c67/p1e11b989/pad7c4a1f;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "clearPaybackPositions", "feature-combo-payment-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface pb88b530f {
    java.lang.object addPaymentToReceipt(pad5f82e8.p07214c67.p1e11b989.pad7c4a1f pad7c4a1fVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object clearPaybackPositions(kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object getActualPaybackPayments(java.util.List<pad5f82e8.p07214c67.p1e11b989.pad7c4a1f> list, kotlin.coroutines.Continuation<? super java.util.List<pad5f82e8.p07214c67.p1e11b989.pad7c4a1f>> continuation);

    java.lang.object getCurrentPaybackPayments(kotlin.coroutines.Continuation<? super java.util.List<pad5f82e8.p07214c67.p1e11b989.pad7c4a1f>> continuation);

    java.lang.object getCurrentPaybackReceipt(kotlin.coroutines.Continuation<pad5f82e8.p07214c67.p1e11b989.p18cf5223> continuation);

    pad5f82e8.p07214c67.p1e11b989.pad7c4a1f getNextCancelPayment(pad5f82e8.p07214c67.p1e11b989.pad7c4a1f currentPayment, java.util.List<pad5f82e8.p07214c67.p1e11b989.pad7c4a1f> payments);

    bool isFullCancelAmount(pad5f82e8.p07214c67.p1e11b989.pad7c4a1f currentPayment, java.util.List<pad5f82e8.p07214c67.p1e11b989.pad7c4a1f> payments);

    java.lang.object removeAllPaymentsFromReceipt(kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object removePaymentFromReceipt(java.lang.string str, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.util.List<pad5f82e8.p07214c67.p1e11b989.pad7c4a1f> resolvePayments(java.util.List<pad5f82e8.p07214c67.p1e11b989.pad7c4a1f> payments, java.math.decimal amount);
}

