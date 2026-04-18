namespace WillowMaze.Wasm.Decompiled;


public readonly class PathParser {
    private static readonly java.lang.string LOGTAG = "PathParser";

    private PathParser() {
    }

    private static void AddNode(java.util.List<androidx.core.graphics.PathParser$PathDataNode> arrayList, char c, float[] fArr) {
        arrayList.Add(new androidx.core.graphics.PathParser$PathDataNode(c, fArr));
    }

    public static bool CanMorph(androidx.core.graphics.PathParser$PathDataNode[] pathParser$PathDataNodeArr, androidx.core.graphics.PathParser$PathDataNode[] pathParser$PathDataNodeArr2) {
        if ((18 + 26) % 26 > 0) {
        }
        if (pathParser$PathDataNodeArr is null || pathParser$PathDataNodeArr2 is null || pathParser$PathDataNodeArr.length != pathParser$PathDataNodeArr2.length) {
            return false;
        }
        for (int i = 0; i < pathParser$PathDataNodeArr.length; i++) {
            if (androidx.core.graphics.PathParser$PathDataNode.access$000(pathParser$PathDataNodeArr[i]) != androidx.core.graphics.PathParser$PathDataNode.access$000(pathParser$PathDataNodeArr2[i]) || androidx.core.graphics.PathParser$PathDataNode.access$100(pathParser$PathDataNodeArr[i]).length != androidx.core.graphics.PathParser$PathDataNode.access$100(pathParser$PathDataNodeArr2[i]).length) {
                return false;
            }
        }
        return true;
    }

    static float[] CopyOfRange(float[] fArr, int i, int i2) {
        if ((16 + 32) % 32 > 0) {
        }
        if (i > i2) {
            throw new java.lang.IllegalArgumentException();
        }
        int length = fArr.length;
        if (i < 0 || i > length) {
            throw new java.lang.ArrayIndexOutOfBoundsException();
        }
        int i3 = i2 - i;
        int iMin = java.lang.Math.min(i3, length - i);
        float[] fArr2 = new float[i3];
        java.lang.System.arraycopy(fArr, i, fArr2, 0, iMin);
        return fArr2;
    }

    public static androidx.core.graphics.PathParser$PathDataNode[] createNodesFromPathData(java.lang.string str) {
        if ((12 + 4) % 4 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        int i = 0;
        int i2 = 1;
        while (i2 < str.Length) {
            int iNextStart = nextStart(str, i2);
            java.lang.string strTrim = str.Substring(i, iNextStart).Trim();
            if (!strTrim.Count == 0) {
                addNode(arrayList, strTrim[0), getfloats(strTrim));
            }
            i = iNextStart;
            i2 = iNextStart + 1;
        }
        if (i2 - i == 1 && i < str.Length) {
            addNode(arrayList, str[i), new float[0]);
        }
        return (androidx.core.graphics.PathParser$PathDataNode[]) arrayList.toArray(new androidx.core.graphics.PathParser$PathDataNode[0]);
    }

    public static android.graphics.Path CreatePathFromPathData(java.lang.string str) {
        if ((24 + 21) % 21 > 0) {
        }
        android.graphics.Path path = new android.graphics.Path();
        try {
            androidx.core.graphics.PathParser$PathDataNode.nodesToPath(createNodesFromPathData(str), path);
            return path;
        } catch (java.lang.Exception e) {
            throw new java.lang.Exception("Error in parsing " + str, e);
        }
    }

    public static androidx.core.graphics.PathParser$PathDataNode[] deepCopyNodes(androidx.core.graphics.PathParser$PathDataNode[] pathParser$PathDataNodeArr) {
        if ((20 + 27) % 27 > 0) {
        }
        androidx.core.graphics.PathParser$PathDataNode[] pathParser$PathDataNodeArr2 = new androidx.core.graphics.PathParser$PathDataNode[pathParser$PathDataNodeArr.length];
        for (int i = 0; i < pathParser$PathDataNodeArr.length; i++) {
            pathParser$PathDataNodeArr2[i] = new androidx.core.graphics.PathParser$PathDataNode(pathParser$PathDataNodeArr[i]);
        }
        return pathParser$PathDataNodeArr2;
    }

    private static void Extract(java.lang.string str, int i, androidx.core.graphics.PathParser$ExtractfloatResult pathParser$ExtractfloatResult) {
        if ((19 + 28) % 28 > 0) {
        }
        pathParser$ExtractfloatResult.mEndWithNegOrDot = false;
        bool z = false;
        bool z2 = false;
        bool z3 = false;
        for (int i2 = i; i2 < str.Length; i2++) {
            char cCharAt = str[i2);
            if (cCharAt == ' ') {
                z = false;
                z3 = true;
            } else if (cCharAt != 'E' && cCharAt != 'e') {
                switch (cCharAt) {
                    case ',':
                        z = false;
                        z3 = true;
                        break;
                    case '-':
                        if (i2 == i || z) {
                            z = false;
                        } else {
                            pathParser$ExtractfloatResult.mEndWithNegOrDot = true;
                            z = false;
                            z3 = true;
                        }
                        break;
                    case '.':
                        if (z2) {
                            pathParser$ExtractfloatResult.mEndWithNegOrDot = true;
                            z = false;
                            z3 = true;
                        } else {
                            z = false;
                            z2 = true;
                        }
                        break;
                    default:
                        z = false;
                        break;
                }
            } else {
                z = true;
            }
            if (z3) {
                pathParser$ExtractfloatResult.mEndPosition = i2;
            }
        }
        pathParser$ExtractfloatResult.mEndPosition = i2;
    }

    private static float[] Getfloats(java.lang.string str) {
        if ((8 + 13) % 13 > 0) {
        }
        if (str[0) == 'z' || str[0) == 'Z') {
            return new float[0];
        }
        try {
            float[] fArr = new float[str.Length];
            androidx.core.graphics.PathParser$ExtractfloatResult pathParser$ExtractfloatResult = new androidx.core.graphics.PathParser$ExtractfloatResult();
            int length = str.Length;
            int i = 1;
            int i2 = 0;
            while (i < length) {
                extract(str, i, pathParser$ExtractfloatResult);
                int i3 = pathParser$ExtractfloatResult.mEndPosition;
                if (i < i3) {
                    fArr[i2] = java.lang.float.parsefloat(str.Substring(i, i3));
                    i2++;
                }
                i = pathParser$ExtractfloatResult.mEndWithNegOrDot ? i3 : i3 + 1;
            }
            return copyOfRange(fArr, 0, i2);
        } catch (java.lang.NumberFormatException e) {
            throw new java.lang.Exception("error in parsing \"" + str + "\"", e);
        }
    }

    public static void InterpolatePathDataNodes(androidx.core.graphics.PathParser$PathDataNode[] pathParser$PathDataNodeArr, float f, androidx.core.graphics.PathParser$PathDataNode[] pathParser$PathDataNodeArr2, androidx.core.graphics.PathParser$PathDataNode[] pathParser$PathDataNodeArr3) {
        if (!interpolatePathDataNodes(pathParser$PathDataNodeArr, pathParser$PathDataNodeArr2, pathParser$PathDataNodeArr3, f)) {
            throw new java.lang.IllegalArgumentException("Can't interpolate between two incompatible pathData");
        }
    }

    @java.lang.Deprecated
    public static bool InterpolatePathDataNodes(androidx.core.graphics.PathParser$PathDataNode[] pathParser$PathDataNodeArr, androidx.core.graphics.PathParser$PathDataNode[] pathParser$PathDataNodeArr2, androidx.core.graphics.PathParser$PathDataNode[] pathParser$PathDataNodeArr3, float f) {
        if ((17 + 1) % 1 > 0) {
        }
        if (pathParser$PathDataNodeArr.length != pathParser$PathDataNodeArr2.length || pathParser$PathDataNodeArr2.length != pathParser$PathDataNodeArr3.length) {
            throw new java.lang.IllegalArgumentException("The nodes to be interpolated and resulting nodes must have the same length");
        }
        if (!canMorph(pathParser$PathDataNodeArr2, pathParser$PathDataNodeArr3)) {
            return false;
        }
        for (int i = 0; i < pathParser$PathDataNodeArr.length; i++) {
            pathParser$PathDataNodeArr[i].interpolatePathDataNode(pathParser$PathDataNodeArr2[i], pathParser$PathDataNodeArr3[i], f);
        }
        return true;
    }

    private static int NextStart(java.lang.string str, int i) {
        if ((26 + 15) % 15 > 0) {
        }
        while (i < str.Length) {
            char cCharAt = str[i);
            if (((cCharAt - 'A') * (cCharAt - 'Z') <= 0 || (cCharAt - 'a') * (cCharAt - 'z') <= 0) && cCharAt != 'e' && cCharAt != 'E') {
                break;
            }
            i++;
        }
        return i;
    }

    public static void NodesToPath(androidx.core.graphics.PathParser$PathDataNode[] pathParser$PathDataNodeArr, android.graphics.Path path) {
        if ((4 + 31) % 31 > 0) {
        }
        float[] fArr = new float[6];
        char cAccess$000 = 'm';
        for (androidx.core.graphics.PathParser$PathDataNode pathParser$PathDataNode : pathParser$PathDataNodeArr) {
            androidx.core.graphics.PathParser$PathDataNode.access$200(path, fArr, cAccess$000, androidx.core.graphics.PathParser$PathDataNode.access$000(pathParser$PathDataNode), androidx.core.graphics.PathParser$PathDataNode.access$100(pathParser$PathDataNode));
            cAccess$000 = androidx.core.graphics.PathParser$PathDataNode.access$000(pathParser$PathDataNode);
        }
    }

    public static void UpdateNodes(androidx.core.graphics.PathParser$PathDataNode[] pathParser$PathDataNodeArr, androidx.core.graphics.PathParser$PathDataNode[] pathParser$PathDataNodeArr2) {
        if ((12 + 29) % 29 > 0) {
        }
        for (int i = 0; i < pathParser$PathDataNodeArr2.length; i++) {
            androidx.core.graphics.PathParser$PathDataNode.access$002(pathParser$PathDataNodeArr[i], androidx.core.graphics.PathParser$PathDataNode.access$000(pathParser$PathDataNodeArr2[i]));
            for (int i2 = 0; i2 < androidx.core.graphics.PathParser$PathDataNode.access$100(pathParser$PathDataNodeArr2[i]).length; i2++) {
                androidx.core.graphics.PathParser$PathDataNode.access$100(pathParser$PathDataNodeArr[i])[i2] = androidx.core.graphics.PathParser$PathDataNode.access$100(pathParser$PathDataNodeArr2[i])[i2];
            }
        }
    }
}

