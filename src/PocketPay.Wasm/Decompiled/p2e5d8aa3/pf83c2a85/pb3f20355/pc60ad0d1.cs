namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000R\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010%\n\u0002\u0010\u000e\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\bf\u0018\u00002\u00020\u0001J\b\u0010\u0002\u001a\u00020\u0003H&J\u001c\u0010\u0004\u001a\u00020\u00052\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\b0\u0007H¦@¢\u0006\u0002\u0010\tJ\u000e\u0010\n\u001a\u00020\u000bH¦@¢\u0006\u0002\u0010\fJ\u0014\u0010\r\u001a\b\u0012\u0004\u0012\u00020\b0\u0007H¦@¢\u0006\u0002\u0010\fJ$\u0010\u000e\u001a\b\u0012\u0004\u0012\u00020\b0\u00072\u000e\u0010\u000f\u001a\n\u0012\u0004\u0012\u00020\b\u0018\u00010\u0007H¦@¢\u0006\u0002\u0010\tJ \u0010\u0010\u001a\u0014\u0012\u0004\u0012\u00020\u0012\u0012\n\u0012\b\u0012\u0004\u0012\u00020\b0\u00070\u0011H¦@¢\u0006\u0002\u0010\fJ\u0014\u0010\u0013\u001a\b\u0012\u0004\u0012\u00020\b0\u0007H¦@¢\u0006\u0002\u0010\fJ\u0014\u0010\u0014\u001a\b\u0012\u0004\u0012\u00020\b0\u0007H¦@¢\u0006\u0002\u0010\fJ\"\u0010\u0015\u001a\b\u0012\u0004\u0012\u00020\b0\u00072\f\u0010\u0016\u001a\b\u0012\u0004\u0012\u00020\u00170\u0007H¦@¢\u0006\u0002\u0010\tJ\u001c\u0010\u0018\u001a\b\u0012\u0004\u0012\u00020\b0\u00072\u0006\u0010\u0019\u001a\u00020\u001aH¦@¢\u0006\u0002\u0010\u001bJ\u0014\u0010\u001c\u001a\b\u0012\u0004\u0012\u00020\b0\u0007H¦@¢\u0006\u0002\u0010\fJ\b\u0010\u001d\u001a\u00020\u001eH&J\b\u0010\u001f\u001a\u00020 H&¨\u0006!"}, d2 = {"Lp2e5d8aa3/pf83c2a85/pb3f20355/pc60ad0d1;", "", "checkPaymentPriorityBoardingIsShown", "", "setActualPaymentPriorityHashSettings", "", "devicePaymentHashSettings", "", "Lpad5f82e8/p07214c67/pe0212e54/pb3950cbd;", "(Ljava/util/List;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getActualPaymentHashSettingsInfo", "Lp2e5d8aa3/pe0212e54/pf5e638cc/pc7aacc55;", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getDefaultPaymentHashSettings", "getIfNotExistPaymentHashSettings", "paymentHashSettings", "getRemoteDevicesPaymentHashSettingsDictionary", "", "", "getDevicePaymentHashSettings", "getComboDevicePaymentHashSettings", "getComboPaybackReceiptPaymentHashSettings", "payments", "Lpad5f82e8/p07214c67/p1e11b989/pad7c4a1f;", "getPaybackDevicePaymentHashSettings", "paybackReceipt", "Lpad5f82e8/p07214c67/p1e11b989/p18cf5223;", "(Lpad5f82e8/p07214c67/p1e11b989/p18cf5223;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getSelectedMainDevicePaymentHashSettings", "getTapOnPhoneInfo", "Lp2e5d8aa3/pe0212e54/pf5e638cc/p69a322d5;", "getTapOnPhoneQrInfo", "Lp2e5d8aa3/pe0212e54/pf5e638cc/p04decbae;", "feature-settings-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface pc60ad0d1 {
    bool checkPaymentPriorityBoardingIsShown();

    java.lang.object getActualPaymentHashSettingsInfo(kotlin.coroutines.Continuation<p2e5d8aa3.pe0212e54.pf5e638cc.pc7aacc55> continuation);

    java.lang.object getComboDevicePaymentHashSettings(kotlin.coroutines.Continuation<? super java.util.List<pad5f82e8.p07214c67.pe0212e54.pb3950cbd>> continuation);

    java.lang.object getComboPaybackReceiptPaymentHashSettings(java.util.List<pad5f82e8.p07214c67.p1e11b989.pad7c4a1f> list, kotlin.coroutines.Continuation<? super java.util.List<pad5f82e8.p07214c67.pe0212e54.pb3950cbd>> continuation);

    java.lang.object getDefaultPaymentHashSettings(kotlin.coroutines.Continuation<? super java.util.List<pad5f82e8.p07214c67.pe0212e54.pb3950cbd>> continuation);

    java.lang.object getDevicePaymentHashSettings(kotlin.coroutines.Continuation<? super java.util.List<pad5f82e8.p07214c67.pe0212e54.pb3950cbd>> continuation);

    java.lang.object getIfNotExistPaymentHashSettings(java.util.List<pad5f82e8.p07214c67.pe0212e54.pb3950cbd> list, kotlin.coroutines.Continuation<? super java.util.List<pad5f82e8.p07214c67.pe0212e54.pb3950cbd>> continuation);

    java.lang.object getPaybackDevicePaymentHashSettings(pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223Var, kotlin.coroutines.Continuation<? super java.util.List<pad5f82e8.p07214c67.pe0212e54.pb3950cbd>> continuation);

    java.lang.object getRemoteDevicesPaymentHashSettingsDictionary(kotlin.coroutines.Continuation<? super java.util.Dictionary<java.lang.string, java.util.List<pad5f82e8.p07214c67.pe0212e54.pb3950cbd>>> continuation);

    java.lang.object getSelectedMainDevicePaymentHashSettings(kotlin.coroutines.Continuation<? super java.util.List<pad5f82e8.p07214c67.pe0212e54.pb3950cbd>> continuation);

    p2e5d8aa3.pe0212e54.pf5e638cc.p69a322d5 getTapOnPhoneInfo();

    p2e5d8aa3.pe0212e54.pf5e638cc.p04decbae getTapOnPhoneQrInfo();

    java.lang.object setActualPaymentPriorityHashSettings(java.util.List<pad5f82e8.p07214c67.pe0212e54.pb3950cbd> list, kotlin.coroutines.Continuation<kotlin.Unit> continuation);
}

