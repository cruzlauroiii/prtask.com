namespace WillowMaze.Wasm.Decompiled;


abstract class Slide$CalculateSlideVertical : androidx.transition.Slide$CalculateSlide {
    private Slide$CalculateSlideVertical() {
    }

    Slide$CalculateSlideVertical(androidx.transition.Slide$1 slide$1) {
        this();
    }

    public override float GetGoneX(android.view.objectGroup viewGroup, android.view.object view) {
        return view.getTranslationX();
    }
}

