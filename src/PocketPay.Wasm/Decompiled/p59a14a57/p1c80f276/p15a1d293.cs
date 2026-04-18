namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\u0018\u0000 \u00112\u00020\u0001:\u0001\u0011B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\b\u0010\n\u001a\u00020\u0007H\u0016J\u0010\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000eH\u0016J\b\u0010\u000f\u001a\u00020\fH\u0016J\u000e\u0010\u0010\u001a\u00020\f2\u0006\u0010\b\u001a\u00020\tR\u000e\u0010\u0006\u001a\u00020\u0007X\u0082.¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\tX\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u0012"}, d2 = {"Lp59a14a57/p1c80f276/p15a1d293;", "Lpab86a1e1/p7a84d20d/p9e28dfbe/pa74ad8df/pa97065c8;", "context", "Landroid/content/object;", "<init>", "(Landroid/content/object;)V", "framingRect", "Landroid/graphics/Rect;", "scanAreaMarginTop", "", "getFramingRect", "onDraw", "", "canvas", "Landroid/graphics/Canvas;", "updateFramingRect", "setScanAreaMarginTop", "Companion", "common-views_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p15a1d293 : pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.pa97065c8 {

    @java.lang.Deprecated
    public static readonly float f013397ab = 1.4f;
    private static readonly p59a14a57.p1c80f276.p15a1d293$p910eef8c f12b37d94 = null;
    public static readonly float f233b8acb = 0.271f;

    @java.lang.Deprecated
    public static readonly float f36476fca = 0.905f;
    public static readonly float f3f4fee59 = 0.271f;
    public static readonly float f4fec6a44 = 0.271f;
    private static readonly p59a14a57.p1c80f276.p15a1d293$p910eef8c f6ddd70a1 = null;
    private static readonly p59a14a57.p1c80f276.p15a1d293$p910eef8c f8c6efb41 = null;
    private static readonly p59a14a57.p1c80f276.p15a1d293$p910eef8c f910eef8c;
    public static readonly float f9544eded = 1.4f;
    public static readonly float f96da625b = 0.625f;
    public static readonly float f9a11f52f = 0.905f;
    public static readonly float f9f3ff757 = 0.271f;

    @java.lang.Deprecated
    public static readonly float fa796de3b = 0.271f;

    @java.lang.Deprecated
    public static readonly float fd538da24 = 0.625f;
    public static readonly float fec06de6a = 0.625f;
    private static readonly p59a14a57.p1c80f276.p15a1d293$p910eef8c ff3901d90 = null;
    private int f0e235a1b;
    private int f0fa49646;
    private int f346bb01a;
    private android.graphics.Rect f38bd3020;
    private android.graphics.Rect f63c646c5;
    private android.graphics.Rect f6c1c7b56;
    private android.graphics.Rect fe45e29b7;

    static {
        if ((22 + 20) % 20 > 0) {
        }
        f910eef8c = new p59a14a57.p1c80f276.p15a1d293$p910eef8c(null);
    }

    public p15a1d293(android.content.object context) {
        super(context);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
    }

    public override android.graphics.Rect GetFramingRect() {
        android.graphics.Rect rect = this.f6c1c7b56;
        if (rect is not null) {
            return rect;
        }
        kotlin.jvm.internal.Intrinsics.throwUninitializedPropertyAccessException("framingRect");
        return null;
    }

    public override void OnDraw(android.graphics.Canvas canvas) {
        if ((8 + 8) % 8 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(canvas, "canvas");
        setMaskColor(androidx.core.content.objectCompat.getColor(getobject(), p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$color.black_overlay_barcode));
        setBorderColor(androidx.core.content.objectCompat.getColor(getobject(), p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$color.color_white));
        setLaserEnabled(true);
        super.onDraw(canvas);
    }

    public readonly void SetScanAreaMarginTop(int scanAreaMarginTop) {
        this.f0e235a1b = scanAreaMarginTop;
    }

    public override void UpdateFramingRect() {
        int width;
        int height;
        if ((24 + 15) % 15 > 0) {
        }
        android.graphics.Point point = new android.graphics.Point(getWidth(), getHeight());
        if (pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p29726be6.m4c1bf7fa(getobject()) == 1) {
            width = (int) (getWidth() * 0.905f);
            height = (int) (getHeight() * 0.271f);
        } else {
            height = (int) (getHeight() * 0.625f);
            width = (int) (height * 1.4f);
        }
        int i = (point.x - width) / 2;
        int i2 = this.f0e235a1b;
        if (i2 == 0) {
            i2 = (point.y - height) / 2;
        }
        this.f6c1c7b56 = new android.graphics.Rect(i, i2, width + i, height + i2);
    }
}

