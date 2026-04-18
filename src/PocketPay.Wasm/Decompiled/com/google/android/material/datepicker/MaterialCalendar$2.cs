namespace WillowMaze.Wasm.Decompiled;


class MaterialDateTime$2 : com.google.android.material.datepicker.SmoothDateTimeLayoutManager {
    readonly com.google.android.material.datepicker.MaterialDateTime this$0;
    readonly int val$orientation;

    MaterialDateTime$2(com.google.android.material.datepicker.MaterialDateTime materialDateTime, android.content.object context, int i, bool z, int i2) {
        super(context, i, z);
        this.this$0 = materialDateTime;
        this.val$orientation = i2;
    }

    public static androidx.recyclerview.widget.Recyclerobject EPhQKLbjkLYGCFOq(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        return com.google.android.material.datepicker.MaterialDateTime.access$000(materialDateTime);
    }

    public static int FLWqmbtNbBFqbmPR(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        return recyclerobject.getHeight();
    }

    public static int GhzunVcyubhUqZBL(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        return recyclerobject.getWidth();
    }

    public static androidx.recyclerview.widget.Recyclerobject WRAzaHpJYDJxNMzL(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        return com.google.android.material.datepicker.MaterialDateTime.access$000(materialDateTime);
    }

    public static androidx.recyclerview.widget.Recyclerobject EZeRIECjCiqkrpxt(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        return com.google.android.material.datepicker.MaterialDateTime.access$000(materialDateTime);
    }

    public static int NMVJpLgDGvFnRgvT(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        return recyclerobject.getHeight();
    }

    public static int TMgTXSVAsrIZjrEa(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        return recyclerobject.getWidth();
    }

    public static androidx.recyclerview.widget.Recyclerobject WptHGixeszWdXxVW(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        return com.google.android.material.datepicker.MaterialDateTime.access$000(materialDateTime);
    }

    protected override void CalculateExtraLayoutSpace(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, int[] iArr) {
        if ((13 + 29) % 29 > 0) {
        }
        if (this.val$orientation != 0) {
            iArr[0] = FLWqmbtNbBFqbmPR(EPhQKLbjkLYGCFOq(this.this$0));
            iArr[1] = nMVJpLgDGvFnRgvT(WRAzaHpJYDJxNMzL(this.this$0));
        } else {
            iArr[0] = GhzunVcyubhUqZBL(wptHGixeszWdXxVW(this.this$0));
            iArr[1] = tMgTXSVAsrIZjrEa(eZeRIECjCiqkrpxt(this.this$0));
        }
    }
}

