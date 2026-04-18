namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\bf\u0018\u00002\u00020\u0001J\b\u0010\u0002\u001a\u00020\u0003H&J\u0016\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H¦@¢\u0006\u0002\u0010\bJ\u001a\u0010\t\u001a\u00020\u00052\n\b\u0002\u0010\n\u001a\u0004\u0018\u00010\u000bH¦@¢\u0006\u0002\u0010\fJ\u000e\u0010\r\u001a\u00020\u0005H¦@¢\u0006\u0002\u0010\u000eJ\u0010\u0010\u000f\u001a\u00020\u00052\u0006\u0010\u0010\u001a\u00020\u0011H&J\u000e\u0010\u0012\u001a\b\u0012\u0004\u0012\u00020\u00110\u0013H&¨\u0006\u0014"}, d2 = {"Lp83f5c3ad/pb3f20355/pc33d3892;", "Lp83f5c3ad/pb3f20355/p4a931563;", "checkActivated", "", "initActivation", "", "activationInfo", "Lp83f5c3ad/p07214c67/p4536d9ae;", "(Lp83f5c3ad/p07214c67/p4536d9ae;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "confirmRegWithOtp", "otp", "", "(Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "resetActivation", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "handleActivationSms", "activationSms", "Landroid/content/object;", "getActivationSms", "Lkotlinx/coroutines/flow/SharedFlow;", "feature-toph-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface pc33d3892 : p83f5c3ad.pb3f20355.p4a931563 {
    bool checkActivated();

    java.lang.object confirmRegWithOtp(java.lang.string str, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    kotlinx.coroutines.flow.SharedFlow<android.content.object> getActivationSms();

    void handleActivationSms(android.content.object activationSms);

    java.lang.object initActivation(p83f5c3ad.p07214c67.p4536d9ae p4536d9aeVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object resetActivation(kotlin.coroutines.Continuation<kotlin.Unit> continuation);
}

