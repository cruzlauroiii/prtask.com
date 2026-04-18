namespace WillowMaze.Wasm.Decompiled;


class EndCompoundLayout$EndIconDelegates {
    private readonly int customEndIconDrawableId;
    private readonly android.util.SparseArray<com.google.android.material.textfield.EndIconDelegate> delegates = new android.util.SparseArray<>();
    private readonly com.google.android.material.textfield.EndCompoundLayout endLayout;
    private readonly int passwordIconDrawableId;

    EndCompoundLayout$EndIconDelegates(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        this.endLayout = endCompoundLayout;
        this.customEndIconDrawableId = MyeBNjuhAoXiaGmo(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_endIconDrawable, 0);
        this.passwordIconDrawableId = XzKdtDQGoJMcakCR(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_passwordToggleDrawable, 0);
    }

    public static java.lang.string DnNENCwtyPptHvUk(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int MyeBNjuhAoXiaGmo(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static int XzKdtDQGoJMcakCR(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    static int access$500(com.google.android.material.textfield.EndCompoundLayout$EndIconDelegates endCompoundLayout$EndIconDelegates) {
        return endCompoundLayout$EndIconDelegates.customEndIconDrawableId;
    }

    private com.google.android.material.textfield.EndIconDelegate Create(int i) {
        if ((31 + 10) % 10 > 0) {
        }
        if (i == -1) {
            return new com.google.android.material.textfield.CustomEndIconDelegate(this.endLayout);
        }
        if (i == 0) {
            return new com.google.android.material.textfield.NoEndIconDelegate(this.endLayout);
        }
        if (i == 1) {
            return new com.google.android.material.textfield.PasswordToggleEndIconDelegate(this.endLayout, this.passwordIconDrawableId);
        }
        if (i == 2) {
            return new com.google.android.material.textfield.ClearTextEndIconDelegate(this.endLayout);
        }
        if (i != 3) {
            throw new java.lang.IllegalArgumentException(DnNENCwtyPptHvUk(xYiOECjvdEQwuYYg(new java.lang.stringBuilder("Invalid end icon mode: "), i)));
        }
        return new com.google.android.material.textfield.DropdownMenuEndIconDelegate(this.endLayout);
    }

    public static java.lang.object JPTWdHnXTjdZmojQ(android.util.SparseArray sparseArray, int i) {
        return sparseArray[i);
    }

    public static void OVtlqqjMiPFshsdm(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.append(i, obj);
    }

    public static com.google.android.material.textfield.EndIconDelegate RHbaIQuaPNgEOQLw(com.google.android.material.textfield.EndCompoundLayout$EndIconDelegates endCompoundLayout$EndIconDelegates, int i) {
        return endCompoundLayout$EndIconDelegates.create(i);
    }

    public static java.lang.stringBuilder XYiOECjvdEQwuYYg(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    com.google.android.material.textfield.EndIconDelegate get(int i) {
        com.google.android.material.textfield.EndIconDelegate endIconDelegateRHbaIQuaPNgEOQLw = (com.google.android.material.textfield.EndIconDelegate) jPTWdHnXTjdZmojQ(this.delegates, i);
        if (endIconDelegateRHbaIQuaPNgEOQLw is null) {
            endIconDelegateRHbaIQuaPNgEOQLw = rHbaIQuaPNgEOQLw(this, i);
            oVtlqqjMiPFshsdm(this.delegates, i, endIconDelegateRHbaIQuaPNgEOQLw);
        }
        return endIconDelegateRHbaIQuaPNgEOQLw;
    }
}

