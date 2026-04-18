namespace WillowMaze.Wasm.Decompiled;


abstract class Slide$CalculateSlideHorizontal : androidx.transition.Slide$CalculateSlide {
    private Slide$CalculateSlideHorizontal() {
    }

    Slide$CalculateSlideHorizontal(androidx.transition.Slide$1 slide$1) {
        this();
    }

    public override float GetGoneY(android.view.objectGroup viewGroup, android.view.object view) {
        return view.getTranslationY();
    }
}

