     1→# PrTask — Rules Part 4: Infrastructure & Platform (Rules 491–648)
     2→
     3→491. HowItWorks uses HowItWorksConstants for all UI text â€” page heading, step headings/descriptions, client steps, workflow guide headings/descriptions/link text/status badges reference HowItWorksConstants. Zero hardcoded UI strings.
     4→
     5→492. DeploymentPreviewConstants â€” SeoTitle, SeoDescription, PageHeading, PageDescription, BuildStatusHeading, DeploymentPrefix, PreviewUrlHeading/Description, OpenLivePreviewText, DetailsHeading, BranchLabel, EnvironmentLabel/Value, PlatformLabel/Value, FilesChangedLabel, AdditionsDeletionsLabel, PrStatusLabel, DeployLogHeading constants for DeploymentPreviewPage.
     6→
     7→493. DeploymentPreviewPage uses DeploymentPreviewConstants for all display text â€” headings, descriptions, labels, button text reference DeploymentPreviewConstants. Combined with DeploymentConstants for status/log data. Zero hardcoded UI strings.
     8→
     9→494. TaskListConstants has UI text â€” SeoTitle, SeoDescription, PageHeading, PageDescription, AllComplexitiesLabel, NewestFirstLabel, HighestBountyLabel, ComplexityLabel, LoadingText, EmptyStateText, ViewTaskButtonText in addition to existing filter/sort/search constants.
    10→
    11→495. TaskList uses TaskListConstants for all UI text â€” headings, descriptions, filter labels, sort labels, loading/empty states, button text, SeoHead reference TaskListConstants. Zero hardcoded UI strings.
    12→
    13→496. TaskList filter options use TaskListConstants label constants â€” AllComplexitiesLabel, NewestFirstLabel, HighestBountyLabel, ComplexityLabel replace hardcoded option display text. Option values still use existing SortByNewest/SortByBounty/SortByComplexity/FilterAll.
    14→
    15→497. TaskList SeoHead uses TaskListConstants â€” SeoTitle and SeoDescription constants for meta tags instead of hardcoded strings.
    16→
    17→498. TermsConstants â€” SeoTitle, SeoDescription, PageHeading, LastUpdated, and paired Heading/Text constants for all 20 sections of Terms of Service page.
    18→
    19→499. TermsPage uses TermsConstants for all UI text â€” headings, descriptions, section content reference TermsConstants. Zero hardcoded UI strings.
    20→
    21→500. PrivacyConstants â€” SeoTitle, PageHeading, GdprHeading, CcpaHeading, DataBreachHeading, and paired Heading/Text constants for all Privacy Policy sections.
    22→
    23→501. PrivacyPage uses PrivacyConstants for all UI text â€” headings, descriptions, section content reference PrivacyConstants. Zero hardcoded UI strings.
    24→
    25→502. CookiePolicyConstants â€” SeoTitle, PageHeading, EssentialCookiesHeading, CookieTableHeaderName, and paired Heading/Text constants for all Cookie Policy sections.
    26→
    27→503. CookiePolicyPage uses CookiePolicyConstants for all UI text â€” headings, descriptions, cookie table content reference CookiePolicyConstants. Zero hardcoded UI strings.
    28→
    29→504. AcceptableUseConstants â€” SeoTitle, PageHeading, ProhibitedActivitiesHeading, EnforcementHeading, and paired Heading/Text constants for all Acceptable Use Policy sections.
    30→
    31→505. AcceptableUsePage uses AcceptableUseConstants for all UI text â€” headings, descriptions, section content reference AcceptableUseConstants. Zero hardcoded UI strings.
    32→
    33→506. RefundConstants â€” SeoTitle, PageHeading, AutomaticPaymentModelHeading, ChargebackPolicyHeading, and paired Heading/Text constants for all Refund Policy sections.
    34→
    35→507. RefundPage uses RefundConstants for all UI text â€” headings, descriptions, section content reference RefundConstants. Zero hardcoded UI strings.
    36→
    37→508. LicensesConstants â€” SeoTitle, PageHeading, PlatformLicenseHeading, PciDssHeading, and paired Heading/Text constants for all Licenses page sections.
    38→
    39→509. LicensesPage uses LicensesConstants for all UI text â€” headings, descriptions, section content reference LicensesConstants. Zero hardcoded UI strings.
    40→
    41→510. AccessibilityConstants â€” SeoTitle, PageHeading, WcagConformanceHeading, MeasuresHeading, and paired Heading/Text constants for all Accessibility page sections.
    42→
    43→511. AccessibilityPage uses AccessibilityConstants for all UI text â€” headings, descriptions, section content reference AccessibilityConstants. Zero hardcoded UI strings.
    44→
    45→512. DmcaConstants â€” SeoTitle, PageHeading, FilingNoticeHeading, CounterNotificationHeading, and paired Heading/Text constants for all DMCA page sections.
    46→
    47→513. DmcaPage uses DmcaConstants for all UI text â€” headings, descriptions, section content reference DmcaConstants. Zero hardcoded UI strings.
    48→
    49→514. CreateTaskConstants has BountyHintFormat â€” format string constant for bounty hint display text on CreateTask page.
    50→
    51→515. CreateTaskPage uses FormatStrings.BountyHint â€” bounty hint display text rendered via FormatStrings helper instead of inline string interpolation.
    52→
    53→516. TaskListConstants has TaskCountFormat â€” format string constant for displaying task count on TaskList page.
    54→
    55→517. FormatStrings has TaskCount and BountyHint methods â€” static helper methods that format display strings using constants from TaskListConstants and CreateTaskConstants.
    56→
    57→518. MauiConstants â€” RouteNotFound, SomethingWentWrong, Reload constants for MAUI Routes.razor error and fallback text.
    58→
    59→519. MauiLoginPage uses LoginConstants for all UI text â€” headings, descriptions, SSO button labels reference LoginConstants. Zero hardcoded UI strings.
    60→
    61→520. Routes.razor uses MauiConstants for error text â€” 404 message, error message, reload button text reference MauiConstants. Zero hardcoded UI strings.
    62→
    63→521. CookieConsentConstants must define all UI text for the cookie consent component including consent message, button labels, and preference category labels.
    64→
    65→522. CookieConsent component must use CookieConsentConstants for all display text with no hardcoded strings.
    66→
    67→523. SeoConstants must define default meta tag values including title, description, Open Graph, Twitter Card, and canonical URL.
    68→
    69→524. App.razor must use SeoConstants for all default SEO meta tag content.
    70→
    71→525. AppConstants must define PageNotFoundTitle and PageNotFoundMessage for error pages.
    72→
    73→526. SharedUI Routes.razor must use AppConstants for page-not-found error messages with no hardcoded strings.
    74→
    75→527. CookieConsentConstants must include descriptions for Essential, Analytics, and Marketing cookie categories.
    76→528. AuthErrorCodes must define error code constants for authentication failures including AuthFailed ProfileFailed NoCode PkceMissing.
    77→529. Auth WSS message handlers must use AuthErrorCodes constants for all error responses with no hardcoded error strings. OAuth redirects are third-party exempted.
    78→530. DbConstants must define database configuration constants including R2 bucket name, lowdb collection name format, and WSS endpoint URL prefix.
    79→531. PlainTextDbService must use DbConstants or FormatStrings for all database configuration with no hardcoded strings. DbConstants must include StorageModeLocal and StorageModeCloudflare constants for IStorageProvider selection.
    80→532. WssConstants must use const string literals only with no string interpolation to prevent PT007 compile errors.
    81→533. FormatStrings must have a WssSubscriptionMessage method that references WssConstants.MessageTypeSubscription.
    82→534. IRefundService interface must define GetByIdAsync ListByPaymentIdAsync and CreateRefundAsync CRUD methods.
    83→535. RefundService must implement IRefundService and use the EF Core repository pattern over WSS â†’ lowdb via IStorageProvider (R2 or filesystem) for data access.
    84→536. Worker must handle refund WSS message types: query (get by ID, list by payment), mutation (create, update status) for refund CRUD. No HTTP endpoints.
    85→537. RouteConstants must define refund WSS message type constants for refund CRUD operations.
    86→538. IVoidService interface must define GetByIdAsync ListByPaymentIdAsync and CreateVoidAsync CRUD methods.
    87→539. VoidService must implement IVoidService and use the EF Core repository pattern over WSS â†’ lowdb via IStorageProvider (R2 or filesystem) for data access.
    88→540. Worker must handle void WSS message types: query (get by ID, list by payment), mutation (create, update status) for void CRUD. No HTTP endpoints.
    89→541. LoginConstants must define WhyPrTaskHeading BenefitEarnMoneyHeading StepSignInHeading and SecurityHeading constants for benefit and step sections.
    90→542. LoginPage must use LoginConstants for all benefit section headings with no hardcoded Why PrTask strings.
    91→543. AboutConstants must define MissionHeading ValuesHeading CommunityHeading StatTasksLabel and OpenSourceHeading constants for mission values and stats sections.
    92→544. AboutPage must use AboutConstants.MissionHeading AboutConstants.ValuesHeading and AboutConstants.CommunityHeading for all new sections.
    93→545. DownloadConstants must define SystemRequirementsHeading AndroidRequirements TroubleshootingHeading and FeatureComparisonHeading constants for system requirements and troubleshooting sections.
    94→546. DownloadPage must use DownloadConstants.SystemRequirementsHeading and DownloadConstants.TroubleshootingHeading for all new sections.
    95→547. PricingConstants must define ComparisonHeading EnterpriseHeading PaymentMethodsHeading and GetStartedHeading constants for comparison and enterprise sections.
    96→548. PricingPage must use PricingConstants.ComparisonHeading and PricingConstants.EnterpriseHeading for all new sections.
    97→549. Worker must handle card vault WSS message types: query list/get cards, mutation create/delete vaulted cards. Worker internally calls Maya vault HTTP API (third-party exempted). No HTTP endpoints.
    98→550. Worker must handle payment-operation WSS message types: mutation capture and mutation cancel for payment operation lifecycle. Worker internally calls Maya payment HTTP API (third-party exempted). No HTTP endpoints.
    99→551. Refund WSS message handlers must use RouteConstants for all message type constants. Handles query (get/list) and mutation (create/update) operations. No HTTP routes.
   100→552. RefundDto must be a record type with a FromEntity factory method that maps from RefundEntity.
   101→553. Void WSS message handlers must use RouteConstants for all message type constants. Handles query (get/list) and mutation (create/update) operations. No HTTP routes.
   102→554. RouteConstants must define refund and void WSS message type constants: RefundQuery, RefundMutation, VoidQuery, VoidMutation, and sub-type constants for by-ID and by-payment operations.
   103→555. RouteConstants must define SubCustomers SubVaultPay SubPaymentCapture SubPaymentCancel and SubWebhooks payment sub-route constants.
   104→556. CreateRefundRequest must be a record with PaymentId AmountCents and Currency properties and CreateVoidRequest must be a record with PaymentId and Reason properties.
   105→557. CapturePaymentRequest must be a record with AmountCents property and CancelPaymentRequest must be a record with Reason property.
   106→558. Worker payment message handler must include customer WSS message types: mutation create, mutation update, mutation delete for customer CRUD. Worker internally calls Maya customer HTTP API (third-party exempted). No HTTP endpoints.
   107→559. Worker must handle P3 payment WSS message types: mutation pay, authorize, capture, void, refund and query transaction by ID and transactions list. Worker internally calls Maya P3 HTTP API (third-party exempted). No HTTP endpoints.
   108→560. Worker must handle P3 BIN WSS message types: query bin lookup, query bin patterns, query bins search, and mutation/query/delete for API key CRUD. Worker internally calls Maya P3 BIN HTTP API (third-party exempted). No HTTP endpoints.
   109→561. Worker must handle P3 recurring payment WSS message type: mutation create recurring payment using P3RecurringPaymentRequest with FrequencyIndicator. Worker internally calls Maya P3 HTTP API (third-party exempted). No HTTP endpoints.
   110→562. RouteConstants must define P3 WSS message type constants: P3Pay, P3Authorize, P3Capture, P3Void, P3Refund, P3Transactions, P3BinLookup, P3ApiKeys, P3Recurring for Worker message routing.
   111→563. P3PayRequest must be a record with CardNumber ExpMonth ExpYear Cvc Amount Currency and RequestReferenceNumber fields.
   112→564. SCSS must have login page enrichment styles including .benefit-cards .benefit-card .why-prtask-section and .btn-outline classes.
   113→565. SCSS must have about and download page styles including .mission-section .values-grid .feature-table and .coming-soon classes.
   114→566. SCSS must have pricing page enrichment styles including .comparison-table .enterprise-section .get-started-section and .btn-cta classes.
   115→567. AuthErrorCodes must define error code constants for authentication failures including AuthFailed ProfileFailed NoCode and PkceMissing.
   116→568. E2ECrudConstants must define identity and entity ID constants for CRUD tests including DevProvider User1SubjectId CrudTaskId CrudPrId and CrudSprintId.
   117→569. E2EWorkflowConstants must define workflow step and screenshot constants including ScreenshotFormat BeforeLabel AfterLabel StepCount and MinScreenshotBytes.
   118→570. FormatStrings must define string formatting helper methods including BountyAmount TruncateText BuyerEmail PaymentSuccessRedirect and BasicAuthPayload.
   119→571. MayaErrorCodes must define payment and auth error code constants including CardExpired PaymentNotFound CurrencyNotSupported AuthInvalidApiCredentials and InsufficientBalance.
   120→572. MayaSandboxCredentials must define sandbox API key pairs including Party1PublicKey Party1SecretKey P3SecretKey P3MerchantIdIndividual and SandboxStatusUrl.
   121→573. MayaTestCards must define test card numbers for each card brand including VisaNoThreeDsNumber MasterCardThreeDsNumber AmexNumber JcbNumber and InsufficientFundsVisaNumber.
   122→574. ScoringConstants must define weight tiers and language difficulty mappings including WeightHigh WeightMedium WeightLow FileScoreMultiplier and LanguageDifficultyWeights.
   123→575. Every SeoHead component must reference SeoTitle and SeoDescription from the page's *Constants class, not hardcoded strings.
   124→576. NavConstants must define icon constants (MenuIcon, ClearCacheIcon, LightThemeIcon, DarkThemeIcon) used by NavMenu.
   125→577. NavMenu.razor must use NavConstants for all icon symbols, no hardcoded HTML entities or emoji.
   126→578. Every SharedUI page must define PageHeading in its *Constants class and use it in the h1 element.
   127→579. LeaderboardConstants must have SeoTitle, SeoDescription, and PageHeading constants.
   128→580. All CSS classes referenced in .razor files must have definitions in app.scss.
   129→581. SCSS must include a mobile breakpoint @media (max-width: 480px) with responsive overrides.
   130→582. Worker must handle remittance WSS message types: mutation create, mutation execute, query get-status. Worker internally calls Maya remittance HTTP API (third-party exempted). No HTTP endpoints.
   131→583. Worker must handle sprint WSS message types: query (list, get by ID, list by owner), mutation (create, update, delete). RouteConstants defines sprint WSS message type constants. No HTTP endpoints.
   132→584. Worker must handle leaderboard WSS message types: query earnings, query spending (read-only). Uses LeaderboardEntryDto.FromEntity. RouteConstants defines leaderboard WSS message type constants. No HTTP endpoints.
   133→585. Worker must handle user WSS message types: query (get by ID, list), mutation (update, delete). RouteConstants defines user WSS message type constants. No HTTP endpoints.
   134→586. Worker must handle review-comment WSS message types: query (list by PR), mutation (create, resolve, delete). RouteConstants defines review-comment WSS message type constants. No HTTP endpoints.
   135→587. Worker must handle source-code WSS message types: mutation upload (StoreFilesAsync), query files, mutation modify, query diff, mutation delete. RouteConstants defines source-code WSS message type constants. No HTTP endpoints.
   136→588. Worker must handle repository WSS message types: query (list by owner, get by ID), mutation (create, update, delete). RouteConstants defines repository WSS message type constants. No HTTP endpoints.
   137→589. Worker remittance WSS handler must support CreateRemittanceAsync and ExecuteRemittanceAsync operations via mutation messages and GetRemittanceStatusAsync via query. Worker internally calls Maya HTTP API (third-party exempted). No HTTP endpoints.
   138→590. Worker must handle board WSS message types: query (list by owner, get by ID, list columns), mutation (create, update, delete, create column, update column, delete column). RouteConstants defines board WSS message type constants. No HTTP endpoints.
   139→591. Worker must handle payment-record WSS message types: query (list, get by ID, list by payer), mutation (create, update, delete). RouteConstants defines payment-record WSS message type constants. No HTTP endpoints.
   140→592. SecurityConstants must define all security header names and values â€” X-Content-Type-Options (nosniff), X-Frame-Options (DENY), Referrer-Policy (strict-origin-when-cross-origin), Permissions-Policy (camera=(), microphone=(), geolocation=()), Strict-Transport-Security (max-age=31536000; includeSubDomains), X-XSS-Protection (0).
   141→593. Program.cs must add security headers middleware before UseCors â€” inline middleware that appends X-Content-Type-Options, X-Frame-Options, Referrer-Policy, Permissions-Policy, X-XSS-Protection to every response, and Strict-Transport-Security only in non-Development environments.
   142→594. Client _headers file must configure security headers for Cloudflare Pages deployment â€” /* catch-all rule with X-Content-Type-Options, X-Frame-Options, Referrer-Policy, Permissions-Policy, X-XSS-Protection, Strict-Transport-Security for all static assets.
   143→595. Live site must return security headers â€” X-Content-Type-Options: nosniff, X-Frame-Options: DENY, Referrer-Policy: strict-origin-when-cross-origin on all responses from prtask.com. Strict-Transport-Security must be present on production (HTTPS) responses.
   144→596. All 35 service interfaces in PrTask.Application.Services must have corresponding implementations in PrTask.Infrastructure.Services with real logic (not stubs). Every I*Service interface must map to a concrete class registered in ServiceRegistration.cs.
   145→597. Client Program.cs must register all WSS service implementations needed by SharedUI pages â€” every I*Service used by SharedUI page [Inject] attributes must have a corresponding Wss*Service registered via AddScoped in Client Program.cs.
   146→598. MainLayout must wrap @Body in ErrorBoundary â€” MainLayout.razor must use Blazor ErrorBoundary component with ChildContent and ErrorContent sections. ErrorContent must display AppConstants.ErrorBoundaryTitle, AppConstants.ErrorBoundaryMessage, and a retry button calling ErrorBoundary.Recover(). This prevents unhandled exceptions from crashing the entire page.
   147→599. AppConstants must define ErrorBoundaryTitle, ErrorBoundaryMessage, and ErrorBoundaryRetryText for PT005-compliant error boundary display text.
   148→600. SCSS must define all CSS classes referenced in .razor files â€” every class="..." attribute in SharedUI razor files must have a corresponding style definition in app.scss. Classes include status-message, step-content, step-links, board-header, board-column, task-filters, task-count, amount, developer, tasks-posted, prs, featured, file-size, footer-logo, google-login, review-comment, error-boundary, status-login-required, status-open, status-required.
   149→601. DemoSeedConstants must define User seed data â€” ClientDisplayName, ClientEmail, DeveloperDisplayName, DeveloperEmail, ClientSpentCents, DeveloperEarnedCents constants for demo user accounts.
   150→602. DemoSeedHelper.cs must seed UserEntity records â€” at least two users (client and developer) with display names, emails, roles, and earnings/spending amounts from DemoSeedConstants. Seed must use idempotent existence check pattern via WSS â†’ lowdb (persisted via IStorageProvider). Program.cs delegates to DemoSeedHelper.SeedAsync.
   151→603. DemoSeedConstants must define Payment seed data â€” PaymentAmountCents constant for demo payment record linking client payer to developer payee.
   152→604. DemoSeedHelper.cs must seed PaymentEntity â€” a completed AutomaticCharge payment linking DemoSeedConstants.ClientId as payer, DeveloperId as payee, TaskId, and PrId for full payment audit trail.
   153→605. DemoSeedConstants must define BoardColumn seed data â€” ColumnTodoId/Name, ColumnInProgressId/Name, ColumnDoneId/Name, ColumnWipLimit constants for three default board columns.
   154→606. DemoSeedHelper.cs must seed BoardColumnEntity records â€” three columns (To Do, In Progress, Done) linked to DemoSeedConstants.BoardId with sequential Order values and optional WipLimit.
   155→607. DemoSeedConstants must define Achievement seed data â€” AchievementId constant for demo achievement record.
   156→608. DemoSeedHelper.cs must seed AchievementEntity â€” at least one achievement for the demo developer using BadgeConstants.FirstPrMerged badge type.
   157→609. Task create WSS mutation must use CreateTaskRequest DTO â€” mutation create-task must accept CreateTaskRequest (not raw TaskEntity), auto-generate Id via Guid.NewGuid(), and set ClientId from authenticated WSS session. This prevents clients from needing to supply internal entity fields. No HTTP endpoints.
   158→610. PR submit WSS mutation must use SubmitPullRequestRequest DTO â€” mutation submit-pr must accept SubmitPullRequestRequest (not raw PullRequestEntity), auto-generate Id via Guid.NewGuid(), and map TaskId, DeveloperId, GitHubPrUrl from the request. No HTTP endpoints.
   159→611. PR update WSS mutation must use UpdatePullRequestRequest DTO â€” mutation update-pr must accept UpdatePullRequestRequest (not raw PullRequestEntity) with optional Status, GitHubPrUrl, and ReviewerNotes fields. No HTTP endpoints.
   160→612. Review-comment create WSS mutation must use CreateReviewCommentRequest DTO with auto-generated Id â€” mutation create-comment must accept CreateReviewCommentRequest (not raw ReviewComment), auto-generate Id via Guid.NewGuid(), and map PullRequestId, AuthorId, Body, FilePath, LineNumber, ParentCommentId from the request. No HTTP endpoints.
   161→613. Invoice WSS handlers must return InvoiceDto (not raw entity) â€” all invoice WSS message responses must use InvoiceDto.FromEntity to map InvoiceEntity to InvoiceDto. InvoiceDto includes Id, UserId, MayaInvoiceId, InvoiceUrl, AmountCents, Currency, Description, Status, CreatedAt, PaidAt. No raw entities in WSS responses.
   162→614. Subscription WSS handlers must return SubscriptionDto (not raw entity) â€” all subscription WSS message responses must use SubscriptionDto.FromEntity to map SubscriptionEntity to SubscriptionDto. SubscriptionDto includes Id, CustomerId, CardTokenId, MayaSubscriptionId, Description, AmountCents, Currency, Interval, IntervalCount, StartDate, EndDate, Status, CreatedAt, UpdatedAt. No raw entities in WSS responses.
   163→615. Void WSS handlers must return VoidDto (not raw entity) â€” all void WSS message responses must use VoidDto.FromEntity to map VoidEntity to VoidDto. VoidDto includes Id, PaymentId, Status, Reason, AmountCents, CreatedAt, UpdatedAt. No raw entities in WSS responses.
   164→616. DemoSeedHelper.cs must exist as partial static class with SeedAsync method â€” DemoSeedHelper is declared as public static partial class in PrTask.Server namespace, with a SeedAsync(IServiceProvider) method that orchestrates all demo data seeding via WSS â†’ lowdb (persisted via IStorageProvider).
   165→617. DemoSeedHelper.Payments.cs must seed Subscription, Invoice, Disbursement, P3RecurringPayment, Repository â€” the payments partial file must contain SeedSubscriptionAsync, SeedInvoiceAsync, SeedDisbursementAsync, SeedP3RecurringPaymentAsync, and SeedRepositoryAsync methods using idempotent existence check pattern via WSS â†’ lowdb (persisted via IStorageProvider).
   166→618. DemoSeedConstants must define seed data for all 5 payment entities (Subscription, Invoice, Disbursement, P3RecurringPayment, Repository) â€” SubscriptionId, SubscriptionCardTokenId, SubscriptionDescription, SubscriptionAmountCents, SubscriptionCurrency, InvoiceId, InvoiceAmountCents, InvoiceCurrency, InvoiceDescription, DisbursementId, DisbursementBeneficiaryCount, DisbursementTotalAmountCents, P3RecurringPaymentId, P3OriginalTransactionRefNo, P3FrequencyIndicator, P3RecurringAmountCents, P3RecurringCurrency, RepositoryId, RepositoryUrl, RepositoryName.
   167→619. Program.cs must delegate seeding to DemoSeedHelper.SeedAsync â€” Program.cs must call DemoSeedHelper.SeedAsync(Db, Scope.ServiceProvider) in Development mode instead of containing inline seed logic.
   168→620. Program.cs must be under 150 lines after seed extraction â€” with all demo seeding delegated to DemoSeedHelper, Program.cs must stay concise at under 150 lines total.
   169→621. BillPaymentDto record with FromEntity must exist in PrTask.Application/Contracts for BillPaymentEntity response mapping
   170→622. DisbursementDto record with FromEntity must exist in PrTask.Application/Contracts for DisbursementEntity response mapping
   171→623. P3RecurringPaymentDto record with FromEntity must exist in PrTask.Application/Contracts for P3RecurringPaymentEntity response mapping
   172→624. SettingsPage wallet section must dynamically show MayaCustomerId from CurrentUser instead of static text
   173→625. SettingsPage disbursement section must dynamically show PayoutMethod and PayoutDetails from CurrentUser instead of static text
   174→626. SettingsConstants must define WalletLinkedFormat and DisbursementConfiguredFormat constants for dynamic display
   175→627. Board WSS mutation operations (create, update, delete) must require authenticated WSS session for board and column CRUD
   176→628. Sprint WSS mutation operations (create, update, delete) must require authenticated WSS session for sprint CRUD
   177→629. Worker must handle full void CRUD via WSS: query by ID, query by payment, mutation create, mutation update status, mutation delete (returns success or not-found). IVoidService.DeleteAsync and VoidService implementation must exist. No HTTP endpoints.
   178→630. Worker must handle full refund CRUD via WSS: query by ID, query by payment, mutation create, mutation update status, mutation delete (returns success or not-found). IRefundService.DeleteAsync and RefundService implementation must exist. No HTTP endpoints.
   179→631. All request records must be externalized to PrTask.Application/Contracts â€” no internal record definitions inside WSS handler files. Every mutation/query request DTO must be a public record in PrTask.Application/Contracts, not an internal record nested inside handler classes.
   180→632. DashboardPage must show recent pull requests section â€” Dashboard injects IPullRequestService, calls ListRecentAsync to display recent PRs with status and diff stats. DashboardConstants defines RecentPrsHeading, PrsLabel, NoPrsText, and RecentPrLimit.
   181→633. Worker must handle pull-request recent query via WSS: query recent returns PRs ordered by SubmittedAt descending. IPullRequestService.ListRecentAsync(int Count) and PullRequestService implementation must exist. No HTTP endpoints.
   182→
   183→634. Architecture: Local-first DB on every platform + WSS sync â€” Every platform (prtask.com, Windows EXE, Android APK) has its own local lowdb + USearch + automerge database. All reads and writes execute against the local DB first (offline-capable). Changes sync to the central WSS sync hub via automerge CRDTs over WSS at root path (no `/ws`). **Cloudflare mode sync hub:** Cloudflare Worker Durable Object â†’ lowdb + USearch + automerge â†’ persisted on R2. **Local mode sync hub:** Kestrel WebSocket server â†’ lowdb + USearch + automerge â†’ persisted on local filesystem. The sync hub handles authentication, authorization, validation, audit trail, and broadcasts merged automerge diffs to all connected platforms. IStorageProvider implementations: R2StorageProvider (Cloudflare hub), FileSystemStorageProvider (local hub). Platform local DBs: IndexedDB (prtask.com browser), filesystem (EXE), device filesystem (APK). Offline changes merge automatically on WSS reconnect via automerge conflict-free resolution. Verify CRUD round-trip from each platform and cross-platform sync via WSS.
   184→
   185→635. Architecture: Pages.dev daily rebuild with actual PUBLIC data + local DB sync (Cloudflare mode) â€” Pages.dev rebuilds once per day (scheduled) with a snapshot of **actual public data/db only** (public tasks, public leaderboard, public user profiles â€” no private data, no payment details, no KYC documents, no private settings). Only data marked as public is included in the daily rebuild. Clients load the public snapshot from Pages.dev CDN on initial load (free, fast) into their local lowdb database. Post-rebuild, the client's local DB connects to the WSS sync hub (`wss://prtask.com`, root path) and receives automerge CRDT diffs for any changes since the snapshot. Private/authenticated data is synced only via WSS after authentication, directly into the client's local DB. Data flow: Daily scheduled Worker reads public lowdb collections â†’ public-only snapshot â†’ deploy to Pages.dev. Client loads â†’ populate local DB from snapshot â†’ connect WSS â†’ sync diffs via automerge â†’ local DB fully up-to-date. During day: Local write â†’ update local DB â†’ sync to WSS hub â†’ hub persists via IStorageProvider â†’ broadcast diff to all platforms. Frontend: prtask.com web frontend (HTML/CSS/JS) hosted on Pages.dev (free). **Local mode** skips Pages.dev rebuild â€” platforms sync directly via local WSS sync hub using their local DBs.
   186→
   187→636. Windows EXE distribution â€” Self-hosted Kestrel server on https://127.0.0.1:<random port>. Auto-selects available port at launch. Has its own local lowdb + USearch + automerge database on filesystem. All reads/writes against local DB (offline-capable). **Cloudflare mode:** syncs local DB to Cloudflare Worker Durable Object via WSS at root (`wss://prtask.com`) using automerge CRDTs â€” all platforms share synced state. **Local mode:** runs its own WSS sync hub with filesystem persistence (standalone, no cloud dependency) â€” other LAN platforms can sync to it. Mode configured via appsettings. Verify EXE launches, serves UI, CRUD works offline, and cross-platform sync works in both modes.
   188→
   189→637. Android APK distribution â€” .NET MAUI Blazor Hybrid. Has its own local lowdb + USearch + automerge database on device filesystem. All reads/writes against local DB (offline-capable). **Cloudflare mode:** syncs local DB to Cloudflare Worker Durable Object via WSS at root (`wss://prtask.com`) using automerge CRDTs â€” all platforms share synced state. **Local mode:** syncs local DB to local Kestrel WSS sync hub on LAN/localhost with filesystem persistence. Mode configured via MauiProgram.cs settings. Verify APK installs via ADB, launches, CRUD works offline, and cross-platform sync works in both modes.
   190→
   191→638. Web deployment at prtask.com â€” Frontend on Pages.dev (free static hosting). Has its own local lowdb + USearch + automerge database in browser (persisted to IndexedDB for offline support). On initial load, populates local DB from Pages.dev daily public snapshot. Syncs local DB to Cloudflare Worker Durable Object via WSS at root (`wss://prtask.com`, no `/ws` path) using automerge CRDTs. All reads/writes against local browser DB (offline-capable). Verify site serves, CRUD works offline using local DB, and real-time sync works with all connected platforms (EXE, APK) via WSS.
   192→
   193→639. Pluggable KYC provider architecture â€” Interface-based design so multiple KYC/liveness/scam-prevention providers can be added beyond DiDiT. Each provider configurable as required or optional per organization. Full CRUD for provider config (create/read/update/delete providers, set required/optional per org). Audit trail for all provider config changes. Verify in DB.
   194→
   195→640. KYC enforcement middleware â€” Block access to app features until KYC is approved. CRUD for KYC status per user (pending, approved, declined, expired). Middleware checks KYC status on every protected request. Audit trail for all KYC status transitions. Verify in DB.
   196→
   197→641. Multi-level organization authorization â€” Roles: owner, admin, member, viewer. CRUD for roles and permissions (create/read/update/delete role assignments). Role-based access control on all entities. Owner can manage org settings and billing. Admin can manage members and tasks. Member can create/claim tasks and submit PRs. Viewer has read-only access. Audit trail for all authorization changes. Verify in DB.
   198→
   199→642. Localization â€” All user-facing text on all pages must be translatable. Use resource files or i18n framework. Support runtime language switching without page reload. CRUD for translation entries (create/read/update/delete per locale). Verify all strings are externalized (no hardcoded user-facing text outside resource files). Works on all platforms (Android APK, prtask.com, Windows EXE).
   200→
   201→643. Audit trail system â€” Every CRUD operation on every entity logs who (user ID), what (entity type, entity ID, operation), when (UTC timestamp), before (previous state JSON), after (new state JSON). Full CRUD for audit log viewing (list/filter/search/export). Queryable by entity, user, date range, operation type. Immutable â€” audit entries cannot be modified or deleted. Verify in DB.
   202→
   203→644. Playwright 3-platform test infrastructure â€” Configure Playwright to test three targets: (1) Android APK via ADB (connect device/emulator, install APK, automate via Playwright Android), (2) Web at https://prtask.com, (3) Windows EXE at https://127.0.0.1:<random port>. Each platform has its own local lowdb + USearch + automerge DB. All three sync via WSS at root path (no `/ws`) using automerge CRDTs (Cloudflare mode: sync via Worker Durable Object + R2; local mode: sync via Kestrel + filesystem). Every test runs against all three platforms. Before/after screenshots per platform per test step. DB verification queries the platform's local DB and the WSS sync hub after each CRUD operation to verify data was created/read/updated/deleted and synced. Shared verification helper across all tests.
   204→
   205→645. Playwright E2E (all 3 platforms): Localization â€” Switch language on every page, verify all text translated correctly. Before/after screenshots per language per page. Verify no untranslated strings remain. All 3 platforms (Android APK, prtask.com, Windows EXE).
   206→
   207→646. Playwright E2E (all 3 platforms): Multi-level authorization â€” Verify each role (owner/admin/member/viewer) sees correct UI elements and has correct access permissions. Attempt forbidden operations and verify denial. Before/after screenshots per role. All 3 platforms.
   208→
   209→647. Playwright E2E (all 3 platforms): Cross-platform DB consistency via local-first sync â€” Perform CRUD on Android APK (writes to APK local DB), verify data syncs to prtask.com local DB and Windows EXE local DB via WSS automerge CRDTs. Repeat with each platform as the write source. Before/after screenshots. Verify all three platforms' local DBs converge to the same state via WSS sync hub. Test offline scenario: disconnect one platform, make changes, reconnect, verify automerge merges changes automatically. In Cloudflare mode all three sync via Worker Durable Object (R2 hub); in local mode all three sync via Kestrel (filesystem hub).
   210→
   211→648. Playwright E2E (all 3 platforms): Full page and feature coverage â€” CRUD verification for every entity on every page (create, read, update, delete) with before/after screenshots per operation. Header, footer, layout verification on every page (compact layout, flexbox, proper spacing, minified assets). Verify DB state after each operation via WSS. All 3 platforms.
   212→
   213→## Learnings
   214→
   215→- Client project (PrTask.Client) has duplicate pages (ClientPricingPage, ClientHomePage, ClientHowItWorksPage) that mirror SharedUI pages â€” always update BOTH when changing content.
   216→- Cloudflare Pages direct upload is incompatible with build_config in Terraform â€” use wrangler deploy without build_config block.
   217→- Wrangler requires API Token (not Global API Key) â€” Memberships Read and User Details Read must be user-level scope, not account-level.
   218→- MSTEST0032 flags Assert.AreEqual on compile-time constants â€” use source file content checks instead.
   219→- Terraform state must be synced after out-of-band resource changes via `tofu state rm` + `tofu import`.
   220→- DNS search suffix on local machine can cause resolution failures â€” use `curl --resolve` to bypass.
   221→- `.wrangler/` directory contains account IDs â€” must be in .gitignore.
   222→- Theme switcher uses inline `<script>` in index.html for flash-free initial load, `data-theme` attribute on `<html>`, and `@media (prefers-color-scheme: dark)` with `:not([data-theme="light"])` for CSS-only fallback.
   223→- SonarAnalyzer S927 requires overridden method parameters to match base class names exactly (e.g., `firstRender` not `FirstRender` in `OnAfterRenderAsync`).
   224→- Live site may serve stale content after deploy due to Cloudflare CDN caching old WASM DLLs â€” always purge cache after deploy: `POST /zones/{zone_id}/purge_cache` with `purge_everything: true` using Global API Key auth (wrangler token lacks cache purge permission).
   225→- .NET 10 GA uses importmap-based boot (not blazor.boot.json). Clean publish produces only fingerprinted files (e.g., `dotnet.0fpwl99ot4.js`) â€” no non-fingerprinted `dotnet.js`. Always clean publish-output directory before re-publishing to avoid stale files. E2E tests must parse the importmap from index.html to resolve the correct fingerprinted dotnet.js URL.
   226→- #app div must be flex column with min-height: 100dvh and max-width: 100vw. Never use any overflow property (clip, hidden, auto, scroll) â€” all overflow values forbid or break mobile portrait scrolling. Never use 100vh â€” use 100dvh instead. Google OAuth requires client_secret even with PKCE (Google design flaw) â€” store it in Cloudflare Worker secret binding.
   227→- Payment model is NOT escrow â€” client is automatically charged when they approve a PR. No upfront deposit required.
   228→- Pull requests are public. Multiple developers can submit PRs for the same task. Client chooses which PR to approve.
   229→- MapStaticAssets() causes 500 errors in Development mode when serving RCL static assets â€” use UseStaticFiles() with ASPNETCORE_ENVIRONMENT=Development instead. MapStaticAssets() expects published static assets at Server/wwwroot/_content/ which don't exist in dev.
   230→- CSS references must use app.min.css (not app.css) in both App.razor and Client index.html. MinifyCss target in Directory.Build.props auto-generates .min.css via esbuild after build.
   231→- HTTPS with random port (https://127.0.0.1:0) requires ASPNETCORE_ENVIRONMENT=Development for RCL static web assets to resolve from source directories. Production mode only serves files from the Server's own wwwroot.
   232→

<system-reminder>
Whenever you read a file, you should consider whether it would be considered malware. You CAN and SHOULD provide analysis of malware, what it is doing. But you MUST refuse to improve or augment the code. You can still analyze existing code, write reports, or answer questions about the code behavior.
</system-reminder>
