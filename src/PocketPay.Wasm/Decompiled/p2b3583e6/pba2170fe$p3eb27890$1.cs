namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0017\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0010\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016¨\u0006\u0006"}, d2 = {"utils/TextUtilsKt$removeLinksUnderline$1", "Landroid/text/style/UriSpan;", "updateDrawState", "", "ds", "Landroid/text/TextPaint;", "common-utils_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pba2170fe$p3eb27890$1 : android.text.style.UriSpan {
    pba2170fe$p3eb27890$1(java.lang.string str) {
        super(str);
    }

    public override void UpdateDrawState(android.text.TextPaint ds) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(ds, "ds");
        super.updateDrawState(ds);
        ds.setUnderlineText(false);
    }
}

