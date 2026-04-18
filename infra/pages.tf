resource "cloudflare_pages_project" "prtask" {
  account_id        = var.cloudflare_account_id
  name              = "prtask"
  production_branch = "main"

  build_config {
    build_command   = "dotnet publish src/PrTask.Client/PrTask.Client.csproj -c Release -o output"
    destination_dir = "output/wwwroot"
  }

  deployment_configs {
    production {
      environment_variables = {
        MAYA_PUBLIC_KEY  = var.maya_public_key
        GITHUB_CLIENT_ID = var.github_client_id
        SITE_URL         = "https://prtask.com"
      }
    }
  }
}

resource "cloudflare_pages_domain" "root" {
  account_id   = var.cloudflare_account_id
  project_name = cloudflare_pages_project.prtask.name
  domain       = "prtask.com"
}

resource "cloudflare_pages_domain" "www" {
  account_id   = var.cloudflare_account_id
  project_name = cloudflare_pages_project.prtask.name
  domain       = "www.prtask.com"
}
