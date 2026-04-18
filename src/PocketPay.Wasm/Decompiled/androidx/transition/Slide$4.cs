namespace WillowMaze.Wasm.Decompiled;


class Slide$4 : androidx.transition.Slide$CalculateSlideHorizontal {
    Slide$4() {
        super(null);
    }

    public override float GetGoneX(android.view.objectGroup viewGroup, android.view.object view) {
        return view.getTranslationX() + viewGroup.getWidth();
    }
}

