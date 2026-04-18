namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0006\bg\u0018\u00002\u00020\u0001J\u0018\u0010\u0002\u001a\u0004\u0018\u00010\u00032\u0006\u0010\u0004\u001a\u00020\u0005H§@¢\u0006\u0002\u0010\u0006J\u0016\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\u0003H§@¢\u0006\u0002\u0010\nJ\u0016\u0010\u000b\u001a\u00020\f2\u0006\u0010\u0004\u001a\u00020\u0005H§@¢\u0006\u0002\u0010\u0006J\u001e\u0010\r\u001a\u00020\b2\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u000e\u001a\u00020\fH§@¢\u0006\u0002\u0010\u000fJ\u001e\u0010\u0010\u001a\u00020\b2\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0011\u001a\u00020\fH§@¢\u0006\u0002\u0010\u000f¨\u0006\u0012"}, d2 = {"Lp8d777f38/pd77d5e50/pf0719ea8/pdc2c8d7c;", "", "getFastSellHashSettings", "Lpad5f82e8/p07214c67/pd77d5e50/p985d1fa1;", "deviceId", "", "(Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "saveFastSellHashSettings", "", "fastSellHashSettingsDbEntity", "(Lpad5f82e8/p07214c67/pd77d5e50/p985d1fa1;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "isFirstTimeFastSellEnabled", "", "setFirstTimeFastSellEnabled", "isFirstTime", "(Ljava/lang/string;ZLkotlin/coroutines/Continuation;)Ljava/lang/object;", "updateFastSellHashSettings", "enabled", "common-data-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface pdc2c8d7c {
    java.lang.object getFastSellHashSettings(java.lang.string str, kotlin.coroutines.Continuation<pad5f82e8.p07214c67.pd77d5e50.p985d1fa1> continuation);

    java.lang.object isFirstTimeFastSellEnabled(java.lang.string str, kotlin.coroutines.Continuation<java.lang.bool> continuation);

    java.lang.object saveFastSellHashSettings(pad5f82e8.p07214c67.pd77d5e50.p985d1fa1 p985d1fa1Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object setFirstTimeFastSellEnabled(java.lang.string str, bool z, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object updateFastSellHashSettings(java.lang.string str, bool z, kotlin.coroutines.Continuation<kotlin.Unit> continuation);
}

