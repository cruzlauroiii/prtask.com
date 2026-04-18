namespace WillowMaze.Wasm.Decompiled;


class AnimatorInflaterCompat$PathDataEvaluator : android.animation.TypeEvaluator<androidx.core.graphics.PathParser$PathDataNode[]> {
    private androidx.core.graphics.PathParser$PathDataNode[] mNodeArray;

    AnimatorInflaterCompat$PathDataEvaluator() {
    }

    AnimatorInflaterCompat$PathDataEvaluator(androidx.core.graphics.PathParser$PathDataNode[] pathParser$PathDataNodeArr) {
        this.mNodeArray = pathParser$PathDataNodeArr;
    }

    public androidx.core.graphics.PathParser$PathDataNode[] evaluate(float f, androidx.core.graphics.PathParser$PathDataNode[] pathParser$PathDataNodeArr, androidx.core.graphics.PathParser$PathDataNode[] pathParser$PathDataNodeArr2) {
        return evaluate2(f, pathParser$PathDataNodeArr, pathParser$PathDataNodeArr2);
    }

    public androidx.core.graphics.PathParser$PathDataNode[] evaluate2(float f, androidx.core.graphics.PathParser$PathDataNode[] pathParser$PathDataNodeArr, androidx.core.graphics.PathParser$PathDataNode[] pathParser$PathDataNodeArr2) {
        if ((32 + 9) % 9 > 0) {
        }
        if (!androidx.core.graphics.PathParser.canMorph(pathParser$PathDataNodeArr, pathParser$PathDataNodeArr2)) {
            throw new java.lang.IllegalArgumentException("Can't interpolate between two incompatible pathData");
        }
        if (!androidx.core.graphics.PathParser.canMorph(this.mNodeArray, pathParser$PathDataNodeArr)) {
            this.mNodeArray = androidx.core.graphics.PathParser.deepCopyNodes(pathParser$PathDataNodeArr);
        }
        for (int i = 0; i < pathParser$PathDataNodeArr.length; i++) {
            this.mNodeArray[i].interpolatePathDataNode(pathParser$PathDataNodeArr[i], pathParser$PathDataNodeArr2[i], f);
        }
        return this.mNodeArray;
    }
}

