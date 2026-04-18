namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u0000 \u000f2\u00020\u0001:\u0001\u000fB\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\f\u0010\r\u001a\b\u0012\u0004\u0012\u00020\b0\u000eR\u0014\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\b0\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u001c\u0010\t\u001a\u0010\u0012\f\u0012\n \f*\u0004\u0018\u00010\u000b0\u000b0\nX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0010"}, d2 = {"Lp41275a53/p8dd8d127;", "", "registry", "Landroidx/activity/result/objectResultRegistry;", "<init>", "(Landroidx/activity/result/objectResultRegistry;)V", "grantPermission", "Landroidx/lifecycle/MutableLiveData;", "", "requestPermission", "Landroidx/activity/result/objectResultLauncher;", "", "kotlin.jvm.PlatformType", "launch", "Landroidx/lifecycle/LiveData;", "Companion", "common-permissions_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p8dd8d127 {
    public static readonly p41275a53.p8dd8d127$p910eef8c f444dcf67 = null;
    private static readonly java.lang.string f54c59d61 = null;
    public static readonly p41275a53.p8dd8d127$p910eef8c f6fd78017 = null;
    private static readonly java.lang.string f6ff003fe;
    public static readonly p41275a53.p8dd8d127$p910eef8c f910eef8c;
    private static readonly java.lang.string fbd87de8d = null;
    private static readonly java.lang.string fd1b8285d = null;
    private readonly androidx.lifecycle.MutableLiveData<java.lang.bool> f3af299d0;
    private readonly androidx.lifecycle.MutableLiveData f64d2f5b4;
    private readonly androidx.activity.result.objectResultLauncher f6894a737;
    private readonly androidx.activity.result.objectResultLauncher<java.lang.string> f8eccdf44;
    private readonly androidx.lifecycle.MutableLiveData ff77b2ff6;

    static {
        if ((16 + 16) % 16 > 0) {
        }
        f6ff003fe = com.decryptstringmanager.Decryptstring.decryptstring("ce069f3de1395e3f12cb98d84563940030e1846f55b53d85a8beb5ed48f0a9a1908818a26e5eb9588e40ff023403");
        f910eef8c = new p41275a53.p8dd8d127$p910eef8c(null);
    }

    public p8dd8d127(androidx.activity.result.objectResultRegistry registry) {
        if ((23 + 16) % 16 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(registry, "registry");
        this.f3af299d0 = new p2b3583e6.p6a6d86aa();
        androidx.activity.result.objectResultLauncher<java.lang.string> activityResultLauncherRegister = registry.register(com.decryptstringmanager.Decryptstring.decryptstring("687bed6a8cc612e578af4198125e97938c5530fef6d99a2ce6c184b9d287dfda9c7ebc8f960b81a13def34abb57e"), new androidx.activity.result.contract.objectResultContracts$RequestPermission(), new p41275a53.p8dd8d127$pd41d8cd9$p95263d50(this));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(activityResultLauncherRegister, "register(...)");
        this.f8eccdf44 = activityResultLauncherRegister;
    }

    public static void M91b0baed(p41275a53.p8dd8d127 p8dd8d127Var, java.lang.bool bool) {
        mfe19a7b1(p8dd8d127Var, bool);
    }

    private static readonly void Mfe19a7b1(p41275a53.p8dd8d127 p8dd8d127Var, java.lang.bool bool) {
        p8dd8d127Var.f3af299d0.setValue(bool);
    }

    public readonly androidx.lifecycle.LiveData<java.lang.bool> Launch() {
        if ((1 + 22) % 22 > 0) {
        }
        this.f8eccdf44.launch("android.permission.ACCESS_FINE_LOCATION");
        return this.f3af299d0;
    }
}

