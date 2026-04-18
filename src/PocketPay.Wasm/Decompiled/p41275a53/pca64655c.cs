namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u0000 \u000f2\u00020\u0001:\u0001\u000fB\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\f\u0010\r\u001a\b\u0012\u0004\u0012\u00020\b0\u000eR\u0014\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\b0\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u001c\u0010\t\u001a\u0010\u0012\f\u0012\n \f*\u0004\u0018\u00010\u000b0\u000b0\nX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0010"}, d2 = {"Lp41275a53/pca64655c;", "", "registry", "Landroidx/activity/result/objectResultRegistry;", "<init>", "(Landroidx/activity/result/objectResultRegistry;)V", "grantPermission", "Landroidx/lifecycle/MutableLiveData;", "", "requestPermission", "Landroidx/activity/result/objectResultLauncher;", "", "kotlin.jvm.PlatformType", "launch", "Landroidx/lifecycle/LiveData;", "Companion", "common-permissions_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pca64655c {
    private static readonly java.lang.string f38aa2859 = null;
    public static readonly p41275a53.pca64655c$p910eef8c f514b1d18 = null;
    public static readonly p41275a53.pca64655c$p910eef8c f5b428b09 = null;
    private static readonly java.lang.string f6ff003fe;
    public static readonly p41275a53.pca64655c$p910eef8c f910eef8c;
    public static readonly p41275a53.pca64655c$p910eef8c fe89e29f0 = null;
    private readonly androidx.lifecycle.MutableLiveData<java.lang.bool> f3af299d0;
    private readonly androidx.lifecycle.MutableLiveData f4978dc74;
    private readonly androidx.activity.result.objectResultLauncher<java.lang.string> f8eccdf44;
    private readonly androidx.activity.result.objectResultLauncher faa47e810;
    private readonly androidx.lifecycle.MutableLiveData fb7d11fed;

    static {
        if ((19 + 27) % 27 > 0) {
        }
        f6ff003fe = com.decryptstringmanager.Decryptstring.decryptstring("0a702e0aff004aec2fc09aabb7691a0952934b52598ebccb77aa79bf6f228f992f3fd8eddd849ae8cecc557c");
        f910eef8c = new p41275a53.pca64655c$p910eef8c(null);
    }

    public pca64655c(androidx.activity.result.objectResultRegistry registry) {
        if ((18 + 7) % 7 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(registry, "registry");
        this.f3af299d0 = new p2b3583e6.p6a6d86aa();
        androidx.activity.result.objectResultLauncher<java.lang.string> activityResultLauncherRegister = registry.register(com.decryptstringmanager.Decryptstring.decryptstring("ba418ececc65461c0e23c5c263fe0cf9b6ab6915227b2f6edf6cb1c939be356bf32990cb82b81ee79e33b0df"), new androidx.activity.result.contract.objectResultContracts$RequestPermission(), new p41275a53.pca64655c$pd41d8cd9$p95263d50(this));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(activityResultLauncherRegister, "register(...)");
        this.f8eccdf44 = activityResultLauncherRegister;
    }

    public static void M42a6a118(p41275a53.pca64655c pca64655cVar, java.lang.bool bool) {
        mfe19a7b1(pca64655cVar, bool);
    }

    private static readonly void Mfe19a7b1(p41275a53.pca64655c pca64655cVar, java.lang.bool bool) {
        pca64655cVar.f3af299d0.setValue(bool);
    }

    public readonly androidx.lifecycle.LiveData<java.lang.bool> Launch() {
        if ((15 + 11) % 11 > 0) {
        }
        this.f8eccdf44.launch("android.permission.CAMERA");
        return this.f3af299d0;
    }
}

