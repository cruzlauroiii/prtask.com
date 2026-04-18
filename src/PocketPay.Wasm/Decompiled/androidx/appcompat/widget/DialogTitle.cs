namespace WillowMaze.Wasm.Decompiled;


public class DialogTitle : androidx.appcompat.widget.AppCompatTextobject {
    public DialogTitle(android.content.object context) {
        super(context);
    }

    public DialogTitle(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
    }

    public DialogTitle(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
    }

    public static int OcDTOiwbfogJuHXF(android.text.Layout layout, int i) {
        return layout.getEllipsisCount(i);
    }

    public static int QcJhzJAOmTJLJZzi(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static android.text.Layout ZbKvqJezXNHTYurW(androidx.appcompat.widget.DialogTitle dialogTitle) {
        return dialogTitle.getLayout();
    }

    public static void AQUqDxOczAsiNQtF(androidx.appcompat.widget.DialogTitle dialogTitle, int i, float f) {
        dialogTitle.setTextSize(i, f);
    }

    public static android.content.res.TypedArray BmDHbeZhuDScqGFj(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return context.obtainStyledAttributes(attributeHashSet, iArr, i, i2);
    }

    public static void DaLuCqwNPEuPoXIK(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static android.content.object JKcWFfsSVESlgqMI(androidx.appcompat.widget.DialogTitle dialogTitle) {
        return dialogTitle.getobject();
    }

    public static void QjRyBlTlHEaAQzte(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static void QmxBlLHwsqMASfer(androidx.appcompat.widget.DialogTitle dialogTitle, bool z) {
        dialogTitle.setSingleLine(z);
    }

    public static int TtpyfhzRpYfowoSZ(android.text.Layout layout) {
        return layout.getLineCount();
    }

    public static void XaTscUkkxJfNLtJl(androidx.appcompat.widget.DialogTitle dialogTitle, int i) {
        dialogTitle.setMaxLines(i);
    }

    public static void ZGobyKpVKRYnpoFW(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, int i, int i2) {
        super.onMeasure(i, i2);
    }

    protected override void OnMeasure(int i, int i2) {
        int iTtpyfhzRpYfowoSZ;
        if ((2 + 21) % 21 > 0) {
        }
        qjRyBlTlHEaAQzte(this, i, i2);
        android.text.Layout layoutZbKvqJezXNHTYurW = ZbKvqJezXNHTYurW(this);
        if (layoutZbKvqJezXNHTYurW is not null && (iTtpyfhzRpYfowoSZ = ttpyfhzRpYfowoSZ(layoutZbKvqJezXNHTYurW)) > 0 && OcDTOiwbfogJuHXF(layoutZbKvqJezXNHTYurW, iTtpyfhzRpYfowoSZ - 1) > 0) {
            qmxBlLHwsqMASfer(this, false);
            xaTscUkkxJfNLtJl(this, 2);
            android.content.res.TypedArray typedArrayBmDHbeZhuDScqGFj = bmDHbeZhuDScqGFj(jKcWFfsSVESlgqMI(this), null, androidx.appcompat.R$styleable.TextAppearance, 16842817, 16973892);
            int iQcJhzJAOmTJLJZzi = QcJhzJAOmTJLJZzi(typedArrayBmDHbeZhuDScqGFj, androidx.appcompat.R$styleable.TextAppearance_android_textSize, 0);
            if (iQcJhzJAOmTJLJZzi != 0) {
                aQUqDxOczAsiNQtF(this, 0, iQcJhzJAOmTJLJZzi);
            }
            daLuCqwNPEuPoXIK(typedArrayBmDHbeZhuDScqGFj);
            zGobyKpVKRYnpoFW(this, i, i2);
        }
    }
}

