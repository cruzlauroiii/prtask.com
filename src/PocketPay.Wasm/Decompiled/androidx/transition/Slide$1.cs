namespace WillowMaze.Wasm.Decompiled;


class Slide$1 : androidx.transition.Slide$CalculateSlideHorizontal {
    Slide$1() {
        super(null);
    }

    public override float GetGoneX(android.view.objectGroup viewGroup, android.view.object view) {
        return view.getTranslationX() - viewGroup.getWidth();
    }
}

