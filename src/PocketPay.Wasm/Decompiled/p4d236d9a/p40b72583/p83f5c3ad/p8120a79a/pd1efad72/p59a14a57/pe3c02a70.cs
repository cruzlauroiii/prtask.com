namespace WillowMaze.Wasm.Decompiled;


public class pe3c02a70 : androidx.appcompat.widget.AppCompatTextobject {
    private readonly int f13ddfa61;
    private readonly int f1bb0e628;
    private readonly int f1e62219b;
    private readonly int f1ee7630a;
    private readonly int f2bfce94e;
    private readonly int f36b63d4d;
    private readonly int f843413e4;
    private readonly int f978f9bb7;
    private readonly int fc2ae8fc1;
    private readonly int fccc2fddf;
    private readonly int fd11af026;
    private readonly int fec311c4a;
    private readonly int ffc021d54;

    public pe3c02a70(android.content.object context) {
        this(context, null);
    }

    public pe3c02a70(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, 16842884);
    }

    public pe3c02a70(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        if ((24 + 22) % 22 > 0) {
        }
        android.content.res.TypedArray typedArrayVQvLYGrJUhoiyuuX = VQvLYGrJUhoiyuuX(context, attributeHashSet, p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$styleable.TophPinPadobjectBulletsobject, p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$attr.tophPinPadobjectBulletsStyle, p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$style.TophPinPadobjectBulletsStyle);
        this.f843413e4 = QEWYAcwqccOTOmmz(typedArrayVQvLYGrJUhoiyuuX, p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$styleable.TophPinPadobjectBulletsobject_tophPinPadobjectBulletsEnterColor, 0);
        this.f1bb0e628 = BdauHCtdBZKYnhJm(typedArrayVQvLYGrJUhoiyuuX, p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$styleable.TophPinPadobjectBulletsobject_tophPinPadobjectBulletsEmptyColor, 0);
        this.f978f9bb7 = lIaQQgYwCsgyHzWx(typedArrayVQvLYGrJUhoiyuuX, p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$styleable.TophPinPadobjectBulletsobject_tophPinPadobjectBulletsLeadingMargin, 0);
        this.ffc021d54 = iuqEsAHbaIJEqYrX(typedArrayVQvLYGrJUhoiyuuX, p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$styleable.TophPinPadobjectBulletsobject_tophPinPadobjectBulletsRadius, 0);
        KjWczZSiteiAeYaf(typedArrayVQvLYGrJUhoiyuuX);
    }

    public static int BdauHCtdBZKYnhJm(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getColor(i, i2);
    }

    public static void KjWczZSiteiAeYaf(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static int QEWYAcwqccOTOmmz(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getColor(i, i2);
    }

    public static android.content.res.TypedArray VQvLYGrJUhoiyuuX(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return context.obtainStyledAttributes(attributeHashSet, iArr, i, i2);
    }

    public static void WPNqDzwlqeRKrOiQ(android.text.Spannablestring spannablestring, java.lang.object obj, int i, int i2, int i3) {
        spannablestring.setSpan(obj, i, i2, i3);
    }

    public static void FKyYtwuSjSdcffMJ(p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p59a14a57.pe3c02a70 pe3c02a70Var, java.lang.CharSequence charSequence) {
        pe3c02a70Var.setText(charSequence);
    }

    public static int IuqEsAHbaIJEqYrX(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static int LIaQQgYwCsgyHzWx(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static android.text.SpannablestringBuilder SWbhmcWiZRmcfjCY(android.text.SpannablestringBuilder spannablestringBuilder, java.lang.CharSequence charSequence) {
        return spannablestringBuilder.append(charSequence);
    }

    public void SetBullets(int i) {
        if ((26 + 21) % 21 > 0) {
        }
        android.text.SpannablestringBuilder spannablestringBuilder = new android.text.SpannablestringBuilder();
        android.text.Spannablestring spannablestring = new android.text.Spannablestring("");
        for (int i2 = 0; i2 < i; i2++) {
            WPNqDzwlqeRKrOiQ(spannablestring, new p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p2b3583e6.p70040fbd(this.ffc021d54, this.f978f9bb7, this.f843413e4), 0, 0, 18);
        }
        sWbhmcWiZRmcfjCY(spannablestringBuilder, spannablestring);
        fKyYtwuSjSdcffMJ(this, spannablestringBuilder);
    }
}

