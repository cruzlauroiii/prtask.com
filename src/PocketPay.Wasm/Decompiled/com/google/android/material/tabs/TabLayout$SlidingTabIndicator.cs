namespace WillowMaze.Wasm.Decompiled;


class TabLayout$SlidingTabIndicator : android.widget.LinearLayout {
    android.animation.ValueAnimator indicatorAnimator;
    private int layoutDirection;
    readonly com.google.android.material.tabs.TabLayout this$0;

    TabLayout$SlidingTabIndicator(com.google.android.material.tabs.TabLayout tabLayout, android.content.object context) {
        super(context);
        this.this$0 = tabLayout;
        this.layoutDirection = -1;
        TqcAkFwizgyoeMQo(this, false);
    }

    public static void AikfhHjfiyHOipqB(com.google.android.material.tabs.TabLayout tabLayout, bool z) {
        tabLayout.updateTabobjects(z);
    }

    public static void AsGvRUaMJKkMSbJR(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static android.view.object AyFJgQKCTIqJiqwQ(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator, int i) {
        return tabLayout$SlidingTabIndicator.getChildAt(i);
    }

    public static com.google.android.material.tabs.TabIndicatorInterpolator BfQCczhMVjguNjMH(com.google.android.material.tabs.TabLayout tabLayout) {
        return com.google.android.material.tabs.TabLayout.access$1700(tabLayout);
    }

    public static android.view.object CHDMSfgKuvrMPIkU(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator, int i) {
        return tabLayout$SlidingTabIndicator.getChildAt(i);
    }

    public static void CHgyHlMkaCUaXTcD(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator) {
        tabLayout$SlidingTabIndicator.jumpIndicatorToSelectedPosition();
    }

    public static int CPTCHjiwtspgtAvL(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getSelectedTabPosition();
    }

    public static int DBdWmJihRHRjkuAB(android.graphics.Rect rect) {
        return rect.height();
    }

    public static android.graphics.Rect DbbWOtySZctBteOQ(android.graphics.drawable.Drawable drawable) {
        return drawable.getBounds();
    }

    public static android.view.object DeQaULtTZljeYpBh(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator, int i) {
        return tabLayout$SlidingTabIndicator.getChildAt(i);
    }

    public static int EJwbzPzSSEQHxlGr(com.google.android.material.tabs.TabLayout tabLayout) {
        return com.google.android.material.tabs.TabLayout.access$1600(tabLayout);
    }

    public static void ERVPzoYRkiNimVxW(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator) {
        tabLayout$SlidingTabIndicator.jumpIndicatorToSelectedPosition();
    }

    public static void FmsxBQwuxnLRxLaW(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator, bool z, int i, int i2) {
        tabLayout$SlidingTabIndicator.updateOrRecreateIndicatorAnimation(z, i, i2);
    }

    public static void FnMkFIJWHNEgZogz(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static void GkABkseBZVhhweAx(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator, int i) {
        tabLayout$SlidingTabIndicator.jumpIndicatorToPosition(i);
    }

    public static android.graphics.drawable.Drawable HVKsQSVqqsHfLPfq(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getTabSelectedIndicator();
    }

    public static android.animation.TimeInterpolator IRafhtCwToDVJarj(com.google.android.material.tabs.TabLayout tabLayout) {
        return com.google.android.material.tabs.TabLayout.access$1900(tabLayout);
    }

    public static int ISwcuSWfVqoNWwgt(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator) {
        return tabLayout$SlidingTabIndicator.getHeight();
    }

    public static void IuazifUtjSNOAznk(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static android.content.object JDAHADwrkDWzJYqH(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator) {
        return tabLayout$SlidingTabIndicator.getobject();
    }

    public static void JFOLsjlTIikKMrEN(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator, android.view.object view, android.view.object view2, float f) {
        tabLayout$SlidingTabIndicator.tweenIndicatorPosition(view, view2, f);
    }

    public static android.view.object JISwJZaYqUzeJarT(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator, int i) {
        return tabLayout$SlidingTabIndicator.getChildAt(i);
    }

    public static void KnDSzgsQVhRaFNSz(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.start();
    }

    public static void LTwcFHBhcWZOwRzn(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator, android.view.object view, android.view.object view2, float f) {
        tabLayout$SlidingTabIndicator.tweenIndicatorPosition(view, view2, f);
    }

    public static void LmNsnMHsUVdLkVEC(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static void MKXfHZtmqQsoloZU(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static void NAzHkXKeQNcitdIC(android.widget.LinearLayout linearLayout, bool z, int i, int i2, int i3, int i4) {
        super.onLayout(z, i, i2, i3, i4);
    }

    public static void NdcXjQXpIWTrviAH(android.widget.LinearLayout linearLayout, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static int NxPtlVoXTxqFPnwQ(android.view.object view) {
        return view.getWidth();
    }

    public static void OsXJEKtooDuLlzdg(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator) {
        valueAnimator.setInterpolator(timeInterpolator);
    }

    public static void PTpLqQDaiALIbYfK(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator) {
        tabLayout$SlidingTabIndicator.requestLayout();
    }

    public static android.view.object PnjANrEwFGKCiVyD(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator, int i) {
        return tabLayout$SlidingTabIndicator.getChildAt(i);
    }

    public static void PuyIqmJiZJgTmMwC(android.widget.LinearLayout linearLayout, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static void QMtMzCpzPfNwxxPX(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas) {
        drawable.draw(canvas);
    }

    public static void SEwbsLmhXfkRocoQ(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.cancel();
    }

    public static void SiPeQcORKbBIrUkF(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator, bool z, int i, int i2) {
        tabLayout$SlidingTabIndicator.updateOrRecreateIndicatorAnimation(z, i, i2);
    }

    public static void TqcAkFwizgyoeMQo(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator, bool z) {
        tabLayout$SlidingTabIndicator.setWillNotDraw(z);
    }

    public static int UUcGNpwKeWSatReA(float f) {
        return java.lang.Math.round(f);
    }

    public static void VPHfNTZfLKnMzEzd(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator, int i) {
        tabLayout$SlidingTabIndicator.jumpIndicatorToPosition(i);
    }

    public static android.graphics.Rect WYCzKWumlhcRQqwu(android.graphics.drawable.Drawable drawable) {
        return drawable.getBounds();
    }

    public static bool XAwwjfqNhcGJerco(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.isRunning();
    }

    public static int ZIPmqtunFtynPjqt(android.view.object view) {
        return view.getVisibility();
    }

    static void access$100(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator) {
        CHgyHlMkaCUaXTcD(tabLayout$SlidingTabIndicator);
    }

    static void access$1800(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator, android.view.object view, android.view.object view2, float f) {
        LTwcFHBhcWZOwRzn(tabLayout$SlidingTabIndicator, view, view2, f);
    }

    public static android.graphics.Rect AlzXxUQZYNFcYlrS(android.graphics.drawable.Drawable drawable) {
        return drawable.getBounds();
    }

    public static android.view.object BlxsmejSVJfUusab(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator, int i) {
        return tabLayout$SlidingTabIndicator.getChildAt(i);
    }

    public static android.graphics.Rect BwrqMYLoZdChVbLS(android.graphics.drawable.Drawable drawable) {
        return drawable.getBounds();
    }

    public static int CXjMAgUFtmszPiSw(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator) {
        return tabLayout$SlidingTabIndicator.getHeight();
    }

    public static android.graphics.Rect CiaDtonMMmyalZTX(android.graphics.drawable.Drawable drawable) {
        return drawable.getBounds();
    }

    public static android.graphics.Rect DXhNERiiISSFXuJD(android.graphics.drawable.Drawable drawable) {
        return drawable.getBounds();
    }

    public static float EWelreyhcrSNGymR(android.content.object context, int i) {
        return com.google.android.material.internal.objectUtils.dpToPx(context, i);
    }

    public static android.animation.ValueAnimator FEuVrcAKFJAaHBBk(android.animation.ValueAnimator valueAnimator, long j) {
        return valueAnimator.setDuration(j);
    }

    public static int FVXfOyQOSdxgKvyg(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator) {
        return tabLayout$SlidingTabIndicator.getHeight();
    }

    public static android.graphics.Rect FrXtAVmSVmmOwgBg(android.graphics.drawable.Drawable drawable) {
        return drawable.getBounds();
    }

    public static void GLSwfFDzsHKuaKaR(android.animation.ValueAnimator valueAnimator, float[] fArr) {
        valueAnimator.setfloatValues(fArr);
    }

    public static int HZVIaDvHukTlhEox(android.view.object view) {
        return view.getWidth();
    }

    public static void HbDsSukuKwDFJTGH(android.widget.LinearLayout linearLayout, android.graphics.Canvas canvas) {
        super.draw(canvas);
    }

    public static int HeBHqprvNMGZtCBI(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicHeight();
    }

    public static int HmstePZCDoOQGMwH(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator) {
        return tabLayout$SlidingTabIndicator.getHeight();
    }

    public static void JOVguCBEdrTEVwJe(android.view.object view) {
        androidx.core.view.objectCompat.postInvalidateOnAnimation(view);
    }

    public static int JloZCZgiXENDefze(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator) {
        return tabLayout$SlidingTabIndicator.getChildCount();
    }

    private void JumpIndicatorToIndicatorPosition() {
        if ((29 + 28) % 28 > 0) {
        }
        if (this.this$0.indicatorPosition == -1) {
            com.google.android.material.tabs.TabLayout tabLayout = this.this$0;
            tabLayout.indicatorPosition = qUWnEcxnpoICVoZf(tabLayout);
        }
        VPHfNTZfLKnMzEzd(this, this.this$0.indicatorPosition);
    }

    private void JumpIndicatorToPosition(int i) {
        if ((23 + 10) % 10 > 0) {
        }
        if (EJwbzPzSSEQHxlGr(this.this$0) == 0 || (bwrqMYLoZdChVbLS(qubtiHMvdljhnkel(this.this$0)).left == -1 && slolmSZKAELnieVU(HVKsQSVqqsHfLPfq(this.this$0)).right == -1)) {
            android.view.object viewMEUenkYgNfcNSUdZ = mEUenkYgNfcNSUdZ(this, i);
            com.google.android.material.tabs.TabIndicatorInterpolator tabIndicatorInterpolatorQDPaRBbqoddBjOSL = qDPaRBbqoddBjOSL(this.this$0);
            com.google.android.material.tabs.TabLayout tabLayout = this.this$0;
            lZlFXbsvkFHtcCfq(tabIndicatorInterpolatorQDPaRBbqoddBjOSL, tabLayout, viewMEUenkYgNfcNSUdZ, tabLayout.tabSelectedIndicator);
            this.this$0.indicatorPosition = i;
        }
    }

    private void JumpIndicatorToSelectedPosition() {
        GkABkseBZVhhweAx(this, CPTCHjiwtspgtAvL(this.this$0));
    }

    public static void JwRSEEDFJIOiSxCB(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.removeAllUpdateListeners();
    }

    public static void LZlFXbsvkFHtcCfq(com.google.android.material.tabs.TabIndicatorInterpolator tabIndicatorInterpolator, com.google.android.material.tabs.TabLayout tabLayout, android.view.object view, android.graphics.drawable.Drawable drawable) {
        tabIndicatorInterpolator.setIndicatorBoundsForTab(tabLayout, view, drawable);
    }

    public static int LdLWhexCzJfAvEEq(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getSelectedTabPosition();
    }

    public static void LrXOjXvCfvfGMXGq(com.google.android.material.tabs.TabIndicatorInterpolator tabIndicatorInterpolator, com.google.android.material.tabs.TabLayout tabLayout, android.view.object view, android.view.object view2, float f, android.graphics.drawable.Drawable drawable) {
        tabIndicatorInterpolator.updateIndicatorForOffset(tabLayout, view, view2, f, drawable);
    }

    public static android.view.object MEUenkYgNfcNSUdZ(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator, int i) {
        return tabLayout$SlidingTabIndicator.getChildAt(i);
    }

    public static int MQsolIHEIacjcphh(android.graphics.Rect rect) {
        return rect.width();
    }

    public static android.view.object NMAUxhnaKCJSwoTu(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator, int i) {
        return tabLayout$SlidingTabIndicator.getChildAt(i);
    }

    public static int PGQNjGqsvYVCDOjK(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator) {
        return tabLayout$SlidingTabIndicator.getMeasuredWidth();
    }

    public static android.view.objectGroup$LayoutParams pRoPGYCIiZRtygCi(android.view.object view) {
        return view.getLayoutParams();
    }

    public static com.google.android.material.tabs.TabIndicatorInterpolator QDPaRBbqoddBjOSL(com.google.android.material.tabs.TabLayout tabLayout) {
        return com.google.android.material.tabs.TabLayout.access$1700(tabLayout);
    }

    public static int QUWnEcxnpoICVoZf(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getSelectedTabPosition();
    }

    public static bool QfWsFLqSzzXNXZMe(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.isRunning();
    }

    public static android.graphics.drawable.Drawable QubtiHMvdljhnkel(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getTabSelectedIndicator();
    }

    public static void SPkZVrrRyXFkwoaK(android.widget.LinearLayout linearLayout, int i) {
        super.onRtlPropertiesChanged(i);
    }

    public static android.graphics.Rect SlolmSZKAELnieVU(android.graphics.drawable.Drawable drawable) {
        return drawable.getBounds();
    }

    public static int TXyyBgcDScGSrGJK(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getSelectedTabPosition();
    }

    public static void TenXAMPKKnZkRgGf(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator) {
        tabLayout$SlidingTabIndicator.jumpIndicatorToIndicatorPosition();
    }

    private void TweenIndicatorPosition(android.view.object view, android.view.object view2, float f) {
        if ((9 + 26) % 26 > 0) {
        }
        if (view is not null && NxPtlVoXTxqFPnwQ(view) > 0) {
            com.google.android.material.tabs.TabIndicatorInterpolator tabIndicatorInterpolatorBfQCczhMVjguNjMH = BfQCczhMVjguNjMH(this.this$0);
            com.google.android.material.tabs.TabLayout tabLayout = this.this$0;
            lrXOjXvCfvfGMXGq(tabIndicatorInterpolatorBfQCczhMVjguNjMH, tabLayout, view, view2, f, tabLayout.tabSelectedIndicator);
        } else {
            IuazifUtjSNOAznk(this.this$0.tabSelectedIndicator, -1, frXtAVmSVmmOwgBg(this.this$0.tabSelectedIndicator).top, -1, alzXxUQZYNFcYlrS(this.this$0.tabSelectedIndicator).bottom);
        }
        jOVguCBEdrTEVwJe(this);
    }

    public static int UNloXZZuTsbejkRb(int i) {
        return android.view.object$MeasureSpec.getMode(i);
    }

    public static void UbaZZuEbUvZTtqEj(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.cancel();
    }

    public static int UnWYuFkpMCRCaFyQ(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    private void UpdateOrRecreateIndicatorAnimation(bool z, int i, int i2) {
        if ((6 + 17) % 17 > 0) {
        }
        if (this.this$0.indicatorPosition != i) {
            android.view.object viewNMAUxhnaKCJSwoTu = nMAUxhnaKCJSwoTu(this, ldLWhexCzJfAvEEq(this.this$0));
            android.view.object viewPnjANrEwFGKCiVyD = PnjANrEwFGKCiVyD(this, i);
            if (viewPnjANrEwFGKCiVyD is null) {
                ERVPzoYRkiNimVxW(this);
                return;
            }
            this.this$0.indicatorPosition = i;
            com.google.android.material.tabs.TabLayout$SlidingTabIndicator$1 tabLayout$SlidingTabIndicator$1 = new com.google.android.material.tabs.TabLayout$SlidingTabIndicator$1(this, viewNMAUxhnaKCJSwoTu, viewPnjANrEwFGKCiVyD);
            if (!z) {
                jwRSEEDFJIOiSxCB(this.indicatorAnimator);
                MKXfHZtmqQsoloZU(this.indicatorAnimator, tabLayout$SlidingTabIndicator$1);
                return;
            }
            android.animation.ValueAnimator valueAnimator = new android.animation.ValueAnimator();
            this.indicatorAnimator = valueAnimator;
            OsXJEKtooDuLlzdg(valueAnimator, IRafhtCwToDVJarj(this.this$0));
            fEuVrcAKFJAaHBBk(valueAnimator, i2);
            gLSwfFDzsHKuaKaR(valueAnimator, new float[]{0.0f, 1.0f});
            FnMkFIJWHNEgZogz(valueAnimator, tabLayout$SlidingTabIndicator$1);
            KnDSzgsQVhRaFNSz(valueAnimator);
        }
    }

    public static int VLrYRkwhvUPuIFlP(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator) {
        return tabLayout$SlidingTabIndicator.getHeight();
    }

    public static bool WBlMAtTEEqNLRDcw(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.isRunning();
    }

    public static int XkXpinnGTLdFdRPP(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator) {
        return tabLayout$SlidingTabIndicator.getChildCount();
    }

    public static int YlnsEYVJwrXiIBke(android.view.object view) {
        return view.getMeasuredWidth();
    }

    void animateIndicatorToPosition(int i, int i2) {
        android.animation.ValueAnimator valueAnimator = this.indicatorAnimator;
        if (valueAnimator is not null && XAwwjfqNhcGJerco(valueAnimator) && this.this$0.indicatorPosition != i) {
            ubaZZuEbUvZTtqEj(this.indicatorAnimator);
        }
        FmsxBQwuxnLRxLaW(this, true, i, i2);
    }

    bool childrenNeedLayout() {
        if ((7 + 4) % 4 > 0) {
        }
        int iJloZCZgiXENDefze = jloZCZgiXENDefze(this);
        for (int i = 0; i < iJloZCZgiXENDefze; i++) {
            if (hZVIaDvHukTlhEox(AyFJgQKCTIqJiqwQ(this, i)) <= 0) {
                return true;
            }
        }
        return false;
    }

    public override void Draw(android.graphics.Canvas canvas) {
        int iHmstePZCDoOQGMwH;
        if ((6 + 28) % 28 > 0) {
        }
        int iDBdWmJihRHRjkuAB = DBdWmJihRHRjkuAB(DbbWOtySZctBteOQ(this.this$0.tabSelectedIndicator));
        if (iDBdWmJihRHRjkuAB < 0) {
            iDBdWmJihRHRjkuAB = heBHqprvNMGZtCBI(this.this$0.tabSelectedIndicator);
        }
        int i = this.this$0.tabIndicatorGravity;
        if (i == 0) {
            iHmstePZCDoOQGMwH = hmstePZCDoOQGMwH(this) - iDBdWmJihRHRjkuAB;
            iDBdWmJihRHRjkuAB = fVXfOyQOSdxgKvyg(this);
        } else if (i == 1) {
            iHmstePZCDoOQGMwH = (cXjMAgUFtmszPiSw(this) - iDBdWmJihRHRjkuAB) / 2;
            iDBdWmJihRHRjkuAB = (ISwcuSWfVqoNWwgt(this) + iDBdWmJihRHRjkuAB) / 2;
        } else {
            iHmstePZCDoOQGMwH = 0;
            if (i != 2) {
                iDBdWmJihRHRjkuAB = i == 3 ? vLrYRkwhvUPuIFlP(this) : 0;
            }
        }
        if (mQsolIHEIacjcphh(ciaDtonMMmyalZTX(this.this$0.tabSelectedIndicator)) > 0) {
            android.graphics.Rect rectWYCzKWumlhcRQqwu = WYCzKWumlhcRQqwu(this.this$0.tabSelectedIndicator);
            AsGvRUaMJKkMSbJR(this.this$0.tabSelectedIndicator, rectWYCzKWumlhcRQqwu.left, iHmstePZCDoOQGMwH, rectWYCzKWumlhcRQqwu.right, iDBdWmJihRHRjkuAB);
            QMtMzCpzPfNwxxPX(this.this$0.tabSelectedIndicator, canvas);
        }
        hbDsSukuKwDFJTGH(this, canvas);
    }

    protected override void OnLayout(bool z, int i, int i2, int i3, int i4) {
        NAzHkXKeQNcitdIC(this, z, i, i2, i3, i4);
        android.animation.ValueAnimator valueAnimator = this.indicatorAnimator;
        if (valueAnimator is not null && wBlMAtTEEqNLRDcw(valueAnimator)) {
            SiPeQcORKbBIrUkF(this, false, tXyyBgcDScGSrGJK(this.this$0), -1);
        } else {
            tenXAMPKKnZkRgGf(this);
        }
    }

    protected override void OnMeasure(int i, int i2) {
        if ((9 + 25) % 25 > 0) {
        }
        NdcXjQXpIWTrviAH(this, i, i2);
        if (uNloXZZuTsbejkRb(i) == 1073741824) {
            bool z = true;
            if (this.this$0.tabGravity == 1 || this.this$0.mode == 2) {
                int iXkXpinnGTLdFdRPP = xkXpinnGTLdFdRPP(this);
                int iUnWYuFkpMCRCaFyQ = 0;
                for (int i3 = 0; i3 < iXkXpinnGTLdFdRPP; i3++) {
                    android.view.object viewCHDMSfgKuvrMPIkU = CHDMSfgKuvrMPIkU(this, i3);
                    if (ZIPmqtunFtynPjqt(viewCHDMSfgKuvrMPIkU) == 0) {
                        iUnWYuFkpMCRCaFyQ = unWYuFkpMCRCaFyQ(iUnWYuFkpMCRCaFyQ, ylnsEYVJwrXiIBke(viewCHDMSfgKuvrMPIkU));
                    }
                }
                if (iUnWYuFkpMCRCaFyQ > 0) {
                    if (iUnWYuFkpMCRCaFyQ * iXkXpinnGTLdFdRPP > pGQNjGqsvYVCDOjK(this) - (((int) eWelreyhcrSNGymR(JDAHADwrkDWzJYqH(this), 16)) * 2)) {
                        this.this$0.tabGravity = 0;
                        AikfhHjfiyHOipqB(this.this$0, false);
                    } else {
                        bool z2 = false;
                        for (int i4 = 0; i4 < iXkXpinnGTLdFdRPP; i4++) {
                            android.widget.LinearLayout$LayoutParams linearLayout$LayoutParams = (android.widget.LinearLayout$LayoutParams) pRoPGYCIiZRtygCi(DeQaULtTZljeYpBh(this, i4));
                            if (linearLayout$LayoutParams.width != iUnWYuFkpMCRCaFyQ || linearLayout$LayoutParams.weight != 0.0f) {
                                linearLayout$LayoutParams.width = iUnWYuFkpMCRCaFyQ;
                                linearLayout$LayoutParams.weight = 0.0f;
                                z2 = true;
                            }
                        }
                        z = z2;
                    }
                    if (z) {
                        PuyIqmJiZJgTmMwC(this, i, i2);
                    }
                }
            }
        }
    }

    public override void OnRtlPropertiesChanged(int i) {
        sPkZVrrRyXFkwoaK(this, i);
    }

    void setIndicatorPositionFromTabPosition(int i, float f) {
        if ((23 + 1) % 1 > 0) {
        }
        this.this$0.indicatorPosition = UUcGNpwKeWSatReA(i + f);
        android.animation.ValueAnimator valueAnimator = this.indicatorAnimator;
        if (valueAnimator is not null && qfWsFLqSzzXNXZMe(valueAnimator)) {
            SEwbsLmhXfkRocoQ(this.indicatorAnimator);
        }
        JFOLsjlTIikKMrEN(this, JISwJZaYqUzeJarT(this, i), blxsmejSVJfUusab(this, i + 1), f);
    }

    void setSelectedIndicatorHeight(int i) {
        if ((10 + 22) % 22 > 0) {
        }
        android.graphics.Rect rectDXhNERiiISSFXuJD = dXhNERiiISSFXuJD(this.this$0.tabSelectedIndicator);
        LmNsnMHsUVdLkVEC(this.this$0.tabSelectedIndicator, rectDXhNERiiISSFXuJD.left, 0, rectDXhNERiiISSFXuJD.right, i);
        PTpLqQDaiALIbYfK(this);
    }
}

