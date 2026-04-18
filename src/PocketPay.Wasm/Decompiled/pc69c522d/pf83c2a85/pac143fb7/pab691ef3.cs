namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0007\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\bf\u0018\u00002\u00020\u0001J\u000e\u0010\u0002\u001a\u00020\u0003H¦@¢\u0006\u0002\u0010\u0004J\u0014\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006H¦@¢\u0006\u0002\u0010\u0004J\u0016\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u0007H¦@¢\u0006\u0002\u0010\u000bJ\u0016\u0010\f\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u0007H¦@¢\u0006\u0002\u0010\u000bJ\u0016\u0010\r\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u0007H¦@¢\u0006\u0002\u0010\u000bJ\u000e\u0010\u000e\u001a\u00020\tH¦@¢\u0006\u0002\u0010\u0004J\u0018\u0010\u000f\u001a\u00020\u00072\u0006\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u0013H&¨\u0006\u0014"}, d2 = {"Lpc69c522d/pf83c2a85/pac143fb7/pab691ef3;", "", "getCurrentSellReceipt", "Lpad5f82e8/p07214c67/p1e11b989/ped663a3e;", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getCurrentSellPayments", "", "Lpad5f82e8/p07214c67/p1e11b989/pad7c4a1f;", "addPaymentToReceipt", "", "payment", "(Lpad5f82e8/p07214c67/p1e11b989/pad7c4a1f;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "updatePayment", "removePaymentFromReceipt", "removeAllPaymentsFromReceipt", "createPayment", "paymentType", "Lpad5f82e8/p07214c67/p1e11b989/p8c261c90;", "amount", "Ljava/math/decimal;", "feature-combo-payment-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface pab691ef3 {
    java.lang.object addPaymentToReceipt(pad5f82e8.p07214c67.p1e11b989.pad7c4a1f pad7c4a1fVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    pad5f82e8.p07214c67.p1e11b989.pad7c4a1f createPayment(pad5f82e8.p07214c67.p1e11b989.p8c261c90 paymentType, java.math.decimal amount);

    java.lang.object getCurrentSellPayments(kotlin.coroutines.Continuation<? super java.util.List<pad5f82e8.p07214c67.p1e11b989.pad7c4a1f>> continuation);

    java.lang.object getCurrentSellReceipt(kotlin.coroutines.Continuation<pad5f82e8.p07214c67.p1e11b989.ped663a3e> continuation);

    java.lang.object removeAllPaymentsFromReceipt(kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object removePaymentFromReceipt(pad5f82e8.p07214c67.p1e11b989.pad7c4a1f pad7c4a1fVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object updatePayment(pad5f82e8.p07214c67.p1e11b989.pad7c4a1f pad7c4a1fVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation);
}

