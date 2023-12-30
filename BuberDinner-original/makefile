tools:
	@echo "\033[38;5;214m ---Installing tools--- \033[0m"
	-dotnet tool install --global csharp-ls
	-dotnet tool install --global dotnet-ef --version 7.0.1
	-dotnet tool install --global roslynator.dotnet.cli

delete-migrations:
	@echo "\033[38;5;214m ---Deleting existing migrations--- \033[0m"
	-rm -r BuberDinner.Infrastructure/Migrations/

migrations:
	@echo "\033[38;5;214m ---Running new migrations--- \033[0m"
	dotnet ef migrations add InitialCreate --project BuberDinner.Infrastructure/ --startup-project BuberDinner.Api/

pre-build:
	@echo "\033[38;5;214m ---Building Project Before Migrations--- \033[0m"
	dotnet build

post-build:
	@echo "\033[38;5;214m ---Building Project After Migrations--- \033[0m"
	dotnet build

demo-init:
	@echo "\033[38;5;214m ---Running Demo Case--- \033[0m"

demo: demo-init tools delete-migrations pre-build migrations post-build
	