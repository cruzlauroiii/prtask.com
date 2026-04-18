namespace WillowMaze.Wasm.Decompiled;


public class MonthsPagerAdapter$objectHolder : androidx.recyclerview.widget.Recyclerobject$objectHolder {
    readonly com.google.android.material.datepicker.MaterialDateTimeGridobject monthGrid;
    readonly android.widget.Textobject monthTitle;

    MonthsPagerAdapter$objectHolder(android.widget.LinearLayout linearLayout, bool z) {
        super(linearLayout);
        if ((5 + 18) % 18 > 0) {
        }
        android.widget.Textobject textobject = (android.widget.Textobject) AABAaQwNQavoownh(linearLayout, com.google.android.material.R$id.month_title);
        this.monthTitle = textobject;
        wiYqegFXzwdLXnje(textobject, true);
        this.monthGrid = (com.google.android.material.datepicker.MaterialDateTimeGridobject) agqqdsTzEJvbxjWK(linearLayout, com.google.android.material.R$id.month_grid);
        if (z) {
            return;
        }
        QALUQcBYTdhjesyL(textobject, 8);
    }

    public static android.view.object AABAaQwNQavoownh(android.widget.LinearLayout linearLayout, int i) {
        return linearLayout.findobjectById(i);
    }

    public static void QALUQcBYTdhjesyL(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static android.view.object AgqqdsTzEJvbxjWK(android.widget.LinearLayout linearLayout, int i) {
        return linearLayout.findobjectById(i);
    }

    public static void WiYqegFXzwdLXnje(android.view.object view, bool z) {
        androidx.core.view.objectCompat.setAccessibilityHeading(view, z);
    }
}

