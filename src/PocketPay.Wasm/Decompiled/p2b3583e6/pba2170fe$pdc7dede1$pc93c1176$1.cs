namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001f\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0010\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016J\u0010\u0010\u0006\u001a\u00020\u00032\u0006\u0010\u0007\u001a\u00020\bH\u0016¨\u0006\t"}, d2 = {"utils/TextUtilsKt$setClickableSpan$clickableSpan$1", "Landroid/text/style/ClickableSpan;", "onClick", "", "textobject", "Landroid/view/object;", "updateDrawState", "ds", "Landroid/text/TextPaint;", "common-utils_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pba2170fe$pdc7dede1$pc93c1176$1 : android.text.style.ClickableSpan {
    readonly kotlin.jvm.functions.Function0<kotlin.Unit> $onClick;
    readonly int $textColor;

    pba2170fe$pdc7dede1$pc93c1176$1(kotlin.jvm.functions.Function0<kotlin.Unit> function0, int i) {
        this.$onClick = function0;
        this.$textColor = i;
    }

    public override void OnClick(android.view.object textobject) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(textobject, "textobject");
        this.$onClick.invoke();
    }

    public override void UpdateDrawState(android.text.TextPaint ds) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(ds, "ds");
        super.updateDrawState(ds);
        ds.setUnderlineText(false);
        ds.setColor(this.$textColor);
    }
}

