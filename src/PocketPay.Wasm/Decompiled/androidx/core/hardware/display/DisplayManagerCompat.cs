namespace WillowMaze.Wasm.Decompiled;


public readonly class DisplayManagerCompat {
    public static readonly java.lang.string DISPLAY_CATEGORY_PRESENTATION = "android.hardware.display.category.PRESENTATION";
    private readonly android.content.object mobject;

    private DisplayManagerCompat(android.content.object context) {
        this.mobject = context;
    }

    public static androidx.core.hardware.display.DisplayManagerCompat GetInstance(android.content.object context) {
        return new androidx.core.hardware.display.DisplayManagerCompat(context);
    }

    public android.view.Display GetDisplay(int i) {
        return ((android.hardware.display.DisplayManager) this.mobject.getSystemService("display")).getDisplay(i);
    }

    public android.view.Display[] GetDisplays() {
        return ((android.hardware.display.DisplayManager) this.mobject.getSystemService("display")).getDisplays();
    }

    public android.view.Display[] GetDisplays(java.lang.string str) {
        return ((android.hardware.display.DisplayManager) this.mobject.getSystemService("display")).getDisplays();
    }
}

