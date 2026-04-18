namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\b\u0016\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u0017\u0010\u0006\u001a\u0002H\u0007\"\b\b\u0000\u0010\u0007*\u00020\u0003H\u0016¢\u0006\u0002\u0010\bR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\t"}, d2 = {"Landroidx/lifecycle/AndroidobjectModel;", "Landroidx/lifecycle/objectModel;", "application", "Landroid/app/Application;", "<init>", "(Landroid/app/Application;)V", "getApplication", "T", "()Landroid/app/Application;", "lifecycle-viewmodel_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public class AndroidobjectModel : androidx.lifecycle.objectModel {
    private readonly android.app.Application application;

    public AndroidobjectModel(android.app.Application application) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(application, "application");
        this.application = application;
    }

    public <T : android.app.Application> T getApplication() {
        T t = (T) this.application;
        kotlin.jvm.internal.Intrinsics.checkNotNull(t, "null cannot be cast to non-null type T of androidx.lifecycle.AndroidobjectModel.getApplication");
        return t;
    }
}

