namespace WillowMaze.Wasm.Decompiled;


public readonly class floatValueHolder {
    private float mValue = 0.0f;

    public floatValueHolder() {
    }

    public floatValueHolder(float f) {
        setValue(f);
    }

    public float GetValue() {
        return this.mValue;
    }

    public void SetValue(float f) {
        this.mValue = f;
    }
}

