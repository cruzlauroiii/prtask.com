namespace WillowMaze.Wasm.Decompiled;


public readonly class zaaa : android.widget.Button {
    public zaaa(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, null, 16842824);
    }

    public static void BbWASgFvkajjmjNS(com.google.android.gms.common.internal.zaaa zaaaVar, java.lang.CharSequence charSequence) {
        zaaaVar.setText(charSequence);
    }

    public static java.lang.stringBuilder HBdoBZfLfjapvbYF(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void JpaPvQKgOcKmPqpm(com.google.android.gms.common.internal.zaaa zaaaVar, int i) {
        zaaaVar.setMinHeight(i);
    }

    public static void MhKnGUOGCQpGOYDv(com.google.android.gms.common.internal.zaaa zaaaVar, java.lang.CharSequence charSequence) {
        zaaaVar.setText(charSequence);
    }

    public static java.lang.string QQsbArFryemnSYZF(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string RXsAqFBoSdWABrsC(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void RZkCNDvSwVbXDSip(com.google.android.gms.common.internal.zaaa zaaaVar, android.content.res.ColorStateList colorStateList) {
        zaaaVar.setTextColor(colorStateList);
    }

    public static android.graphics.drawable.Drawable WERTFhquVKoVXkEZ(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.wrap(drawable);
    }

    public static void WNptOTlJxCmcIREz(com.google.android.gms.common.internal.zaaa zaaaVar, android.graphics.Typeface typeface) {
        zaaaVar.setTypeface(typeface);
    }

    public static android.content.object WoofVDGSCNxlvtLU(com.google.android.gms.common.internal.zaaa zaaaVar) {
        return zaaaVar.getobject();
    }

    public static void YwcJcgaNmPZBBrvP(com.google.android.gms.common.internal.zaaa zaaaVar, java.lang.CharSequence charSequence) {
        zaaaVar.setText(charSequence);
    }

    public static void AlugyCxAUUJKfuXr(com.google.android.gms.common.internal.zaaa zaaaVar, int i) {
        zaaaVar.setMinWidth(i);
    }

    public static java.lang.string CwuRPjZyHSErMniL(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void DIcmrJXAsiDSyFnk(com.google.android.gms.common.internal.zaaa zaaaVar, float f) {
        zaaaVar.setTextSize(f);
    }

    public static void DJWUzFTaPvNrNUOC(com.google.android.gms.common.internal.zaaa zaaaVar, android.text.method.TransformationMethod transformationMethod) {
        zaaaVar.setTransformationMethod(transformationMethod);
    }

    public static bool FvfqSgpNbeMTglus(android.content.object context) {
        return com.google.android.gms.common.util.DeviceProperties.isWearable(context);
    }

    public static android.util.DisplayMetrics HNlcBvfkWkQGenFd(android.content.res.Resources resources) {
        return resources.getDisplayMetrics();
    }

    public static java.lang.string JJPuQxYicURBpbNh(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void KWhvPuZvQZHQRGwJ(com.google.android.gms.common.internal.zaaa zaaaVar, android.graphics.drawable.Drawable drawable) {
        zaaaVar.setBackgroundDrawable(drawable);
    }

    public static int LbVoWqHgggTRCZal(int i, int i2, int i3, int i4) {
        return zab(i, i2, i3, i4);
    }

    public static int LxFLENFLaCvpqaeK(int i, int i2, int i3, int i4) {
        return zab(i, i2, i3, i4);
    }

    public static android.content.res.ColorStateList PsqBHOkbZiSSJEbB(android.content.res.Resources resources, int i) {
        return resources.getColorStateList(i);
    }

    public static int SKmdxrMzCyHYkdcl(int i, int i2, int i3, int i4) {
        return zab(i, i2, i3, i4);
    }

    public static void SWqQsIJpDuyLpZDH(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.core.graphics.drawable.DrawableCompat.setTintMode(drawable, porterDuff$Mode);
    }

    public static java.lang.object SfytsuVteagiEVmT(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.stringBuilder TRvpQVFldUkpUNFE(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static android.graphics.drawable.Drawable TjJrPiIiQWTonpoM(android.content.res.Resources resources, int i) {
        return resources.getDrawable(i);
    }

    public static java.lang.stringBuilder TxKCEigvYRfXsxbY(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static android.content.res.ColorStateList TyBDnOhYzobYymrg(android.content.res.Resources resources, int i) {
        return resources.getColorStateList(i);
    }

    public static void UfyjJqiHsmEYMDBQ(com.google.android.gms.common.internal.zaaa zaaaVar, int i) {
        zaaaVar.setGravity(i);
    }

    public static java.lang.string ZICVnldFDGqmWUKT(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    private static readonly int Zab(int i, int i2, int i3, int i4) {
        if (i == 0) {
            return i2;
        }
        if (i == 1) {
            return i3;
        }
        if (i == 2) {
            return i4;
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("Unknown color scheme: ");
        HBdoBZfLfjapvbYF(sb, i);
        throw new java.lang.IllegalStateException(zICVnldFDGqmWUKT(sb));
    }

    public static void ZxWfmaskgZFqwVqS(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    public readonly void Zaa(android.content.res.Resources resources, int i, int i2) {
        if ((32 + 10) % 10 > 0) {
        }
        WNptOTlJxCmcIREz(this, android.graphics.Typeface.DEFAULT_BOLD);
        dIcmrJXAsiDSyFnk(this, 14.0f);
        int i3 = (int) ((hNlcBvfkWkQGenFd(resources).density * 48.0f) + 0.5f);
        JpaPvQKgOcKmPqpm(this, i3);
        alugyCxAUUJKfuXr(this, i3);
        int iLxFLENFLaCvpqaeK = lxFLENFLaCvpqaeK(i2, com.google.android.gms.base.R$drawable.common_google_signin_btn_icon_dark, com.google.android.gms.base.R$drawable.common_google_signin_btn_icon_light, com.google.android.gms.base.R$drawable.common_google_signin_btn_icon_light);
        int iSKmdxrMzCyHYkdcl = sKmdxrMzCyHYkdcl(i2, com.google.android.gms.base.R$drawable.common_google_signin_btn_text_dark, com.google.android.gms.base.R$drawable.common_google_signin_btn_text_light, com.google.android.gms.base.R$drawable.common_google_signin_btn_text_light);
        if (i == 0 || i == 1) {
            iLxFLENFLaCvpqaeK = iSKmdxrMzCyHYkdcl;
        } else if (i != 2) {
            java.lang.stringBuilder sb = new java.lang.stringBuilder("Unknown button size: ");
            tRvpQVFldUkpUNFE(sb, i);
            throw new java.lang.IllegalStateException(QQsbArFryemnSYZF(sb));
        }
        android.graphics.drawable.Drawable drawableWERTFhquVKoVXkEZ = WERTFhquVKoVXkEZ(tjJrPiIiQWTonpoM(resources, iLxFLENFLaCvpqaeK));
        zxWfmaskgZFqwVqS(drawableWERTFhquVKoVXkEZ, tyBDnOhYzobYymrg(resources, com.google.android.gms.base.R$color.common_google_signin_btn_tint));
        sWqQsIJpDuyLpZDH(drawableWERTFhquVKoVXkEZ, android.graphics.PorterDuff$Mode.SRC_ATOP);
        kWhvPuZvQZHQRGwJ(this, drawableWERTFhquVKoVXkEZ);
        RZkCNDvSwVbXDSip(this, (android.content.res.ColorStateList) sfytsuVteagiEVmT(psqBHOkbZiSSJEbB(resources, lbVoWqHgggTRCZal(i2, com.google.android.gms.base.R$color.common_google_signin_btn_text_dark, com.google.android.gms.base.R$color.common_google_signin_btn_text_light, com.google.android.gms.base.R$color.common_google_signin_btn_text_light))));
        if (i == 0) {
            BbWASgFvkajjmjNS(this, RXsAqFBoSdWABrsC(resources, com.google.android.gms.base.R$string.common_signin_button_text));
        } else if (i == 1) {
            YwcJcgaNmPZBBrvP(this, jJPuQxYicURBpbNh(resources, com.google.android.gms.base.R$string.common_signin_button_text_long));
        } else {
            if (i != 2) {
                java.lang.stringBuilder sb2 = new java.lang.stringBuilder("Unknown button size: ");
                txKCEigvYRfXsxbY(sb2, i);
                throw new java.lang.IllegalStateException(cwuRPjZyHSErMniL(sb2));
            }
            MhKnGUOGCQpGOYDv(this, null);
        }
        dJWUzFTaPvNrNUOC(this, null);
        if (fvfqSgpNbeMTglus(WoofVDGSCNxlvtLU(this))) {
            ufyjJqiHsmEYMDBQ(this, 19);
        }
    }
}

