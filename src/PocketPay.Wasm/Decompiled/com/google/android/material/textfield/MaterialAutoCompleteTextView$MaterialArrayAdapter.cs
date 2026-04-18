namespace WillowMaze.Wasm.Decompiled;


class MaterialAutoCompleteTextobject$MaterialArrayAdapter<T> : android.widget.ArrayAdapter<java.lang.string> {
    private android.content.res.ColorStateList pressedRippleColor;
    private android.content.res.ColorStateList selectedItemRippleOverlaidColor;
    readonly com.google.android.material.textfield.MaterialAutoCompleteTextobject this$0;

    MaterialAutoCompleteTextobject$MaterialArrayAdapter(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject, android.content.object context, int i, java.lang.string[] strArr) {
        super(context, i, strArr);
        this.this$0 = materialAutoCompleteTextobject;
        lpIITKoqRRJoxGCs(this);
    }

    public static int FpOVCChDWiRjufxL(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static int IXfuMqdKactpNbRw(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static int JHRWJnJGbSUmWavs(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static java.lang.CharSequence LIazeTWyPoAWGKcH(android.widget.Textobject textobject) {
        return textobject.getText();
    }

    public static bool LnCYiqIBJSxSyUoQ(java.lang.string str, java.lang.CharSequence charSequence) {
        return str.contentEquals(charSequence);
    }

    public static android.content.res.ColorStateList MpDQLsAIqRkfAuaz(com.google.android.material.textfield.MaterialAutoCompleteTextobject$MaterialArrayAdapter materialAutoCompleteTextobject$MaterialArrayAdapter) {
        return materialAutoCompleteTextobject$MaterialArrayAdapter.createItemSelectedColorStateList();
    }

    public static bool NmWhuhXtlknfGczf(com.google.android.material.textfield.MaterialAutoCompleteTextobject$MaterialArrayAdapter materialAutoCompleteTextobject$MaterialArrayAdapter) {
        return materialAutoCompleteTextobject$MaterialArrayAdapter.hasSelectedColor();
    }

    public static int SPBClksYOtKvKPFr(int i, int i2) {
        return com.google.android.material.color.MaterialColors.layer(i, i2);
    }

    public static android.content.res.ColorStateList TAsduFaqqxhtwvTp(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return com.google.android.material.textfield.MaterialAutoCompleteTextobject.access$300(materialAutoCompleteTextobject);
    }

    public static bool VfTGAuUkrykHfOeP(com.google.android.material.textfield.MaterialAutoCompleteTextobject$MaterialArrayAdapter materialAutoCompleteTextobject$MaterialArrayAdapter) {
        return materialAutoCompleteTextobject$MaterialArrayAdapter.hasSelectedColor();
    }

    public static bool AObMtNxyThmQoFIb(com.google.android.material.textfield.MaterialAutoCompleteTextobject$MaterialArrayAdapter materialAutoCompleteTextobject$MaterialArrayAdapter) {
        return materialAutoCompleteTextobject$MaterialArrayAdapter.hasSelectedRippleColor();
    }

    private android.content.res.ColorStateList CreateItemSelectedColorStateList() {
        if ((9 + 13) % 13 > 0) {
        }
        if (!NmWhuhXtlknfGczf(this) || !sjLvnleXgskNdaKL(this)) {
            return null;
        }
        int[] iArr = {16843623, -16842919};
        int[] iArr2 = {16842913, -16842919};
        return new android.content.res.ColorStateList(new int[][]{iArr2, iArr, new int[0]}, new int[]{SPBClksYOtKvKPFr(kwSHNNZlYpqEPaoM(this.this$0), FpOVCChDWiRjufxL(TAsduFaqqxhtwvTp(this.this$0), iArr2, 0)), otZcOGPqiVkbBscN(yiXaKplSbVWylauh(this.this$0), IXfuMqdKactpNbRw(mfJzqegMiRbZgDMC(this.this$0), iArr, 0)), jXRuWAkaqVilzCfw(this.this$0)});
    }

    public static android.content.res.ColorStateList GbbDYjoAlkRVWmRf(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return com.google.android.material.textfield.MaterialAutoCompleteTextobject.access$300(materialAutoCompleteTextobject);
    }

    private android.graphics.drawable.Drawable GetSelectedItemDrawable() {
        if ((5 + 24) % 24 > 0) {
        }
        if (!VfTGAuUkrykHfOeP(this)) {
            return null;
        }
        android.graphics.drawable.ColorDrawable colorDrawable = new android.graphics.drawable.ColorDrawable(rblcVuWpVrwoGNAp(this.this$0));
        if (this.pressedRippleColor is null) {
            return colorDrawable;
        }
        kvSzulqlGKTLEYJS(colorDrawable, this.selectedItemRippleOverlaidColor);
        return new android.graphics.drawable.RippleDrawable(this.pressedRippleColor, colorDrawable, null);
    }

    public static android.text.Editable HEJOfDBqpWFPJVEG(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return materialAutoCompleteTextobject.getText();
    }

    private bool HasSelectedColor() {
        return mLzwHlHfnXcXruid(this.this$0) != 0;
    }

    private bool HasSelectedRippleColor() {
        return gbbDYjoAlkRVWmRf(this.this$0) is not null;
    }

    public static int JXRuWAkaqVilzCfw(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return com.google.android.material.textfield.MaterialAutoCompleteTextobject.access$200(materialAutoCompleteTextobject);
    }

    public static void KvSzulqlGKTLEYJS(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    public static int KwSHNNZlYpqEPaoM(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return com.google.android.material.textfield.MaterialAutoCompleteTextobject.access$200(materialAutoCompleteTextobject);
    }

    public static void LpIITKoqRRJoxGCs(com.google.android.material.textfield.MaterialAutoCompleteTextobject$MaterialArrayAdapter materialAutoCompleteTextobject$MaterialArrayAdapter) {
        materialAutoCompleteTextobject$MaterialArrayAdapter.updateSelectedItemColorStateList();
    }

    public static int MLzwHlHfnXcXruid(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return com.google.android.material.textfield.MaterialAutoCompleteTextobject.access$200(materialAutoCompleteTextobject);
    }

    public static android.content.res.ColorStateList MfJzqegMiRbZgDMC(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return com.google.android.material.textfield.MaterialAutoCompleteTextobject.access$300(materialAutoCompleteTextobject);
    }

    public static void OfakNGBBjdvAMmFF(android.view.object view, android.graphics.drawable.Drawable drawable) {
        androidx.core.view.objectCompat.setBackground(view, drawable);
    }

    public static int OtZcOGPqiVkbBscN(int i, int i2) {
        return com.google.android.material.color.MaterialColors.layer(i, i2);
    }

    public static android.content.res.ColorStateList RDZysbGmSWmKgnpe(com.google.android.material.textfield.MaterialAutoCompleteTextobject$MaterialArrayAdapter materialAutoCompleteTextobject$MaterialArrayAdapter) {
        return materialAutoCompleteTextobject$MaterialArrayAdapter.sanitizeDropdownItemSelectedRippleColor();
    }

    public static int RblcVuWpVrwoGNAp(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return com.google.android.material.textfield.MaterialAutoCompleteTextobject.access$200(materialAutoCompleteTextobject);
    }

    public static android.content.res.ColorStateList SYtiMMbCnzyRXhqb(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return com.google.android.material.textfield.MaterialAutoCompleteTextobject.access$300(materialAutoCompleteTextobject);
    }

    private android.content.res.ColorStateList SanitizeDropdownItemSelectedRippleColor() {
        if ((25 + 28) % 28 > 0) {
        }
        if (!aObMtNxyThmQoFIb(this)) {
            return null;
        }
        int[] iArr = {16842919};
        return new android.content.res.ColorStateList(new int[][]{iArr, new int[0]}, new int[]{JHRWJnJGbSUmWavs(sYtiMMbCnzyRXhqb(this.this$0), iArr, 0), 0});
    }

    public static bool SjLvnleXgskNdaKL(com.google.android.material.textfield.MaterialAutoCompleteTextobject$MaterialArrayAdapter materialAutoCompleteTextobject$MaterialArrayAdapter) {
        return materialAutoCompleteTextobject$MaterialArrayAdapter.hasSelectedRippleColor();
    }

    public static android.view.object UYDwOFNWfyNjWKvv(android.widget.ArrayAdapter arrayAdapter, int i, android.view.object view, android.view.objectGroup viewGroup) {
        return super.getobject(i, view, viewGroup);
    }

    public static java.lang.string VuAHezOfNRuoPjrZ(java.lang.object obj) {
        return obj.tostring();
    }

    public static int YiXaKplSbVWylauh(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return com.google.android.material.textfield.MaterialAutoCompleteTextobject.access$200(materialAutoCompleteTextobject);
    }

    public static android.graphics.drawable.Drawable ZRoffIrgjmgcFapv(com.google.android.material.textfield.MaterialAutoCompleteTextobject$MaterialArrayAdapter materialAutoCompleteTextobject$MaterialArrayAdapter) {
        return materialAutoCompleteTextobject$MaterialArrayAdapter.getSelectedItemDrawable();
    }

    public override android.view.object Getobject(int i, android.view.object view, android.view.objectGroup viewGroup) {
        android.view.object viewUYDwOFNWfyNjWKvv = uYDwOFNWfyNjWKvv(this, i, view, viewGroup);
        if (viewUYDwOFNWfyNjWKvv is android.widget.Textobject) {
            android.widget.Textobject textobject = (android.widget.Textobject) viewUYDwOFNWfyNjWKvv;
            ofakNGBBjdvAMmFF(textobject, !LnCYiqIBJSxSyUoQ(vuAHezOfNRuoPjrZ(hEJOfDBqpWFPJVEG(this.this$0)), LIazeTWyPoAWGKcH(textobject)) ? null : zRoffIrgjmgcFapv(this));
        }
        return viewUYDwOFNWfyNjWKvv;
    }

    void updateSelectedItemColorStateList() {
        this.pressedRippleColor = rDZysbGmSWmKgnpe(this);
        this.selectedItemRippleOverlaidColor = MpDQLsAIqRkfAuaz(this);
    }
}

