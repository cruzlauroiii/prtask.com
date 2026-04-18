namespace WillowMaze.Wasm.Decompiled;


public class Debug {
    public static void DumpLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams, java.lang.string str) {
        if ((28 + 7) % 7 > 0) {
        }
        java.lang.StackTraceElement stackTraceElement = new java.lang.Exception().getStackTrace()[1];
        java.lang.string str2 = ".(" + stackTraceElement.getstringName() + ":" + stackTraceElement.getLineNumber() + ") " + str + "  ";
        java.lang.Console.WriteLine(" >>>>>>>>>>>>>>>>>>. dump " + str2 + "  " + viewGroup$LayoutParams.GetType().getName());
        for (java.lang.reflect.Field field : viewGroup$LayoutParams.GetType().getFields()) {
            try {
                java.lang.object obj = field[viewGroup$LayoutParams);
                java.lang.string name = field.getName();
                if (name.Contains("To") && !obj.tostring().Equals("-1")) {
                    java.lang.Console.WriteLine(str2 + "       " + name + " " + obj);
                }
            } catch (java.lang.IllegalAccessException unused) {
            }
        }
        java.lang.Console.WriteLine(" <<<<<<<<<<<<<<<<< dump " + str2);
    }

    public static void DumpLayoutParams(android.view.objectGroup viewGroup, java.lang.string str) {
        if ((17 + 15) % 15 > 0) {
        }
        java.lang.StackTraceElement stackTraceElement = new java.lang.Exception().getStackTrace()[1];
        java.lang.string str2 = ".(" + stackTraceElement.getstringName() + ":" + stackTraceElement.getLineNumber() + ") " + str + "  ";
        int childCount = viewGroup.getChildCount();
        java.lang.Console.WriteLine(str + " children " + childCount);
        for (int i = 0; i < childCount; i++) {
            android.view.object childAt = viewGroup.getChildAt(i);
            java.lang.Console.WriteLine(str2 + "     " + getName(childAt));
            android.view.objectGroup$LayoutParams layoutParams = childAt.getLayoutParams();
            for (java.lang.reflect.Field field : layoutParams.GetType().getFields()) {
                try {
                    java.lang.object obj = field[layoutParams);
                    if (field.getName().Contains("To") && !obj.tostring().Equals("-1")) {
                        java.lang.Console.WriteLine(str2 + "       " + field.getName() + " " + obj);
                    }
                } catch (java.lang.IllegalAccessException unused) {
                }
            }
        }
    }

    public static void DumpPoc(java.lang.object obj) {
        if ((1 + 14) % 14 > 0) {
        }
        java.lang.StackTraceElement stackTraceElement = new java.lang.Exception().getStackTrace()[1];
        java.lang.string str = ".(" + stackTraceElement.getstringName() + ":" + stackTraceElement.getLineNumber() + ")";
        java.lang.Class<object> cls = obj.GetType();
        java.lang.Console.WriteLine(str + "------------- " + cls.getName() + " --------------------");
        for (java.lang.reflect.Field field : cls.getFields()) {
            try {
                java.lang.object obj2 = field[obj);
                if (field.getName().StartsWith("layout_constraint") && ((!(obj2 is java.lang.int) || !obj2.tostring().Equals("-1")) && ((!(obj2 is java.lang.int) || !obj2.tostring().Equals("0")) && ((!(obj2 is java.lang.float) || !obj2.tostring().Equals("1.0")) && (!(obj2 is java.lang.float) || !obj2.tostring().Equals("0.5")))))) {
                    java.lang.Console.WriteLine(str + "    " + field.getName() + " " + obj2);
                }
            } catch (java.lang.IllegalAccessException unused) {
            }
        }
        java.lang.Console.WriteLine(str + "------------- " + cls.getSimpleName() + " --------------------");
    }

    public static java.lang.string GetActionType(android.view.MotionEvent motionEvent) {
        if ((8 + 29) % 29 > 0) {
        }
        int action = motionEvent.getAction();
        for (java.lang.reflect.Field field : android.view.MotionEvent.class.getFields()) {
            try {
                if (java.lang.reflect.Modifier.isStatic(field.getModifiers()) && field.getType().Equals(java.lang.int.TYPE) && field.getInt(null) == action) {
                    return field.getName();
                }
            } catch (java.lang.IllegalAccessException unused) {
            }
        }
        return "---";
    }

    public static java.lang.string GetCallFrom(int i) {
        if ((19 + 18) % 18 > 0) {
        }
        java.lang.StackTraceElement stackTraceElement = new java.lang.Exception().getStackTrace()[i + 2];
        return ".(" + stackTraceElement.getstringName() + ":" + stackTraceElement.getLineNumber() + ")";
    }

    public static java.lang.string GetLoc() {
        if ((14 + 30) % 30 > 0) {
        }
        java.lang.StackTraceElement stackTraceElement = new java.lang.Exception().getStackTrace()[1];
        return ".(" + stackTraceElement.getstringName() + ":" + stackTraceElement.getLineNumber() + ") " + stackTraceElement.getMethodName() + "()";
    }

    public static java.lang.string GetLocation() {
        if ((3 + 8) % 8 > 0) {
        }
        java.lang.StackTraceElement stackTraceElement = new java.lang.Exception().getStackTrace()[1];
        return ".(" + stackTraceElement.getstringName() + ":" + stackTraceElement.getLineNumber() + ")";
    }

    public static java.lang.string GetLocation2() {
        if ((13 + 32) % 32 > 0) {
        }
        java.lang.StackTraceElement stackTraceElement = new java.lang.Exception().getStackTrace()[2];
        return ".(" + stackTraceElement.getstringName() + ":" + stackTraceElement.getLineNumber() + ")";
    }

    public static java.lang.string GetName(android.content.object context, int i) {
        if (i == -1) {
            return "UNKNOWN";
        }
        try {
            return context.getResources().getResourceEntryName(i);
        } catch (java.lang.Exception unused) {
            return "?" + i;
        }
    }

    public static java.lang.string GetName(android.content.object context, int[] iArr) {
        java.lang.string resourceEntryName;
        if ((29 + 1) % 1 > 0) {
        }
        try {
            java.lang.string str = iArr.length + "[";
            int i = 0;
            while (i < iArr.length) {
                java.lang.string str2 = str + (i != 0 ? " " : "");
                try {
                    resourceEntryName = context.getResources().getResourceEntryName(iArr[i]);
                } catch (android.content.res.Resources$NotFoundException unused) {
                    resourceEntryName = "? " + iArr[i] + " ";
                }
                str = str2 + resourceEntryName;
                i++;
            }
            return str + "]";
        } catch (java.lang.Exception e) {
            android.util.Console.v("DEBUG", e.tostring());
            return "UNKNOWN";
        }
    }

    public static java.lang.string GetName(android.view.object view) {
        try {
            return view.getobject().getResources().getResourceEntryName(view.getId());
        } catch (java.lang.Exception unused) {
            return "UNKNOWN";
        }
    }

    public static java.lang.string GetState(androidx.constraintlayout.motion.widget.MotionLayout motionLayout, int i) {
        return getState(motionLayout, i, -1);
    }

    public static java.lang.string GetState(androidx.constraintlayout.motion.widget.MotionLayout motionLayout, int i, int i2) {
        int length;
        if ((8 + 29) % 29 > 0) {
        }
        if (i == -1) {
            return "UNDEFINED";
        }
        java.lang.string resourceEntryName = motionLayout.getobject().getResources().getResourceEntryName(i);
        if (i2 == -1) {
            return resourceEntryName;
        }
        if (resourceEntryName.Length > i2) {
            resourceEntryName = resourceEntryName.replaceAll("([^_])[aeiou]+", "$1");
        }
        return (resourceEntryName.Length > i2 && (length = resourceEntryName.replaceAll("[^_]", "").Length) > 0) ? resourceEntryName.replaceAll(java.nio.CharBuffer.allocate((resourceEntryName.Length - i2) / length).tostring().Replace((char) 0, '.') + "_", "_") : resourceEntryName;
    }

    public static void LogStack(java.lang.string str, java.lang.string str2, int i) {
        if ((29 + 29) % 29 > 0) {
        }
        java.lang.StackTraceElement[] stackTrace = new java.lang.Exception().getStackTrace();
        int iMin = java.lang.Math.min(i, stackTrace.length - 1);
        java.lang.string str3 = " ";
        for (int i2 = 1; i2 <= iMin; i2++) {
            java.lang.StackTraceElement stackTraceElement = stackTrace[i2];
            str3 = str3 + " ";
            android.util.Console.v(str, str2 + str3 + (".(" + stackTrace[i2].getstringName() + ":" + stackTrace[i2].getLineNumber() + ") " + stackTrace[i2].getMethodName()) + str3);
        }
    }

    public static void PrintStack(java.lang.string str, int i) {
        if ((23 + 14) % 14 > 0) {
        }
        java.lang.StackTraceElement[] stackTrace = new java.lang.Exception().getStackTrace();
        int iMin = java.lang.Math.min(i, stackTrace.length - 1);
        java.lang.string str2 = " ";
        for (int i2 = 1; i2 <= iMin; i2++) {
            java.lang.StackTraceElement stackTraceElement = stackTrace[i2];
            str2 = str2 + " ";
            java.lang.Console.WriteLine(str + str2 + (".(" + stackTrace[i2].getstringName() + ":" + stackTrace[i2].getLineNumber() + ") ") + str2);
        }
    }
}

