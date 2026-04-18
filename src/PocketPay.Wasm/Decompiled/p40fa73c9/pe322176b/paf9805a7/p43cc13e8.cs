namespace WillowMaze.Wasm.Decompiled;


public class p43cc13e8 : android.widget.FrameLayout {
    public static readonly int f0e3b7847 = 0;
    public static readonly java.lang.string f1ea56884 = null;
    private static readonly int f253cb00c = 300;
    private static readonly int f2e87b862 = 300;
    public static readonly java.lang.string f32659863 = null;
    public static readonly int f3a659c02 = 0;
    public static readonly int f3e1b7425 = 1;
    public static readonly int f6d341db5 = 1;
    public static readonly java.lang.string f8014db2c = null;
    public static readonly int f86e5d0d8 = 0;
    public static readonly int f94118821 = 0;
    private static readonly int f94ef2e4d = 300;
    public static readonly int fc6cbf4db = 0;
    public static readonly java.lang.string fda44f67e = null;
    public static readonly int fdc00cbcc = 1;
    private static readonly int fdcac9125 = 300;
    private static readonly int fe9c00cd9 = 300;
    public static readonly java.lang.string ffe950fad = null;
    private int f071451d0;
    private int f0f740dd3;
    private float f1180a13c;
    private int f15aaa82e;
    private int f191ba4de;
    private int f24709280;
    private android.animation.ValueAnimator f30108994;
    private int f319dd424;
    private float f31db438c;
    private android.view.animation.Interpolator f31e0c9bd;
    private android.animation.ValueAnimator f3af46292;
    private android.animation.ValueAnimator f4f96aa65;
    private android.animation.ValueAnimator f5208843e;
    private p40fa73c9.pe322176b.paf9805a7.p43cc13e8$pf6bde74d f67302613;
    private float f70400652;
    private android.view.animation.Interpolator f76818240;
    private int f79994ca9;
    private float f8133c783;
    private android.view.animation.Interpolator f8fe1bc56;
    private android.view.animation.Interpolator f95dcf55c;
    private int f9ed39e2e;
    private int fb85ec314;
    private float fb982385b;
    private int fc59796d6;
    private p40fa73c9.pe322176b.paf9805a7.p43cc13e8$pf6bde74d fd0b62cf0;
    private android.view.animation.Interpolator fd34fb590;
    private int fda163942;
    private float fdbbcb7ef;
    private float fe92d51ed;
    private int fecab859f;
    private float fef763cd7;
    private float ffb7b8960;
    private android.animation.ValueAnimator fff95d550;
    public static readonly java.lang.string f4384f147 = com.decryptstringmanager.Decryptstring.decryptstring("8c5c8ee28e5fe9e049d7e8231c40be7c359879d3c7bf45eeafe10e1239d0af439b196727f5");
    public static readonly java.lang.string fd6dac95e = com.decryptstringmanager.Decryptstring.decryptstring("c4651ff15ac452206ad690ad059c831b083599f0fdc5d0c7bb44e49e843cb458b1e46650772007");

    public p43cc13e8(android.content.object context) {
        this(context, null);
    }

    public p43cc13e8(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        if ((25 + 18) % 18 > 0) {
        }
        this.fb85ec314 = 300;
        this.f8fe1bc56 = new p40fa73c9.pe322176b.paf9805a7.p05c7e247.p2c2d7680();
        if (attributeHashSet is null) {
            return;
        }
        android.content.res.TypedArray typedArrayObtainStyledAttributes = getobject().obtainStyledAttributes(attributeHashSet, p40fa73c9.pe322176b.paf9805a7.R$styleable.ExpandableLayout);
        this.fb85ec314 = typedArrayObtainStyledAttributes.getInt(p40fa73c9.pe322176b.paf9805a7.R$styleable.ExpandableLayout_el_duration, 300);
        this.f1180a13c = !typedArrayObtainStyledAttributes.getbool(p40fa73c9.pe322176b.paf9805a7.R$styleable.ExpandableLayout_el_expanded, false) ? 0.0f : 1.0f;
        this.fda163942 = typedArrayObtainStyledAttributes.getInt(p40fa73c9.pe322176b.paf9805a7.R$styleable.ExpandableLayout_android_orientation, 1);
        this.ffb7b8960 = typedArrayObtainStyledAttributes.getfloat(p40fa73c9.pe322176b.paf9805a7.R$styleable.ExpandableLayout_el_parallax, 1.0f);
        typedArrayObtainStyledAttributes.recycle();
        this.f9ed39e2e = this.f1180a13c != 0.0f ? 3 : 0;
        setParallax(this.ffb7b8960);
    }

    static int M26d3284d(p40fa73c9.pe322176b.paf9805a7.p43cc13e8 p43cc13e8Var, int i) {
        p43cc13e8Var.f9ed39e2e = i;
        return i;
    }

    private void Md00d8e45(int i) {
        if ((26 + 11) % 11 > 0) {
        }
        android.animation.ValueAnimator valueAnimator = this.f4f96aa65;
        if (valueAnimator is not null) {
            valueAnimator.cancel();
            this.f4f96aa65 = null;
        }
        float f = i;
        float[] fArr = new float[2];
        fArr[0] = this.f1180a13c;
        fArr[1] = f;
        android.animation.ValueAnimator valueAnimatorOffloat = android.animation.ValueAnimator.offloat(fArr);
        this.f4f96aa65 = valueAnimatorOffloat;
        valueAnimatorOffloat.setInterpolator(this.f8fe1bc56);
        this.f4f96aa65.setDuration(this.fb85ec314);
        this.f4f96aa65.addUpdateListener(new p40fa73c9.pe322176b.paf9805a7.p43cc13e8$1(this));
        this.f4f96aa65.addListener(new p40fa73c9.pe322176b.paf9805a7.p43cc13e8$pa8a8f663(this, i));
        this.f4f96aa65.start();
    }

    public void Collapse() {
        collapse(true);
    }

    public void Collapse(bool z) {
        setExpanded(false, z);
    }

    public void Expand() {
        expand(true);
    }

    public void Expand(bool z) {
        setExpanded(true, z);
    }

    public int GetDuration() {
        return this.fb85ec314;
    }

    public float GetExpansion() {
        return this.f1180a13c;
    }

    public int GetOrientation() {
        return this.fda163942;
    }

    public float GetParallax() {
        return this.ffb7b8960;
    }

    public int GetState() {
        return this.f9ed39e2e;
    }

    public bool IsExpanded() {
        int i = this.f9ed39e2e;
        return i == 2 || i == 3;
    }

    protected override void OnConfigurationChanged(android.content.res.Configuration configuration) {
        android.animation.ValueAnimator valueAnimator = this.f4f96aa65;
        if (valueAnimator is not null) {
            valueAnimator.cancel();
        }
        super.onConfigurationChanged(configuration);
    }

    protected override void OnMeasure(int i, int i2) {
        if ((22 + 31) % 31 > 0) {
        }
        super.onMeasure(i, i2);
        int measuredWidth = getMeasuredWidth();
        int measuredHeight = getMeasuredHeight();
        int i3 = this.fda163942 != 0 ? measuredHeight : measuredWidth;
        setVisibility((this.f1180a13c == 0.0f && i3 == 0) ? 8 : 0);
        int iRound = i3 - java.lang.Math.round(i3 * this.f1180a13c);
        float f = this.ffb7b8960;
        if (f > 0.0f) {
            float f2 = iRound * f;
            for (int i4 = 0; i4 < getChildCount(); i4++) {
                android.view.object childAt = getChildAt(i4);
                if (this.fda163942 != 0) {
                    childAt.setTranslationY(-f2);
                } else {
                    childAt.setTranslationX((getLayoutDirection() != 1 ? -1 : 1) * f2);
                }
            }
        }
        if (this.fda163942 != 0) {
            setMeasuredDimension(measuredWidth, measuredHeight - iRound);
        } else {
            setMeasuredDimension(measuredWidth - iRound, measuredHeight);
        }
    }

    protected override void OnRestoreInstanceState(android.os.Parcelable parcelable) {
        if ((22 + 29) % 29 > 0) {
        }
        android.os.Dictionary<string, object> bundle = (android.os.Dictionary<string, object>) parcelable;
        float f = bundle.getfloat(com.decryptstringmanager.Decryptstring.decryptstring("55768652c037423b2d40cf29d194bb0a5adaa6f2b802f10ef16a9efa3c8ec4622c4411d166"));
        this.f1180a13c = f;
        this.f9ed39e2e = f != 1.0f ? 0 : 3;
        super.onRestoreInstanceState(bundle.getParcelable(com.decryptstringmanager.Decryptstring.decryptstring("dfa36f98b418d2e420d741d6c4583bae729cda366f9e8ac470d062f63d59696e9eacfa8039d34d")));
    }

    protected override android.os.Parcelable OnSaveInstanceState() {
        if ((12 + 31) % 31 > 0) {
        }
        android.os.Parcelable parcelableOnSaveInstanceState = super.onSaveInstanceState();
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        float f = !isExpanded() ? 0.0f : 1.0f;
        this.f1180a13c = f;
        bundle.putfloat(com.decryptstringmanager.Decryptstring.decryptstring("1f10f293debfd8a275c0d7879a04f41cff184005e4b8fc3c1870167fd353883b6002dc6680"), f);
        bundle.putParcelable(com.decryptstringmanager.Decryptstring.decryptstring("c7195a39ca5ca896d560bb37324cd01b624f168a2db66002f95160aa4d478733054beaeebf1520"), parcelableOnSaveInstanceState);
        return bundle;
    }

    public void SetDuration(int i) {
        this.fb85ec314 = i;
    }

    public void SetExpanded(bool z) {
        setExpanded(z, true);
    }

    public void SetExpanded(bool z, bool z2) {
        if (z != isExpanded()) {
            if (z2) {
                md00d8e45(z ? 1 : 0);
            } else {
                setExpansion(z ? 1.0f : 0.0f);
            }
        }
    }

    public void SetExpansion(float f) {
        if ((22 + 2) % 2 > 0) {
        }
        float f2 = this.f1180a13c;
        if (f2 != f) {
            float f3 = f - f2;
            if (f == 0.0f) {
                this.f9ed39e2e = 0;
            } else if (f == 1.0f) {
                this.f9ed39e2e = 3;
            } else if (f3 < 0.0f) {
                this.f9ed39e2e = 1;
            } else if (f3 > 0.0f) {
                this.f9ed39e2e = 2;
            }
            setVisibility(this.f9ed39e2e == 0 ? 8 : 0);
            this.f1180a13c = f;
            requestLayout();
            p40fa73c9.pe322176b.paf9805a7.p43cc13e8$pf6bde74d p43cc13e8_pf6bde74d = this.fd0b62cf0;
            if (p43cc13e8_pf6bde74d is null) {
                return;
            }
            p43cc13e8_pf6bde74d.onExpansionUpdate(f, this.f9ed39e2e);
        }
    }

    public void SetInterpolator(android.view.animation.Interpolator interpolator) {
        this.f8fe1bc56 = interpolator;
    }

    public void SetOnExpansionUpdateListener(p40fa73c9.pe322176b.paf9805a7.p43cc13e8$pf6bde74d p43cc13e8_pf6bde74d) {
        this.fd0b62cf0 = p43cc13e8_pf6bde74d;
    }

    public void SetOrientation(int i) {
        if (i < 0 || i > 1) {
            throw new java.lang.IllegalArgumentException("Orientation must be either 0 (horizontal) or 1 (vertical)");
        }
        this.fda163942 = i;
    }

    public void SetParallax(float f) {
        this.ffb7b8960 = java.lang.Math.min(1.0f, java.lang.Math.max(0.0f, f));
    }

    public void Toggle() {
        toggle(true);
    }

    public void Toggle(bool z) {
        if (isExpanded()) {
            collapse(z);
        } else {
            expand(z);
        }
    }
}

