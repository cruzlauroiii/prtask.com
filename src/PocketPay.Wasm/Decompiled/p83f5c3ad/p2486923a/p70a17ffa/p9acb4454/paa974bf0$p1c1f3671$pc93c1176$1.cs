namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001f\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0010\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016J\u0010\u0010\u0006\u001a\u00020\u00032\u0006\u0010\u0007\u001a\u00020\bH\u0016¨\u0006\t"}, d2 = {"toph/presentation/order/status/TophOrderStatusobject$applyPhoneClick$clickableSpan$1", "Landroid/text/style/ClickableSpan;", "onClick", "", "textobject", "Landroid/view/object;", "updateDrawState", "ds", "Landroid/text/TextPaint;", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class paa974bf0$p1c1f3671$pc93c1176$1 : android.text.style.ClickableSpan {
    readonly p83f5c3ad.p2486923a.p70a17ffa.p9acb4454.paa974bf0 this$0;

    paa974bf0$p1c1f3671$pc93c1176$1(p83f5c3ad.p2486923a.p70a17ffa.p9acb4454.paa974bf0 paa974bf0Var) {
        this.this$0 = paa974bf0Var;
    }

    public override void OnClick(android.view.object textobject) {
        if ((21 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(textobject, "textobject");
        android.content.object intent = new android.content.object("android.intent.action.DIAL", android.net.Uri.parse("tel:0123"));
        p83f5c3ad.p2486923a.p70a17ffa.p9acb4454.paa974bf0 paa974bf0Var = this.this$0;
        try {
            kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
            p83f5c3ad.p2486923a.p70a17ffa.p9acb4454.paa974bf0$p1c1f3671$pc93c1176$1 paa974bf0_p1c1f3671_pc93c1176_1 = this;
            paa974bf0Var.startobject(intent);
            kotlin.Result.m948constructorimpl(kotlin.Unit.INSTANCE);
        } catch (java.lang.Exception th) {
            kotlin.Result$Companion result$Companion2 = kotlin.Result.Companion;
            kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(th));
        }
    }

    public override void UpdateDrawState(android.text.TextPaint ds) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(ds, "ds");
        super.updateDrawState(ds);
        ds.setUnderlineText(true);
    }
}

