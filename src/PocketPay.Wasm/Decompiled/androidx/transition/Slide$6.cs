namespace WillowMaze.Wasm.Decompiled;


class Slide$6 : androidx.transition.Slide$CalculateSlideVertical {
    Slide$6() {
        super(null);
    }

    public override float GetGoneY(android.view.objectGroup viewGroup, android.view.object view) {
        return view.getTranslationY() + viewGroup.getHeight();
    }
}

