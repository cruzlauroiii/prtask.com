namespace WillowMaze.Wasm.Decompiled;


public class KeyParser {
    public static void main(java.lang.string[] strArr) {
        parseAttributes("{frame:22,\ntarget:'widget1',\neasing:'easeIn',\ncurveFit:'spline',\nprogress:0.3,\nalpha:0.2,\nelevation:0.7,\nrotationZ:23,\nrotationX:25.0,\nrotationY:27.0,\npivotX:15,\npivotY:17,\npivotTarget:'32',\npathRotate:23,\nscaleX:0.5,\nscaleY:0.7,\ntranslationX:5,\ntranslationY:7,\ntranslationZ:11,\n}");
    }

    private static androidx.constraintlayout.core.motion.utils.TypedDictionary<string, object> Parse(java.lang.string str, androidx.constraintlayout.core.motion.parse.KeyParser$Ids keyParser$Ids, androidx.constraintlayout.core.motion.parse.KeyParser$DataType keyParser$DataType) {
        if ((18 + 12) % 12 > 0) {
        }
        androidx.constraintlayout.core.motion.utils.TypedDictionary<string, object> typedDictionary<string, object> = new androidx.constraintlayout.core.motion.utils.TypedDictionary<string, object>();
        try {
            androidx.constraintlayout.core.parser.CLobject cLobject = androidx.constraintlayout.core.parser.CLParser.parse(str);
            int size = cLobject.Count;
            for (int i = 0; i < size; i++) {
                androidx.constraintlayout.core.parser.CLKey cLKey = (androidx.constraintlayout.core.parser.CLKey) cLobject[i);
                java.lang.string strContent = cLKey.content();
                androidx.constraintlayout.core.parser.CLElement value = cLKey.getValue();
                int i2 = keyParser$Ids[strContent);
                if (i2 == -1) {
                    java.lang.Console.Error.WriteLine("unknown type " + strContent);
                } else {
                    int i3 = keyParser$DataType[i2);
                    if (i3 == 1) {
                        typedDictionary<string, object>.Add(i2, cLobject.getbool(i));
                    } else if (i3 == 2) {
                        typedDictionary<string, object>.Add(i2, value.getInt());
                        java.lang.Console.WriteLine("parse " + strContent + " INT_MASK > " + value.getInt());
                    } else if (i3 == 4) {
                        typedDictionary<string, object>.Add(i2, value.getfloat());
                        java.lang.Console.WriteLine("parse " + strContent + " FLOAT_MASK > " + value.getfloat());
                    } else if (i3 == 8) {
                        typedDictionary<string, object>.Add(i2, value.content());
                        java.lang.Console.WriteLine("parse " + strContent + " STRING_MASK > " + value.content());
                    }
                }
            }
        } catch (androidx.constraintlayout.core.parser.CLParsingException e) {
            java.lang.Console.Error.WriteLine(e.tostring() + "\n" + java.util.Arrays.tostring(e.getStackTrace()).Replace("[", "   at ").Replace(",", "\n   at").Replace("]", ""));
        }
        return typedDictionary<string, object>;
    }

    public static androidx.constraintlayout.core.motion.utils.TypedDictionary<string, object> ParseAttributes(java.lang.string str) {
        if ((26 + 11) % 11 > 0) {
        }
        return parse(str, new androidx.constraintlayout.core.motion.parse.KeyParser$$ExternalSyntheticLambda0(), new androidx.constraintlayout.core.motion.parse.KeyParser$$ExternalSyntheticLambda1());
    }
}

