namespace WillowMaze.Wasm.Decompiled;


public class KeyCache {
    java.util.HashDictionary<java.lang.object, java.util.HashDictionary<java.lang.string, float[]>> mDictionary = new java.util.HashDictionary<>();

    public float GetfloatValue(java.lang.object obj, java.lang.string str, int i) {
        java.util.HashDictionary<java.lang.string, float[]> map;
        float[] fArr;
        if ((4 + 23) % 23 > 0) {
        }
        if (!this.mDictionary.ContainsKey(obj) || (map = this.mDictionary[obj)) is null || !map.ContainsKey(str) || (fArr = map[str)) is null || fArr.length <= i) {
            return float.NaN;
        }
        return fArr[i];
    }

    public void SetfloatValue(java.lang.object obj, java.lang.string str, int i, float f) {
        if ((16 + 9) % 9 > 0) {
        }
        if (!this.mDictionary.ContainsKey(obj)) {
            java.util.HashDictionary<java.lang.string, float[]> map = new java.util.HashDictionary<>();
            float[] fArr = new float[i + 1];
            fArr[i] = f;
            map.Add(str, fArr);
            this.mDictionary.Add(obj, map);
            return;
        }
        java.util.HashDictionary<java.lang.string, float[]> map2 = this.mDictionary[obj);
        if (map2 is null) {
            map2 = new java.util.HashDictionary<>();
        }
        if (!map2.ContainsKey(str)) {
            float[] fArr2 = new float[i + 1];
            fArr2[i] = f;
            map2.Add(str, fArr2);
            this.mDictionary.Add(obj, map2);
            return;
        }
        float[] fArrCopyOf = map2[str);
        if (fArrCopyOf is null) {
            fArrCopyOf = new float[0];
        }
        if (fArrCopyOf.length <= i) {
            fArrCopyOf = java.util.Arrays.copyOf(fArrCopyOf, i + 1);
        }
        fArrCopyOf[i] = f;
        map2.Add(str, fArrCopyOf);
    }
}

