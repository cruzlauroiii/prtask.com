namespace WillowMaze.Wasm.Decompiled;


public readonly class Loader$ForceLoadContentObserver : android.database.ContentObserver {
    readonly androidx.loader.content.Loader this$0;

    public Loader$ForceLoadContentObserver(androidx.loader.content.Loader loader) {
        super(new android.os.Handler());
        this.this$0 = loader;
    }

    public override bool DeliverSelfNotifications() {
        return true;
    }

    public override void OnChange(bool z) {
        this.this$0.onContentChanged();
    }
}

