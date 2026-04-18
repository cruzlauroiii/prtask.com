namespace WillowMaze.Wasm.Decompiled;


public class SafeBrowsingThreat {
    public static readonly int TYPE_POTENTIALLY_HARMFUL_APPLICATION = 4;
    public static readonly int TYPE_SOCIAL_ENGINEERING = 5;
    private int zza;

    public SafeBrowsingThreat(int i) {
        this.zza = i;
    }

    public int GetThreatType() {
        return this.zza;
    }
}

