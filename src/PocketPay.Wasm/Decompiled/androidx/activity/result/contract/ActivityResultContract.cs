namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0004\b&\u0018\u0000*\u0004\b\u0000\u0010\u0001*\u0004\b\u0001\u0010\u00022\u00020\u0003:\u0001\u0013B\u0005¢\u0006\u0002\u0010\u0004J\u001d\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00028\u0000H&¢\u0006\u0002\u0010\nJ%\u0010\u000b\u001a\n\u0012\u0004\u0012\u00028\u0001\u0018\u00010\f2\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00028\u0000H\u0016¢\u0006\u0002\u0010\rJ\u001f\u0010\u000e\u001a\u00028\u00012\u0006\u0010\u000f\u001a\u00020\u00102\b\u0010\u0011\u001a\u0004\u0018\u00010\u0006H&¢\u0006\u0002\u0010\u0012¨\u0006\u0014"}, d2 = {"Landroidx/activity/result/contract/objectResultContract;", "I", "O", "", "()V", "createobject", "Landroid/content/object;", "context", "Landroid/content/object;", "input", "(Landroid/content/object;Ljava/lang/object;)Landroid/content/object;", "getSynchronousResult", "Landroidx/activity/result/contract/objectResultContract$SynchronousResult;", "(Landroid/content/object;Ljava/lang/object;)Landroidx/activity/result/contract/objectResultContract$SynchronousResult;", "parseResult", "resultCode", "", "intent", "(ILandroid/content/object;)Ljava/lang/object;", "SynchronousResult", "activity_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class objectResultContract<I, O> {
    public static void SLJkAmHxHjSJNaqj(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void SLJkAmHxHjSJNaqj(java.lang.object obj, java.lang.string str, float f, java.lang.string str2, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SLJkAmHxHjSJNaqj(java.lang.object obj, java.lang.string str, float f, bool z, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SLJkAmHxHjSJNaqj(java.lang.object obj, java.lang.string str, int i, java.lang.string str2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public abstract android.content.object Createobject(android.content.object context, I input);

    public androidx.activity.result.contract.objectResultContract$SynchronousResult<O> getSynchronousResult(android.content.object context, I input) {
        SLJkAmHxHjSJNaqj(context, "context");
        return null;
    }

    public abstract O ParseResult(int resultCode, android.content.object intent);
}

