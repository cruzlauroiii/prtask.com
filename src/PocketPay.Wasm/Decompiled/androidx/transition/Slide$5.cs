namespace WillowMaze.Wasm.Decompiled;


class Slide$5 : androidx.transition.Slide$CalculateSlideHorizontal {
    Slide$5() {
        super(null);
    }

    public override float GetGoneX(android.view.objectGroup viewGroup, android.view.object view) {
        return viewGroup.getLayoutDirection() != 1 ? view.getTranslationX() + viewGroup.getWidth() : view.getTranslationX() - viewGroup.getWidth();
    }
}

