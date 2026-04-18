# PrTask

.NET 10 Blazor WASM + MAUI Android via SharedUI Razor Class Library (no FrameworkReference). SassCompiler build tool from NativeCdpBridge. No third-party runtime packages. PascalCase everywhere. SSO via GitHub OAuth, Google OIDC PKCE, Azure OIDC PKCE, Okta OIDC PKCE. Clients post jobs with bounties, developers claim tasks and submit PRs, payment scales by PR complexity on approval and merge. Pay and get paid via Maya Business (must pass Maya review). Leaderboard, earnings dashboard, XP, levels, streak, badges. Private source, public sanitized diffs. Copy linters, analyzers, .editorconfig, E2E architecture tests from C:\work\NativeCdpBridge (do not touch that repo). Four analyzers: StyleCop, Roslynator, Meziantou, SonarAnalyzer — all PrivateAssets=all. Latest MSTest 4.x. OpenTofu + Cloudflare free tier. Domain has zero project references. Application references only Domain. Infrastructure references Application and Domain. E2E tests only — no unit tests required. Work in C:\work\prtask.com.

## Shell

Always use Pwsh tool for all shell commands. If Pwsh unavailable, use Bash with: `"/c/Program Files/PowerShell/7-preview/pwsh.exe" -NoProfile -Command '...'`. NEVER run raw bash commands (head, cat, curl fail with exit code 127 on Windows).

## Code Style

PascalCase everywhere: C# properties, TypeScript variables/functions, API route paths, JSON on wire. No comments (PT004 analyzer). No magic strings — use constants in PrTask.Domain/Constants/ (PT005 analyzer). No comments in code.

## Git

Git objects stored at C:\Git\prtask.com (--separate-git-dir). Working tree at C:\work\prtask.com. NEVER push to master. Public branch must have exactly one commit (orphan force push). Delete all GitHub Actions after deploy. Always push master to backup remote after commits.

## Deploy Safety

NEVER run Remove-Item/rm on source tree root. Deploy scripts MUST only operate inside Public worktree (C:\work\prtask.com\Public\). Before any deletion: check for PrTask.sln and src/ — abort if found. Never run git checkout Public on main repo — use the worktree. Use Push-Location/Pop-Location, not cd. All Remove-Item must use -Exclude .git,.gitattributes.

## Deployment Architecture

prtask.com served via Cloudflare Worker (infra/cloudflare-worker/) proxying GitHub Pages. Worker rewrites base href="/prtask.com/" to base href="/". cruzlauroiii.github.io/prtask.com serves directly from Public branch. CNAME must NEVER be in Public branch. Service workers removed — replaced with self-unregistering stubs.

## Fingerprinting

PrTask.Fingerprint runs after dotnet publish via FingerprintHtml MSBuild target. Reads staticwebassets.endpoints.json, creates fingerprinted copies, replaces clean files with redirect stubs. Root index.html and 404.html redirect to en/index.<fingerprint>.html. Fingerprint hashes are content-based — matching hashes verify source is byte-for-byte identical.

## Execution

Run everything in parallel, use all CPU/RAM. All agents and commands in background. Never use TaskOutput to wait/block — notifications arrive automatically. Never output idle status messages about background tasks. Only speak when you have actionable results.

## Architecture (NON-NEGOTIABLE)

WSS gatekeeper, R2 storage, File System Access API local store, Service Worker + Cache API offline, Pages.dev daily snapshots, automerge diff patching, USearch vector search. NEVER substitute user's explicit architecture decisions with research-based alternatives.

## Recovery

Claude JSONL logs at ~/.claude/projects/ contain every file ever read/written. Recovery scripts at C:\work\prtask.com\recover*.ps1. Gap-fill via WASM DLL decompilation from Public branch using ILSpy at c:\work\ILSpy.
