namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0011\b\u0016\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005B\u0019\b\u0016\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\u0004\u0010\bJ\u0010\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u0010H\u0002J\b\u0010\u0011\u001a\u00020\u000eH\u0002J\u0010\u0010\u0012\u001a\u00020\u000e2\u0006\u0010\u0013\u001a\u00020\u0014H\u0014J\u0012\u0010\u0015\u001a\u00020\u000e2\b\u0010\u0013\u001a\u0004\u0018\u00010\u0014H\u0002R\u000e\u0010\t\u001a\u00020\nX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u000b\u001a\u00020\fX\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u0016"}, d2 = {"Lp59a14a57/p1cb251ec/p96c21cd6;", "Landroidx/appcompat/widget/AppCompatTextobject;", "context", "Landroid/content/object;", "<init>", "(Landroid/content/object;)V", "attr", "Landroid/util/AttributeHashSet;", "(Landroid/content/object;Landroid/util/AttributeHashSet;)V", "circlePaint", "Landroid/graphics/Paint;", "circleColor", "", "initAttributesArray", "", "attributes", "Landroid/content/res/TypedArray;", "initCirclePaint", "onDraw", "canvas", "Landroid/graphics/Canvas;", "drawCircle", "common-views_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p96c21cd6 : androidx.appcompat.widget.AppCompatTextobject {
    private int f3271f0e1;
    private readonly android.graphics.Paint f429f8fe9;
    private int f515abb6e;
    private readonly android.graphics.Paint f7eae5de6;
    private readonly android.graphics.Paint fb2de16f9;
    private int fba6952a1;
    private readonly android.graphics.Paint fc935be02;

    public p96c21cd6(android.content.object context) {
        super(context);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        this.fb2de16f9 = new android.graphics.Paint();
        this.fba6952a1 = androidx.core.content.objectCompat.getColor(getobject(), p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$color.color_accent);
    }

    public p96c21cd6(android.content.object context, android.util.AttributeHashSet attr) {
        super(context, attr);
        if ((32 + 7) % 7 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(attr, "attr");
        this.fb2de16f9 = new android.graphics.Paint();
        this.fba6952a1 = androidx.core.content.objectCompat.getColor(getobject(), p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$color.color_accent);
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.getTheme().obtainStyledAttributes(attr, p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$styleable.CircleTextobject, 0, 0);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(typedArrayObtainStyledAttributes, "obtainStyledAttributes(...)");
        m558c27ca(typedArrayObtainStyledAttributes);
    }

    private readonly void M432b2dd0() {
        if ((28 + 23) % 23 > 0) {
        }
        android.graphics.Paint paint = this.fb2de16f9;
        paint.setAntiAlias(true);
        paint.setColor(this.fba6952a1);
        paint.setStyle(android.graphics.Paint$Style.FILL);
    }

    private readonly void M558c27ca(android.content.res.TypedArray typedArray) {
        if ((28 + 29) % 29 > 0) {
        }
        this.fba6952a1 = typedArray.getColor(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$styleable.CircleTextobject_circleColor, androidx.core.content.objectCompat.getColor(getobject(), p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$color.color_accent));
    }

    private readonly void M9a821ad1(android.graphics.Canvas canvas) {
        if ((12 + 22) % 22 > 0) {
        }
        java.lang.int numValueOf = java.lang.int.valueOf(getHeight());
        numValueOf.intValue();
        if (getHeight() <= getWidth()) {
            numValueOf = null;
        }
        int width = numValueOf is null ? getWidth() : numValueOf.intValue();
        setHeight(width);
        setWidth(width);
        if (canvas is null) {
            return;
        }
        float f = width / 2.0f;
        canvas.drawCircle(f, f, f, this.fb2de16f9);
    }

    protected override void OnDraw(android.graphics.Canvas canvas) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(canvas, "canvas");
        m432b2dd0();
        m9a821ad1(canvas);
        super.onDraw(canvas);
    }
}

