output "pages_url" {
  value = "https://${cloudflare_pages_project.prtask.subdomain}"
}

output "pages_project_name" {
  value = cloudflare_pages_project.prtask.name
}
