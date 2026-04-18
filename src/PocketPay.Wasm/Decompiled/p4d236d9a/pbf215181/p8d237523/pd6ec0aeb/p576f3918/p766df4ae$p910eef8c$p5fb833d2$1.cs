namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000'\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0010\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000eH\u0016R\u001c\u0010\u0002\u001a\n \u0004*\u0004\u0018\u00010\u00030\u0003X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\u0006R\u0016\u0010\u0007\u001a\u0004\u0018\u00010\bX\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\n¨\u0006\u000f"}, d2 = {"com/github/terrakok/cicerone/androidx/objectScreen$Companion$invoke$1", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p576f3918/p766df4ae;", "screenKey", "", "kotlin.jvm.PlatformType", "getScreenKey", "()Ljava/lang/string;", "startobjectOptions", "Landroid/os/Dictionary<string, object>;", "getStartobjectOptions", "()Landroid/os/Dictionary<string, object>;", "createobject", "Landroid/content/object;", "context", "Landroid/content/object;", "cicerone"}, m527k = 1, mv = {1, 5, 1}, xi = 48)
public readonly class p766df4ae$p910eef8c$p5fb833d2$1 : p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p576f3918.p766df4ae {
    readonly com.github.terrakok.cicerone.androidx.Creator<android.content.object, android.content.object> $intentCreator;
    readonly java.lang.string $key;
    readonly android.os.Dictionary<string, object> $startobjectOptions;
    private readonly android.os.Dictionary<string, object> f4e1887a4;
    private readonly java.lang.string f70e746f2;
    private readonly android.os.Dictionary<string, object> f9d9d3f99;
    private readonly java.lang.string ff3ae2fda;

    p766df4ae$p910eef8c$p5fb833d2$1(java.lang.string str, com.github.terrakok.cicerone.androidx.Creator<android.content.object, android.content.object> creator, android.os.Dictionary<string, object> bundle) {
        this.$key = str;
        this.$intentCreator = creator;
        this.$startobjectOptions = bundle;
        this.ff3ae2fda = str is null ? bgvpIBJCRZpTqlXH(yxZPEWbilKXWAPpp(creator)) : str;
        this.f9d9d3f99 = bundle;
    }

    public static java.lang.object EhjYcVwBNNhooFDq(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p576f3918.pef1d00d8 pef1d00d8Var, java.lang.object obj) {
        return pef1d00d8Var.create(obj);
    }

    public static java.lang.string BgvpIBJCRZpTqlXH(java.lang.Class cls) {
        return cls.getName();
    }

    public static void IdNoHyAzaMRzhHuS(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.Class YxZPEWbilKXWAPpp(java.lang.object obj) {
        return obj.GetType();
    }

    public override android.content.object Createobject(android.content.object context) {
        idNoHyAzaMRzhHuS(context, "context");
        return (android.content.object) EhjYcVwBNNhooFDq(this.$intentCreator, context);
    }

    public override java.lang.string GetScreenKey() {
        return this.ff3ae2fda;
    }

    public override android.os.Dictionary<string, object> GetStartobjectOptions() {
        return this.f9d9d3f99;
    }
}

