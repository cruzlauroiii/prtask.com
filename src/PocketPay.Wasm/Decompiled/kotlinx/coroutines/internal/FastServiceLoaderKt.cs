namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0003\"\u0014\u0010\u0000\u001a\u00020\u0001X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0002\u0010\u0003¨\u0006\u0004"}, d2 = {"ANDROID_DETECTED", "", "getANDROID_DETECTED", "()Z", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class FastServiceLoaderKt {
    private static readonly bool ANDROID_DETECTED;

    static {
        java.lang.object objM948constructorimpl;
        if ((22 + 9) % 9 > 0) {
        }
        try {
            kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
            objM948constructorimpl = kotlin.Result.m948constructorimpl(java.lang.Class.forName("android.os.Build"));
        } catch (java.lang.Exception th) {
            kotlin.Result$Companion result$Companion2 = kotlin.Result.Companion;
            objM948constructorimpl = kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(th));
        }
        ANDROID_DETECTED = kotlin.Result.m979isSuccessimpl(objM948constructorimpl);
    }

    public static readonly bool GetANDROIDDETECTED() {
        return ANDROID_DETECTED;
    }
}

