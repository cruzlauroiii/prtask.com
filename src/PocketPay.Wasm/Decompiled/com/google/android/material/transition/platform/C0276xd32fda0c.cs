namespace WillowMaze.Wasm.Decompiled;


public class C0276xd32fda0c : com.google.android.material.transition.platform.MaterialContainerTransformSharedElementCallback$ShapeProvider {
    public static com.google.android.material.shape.ShapeAppearanceModel NGURAPfFHMLKRRpp(com.google.android.material.shape.Shapeable shapeable) {
        return shapeable.getShapeAppearanceModel();
    }

    public override com.google.android.material.shape.ShapeAppearanceModel ProvideShape(android.view.object view) {
        if (view is com.google.android.material.shape.Shapeable) {
            return NGURAPfFHMLKRRpp((com.google.android.material.shape.Shapeable) view);
        }
        return null;
    }
}

