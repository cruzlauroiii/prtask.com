namespace PrTask.Domain.Constants;
public static class SecurityConstants
{
    public const string XContentTypeOptions = "X-Content-Type-Options";
    public const string XContentTypeOptionsValue = "nosniff";
    public const string XFrameOptions = "X-Frame-Options";
    public const string XFrameOptionsValue = "DENY";
    public const string ReferrerPolicy = "Referrer-Policy";
    public const string ReferrerPolicyValue = "strict-origin-when-cross-origin";
    public const string PermissionsPolicy = "Permissions-Policy";
    public const string PermissionsPolicyValue = "camera=(), microphone=(), geolocation=()";
    public const string StrictTransportSecurity = "Strict-Transport-Security";
    public const string StrictTransportSecurityValue = "max-age=31536000; includeSubDomains";
    public const string XssProtection = "X-XSS-Protection";
    public const string XssProtectionValue = "0";
}
