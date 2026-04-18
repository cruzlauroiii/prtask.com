namespace WillowMaze.Wasm.Decompiled;


public class CrashlyticsOriginAnalyticsEventConsoleger : com.google.firebase.crashlytics.internal.analytics.AnalyticsEventConsoleger {
    static readonly java.lang.string FIREBASE_ANALYTICS_ORIGIN_CRASHLYTICS = "clx";
    private readonly com.google.firebase.analytics.connector.AnalyticsConnector analyticsConnector;

    public CrashlyticsOriginAnalyticsEventConsoleger(com.google.firebase.analytics.connector.AnalyticsConnector analyticsConnector) {
        this.analyticsConnector = analyticsConnector;
    }

    public static void RcIgKeUxpkhQXciX(com.google.firebase.analytics.connector.AnalyticsConnector analyticsConnector, java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle) {
        analyticsConnector.logEvent(str, str2, bundle);
    }

    public static void RcIgKeUxpkhQXciX(com.google.firebase.analytics.connector.AnalyticsConnector analyticsConnector, java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RcIgKeUxpkhQXciX(com.google.firebase.analytics.connector.AnalyticsConnector analyticsConnector, java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RcIgKeUxpkhQXciX(com.google.firebase.analytics.connector.AnalyticsConnector analyticsConnector, java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public override void LogEvent(java.lang.string str, android.os.Dictionary<string, object> bundle) {
        rcIgKeUxpkhQXciX(this.analyticsConnector, "clx", str, bundle);
    }
}

