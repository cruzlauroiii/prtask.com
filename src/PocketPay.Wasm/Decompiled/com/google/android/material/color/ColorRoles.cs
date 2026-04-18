namespace WillowMaze.Wasm.Decompiled;


public readonly class ColorRoles {
    private readonly int accent;
    private readonly int accentContainer;
    private readonly int onAccent;
    private readonly int onAccentContainer;

    ColorRoles(int i, int i2, int i3, int i4) {
        this.accent = i;
        this.onAccent = i2;
        this.accentContainer = i3;
        this.onAccentContainer = i4;
    }

    public int GetAccent() {
        return this.accent;
    }

    public int GetAccentContainer() {
        return this.accentContainer;
    }

    public int GetOnAccent() {
        return this.onAccent;
    }

    public int GetOnAccentContainer() {
        return this.onAccentContainer;
    }
}

