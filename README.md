# Azure Function App C# Template (.NET 9.0)

This repository provides a starter template for building Azure Function Apps using C# and .NET 9.0. It includes a basic HTTP-triggered function.

## 📂 Project Structure

```
AzureFunctionApp-CSharpTemplate/
├── .github/
│ └── workflows/ # GitHub Actions workflows
├── Properties/ # Project properties
├── .gitignore # Git ignore rules
├── AzureFunctionApp-CSharpTemplate.csproj # Project file
├── AzureFunctionApp-CSharpTemplate.sln # Solution file
├── HttpTrigger_Prototype.cs # Sample HTTP-triggered function
├── Program.cs # Main program entry
└── host.json # Azure Functions host configuration
```

## 🛠 Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [Azure Functions Core Tools](https://learn.microsoft.com/azure/azure-functions/functions-run-local)
- [Azure CLI](https://learn.microsoft.com/cli/azure/install-azure-cli) (optional, for deployment)
- An active [Azure subscription](https://azure.microsoft.com/free/)

## 🧪 Getting Started

1. **Clone the repository**:

```bash
git clone https://github.com/adrianmuzzi/AzureFunctionApp-CSharpTemplate.git
cd AzureFunctionApp-CSharpTemplate
```

**2. Restore Dependencies**

```bash
dotnet restore
```

**3. Run Locally (For Dev)**
```
func start
```
The function will be accessible at http://localhost:7071/api/HttpTrigger_Prototype

## 🚀 Deployment

To deploy the function to Azure, first login via the Azure CLI:

```bash
az login
```
Create a Resource Group
```
az group create --name MyResourceGroup --location <YourPreferredLocation>
```
Create a Storage Account
```
az storage account create --name <YourStorageAccountName> --location <YourPreferredLocation> --resource-group MyResourceGroup --sku Standard_LRS
```
Create the Function App
```
az functionapp create \
  --resource-group MyResourceGroup \
  --consumption-plan-location <YourPreferredLocation> \
  --runtime dotnet \
  --functions-version 4 \
  --name <YourFunctionAppName> \
  --storage-account <YourStorageAccountName>
```
And deploy your code:
```
func azure functionapp publish <YourFunctionAppName>
```
Then accessible at your endpoint:
```
https://<YourFunctionAppName>.azurewebsites.net/api/HttpTrigger_Prototype
```

### Testing the Function

Once deployed, you can test the function using tools like curl:
```
curl -X GET https://<YourFunctionAppName>.azurewebsites.net/api/HttpTrigger_Prototype?name=Azure
```
