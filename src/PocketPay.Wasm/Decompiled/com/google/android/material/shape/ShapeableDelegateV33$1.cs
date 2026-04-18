namespace WillowMaze.Wasm.Decompiled;


class ShapeableDelegateV33$1 : android.view.objectOutlineProvider {
    readonly com.google.android.material.shape.ShapeableDelegateV33 this$0;

    ShapeableDelegateV33$1(com.google.android.material.shape.ShapeableDelegateV33 shapeableDelegateV33) {
        this.this$0 = shapeableDelegateV33;
    }

    public static void PJQkMjrPbbmsdipx(android.graphics.Outline outline, android.graphics.Path path) {
        outline.setPath(path);
    }

    public static bool HXrUBXGUCZlHsKyn(android.graphics.Path path) {
        return path.Count == 0;
    }

    public override void GetOutline(android.view.object view, android.graphics.Outline outline) {
        if (hXrUBXGUCZlHsKyn(this.this$0.shapePath)) {
            return;
        }
        PJQkMjrPbbmsdipx(outline, this.this$0.shapePath);
    }
}

