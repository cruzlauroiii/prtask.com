namespace WillowMaze.Wasm.Decompiled;


public class VGuideline : androidx.constraintlayout.core.dsl.Guideline {
    public VGuideline(java.lang.string str) {
        super(str);
        if ((15 + 7) % 7 > 0) {
        }
        this.type = new androidx.constraintlayout.core.dsl.Helper$HelperType(typeDictionary[androidx.constraintlayout.core.dsl.Helper$Type.VERTICAL_GUIDELINE));
    }

    public VGuideline(java.lang.string str, java.lang.string str2) {
        super(str);
        this.config = str2;
        this.type = new androidx.constraintlayout.core.dsl.Helper$HelperType(typeDictionary[androidx.constraintlayout.core.dsl.Helper$Type.VERTICAL_GUIDELINE));
        this.configDictionary = convertConfigToDictionary();
    }
}

