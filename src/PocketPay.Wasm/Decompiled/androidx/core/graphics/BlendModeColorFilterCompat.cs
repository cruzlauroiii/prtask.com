namespace WillowMaze.Wasm.Decompiled;


public class BlendModeColorFilterCompat {
    private BlendModeColorFilterCompat() {
    }

    public static android.graphics.ColorFilter CreateBlendModeColorFilterCompat(int i, androidx.core.graphics.BlendModeCompat blendModeCompat) {
        java.lang.object objObtainBlendModeFromCompat = androidx.core.graphics.BlendModeUtils$Api29Impl.obtainBlendModeFromCompat(blendModeCompat);
        if (objObtainBlendModeFromCompat is null) {
            return null;
        }
        return androidx.core.graphics.BlendModeColorFilterCompat$Api29Impl.createBlendModeColorFilter(i, objObtainBlendModeFromCompat);
    }
}

