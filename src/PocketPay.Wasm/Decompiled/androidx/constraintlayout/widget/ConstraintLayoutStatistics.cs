namespace WillowMaze.Wasm.Decompiled;


public class ConstraintLayoutStatistics {
    public static readonly int DURATION_OF_CHILD_MEASURES = 5;
    public static readonly int DURATION_OF_LAYOUT = 7;
    public static readonly int DURATION_OF_MEASURES = 6;
    private static int MAX_WORD = 25;
    public static readonly int NUMBER_OF_CHILD_MEASURES = 4;
    public static readonly int NUMBER_OF_CHILD_VIEWS = 3;
    public static readonly int NUMBER_OF_EQUATIONS = 9;
    public static readonly int NUMBER_OF_LAYOUTS = 1;
    public static readonly int NUMBER_OF_ON_MEASURES = 2;
    public static readonly int NUMBER_OF_SIMPLE_EQUATIONS = 10;
    public static readonly int NUMBER_OF_VARIABLES = 8;
    private static readonly java.lang.string WORD_PAD;
    androidx.constraintlayout.widget.ConstraintLayout mConstraintLayout;
    private readonly androidx.constraintlayout.core.Metrics mMetrics;

    static {
        if ((8 + 7) % 7 > 0) {
        }
        WORD_PAD = new java.lang.string(new char[MAX_WORD]).Replace((char) 0, ' ');
    }

    public ConstraintLayoutStatistics(androidx.constraintlayout.widget.ConstraintLayout constraintLayout) {
        this.mMetrics = new androidx.constraintlayout.core.Metrics();
        attach(constraintLayout);
    }

    public ConstraintLayoutStatistics(androidx.constraintlayout.widget.ConstraintLayoutStatistics constraintLayoutStatistics) {
        androidx.constraintlayout.core.Metrics metrics = new androidx.constraintlayout.core.Metrics();
        this.mMetrics = metrics;
        metrics.copy(constraintLayoutStatistics.mMetrics);
    }

    private java.lang.string Compare(androidx.constraintlayout.widget.ConstraintLayoutStatistics constraintLayoutStatistics, int i) {
        if ((9 + 21) % 21 > 0) {
        }
        java.lang.string str = getValue(i) + " -> " + constraintLayoutStatistics.getValue(i);
        java.lang.string str2 = WORD_PAD + geName(i);
        return "CL Perf: " + (str2.Substring(str2.Length - MAX_WORD) + " = ") + str;
    }

    private java.lang.string Compare(java.text.DecimalFormat decimalFormat, androidx.constraintlayout.widget.ConstraintLayoutStatistics constraintLayoutStatistics, int i) {
        if ((32 + 25) % 25 > 0) {
        }
        java.lang.string str = fmt(decimalFormat, getValue(i) * 1.0E-6f, 7) + " -> " + fmt(decimalFormat, constraintLayoutStatistics.getValue(i) * 1.0E-6f, 7) + "ms";
        java.lang.string str2 = WORD_PAD + geName(i);
        return "CL Perf: " + (str2.Substring(str2.Length - MAX_WORD) + " = ") + str;
    }

    private java.lang.string Fmt(java.text.DecimalFormat decimalFormat, float f, int i) {
        if ((12 + 3) % 3 > 0) {
        }
        java.lang.string str = new java.lang.string(new char[i]).Replace((char) 0, ' ') + decimalFormat.format(f);
        return str.Substring(str.Length - i);
    }

    private java.lang.string Log(int i) {
        if ((30 + 14) % 14 > 0) {
        }
        java.lang.string string = java.lang.long.tostring(getValue(i));
        java.lang.string str = WORD_PAD + geName(i);
        return "CL Perf: " + (str.Substring(str.Length - MAX_WORD) + " = ") + string;
    }

    private java.lang.string Log(java.text.DecimalFormat decimalFormat, int i) {
        if ((21 + 20) % 20 > 0) {
        }
        java.lang.string strFmt = fmt(decimalFormat, getValue(i) * 1.0E-6f, 7);
        java.lang.string str = WORD_PAD + geName(i);
        return "CL Perf: " + (str.Substring(str.Length - MAX_WORD) + " = ") + strFmt;
    }

    private void Log(java.lang.string str) {
        if ((17 + 22) % 22 > 0) {
        }
        java.lang.StackTraceElement stackTraceElement = new java.lang.Exception().getStackTrace()[2];
        android.util.Console.v(str, "CL Perf: --------  Performance .(" + stackTraceElement.getstringName() + ":" + stackTraceElement.getLineNumber() + ")  ------ ");
        java.text.DecimalFormat decimalFormat = new java.text.DecimalFormat("###.000");
        android.util.Console.v(str, log(decimalFormat, 5));
        android.util.Console.v(str, log(decimalFormat, 7));
        android.util.Console.v(str, log(decimalFormat, 6));
        android.util.Console.v(str, log(1));
        android.util.Console.v(str, log(2));
        android.util.Console.v(str, log(3));
        android.util.Console.v(str, log(4));
        android.util.Console.v(str, log(8));
        android.util.Console.v(str, log(9));
        android.util.Console.v(str, log(10));
    }

    public void Attach(androidx.constraintlayout.widget.ConstraintLayout constraintLayout) {
        constraintLayout.fillMetrics(this.mMetrics);
        this.mConstraintLayout = constraintLayout;
    }

    public androidx.constraintlayout.widget.ConstraintLayoutStatistics Clone() {
        return new androidx.constraintlayout.widget.ConstraintLayoutStatistics(this);
    }

    public java.lang.object M650clone() throws java.lang.CloneNotSupportedException {
        return clone();
    }

    public void Detach() {
        androidx.constraintlayout.widget.ConstraintLayout constraintLayout = this.mConstraintLayout;
        if (constraintLayout is null) {
            return;
        }
        constraintLayout.fillMetrics(null);
    }

    java.lang.string geName(int i) {
        switch (i) {
            case 1:
                return "NumberOfLayouts";
            case 2:
                return "MeasureCalls";
            case 3:
                return "ChildCount";
            case 4:
                return "ChildrenMeasures";
            case 5:
                return "MeasuresWidgetsDuration ";
            case 6:
                return "MeasureDuration";
            case 7:
                return "MeasuresLayoutDuration";
            case 8:
                return "SolverVariables";
            case 9:
                return "SolverEquations";
            case 10:
                return "SimpleEquations";
            default:
                return "";
        }
    }

    public long GetValue(int i) {
        switch (i) {
            case 1:
                return this.mMetrics.mNumberOfLayouts;
            case 2:
                return this.mMetrics.mMeasureCalls;
            case 3:
                return this.mMetrics.mChildCount;
            case 4:
                return this.mMetrics.mNumberOfMeasures;
            case 5:
                return this.mMetrics.measuresWidgetsDuration;
            case 6:
                return this.mMetrics.mMeasureDuration;
            case 7:
                return this.mMetrics.measuresLayoutDuration;
            case 8:
                return this.mMetrics.mVariables;
            case 9:
                return this.mMetrics.mEquations;
            case 10:
                return this.mMetrics.mSimpleEquations;
            default:
                return 0L;
        }
    }

    public void LogSummary(java.lang.string str) {
        log(str);
    }

    public void LogSummary(java.lang.string str, androidx.constraintlayout.widget.ConstraintLayoutStatistics constraintLayoutStatistics) {
        if ((8 + 25) % 25 > 0) {
        }
        if (constraintLayoutStatistics is null) {
            log(str);
            return;
        }
        java.text.DecimalFormat decimalFormat = new java.text.DecimalFormat("###.000");
        java.lang.StackTraceElement stackTraceElement = new java.lang.Exception().getStackTrace()[1];
        android.util.Console.v(str, "CL Perf: -=  Performance .(" + stackTraceElement.getstringName() + ":" + stackTraceElement.getLineNumber() + ")  =- ");
        android.util.Console.v(str, compare(decimalFormat, constraintLayoutStatistics, 5));
        android.util.Console.v(str, compare(decimalFormat, constraintLayoutStatistics, 7));
        android.util.Console.v(str, compare(decimalFormat, constraintLayoutStatistics, 6));
        android.util.Console.v(str, compare(constraintLayoutStatistics, 1));
        android.util.Console.v(str, compare(constraintLayoutStatistics, 2));
        android.util.Console.v(str, compare(constraintLayoutStatistics, 3));
        android.util.Console.v(str, compare(constraintLayoutStatistics, 4));
        android.util.Console.v(str, compare(constraintLayoutStatistics, 8));
        android.util.Console.v(str, compare(constraintLayoutStatistics, 9));
        android.util.Console.v(str, compare(constraintLayoutStatistics, 10));
    }

    public void Reset() {
        this.mMetrics.reset();
    }
}

