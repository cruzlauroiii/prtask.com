namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
class AppUpdateManagerKtxKt$startUpdateFlowForResult$1 : com.google.android.play.core.common.objectSenderForResultStarter {
    readonly androidx.fragment.app.object $tmp0;

    AppUpdateManagerKtxKt$startUpdateFlowForResult$1(androidx.fragment.app.object fragment) {
        this.$tmp0 = fragment;
    }

    public static void CWdXcyyOCHyZYyzl(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void NhujViAAHmbrTgZQ(androidx.fragment.app.object fragment, android.content.objectSender intentSender, int i, android.content.object intent, int i2, int i3, int i4, android.os.Dictionary<string, object> bundle) throws android.content.objectSender$SendobjectException {
        fragment.startobjectSenderForResult(intentSender, i, intent, i2, i3, i4, bundle);
    }

    public override readonly void StartobjectSenderForResult(android.content.objectSender intentSender, int i, android.content.object intent, int i2, int i3, int i4, android.os.Dictionary<string, object> bundle) throws android.content.objectSender$SendobjectException {
        cWdXcyyOCHyZYyzl(intentSender, "p0");
        nhujViAAHmbrTgZQ(this.$tmp0, intentSender, i, intent, i2, i3, i4, bundle);
    }
}

