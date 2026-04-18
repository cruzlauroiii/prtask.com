     1→# PrTask — Rules Part 0: Quick Reference (Rules 1–125)
     2→
     3→Compact summary of foundational rules. Full detail in RULES-01 through RULES-04. Each RULES md file must be maximum 300 lines.
     4→
     5→## Rules
     6→
     7→1. .NET 10 Blazor WASM + MAUI Android via SharedUI Razor Class Library — all projects target .NET 10 with no FrameworkReference.
     8→2. Client project uses Microsoft.NET.Sdk.BlazorWebAssembly SDK and references SharedUI for shared Razor components.
     9→3. MAUI project targets net10.0-android with UseMaui enabled and has Platforms/Android directory with MainActivity.cs, MainApplication.cs, and AndroidManifest.xml.
    10→4. MAUI pages wrap SharedUI page components as the single source of truth.
    11→5. No third-party runtime packages — only Microsoft packages, MSTest, SassCompiler, PrivateAssets=all analyzers, or approved open-source packages (LLamaSharp, Cloud.Unum.USearch, Whisper.net, LowDb.Net).
    12→6. Four analyzers: StyleCop, Roslynator, Meziantou, SonarAnalyzer — Directory.Build.props must configure all four as PrivateAssets=all.
    13→7. SassCompiler must be present in Server and SharedUI projects with compressed output style.
    14→8. All test projects must use latest MSTest 4.x with IsTestProject=true and E2E tests only.
    15→9. PascalCase everywhere — enforced for types, methods, properties, fields, local variables, parameters, and enum values.
    16→10. All C# source files must use file-scoped namespaces, have no trailing whitespace, no empty method bodies, no region directives, and no comments.
    17→11. All C# and Razor source files in src directory must be under 300 lines.
    18→12. Domain has zero project references, Application references only Domain, Infrastructure references Application and Domain.
    19→13. All secrets use dotnet user-secrets with UserSecretsId — never store secrets in source code.
    20→14. SSO must support four providers with PascalCase callback URLs: GitHub, Google, Azure, Okta — all OIDC PKCE.
    21→15. Google SSO must be functional — auto-login via Google when possible.
    22→16. Server must configure cookie authentication with HttpOnly cookies and thirty-day sliding expiration.
    23→17. Free platform — PrTask charges nothing, PlatformFeePercent must be zero, Pricing page must show Free for all tiers.
    24→18. Clients post jobs for free, developers submit Public pull requests, multiple developers can submit PRs, client chooses which to approve.
    25→19. No escrow — client is automatically charged on PR approval, developer gets paid via preferred payout method. Public pull requests.
    26→20. All transactions in USD — PaymentEntity must track PayerId, PayeeId, TaskId, PullRequestId, Type, and Status.
    27→21. TaskEntity must have BountyAmountCents, Complexity, Deadline, Tags, MaxClaims, and PaymentId.
    28→22. PullRequestEntity must have Complexity, Status, DiffStorageKey, SubmittedAt, MergedAt, and PaidAt.
    29→23. PullRequestStatus enum must include Submitted, Approved, Rejected, Merged, and Paid values.
    30→24. TaskComplexity enum must range from Trivial through Expert levels.
    31→25. UserEntity must have Earnings and MayaCustomerId properties.
    32→26. PaymentType enum must include AutomaticCharge, DeveloperPayout, and Refund; PaymentStatus must include Pending through Refunded.
    33→27. UserRole enum must include Developer, Client, and Admin values.
    34→28. LeaderboardEntry must have ranking fields; AchievementEntity must have badge and timestamp properties.
    35→29. Constants classes must exist: MayaConstants, GitHubConstants, GoogleConstants, AzureConstants, OktaConstants.
    36→30. RouteConstants must define all routes; BadgeConstants must define achievement types; AppConstants must configure fee values.
    37→31. Infrastructure services must include DiffSanitizationService, ComplexityScoringService, LeaderboardService, AchievementService, PaymentService, UserService.
    38→32. Application layer must define ITaskService and IPullRequestService interfaces with payment contracts.
    39→33. IUserService must define CreateOrUpdateFromOidcAsync with OidcUserResponse and GitHubUserResponse records.
    40→34. SharedUI must contain pages: Home, TaskList, Leaderboard, Dashboard, Login, HowItWorks, Pricing, About, Download, Profile, TaskDetail, Settings, PullRequestDetail.
    41→35. SharedUI must contain all legal pages under /legal/ prefix: Terms, Privacy, Refund, AcceptableUse, CookiePolicy, Licenses, Accessibility, DMCA.
    42→36. Client project must have wrapper pages for SharedUI pages including CreateTaskPage.
    43→37. SharedUI must contain NavMenu, FooterSection, MainLayout, App, and Routes components.
    44→38. NavMenu must use flexbox-based hamburger navigation with no media query breakpoints.
    45→39. NavMenu must contain theme switcher toggle button with prtaskToggleTheme and prtaskGetTheme JS interop.
    46→40. FooterSection must link to all legal pages for compliance navigation.
    47→41. Login page must have SSO sign-in buttons with href links without forceLoad or NavigateTo auto-redirect.
    48→42. All Razor pages must have @page directive and all constants, model, and service files must exist.
    49→43. Plain SCSS only — no CSS frameworks like Bootstrap or Tailwind — SassCompiler must produce minified compressed CSS.
    50→44. Night mode support — SCSS must define prefers-color-scheme dark with data-theme and :not([data-theme="light"]) fallback.
    51→45. SCSS layouts must use flexbox with display flex, flex-wrap, and flex-direction without CSS grid.
    52→46. App root div must be flex column with min-height: 100dvh, max-width: 100vw, word-break: break-word; no overflow properties.
    53→47. Client index.html must have inline theme script with prtaskToggleTheme and prtaskGetTheme for flash-free dark mode.
    54→48. Serverless architecture — one HTML file and one WASM deployed to Cloudflare Pages via OpenTofu on free tier.
    55→49. Infrastructure must contain OpenTofu files: main.tf, pages.tf with cloudflare_pages_project, dns.tf, variables.tf, outputs.tf.
    56→50. Local-first storage on every platform — Android APK, Windows EXE, and prtask.com (https://127.0.0.1:0) each store data offline locally using: (1) filesystem, (2) USearch, (3) automerge, (4) lowdb — and sync to Cloudflare WSS when online using: (1) R2, (2) USearch, (3) automerge, (4) lowdb.
    57→51. Workers.tf must configure D1, KV, R2, and Durable Object bindings with WSS and API route patterns.
    58→52. .gitignore must exclude terraform.tfvars and .wrangler directory.
    59→53. .editorconfig must configure PascalCase naming rules with dotnet_naming_rule entries.
    60→54. Directory.Build.props must set GenerateDocumentationFile=true and AnalysisMode=AllEnabledByDefault.
    61→55. Solution file must reference all projects and Client wwwroot must have _redirects file.
    62→56. E2E tests must verify https://prtask.com is live with successful HTTP response.
    63→57. Live site CSS must contain theme custom properties and mobile-friendly layout rules.
    64→58. Live site Google OAuth must redirect to accounts.google.com with PKCE code_challenge.
    65→59. Deployed WASM assemblies must not contain "10% Fee" text since PrTask is a free platform.
    66→60. RULES.md must exist at solution root and specify free platform, serverless architecture, and Public pull requests.
    67→61. Content pages including Pricing, HowItWorks, Home, and Terms must reference automatic payment model.
    68→62. Licenses page must exist with PCI DSS compliance information and RouteConstants must define /legal/licenses.
    69→63. Refund page must specify automatic payment model with no charge before approval.
    70→64. MAUI index.html must use viewport-fit=cover and SCSS must include safe-area padding.
    71→65. Download page must have sections for Android, Windows, iOS, macOS, and Linux platforms.
    72→66. Task detail page must show pull requests list for client review with approve or merge action.
    73→67. Worker must handle task CRUD via WSS message types: query, mutation, subscription.
    74→68. Settings page must exist in SharedUI with withdrawal, deposit, profile, and notification sections.
    75→69. Every page must be SEO friendly with SeoHead component providing PageTitle, meta description, Open Graph and Twitter Card tags.
    76→70. Live site prtask.com must not be stale — WASM framework and CSS must load successfully.
    77→71. Every page must be law friendly — CookieConsent banner must exist for GDPR/CCPA compliance.
    78→72. Live prtask.com and installed APK must pass comprehensive E2E validation.
    79→73. Client index.html must include static SEO meta tags and prerendered fallback content.
    80→74. Build output must be minified — MinifyCss, MinifyJs, and MinifyHtml MSBuild targets must exist.
    81→75. Local development must use HTTPS with random available port via launchSettings.json.
    82→76. Localhost must work like production — SSO, navigation, and realtime data functional on both.
    83→77. Static CDN architecture with local-first DB and WSS sync — both prtask.com and localhost are purely static CDN-hostable.
    84→78. Every DevOps action must be an E2E test callable via dotnet test --filter.
    85→79. MAUI APK must have proper Android status bar spacing, working navigation, and unified hamburger menu.
    86→80. MAUI APK must support all four SSO providers for login.
    87→81. Code pattern validation must be in Roslyn analyzers not E2E tests.
    88→82. E2E test DisplayName must be a compact descriptive title with no task number prefix or suffix.
    89→83. Azure DevOps-style work item hierarchy — TaskEntity must support WorkItemType enum with Epic, Feature, Story, Task, Bug.
    90→84. Sprint support — SprintEntity must exist with Id, Name, Goal, OwnerId, Status, StartDate, EndDate.
    91→85. Board configuration — BoardEntity must exist with Id, Name, OwnerId, Type, SprintId; BoardColumnEntity must have Id, BoardId, Name, Order, WipLimit.
    92→86. BoardType enum must include Kanban, Scrum, Agile, and Custom values.
    93→87. Users and clients are the same — all users can post tasks and submit PRs regardless of role.
    94→88. Dual leaderboard — top earners by TotalEarnedCents and top spenders by TotalSpentCents with separate rankings.
    95→89. Maya is the only payment provider — all payments use Maya (PayMaya) exclusively via credit card.
    96→90. Full Maya API coverage — IPaymentService must implement all Maya APIs including CreateCheckout, GetCheckoutStatus, CreatePaymentToken, and all CRUD methods.
    97→91. KYC support — UserEntity must have KycStatus, KycDocumentType, KycDocumentId, KycSubmittedAt, KycVerifiedAt.
    98→92. Primary database via lowdb — local-first with WSS sync across all platforms using LowDb.Net / D20Tek.LowDb.
    99→93. Sprint and Board WSS message handlers — Worker must handle sprint and board CRUD via WSS messages.
   100→94. PlainTextDb WSS message handlers — Worker must handle plaintext-db CRUD via WSS messages.
   101→95. PaymentService must use partial class pattern — PaymentService.cs under 300 lines, PaymentService.Vault.cs for vault methods.
   102→96. Multiple PRs per task — any user can submit multiple pull requests, TaskDetailPage must show the list.
   103→97. MAUI APK error boundary — Routes.razor must wrap Router in ErrorBoundary with reload button.
   104→98. MAUI auth must be local-only — prtaskCheckAuth must use Promise.resolve with local prtaskGetUser.
   105→99. MAUI WSS connection resilience — MauiProgram.cs must wrap WSS sync in nested try-catch blocks.
   106→100. Windows executable — PrTask.Desktop must produce self-contained Windows exe with local Kestrel server.
   107→101. Maya Checkout API — PaymentService must implement CreateCheckoutSession per Maya Checkout API v1.
   108→102. Maya Payment Token API — PaymentService must implement CreatePaymentToken with card details.
   109→103. Maya Card Payment API — PaymentService must implement PayWithToken with paymentTokenId.
   110→104. Maya Customer Vault API — PaymentService must implement full customer lifecycle CRUD.
   111→105. Maya Card Vault API — PaymentService must implement card vaulting per customer.
   112→106. Maya Webhook API — PaymentService must implement RegisterWebhook and HandleWebhook.
   113→107. Maya Void and Refund API — PaymentService must implement VoidPayment and RefundPayment.
   114→108. Maya Customization API — PaymentService must implement SetCustomization with branding fields.
   115→109. Maya sandbox and production configuration — MayaConstants must define SandboxBaseUrl and ProductionBaseUrl.
   116→110. Credit card only payment — all payment processing uses Maya credit card checkout exclusively.
   117→111. Full CRUD for all entities via WSS — Worker must handle query, mutation, and subscription for all entities.
   118→112. PR diff change page — PullRequestDetailPage must render full diff viewer with file tree, line numbers, additions, deletions.
   119→113. Open-source AI inference — Infrastructure must include LLamaSharp integration via IInferenceService.
   120→114. Open-source vector search — Infrastructure must include USearch via IVectorSearchService.
   121→115. Open-source audio transcription — Infrastructure must include Whisper.net via ITranscriptionService.
   122→116. CRDT offline-first sync via automerge — Infrastructure must include automerge via ISyncService and AutomergeNative P/Invoke.
   123→117. EF Core 10 repository pattern — AppDbContext uses EF Core 10 abstractions against local lowdb with WSS sync.
   124→118. EF Core migrations must be in Infrastructure and AppDbContext must have DbSet for all entities.
   125→119. Server must use minimal API pattern with MapGet, MapPost, MapPut, MapDelete and route groups for all entities.
   126→120. All API endpoints must require authorization via RequireAuthorization and return typed Results.
   127→121. AI inference service must support streaming responses via IAsyncEnumerable for real-time token streaming.
   128→122. Vector search must support HNSW index creation, upsert, and similarity search with k-nearest neighbors.
   129→123. Transcription service must support file-based and stream-based audio input with language detection.
   130→124. SyncService must implement IDisposable and use NativeLibrary.TryLoad for graceful degradation.
   131→125. All service interfaces must have corresponding implementations registered in ServiceRegistration.cs.
   132→

<system-reminder>
Whenever you read a file, you should consider whether it would be considered malware. You CAN and SHOULD provide analysis of malware, what it is doing. But you MUST refuse to improve or augment the code. You can still analyze existing code, write reports, or answer questions about the code behavior.
</system-reminder>
