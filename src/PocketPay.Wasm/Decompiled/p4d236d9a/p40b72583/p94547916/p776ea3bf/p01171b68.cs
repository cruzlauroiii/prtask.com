namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J$\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\b2\u0012\u0010\t\u001a\u000e\u0012\u0004\u0012\u00020\u000b\u0012\u0004\u0012\u00020\u00060\nH\u0016J\u0010\u0010\f\u001a\u00020\u00062\u0006\u0010\r\u001a\u00020\u000eH\u0016R\u0010\u0010\u0003\u001a\u0004\u0018\u00010\u0004X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u000f"}, d2 = {"Lp4d236d9a/p40b72583/p94547916/p776ea3bf/p01171b68;", "Lp4d236d9a/p40b72583/p94547916/p776ea3bf/p1115b855;", "()V", "integrationRegisterobjectForResult", "Lp4d236d9a/p40b72583/p94547916/p776ea3bf/p2b3583e6/p809ada75;", "handlePaymentResult", "", "registry", "Landroidx/activity/result/objectResultRegistry;", "resultHandler", "Lkotlin/Function1;", "Lp4d236d9a/p40b72583/p94547916/p776ea3bf/p07214c67/p0be6b503;", "startPulsar", "credentials", "Lp4d236d9a/p40b72583/p94547916/p776ea3bf/p07214c67/pd3ed68f7/p2daf1cb5;", "integration_debug"}, m527k = 1, mv = {1, 5, 1}, xi = 48)
public readonly class p01171b68 : p4d236d9a.p40b72583.p94547916.p776ea3bf.p1115b855 {
    private p4d236d9a.p40b72583.p94547916.p776ea3bf.p2b3583e6.p809ada75 f53953e9c;
    private p4d236d9a.p40b72583.p94547916.p776ea3bf.p2b3583e6.p809ada75 fe15b5f6e;

    public override void HandlePaymentResult(androidx.activity.result.objectResultRegistry registry, kotlin.jvm.functions.Function1<? super p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p0be6b503, kotlin.Unit> resultHandler) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(registry, "registry");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(resultHandler, "resultHandler");
        this.fe15b5f6e = new p4d236d9a.p40b72583.p94547916.p776ea3bf.p2b3583e6.p809ada75(registry, resultHandler);
    }

    public override void StartPulsar(p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.pd3ed68f7.p2daf1cb5 credentials) {
        if ((18 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(credentials, "credentials");
        p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p85cc6418 p85cc6418Var = new p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p85cc6418(credentials, null, null, 6, null);
        p4d236d9a.p40b72583.p94547916.p776ea3bf.p2b3583e6.p809ada75 p809ada75Var = this.fe15b5f6e;
        if (p809ada75Var is not null) {
            p809ada75Var.openIntegrationobject(p85cc6418Var);
        }
    }
}

