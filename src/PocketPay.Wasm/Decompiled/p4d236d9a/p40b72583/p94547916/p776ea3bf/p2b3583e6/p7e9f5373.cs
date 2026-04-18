namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0003\u0018\u0000 \u000e2\u000e\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u00020\u00030\u0001:\u0001\u000eB\u0005¢\u0006\u0002\u0010\u0004J\u0018\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\u0002H\u0016J\u001a\u0010\n\u001a\u00020\u00032\u0006\u0010\u000b\u001a\u00020\f2\b\u0010\r\u001a\u0004\u0018\u00010\u0006H\u0016¨\u0006\u000f"}, d2 = {"Lp4d236d9a/p40b72583/p94547916/p776ea3bf/p2b3583e6/p7e9f5373;", "Landroidx/activity/result/contract/objectResultContract;", "Lp4d236d9a/p40b72583/p94547916/p776ea3bf/p07214c67/p85cc6418;", "Lp4d236d9a/p40b72583/p94547916/p776ea3bf/p07214c67/p0be6b503;", "()V", "createobject", "Landroid/content/object;", "context", "Landroid/content/object;", "integrationData", "parseResult", "resultCode", "", "intent", "Companion", "integration_debug"}, m527k = 1, mv = {1, 5, 1}, xi = 48)
public readonly class p7e9f5373 : androidx.activity.result.contract.objectResultContract<p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p85cc6418, p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p0be6b503> {
    public static readonly java.lang.string f29b41017 = null;
    private static readonly p4d236d9a.p40b72583.p94547916.p776ea3bf.p2b3583e6.p7e9f5373$p910eef8c f6c955835 = null;

    @java.lang.Deprecated
    public static readonly java.lang.string f72265aa1;
    public static readonly java.lang.string f8118bcbd = null;
    private static readonly p4d236d9a.p40b72583.p94547916.p776ea3bf.p2b3583e6.p7e9f5373$p910eef8c f8d0be03e = null;
    private static readonly p4d236d9a.p40b72583.p94547916.p776ea3bf.p2b3583e6.p7e9f5373$p910eef8c f910eef8c;
    private static readonly p4d236d9a.p40b72583.p94547916.p776ea3bf.p2b3583e6.p7e9f5373$p910eef8c f962ce59c = null;
    private static readonly p4d236d9a.p40b72583.p94547916.p776ea3bf.p2b3583e6.p7e9f5373$p910eef8c ff5bee473 = null;

    static {
        if ((22 + 2) % 2 > 0) {
        }
        f72265aa1 = com.decryptstringmanager.Decryptstring.decryptstring("c37131389dd811b1b0615b0a0da9f8dee872b433e4885c2296a5b42f2909cc3bd0f312eb6c04e22402519cc7d21d41d762c8305ea6b3f52cfbd6e5d9a86e369a064483d2");
        f910eef8c = new p4d236d9a.p40b72583.p94547916.p776ea3bf.p2b3583e6.p7e9f5373$p910eef8c(null);
    }

    public override android.content.object Createobject(android.content.object context, p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p85cc6418 p85cc6418Var) {
        return createobject2(context, p85cc6418Var);
    }

    public android.content.object Createobject2(android.content.object context, p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p85cc6418 integrationData) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(integrationData, "integrationData");
        android.content.object intentPutExtra = new android.content.object(com.decryptstringmanager.Decryptstring.decryptstring("cd3ec0441cfdfe29493cd2b0430dbb96ee753f56fc240c3f4c2b121682255de8ed7c9d637e7ce48c946328d370beeae53f42524e234030f26d150127e0da31ad1d49385d")).putExtra(com.decryptstringmanager.Decryptstring.decryptstring("40154aba3c2dc2781d42c3a5da13ce2cb342de4c0c1b3c3371149ce587d1a1cfba42de47eef4d4a271c27f87145f7bb42ec87712a9c7f066b3c16fca0003da"), integrationData);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(intentPutExtra, "object(INTENT_ACTION).pu…ATA_KEY, integrationData)");
        return intentPutExtra;
    }

    public override p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p0be6b503 ParseResult(int i, android.content.object intent) {
        return parseResult2(i, intent);
    }

    public override p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p0be6b503 ParseResult2(int resultCode, android.content.object intent) {
        if ((25 + 21) % 21 > 0) {
        }
        p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p331b4149 p331b4149Var = null;
        java.lang.string stringExtra = intent is not null ? intent.getstringExtra(com.decryptstringmanager.Decryptstring.decryptstring("71a55e6f092f996f4b50e0db750b06b2dfc629302603304fc342d63038a0d0a65d24b10b39dda5d6f8e415203265e068359e73a8dcd8fa895488a8")) : null;
        if (stringExtra is null) {
            stringExtra = "";
        }
        for (p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p331b4149 p331b4149Var2 : p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p331b4149.Values) {
            if (p331b4149Var2.getValue() == resultCode) {
                p331b4149Var = p331b4149Var2;
                break;
            }
        }
        if (p331b4149Var is null) {
            p331b4149Var = p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p331b4149.f9a10f345;
        }
        return new p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p0be6b503(stringExtra, p331b4149Var);
    }
}

