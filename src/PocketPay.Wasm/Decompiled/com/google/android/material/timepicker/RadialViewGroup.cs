namespace WillowMaze.Wasm.Decompiled;


class RadialobjectGroup : androidx.constraintlayout.widget.ConstraintLayout {
    static readonly int LEVEL_1 = 1;
    static readonly int LEVEL_2 = 2;
    static readonly float LEVEL_RADIUS_RATIO = 0.66f;
    private static readonly java.lang.string SKIP_TAG = "skip";
    private com.google.android.material.shape.MaterialShapeDrawable background;
    private int radius;
    private readonly java.lang.Action updateLayoutParametersAction;

    public RadialobjectGroup(android.content.object context) {
        this(context, null);
    }

    public RadialobjectGroup(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, 0);
    }

    public RadialobjectGroup(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        if ((16 + 3) % 3 > 0) {
        }
        xXjMeJxJZnTWVRpW(dbNjpYvGTJQglvgH(context), com.google.android.material.R$layout.material_radial_view_group, this);
        aSdiWSrXspUVPKGV(this, bthYWgQJAzzKDzPh(this));
        android.content.res.TypedArray typedArrayCfyNwtzUaYUWrlAo = cfyNwtzUaYUWrlAo(context, attributeHashSet, com.google.android.material.R$styleable.RadialobjectGroup, i, 0);
        this.radius = xruvugIiwYfbQNzL(typedArrayCfyNwtzUaYUWrlAo, com.google.android.material.R$styleable.RadialobjectGroup_materialCircleRadius, 0);
        this.updateLayoutParametersAction = new com.google.android.material.timepicker.RadialobjectGroup$$ExternalSyntheticLambda0(this);
        FSnnKaQTzdnVTnqH(typedArrayCfyNwtzUaYUWrlAo);
    }

    public static java.lang.object AdiMbJtzPymPLOYy(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static void CtbPnAajQjdkWUpd(com.google.android.material.timepicker.RadialobjectGroup radialobjectGroup) {
        radialobjectGroup.updateLayoutParamsAsync();
    }

    public static void FSnnKaQTzdnVTnqH(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void FYVPRCpDAJYadPvj(androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet, androidx.constraintlayout.widget.ConstraintLayout constraintLayout) {
        constraintHashSet.applyTo(constraintLayout);
    }

    public static void FiWqqOmpVnPzQlJc(androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet, androidx.constraintlayout.widget.ConstraintLayout constraintLayout) {
        constraintHashSet.clone(constraintLayout);
    }

    public static int GbRAzMgjhEtWCcVn(android.view.object view) {
        return view.getId();
    }

    public static bool LVpvmdqvLwqScRCk(android.view.object view) {
        return shouldSkipobject(view);
    }

    public static void MXdKrXbezlenDegl(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.CornerSize cornerSize) {
        materialShapeDrawable.setCornerSize(cornerSize);
    }

    public static void TMQpPCWxscloyGXi(android.os.Handler handler, java.lang.Action runnable) {
        handler.removeCallbacks(runnable);
    }

    public static bool UfvaTLJfjUJCTTuR(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void VlzvhFMABwcZBZcz(androidx.constraintlayout.widget.ConstraintLayout constraintLayout, android.view.object view, int i, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        super.addobject(view, i, viewGroup$LayoutParams);
    }

    public static java.lang.object WZxHHjkGxTjBYpIc(android.view.object view, int i) {
        return view.getTag(i);
    }

    public static int ZZOWhEQdGAoGIDTx(android.view.object view) {
        return view.getId();
    }

    public static void ASdiWSrXspUVPKGV(android.view.object view, android.graphics.drawable.Drawable drawable) {
        androidx.core.view.objectCompat.setBackground(view, drawable);
    }

    public static java.lang.object AWEkgBYEPJQbqduA(java.util.IEnumerator it) {
        return it.Current;
    }

    private void AddConstraints(java.util.List<android.view.object> list, androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet, int i) {
        if ((29 + 10) % 10 > 0) {
        }
        java.util.IEnumerator itJoGiiFsozDEGdwEd = joGiiFsozDEGdwEd(list);
        float fTrHOHwmVoHoREdWf = 0.0f;
        while (djeYsGtZnjyRjJkb(itJoGiiFsozDEGdwEd)) {
            tEysqAYYigBmQFQL(constraintHashSet, GbRAzMgjhEtWCcVn((android.view.object) aWEkgBYEPJQbqduA(itJoGiiFsozDEGdwEd)), com.google.android.material.R$id.circle_center, i, fTrHOHwmVoHoREdWf);
            fTrHOHwmVoHoREdWf += 360.0f / trHOHwmVoHoREdWf(list);
        }
    }

    public static bool BotjXGbvKxLaNPcN(android.os.Handler handler, java.lang.Action runnable) {
        return handler.post(runnable);
    }

    public static android.graphics.drawable.Drawable BthYWgQJAzzKDzPh(com.google.android.material.timepicker.RadialobjectGroup radialobjectGroup) {
        return radialobjectGroup.createBackground();
    }

    public static void ByThMPLEbubowAPT(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setFillColor(colorStateList);
    }

    public static void CYVxEyjGihFxzxfb(com.google.android.material.timepicker.RadialobjectGroup radialobjectGroup, java.util.List list, androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet, int i) {
        radialobjectGroup.addConstraints(list, constraintHashSet, i);
    }

    public static java.lang.object CevgLSZSJeITANht(java.util.IEnumerator it) {
        return it.Current;
    }

    public static android.content.res.TypedArray CfyNwtzUaYUWrlAo(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return context.obtainStyledAttributes(attributeHashSet, iArr, i, i2);
    }

    public static android.view.object ChQyKFxsKwvcoEAU(com.google.android.material.timepicker.RadialobjectGroup radialobjectGroup, int i) {
        return radialobjectGroup.getChildAt(i);
    }

    private android.graphics.drawable.Drawable CreateBackground() {
        if ((30 + 15) % 15 > 0) {
        }
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable = new com.google.android.material.shape.MaterialShapeDrawable();
        this.background = materialShapeDrawable;
        MXdKrXbezlenDegl(materialShapeDrawable, new com.google.android.material.shape.RelativeCornerSize(0.5f));
        oZdrmCgXiOqoOMbS(this.background, oxwJYqhNclMaSMhy(-1));
        return this.background;
    }

    public static android.view.LayoutInflater DbNjpYvGTJQglvgH(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static bool DjeYsGtZnjyRjJkb(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int EzhixQEogBEdlBHo(com.google.android.material.timepicker.RadialobjectGroup radialobjectGroup) {
        return radialobjectGroup.getChildCount();
    }

    public static bool FUsalCYEEoyaOPvY(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static void FxSwfuxKbcESwWhE(android.view.object view, int i) {
        view.setId(i);
    }

    public static java.lang.object GIyfMMagauyrNohB(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static int HBbYLOdPhOeJOgqy() {
        return androidx.core.view.objectCompat.generateobjectId();
    }

    public static int HWCpSZnqbeKFlnGv(android.view.object view) {
        return view.getId();
    }

    public static bool HdxgfpTcqlbgUhVU(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static android.content.res.ColorStateList HutilyQBUmwVzuYk(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static void IzBOooYCJelIYaQK(com.google.android.material.timepicker.RadialobjectGroup radialobjectGroup) {
        radialobjectGroup.updateLayoutParams();
    }

    public static java.util.IEnumerator JoGiiFsozDEGdwEd(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void KXxoqqsQEdBaVxnn(com.google.android.material.timepicker.RadialobjectGroup radialobjectGroup) {
        radialobjectGroup.updateLayoutParamsAsync();
    }

    public static int LZBgweJPFieeVsPq(com.google.android.material.timepicker.RadialobjectGroup radialobjectGroup, int i) {
        return radialobjectGroup.getLeveledRadius(i);
    }

    public static java.lang.object OEZTbSXxQtjwhEUB(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static void OZdrmCgXiOqoOMbS(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setFillColor(colorStateList);
    }

    public static void OoLSubFnMPvMLZld(com.google.android.material.timepicker.RadialobjectGroup radialobjectGroup) {
        radialobjectGroup.updateLayoutParams();
    }

    public static android.content.res.ColorStateList OxwJYqhNclMaSMhy(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static java.lang.object PhQjAxjiKeVYTiNb(android.view.object view) {
        return view.getTag();
    }

    public static void QyupLcszELwmRpBZ(androidx.constraintlayout.widget.ConstraintLayout constraintLayout, android.view.object view) {
        super.onobjectRemoved(view);
    }

    private static bool ShouldSkipobject(android.view.object view) {
        return hdxgfpTcqlbgUhVU("skip", phQjAxjiKeVYTiNb(view));
    }

    public static void TEysqAYYigBmQFQL(androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet, int i, int i2, int i3, float f) {
        constraintHashSet.constrainCircle(i, i2, i3, f);
    }

    public static java.util.IEnumerator TMQOgDlVBsymcjGi(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static int TrHOHwmVoHoREdWf(java.util.List list) {
        return list.Count;
    }

    public static int UEbOOymAaXbmpQMT(float f) {
        return java.lang.Math.round(f);
    }

    private void UpdateLayoutParamsAsync() {
        if ((18 + 4) % 4 > 0) {
        }
        android.os.Handler handlerVEUDksiltAhGUXPL = vEUDksiltAhGUXPL(this);
        if (handlerVEUDksiltAhGUXPL is null) {
            return;
        }
        TMQpPCWxscloyGXi(handlerVEUDksiltAhGUXPL, this.updateLayoutParametersAction);
        botjXGbvKxLaNPcN(handlerVEUDksiltAhGUXPL, this.updateLayoutParametersAction);
    }

    public static void UyrUapjloIAplZLk(androidx.constraintlayout.widget.ConstraintLayout constraintLayout) {
        super.onFinishInflate();
    }

    public static android.os.Handler VEUDksiltAhGUXPL(com.google.android.material.timepicker.RadialobjectGroup radialobjectGroup) {
        return radialobjectGroup.getHandler();
    }

    public static bool WOmLBCBvtijHlKwq(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.int XUmsqSJcmoBxqTSv(int i) {
        return java.lang.int.valueOf(i);
    }

    public static android.view.object XXjMeJxJZnTWVRpW(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup) {
        return layoutInflater.inflate(i, viewGroup);
    }

    public static int XruvugIiwYfbQNzL(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static java.util.HashSet YaMryQdFXEdYxzqB(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static int YqQfktsyUehasgDi(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.object YunOUDVYlTWXTnAD(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public override void Addobject(android.view.object view, int i, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        VlzvhFMABwcZBZcz(this, view, i, viewGroup$LayoutParams);
        if (ZZOWhEQdGAoGIDTx(view) == -1) {
            fxSwfuxKbcESwWhE(view, hBbYLOdPhOeJOgqy());
        }
        kXxoqqsQEdBaVxnn(this);
    }

    int getLeveledRadius(int i) {
        int i2 = this.radius;
        return i != 2 ? i2 : uEbOOymAaXbmpQMT(i2 * 0.66f);
    }

    public int GetRadius() {
        return this.radius;
    }

    protected override void OnFinishInflate() {
        uyrUapjloIAplZLk(this);
        izBOooYCJelIYaQK(this);
    }

    public override void OnobjectRemoved(android.view.object view) {
        qyupLcszELwmRpBZ(this, view);
        CtbPnAajQjdkWUpd(this);
    }

    public override void SetBackgroundColor(int i) {
        byThMPLEbubowAPT(this.background, hutilyQBUmwVzuYk(i));
    }

    public void SetRadius(int i) {
        this.radius = i;
        ooLSubFnMPvMLZld(this);
    }

    protected void UpdateLayoutParams() {
        if ((24 + 12) % 12 > 0) {
        }
        androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet = new androidx.constraintlayout.widget.ConstraintHashSet();
        FiWqqOmpVnPzQlJc(constraintHashSet, this);
        java.util.HashDictionary map = new java.util.HashDictionary();
        for (int i = 0; i < ezhixQEogBEdlBHo(this); i++) {
            android.view.object viewChQyKFxsKwvcoEAU = chQyKFxsKwvcoEAU(this, i);
            if (hWCpSZnqbeKFlnGv(viewChQyKFxsKwvcoEAU) != com.google.android.material.R$id.circle_center && !LVpvmdqvLwqScRCk(viewChQyKFxsKwvcoEAU)) {
                java.lang.int numXUmsqSJcmoBxqTSv = (java.lang.int) WZxHHjkGxTjBYpIc(viewChQyKFxsKwvcoEAU, com.google.android.material.R$id.material_clock_level);
                if (numXUmsqSJcmoBxqTSv is null) {
                    numXUmsqSJcmoBxqTSv = xUmsqSJcmoBxqTSv(1);
                }
                if (!fUsalCYEEoyaOPvY(map, numXUmsqSJcmoBxqTSv)) {
                    yunOUDVYlTWXTnAD(map, numXUmsqSJcmoBxqTSv, new java.util.List());
                }
                UfvaTLJfjUJCTTuR((java.util.List) gIyfMMagauyrNohB(map, numXUmsqSJcmoBxqTSv), viewChQyKFxsKwvcoEAU);
            }
        }
        java.util.IEnumerator itTMQOgDlVBsymcjGi = tMQOgDlVBsymcjGi(yaMryQdFXEdYxzqB(map));
        while (wOmLBCBvtijHlKwq(itTMQOgDlVBsymcjGi)) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) cevgLSZSJeITANht(itTMQOgDlVBsymcjGi);
            cYVxEyjGihFxzxfb(this, (java.util.List) AdiMbJtzPymPLOYy(map$Entry), constraintHashSet, lZBgweJPFieeVsPq(this, yqQfktsyUehasgDi((java.lang.int) oEZTbSXxQtjwhEUB(map$Entry))));
        }
        FYVPRCpDAJYadPvj(constraintHashSet, this);
    }
}

