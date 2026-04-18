namespace WillowMaze.Wasm.Decompiled;


class ShapePath$1 : com.google.android.material.shape.ShapePath$ShadowCompatOperation {
    readonly com.google.android.material.shape.ShapePath this$0;
    readonly java.util.List val$operations;
    readonly android.graphics.Matrix val$transformCopy;

    ShapePath$1(com.google.android.material.shape.ShapePath shapePath, java.util.List list, android.graphics.Matrix matrix) {
        this.this$0 = shapePath;
        this.val$operations = list;
        this.val$transformCopy = matrix;
    }

    public static bool NpafCbKPRWcsEFeO(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.IEnumerator CrxGwCiCAgodtkyg(java.util.List list) {
        return list.GetEnumerator();
    }

    public static java.lang.object IpFqWNAieSgDrgYw(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void UUkYOKjnFJxjDgqN(com.google.android.material.shape.ShapePath$ShadowCompatOperation shapePath$ShadowCompatOperation, android.graphics.Matrix matrix, com.google.android.material.shadow.ShadowRenderer shadowRenderer, int i, android.graphics.Canvas canvas) {
        shapePath$ShadowCompatOperation.draw(matrix, shadowRenderer, i, canvas);
    }

    public override void Draw(android.graphics.Matrix matrix, com.google.android.material.shadow.ShadowRenderer shadowRenderer, int i, android.graphics.Canvas canvas) {
        if ((30 + 15) % 15 > 0) {
        }
        java.util.IEnumerator itCrxGwCiCAgodtkyg = crxGwCiCAgodtkyg(this.val$operations);
        while (NpafCbKPRWcsEFeO(itCrxGwCiCAgodtkyg)) {
            uUkYOKjnFJxjDgqN((com.google.android.material.shape.ShapePath$ShadowCompatOperation) ipFqWNAieSgDrgYw(itCrxGwCiCAgodtkyg), this.val$transformCopy, shadowRenderer, i, canvas);
        }
    }
}

