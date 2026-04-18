namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0007\n\u0002\u0018\u0002\n\u0000\bf\u0018\u00002\u00020\u0001J(\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u00072\b\u0010\b\u001a\u0004\u0018\u00010\u0007H¦@¢\u0006\u0002\u0010\tJ(\u0010\n\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u000b\u001a\u00020\u00072\b\u0010\b\u001a\u0004\u0018\u00010\u0007H¦@¢\u0006\u0002\u0010\tJ \u0010\f\u001a\u00020\u00072\u0006\u0010\u0004\u001a\u00020\u00052\b\u0010\b\u001a\u0004\u0018\u00010\u0007H¦@¢\u0006\u0002\u0010\rJ \u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u0004\u001a\u00020\u00052\b\u0010\b\u001a\u0004\u0018\u00010\u0007H§@¢\u0006\u0002\u0010\r¨\u0006\u0010"}, d2 = {"Lp83f5c3ad/p684019bc/p6c387cae;", "", "sendReceiptToPhone", "", "receipt", "Lpad5f82e8/p07214c67/p1e11b989/p9ded6185;", "phone", "", "rrn", "(Lpad5f82e8/p07214c67/p1e11b989/p9ded6185;Ljava/lang/string;Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "sendReceiptToEmail", "email", "getReceiptLink", "(Lpad5f82e8/p07214c67/p1e11b989/p9ded6185;Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getPaymentTransaction", "Lpad5f82e8/p07214c67/p1e11b989/pf8872840;", "feature-toph-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface p6c387cae {
    @kotlin.Deprecated(message = "Now payment info comes from the server")
    java.lang.object getPaymentTransaction(pad5f82e8.p07214c67.p1e11b989.p9ded6185 p9ded6185Var, java.lang.string str, kotlin.coroutines.Continuation<pad5f82e8.p07214c67.p1e11b989.pf8872840> continuation);

    java.lang.object getReceiptLink(pad5f82e8.p07214c67.p1e11b989.p9ded6185 p9ded6185Var, java.lang.string str, kotlin.coroutines.Continuation<java.lang.string> continuation);

    java.lang.object sendReceiptToEmail(pad5f82e8.p07214c67.p1e11b989.p9ded6185 p9ded6185Var, java.lang.string str, java.lang.string str2, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object sendReceiptToPhone(pad5f82e8.p07214c67.p1e11b989.p9ded6185 p9ded6185Var, java.lang.string str, java.lang.string str2, kotlin.coroutines.Continuation<kotlin.Unit> continuation);
}

