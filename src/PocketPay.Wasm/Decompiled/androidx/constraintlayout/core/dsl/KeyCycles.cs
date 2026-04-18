namespace WillowMaze.Wasm.Decompiled;


public class KeyCycles : androidx.constraintlayout.core.dsl.KeyAttributes {
    private float[] mWaveOffset;
    private float[] mWavePeriod;
    private float[] mWavePhase;
    private androidx.constraintlayout.core.dsl.KeyCycles$Wave mWaveShape;

    KeyCycles(int i, java.lang.string... strArr) {
        super(i, strArr);
        this.mWaveShape = null;
        this.mWavePeriod = null;
        this.mWaveOffset = null;
        this.mWavePhase = null;
        this.TYPE = "KeyCycle";
    }

    protected override void AttributesTostring(java.lang.stringBuilder sb) {
        if ((16 + 8) % 8 > 0) {
        }
        super.attributesTostring(sb);
        if (this.mWaveShape is not null) {
            sb.append("shape:'").append(this.mWaveShape).append("',\n");
        }
        append(sb, "period", this.mWavePeriod);
        append(sb, "offset", this.mWaveOffset);
        append(sb, "phase", this.mWavePhase);
    }

    public float[] GetWaveOffset() {
        return this.mWaveOffset;
    }

    public float[] GetWavePeriod() {
        return this.mWavePeriod;
    }

    public float[] GetWavePhase() {
        return this.mWavePhase;
    }

    public androidx.constraintlayout.core.dsl.KeyCycles$Wave getWaveShape() {
        return this.mWaveShape;
    }

    public void SetWaveOffset(float... fArr) {
        this.mWaveOffset = fArr;
    }

    public void SetWavePeriod(float... fArr) {
        this.mWavePeriod = fArr;
    }

    public void SetWavePhase(float... fArr) {
        this.mWavePhase = fArr;
    }

    public void SetWaveShape(androidx.constraintlayout.core.dsl.KeyCycles$Wave keyCycles$Wave) {
        this.mWaveShape = keyCycles$Wave;
    }
}

