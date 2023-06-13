# Introduction
This tool will be helpful for performing the following operations related to Azure Key Vault:

1. Inserts values from a given JSON file to Azure Key Vault.
2. Saves all the secrets from Azure Key Vault to a JSON file in the desired location.

# Prerequisites

Before running this application, ensure that you have the following prerequisites:
1. .NET Core SDK installed.
2. Azure subscription with access to Azure Key Vault.

# Running the Application

1. Open a terminal or command prompt and navigate to the project directory.
2. For inserting values from a given JSON file to Azure Key Vault:
   > `dotnet run --o Insert --f "<Path-to-file>" --u "<Key-vault-url>"`
3. For saving all the secrets from Azure Key Vault to a JSON file:
   > `dotnet run --o Export --f "<Path-to-file>" --u "<Key-vault-url>"`
4. For displaying help message:
   > `dotnet run --h`
