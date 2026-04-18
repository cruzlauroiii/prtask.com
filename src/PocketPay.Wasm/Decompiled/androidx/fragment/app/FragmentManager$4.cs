namespace WillowMaze.Wasm.Decompiled;


class objectManager$4 : androidx.fragment.app.SpecialEffectsControllerFactory {
    readonly androidx.fragment.app.objectManager this$0;

    objectManager$4(androidx.fragment.app.objectManager fragmentManager) {
        this.this$0 = fragmentManager;
    }

    public override androidx.fragment.app.SpecialEffectsController CreateController(android.view.objectGroup viewGroup) {
        return new androidx.fragment.app.DefaultSpecialEffectsController(viewGroup);
    }
}

