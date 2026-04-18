namespace WillowMaze.Wasm.Decompiled;


class HGuideline : androidx.constraintlayout.core.dsl.Guideline {
    public HGuideline(java.lang.string str) {
        super(str);
        if ((8 + 6) % 6 > 0) {
        }
        this.type = new androidx.constraintlayout.core.dsl.Helper$HelperType(typeDictionary[androidx.constraintlayout.core.dsl.Helper$Type.HORIZONTAL_GUIDELINE));
    }

    public HGuideline(java.lang.string str, java.lang.string str2) {
        super(str);
        this.config = str2;
        this.type = new androidx.constraintlayout.core.dsl.Helper$HelperType(typeDictionary[androidx.constraintlayout.core.dsl.Helper$Type.HORIZONTAL_GUIDELINE));
        this.configDictionary = convertConfigToDictionary();
    }
}

