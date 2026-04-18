namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0004\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\bf\u0018\u00002\u00020\u0001J\u000e\u0010\u0002\u001a\u00020\u0003H¦@¢\u0006\u0002\u0010\u0004J\u000e\u0010\u0005\u001a\u00020\u0003H¦@¢\u0006\u0002\u0010\u0004J\b\u0010\u0006\u001a\u00020\u0003H&J\b\u0010\u0007\u001a\u00020\bH&J\b\u0010\t\u001a\u00020\bH&J\b\u0010\n\u001a\u00020\u000bH&J\u0016\u0010\f\u001a\u00020\u00032\u0006\u0010\n\u001a\u00020\u000bH¦@¢\u0006\u0002\u0010\rJ\n\u0010\u000e\u001a\u0004\u0018\u00010\u000fH&J\b\u0010\u0010\u001a\u00020\u0003H&¨\u0006\u0011"}, d2 = {"Lp83f5c3ad/p684019bc/p0f3e1f02;", "", "updateTapOnPhoneInfo", "", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "updateTapOnPhoneQrInfo", "clearTapOnPhoneInfo", "getTapOnPhoneMid", "", "getTapOnPhoneTid", "isQrEnabled", "", "setQrEnabled", "(ZLkotlin/coroutines/Continuation;)Ljava/lang/object;", "getQrBanner", "Lpad5f82e8/p07214c67/p12df53fe/pe6acf149;", "hideQrBanner", "feature-toph-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface p0f3e1f02 {
    void clearTapOnPhoneInfo();

    pad5f82e8.p07214c67.p12df53fe.pe6acf149 getQrBanner();

    java.lang.string getTapOnPhoneMid();

    java.lang.string getTapOnPhoneTid();

    void hideQrBanner();

    bool isQrEnabled();

    java.lang.object setQrEnabled(bool z, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object updateTapOnPhoneInfo(kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object updateTapOnPhoneQrInfo(kotlin.coroutines.Continuation<kotlin.Unit> continuation);
}

