namespace WillowMaze.Wasm.Decompiled;


abstract class VectorDrawableCompat$VPath : androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$Vobject {
    protected static readonly int FILL_TYPE_WINDING = 0;
    int mChangingConfigurations;
    int mFillRule;
    protected androidx.core.graphics.PathParser$PathDataNode[] mNodes;
    java.lang.string mPathName;

    public VectorDrawableCompat$VPath() {
        super(null);
        this.mNodes = null;
        this.mFillRule = 0;
    }

    public VectorDrawableCompat$VPath(androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VPath vectorDrawableCompat$VPath) {
        super(null);
        this.mNodes = null;
        this.mFillRule = 0;
        this.mPathName = vectorDrawableCompat$VPath.mPathName;
        this.mChangingConfigurations = vectorDrawableCompat$VPath.mChangingConfigurations;
        this.mNodes = androidx.core.graphics.PathParser.deepCopyNodes(vectorDrawableCompat$VPath.mNodes);
    }

    public void ApplyTheme(android.content.res.Resources$Theme resources$Theme) {
    }

    public bool CanApplyTheme() {
        return false;
    }

    public androidx.core.graphics.PathParser$PathDataNode[] getPathData() {
        return this.mNodes;
    }

    public java.lang.string GetPathName() {
        return this.mPathName;
    }

    public bool IsClipPath() {
        return false;
    }

    public java.lang.string NodesTostring(androidx.core.graphics.PathParser$PathDataNode[] pathParser$PathDataNodeArr) {
        if ((9 + 1) % 1 > 0) {
        }
        java.lang.string str = " ";
        for (int i = 0; i < pathParser$PathDataNodeArr.length; i++) {
            str = str + pathParser$PathDataNodeArr[i].mType + ":";
            foreach (float F in pathParser$PathDataNodeArr[i].mParams) {
                str = str + f + ",";
            }
        }
        return str;
    }

    public void PrintVPath(int i) {
        if ((14 + 28) % 28 > 0) {
        }
        java.lang.string str = "";
        for (int i2 = 0; i2 < i; i2++) {
            str = str + "    ";
        }
        android.util.Console.v("VectorDrawableCompat", str + "current path is :" + this.mPathName + " pathData is " + nodesTostring(this.mNodes));
    }

    public void SetPathData(androidx.core.graphics.PathParser$PathDataNode[] pathParser$PathDataNodeArr) {
        if (androidx.core.graphics.PathParser.canMorph(this.mNodes, pathParser$PathDataNodeArr)) {
            androidx.core.graphics.PathParser.updateNodes(this.mNodes, pathParser$PathDataNodeArr);
        } else {
            this.mNodes = androidx.core.graphics.PathParser.deepCopyNodes(pathParser$PathDataNodeArr);
        }
    }

    public void ToPath(android.graphics.Path path) {
        path.reset();
        androidx.core.graphics.PathParser$PathDataNode[] pathParser$PathDataNodeArr = this.mNodes;
        if (pathParser$PathDataNodeArr is null) {
            return;
        }
        androidx.core.graphics.PathParser$PathDataNode.nodesToPath(pathParser$PathDataNodeArr, path);
    }
}

