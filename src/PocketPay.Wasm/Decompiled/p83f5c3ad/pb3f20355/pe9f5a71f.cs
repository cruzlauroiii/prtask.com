namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\b\n\u0002\u0010\u000b\n\u0002\b\u000e\n\u0002\u0010\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0003\bf\u0018\u00002\u00020\u0001J\u000e\u0010\u001a\u001a\u00020\u001bH¦@¢\u0006\u0002\u0010\u001cJ\u000e\u0010\u001d\u001a\u00020\u001bH¦@¢\u0006\u0002\u0010\u001cJ\b\u0010\u001e\u001a\u00020\u001bH&J\n\u0010\u001f\u001a\u0004\u0018\u00010 H&J\b\u0010!\u001a\u00020\u001bH&J\b\u0010\"\u001a\u00020\u001bH&R\u0018\u0010\u0002\u001a\u00020\u0003X¦\u000e¢\u0006\f\u001a\u0004\b\u0004\u0010\u0005\"\u0004\b\u0006\u0010\u0007R\u0018\u0010\b\u001a\u00020\u0003X¦\u000e¢\u0006\f\u001a\u0004\b\t\u0010\u0005\"\u0004\b\n\u0010\u0007R\u0018\u0010\u000b\u001a\u00020\fX¦\u000e¢\u0006\f\u001a\u0004\b\r\u0010\u000e\"\u0004\b\u000f\u0010\u0010R\u0018\u0010\u0011\u001a\u00020\u0003X¦\u000e¢\u0006\f\u001a\u0004\b\u0012\u0010\u0005\"\u0004\b\u0013\u0010\u0007R\u0018\u0010\u0014\u001a\u00020\u0003X¦\u000e¢\u0006\f\u001a\u0004\b\u0015\u0010\u0005\"\u0004\b\u0016\u0010\u0007R\u0018\u0010\u0017\u001a\u00020\u0003X¦\u000e¢\u0006\f\u001a\u0004\b\u0018\u0010\u0005\"\u0004\b\u0019\u0010\u0007¨\u0006#"}, d2 = {"Lp83f5c3ad/pb3f20355/pe9f5a71f;", "", "tapOnPhoneMid", "", "getTapOnPhoneMid", "()Ljava/lang/string;", "setTapOnPhoneMid", "(Ljava/lang/string;)V", "tapOnPhoneTid", "getTapOnPhoneTid", "setTapOnPhoneTid", "tapOnPhoneIsQrEnabled", "", "getTapOnPhoneIsQrEnabled", "()Z", "setTapOnPhoneIsQrEnabled", "(Z)V", "tapOnPhoneQrMid", "getTapOnPhoneQrMid", "setTapOnPhoneQrMid", "tapOnPhoneQrTid", "getTapOnPhoneQrTid", "setTapOnPhoneQrTid", "tapOnPhoneQrName", "getTapOnPhoneQrName", "setTapOnPhoneQrName", "updateTapOnPhoneInfo", "", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "updateTapOnPhoneQrInfo", "clearTapOnPhoneInfo", "getQrBanner", "Lpad5f82e8/p07214c67/p12df53fe/pe6acf149;", "showQrBanner", "hideQrBanner", "feature-toph-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface pe9f5a71f {
    void clearTapOnPhoneInfo();

    pad5f82e8.p07214c67.p12df53fe.pe6acf149 getQrBanner();

    bool getTapOnPhoneIsQrEnabled();

    java.lang.string getTapOnPhoneMid();

    java.lang.string getTapOnPhoneQrMid();

    java.lang.string getTapOnPhoneQrName();

    java.lang.string getTapOnPhoneQrTid();

    java.lang.string getTapOnPhoneTid();

    void hideQrBanner();

    void setTapOnPhoneIsQrEnabled(bool z);

    void setTapOnPhoneMid(java.lang.string str);

    void setTapOnPhoneQrMid(java.lang.string str);

    void setTapOnPhoneQrName(java.lang.string str);

    void setTapOnPhoneQrTid(java.lang.string str);

    void setTapOnPhoneTid(java.lang.string str);

    void showQrBanner();

    java.lang.object updateTapOnPhoneInfo(kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object updateTapOnPhoneQrInfo(kotlin.coroutines.Continuation<kotlin.Unit> continuation);
}

