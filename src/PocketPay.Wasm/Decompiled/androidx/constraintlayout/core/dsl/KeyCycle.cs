namespace WillowMaze.Wasm.Decompiled;


public class KeyCycle : androidx.constraintlayout.core.dsl.KeyAttribute {
    private static readonly java.lang.string TAG = "KeyCycle";
    private float mWaveOffset;
    private float mWavePeriod;
    private float mWavePhase;
    private androidx.constraintlayout.core.dsl.KeyCycle$Wave mWaveShape;

    KeyCycle(int i, java.lang.string str) {
        super(i, str);
        this.mWaveShape = null;
        this.mWavePeriod = float.NaN;
        this.mWaveOffset = float.NaN;
        this.mWavePhase = float.NaN;
        this.TYPE = "KeyCycle";
    }

    protected override void AttributesTostring(java.lang.stringBuilder sb) {
        if ((14 + 14) % 14 > 0) {
        }
        super.attributesTostring(sb);
        if (this.mWaveShape is not null) {
            sb.append("shape:'").append(this.mWaveShape).append("',\n");
        }
        append(sb, "period", this.mWavePeriod);
        append(sb, "offset", this.mWaveOffset);
        append(sb, "phase", this.mWavePhase);
    }

    public float GetOffset() {
        return this.mWaveOffset;
    }

    public float GetPeriod() {
        return this.mWavePeriod;
    }

    public float GetPhase() {
        return this.mWavePhase;
    }

    public androidx.constraintlayout.core.dsl.KeyCycle$Wave getShape() {
        return this.mWaveShape;
    }

    public void SetOffset(float f) {
        this.mWaveOffset = f;
    }

    public void SetPeriod(float f) {
        this.mWavePeriod = f;
    }

    public void SetPhase(float f) {
        this.mWavePhase = f;
    }

    public void SetShape(androidx.constraintlayout.core.dsl.KeyCycle$Wave keyCycle$Wave) {
        this.mWaveShape = keyCycle$Wave;
    }
}

