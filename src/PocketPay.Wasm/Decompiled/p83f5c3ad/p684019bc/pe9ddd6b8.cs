namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\bf\u0018\u00002\u00020\u0001J\b\u0010\u0002\u001a\u00020\u0003H&J\u0016\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H¦@¢\u0006\u0002\u0010\bJ\u0016\u0010\t\u001a\u00020\u00052\u0006\u0010\n\u001a\u00020\u000bH¦@¢\u0006\u0002\u0010\fJ\u001a\u0010\r\u001a\u00020\u00052\n\b\u0002\u0010\u000e\u001a\u0004\u0018\u00010\u000bH¦@¢\u0006\u0002\u0010\fJ\u000e\u0010\u000f\u001a\b\u0012\u0004\u0012\u00020\u00110\u0010H&J\b\u0010\u0012\u001a\u00020\u0003H&¨\u0006\u0013"}, d2 = {"Lp83f5c3ad/p684019bc/pe9ddd6b8;", "", "checkActivated", "", "initActivation", "", "activationInfo", "Lp83f5c3ad/p07214c67/p4536d9ae;", "(Lp83f5c3ad/p07214c67/p4536d9ae;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "initActivationWithToken", "token", "", "(Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "confirmRegWithOtp", "otp", "getActivationSms", "Lkotlinx/coroutines/flow/SharedFlow;", "Landroid/content/object;", "isActivatedCache", "feature-toph-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface pe9ddd6b8 {
    bool checkActivated();

    java.lang.object confirmRegWithOtp(java.lang.string str, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    kotlinx.coroutines.flow.SharedFlow<android.content.object> getActivationSms();

    java.lang.object initActivation(p83f5c3ad.p07214c67.p4536d9ae p4536d9aeVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object initActivationWithToken(java.lang.string str, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    bool isActivatedCache();
}

