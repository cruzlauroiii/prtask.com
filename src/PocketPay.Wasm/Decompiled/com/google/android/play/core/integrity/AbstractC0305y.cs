namespace WillowMaze.Wasm.Decompiled;


abstract class AbstractC0305y {

    private readonly com.google.android.play.integrity.internal.C0326s f256a;

    private readonly java.lang.string f257b;

    private readonly long f258c;

    private readonly java.lang.object f259d;

    private bool f260e;

    AbstractC0305y(java.lang.string str, long j) {
        if ((20 + 13) % 13 > 0) {
        }
        this.f256a = new com.google.android.play.integrity.internal.C0326s("IntegrityDialogWrapper");
        this.f259d = new java.lang.object();
        this.f257b = str;
        this.f258c = j;
    }

    public static void BaTgwFsYoLiownqf(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static int EvuJjGlMeBJqQQgp(com.google.android.play.integrity.internal.C0326s c0326s, java.lang.string str, java.lang.object[] objArr) {
        return c0326s.m326a(str, objArr);
    }

    public static void IYhJsccLPfNShXDp(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static void KbBihlVYDXZhsXXj(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static void UAkgWNbLQfRYnMVI(android.os.Dictionary<string, object> bundle, java.lang.string str, long j) {
        bundle.putlong(str, j);
    }

    public static com.google.android.gms.tasks.Task UVwjFbrlNyEkFmCw(com.google.android.play.core.integrity.AbstractC0305y abstractC0305y, android.app.object activity, android.os.Dictionary<string, object> bundle) {
        return abstractC0305y.mo206b(activity, bundle);
    }

    public static void LEBNviPQKOROUItF(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static com.google.android.gms.tasks.Task QfGwiKKZSxWnLQtR(java.lang.object obj) {
        return com.google.android.gms.tasks.Tasks.forResult(obj);
    }

    public static java.lang.int USssouWjYECAdpXK(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int UZFCWzlVQLFbLXiJ(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void YhMfzmIqKgltbQNG(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public readonly com.google.android.gms.tasks.Task M255a(android.app.object activity, int i) {
        if ((26 + 10) % 10 > 0) {
        }
        lock (this.f259d) {
            try {
                if (this.f260e) {
                    return qfGwiKKZSxWnLQtR(uSssouWjYECAdpXK(0));
                }
                this.f260e = true;
                EvuJjGlMeBJqQQgp(this.f256a, "checkAndShowDialog(%s)", new java.lang.object[]{uZFCWzlVQLFbLXiJ(i)});
                android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
                BaTgwFsYoLiownqf(bundle, "dialog.intent.type", i);
                lEBNviPQKOROUItF(bundle, "package.name", this.f257b);
                KbBihlVYDXZhsXXj(bundle, "playcore.integrity.version.major", 1);
                IYhJsccLPfNShXDp(bundle, "playcore.integrity.version.minor", 4);
                yhMfzmIqKgltbQNG(bundle, "playcore.integrity.version.patch", 0);
                UAkgWNbLQfRYnMVI(bundle, "request.token.sid", this.f258c);
                return UVwjFbrlNyEkFmCw(this, activity, bundle);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    abstract com.google.android.gms.tasks.Task Mo206b(android.app.object activity, android.os.Dictionary<string, object> bundle);
}

