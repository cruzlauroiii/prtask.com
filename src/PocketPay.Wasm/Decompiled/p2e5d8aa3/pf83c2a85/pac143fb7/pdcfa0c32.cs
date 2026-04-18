namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000H\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\t\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\bf\u0018\u00002\u00020\u0001J\b\u0010\u0002\u001a\u00020\u0003H&J\u000e\u0010\u0004\u001a\u00020\u0005H¦@¢\u0006\u0002\u0010\u0006J\u0016\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\u0003H¦@¢\u0006\u0002\u0010\nJ\u0016\u0010\u000b\u001a\u00020\b2\u0006\u0010\f\u001a\u00020\u0003H¦@¢\u0006\u0002\u0010\nJ\u0016\u0010\r\u001a\u00020\b2\u0006\u0010\u000e\u001a\u00020\u0003H¦@¢\u0006\u0002\u0010\nJ\u0016\u0010\u000f\u001a\u00020\b2\u0006\u0010\u0010\u001a\u00020\u0003H¦@¢\u0006\u0002\u0010\nJ\u0014\u0010\u0011\u001a\b\u0012\u0004\u0012\u00020\u00130\u0012H¦@¢\u0006\u0002\u0010\u0006J\u0014\u0010\u0014\u001a\b\u0012\u0004\u0012\u00020\u00130\u0012H¦@¢\u0006\u0002\u0010\u0006J\"\u0010\u0015\u001a\b\u0012\u0004\u0012\u00020\u00130\u00122\f\u0010\u0016\u001a\b\u0012\u0004\u0012\u00020\u00170\u0012H¦@¢\u0006\u0002\u0010\u0018J\u001c\u0010\u0019\u001a\u00020\b2\f\u0010\u001a\u001a\b\u0012\u0004\u0012\u00020\u00130\u0012H¦@¢\u0006\u0002\u0010\u0018J\u001c\u0010\u001b\u001a\b\u0012\u0004\u0012\u00020\u00130\u00122\u0006\u0010\u001c\u001a\u00020\u001dH¦@¢\u0006\u0002\u0010\u001eJ\u0014\u0010\u001f\u001a\b\u0012\u0004\u0012\u00020\u00130\u0012H¦@¢\u0006\u0002\u0010\u0006J\b\u0010 \u001a\u00020!H&J\b\u0010\"\u001a\u00020#H&¨\u0006$"}, d2 = {"Lp2e5d8aa3/pf83c2a85/pac143fb7/pdcfa0c32;", "", "checkPaymentPriorityBoardingIsShown", "", "getActualPaymentHashSettingsInfo", "Lp2e5d8aa3/pe0212e54/pf5e638cc/pc7aacc55;", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "setCashPaymentsEnabled", "", "cashPaymentsEnabled", "(ZLkotlin/coroutines/Continuation;)Ljava/lang/object;", "setQrPaymentsEnabled", "qrPaymentsEnabled", "setTapOnPhonePaymentsEnabled", "tapOnPhonePaymentsEnabled", "setComboPaymentsEnabled", "comboPaymentsEnabled", "getDevicePaymentHashSettings", "", "Lpad5f82e8/p07214c67/pe0212e54/pb3950cbd;", "getComboDevicePaymentHashSettings", "getComboPaybackReceiptPaymentHashSettings", "payments", "Lpad5f82e8/p07214c67/p1e11b989/pad7c4a1f;", "(Ljava/util/List;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "setActualPaymentPriorityHashSettings", "devicePaymentHashSettings", "getPaybackDevicePaymentHashSettings", "paybackReceipt", "Lpad5f82e8/p07214c67/p1e11b989/p18cf5223;", "(Lpad5f82e8/p07214c67/p1e11b989/p18cf5223;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getSelectedMainDevicePaymentHashSettings", "getTapOnPhoneInfo", "Lp2e5d8aa3/pe0212e54/pf5e638cc/p69a322d5;", "getTapOnPhoneQrInfo", "Lp2e5d8aa3/pe0212e54/pf5e638cc/p04decbae;", "feature-settings-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface pdcfa0c32 {
    bool checkPaymentPriorityBoardingIsShown();

    java.lang.object getActualPaymentHashSettingsInfo(kotlin.coroutines.Continuation<p2e5d8aa3.pe0212e54.pf5e638cc.pc7aacc55> continuation);

    java.lang.object getComboDevicePaymentHashSettings(kotlin.coroutines.Continuation<? super java.util.List<pad5f82e8.p07214c67.pe0212e54.pb3950cbd>> continuation);

    java.lang.object getComboPaybackReceiptPaymentHashSettings(java.util.List<pad5f82e8.p07214c67.p1e11b989.pad7c4a1f> list, kotlin.coroutines.Continuation<? super java.util.List<pad5f82e8.p07214c67.pe0212e54.pb3950cbd>> continuation);

    java.lang.object getDevicePaymentHashSettings(kotlin.coroutines.Continuation<? super java.util.List<pad5f82e8.p07214c67.pe0212e54.pb3950cbd>> continuation);

    java.lang.object getPaybackDevicePaymentHashSettings(pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223Var, kotlin.coroutines.Continuation<? super java.util.List<pad5f82e8.p07214c67.pe0212e54.pb3950cbd>> continuation);

    java.lang.object getSelectedMainDevicePaymentHashSettings(kotlin.coroutines.Continuation<? super java.util.List<pad5f82e8.p07214c67.pe0212e54.pb3950cbd>> continuation);

    p2e5d8aa3.pe0212e54.pf5e638cc.p69a322d5 getTapOnPhoneInfo();

    p2e5d8aa3.pe0212e54.pf5e638cc.p04decbae getTapOnPhoneQrInfo();

    java.lang.object setActualPaymentPriorityHashSettings(java.util.List<pad5f82e8.p07214c67.pe0212e54.pb3950cbd> list, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object setCashPaymentsEnabled(bool z, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object setComboPaymentsEnabled(bool z, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object setQrPaymentsEnabled(bool z, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object setTapOnPhonePaymentsEnabled(bool z, kotlin.coroutines.Continuation<kotlin.Unit> continuation);
}

