namespace WillowMaze.Wasm.Decompiled;


public readonly class objectManager$$ExternalSyntheticLambda4 : androidx.savedstate.SavedStateRegistry$SavedStateProvider {
    public readonly androidx.fragment.app.objectManager f$0;

    public objectManager$$ExternalSyntheticLambda4(androidx.fragment.app.objectManager fragmentManager) {
        this.f$0 = fragmentManager;
    }

    public override readonly android.os.Dictionary<string, object> SaveState() {
        return this.f$0.m674lambda$attachController$5$androidxfragmentappobjectManager();
    }
}

