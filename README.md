# DevOpsProjekt

Projekt demonstracyjny realizowany w ramach zajęć **Cykl Życia i Narzędzia DevOps**.

Celem projektu jest zaprezentowanie pełnego cyklu życia aplikacji:
- planowanie pracy (backlog, issues),
- kontrola wersji (Git, Pull Request),
- ciągła integracja (CI),
- ciągłe wdrażanie (CD),
- wdrożenie do chmury (Azure App Service).

---

## Architektura
- Aplikacja: **.NET 8 Minimal API**
- Repozytorium: **GitHub**
- CI/CD: **GitHub Actions**
- Chmura: **Azure App Service**

---

## Endpointy API
- `GET /` – endpoint zdrowia aplikacji
- `GET /products` – przykładowe dane (lista produktów)

---

## Uruchomienie lokalne
```bash
dotnet restore
dotnet test
dotnet run --project DevOpsProjekt.Api

---

## Docker

Build:
```bash
docker build -t devopsprojekt-api .


Adres aplikacji:
https://devopsprojekt-kiepura-gydgbtgsbdcaerg6.francecentral-01.azurewebsites.net/