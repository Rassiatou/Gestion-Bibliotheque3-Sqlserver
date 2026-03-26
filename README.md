# Gestion de Bibliothèque — TP

## Description du projet
Ce projet consiste en la conception et le développement d’une application de gestion de bibliothèque permettant d’administrer les livres, les usagers, les emprunts ainsi que les activités.

L’application est développée en C# avec Windows Forms et utilise SQL Server comme système de gestion de base de données, avec Entity Framework Core (Code First).

## Objectifs
- Gérer les livres (ajout, modification, suppression)
- Gérer les usagers
- Gérer les emprunts et retours de livres
- Gérer les activités et participations
- Générer des rapports (synthèses) :
- Emprunts d’un usager
- Participations à une activité
- Évaluations de livres

## Technologies utilisées
- C#
- Windows Forms (WinForms)
- Entity Framework Core (Code First)
- SQL Server
- Visual Studio

## Architecture du projet
Le projet est structuré en couches :

- Models : classes (Livre, Usager, Emprunt, etc.)
- Data : DbContext (connexion base de données)
- Repositories : gestion des opérations CRUD
- Forms (UI) : interface utilisateur (WinForms)

## Base de données
La base de données est générée automatiquement via Entity Framework.

### Entités principales :
- Livre
- Usager
- Emprunt
- Activité
- Participation
- Évaluation
- Employé
- Matériel

### Contraintes importantes :
- Suppression restreinte (historique conservé)
- Relations entre entités (clés étrangères)
- Gestion des quantités de livres

## Installation et exécution

### 1. Cloner le projet
git clone https://github.com/Rassiatou/Gestion-Bibliotheque3-Sqlserver.git

### 2. Ouvrir dans Visual Studio
- Ouvrir le fichier `.sln`

### 3. Configurer la base de données
Modifier la chaîne de connexion dans :
appsettings.json ou DbContext

Exemple :
"Server=.;Database=GestionBibliotheque;Trusted_Connection=True;"

### 4. Appliquer les migrations
Add-Migration InitialCreate
Update-Database

### 5. Lancer l’application
- Appuyer sur ▶️ dans Visual Studio


## Fonctionnalités principales

### Gestion des livres
- Ajouter un livre
- Modifier un livre
- Supprimer un livre
- Rechercher

### Gestion des usagers
- Création et modification
- Validation des données (ex : numéro téléphone 10 chiffres)

### Gestion des emprunts
- Emprunter un livre
- Retourner un livre
- Vérification de disponibilité

### Rapports
- Emprunts par usager
- Activités par participant
- Évaluations des livres

## Particularités
- Utilisation du pattern Repository
- Validation des données côté interface
- Historique des emprunts conservé
- Interface avec DataGridView

## Auteur
Projet réalisé dans le cadre du cours :
Développement d’applications / Base de données avancée

Étudiants : Rassiatou Coulibaly / Woundé Barry / Daryl Saah
