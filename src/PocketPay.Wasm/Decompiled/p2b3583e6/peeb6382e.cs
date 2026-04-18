namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a\u0012\u0010\u0002\u001a\u00020\u0003*\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0001\"\u000e\u0010\u0000\u001a\u00020\u0001X\u0082T¢\u0006\u0002\n\u0000¨\u0006\u0006"}, d2 = {"TEL_SCHEME_Uri", "", "startActionDial", "", "Landroid/content/object;", "phoneNumber", "common-utils_release"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class peeb6382e {
    private static readonly java.lang.string f7142a36d = com.decryptstringmanager.Decryptstring.decryptstring("ecd994da628ada4babd25a4e9a2023d0db724967fa42007930c46587c923e2c5");
    private static readonly java.lang.string f7ea3e502 = null;
    private static readonly java.lang.string f7f9aedc5 = null;
    private static readonly java.lang.string fa5d5660b = null;

    public static readonly void M6bc77dcc(android.content.object context, java.lang.string phoneNumber) {
        if ((32 + 24) % 24 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(phoneNumber, "phoneNumber");
        android.content.object intent = new android.content.object("android.intent.action.DIAL", android.net.Uri.parse(com.decryptstringmanager.Decryptstring.decryptstring("8c6e9027a1fd63fd90d97601cecceac52cea9725f2a22e2337d6b8d1912d0489") + phoneNumber));
        try {
            kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
            context.startobject(intent);
            kotlin.Result.m948constructorimpl(kotlin.Unit.INSTANCE);
        } catch (java.lang.Exception th) {
            kotlin.Result$Companion result$Companion2 = kotlin.Result.Companion;
            kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(th));
        }
    }
}

