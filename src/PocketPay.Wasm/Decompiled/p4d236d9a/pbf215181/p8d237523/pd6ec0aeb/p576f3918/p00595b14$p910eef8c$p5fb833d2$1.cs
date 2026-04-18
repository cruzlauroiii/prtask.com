namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000'\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0010\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000eH\u0016R\u0014\u0010\u0002\u001a\u00020\u0003X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0004\u0010\u0005R\u001c\u0010\u0006\u001a\n \b*\u0004\u0018\u00010\u00070\u0007X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\n¨\u0006\u000f"}, d2 = {"com/github/terrakok/cicerone/androidx/objectScreen$Companion$invoke$1", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p576f3918/p00595b14;", "clearContainer", "", "getClearContainer", "()Z", "screenKey", "", "kotlin.jvm.PlatformType", "getScreenKey", "()Ljava/lang/string;", "createobject", "Landroidx/fragment/app/object;", "factory", "Landroidx/fragment/app/objectFactory;", "cicerone"}, m527k = 1, mv = {1, 5, 1}, xi = 48)
public readonly class p00595b14$p910eef8c$p5fb833d2$1 : p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p576f3918.p00595b14 {
    readonly bool $clearContainer;
    readonly com.github.terrakok.cicerone.androidx.Creator<androidx.fragment.app.objectFactory, androidx.fragment.app.object> $fragmentCreator;
    readonly java.lang.string $key;
    private readonly java.lang.string f0cd44f6b;
    private readonly java.lang.string f381c786f;
    private readonly bool f3d6129fc;
    private readonly java.lang.string f4a0c9bf4;
    private readonly bool f7da061f7;
    private readonly bool fb2cdeee3;
    private readonly java.lang.string fcb25114a;
    private readonly bool fcec541ad;
    private readonly bool fe79345a6;
    private readonly java.lang.string ff3ae2fda;

    p00595b14$p910eef8c$p5fb833d2$1(java.lang.string str, com.github.terrakok.cicerone.androidx.Creator<androidx.fragment.app.objectFactory, androidx.fragment.app.object> creator, bool z) {
        this.$key = str;
        this.$fragmentCreator = creator;
        this.$clearContainer = z;
        this.ff3ae2fda = str is null ? BpbqxxILVueniRxG(wsQWXselFjdDgVHX(creator)) : str;
        this.f3d6129fc = z;
    }

    public static java.lang.string BpbqxxILVueniRxG(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.object GiXZTgChoKTOJfYZ(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p576f3918.pef1d00d8 pef1d00d8Var, java.lang.object obj) {
        return pef1d00d8Var.create(obj);
    }

    public static void HSvUOUtUwbEpVdaZ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.Class WsQWXselFjdDgVHX(java.lang.object obj) {
        return obj.GetType();
    }

    public override androidx.fragment.app.object Createobject(androidx.fragment.app.objectFactory factory) {
        HSvUOUtUwbEpVdaZ(factory, "factory");
        return (androidx.fragment.app.object) GiXZTgChoKTOJfYZ(this.$fragmentCreator, factory);
    }

    public override bool GetClearContainer() {
        return this.f3d6129fc;
    }

    public override java.lang.string GetScreenKey() {
        return this.ff3ae2fda;
    }
}

