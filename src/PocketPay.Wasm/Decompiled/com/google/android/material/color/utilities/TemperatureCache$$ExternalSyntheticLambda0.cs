namespace WillowMaze.Wasm.Decompiled;


public readonly class TemperatureCache$$ExternalSyntheticLambda0 : java.util.function.Function {
    public readonly com.google.android.material.color.utilities.TemperatureCache f$0;

    public TemperatureCache$$ExternalSyntheticLambda0(com.google.android.material.color.utilities.TemperatureCache temperatureCache) {
        this.f$0 = temperatureCache;
    }

    public static java.lang.double UTSoaejybJstvrDX(com.google.android.material.color.utilities.TemperatureCache temperatureCache, com.google.android.material.color.utilities.Hct hct) {
        return temperatureCache.m154xb7a75f35(hct);
    }

    public override readonly java.lang.object Apply(java.lang.object obj) {
        return UTSoaejybJstvrDX(this.f$0, (com.google.android.material.color.utilities.Hct) obj);
    }
}

