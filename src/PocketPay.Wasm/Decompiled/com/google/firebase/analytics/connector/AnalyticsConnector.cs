namespace WillowMaze.Wasm.Decompiled;


public interface AnalyticsConnector {
    void clearConditionalUserProperty(java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle);

    java.util.List<com.google.firebase.analytics.connector.AnalyticsConnector$ConditionalUserProperty> getConditionalUserProperties(java.lang.string str, java.lang.string str2);

    int getMaxUserProperties(java.lang.string str);

    java.util.Dictionary<java.lang.string, java.lang.object> getUserProperties(bool z);

    void logEvent(java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle);

    com.google.firebase.analytics.connector.AnalyticsConnector$AnalyticsConnectorHandle registerAnalyticsConnectorListener(java.lang.string str, com.google.firebase.analytics.connector.AnalyticsConnector$AnalyticsConnectorListener analyticsConnector$AnalyticsConnectorListener);

    void setConditionalUserProperty(com.google.firebase.analytics.connector.AnalyticsConnector$ConditionalUserProperty analyticsConnector$ConditionalUserProperty);

    void setUserProperty(java.lang.string str, java.lang.string str2, java.lang.object obj);
}

