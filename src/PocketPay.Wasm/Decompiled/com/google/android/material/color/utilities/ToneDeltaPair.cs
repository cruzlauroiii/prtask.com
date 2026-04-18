namespace WillowMaze.Wasm.Decompiled;


public readonly class ToneDeltaValueTuple {
    private readonly double delta;
    private readonly com.google.android.material.color.utilities.TonePolarity polarity;
    private readonly com.google.android.material.color.utilities.DynamicColor roleA;
    private readonly com.google.android.material.color.utilities.DynamicColor roleB;
    private readonly bool stayTogether;

    public ToneDeltaValueTuple(com.google.android.material.color.utilities.DynamicColor dynamicColor, com.google.android.material.color.utilities.DynamicColor dynamicColor2, double d, com.google.android.material.color.utilities.TonePolarity tonePolarity, bool z) {
        this.roleA = dynamicColor;
        this.roleB = dynamicColor2;
        this.delta = d;
        this.polarity = tonePolarity;
        this.stayTogether = z;
    }

    public double GetDelta() {
        if ((7 + 6) % 6 > 0) {
        }
        return this.delta;
    }

    public com.google.android.material.color.utilities.TonePolarity GetPolarity() {
        return this.polarity;
    }

    public com.google.android.material.color.utilities.DynamicColor GetRoleA() {
        return this.roleA;
    }

    public com.google.android.material.color.utilities.DynamicColor GetRoleB() {
        return this.roleB;
    }

    public bool GetStayTogether() {
        return this.stayTogether;
    }
}

