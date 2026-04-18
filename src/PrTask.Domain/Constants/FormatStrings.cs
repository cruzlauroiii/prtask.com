namespace PrTask.Domain.Constants;
public static class FormatStrings
{
    public static string BountyAmount(long AmountCents) => string.Format(AppConstants.BountyDisplayFormat, AmountCents / AppConstants.CentsToDollarsDivisor);
    public static string BountyHint(long MinCents) => string.Format(CreateTaskConstants.BountyHintFormat, MinCents / AppConstants.CentsToDollarsDivisor);
    public static string TruncateText(string Text, int MaxLength) => Text.Length <= MaxLength ? Text : $"{Text[..MaxLength]}...";
    public static string BuyerEmail(string PayerId) => $"{PayerId}@{AppConstants.AppDomain}";
    public static string TaskBountyName(string TaskId) => $"Task Bounty: {TaskId}";
    public static string PaymentSuccessRedirect(string TaskId) => $"https://{AppConstants.AppDomain}/dashboard?payment=success&task={TaskId}";
    public static string PaymentFailureRedirect(string TaskId) => $"https://{AppConstants.AppDomain}/dashboard?payment=failed&task={TaskId}";
    public static string PaymentCancelRedirect(string TaskId) => $"https://{AppConstants.AppDomain}/dashboard?payment=cancelled&task={TaskId}";
    public static string PaymentReferenceNumber(string TaskId) => $"PRTASK-{TaskId}-{DateTime.UtcNow:yyyyMMddHHmmss}";
    public static string BasicAuthPayload(string Key) => $"{Key}:";
    public static string BasicAuthPayload(string ClientId, string ClientSecret) => $"{ClientId}:{ClientSecret}";
    public static string OidcKey(string Provider, string SubjectId) => $"{Provider}:{SubjectId}";
    public static string DiffHeader(string FileA, string FileB) => $"diff --git a/{FileA} b/{FileB}";
    public static string DiffPrefixLine(string Prefix, string FileName) => $"{Prefix} {FileName}";
    public static string RedactedLine(char LinePrefix) => $"{LinePrefix}{DiffConstants.RedactedMarker}";
    public static string AppOrigin() => $"https://{AppConstants.AppDomain}";
    public static string CallbackRedirect(string CallbackRoute) => $"https://{AppConstants.AppDomain}{CallbackRoute}";
    public static string CallbackRedirect(string BaseUrl, string CallbackRoute) => $"{BaseUrl}{CallbackRoute}";
    public static string LoginErrorRedirect(string ErrorCode) => $"{RouteConstants.Login}?error={ErrorCode}";
    public static string LoginAutoFailedRedirect() => $"{RouteConstants.Login}?auto_failed=true";
    public static string PkceCookieName(string Provider) => $"{OAuthConstants.PkceCookiePrefix}{Provider}";
    public static string GitHubAuthRedirect(string ClientId, string RedirectUri, string Scope) =>
        $"{GitHubConstants.AuthorizeUrl}?{OAuthConstants.ParamClientId}={ClientId}&{OAuthConstants.ParamRedirectUri}={Uri.EscapeDataString(RedirectUri)}&{OAuthConstants.ParamScope}={Uri.EscapeDataString(Scope)}";
    public static string OidcAuthRedirect(string AuthorizeBase, string ClientId, string RedirectUri, string Scope, string Challenge) =>
        $"{AuthorizeBase}?{OAuthConstants.ParamClientId}={ClientId}&{OAuthConstants.ParamRedirectUri}={Uri.EscapeDataString(RedirectUri)}" +
        $"&{OAuthConstants.ParamResponseType}={OAuthConstants.ResponseTypeCode}&{OAuthConstants.ParamScope}={Uri.EscapeDataString(Scope)}" +
        $"&{OAuthConstants.ParamCodeChallenge}={Challenge}&{OAuthConstants.ParamCodeChallengeMethod}={OAuthConstants.ChallengeMethodS256}";
    public static string OidcAuthRedirectSilent(string Base) => $"{Base}&{OAuthConstants.ParamPrompt}={OAuthConstants.PromptNone}";
    public static string AzureAuthorizeEndpoint() =>
        $"https://login.microsoftonline.com/{AzureConstants.CommonTenant}/oauth2/v2.0/authorize";
    public static string AzureTokenEndpoint() =>
        $"https://login.microsoftonline.com/{AzureConstants.CommonTenant}/oauth2/v2.0/token";
    public static string OktaAuthorizePath(string Domain) => $"{Domain}{OktaConstants.AuthorizePathTemplate}";
    public static string OktaTokenPath(string Domain) => $"{Domain}{OktaConstants.TokenPathTemplate}";
    public static string OktaUserInfoPath(string Domain) => $"{Domain}{OktaConstants.UserInfoPathTemplate}";
    public static string ApiResourcePath(string BasePath, string Id) => $"{BasePath}/{Id}";
    public static string OwnerPath(string BasePath, string OwnerId) => $"{BasePath}/owner/{OwnerId}";
    public static string ColumnPath(string BasePath, string BoardId) => $"{BasePath}/{BoardId}/columns";
    public static string ColumnItemPath(string BasePath, string BoardId, string ColumnId) => $"{BasePath}/{BoardId}/columns/{ColumnId}";
    public static string LeaderboardUserPath() => $"{RouteConstants.ApiLeaderboard}{RouteConstants.SubLeaderboardUser}";
    public static string PaymentStatusPath() => $"{RouteConstants.ApiPaymentsStatus}{RouteConstants.SubPaymentStatus}";
    public static string MayaCheckoutPath(string CheckoutId) => $"{MayaConstants.CheckoutEndpoint}/{CheckoutId}";
    public static string MayaPaymentPath(string PaymentId) => $"{MayaConstants.PaymentEndpoint}/{PaymentId}";
    public static string MayaPaymentRrnPath(string Rrn) => $"{MayaConstants.PaymentByRrnEndpoint}/{Rrn}";
    public static string MayaPaymentVoidsPath(string PaymentId) => $"{MayaConstants.PaymentEndpoint}/{PaymentId}/voids";
    public static string MayaPaymentVoidPath(string PaymentId, string VoidId) => $"{MayaConstants.PaymentEndpoint}/{PaymentId}/voids/{VoidId}";
    public static string MayaPaymentRefundsPath(string PaymentId) => $"{MayaConstants.PaymentEndpoint}/{PaymentId}/refunds";
    public static string MayaPaymentRefundPath(string PaymentId, string RefundId) => $"{MayaConstants.PaymentEndpoint}/{PaymentId}/refunds/{RefundId}";
    public static string MayaCustomerPath(string CustomerId) => $"{MayaConstants.CustomerEndpoint}/{CustomerId}";
    public static string MayaCustomerCardsPath(string CustomerId) => $"{MayaConstants.CustomerEndpoint}/{CustomerId}/cards";
    public static string MayaCustomerCardPath(string CustomerId, string CardToken) => $"{MayaConstants.CustomerEndpoint}/{CustomerId}/cards/{CardToken}";
    public static string MayaCustomerCardPaymentsPath(string CustomerId, string CardToken) => $"{MayaConstants.CustomerEndpoint}/{CustomerId}/cards/{CardToken}/payments";
    public static string MayaWebhookPath(string WebhookId) => $"{MayaConstants.WebhookEndpoint}/{WebhookId}";
    public static string ThreeDsCallbackNote(string Status) => $"3DS callback: {Status}";
    public static string MayaVoidReference(string PaymentId) => $"VOID-{PaymentId}-{DateTime.UtcNow:yyyyMMddHHmmss}";
    public static string MayaRefundReference(string PaymentId) => $"REFUND-{PaymentId}-{DateTime.UtcNow:yyyyMMddHHmmss}";
    public static string MayaSubscriptionPath(string SubscriptionId) => $"{MayaConstants.SubscriptionEndpoint}/{SubscriptionId}";
    public static string MayaSubscriptionPaymentsPath(string SubscriptionId) => $"{MayaConstants.SubscriptionEndpoint}/{SubscriptionId}/payments";
    public static string MayaInvoicePath(string InvoiceId) => $"{MayaConstants.InvoiceEndpoint}/{InvoiceId}";
    public static string MayaDisbursementPath(string DisbursementId) => $"{MayaConstants.DisbursementsEndpoint}/{DisbursementId}";
    public static string MayaDisbursementProcessPath(string DisbursementId) => $"{MayaConstants.DisbursementsEndpoint}/{DisbursementId}/process";
    public static string MayaQrPaymentPath(string PaymentId) => $"{MayaConstants.QrPaymentEndpoint}/{PaymentId}";
    public static string MayaQrPaymentExecutePath(string PaymentId) => $"{MayaConstants.QrPaymentEndpoint}/{PaymentId}/execute";
    public static string MayaWalletLinkPath(string LinkId) => $"{MayaConstants.WalletLinkEndpoint}/{LinkId}";
    public static string MayaWalletLinkPaymentsPath(string LinkId) => $"{MayaConstants.WalletLinkEndpoint}/{LinkId}/payments";
    public static string MayaStaticQrPaymentPath(string P2mId) => $"{MayaConstants.StaticQrEndpoint}/{P2mId}/payments";
    public static string MayaP3TransactionPath(string RefNo) => $"{MayaConstants.P3TransactionsEndpoint}/{RefNo}";
    public static string MayaP3BinPath(string Bin) => $"{MayaConstants.P3BinsEndpoint}/{Bin}";
    public static string MayaP3KeyPath(string KeyId) => $"{MayaConstants.P3KeysEndpoint}/{KeyId}";
    public static string MayaRemittancePath(string TransactionReferenceNumber) => $"{MayaConstants.RemittanceEndpoint}/{TransactionReferenceNumber}";
    public static string MayaRemittanceExecutePath(string TransactionReferenceNumber) => $"{MayaConstants.RemittanceEndpoint}/{TransactionReferenceNumber}/execute";
    public static string MayaBillerPath(string Slug) => $"{MayaConstants.BillersEndpoint}/{Slug}";
    public static string MayaBillPaymentPath(string BillPaymentId) => $"{MayaConstants.BillPaymentEndpoint}/{BillPaymentId}";
    public static string MayaBillPaymentExecutePath(string BillPaymentId) => $"{MayaConstants.BillPaymentEndpoint}/{BillPaymentId}/execute";
    public static string MayaBillPaymentStatusPath(string BillPaymentId) => $"{MayaConstants.BillPaymentEndpoint}/{BillPaymentId}/status";
    public static string MayaPaymentCancelPath(string PaymentId) => $"{MayaConstants.PaymentEndpoint}/{PaymentId}/cancel";
    public static string MayaPaymentStatusLightPath(string PaymentId) => $"{MayaConstants.PaymentEndpoint}/{PaymentId}/status";
    public static string MayaPaymentCapturePath(string PaymentId) => $"{MayaConstants.PaymentEndpoint}/{PaymentId}/capture";
    public static string MayaCancelReference(string PaymentId) => $"CANCEL-{PaymentId}-{DateTime.UtcNow:yyyyMMddHHmmss}";
    public static string CollectionFilePath(string BasePath, string Collection) => $"{BasePath}/{Collection}{DbConstants.JsonExtension}";
    public static string SyncChangeKey(string EntityType, string EntityId) => $"{EntityType}:{EntityId}";
    public static string WssTokenQuery(string Token) => $"{WssConstants.TokenQueryParam}={Uri.EscapeDataString(Token)}";
    public static string WssTokenQueryAppend(string ExistingQuery, string Token) => $"{ExistingQuery}&{WssConstants.TokenQueryParam}={Uri.EscapeDataString(Token)}";
    public static string SqliteConnectionString(string DbPath) => $"{DbConstants.DataSourcePrefix}{DbPath}";
    public static string MauiAuthCallbackRedirect(string SessionId, string Username) =>
        $"{MauiConstants.AuthCallbackScheme}?{MauiConstants.AuthSessionKey}={Uri.EscapeDataString(SessionId)}&{MauiConstants.AuthUsernameKey}={Uri.EscapeDataString(Username)}";
    public static string MauiDbInitError(string Message) => $"[PrTask] DB init failed: {Message}";
    public static string MauiDbRetryError(string Message) => $"[PrTask] DB retry failed: {Message}";
    public static string MauiStartupError(string Message) => $"[PrTask] Startup failed: {Message}";
    public static string MauiKestrelError(string Message) => $"[PrTask] Kestrel failed: {Message}";
    public static string MauiServerNotificationText(string Url) => $"{MauiConstants.NotificationServerPrefix}{Url}";
    public static string HttpListenerPrefix(int Port) => string.Format(MauiConstants.HttpListenerPrefixFormat, Port);
    public static string HttpServerAddress(int Port) => string.Format(MauiConstants.HttpServerUrlFormat, Port);
    public static string MayaConnectAuthorizeRedirect(string BaseUrl, string ClientId, string RedirectUri, string Scope, string State) =>
        $"{BaseUrl}{MayaConstants.ConnectAuthorizePath}?{OAuthConstants.ParamClientId}={ClientId}" +
        $"&{OAuthConstants.ParamRedirectUri}={Uri.EscapeDataString(RedirectUri)}" +
        $"&{OAuthConstants.ParamResponseType}={OAuthConstants.ResponseTypeCode}" +
        $"&{OAuthConstants.ParamScope}={Uri.EscapeDataString(Scope)}&state={State}";
    public static string MayaConnectTokenBody(string GrantType, string Code, string RedirectUri) =>
        $"{OAuthConstants.ParamGrantType}={GrantType}&{OAuthConstants.ParamCode}={Code}&{OAuthConstants.ParamRedirectUri}={Uri.EscapeDataString(RedirectUri)}";
    public static string MayaConnectRefreshBody(string RefreshToken) =>
        $"{OAuthConstants.ParamGrantType}={MayaConstants.GrantTypeRefreshToken}&{MayaConstants.ConnectRefreshTokenProperty}={RefreshToken}";
    public static string MayaPaymentV2Path(string PaymentId) => $"{MayaConstants.PaymentV2Endpoint}/{PaymentId}";
    public static string MayaSubscriptionListPath(string CustomerId, string CardTokenId) =>
        $"{MayaConstants.CustomerEndpoint}/{CustomerId}/cards/{CardTokenId}/subscriptions";
    public static string SubscriptionInterval(int Count, string Interval) =>
        string.Format(SettingsConstants.SubscriptionIntervalFormat, Count, Interval);
    public static string CommentLocation(int LineNumber, string FilePath) =>
        string.Format(PrDetailConstants.CommentLocationFormat, LineNumber, FilePath);
    public static string DiffStats(int FilesChanged, int Additions, int Deletions) =>
        string.Format(PrDetailConstants.DiffStatsFormat, FilesChanged, Additions, Deletions);
    public static string AppendLinkedProvider(string Existing, string Provider) => $"{Existing}{SsoConstants.ProviderSeparator}{Provider}";
    public static string DeployPreviewAddress(string DeploymentId) =>
        string.Format(DeploymentConstants.PreviewUrlFormat, DeploymentId, AppConstants.CloudflarePagesProject);
    public static string DeployLogLine(string Message) =>
        $"[{DateTime.UtcNow.ToString(DeploymentConstants.LogTimeFormat)}] {Message}";
    public static string DeployLogComplete(string PreviewUrl) =>
        $"[{DateTime.UtcNow.ToString(DeploymentConstants.LogTimeFormat)}] Deploy complete \u2014 preview live at {PreviewUrl}";
    public static string P3TransactionsQuery(string? MerchantId, int? Page, int? Size)
    {
        var Query = new System.Text.StringBuilder(MayaConstants.P3TransactionsEndpoint);
        var Sep = '?';
        if (!string.IsNullOrEmpty(MerchantId)) { Query.Append(Sep).Append("merchantId=").Append(MerchantId); Sep = '&'; }
        if (Page.HasValue) { Query.Append(Sep).Append("page=").Append(Page.Value); Sep = '&'; }
        if (Size.HasValue) { Query.Append(Sep).Append("size=").Append(Size.Value); }
        return Query.ToString();
    }
    public static string PaymentCustomerPath(string CustomerId) => $"{RouteConstants.ApiPayments}/customers/{CustomerId}";
    public static string PaymentCustomerCardPath(string CustomerId, string CardToken) => $"{RouteConstants.ApiPayments}/customers/{CustomerId}/cards/{CardToken}";
    public static string PaymentWebhookPath(string WebhookId) => $"{RouteConstants.ApiPayments}/webhooks/{WebhookId}";
    public static string TaskCount(int Count) => string.Format(TaskListConstants.TaskCountFormat, Count);
    public static string WssSubscriptionMessage(string Channel) => $"{{\"type\":\"{WssConstants.MessageTypeSubscription}\",\"channel\":\"{Channel}\"}}";
    public static string WssCatchupRequestMessage(string RequestId, long SinceTimestamp) => $"{{\"type\":\"{WssConstants.MessageTypeCatchupRequest}\",\"id\":\"{RequestId}\",\"since\":{SinceTimestamp}}}";
    public static string SnapshotEndpoint(string BaseUrl) => $"{BaseUrl}{WssConstants.SnapshotEndpointPath}";
    public static string AutomergePath(string Collection) => $"{WssConstants.AutomergePathPrefix}{Collection}{WssConstants.AutomergePathSuffix}";
}
