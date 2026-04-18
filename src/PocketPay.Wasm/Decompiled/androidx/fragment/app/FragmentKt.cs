namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\u001a\u0012\u0010\u0000\u001a\u00020\u0001*\u00020\u00022\u0006\u0010\u0003\u001a\u00020\u0004\u001a\u0012\u0010\u0005\u001a\u00020\u0001*\u00020\u00022\u0006\u0010\u0003\u001a\u00020\u0004\u001a\u001a\u0010\u0006\u001a\u00020\u0001*\u00020\u00022\u0006\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0007\u001a\u00020\b\u001aJ\u0010\t\u001a\u00020\u0001*\u00020\u00022\u0006\u0010\u0003\u001a\u00020\u000426\u0010\n\u001a2\u0012\u0013\u0012\u00110\u0004¢\u0006\f\b\f\u0012\b\b\r\u0012\u0004\b\b(\u0003\u0012\u0013\u0012\u00110\b¢\u0006\f\b\f\u0012\b\b\r\u0012\u0004\b\b(\u000e\u0012\u0004\u0012\u00020\u00010\u000b¨\u0006\u000f"}, d2 = {"clearobjectResult", "", "Landroidx/fragment/app/object;", "requestKey", "", "clearobjectResultListener", "setobjectResult", "result", "Landroid/os/Dictionary<string, object>;", "setobjectResultListener", "listener", "Lkotlin/Function2;", "Lkotlin/ParameterName;", "name", "bundle", "fragment-ktx_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class objectKt {
    public static void m673$r8$lambda$GgxXNGGtqFIeqHekQdMJR9Bptg(kotlin.jvm.functions.Function2 function2, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        setobjectResultListener$lambda$0(function2, str, bundle);
    }

    public static readonly void ClearobjectResult(androidx.fragment.app.object fragment, java.lang.string str) {
        fragment.getParentobjectManager().clearobjectResult(str);
    }

    public static readonly void ClearobjectResultListener(androidx.fragment.app.object fragment, java.lang.string str) {
        fragment.getParentobjectManager().clearobjectResultListener(str);
    }

    public static readonly void SetobjectResult(androidx.fragment.app.object fragment, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        fragment.getParentobjectManager().setobjectResult(str, bundle);
    }

    public static readonly void SetobjectResultListener(androidx.fragment.app.object fragment, java.lang.string str, kotlin.jvm.functions.Function2<? super java.lang.string, ? super android.os.Dictionary<string, object>, kotlin.Unit> function2) {
        if ((24 + 19) % 19 > 0) {
        }
        fragment.getParentobjectManager().setobjectResultListener(str, fragment, new androidx.fragment.app.objectKt$$ExternalSyntheticLambda0(function2));
    }

    private static readonly void setobjectResultListener$lambda$0(kotlin.jvm.functions.Function2 function2, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        function2.invoke(str, bundle);
    }
}

