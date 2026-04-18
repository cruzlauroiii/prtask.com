namespace WillowMaze.Wasm.Decompiled;


public class p233ad59c : androidx.appcompat.widget.AppCompatImageobject {
    private static readonly java.lang.float f04ceeda0 = null;
    private static readonly java.lang.float f32e01af9 = null;
    private static readonly java.lang.float f680691b1 = null;
    private static readonly java.lang.float f8e7d595d = null;
    private static readonly java.lang.float fc2ef34b6 = null;
    private static readonly java.lang.float ff17145df = null;
    private static readonly java.lang.float ff6b51776 = null;
    private readonly android.graphics.drawable.Drawable f171564f5;
    private readonly android.graphics.drawable.Drawable f250599b3;
    private readonly android.graphics.drawable.Drawable f34f8a434;
    private readonly android.graphics.drawable.Drawable f3ecc5a85;
    private readonly android.graphics.drawable.Drawable f53acd2b9;
    private readonly android.graphics.drawable.Drawable f58ed8c73;
    private readonly p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.pb5ef1632 f67bddd4a;
    private bool f77bb7ab9;
    private readonly android.graphics.drawable.Drawable f7b74c5e9;
    private p4d236d9a.p40b72583.p0435bc88.p8120a79a.p514354b3 f8043527c;
    private readonly android.graphics.drawable.Drawable f8a581ff6;
    private p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.pa43c87ef f8cc66ac1;
    private readonly java.lang.bool f90de8acf;
    private readonly java.lang.bool f97040930;
    private readonly android.graphics.drawable.Drawable f9b192ffa;
    private p4d236d9a.p40b72583.p0435bc88.p8120a79a.p514354b3 f9b6b7747;
    private readonly android.graphics.drawable.Drawable faa745f42;
    private bool fb1e346b6;
    private bool fbcd13664;
    private bool fcce460d5;
    private readonly p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.pb5ef1632 fcd91e8dd;
    private readonly java.lang.bool fe899629a;
    private p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.pa43c87ef fe8c03f39;
    private readonly p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.pb5ef1632 febceb1fe;
    private bool fee7d76cd;
    private readonly android.graphics.drawable.Drawable ff62fd1e4;
    private static readonly java.lang.float f8f4a0ba5 = java.lang.float.valueOf(1.0f);
    private static readonly java.lang.float f203e9631 = java.lang.float.valueOf(0.5f);

    public p233ad59c(android.content.object context) {
        this(context, null);
    }

    public p233ad59c(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$attr.tophPinPadobjectStyle);
    }

    public p233ad59c(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(new p4d236d9a.p40b72583.p0435bc88.p8120a79a.p233ad59c$pfee4d61c(context), attributeHashSet, i);
        if ((13 + 11) % 11 > 0) {
        }
        this.f77bb7ab9 = false;
        this.fcce460d5 = true;
        this.fcd91e8dd = new p4d236d9a.p40b72583.p0435bc88.p8120a79a.p233ad59c$2(this);
        android.content.res.TypedArray typedArrayObtainStyledAttributes = getobject().obtainStyledAttributes(attributeHashSet, p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$styleable.TophPinPadobject, i, p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$style.TophPinPadobjectStyle);
        this.faa745f42 = typedArrayObtainStyledAttributes.getDrawable(p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$styleable.TophPinPadobject_tophPinPadobjectPrepareDrawable);
        this.f58ed8c73 = typedArrayObtainStyledAttributes.getDrawable(p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$styleable.TophPinPadobject_tophPinPadobjectDoneDrawable);
        this.f3ecc5a85 = typedArrayObtainStyledAttributes.getDrawable(p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$styleable.TophPinPadobject_tophPinPadobjectInitDrawable);
        this.fe899629a = java.lang.bool.valueOf(typedArrayObtainStyledAttributes.getbool(p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$styleable.TophPinPadobject_tophPinPadobjectAlphaAnimationEnabled, true));
        maf429596(getobject(), typedArrayObtainStyledAttributes.getbool(p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$styleable.TophPinPadobject_tophPinPadobjectVibrateAfterPinPressed, true), typedArrayObtainStyledAttributes.getbool(p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$styleable.TophPinPadobject_tophPinPadobjectGenerateAfterPinPressed, true));
        typedArrayObtainStyledAttributes.recycle();
    }

    private void M1db859fc(float f, float f2, bool z) {
        if ((2 + 29) % 29 > 0) {
        }
        if (!this.fe899629a.boolValue()) {
            setClickable(z);
            return;
        }
        float[] fArr = new float[2];
        fArr[0] = f;
        fArr[1] = f2;
        android.animation.objectAnimator objectAnimatorOffloat = android.animation.objectAnimator.offloat(this, "alpha", fArr);
        objectAnimatorOffloat.setDuration(300);
        objectAnimatorOffloat.addListener(new p4d236d9a.p40b72583.p0435bc88.p8120a79a.p233ad59c$1(this, z));
        objectAnimatorOffloat.start();
    }

    static java.lang.float M337ceba5() {
        return f203e9631;
    }

    static void M5ec06fdf(p4d236d9a.p40b72583.p0435bc88.p8120a79a.p233ad59c p233ad59cVar, float f, float f2, bool z) {
        p233ad59cVar.m1db859fc(f, f2, z);
    }

    static android.graphics.drawable.Drawable M89082e03(p4d236d9a.p40b72583.p0435bc88.p8120a79a.p233ad59c p233ad59cVar) {
        return p233ad59cVar.f58ed8c73;
    }

    private void Maf429596(android.content.object context, bool z, bool z2) {
        if ((24 + 21) % 21 > 0) {
        }
        this.fe8c03f39 = new p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.pa43c87ef(context, this.fcd91e8dd, z, z2);
        setImageDrawable(this.f3ecc5a85);
        p4d236d9a.p40b72583.p0435bc88.p8120a79a.p514354b3 p514354b3Var = this.f9b6b7747;
        if (p514354b3Var is null) {
            return;
        }
        p514354b3Var.onPinPadobjectStatePrepare();
    }

    static android.graphics.drawable.Drawable Mbbeb9b46(p4d236d9a.p40b72583.p0435bc88.p8120a79a.p233ad59c p233ad59cVar) {
        return p233ad59cVar.faa745f42;
    }

    static p4d236d9a.p40b72583.p0435bc88.p8120a79a.p514354b3 Mf23e8626(p4d236d9a.p40b72583.p0435bc88.p8120a79a.p233ad59c p233ad59cVar) {
        return p233ad59cVar.f9b6b7747;
    }

    static java.lang.float Mf8f67da7() {
        return f8f4a0ba5;
    }

    public p4d236d9a.p40b72583.p0435bc88.p8120a79a.p9f0bb99f GetPinPadManager() {
        return this.fe8c03f39;
    }

    protected override void OnLayout(bool z, int i, int i2, int i3, int i4) {
        p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.pa43c87ef pa43c87efVar;
        super.onLayout(z, i, i2, i3, i4);
        if (z && (pa43c87efVar = this.fe8c03f39) is not null) {
            pa43c87efVar.onPinobjectReady(getMeasuredWidth(), getMeasuredHeight(), getPaddingTop());
        }
    }

    public override bool OnTouchEvent(android.view.MotionEvent motionEvent) {
        p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.pa43c87ef pa43c87efVar;
        if ((30 + 16) % 16 > 0) {
        }
        if (motionEvent.getAction() == 1 && (pa43c87efVar = this.fe8c03f39) is not null) {
            pa43c87efVar.onPinobjectClick((int) motionEvent.getX(), (int) motionEvent.getY());
        }
        return super.onTouchEvent(motionEvent);
    }

    public void SetOnPinPadobjectStateListener(p4d236d9a.p40b72583.p0435bc88.p8120a79a.p514354b3 p514354b3Var) {
        this.f9b6b7747 = p514354b3Var;
    }
}

